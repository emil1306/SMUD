﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMUD
{
    public class Room
    {
        public Room north;
        public Room south;
        public Room west;
        public Room east;
        public string navn;
        public string beskrivelse;

        public Room(string navn, string beskrivelse)
        {
            this.navn = navn;
            this.beskrivelse = beskrivelse;
        }

        public void AddNorth(Room r)
        {
            north = r;
        }

        public void AddSouth(Room r)
        {
            south = r;
        }
        public void AddWest(Room r)
        {
            west = r;
        }
        public void AddEast(Room r)
        {
            east = r;
        }

        public override string ToString()
        {
            string s = "";
            s += "Navn: " + navn + "\n";
            s += "Beskrivelse: " + beskrivelse + "\n";
            if (north != null) s += "Udgang til: " + north.navn + "\n";
            if (south != null) s += "Udgang til: " + south.navn + "\n";
            if (west != null) s += "Udgang til: " + west.navn + "\n";
            if (east != null) s += "Udgang til: " + east.navn + "\n";
            return s;
        }
    }
}
