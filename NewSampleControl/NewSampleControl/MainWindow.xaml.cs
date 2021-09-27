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

namespace NewSampleControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            List<Class1> s = new List<Class1>();
            s.Add(new Class1 { Subject = "Tamil", Percent = 35 });
            s.Add(new Class1 { Subject = "english", Percent = 100 });
            s.Add(new Class1 { Subject = "maths", Percent = 50 });
            s.Add(new Class1 { Subject = "social", Percent = 35 });
            s.Add(new Class1 { Subject = "science", Percent = 35 });
            items.ItemsSource = s;

        }
    }
}
