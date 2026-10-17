// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSemanticLabelBD")]
public enum SemanticLabelBD : uint
{
    [NativeName("XR_SEMANTIC_LABEL_UNKNOWN_BD")]
    Unknown = 0,

    [NativeName("XR_SEMANTIC_LABEL_FLOOR_BD")]
    Floor = 1,

    [NativeName("XR_SEMANTIC_LABEL_CEILING_BD")]
    Ceiling = 2,

    [NativeName("XR_SEMANTIC_LABEL_WALL_BD")]
    Wall = 3,

    [NativeName("XR_SEMANTIC_LABEL_DOOR_BD")]
    Door = 4,

    [NativeName("XR_SEMANTIC_LABEL_WINDOW_BD")]
    Window = 5,

    [NativeName("XR_SEMANTIC_LABEL_OPENING_BD")]
    Opening = 6,

    [NativeName("XR_SEMANTIC_LABEL_TABLE_BD")]
    Table = 7,

    [NativeName("XR_SEMANTIC_LABEL_SOFA_BD")]
    Sofa = 8,

    [NativeName("XR_SEMANTIC_LABEL_CHAIR_BD")]
    Chair = 9,

    [NativeName("XR_SEMANTIC_LABEL_HUMAN_BD")]
    Human = 10,

    [NativeName("XR_SEMANTIC_LABEL_BEAM_BD")]
    Beam = 11,

    [NativeName("XR_SEMANTIC_LABEL_COLUMN_BD")]
    Column = 12,

    [NativeName("XR_SEMANTIC_LABEL_CURTAIN_BD")]
    Curtain = 13,

    [NativeName("XR_SEMANTIC_LABEL_CABINET_BD")]
    Cabinet = 14,

    [NativeName("XR_SEMANTIC_LABEL_BED_BD")]
    Bed = 15,

    [NativeName("XR_SEMANTIC_LABEL_PLANT_BD")]
    Plant = 16,

    [NativeName("XR_SEMANTIC_LABEL_SCREEN_BD")]
    Screen = 17,

    [NativeName("XR_SEMANTIC_LABEL_VIRTUAL_WALL_BD")]
    VirtualWall = 18,

    [NativeName("XR_SEMANTIC_LABEL_REFRIGERATOR_BD")]
    Refrigerator = 19,

    [NativeName("XR_SEMANTIC_LABEL_WASHING_MACHINE_BD")]
    WashingMachine = 20,

    [NativeName("XR_SEMANTIC_LABEL_AIR_CONDITIONER_BD")]
    AirConditioner = 21,

    [NativeName("XR_SEMANTIC_LABEL_LAMP_BD")]
    Lamp = 22,

    [NativeName("XR_SEMANTIC_LABEL_WALL_ART_BD")]
    WallArt = 23,

    [NativeName("XR_SEMANTIC_LABEL_STAIRWAY_BD")]
    Stairway = 24,
}
