namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server mainserver = new Server("192.168.123.111", 100, "Main server" );
            WorkStation mainworkstation = new WorkStation("192.168.123.222", 90, "Windows 10" );
            Router mainrouter = new Router ("192.168.123.333", 100, "Simple router");

            Network network = new Network();

            network.AddDevice(mainserver);
            network.AddDevice(mainworkstation);
            network.AddDevice(mainrouter);

            network.DisconnectDevice(mainserver, mainworkstation);
            network.DisconnectDevice(mainworkstation, mainrouter);
            network.ConnectDevice(mainrouter, mainserver);

            Console.ReadKey();
        }
    }
}
