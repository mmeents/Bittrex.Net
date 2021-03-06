﻿namespace Bittrex.Net.Sockets
{
    internal class ConnectionRequestV3
    {
        public string RequestName { get; set; }
        public object[] Parameters { get; set; }
        
        public ConnectionRequestV3(string name, params string[] channels)
        {
            RequestName = name;
            Parameters = new object[]
            {
                channels
            };
        }
    }
}
