using Communication.ModBus.Common;
using Serilog;

namespace FactoryMonitor.Client.Common.Adapter
{
    public class SerilogAdapter() : ISerilog
    {
        public void Debug(string msg) => Log.Debug(msg);

        public void Debug<T>(string msgTemplate, T propertyValue) => Log.Debug(msgTemplate, propertyValue);

        public void Debug<T0, T1>(string msgTemplate, T0 propertyValue0, T1 propertyValue1)
            => Log.Debug(msgTemplate, propertyValue0, propertyValue1);

        public void Debug<T0, T1, T2>(string msgTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
            => Log.Debug(msgTemplate, propertyValue0, propertyValue1, propertyValue2);



        public void Error(string msg) => Log.Error(msg);

        public void Error<T>(string msgTemplate, T propertyValue) => Log.Error(msgTemplate, propertyValue);

        public void Error<T0, T1>(string msgTemplate, T0 propertyValue0, T1 propertyValue1)
            => Log.Error(msgTemplate, propertyValue0, propertyValue1);

        public void Error<T0, T1, T2>(string msgTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
            => Log.Error(msgTemplate, propertyValue0, propertyValue1, propertyValue2);



        public void Fatal(string msg) => Log.Fatal(msg);

        public void Fatal<T>(string msgTemplate, T propertyValue) => Log.Fatal(msgTemplate, propertyValue);

        public void Fatal<T0, T1>(string msgTemplate, T0 propertyValue0, T1 propertyValue1)
            => Log.Fatal(msgTemplate, propertyValue0, propertyValue1);

        public void Fatal<T0, T1, T2>(string msgTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
            => Log.Fatal(msgTemplate, propertyValue0, propertyValue1, propertyValue2);



        public void Information(string msg) => Log.Information(msg);

        public void Information<T>(string msgTemplate, T propertyValue) => Log.Information(msgTemplate, propertyValue);

        public void Information<T0, T1>(string msgTemplate, T0 propertyValue0, T1 propertyValue1)
            => Log.Information(msgTemplate, propertyValue0, propertyValue1);

        public void Information<T0, T1, T2>(string msgTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
            => Log.Information(msgTemplate, propertyValue0, propertyValue1, propertyValue2);



        public void Verbose(string msg) => Log.Verbose(msg);

        public void Verbose<T>(string msgTemplate, T propertyValue) => Log.Verbose(msgTemplate, propertyValue);

        public void Verbose<T0, T1>(string msgTemplate, T0 propertyValue0, T1 propertyValue1)
            => Log.Verbose(msgTemplate, propertyValue0, propertyValue1);

        public void Verbose<T0, T1, T2>(string msgTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
            => Log.Verbose(msgTemplate, propertyValue0, propertyValue1, propertyValue2);



        public void Warning(string msg) => Log.Warning(msg);

        public void Warning<T>(string msgTemplate, T propertyValue) => Log.Warning(msgTemplate, propertyValue);

        public void Warning<T0, T1>(string msgTemplate, T0 propertyValue0, T1 propertyValue1)
            => Log.Warning(msgTemplate, propertyValue0, propertyValue1);

        public void Warning<T0, T1, T2>(string msgTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
            => Log.Warning(msgTemplate, propertyValue0, propertyValue1, propertyValue2);

    }
}
