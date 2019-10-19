using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iJob2019
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            lblErUsername.Visible = false;
            lblErUsername.Visible = false;
            if (txtUserName.Text!="")
            {
                try
                {
                    MailAddress email = new MailAddress(txtUserName.Text);
                }
                catch (Exception)
                {

                    lblErUsername.Text = "Invalid email format";
                    lblErUsername.Visible = true;
                }
                if (txtPassword.Text!="")
                {
                    lblErPass.Visible = false;
                    lblErUsername.Visible = false;
                    string query =( $"SELECT * FROM [Credential] where Username = '{txtUserName.Text}' AND Password='{txtPassword.Text}'");
                    SqlCommand command = new SqlCommand(query, Database.connection);
                    
                    try
                    {
                        Database.connection.Open();
                        if (command.ExecuteScalar()!=null)//Password and username are correct
                        {
                            SqlDataReader dataReader;
                            SqlCommand command2 = new SqlCommand($"Select * from Credential where Username='{txtUserName.Text}'", Database.connection);
                            dataReader = command.ExecuteReader();
                            if (dataReader.Read())
                            {
                               
                                LoginSession.ID = dataReader["Agent_ID"].ToString();
                                LoginSession.UserName = dataReader["Username"].ToString();
                                if (dataReader["Rights"].ToString()=="True")
                                {
                                    LoginSession.AdminRights = true;
                                }
                                else
                                {
                                    LoginSession.AdminRights = false;
                                }
                            }
                     
                               Database.connection.Close();
                            Form form;
                            //if (LoginSession.AdminRights==true)
                            //{
                            //    form = new frmAdmin();
                            //}
                            //else
                            //{
                            //    form = new frmMain();
                            //}
                            form =LoginSession.AdminRights == true ? form= new frmAdmin() : form = new frmMain();
                            form.Show();
                        this.Hide();
                        }
                        else
                        {
                            Database.connection.Close();
                            lblErPass.Text = "Username or Password are incorrect";
                            lblErPass.Visible = true;
                        }
                      
                    }
                    catch (Exception ex)
                    {
                        Database.connection.Close();
                        MessageBox.Show($"Database Coonection error \n Technical information: {ex.Message}","Reading error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                   
                    errorProviderInput.SetError(txtPassword, "Please fill in the Password");
                    txtPassword.Focus();
                }
            }
            else
            {
                errorProviderInput.SetError(txtUserName, "Please fill the Username");
                txtUserName.Focus();
            }
          

        }
    }
}

//insert into Agent(Agent_ID, Name, Surname, Date_Of_Birth, Gender, Contact, Email, Street_Address, Province, Postal_Code, City)
//Values('9607275632986','Thandoka','Chikopera','19960727','Male','0653125518','tanya@mail.com','11 Jameson Street','Eastern Cape',5240,'East London')

