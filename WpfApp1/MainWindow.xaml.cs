using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<MenuTreeItem> TreeItems;
        public MainWindow()
        {
            InitializeComponent();
            TreeItems = new ObservableCollection<MenuTreeItem>();
            MenuTreeItem item1 = new MenuTreeItem() 
            { Name = "item1", URL = "https", Items = new ObservableCollection<MenuTreeItem>
                {
                    new MenuTreeItem() { Name="sub item 1", URL = "url ne" },
                    new MenuTreeItem() { Name="sub item 2", URL = "url ne" }
                }
            };

            MenuTreeItem item2 = new MenuTreeItem()
            {
                Name = "item2",
                URL = "https",
                Items = new ObservableCollection<MenuTreeItem>
                {
                    new MenuTreeItem() { Name="sub item 1", URL = "url ne",Items = new ObservableCollection<MenuTreeItem>()
                        {
                            new MenuTreeItem() { Name="sub sub item 1" , URL="url url ne"},
                            new MenuTreeItem() { Name="sub sub item 1" , URL="url url ne"},
                            new MenuTreeItem() { Name="sub sub item 1" , URL="url url ne"}
                        } 
                    },
                    new MenuTreeItem() { Name="sub item 2", URL = "url ne" },
                    new MenuTreeItem() { Name="sub item 3", URL = "url ne" },
                    new MenuTreeItem() { Name="sub item 4", URL = "url ne" }
                }
            };
            AddItemToTreeView(TreeItems,item1);
            AddItemToTreeView(TreeItems,item2);

            treeMain.ItemsSource = TreeItems;
        }

        #region
        void AddItemToTreeView(ObservableCollection<MenuTreeItem> root, MenuTreeItem node)
        {
            root.Add(node);
        }
        #endregion

        private void Click_AddItemToTreeView(object sender, RoutedEventArgs e)
        {
            MenuTreeItem item3 = new MenuTreeItem()
            {
                Name = "item3",
                URL = "https",
                Items = new ObservableCollection<MenuTreeItem>
                {
                    new MenuTreeItem() { Name="sub item 1", URL = "url ne" },
                    new MenuTreeItem() { Name="sub item 2", URL = "url ne" }
                }
            };

            AddItemToTreeView(TreeItems[1].Items,item3);
        }
    }
}
