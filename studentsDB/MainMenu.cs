using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace studentsDB
{
    public partial class MainMenu : Form
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\studentsDB\studentsDB\Database3.mdf;Integrated Security=True");


        int BookId = 0;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            button4.Visible = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database3DataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter1.Fill(this.database3DataSet.Books);
          /*  using (EFDbContextEntities db = new EFDbContextEntities())
            {
                booksBindingSource1.DataSource = db.Books.ToList();
            }*/

            // TODO: данная строка кода позволяет загрузить данные в таблицу "eFDbContextDataSet.Books". При необходимости она может быть перемещена или удалена.
            //this.booksTableAdapter.Fill(this.eFDbContextDataSet.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eFDbContextDataSet.Books". При необходимости она может быть перемещена или удалена.
          //  this.booksTableAdapter.Fill(this.eFDbContextDataSet.Books);

            Reset();
            FillDataGridView();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eFDbContextDataSet1.students". При необходимости она может быть перемещена или удалена.
            //this.booksTableAdapter.Fill(this.eFDbContextDataSet.Books);


            /*   dataGridView1.Visible = false;
               EditPanel.Visible = false;*/


        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            EditPanel.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("DeleteProcedure", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@BookId", BookId);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Удалено");
                Reset();
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eFDbContextDataSet1.students". При необходимости она может быть перемещена или удалена.
           // this.booksTableAdapter.Update(this.eFDbContextDataSet.Books);
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                 if (button5.Text == "Сохранить")
                {
                SqlCommand sqlCmd = new SqlCommand("addORedit", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@BookId", 0);
                sqlCmd.Parameters.AddWithValue("@name", textBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@author", textBox2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Отчество", textBox3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@description", textBox4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Дата_рождения", textBox5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Год_поступления", textBox6.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Год_окончания", textBox7.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Образование", textBox8.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Год_окончания_школы", textBox9.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Номер_школы", textBox10.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@genre", textBox11.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@year", textBox12.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@picture", textBox13.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Номер_телефона_родителей", textBox14.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@url", textBox15.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@dimensions", textBox16.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@weight", textBox17.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Гражданство", textBox18.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Документ_подтверждающий_гражданство", textBox19.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Многодетная_семья", textBox20.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@barcode", textBox21.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Срок_действия", textBox22.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Основание_поощрение", textBox23.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Основание_взыскания", textBox24.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@media", textBox25.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@От_какого_числа", textBox26.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Внутриние_перемещения", textBox27.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Характеристика_выпускника", textBox28.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Трудоустройство_выпускника", textBox29.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Продвижение_выпускника", textBox30.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@price", textBox31.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Сохранено");
                  }
                 else
                  {
                      SqlCommand sqlCmd = new SqlCommand("addORedit", sqlCon);
                      sqlCmd.CommandType = CommandType.StoredProcedure;
                      sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                      sqlCmd.Parameters.AddWithValue("@BookId", BookId);
                      sqlCmd.Parameters.AddWithValue("@name", textBox1.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@author", textBox2.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Отчество", textBox3.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@description", textBox4.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Дата_рождения", textBox5.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Год_поступления", textBox6.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Год_окончания", textBox7.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Образование", textBox8.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Год_окончания_школы", textBox9.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Номер_школы", textBox10.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@genre", textBox11.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@year", textBox12.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@picture", textBox13.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Номер_телефона_родителей", textBox14.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@url", textBox15.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@dimensions", textBox16.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@weight", textBox17.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Гражданство", textBox18.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Документ_подтверждающий_гражданство", textBox19.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Многодетная_семья", textBox20.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@barcode", textBox21.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Срок_действия", textBox22.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Основание_поощрение", textBox23.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Основание_взыскания", textBox24.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@media", textBox25.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@От_какого_числа", textBox26.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Внутриние_перемещения", textBox27.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Характеристика_выпускника", textBox28.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Трудоустройство_выпускника", textBox29.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Продвижение_выпускника", textBox30.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@price", textBox31.Text.Trim());
                      sqlCmd.ExecuteNonQuery();
                      MessageBox.Show("Обновлено");
                  }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            finally
            {
                sqlCon.Close();
            }
        }
        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("ViewOrSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@lil", txtSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
           // dataGridView1.Columns[0].Visible =false ;
            sqlCon.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            /*if (this.txtSearch.Text != String.Empty)
            {
                this.studentsBindingSource1.Filter = String.Format("[Фамилия] LIKE '*{0}*' OR [Имя] LIKE '*{0}*' OR [Группа] LIKE '*{0}*'  OR [Специальность] LIKE '*{0}* 'OR [Иностранный_язык] LIKE '*{0}*' OR [Многодетная_семья] LIKE '*{0}*' OR [Номер_диплома] LIKE '*{0}*' OR [Форма_обучения ] LIKE '*{0}*' ", this.txtSearch.Text);
            }
            else
            {
                this.studentsBindingSource1.Filter = "";
            }*/
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EditPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            EditPanel.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            EditPanel.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                BookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox10.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                textBox11.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                textBox12.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                textBox13.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                textBox14.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                textBox15.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                textBox16.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                textBox17.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                textBox18.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                textBox19.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
                textBox20.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
                textBox21.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
                textBox22.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
                textBox23.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
                textBox24.Text = dataGridView1.CurrentRow.Cells[24].Value.ToString();
                textBox25.Text = dataGridView1.CurrentRow.Cells[25].Value.ToString();
                textBox26.Text = dataGridView1.CurrentRow.Cells[26].Value.ToString();
                textBox27.Text = dataGridView1.CurrentRow.Cells[27].Value.ToString();
                textBox28.Text = dataGridView1.CurrentRow.Cells[28].Value.ToString();
                textBox29.Text = dataGridView1.CurrentRow.Cells[29].Value.ToString();
                textBox30.Text = dataGridView1.CurrentRow.Cells[30].Value.ToString();
                textBox31.Text = dataGridView1.CurrentRow.Cells[31].Value.ToString();

                button5.Text = "Обновить";
                button1.Enabled = true;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();

                    this.booksTableAdapter.Update(this.eFDbContextDataSet.Books);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "eFDbContextDataSet1.students". При необходимости она может быть перемещена или удалена.
                    this.booksTableAdapter.Update(this.eFDbContextDataSet.Books);
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("addORedit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@BookId", BookId);
                    sqlCmd.Parameters.AddWithValue("@name", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@author", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Отчество", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@description", textBox4.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Дата_рождения", textBox5.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Год_поступления", textBox6.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Год_окончания", textBox7.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Образование", textBox8.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Год_окончания_школы", textBox9.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Номер_школы", textBox10.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@genre", textBox11.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@year", textBox12.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@picture", textBox13.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Номер_телефона_родителей", textBox14.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@url", textBox15.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@dimensions", textBox16.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@weight", textBox17.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Гражданство", textBox18.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Документ_подтверждающий_гражданство", textBox19.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Многодетная_семья", textBox20.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@barcode", textBox21.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Срок_действия", textBox22.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Основание_поощрение", textBox23.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Основание_взыскания", textBox24.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@media", textBox25.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@От_какого_числа", textBox26.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Внутриние_перемещения", textBox27.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Характеристика_выпускника", textBox28.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Трудоустройство_выпускника", textBox29.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Продвижение_выпускника", textBox30.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@price", textBox31.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Обновлено");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Обновлено");
            }
            finally
            {
                sqlCon.Close();
            }

        }
        void Reset()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = textBox15.Text = textBox16.Text = textBox17.Text = textBox18.Text = textBox19.Text = textBox20.Text = textBox21.Text = textBox22.Text = textBox23.Text = textBox24.Text = textBox25.Text = textBox26.Text = textBox27.Text = textBox28.Text = textBox29.Text = textBox30.Text = textBox31.Text = "";
            button5.Text = "Сохранить";
            BookId = 0;
            button1.Enabled = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow.Index != -1)
            {
                BookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox10.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                textBox11.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                textBox12.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                textBox13.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                textBox14.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                textBox15.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                textBox16.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                textBox17.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                textBox18.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                textBox19.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
                textBox20.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
                textBox21.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
                textBox22.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
                textBox23.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
                textBox24.Text = dataGridView1.CurrentRow.Cells[24].Value.ToString();
                textBox25.Text = dataGridView1.CurrentRow.Cells[25].Value.ToString();
                textBox26.Text = dataGridView1.CurrentRow.Cells[26].Value.ToString();
                textBox27.Text = dataGridView1.CurrentRow.Cells[27].Value.ToString();
                textBox28.Text = dataGridView1.CurrentRow.Cells[28].Value.ToString();
                textBox29.Text = dataGridView1.CurrentRow.Cells[29].Value.ToString();
                textBox30.Text = dataGridView1.CurrentRow.Cells[30].Value.ToString();
                textBox31.Text = dataGridView1.CurrentRow.Cells[31].Value.ToString();

                button5.Text = "Обновить";
                button1.Enabled = true;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height + 10);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
           /* e.Graphics.DrawString(dataGridView1.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 150, 125);
            /*
             e.Graphics.DrawString(textBox4.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 150, 125);
             e.Graphics.DrawString(textBox11.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 150, 125);
             e.Graphics.DrawString(textBox12.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 150, 125);
             e.Graphics.DrawString(textBox16.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 150, 125);
             e.Graphics.DrawString(textBox17.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 150, 125);
             e.Graphics.DrawString(textBox25.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 150, 125);
             e.Graphics.DrawString(textBox31.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 150, 125);
            */
        }
        Bitmap bmp;

        private void button2_Click_1(object sender, EventArgs e)
        {
            printDocument1.Print();/*
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
           /* Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 500, 0, this.Size);
            printPreviewDialog1.ShowDialog();*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void booksBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void booksBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 1;
            int j = 0;

            xlWorkSheet.get_Range("A1").Value = "Личный номер";
            xlWorkSheet.get_Range("B1").Value = "Фамилия";
            xlWorkSheet.get_Range("C1").Value = "Имя";
            xlWorkSheet.get_Range("D1").Value = "Отчество";
            xlWorkSheet.get_Range("E1").Value = "Группа";
            xlWorkSheet.get_Range("F1").Value = "Дата рождения";
            xlWorkSheet.get_Range("G1").Value = "Год поступления";
            xlWorkSheet.get_Range("H1").Value = "Год окончания ";
            xlWorkSheet.get_Range("I1").Value = "Образование";
            xlWorkSheet.get_Range("J1").Value = "Год окончания школы";
            xlWorkSheet.get_Range("K1").Value = "Номер школы";
            xlWorkSheet.get_Range("L1").Value = "Специальность";
            xlWorkSheet.get_Range("M1").Value = "Форма обучения";
            xlWorkSheet.get_Range("N1").Value = "Номер телефона учащегося";
            xlWorkSheet.get_Range("O1").Value = "Номер телефона родителей";
            xlWorkSheet.get_Range("P1").Value = "Адрес";
            xlWorkSheet.get_Range("Q1").Value = "Иностранный язык";
            xlWorkSheet.get_Range("R1").Value = "Группа здоровья";
            xlWorkSheet.get_Range("S1").Value = "Гражданство";
            xlWorkSheet.get_Range("T1").Value = "Документ подтверждающий гражданство";
            xlWorkSheet.get_Range("U1").Value = "Многодетная семья";
            xlWorkSheet.get_Range("V1").Value = "Инвалидность";
            xlWorkSheet.get_Range("W1").Value = "Срок действия";
            xlWorkSheet.get_Range("X1").Value = "Основание поощрение";
            xlWorkSheet.get_Range("Y1").Value = "Основание взыскания";
            xlWorkSheet.get_Range("Z1").Value = "Номер диплома";
            xlWorkSheet.get_Range("AA1").Value = "От какого числа";
            xlWorkSheet.get_Range("AB1").Value = "Внутриние перемещения";
            xlWorkSheet.get_Range("AC1").Value = "Характеристика выпускника:";
            xlWorkSheet.get_Range("AD1").Value = "Трудоустройство выпускника:";
            xlWorkSheet.get_Range("AE1").Value = "Продвижение выпускника:";
            xlWorkSheet.get_Range("AF1").Value = "Пропуски без уважительных причин:";




            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];

                    xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                }
            }
            DialogResult res = MessageBox.Show("Экспорт завершен. При нажатии Yes будет открыт сгенерированный файл, при нажатии No будет предложено сохранить файл.", "Экспорт в Excel", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            { xlApp.Visible = true; }
            if (res == DialogResult.No)
            {
                string fileName = String.Empty;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog1.FileName;
                }
                else
                    return;
                //сохраняем 
                xlWorkBook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                saveFileDialog1.Dispose();
            }

            //  xlWorkBook.SaveAs("Экспорт данных.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkSheet.Cells.get_Range("A1", "AF1").Font.Bold = true;
            xlWorkSheet.Columns.ColumnWidth = 20;

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private static void ToCsV(DataGridView dGV, string filename)
        {
            IEnumerable<string[]> writeData = GetWriteData(dGV);
            int[] maxLengths = new int[dGV.ColumnCount - 1];
            foreach (string[] row in writeData)
            {
                for (int i = 0; i < maxLengths.Length; ++i)
                {
                    if (row[i] != null && row[i].Length > maxLengths[i])
                    {
                        maxLengths[i] = row[i].Length;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < maxLengths.Length; ++i)
            {
                sb.AppendFormat("{{{0},-{1}}}", i, maxLengths[i]).Append("\t");
            }
            string format = sb.AppendFormat("{{{0}}}", maxLengths.Length).ToString();

            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.GetEncoding(1251)))
            {
                foreach (string[] row in writeData)
                {
                    sw.WriteLine(format, row);
                }
            }
        }

        private static IEnumerable<string[]> GetWriteData(DataGridView dGV)
        {
            yield return dGV.Columns.Cast<DataGridViewColumn>().Select(column => Convert.ToString(column.HeaderText)).ToArray();
            for (int i = 0; i < dGV.RowCount - 1; ++i)
            {
                yield return dGV.Rows[i].Cells.Cast<DataGridViewCell>().Select(cell => Convert.ToString(cell.Value)).ToArray();
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sdf = new SaveFileDialog();
            sdf.Filter = @"Word Documents(*.txt)|*.txt";
            sdf.FileName = "*.txt";
            if (sdf.ShowDialog() == DialogResult.OK)
            {
                ToCsV(dataGridView1, sdf.FileName);
            }
        }
    }
}
