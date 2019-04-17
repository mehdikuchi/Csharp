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

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        private List<Student> st = new List<Student>();
        int n,i = 0;
        public MainWindow()
        {
            InitializeComponent();            
        }
        
        //Event handler for the create student button 
        public void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            //Creating student object and adding the new student to the list
            st.Add(new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text));            
            //Clearing the textbox values
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            //MessageBox.Show("Student added");
        }
        ///Displaying each students' information in the text box:        
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            int n = st.Count;
            txtFirstName.Text = st[i].FirstName;
            txtLastName.Text = st[i].LastName;
            txtCity.Text = st[i].City;
            i=++i%n;//This modulo results in iteration to wrap around (Bonus Challenge)
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            n = st.Count;
            if (i > 0)//Checking the sign of the i if it is negative set it to the st.Count-1
            {
                i = --i % n;//This modulo results in iteration to wrap around (Bonus Challenge)
            }
            else
            {
                i = st.Count-1;
            }
            txtFirstName.Text = st[i].FirstName;
            txtLastName.Text = st[i].LastName;
            txtCity.Text = st[i].City;
            
            
        }
    }
    //Adding new class to represent a Student
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public Student(string fname = "blank", string surname = "blank", string city = "blank")
        {
            this.FirstName = fname;
            this.LastName = surname;
            this.City = city;

        }
    }
}
