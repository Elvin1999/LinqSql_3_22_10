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
using WpfApp2.Model;
using WpfApp2.ModelExtention;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LibraryDataClassesDataContext context = new LibraryDataClassesDataContext();

            //var result = from b in context.Books
            //             select b;

            //mygrid.ItemsSource = result;


            // linq to sql variants
            //var result = from b in context.Books
            //             where b.Pages > 450
            //             select b;

            //var result = context.Books.Where(b => b.Pages >= 450);

            //mygrid.ItemsSource = result;




            //var result = from b in context.Books
            //             where b.Pages >= (context.Books.Average(i => i.Pages))
            //             select b;


            //var result = from b in context.Books
            //             where b.Pages >= (context.Books.Average(i => i.Pages))
            //             select new { Name=b.Name,Page=b.Pages };

            //var result = from b in context.Books
            //             where b.Pages >= (context.Books.Average(i => i.Pages))
            //             select new BookModel { Name=b.Name,Page=b.Pages };

            //mygrid.ItemsSource = result;



            //var result=from a in context.Authors
            //           where a.Id==1
            //           select a;


            //var result=from a in context.Authors
            //           where a.FirstName.Contains("a")
            //           orderby a.FirstName ascending
            //           select a;


            //var result = from sc in context.S_Cards
            //             group sc by sc.Id_Book into mygroup
            //             where mygroup.Count()>=2
            //             select new { mygroup.Key, mygroup.First().Book.Name, MyCount = mygroup.Count() };

            //var result = from b in context.Books
            //             join a in context.Authors on b.Id_Author equals a.Id
            //             join c in context.Categories on b.Id_Category equals c.Id
            //             select new { BookName = b.Name, AuthorName = a.FirstName, CategoryName = c.Name };

            //mygrid.ItemsSource = result;


            //var author = new Author
            //{
            //    Id=555,
            //     FirstName="Togrul",
            //      LastName="Eliyev"
            //};

            //context.Authors.InsertOnSubmit(author);
            //context.SubmitChanges();

            //var result = from a in context.Authors
            //             select a;
            //mygrid.ItemsSource = result;

            //var author = context.Authors.FirstOrDefault(a => a.Id == 555);
            //author.FirstName = "I Changed";

            //context.SubmitChanges();

            var author = context.Authors.FirstOrDefault(a => a.Id == 555);
            context.Authors.DeleteOnSubmit(author);
            context.SubmitChanges();    

            var result = from a in context.Authors
                         select a;
            mygrid.ItemsSource = result;

        }

      
    }
}
