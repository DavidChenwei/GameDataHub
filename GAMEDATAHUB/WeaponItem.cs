//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAMEDATAHUB
{
    using System;
    using System.Collections.Generic;
    
    public partial class WeaponItem
    {
        public int WeaponItemId { get; set; }
        public Nullable<int> WeaponID { get; set; }
        public Nullable<int> HeroID { get; set; }
        public Nullable<int> Kills { get; set; }
        public Nullable<int> Damage { get; set; }
        public Nullable<int> BodyKills { get; set; }
        public Nullable<int> HeadshotKills { get; set; }
        public Nullable<int> HipfireKills { get; set; }
        public Nullable<int> MultiKills { get; set; }
        public Nullable<decimal> Accuracy { get; set; }
        public Nullable<decimal> KillsPerMinute { get; set; }
        public Nullable<decimal> DamagePerMinute { get; set; }
        public Nullable<decimal> Headshots { get; set; }
        public Nullable<decimal> Hitvalls { get; set; }
        public Nullable<int> ShotsHit { get; set; }
        public Nullable<int> ShotsFired { get; set; }
        public Nullable<int> Spawns { get; set; }
        public Nullable<int> TimeEquipped { get; set; }
    
        public virtual Hero Hero { get; set; }
        public virtual Weapon Weapon { get; set; }
    }
}
