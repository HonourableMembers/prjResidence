using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prjResidence
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Resident> Res_List = new List<Resident>();
        public MainWindow()
        {
            InitializeComponent();
        }

        //variables for user input
        private string name, surname, email, cellNum, year, complaint;
        private int id;

        private void txtPerson_TextChanged(object sender, TextChangedEventArgs e)
        {
            name = txtPerson.Text;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Res_List.Add(new Resident(id, name, surname, email, cellNum, year));
            PrintRes();
        }

        private void txtSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            surname = txtSurname.Text;
        }

        private void txtID_TextChanged(object sender, TextChangedEventArgs e)
        {
            id = Convert.ToInt32(txtID.Text);
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            email = txtEmail.Text;
        }

        private void txtCellNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            cellNum = txtCellNum.Text;
        }

        private void txtYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            year = txtYear.Text;
        }

        private void txtComplaint_TextChanged(object sender, TextChangedEventArgs e)
        {
            complaint = txtComplaint.Text;
        }

        public void PrintRes()
        {
            lstPeople.Items.Clear();

            foreach (var r in Res_List)
            {
                lstPeople.Items.Add(r.R_Name);
            }
        }


    }
}
