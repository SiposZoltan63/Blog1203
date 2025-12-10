using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Blog
{
    public partial class BloggerList : Page
    {
        public BloggerList()
        {
            InitializeComponent();
            BloggerDataGrid.ItemsSource = ListaBloggers();
        }
        public List<Blogger> ListaBloggers()
        {
            using (var context = new BlogDbContext())
            {
                return context.bloggers.ToList();
            }
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = BloggerDataGrid.SelectedItem;
            var blogger = item as Blogger;
            if (blogger != null)
            {
                int id = blogger.Id;
                MessageBox.Show(id.ToString());
            }
        }
    }
}
