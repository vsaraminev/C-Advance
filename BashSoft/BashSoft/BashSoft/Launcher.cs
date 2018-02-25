namespace BashSoft
{
    using System;

    public class Launcher
    {
        public static void Main()
        {
            Tester tester = new Tester();

            IOManager iOManager = new IOManager();

            StudentsRepository repo = new StudentsRepository(new RepositoryFilter(), new RepositorySorter());

            CommandInterpreter currentdInterpreter = new CommandInterpreter(tester, repo, iOManager);

            InputReader reader = new InputReader(currentdInterpreter);

            reader.StartReadingCommands();
        }
    }
}
