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
using System.Windows.Shapes;
using wpf_Konuk_Ivan_Mihailovich.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace wpf_Konuk_Ivan_Mihailovich.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdmMenu.xaml
    /// </summary>
    public partial class AdmMenu : Window
    {
        public AdmMenu()
        {
            InitializeComponent();
            var context = new Pz1KonukIvanMihailovichContext();
            var user = context.Users.ToList();
            admDg.ItemsSource = user;
        }
    }
}
