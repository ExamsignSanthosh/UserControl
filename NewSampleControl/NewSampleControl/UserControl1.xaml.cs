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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
     
        public object Subject
        {
            get { return (object)GetValue(SubjectProperty); }
            set { SetValue(SubjectProperty, value); }
        }

        public static readonly DependencyProperty SubjectProperty =
            DependencyProperty.Register("Subject", typeof(object), typeof(UserControl1), new PropertyMetadata("Maths"));

        public int WidthValue
        {
            get { return (int)GetValue(WidthValueProperty); }
            set { SetValue(WidthValueProperty, value); }
        }


        public static readonly DependencyProperty WidthValueProperty =
            DependencyProperty.Register("WidthValue", typeof(int), typeof(UserControl1), new PropertyMetadata(100));



        public int Percentage
        {
            get { return (int)GetValue(PercentageProperty); }
            set { SetValue(PercentageProperty,value); }
        }

        public static readonly DependencyProperty PercentageProperty =
            DependencyProperty.Register("Percentage", typeof(int), typeof(UserControl1), new PropertyMetadata(0));


        public UserControl1()
        {
            InitializeComponent();
        }

      
    }
}
