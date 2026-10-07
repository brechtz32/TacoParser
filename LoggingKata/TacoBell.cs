using System;
using System.Security.Cryptography.X509Certificates;

namespace LoggingKata

{
    public class TacoBell : ITrackable
    {
        public string Name { get; set; }

        public Point Location { get; set; }       
        
        
    }
}