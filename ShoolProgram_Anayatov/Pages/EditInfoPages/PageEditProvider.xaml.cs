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

namespace ShoolProgram_Anayatov.Pages.EditInfoPages
{
    /// <summary>
    /// Логика взаимодействия для PageEditProvider.xaml
    /// </summary>
    public partial class PageEditProvider : Page
    {
        private int providerId;

        public PageEditProvider(Provider provider)
        {
            InitializeComponent();
            DatDatePurchase.Text = provider.PurchaseDate.ToString();

            TxbBankAccont.Text = provider.CheckingAccount.ToString();
            TxbEmail.Text = provider.Email.ToString();
            TxbINN.Text = provider.TIN.ToString();
            TxbAddress.Text = provider.Address.ToString();
            TxbName.Text = provider.Name.ToString();
            TxbTelephone.Text = provider.Telephone.ToString();

            CmbStatusProvider.DisplayMemberPath = "Name";
            CmbStatusProvider.SelectedValuePath = "id";
            CmbStatusProvider.ItemsSource = Connection.DBConnect.StatusProvider.ToList();
            CmbStatusProvider.Text = provider.StatusProvider.Name.ToString();

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (TxbTelephone.Text == "" || TxbName.Text == "" || TxbINN.Text == "" ||
                TxbEmail.Text == "" || TxbBankAccont.Text == "" || TxbAddress.Text == ""
                || CmbStatusProvider.Text == "" || DatDatePurchase.Text == "")
            {
                MessageBox.Show("Поля пусты",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {

                Anayatov_magazineEntities2 context = new Anayatov_magazineEntities2();
                var provider = context.Provider.Where(c => c.id == providerId).FirstOrDefault();

                provider.PurchaseDate = DateTime.Parse(DatDatePurchase.Text);
                provider.Telephone = TxbTelephone.Text;
                provider.TIN = TxbINN.Text;
                provider.Address = TxbAddress.Text;
                provider.Email = TxbEmail.Text;
                provider.Name = TxbName.Text;
                provider.CheckingAccount = TxbBankAccont.Text;
                provider.idStatusProvider = (CmbStatusProvider.SelectedItem as StatusProvider).id;

                context.SaveChanges();

                MessageBox.Show("Данные успешно изменены!",
                        "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

                Navigation.frameView.GoBack();
            }

        }
             public void BtnBack_Click(object sender, RoutedEventArgs e)
            {
                Navigation.frameView.GoBack();
            }
    }
}
