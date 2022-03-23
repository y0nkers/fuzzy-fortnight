using System;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.Data.SqlClient;

namespace RGR
{
    public partial class FormMain : Form
    {
        private readonly SqlConnection _connection;
        public FormMain()
        {
            InitializeComponent();
            _connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=Constellations;Integrated Security=True");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            constellationsTableAdapter.Fill(constellationsDataSet.Constellations);
            constellationsDataGridView.ResetBindings();
        }

        private void constellationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (textBoxRussianTitle.Text == "" || textBoxLatinTitle.Text == "" || textBoxAbbreviation.Text == "" || numericUpDownArea.Value == 0 || numericUpDownBrigther6m.Value == 0)
            {
                MessageBox.Show("Не все обязательные поля были введены!", "Ошибка при сохранении.");
            }
            else
            {
                try
                {
                    Validate();
                    constellationsBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(constellationsDataSet);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("RussianTitle_UniqueIndex")) MessageBox.Show("Созвездие с таким русским названием уже существует!", "Ошибка при добавлении.");
                    else if (ex.Message.Contains("LatinTitle_UniqueIndex")) MessageBox.Show("Созвездие с таким латинским названием уже существует!", "Ошибка при добавлении.");
                    else if (ex.Message.Contains("Abbreviation_UniqueIndex")) MessageBox.Show("Созвездие с таким сокращением уже существует!", "Ошибка при добавлении.");
                    else MessageBox.Show("Произошла ошибка при добавлении.", "Ошибка при добавлении");
                }
            }
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += ParseHtml;
            worker.RunWorkerCompleted += FormMain_Load;
            worker.RunWorkerAsync();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ParseHtml(object sender, DoWorkEventArgs e)
        {
            int count = 0;
            toolStripLabelStatus.Text = "Подождите, идёт загрузка... Это может занять некоторое время...";
            HtmlWeb webGet = new HtmlWeb();
            string html = "https://spacegid.com/constellations";
            var document = webGet.Load(html);

            HtmlNode table = document.DocumentNode.SelectSingleNode("//table[@class='cozf123']"); // Получаем таблицу со всеми созвездиями.
            HtmlNodeCollection rows = table.SelectNodes(".//tr");
            foreach (HtmlNode row in rows)
            {
                if (row != rows.First())
                {
                    HtmlNodeCollection columns = row.SelectNodes(".//td");
                    Constellation constellation = new Constellation();
                    HtmlNode russianTitle = columns[0].SelectSingleNode(".//a");
                    string htmlImage = russianTitle.Attributes["href"].Value;
                    constellation.RussianTitle = russianTitle.InnerText;
                    constellation.LatinTitle = columns[1].InnerText;
                    constellation.Abbreviation = columns[2].InnerText;
                    constellation.Area = Convert.ToInt32(columns[3].InnerText);
                    constellation.Brigther6m = Convert.ToInt32(columns[4].InnerText);
                    constellation.Photo = GetImage(htmlImage);

                    if (Constellation.Select(_connection, constellation.LatinTitle) == null)
                    {
                        toolStripLabelStatus.Text = $"Добавление созвездия {constellation.LatinTitle}...";
                        Constellation.Insert(_connection, constellation);
                        count++;
                    }
                }
            }
            toolStripLabelStatus.Text = $"Загрузка успешно завершена. Было добавлено {count} новых созвездий.";
        }

