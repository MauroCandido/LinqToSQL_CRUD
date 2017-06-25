using DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace People
{
    public partial class FrmPeople : Form
    {
        public FrmPeople()
        {
            InitializeComponent();
        }

        private void FrmPeople_Load(object sender, EventArgs e)
        {
            // Implement the First Load
            try
            {
                LoadData();
            }
            catch(Exception  ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Load" );
            }
        }

        public void LoadData()
        {
            try
            {
                IQueryable<people> PeopleS = DBAccess.GetIQueryablePeople();
                dgViewPeople.DataSource = PeopleS;
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Load");
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            people People = new people();
            People.age = Convert.ToInt16(txtAge.Text);
            // ID is IDENTITY, so the database will take care of it !
             People.Id =  Convert.ToInt16(txtID.Text);
            People.name = txtName.Text;
            People.phone = txtPhone.Text;
            try
            {
                DBAccess.ManuPeople(People);
                MessageBox.Show("Insert OK");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert", MessageBoxButtons.OK);
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            people People = new people();
            People.age = Convert.ToInt16(txtAge.Text);
            People.Id = Convert.ToInt16(txtID.Text);
            People.name = txtName.Text;
            People.phone = txtPhone.Text;
            try
            {
                DBAccess.ManuPeople(People);
                MessageBox.Show("Alterar OK");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert", MessageBoxButtons.OK);
            }
        }

        private void dgViewPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPeople = Convert.ToInt32(dgViewPeople.Rows[e.RowIndex].Cells[0].Value);
            people result = DBAccess.GetPeopleID(idPeople);
            FillGrig(result);

        }

        private void FillGrig(people People)
        {
            try
            {
                txtAge.Text = People.age.ToString();
                txtID.Text = People.Id.ToString();
                txtName.Text = People.name;
                txtPhone.Text  = People.phone;
            }
            catch(Exception)
            {
                throw ;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int Code = Convert.ToInt16(txtID.Text);
            if (MessageBox.Show("Exclude ?", "Excluding",
                MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                try
                { 
                  DBAccess.DeletePeople(Code);
                  LoadData();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Delete", MessageBoxButtons.OK);
                }

            }
           

        }

        private void dgViewPeople_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idPeople = Convert.ToInt32(dgViewPeople.Rows[e.RowIndex].Cells[0].Value);
            people result = DBAccess.GetPeopleID(idPeople);
            FillGrig(result);

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            formClear(this);
            txtID.Focus();
        }

        private void formClear(Control control)
        {
            foreach(Control textbox in control.Controls)
            {
                if (textbox is TextBox )
                {
                    ((TextBox)textbox).Text = string.Empty ;
                }
            }
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            try
            {

            int idPeople = Convert.ToInt32(txtID.Text);
            people result = DBAccess.GetPeopleID(idPeople);
            FillGrig(result);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Find", MessageBoxButtons.OK);
            }
        }
    }
}
