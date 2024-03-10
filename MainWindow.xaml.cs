using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace DataGrid_Dashboard
{
    public partial class MainWindow : Window
    {
        private bool isMaximized = false;
        public ObservableCollection<Member> Members { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            InitializeMembers();
        }

        private void InitializeMembers()
        {
            var converter = new BrushConverter();
            Members = new ObservableCollection<Member>();

            // Add member data here...
            //Create DataGrid Items Info
            Members.Add(new Member
            {
                Number = "1",
                Character = "j",
                BgColor = (Brush)converter.ConvertFromString("#1098ad"),
                Name = "Jonh Doe",
                Position = "Coach",
                Email = "jdoe@gmail.com",
                Phone = "+44 7976290"
            });
            Members.Add(new Member
            {
                Number = "2",
                Character = "M",
                BgColor = (Brush)converter.ConvertFromString("#1e88e5"),
                Name = "Mint Caramel",
                Position = "Administrator",
                Email = "mc@gmail.com",
                Phone = "+44 75887590"
            });
            Members.Add(new Member
            {
                Number = "3",
                Character = "H",
                BgColor = (Brush)converter.ConvertFromString("#ff8f00"),
                Name = "Hosea Mine",
                Position = "Coach",
                Email = "Hos34mine@gmail.com",
                Phone = "+44 1245290"
            });
            Members.Add(new Member
            {
                Number = "4",
                Character = "A",
                BgColor = (Brush)converter.ConvertFromString("#ff5252"),
                Name = "Arigato Sakura",
                Position = "Coach",
                Email = "Asa89@gmail.com",
                Phone = "+44 9874563"
            });
            Members.Add(new Member
            {
                Number = "5",
                Character = "T",
                BgColor = (Brush)converter.ConvertFromString("#0ca678"),
                Name = "Thomas Edison",
                Position = "Manager",
                Email = "TEdison@electric.com",
                Phone = "+44 74756290"
            });
            Members.Add(new Member
            {
                Number = "6",
                Character = "L",
                BgColor = (Brush)converter.ConvertFromString("#ff6d00"),
                Name = "Lena Jones",
                Position = "Administrator",
                Email = "LJoe44@gmail.com",
                Phone = "+44 79862290"
            });
            Members.Add(new Member
            {
                Number = "7",
                Character = "B",
                BgColor = (Brush)converter.ConvertFromString("#ff5252"),
                Name = "Brett Pormand",
                Position = "Coach",
                Email = "Brett56@yahoo.com",
                Phone = "+44 75896290"
            });
            Members.Add(new Member
            {
                Number = "8",
                Character = "F",
                BgColor = (Brush)converter.ConvertFromString("#6741d9"),
                Name = "Frank Cart",
                Position = "Manager",
                Email = "FCart@gmail.com",
                Phone = "+44 77586290"
            });
            Members.Add(new Member
            {
                Number = "9",
                Character = "G",
                BgColor = (Brush)converter.ConvertFromString("#1e88e5"),
                Name = "Grabriel Cox",
                Position = "Manager",
                Email = "GCox@gmail.com",
                Phone = "+44 75000290"
            });
            Members.Add(new Member
            {
                Number = "10",
                Character = "D",
                BgColor = (Brush)converter.ConvertFromString("#0ca678"),
                Name = "David Macedon",
                Position = "Coach",
                Email = "Dave56@yahoo.cm",
                Phone = "+44 75111290"
            });


            membersDataGrid.ItemsSource = Members;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (isMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    isMaximized = false;
                }
            }
        }

        private void MembersDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Handle selection changed event
        }
    }

    public class Member
    {
        public string Character { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor { get; set; }
    }
}
