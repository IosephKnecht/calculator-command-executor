using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class CommandInjector
    {
        private static CommandInjector commandInjector = null;
        private static readonly object padlock = new object();

        private List<ICommand> commands = new List<ICommand>();

        private CommandInjector()
        {
        }

        public static CommandInjector Instance
        {
            get
            {
                if (commandInjector == null)
                {
                    lock (padlock)
                    {
                        if (commandInjector == null)
                        {
                            commandInjector = new CommandInjector();
                        }
                    }
                }
                return commandInjector;
            }
        }

        public void EnumeratePluginClasses(string path)
        {
            List<ICommand> commands = new List<ICommand>();

            foreach (string dllPath in Directory.EnumerateFiles(path, "*.dll"))
            {
                try
                {
                    Assembly dll = Assembly.LoadFile(dllPath);

                    foreach (Type type in dll.GetExportedTypes())
                    {
                        if (type.GetInterfaces().Contains(typeof(ICommand)))
                        {
                            try
                            {
                                var instance = Activator.CreateInstance(type);
                                commands.Add((ICommand)instance);
                            }
                            catch
                            {

                            }
                        }
                    }
                }
                catch
                {

                }
            }

            this.commands.AddRange(commands);
        }

        public List<ICommand> GetCommandList()
        {
            return commands;
        }


    }
}
