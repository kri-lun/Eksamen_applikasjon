using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;


namespace MindfulMinutes
{
    public partial class Main : Form
    {
        MySqlConnection connection = new MySqlConnection("server=192.168.1.100;port=3306;user id=kristian;password=Passord123;database=EksamenDB");
        MySqlCommand command = new MySqlCommand();

        private string InnloggetBrukernavn;
        private int IsAdmin;
        private int UserID;
        private int CurrentSelectedID;
        public Main(MySqlDataReader mdr)
        {
            //this.userId = userId; 

            InnloggetBrukernavn = mdr.GetString("Brukernavn");
            IsAdmin = mdr.GetInt32("IsAdmin");
            UserID = mdr.GetInt32("id");
            InitializeComponent();
        }

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }

        public void executeQuery(String query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Querry Executed!");
                }
                else
                {
                    MessageBox.Show("Querry Not Executed!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void Print()
        {
            openConnection();
            if (IsAdmin == 1)
            {
                try
                {
                    string selectQuery = $"SELECT * FROM EksamenDB.Brukere WHERE IsAdmin = 0 OR id = {UserID}";
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                    adapter.Fill(dataTable);
                    DataGridView.DataSource = dataTable;

                    closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    string selectQuery = $"SELECT * FROM EksamenDB.Brukere WHERE id = {UserID}";
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                    adapter.Fill(dataTable);
                    DataGridView.DataSource = dataTable;

                    closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DataGridView.Columns[e.ColumnIndex].Name == "Passord")
            {
                if (e.Value != null)
                {
                    e.Value = "*********";
                    e.FormattingApplied = true;
                }
            }
        }


        private void ClearAllTextBoxs()
        {
            txtBrukernavn.Text = "";
            txtPassord.Text = "";
            txtAvdeling.Text = "";
            txtProsjekt.Text = "";
            txtTelefon.Text = "";
            txtAdresse.Text = "";
            txtPostnr.Text = "";
            txtIsAdmin.Text = "";
        }

        private void HideIfNotAdmin()
        {
            if (IsAdmin == 0)
            {
                lblIsAdmin.Visible = false;
                txtIsAdmin.Visible = false;

                btnLeggtil.Visible = false;
                btnSlett.Visible = false;
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {
            Print();
            lblBrukernavn.Text = "Velkommen: " + InnloggetBrukernavn;
            HideIfNotAdmin();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentSelectedID = (int)DataGridView.CurrentRow.Cells[0].Value;
            txtBrukernavn.Text = DataGridView.CurrentRow.Cells[1].Value.ToString();
            txtPassord.Text = DataGridView.CurrentRow.Cells[2].Value.ToString();
            txtAvdeling.Text = DataGridView.CurrentRow.Cells[3].Value.ToString();
            txtProsjekt.Text = DataGridView.CurrentRow.Cells[4].Value.ToString();
            txtTelefon.Text = DataGridView.CurrentRow.Cells[5].Value.ToString();
            txtAdresse.Text = DataGridView.CurrentRow.Cells[6].Value.ToString();
            txtPostnr.Text = DataGridView.CurrentRow.Cells[7].Value.ToString();
            txtIsAdmin.Text = DataGridView.CurrentRow.Cells[8].Value.ToString();
        }


        private void btnLeggtil_Click(object sender, EventArgs e)
        {
            int TelefonnrINT = Convert.ToInt32(txtTelefon.Text);
            int PostnrINT = Convert.ToInt32(txtPostnr.Text);
            int IsAdminINT = Convert.ToInt32(txtIsAdmin.Text);


            string insertQuery = $"INSERT INTO EksamenDB.Brukere (id, Brukernavn, Passord, Avdeling, Prosjekt, Telefonnr, Adresse, Postnr, IsAdmin)VALUES('{0}','{txtBrukernavn.Text}', '{txtPassord.Text}', '{txtAvdeling.Text}', '{txtProsjekt.Text}', '{TelefonnrINT}', '{txtAdresse.Text}', '{PostnrINT}', '{IsAdminINT}')";
            executeQuery(insertQuery);

            Print();

            ClearAllTextBoxs();
        }

        private void btnLeggtil_Click_1(object sender, EventArgs e)
        {
            int TelefonnrINT = Convert.ToInt32(txtTelefon.Text);
            int PostnrINT = Convert.ToInt32(txtPostnr.Text);
            int IsAdminINT = Convert.ToInt32(txtIsAdmin.Text);


            string insertQuery = $"INSERT INTO EksamenDB.Brukere (id, Brukernavn, Passord, Avdeling, Prosjekt, Telefonnr, Adresse, Postnr, IsAdmin)VALUES('{0}','{txtBrukernavn.Text}', '{txtPassord.Text}', '{txtAvdeling.Text}', '{txtProsjekt.Text}', '{TelefonnrINT}', '{txtAdresse.Text}', '{PostnrINT}', '{IsAdminINT}')";
            executeQuery(insertQuery);

            Print();

            ClearAllTextBoxs();
        }

        private void btnSlett_Click_1(object sender, EventArgs e)
        {
            try
            {
                string deletQuery = $"DELETE FROM EksamenDB.Brukere WHERE id = {CurrentSelectedID}";
                executeQuery(deletQuery);


                if (UserID == CurrentSelectedID)
                {
                    //Make this a function
                    this.Close();
                    Login loginForm = new Login();
                    loginForm.Closed += (s, args) => this.Close();
                    loginForm.Show();
                }

                Print();

                ClearAllTextBoxs();

            }

            catch (Exception ex)
            {

            }
        }

        private void btnOppdater_Click_1(object sender, EventArgs e)
        {

            int TelefonnrINT = Convert.ToInt32(txtTelefon.Text);
            int PostnrINT = Convert.ToInt32(txtPostnr.Text);
            int IsAdminINT = Convert.ToInt32(txtIsAdmin.Text);


            string updateQuery = $"UPDATE EksamenDB.Brukere SET Brukernavn='{txtBrukernavn.Text}', Passord='{txtPassord.Text}', Avdeling='{txtAvdeling.Text}', Prosjekt='{txtProsjekt.Text}', Telefonnr='{TelefonnrINT}', Adresse='{txtAdresse.Text}', Postnr='{PostnrINT}', IsAdmin='{IsAdminINT}' WHERE id='{CurrentSelectedID}'";
            executeQuery(updateQuery);

            if (UserID == CurrentSelectedID)
            {
                Console.WriteLine("Changed Self Data");
                IsAdmin = IsAdminINT;
            }

            HideIfNotAdmin();

            Print();

            //Make this a function
            ClearAllTextBoxs();
        }

        private void btnLoggut_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}