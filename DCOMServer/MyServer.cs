using System;
using System.Runtime.InteropServices;

namespace DCOMServer
{
    [ComVisible(true)]
    public interface IMyInterface
    {
        string SayHello();
    }

    [ComVisible(true)]
    public class MyServer : IMyInterface
    {
        public string SayHello()
        {
            return "Hola desde el servidor DCOM";
        }
    }
}

