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
    /// Логика взаимодействия для PageEditProduct.xaml
    /// </summary>
    public partial class PageEditProduct : Page
    {
        private int productId;
        public PageEditProduct(Product product)
        {
            InitializeComponent();

            TxbNameProduct.Text = product.NameProduct.ToString();
            TxbPurchasePrice.Text = product.PurchasePrice.ToString();
            TxbPurchaseVolue.Text = product.PurchaseVolume.ToString();
            TxbUnit.Text = product.Unit.ToString();

            CmbProvider.DisplayMemberPath = "Name";
            CmbProvider.SelectedValuePath = "id";
            CmbProvider.ItemsSource = Connection.DBConnect.Provider.ToList();
            CmbProvider.Text = product.Provider.Name.ToString();
         
           
            CmbTypeOfProduct.DisplayMemberPath = "NameType";
            CmbTypeOfProduct.SelectedValuePath = "id";
            CmbTypeOfProduct.ItemsSource = Connection.DBConnect.TypeOfProduct.ToList();
            CmbTypeOfProduct.Text = product.TypeOfProduct.NameType.ToString();

            productId = product.id;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (TxbNameProduct.Text == "" || TxbPurchasePrice.Text == "" || TxbPurchaseVolue.Text == "" ||
                TxbUnit.Text == "" || CmbProvider.Text == "" || CmbTypeOfProduct.Text == "")
            {
                MessageBox.Show("Поля пусты",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {

                Anayatov_magazineEntities3 context = new Anayatov_magazineEntities3();
                var product = context.Product.Where(c => c.id == productId).FirstOrDefault();

                product.Unit = TxbUnit.Text;
                product.idProvider = (CmbProvider.SelectedItem as Provider).id;
                product.NameProduct = TxbNameProduct.Text;
                product.idTypeOfProduct = (CmbTypeOfProduct.SelectedItem as TypeOfProduct).id;
                product.PurchasePrice = TxbPurchasePrice.Text;
                product.PurchaseVolume = TxbPurchaseVolue.Text;

                context.SaveChanges();
                MessageBox.Show("Данные успешно изменены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

                Navigation.frameView.GoBack();
            }

        }
    

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameView.GoBack();
        }
    }
}
