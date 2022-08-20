using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using RimWorld.Planet;

namespace AEWater
{
    public class BiomeWorker_UnderwaterOcean : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            if (tile.WaterCovered && tile.elevation <= 0)
            {
                return float.MaxValue;
            }
            return float.MinValue;
        }
    }
}
