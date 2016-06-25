//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class GlobalStat
    {
        public int Id { get; set; }
        public int GamesPlayed { get; set; }
        public int PlayersKilled { get; set; }
        public int PlayersSurvived { get; set; }
        public string MostKilledFirstNight { get; set; }
        public Nullable<int> MostKilledFirstPercent { get; set; }
        public string MostLynchedFirstDay { get; set; }
        public Nullable<int> MostLynchedFirstPercent { get; set; }
        public string MostKilledFirstDay { get; set; }
        public Nullable<int> MostKilledFirstDayPercent { get; set; }
        public string BestSurvivor { get; set; }
        public Nullable<int> BestSurvivorPercent { get; set; }
        public Nullable<System.DateTime> LastRun { get; set; }
        public Nullable<int> TotalPlayers { get; set; }
        public Nullable<int> TotalGroups { get; set; }
        public Nullable<int> MostKilledFirstNightId { get; set; }
        public Nullable<int> MostLynchedFirstDayId { get; set; }
        public Nullable<int> MostKilledFirstDayId { get; set; }
        public Nullable<int> BestSurvivorId { get; set; }
    }
}
