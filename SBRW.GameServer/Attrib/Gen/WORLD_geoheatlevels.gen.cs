using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_geoheatlevels : CollectionWrapperBase {
        #region Field Names
        public const string Name_NumPatrolCars = "NumPatrolCars";
        public const string Name_HeatIncPerPursuit = "HeatIncPerPursuit";
        public const string Name_HeatDecPerTurn = "HeatDecPerTurn";
        #endregion

        public WORLD_geoheatlevels(VLTCollection collection) : base(collection) {}

        #region Getters
        public System.Int32 HeatDecPerTurn() {
            return GetValue<System.Int32>("HeatDecPerTurn");
        }
        public System.Int32 HeatIncPerPursuit() {
            return GetValue<System.Int32>("HeatIncPerPursuit");
        }
        public List<System.Int32> NumPatrolCars() {
            return GetArray<System.Int32>("NumPatrolCars");
        }
        #endregion

    }
}