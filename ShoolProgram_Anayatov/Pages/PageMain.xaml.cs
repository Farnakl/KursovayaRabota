using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.IdentityModel.Protocols;
using ShoolProgram_Anayatov.Classes;
using ShoolProgram_Anayatov.Modeks;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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

namespace ShoolProgram_Anayatov.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public SeriesCollection SeriesCollection { get; set; }
        public PageMain()
        {
            InitializeComponent();



            SeriesCollection = new SeriesCollection

            {
            new LineSeries
            {
                Title = "Первый",
                Values = new ChartValues<double> { 4, 6, 5, 2, 3 }
            },
            new LineSeries
            {
                Title = "Второй",
                Values = new ChartValues<double> {5,2,2,2,2}
            }

            
        };

            // присваиваем набор данных графику
            DataContext = this;
        }

        
    }
}
