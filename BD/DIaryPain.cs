using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD
{

    public partial class DIaryPain : Form
    {

        public DIaryPain()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                IRepository myRep = new PGRepository();
                if (myRep.AddUser(new User(0, txtAddUser.Text, txtAddUser1.Text, Convert.ToInt32(txtAddUser2.Text), Convert.ToInt32(txtAddUser3.Text)))) Status.Text = "Пользователь добавлен";
                else Status.Text = "Ошибка в заполнении пользователя";
            }
            catch (Exception ex)
            {
                Status.Text = ex.Message;
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                IRepository myRep = new PGRepository();

                if (cmbUserEdit.Text=="ID")
                {
                    if (myRep.EditUserByID(new User(Convert.ToInt32(txtEditUser_1.Text), txtEditUser.Text, txtEditUser_2.Text, Convert.ToInt32(txtEditUser_3.Text), Convert.ToInt32(txtEditUser_4.Text)))) Status.Text = "Пользователь изменен";
                    else Status.Text = "Ошибка в заполнении пользователя";
                }
                else if (cmbUserEdit.Text == "Имя")
                {
                    if (myRep.EditUserByName(new User(0, txtEditUser.Text, txtEditUser_2.Text, Convert.ToInt32(txtEditUser_3.Text), Convert.ToInt32(txtEditUser_4.Text)), txtEditUser_1.Text)) Status.Text = "Пользователь успешно изменен";
                    else Status.Text = "Ошибка в заполнении пользователя";
                }
                else if (cmbUserEdit.Text == "Ник")
                {
                    if (myRep.EditUserByNickName(new User(0, txtEditUser.Text, txtEditUser_2.Text, Convert.ToInt32(txtEditUser_3.Text), Convert.ToInt32(txtEditUser_4.Text)), txtEditUser_1.Text)) Status.Text = "Пользователь успешно изменен";
                    else Status.Text = "Ошибка в заполнении пользователя";
                }
            }
            catch (Exception ex)
            {
                Status.Text = ex.Message;
            }
        }
        private void btnDelUser_Click(object sender, EventArgs e)
        {
            try
            {
                IRepository myRep = new PGRepository();
                if (cmbDelUser.Text == "ID")
                {
                    if (myRep.DelUserByID(Convert.ToInt32(txtDelUser.Text))) Status.Text = "Пользователь успешно удален";
                    else Status.Text = "Ошибка в заполнении пользователя";
                }
                else if (cmbDelUser.Text == "Имя")
                {
                    if (myRep.DelUserByName(txtDelUser.Text)) Status.Text = "Пользователь успешно удален";
                    else Status.Text = "Ошибка в заполнении пользователя";
                }
                else if (cmbDelUser.Text == "Ник")
                {
                    if (myRep.DelUserByNickName(txtDelUser.Text)) Status.Text = "Пользователь успешно удален";
                    else Status.Text = "Ошибка в заполнении пользователя";
                }
            }
            catch (Exception ex)
            {
                Status.Text = ex.Message;
            }
        }
        private void btnAddMedicines_Click(object sender, EventArgs e)
        {
            try
            {
                IRepository myRep = new PGRepository();
                if (
                    myRep.AddMedicines(new Medicines(0, txtAddMed.Text, Convert.ToInt32(txtAddMed1.Text), float.Parse(txtAddMed2.Text)))
                   )
                    Status.Text = "Лекарство добавлено";
                else
                    Status.Text = "Ошибка в заполнении";
            }
            catch (Exception ex)
            {
                Status.Text = ex.Message;
            }
        }

        private void btnEditMedicines_Click(object sender, EventArgs e)
        {
            try
            {
                IRepository myRep = new PGRepository();


                if (cmbEditMed_1.Text == "ID")
                {
                    if (myRep.EditMedByID(new Medicines(Convert.ToInt32(txtEditMed.Text), txtEditMed1.Text, Convert.ToInt32(txtEditMed2.Text), float.Parse(txtEditMed3.Text)))) Status.Text = "Успешно изменено";
                    else Status.Text = "Ошибка в заполнении";
                }
                else if (cmbEditMed_1.Text == "Имя")
                {
                    if (myRep.EditMedByName(new Medicines(0, txtEditMed1.Text, Convert.ToInt32(txtEditMed2.Text), float.Parse(txtEditMed3.Text)), txtEditMed.Text)) Status.Text = "Успешно изменено";
                    else Status.Text = "Ошибка в заполнении";
                }
            }
            catch (Exception ex)
            {
                Status.Text = ex.Message;
            }
        }
        private void btnDelMedicines_Click(object sender, EventArgs e)
        {
            try
            {
                IRepository myRep = new PGRepository();
                if (cmbDelMed.Text == "ID")
                {
                    if (myRep.DelMedByID(Convert.ToInt32(txtDelMed.Text))) Status.Text = "Успешно удалено";
                    else Status.Text = "Ошибка в заполнении";
                }
                else if (cmbDelMed.Text == "Имя")
                {
                    if (myRep.DelMedByName(txtDelMed.Text)) Status.Text = "Успешно удалено";
                    else Status.Text = "Ошибка в заполнении";
                }
            }
            catch (Exception ex)
            {
                Status.Text = ex.Message;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            IRepository myRep = new PGRepository();
            MainList.Clear();
            if (cmbMain3.Text == "Все таблицы")
            {
                MainList.Columns.Add("Таблицы в базе данных:", 200, HorizontalAlignment.Left);

                var tables = myRep.GetTables();

                foreach (var table in tables)
                {
                    ListViewItem MainListInit = new ListViewItem();
                    MainListInit.Text = table.ToString();

                    MainList.Items.Add(MainListInit);
                }
            }
            else if (cmbMain3.Text == "Пользователи")
            {
                MainList.Columns.Add("id", 100, HorizontalAlignment.Left);
                MainList.Columns.Add("name", 100, HorizontalAlignment.Left);
                MainList.Columns.Add("nickname", 100, HorizontalAlignment.Left);
                MainList.Columns.Add("full_age", 100, HorizontalAlignment.Left);
                MainList.Columns.Add("roleid", 100, HorizontalAlignment.Left);
                var users = myRep.GetUsers();


                foreach (var user in users)
                {
                    ListViewItem MainListInit = new ListViewItem();
                    ListViewItem.ListViewSubItem field_name = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem field_nickname = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem field_full_age = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem field_roleid = new ListViewItem.ListViewSubItem();


                    MainListInit.Text = user.Id.ToString();
                    field_name.Text = user.Name;
                    field_nickname.Text = user.NickName;
                    field_full_age.Text = user.Full_Age.ToString();
                    field_roleid.Text = user.RoleId.ToString();

                    MainListInit.SubItems.Add(field_name);
                    MainListInit.SubItems.Add(field_nickname);
                    MainListInit.SubItems.Add(field_full_age);
                    MainListInit.SubItems.Add(field_roleid);

                    MainList.Items.Add(MainListInit);
                }
            }
            else if (cmbMain3.Text == "Лекарства")
            {
                MainList.Columns.Add("id", 100, HorizontalAlignment.Left);
                MainList.Columns.Add("name", 100, HorizontalAlignment.Left);
                MainList.Columns.Add("rating", 100, HorizontalAlignment.Left);
                MainList.Columns.Add("price", 100, HorizontalAlignment.Left);

                var meds = myRep.GetMedicines();


                foreach (var med in meds)
                {
                    ListViewItem MainListInit = new ListViewItem();
                    ListViewItem.ListViewSubItem field_name = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem field_rating = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem field_price = new ListViewItem.ListViewSubItem();

                    MainListInit.Text = med.Id.ToString();
                    field_name.Text = med.Name;
                    field_rating.Text = med.Rating.ToString();
                    field_price.Text = med.Price.ToString();

                    MainListInit.SubItems.Add(field_name);
                    MainListInit.SubItems.Add(field_rating);
                    MainListInit.SubItems.Add(field_price);

                    MainList.Items.Add(MainListInit);
                }
            }
            else if (cmbMain3.Text == "Врачи")
            {
                MainList.Columns.Add("id", 100, HorizontalAlignment.Left);
                MainList.Columns.Add("name", 100, HorizontalAlignment.Left);
                MainList.Columns.Add("rating", 100, HorizontalAlignment.Left);
                MainList.Columns.Add("telnum", 100, HorizontalAlignment.Left);

                var docs = myRep.GetDoctors();


                foreach (var doc in docs)
                {
                    ListViewItem MainListInit = new ListViewItem();
                    ListViewItem.ListViewSubItem field_name = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem field_rating = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem field_telnum = new ListViewItem.ListViewSubItem();

                    MainListInit.Text = doc.Id.ToString();
                    field_name.Text = doc.Name;
                    field_rating.Text = doc.Rating.ToString();
                    field_telnum.Text = doc.Telephone_Number;

                    MainListInit.SubItems.Add(field_name);
                    MainListInit.SubItems.Add(field_rating);
                    MainListInit.SubItems.Add(field_telnum);

                    MainList.Items.Add(MainListInit);
                }
            }
            else if (cmbMain3.Text == "Места боли")
            {
                MainList.Columns.Add("id", 100, HorizontalAlignment.Left);
                MainList.Columns.Add("name", 100, HorizontalAlignment.Left);

                var pops = myRep.GetPOP();


                foreach (var pop in pops)
                {
                    ListViewItem MainListInit = new ListViewItem();
                    ListViewItem.ListViewSubItem field_name = new ListViewItem.ListViewSubItem();
                    MainListInit.Text = pop.Id.ToString();
                    field_name.Text = pop.Name;

                    MainListInit.SubItems.Add(field_name);

                    MainList.Items.Add(MainListInit);
                }
            }
            else if (cmbMain3.Text == "Награды")
            {
                MainList.Columns.Add("id", 100, HorizontalAlignment.Left);
                MainList.Columns.Add("name", 100, HorizontalAlignment.Left);

                var awards = myRep.GetAwards();


                foreach (var award in awards)
                {
                    ListViewItem MainListInit = new ListViewItem();
                    ListViewItem.ListViewSubItem field_name = new ListViewItem.ListViewSubItem();


                    MainListInit.Text = award.Id.ToString();
                    field_name.Text = award.Name;


                    MainListInit.SubItems.Add(field_name);

                    MainList.Items.Add(MainListInit);
                }
            }
            else if (cmbMain3.Text == "Роли")
            {
                MainList.Columns.Add("id", 100, HorizontalAlignment.Left);
                MainList.Columns.Add("name", 100, HorizontalAlignment.Left);

                var roles = myRep.GetRoles();


                foreach (var role in roles)
                {
                    ListViewItem MainListInit = new ListViewItem();
                    ListViewItem.ListViewSubItem field_name = new ListViewItem.ListViewSubItem();

                    MainListInit.Text = role.Id.ToString();
                    field_name.Text = role.Name;


                    MainListInit.SubItems.Add(field_name);


                    MainList.Items.Add(MainListInit);
                }
            }            
            
        }

        




        private void BDDefenderTheForest_Load(object sender, EventArgs e)
        {
            record1.Hide();
            records1.Hide();
            request1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            records1.Hide();
            request1.Hide();

            record1.Show();
            record1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            record1.Hide();
            request1.Hide();

            records1.Show();
            records1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            records1.Hide();
            record1.Hide();

            request1.Show();
            request1.BringToFront();
        }
    }
}
