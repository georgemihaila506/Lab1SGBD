using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1SGBF
{
    public partial class Interfata : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-B0UH3NI;Initial Catalog=Depozit;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlDataAdapter dataAdapterAngajati = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        DataSet dataSetAngajati = new DataSet();
        string id;
        string fid;
        public Interfata()
        {
            InitializeComponent();
            refreshButton_Click(null, null);


        }

        private void parinteGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id=parinteGrid.SelectedRows[0].Cells["SId"].Value.ToString();
            dataAdapterAngajati.SelectCommand = new SqlCommand("Select * From Angajati where SId=@id", connection);
            dataAdapterAngajati.SelectCommand.Parameters.Add("@id",SqlDbType.Int).Value=id;
            dataSetAngajati.Clear();
            dataAdapterAngajati.Fill(dataSetAngajati);
            fiuGrid.DataSource = dataSetAngajati.Tables[0];
            Console.WriteLine(id);
            
        } 
        private void fiuGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fid = fiuGrid.SelectedRows[0].Cells["AId"].Value.ToString();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Sedii", connection);
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
            parinteGrid.DataSource = dataSet.Tables[0];
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var nume = numeText.Text;
            var prenume = prenumeText.Text;
            var salariu = salariuText.Text;

            try
            {
                dataAdapterAngajati.InsertCommand = new SqlCommand("insert into Angajati(Nume,Prenume,Salariu,SId) values(@nume,@prenume,@salariu,@sid)",connection);
                dataAdapterAngajati.InsertCommand.Parameters.Add("@nume", SqlDbType.VarChar).Value = nume;
                dataAdapterAngajati.InsertCommand.Parameters.Add("@prenume", SqlDbType.VarChar).Value = prenume;
                dataAdapterAngajati.InsertCommand.Parameters.Add("@salariu", SqlDbType.Int).Value = int.Parse(salariu);
                dataAdapterAngajati.InsertCommand.Parameters.Add("@sid", SqlDbType.Int).Value = int.Parse(id);
                connection.Open();
                dataAdapterAngajati.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("A fost adaugat cu succes!");
                connection.Close();
                dataSetAngajati.Clear();
                dataAdapterAngajati.Fill(dataSetAngajati);
                fiuGrid.DataSource = dataSetAngajati.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare!");
                connection.Close();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var nume = numeText.Text;
            var prenume = prenumeText.Text;
            var salariu = salariuText.Text;

            try
            {
                dataAdapterAngajati.UpdateCommand = new SqlCommand("update Angajati set Nume=@nume,Prenume=@prenume,Salariu=@salariu where AId=@aid", connection);
                dataAdapterAngajati.UpdateCommand.Parameters.Add("@nume", SqlDbType.VarChar).Value = nume;
                dataAdapterAngajati.UpdateCommand.Parameters.Add("@prenume", SqlDbType.VarChar).Value = prenume;
                dataAdapterAngajati.UpdateCommand.Parameters.Add("@salariu", SqlDbType.Int).Value = int.Parse(salariu);
                dataAdapterAngajati.UpdateCommand.Parameters.Add("@aid", SqlDbType.Int).Value = int.Parse(fid);
                connection.Open();
                dataAdapterAngajati.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("A fost actualizat cu succes!");
                connection.Close();
                dataSetAngajati.Clear();
                dataAdapterAngajati.Fill(dataSetAngajati);
                fiuGrid.DataSource = dataSetAngajati.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare!");
                connection.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapterAngajati.DeleteCommand = new SqlCommand("delete from Angajati where AId=@aid", connection);
                dataAdapterAngajati.DeleteCommand.Parameters.Add("@aid", SqlDbType.Int).Value = int.Parse(fid);
                connection.Open();
                dataAdapterAngajati.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("A fost sters cu succes!");
                connection.Close();
                dataSetAngajati.Clear();
                dataAdapterAngajati.Fill(dataSetAngajati);
                fiuGrid.DataSource = dataSetAngajati.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare!");
                connection.Close();
            }
        }
    }
}
