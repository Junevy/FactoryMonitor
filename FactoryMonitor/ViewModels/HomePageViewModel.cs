using Communication.ModBus.ModBusRTU;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FactoryMonitor.Client.Temp;
using System.Collections.ObjectModel;
using System.IO.Ports;

namespace FactoryMonitor.Client.ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        private readonly ModBusRTUMaster rtu;
        [ObservableProperty]
        private MbCommand cmd;

        [ObservableProperty]
        private ModBusRTUConfig config;
        public ObservableCollection<string> Serials { get; private set; } = [];

        public HomePageViewModel(ModBusRTUMaster rtu)
        {
            this.rtu = rtu;
            this.config = rtu.Config;
            this.cmd = new();

            var portName = SerialPort.GetPortNames();

            foreach (var name in portName)
            {
                Serials.Add(name);
            }
        }

        [RelayCommand]
        public void Connect()
        {
            rtu.Connect();
        }

        [RelayCommand]
        public void Disconnect()
        {
            rtu.Disconnect();
        }

        [RelayCommand]
        public async Task ReadCoilsAsync()
        {
            Console.Write(Cmd);
            var result = await rtu.ReadCoilsAsync((byte)Cmd.SlaveId, Cmd.FunctionCode, Cmd.Count);
            await Task.Delay(2000);

            //Console.WriteLine(result);
        }
    }
}
