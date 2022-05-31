using CommandsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsAPI.Data
{
    public interface ICommandAPIRepo
    {
        public bool SaveChanges();
        public IEnumerable<Command> GetAllCommands();
        public Command GetCommandById(int id);
        public void CreateCommand(Command cmd);
        public void UpdateCommand(Command cmd);
        public void DeleteCommand(Command cmd);
    }
}
