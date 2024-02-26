using System.Runtime.Intrinsics.X86;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LE_ClassLibraryCustomExceptions_StephanieLopez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MessageBox.Show(MyLibrary.MyMath.Add(14, 2).ToString());
            MessageBox.Show(MyLibrary.MyMath.Subtract(14, 2).ToString());
            MessageBox.Show(MyLibrary.MyMath.Multiply(14, 2).ToString());
            MessageBox.Show(MyLibrary.MyMath.Divide(14, 2).ToString());
            //Back to back message boxes to display each of the constructors I built for each of the 4 above.


            //1.Can a Class Library run on its own?
            //No! a Class Library CANT run on its own. It needs to be referenced and used by another project.

            //2.When you build a Class Library, what file format does it turn into?
            //When you build a Class Library it turns into a DLL (Dynamic Link Library) file format.

            //3.What file do you right-click on in the solution explorer to add your Class Library to a project?
            //Dependencies!

            //4.You have to make sure you change your class access modifier to _______, otherwise your other project won't recognize your Library class.
            //You have to make sure you change your class access modifier to "public".

            //5. When someone triggers an Exception you "t______ new Exception()", what's the word that starts with t.
            //"throw new Exception()".

            //6. You use a ___ / ____ block to respond to exceptions.
            //You use a "try / catch" block.

            //7. Should you use Exceptions for simple errors like "please enter a number" or "that is an incorrect command"? answer these questions in simple short responses.
            //No, Exceptions should not be used for simple errors like "please enter a number" or "that is an incorrect command". Because exceptions are exceptional conditions that display an error in the program flow, such as runtime errors or exceptional situations that cannot be handled locally.

            //Sorry if this project doesn't look right Mr.cram. I was a bit confused about the instructions. If I was supposed to follow the whole video and display each step in my program that you preformed or if I was supposed to follow the steps instructed just on canvas? 
        }
    }
}