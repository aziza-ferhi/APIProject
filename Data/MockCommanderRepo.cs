
using System.Collections.Generic;
using commander.Models;

namespace commander.Data
{

    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands =  new List<Command>
            {
                new Command{ Id=0, HowTo="fnjfgbrvge", Line=",efjfft", Platform="dkfjhfbdvg"},
                new Command { Id=1, HowTo="pdkoirhyezgreàç", Line="kjhgfdsqazer", Platform="shgffvxllkjhs"}
            };
            return commands;
            
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id=0, HowTo="fnjfgbrvge", Line=",efjfft", Platform="dkfjhfbdvg"

            };
        }
    }
}
