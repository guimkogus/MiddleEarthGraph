﻿using System;

namespace MiddleEarthGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            MiddleEarth middleEarth = MiddleEarth.getInstance();

            middleEarth.map.BreadthFirstSearch("Hobbiton", "Orodruin");
        }
    }
}
