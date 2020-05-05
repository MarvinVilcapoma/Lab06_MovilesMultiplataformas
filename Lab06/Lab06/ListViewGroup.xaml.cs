using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
{
    public class VehiclesModel
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public VehiclesModel()
        {

        }
    }
    public class GroupedVehiclesModel : ObservableCollection<VehiclesModel>
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }

    }
  


    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewGroup : ContentPage
	{
        private ObservableCollection<GroupedVehiclesModel> grouped { get; set; }


        public ListViewGroup ()
		{
			InitializeComponent ();
            grouped = new ObservableCollection<GroupedVehiclesModel>();
            var Cars = new GroupedVehiclesModel() { LongName = "Carros", ShortName = "C" };
            var Motorcycles = new GroupedVehiclesModel() { LongName = "Motocicletas", ShortName = "M" };
            Cars.Add(new VehiclesModel { Name = "Aston Martin Vulcan", Price = "3400000$" });
            Cars.Add(new VehiclesModel { Name = "Lykan HyperSport", Price = "3400000$" });
            Cars.Add(new VehiclesModel { Name = "Lamborghini Veneno Roadster", Price = "4500000$" });
            Cars.Add(new VehiclesModel { Name = "Ferrari LaFerrari Aperta", Price = "6000000$" });
            Cars.Add(new VehiclesModel { Name = "Mercedes-Maybach Exelero", Price = "8000000$" });
            Motorcycles.Add(new VehiclesModel { Name = "NCR Macchia Nera Concept", Price= "225000$"});
            Motorcycles.Add(new VehiclesModel { Name = "Icon Sheene", Price = "172000$" });
            Motorcycles.Add(new VehiclesModel { Name = "Vyrus 987 C3 4V", Price = "103800$" });
            grouped.Add(Cars); grouped.Add(Motorcycles);
            lstView.ItemsSource = grouped;
        }
	}
}