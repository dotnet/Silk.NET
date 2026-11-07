// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSemanticLabelBD")]
[SupportedApiProfile("openxr")]
public enum SemanticLabelBD : uint
{
    [NativeName("XR_SEMANTIC_LABEL_UNKNOWN_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Unknown = 0,

    [NativeName("XR_SEMANTIC_LABEL_FLOOR_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Floor = 1,

    [NativeName("XR_SEMANTIC_LABEL_CEILING_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Ceiling = 2,

    [NativeName("XR_SEMANTIC_LABEL_WALL_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Wall = 3,

    [NativeName("XR_SEMANTIC_LABEL_DOOR_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Door = 4,

    [NativeName("XR_SEMANTIC_LABEL_WINDOW_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Window = 5,

    [NativeName("XR_SEMANTIC_LABEL_OPENING_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Opening = 6,

    [NativeName("XR_SEMANTIC_LABEL_TABLE_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Table = 7,

    [NativeName("XR_SEMANTIC_LABEL_SOFA_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Sofa = 8,

    [NativeName("XR_SEMANTIC_LABEL_CHAIR_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Chair = 9,

    [NativeName("XR_SEMANTIC_LABEL_HUMAN_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Human = 10,

    [NativeName("XR_SEMANTIC_LABEL_BEAM_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Beam = 11,

    [NativeName("XR_SEMANTIC_LABEL_COLUMN_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Column = 12,

    [NativeName("XR_SEMANTIC_LABEL_CURTAIN_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Curtain = 13,

    [NativeName("XR_SEMANTIC_LABEL_CABINET_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Cabinet = 14,

    [NativeName("XR_SEMANTIC_LABEL_BED_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Bed = 15,

    [NativeName("XR_SEMANTIC_LABEL_PLANT_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Plant = 16,

    [NativeName("XR_SEMANTIC_LABEL_SCREEN_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Screen = 17,

    [NativeName("XR_SEMANTIC_LABEL_VIRTUAL_WALL_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    VirtualWall = 18,

    [NativeName("XR_SEMANTIC_LABEL_REFRIGERATOR_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Refrigerator = 19,

    [NativeName("XR_SEMANTIC_LABEL_WASHING_MACHINE_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    WashingMachine = 20,

    [NativeName("XR_SEMANTIC_LABEL_AIR_CONDITIONER_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    AirConditioner = 21,

    [NativeName("XR_SEMANTIC_LABEL_LAMP_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Lamp = 22,

    [NativeName("XR_SEMANTIC_LABEL_WALL_ART_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    WallArt = 23,

    [NativeName("XR_SEMANTIC_LABEL_STAIRWAY_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Stairway = 24,
}
