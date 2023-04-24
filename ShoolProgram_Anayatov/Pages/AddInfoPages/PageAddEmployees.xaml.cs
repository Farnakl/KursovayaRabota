using ShoolProgram_Anayatov.Classes;
using ShoolProgram_Anayatov.Modeks;
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

namespace ShoolProgram_Anayatov.Pages.AddInfoPages
{
    /// <summary>
    /// Логика взаимодействия для PageAddEmploees.xaml
    /// </summary>
    public partial class PageAddEmploees : Page
    {
        public PageAddEmploees()
        {
            InitializeComponent();

            CmbJobTitle.DisplayMemberPath = "Name";
            CmbJobTitle.SelectedValuePath = "id";
            CmbJobTitle.ItemsSource = Connection.DBConnect.JobTitle.ToList();

            CmbFamilyStatus.DisplayMemberPath = "Name";
            CmbFamilyStatus.SelectedValuePath = "id";
            CmbFamilyStatus.ItemsSource = Connection.DBConnect.FamilyStatus.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameView.GoBack();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

            if (TxbName.Text == "" || CmbFamilyStatus.Text == "" || CmbJobTitle.Text == "" ||
                DatOfBirth.Text == "" || TxbEducation.Text == "" || TxbPassport.Text == "" ||
                TxbRegAddres.Text == "" || TxbResAddres.Text == "" || TxbSpeciality.Text == ""
                || TxbTelephone.Text == "" || TxbTIN.Text == "" )
            {
                MessageBox.Show("Поля пусты", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {

                try
                {
                    Employees employees = new Employees()
                    {
                        JobTitle = CmbJobTitle.SelectedItem as JobTitle,
                        FamilyStatus1 = CmbFamilyStatus.SelectedItem as FamilyStatus,
                        Name = TxbName.Text,
                        DateOfBirth = DateTime.Parse(DatOfBirth.Text),
                        TIN= TxbTIN.Text,
                        Education = TxbEducation.Text,
                        Passport = TxbPassport.Text,
                        RegistrationAddress= TxbRegAddres.Text,
                        ResidentialAddress= TxbResAddres.Text,
                        Speciality = TxbSpeciality.Text,
                        Telephone = TxbTelephone.Text,

                    };




                    Connection.DBConnect.Employees.Add(employees);

                    Connection.DBConnect.SaveChanges();
                    MessageBox.Show("Данные успешно добавлены!",
                        "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    Navigation.frameView.GoBack();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(),
                        "Критическая ошибка",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }


            }
        }
    }
}