        private byte[] GetImage (string html)
        {
            try
            {
                HtmlWeb webGet = new HtmlWeb();
                var document = webGet.Load(html);

                HtmlNode imageNode = document.DocumentNode.SelectSingleNode("//div[@class='entry-content']//img");
                var request = WebRequest.Create(imageNode.Attributes["src"].Value);
                var response = request.GetResponse();
                byte[] image;
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        responseStream.CopyTo(memoryStream);
                        image = memoryStream.ToArray();
                    }
                }
                return image;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void constellationsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    if (row.Cells[0].Value != DBNull.Value) textBoxRussianTitle.Text = row.Cells[0].Value.ToString();
                    else textBoxRussianTitle.Text = null;
                    if (row.Cells[1].Value != DBNull.Value) textBoxLatinTitle.Text = row.Cells[1].Value.ToString();
                    else textBoxLatinTitle.Text = null;
                    if (row.Cells[2].Value != DBNull.Value) textBoxAbbreviation.Text = row.Cells[2].Value.ToString();
                    else textBoxAbbreviation.Text = null;
                    if (row.Cells[3].Value != DBNull.Value) numericUpDownArea.Value = Convert.ToInt32(row.Cells[3].Value);
                    else numericUpDownArea.Value = 0;
                    if (row.Cells[4].Value != DBNull.Value) numericUpDownBrigther6m.Value = Convert.ToInt32(row.Cells[4].Value);
                    else numericUpDownBrigther6m.Value = 0;
                    if (row.Cells[5].Value != DBNull.Value)
                    {
                        Byte[] data = (Byte[])(row.Cells[5].Value);
                        MemoryStream stream = new MemoryStream(data);
                        pictureBoxPhoto.Image = Image.FromStream(stream);
                    }
                    else pictureBoxPhoto.Image = null;
                }
            }
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(ofd.FileName);
                toolStripLabelStatus.Text = "Фотография успешно загружена!";
            }
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxPhoto.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Image Files(*.PNG;*.JPG)|*.PNG;*.JPG|All files (*.*)|*.*";
                sfd.DefaultExt = "jpg";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                    pictureBoxPhoto.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                    fs.Close();
                    toolStripLabelStatus.Text = "Фотография успешно сохранена!";
                }
            }
            else toolStripLabelStatus.Text = "Нет фотографии, сохранение невозможно.";
        }

        private void CyrillicCharsPressed(object sender, KeyPressEventArgs e)
        {
            char с = e.KeyChar;
            if ((с < 'А' || с > 'я') && с != '\b')
            {
                e.Handled = true;
            }
        }

        private void LatinCharsPressed(object sender, KeyPressEventArgs e)
        {
            char с = e.KeyChar;
            if ((с < 'A' || с > 'z') && с != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBoxRussianTitle_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxRussianTitle.Text)) errorProviderRussianTitle.SetError(textBoxRussianTitle, "Не указано русское название!");
            else if (textBoxRussianTitle.Text.Length < 4) errorProviderRussianTitle.SetError(textBoxRussianTitle, "Слишком короткое русское название!");
            else if (textBoxRussianTitle.Text.Length > 32) errorProviderRussianTitle.SetError(textBoxRussianTitle, "Слишком длинное русское название!");
            else errorProviderRussianTitle.Clear();
        }

        private void textBoxLatinTitle_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxLatinTitle.Text)) errorProviderLatinTitle.SetError(textBoxLatinTitle, "Не указано латинское название!");
            else if (textBoxLatinTitle.Text.Length < 4) errorProviderLatinTitle.SetError(textBoxLatinTitle, "Слишком короткое латинское название!");
            else if (textBoxLatinTitle.Text.Length > 32) errorProviderLatinTitle.SetError(textBoxLatinTitle, "Слишком длинное латинское название!");
            else errorProviderLatinTitle.Clear();
        }

        private void textBoxAbbreviation_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxAbbreviation.Text)) errorProviderAbbreviation.SetError(textBoxAbbreviation, "Не указано сокращение!");
            else if (textBoxAbbreviation.Text.Length < 3) errorProviderAbbreviation.SetError(textBoxAbbreviation, "Слишком короткое сокращение!");
            else if (textBoxAbbreviation.Text.Length > 3) errorProviderAbbreviation.SetError(textBoxAbbreviation, "Слишком длинное сокращение!");
            else errorProviderAbbreviation.Clear();
        }

        private void numericUpDownArea_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownArea.Value == 0) errorProviderArea.SetError(numericUpDownArea, "Площадь не может быть равна 0");
            else errorProviderArea.Clear();
        }

        private void numericUpDownBrigther6m_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownBrigther6m.Value == 0) errorProviderBrigther6m.SetError(numericUpDownBrigther6m, "Это число не может быть равно 0");
            else errorProviderBrigther6m.Clear();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            errorProviderRussianTitle.SetError(textBoxRussianTitle, "Введите русское название");
            errorProviderLatinTitle.SetError(textBoxLatinTitle, "Введите латинское название");
            errorProviderAbbreviation.SetError(textBoxAbbreviation, "Введите сокращение");
            errorProviderArea.SetError(numericUpDownArea, "Введите площадь");
            errorProviderBrigther6m.SetError(numericUpDownBrigther6m, "Введите число звёзд ярче 6.0m");
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(constellationsDataSet);
            textBoxRussianTitle.Text = "";
            textBoxLatinTitle.Text = "";
            textBoxAbbreviation.Text = "";
            numericUpDownArea.Value = 0;
            numericUpDownBrigther6m.Value = 0;
            pictureBoxPhoto.Image = null;
        }

    }
}