using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder1 = new VolleyballCourt();
            builder1.CreateFence();
            builder1.CreateMapping();
            builder1.CreatePillars();
            builder1.CreateNetwork();
            Console.Write(builder1.GetProduct().ListParts());
            var builder2 = new TennisCourt();
            builder2.CreateMapping();
            builder2.CreatePillars();
            builder2.CreateNetwork();
            builder2.CreateFence();
            Console.Write(builder2.GetProduct().ListParts());
        }
    }
}
