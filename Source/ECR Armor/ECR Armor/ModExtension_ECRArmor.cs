using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RimWorld;
using Verse;

namespace ECR_Armor
{
    public class ModExtension_ECRArmor : DefModExtension
    {
        public float addHediffChance = 0.05f;
        public HediffDef hediffToAdd;
    }
}
