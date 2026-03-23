using Communication.ModBus.ModBusRTU;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO.Ports;

namespace FactoryMonitor.Client.ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        private readonly ModBusRTUMaster rtu;

        [ObservableProperty]
        private ModBusRTUConfig config;
        public ObservableCollection<string> Serials { get; private set; } = new();

        public HomePageViewModel(ModBusRTUMaster rtu)
        {
            this.rtu = rtu;
            this.config = rtu.Config;

            Config.BaudRate = 9600;

            var test = SerialPort.GetPortNames();

            foreach (var name in test)
            {
                Serials.Add(name);
            }
        }

        [RelayCommand]
        public void Connect()
        {
            rtu.Connect();
            Console.WriteLine(Config);
            rtu.Disconnect();
        }
    }
}
