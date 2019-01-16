using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    class Switch
    {
        ICommand _closedCommand;
        ICommand _openedCommand;

        public Switch(ICommand _closedCommand, ICommand _openedCommand)
        {
            this._closedCommand = _closedCommand;
            this._openedCommand = _openedCommand;
        }
        public void Close()
        {
            this._closedCommand.Execute();
        }
        public void Open()
        {
            this._openedCommand.Execute();
        }
    }   
}
