using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace rain_weather.ViewModels
{
    public abstract class CommandBaseAsync : CommandBase
    {
        public CommandBaseAsync(string label = "") : base(label)
        { }

        public override async void Execute(object parameter)
        {
            await ExecuteImplementationAsync(parameter);
        }

        public abstract Task ExecuteImplementationAsync(object parameter);
    }
}
