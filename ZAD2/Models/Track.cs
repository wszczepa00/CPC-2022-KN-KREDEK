using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace ZadanieDomowe2.Models
{
    public class Track
    {

        public Track(int Number, string Description, double PricePerHour, int Players)
        {
            this.Number = Number;
            this.Description = Description;
            this.PricePerHour = PricePerHour;
            this.Players = Players;
            this.TrackHours = TrackHours;

            List<bool> monday = new List<bool>(Enumerable.Repeat(true, 7).ToList());
            List<bool> tuesday = new List<bool>(Enumerable.Repeat(true, 7).ToList());
            List<bool> wednesday = new List<bool>(Enumerable.Repeat(true, 7).ToList());
            List<bool> thursday = new List<bool>(Enumerable.Repeat(true, 7).ToList());
            List<bool> friday = new List<bool>(Enumerable.Repeat(false, 9).ToList());
            List<bool> saturday = new List<bool>(Enumerable.Repeat(true, 12).ToList());
            List<bool> sunday = new List<bool>(Enumerable.Repeat(true, 9).ToList());

            TrackHours = new Dictionary<string, List<bool>>();
            TrackHours.Add("Poniedziałek", monday);
            TrackHours.Add("Wtorek", tuesday);
            TrackHours.Add("Środa", wednesday);
            TrackHours.Add("Czwartek", thursday);
            TrackHours.Add("Piatek", friday);
            TrackHours.Add("Sobota", saturday);
            TrackHours.Add("Niedziela", sunday);

        }
        public int Number { get; set; }
        public string Description { get; set; }
        public double PricePerHour { get; set; }
        public int Players { get; set; }
        public Dictionary<string, List<bool>> TrackHours { get; set; }


    }
}
