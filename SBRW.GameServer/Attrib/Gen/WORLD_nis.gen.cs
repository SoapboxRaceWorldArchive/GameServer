using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_nis : CollectionWrapperBase {
        #region Field Names
        public const string Name_RaceCar = "RaceCar";
        public const string Name_AudioCamera = "AudioCamera";
        public const string Name_0x79C50AFB = "0x79C50AFB";
        public const string Name_CopCar = "CopCar";
        public const string Name_PresetSkins = "PresetSkins";
        public const string Name_0x993C6094 = "0x993C6094";
        public const string Name_CollectionName = "CollectionName";
        public const string Name_AudioEnd = "AudioEnd";
        public const string Name_AudioIntro = "AudioIntro";
        public const string Name_0xF9075181 = "0xF9075181";
        #endregion

        public WORLD_nis(VLTCollection collection) : base(collection) {}

        #region Getters
        // unknown type: Csis::Type_NIS_Camera
        public VaultLib.Core.Types.VLTUnknown AudioCamera() {
            return GetValue<VaultLib.Core.Types.VLTUnknown>("AudioCamera");
        }
        // unknown type: Csis::Type_NIS_Scene_End
        public VaultLib.Core.Types.VLTUnknown AudioEnd() {
            return GetValue<VaultLib.Core.Types.VLTUnknown>("AudioEnd");
        }
        // unknown type: Csis::Type_NIS_Scene_Intro
        public VaultLib.Core.Types.VLTUnknown AudioIntro() {
            return GetValue<VaultLib.Core.Types.VLTUnknown>("AudioIntro");
        }
        public System.String CollectionName() {
            return GetValue<System.String>("CollectionName");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> CopCar() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("CopCar");
        }
        public System.Boolean field_0x79C50AFB() {
            return GetValue<System.Boolean>("0x79C50AFB");
        }
        public System.Boolean field_0x993C6094() {
            return GetValue<System.Boolean>("0x993C6094");
        }
        public System.Boolean field_0xF9075181() {
            return GetValue<System.Boolean>("0xF9075181");
        }
        public List<VaultLib.Support.World.VLT.type_bStringHash> PresetSkins() {
            return GetArray<VaultLib.Support.World.VLT.type_bStringHash>("PresetSkins");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> RaceCar() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("RaceCar");
        }
        #endregion

    }
}