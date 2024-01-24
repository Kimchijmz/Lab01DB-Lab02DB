using Lab02DB.Data1;
using Lab02DB.Models;
using Lab02DB.Models1;
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

namespace Lab02DB.Displays
{
    /// <summary>
    /// Interaction logic for BlossomBooks.xaml
    /// </summary>
    public partial class BlossomBooks : Window
    {
        public Library3DBContext library3DBContext;
        public Store thisStore;
        //public BookInfo bookInfo;
        public BlossomBooks()
        {
            InitializeComponent();
            library3DBContext= new Library3DBContext();
            //bookInfo= new BookInfo();
            thisStore = library3DBContext.Stores.FirstOrDefault(s => s.StoreId == 1);
        }

        public void ShowBooks()
        {

        }

    }
}
