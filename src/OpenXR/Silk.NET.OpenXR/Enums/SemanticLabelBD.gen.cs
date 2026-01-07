// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSemanticLabelBD")]
    public enum SemanticLabelBD : int
    {
        [Obsolete("Deprecated in favour of \"UnknownBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_UNKNOWN_BD")]
        SemanticLabelUnknownBD = 0,
        [Obsolete("Deprecated in favour of \"FloorBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_FLOOR_BD")]
        SemanticLabelFloorBD = 1,
        [Obsolete("Deprecated in favour of \"CeilingBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_CEILING_BD")]
        SemanticLabelCeilingBD = 2,
        [Obsolete("Deprecated in favour of \"WallBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_WALL_BD")]
        SemanticLabelWallBD = 3,
        [Obsolete("Deprecated in favour of \"DoorBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_DOOR_BD")]
        SemanticLabelDoorBD = 4,
        [Obsolete("Deprecated in favour of \"WindowBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_WINDOW_BD")]
        SemanticLabelWindowBD = 5,
        [Obsolete("Deprecated in favour of \"OpeningBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_OPENING_BD")]
        SemanticLabelOpeningBD = 6,
        [Obsolete("Deprecated in favour of \"TableBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_TABLE_BD")]
        SemanticLabelTableBD = 7,
        [Obsolete("Deprecated in favour of \"SofaBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_SOFA_BD")]
        SemanticLabelSofaBD = 8,
        [Obsolete("Deprecated in favour of \"ChairBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_CHAIR_BD")]
        SemanticLabelChairBD = 9,
        [Obsolete("Deprecated in favour of \"HumanBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_HUMAN_BD")]
        SemanticLabelHumanBD = 10,
        [Obsolete("Deprecated in favour of \"BeamBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_BEAM_BD")]
        SemanticLabelBeamBD = 11,
        [Obsolete("Deprecated in favour of \"ColumnBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_COLUMN_BD")]
        SemanticLabelColumnBD = 12,
        [Obsolete("Deprecated in favour of \"CurtainBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_CURTAIN_BD")]
        SemanticLabelCurtainBD = 13,
        [Obsolete("Deprecated in favour of \"CabinetBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_CABINET_BD")]
        SemanticLabelCabinetBD = 14,
        [Obsolete("Deprecated in favour of \"BedBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_BED_BD")]
        SemanticLabelBedBD = 15,
        [Obsolete("Deprecated in favour of \"PlantBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_PLANT_BD")]
        SemanticLabelPlantBD = 16,
        [Obsolete("Deprecated in favour of \"ScreenBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_SCREEN_BD")]
        SemanticLabelScreenBD = 17,
        [Obsolete("Deprecated in favour of \"VirtualWallBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_VIRTUAL_WALL_BD")]
        SemanticLabelVirtualWallBD = 18,
        [Obsolete("Deprecated in favour of \"RefrigeratorBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_REFRIGERATOR_BD")]
        SemanticLabelRefrigeratorBD = 19,
        [Obsolete("Deprecated in favour of \"WashingMachineBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_WASHING_MACHINE_BD")]
        SemanticLabelWashingMachineBD = 20,
        [Obsolete("Deprecated in favour of \"AirConditionerBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_AIR_CONDITIONER_BD")]
        SemanticLabelAirConditionerBD = 21,
        [Obsolete("Deprecated in favour of \"LampBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_LAMP_BD")]
        SemanticLabelLampBD = 22,
        [Obsolete("Deprecated in favour of \"WallArtBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_WALL_ART_BD")]
        SemanticLabelWallArtBD = 23,
        [Obsolete("Deprecated in favour of \"StairwayBD\"")]
        [NativeName("Name", "XR_SEMANTIC_LABEL_STAIRWAY_BD")]
        SemanticLabelStairwayBD = 24,
        [NativeName("Name", "XR_SEMANTIC_LABEL_UNKNOWN_BD")]
        UnknownBD = 0,
        [NativeName("Name", "XR_SEMANTIC_LABEL_FLOOR_BD")]
        FloorBD = 1,
        [NativeName("Name", "XR_SEMANTIC_LABEL_CEILING_BD")]
        CeilingBD = 2,
        [NativeName("Name", "XR_SEMANTIC_LABEL_WALL_BD")]
        WallBD = 3,
        [NativeName("Name", "XR_SEMANTIC_LABEL_DOOR_BD")]
        DoorBD = 4,
        [NativeName("Name", "XR_SEMANTIC_LABEL_WINDOW_BD")]
        WindowBD = 5,
        [NativeName("Name", "XR_SEMANTIC_LABEL_OPENING_BD")]
        OpeningBD = 6,
        [NativeName("Name", "XR_SEMANTIC_LABEL_TABLE_BD")]
        TableBD = 7,
        [NativeName("Name", "XR_SEMANTIC_LABEL_SOFA_BD")]
        SofaBD = 8,
        [NativeName("Name", "XR_SEMANTIC_LABEL_CHAIR_BD")]
        ChairBD = 9,
        [NativeName("Name", "XR_SEMANTIC_LABEL_HUMAN_BD")]
        HumanBD = 10,
        [NativeName("Name", "XR_SEMANTIC_LABEL_BEAM_BD")]
        BeamBD = 11,
        [NativeName("Name", "XR_SEMANTIC_LABEL_COLUMN_BD")]
        ColumnBD = 12,
        [NativeName("Name", "XR_SEMANTIC_LABEL_CURTAIN_BD")]
        CurtainBD = 13,
        [NativeName("Name", "XR_SEMANTIC_LABEL_CABINET_BD")]
        CabinetBD = 14,
        [NativeName("Name", "XR_SEMANTIC_LABEL_BED_BD")]
        BedBD = 15,
        [NativeName("Name", "XR_SEMANTIC_LABEL_PLANT_BD")]
        PlantBD = 16,
        [NativeName("Name", "XR_SEMANTIC_LABEL_SCREEN_BD")]
        ScreenBD = 17,
        [NativeName("Name", "XR_SEMANTIC_LABEL_VIRTUAL_WALL_BD")]
        VirtualWallBD = 18,
        [NativeName("Name", "XR_SEMANTIC_LABEL_REFRIGERATOR_BD")]
        RefrigeratorBD = 19,
        [NativeName("Name", "XR_SEMANTIC_LABEL_WASHING_MACHINE_BD")]
        WashingMachineBD = 20,
        [NativeName("Name", "XR_SEMANTIC_LABEL_AIR_CONDITIONER_BD")]
        AirConditionerBD = 21,
        [NativeName("Name", "XR_SEMANTIC_LABEL_LAMP_BD")]
        LampBD = 22,
        [NativeName("Name", "XR_SEMANTIC_LABEL_WALL_ART_BD")]
        WallArtBD = 23,
        [NativeName("Name", "XR_SEMANTIC_LABEL_STAIRWAY_BD")]
        StairwayBD = 24,
    }
}
