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

namespace CA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Activity> allActivities = new List<Activity>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create some activities 
            Activity land1 = new Activity("Treking", DateTime.Parse("2019, 06, 01"), 20m, "Instructor led group trek through the local mountains", Activity.terrain.Land);
            Activity land2 = new Activity("Mountain Biking", DateTime.Parse("2019, 06, 02"), 30m, "Instructor led half day Mountain Biking. All equipment provided", Activity.terrain.Land);
            Activity land3 = new Activity("Abseiling", DateTime.Parse("2019, 06, 03"), 40m, "Experience the rush of adrenaline as you descend cliff faces from 10 - 500m", Activity.terrain.Land);

            Activity water1 = new Activity("Kayaking", DateTime.Parse("2019, 06, 01"), 40m, "Half day lakeland kayak with Island picnic", Activity.terrain.Water);
            Activity water2 = new Activity("Surfing", DateTime.Parse("2019, 06, 02"), 25m, "2 hour surf lesson on the wild atlantic way", Activity.terrain.Water);
            Activity water3 = new Activity("Sailing", DateTime.Parse("2019, 06, 03"), 50m, "Full day lakeland kayak with island picnic", Activity.terrain.Water);

            Activity air1 = new Activity("Parachuting", DateTime.Parse("2019, 06, 01"), 100m, "Experience the thrill of free fall while you tandem jump from an airplane", Activity.terrain.Air);
            Activity air2 = new Activity("Hang Glinding", DateTime.Parse("2019, 06, 02"), 80m, "Soar on hot air currents and enjoy the spectacular views of the coastal region", Activity.terrain.Air);
            Activity air3 = new Activity("Helicopter Tour", DateTime.Parse("2019, 06, 03"), 200m, "Experience the ultimate in aerial sight-seeing as you tour the area in our modern helicopters", Activity.terrain.Air);
            //Add them to the List

            allActivities.Add(land1);
            allActivities.Add(land2);
            allActivities.Add(land3);

            allActivities.Add(water1);
            allActivities.Add(water2);
            allActivities.Add(water3);

            allActivities.Add(air1);
            allActivities.Add(air2);
            allActivities.Add(air3);

            //display in Activities ListBox

            lbxActivities.ItemsSource = allActivities;
        }
    }
}
