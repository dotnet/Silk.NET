// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundObstacleMaterialTypeBD")]
[SupportedApiProfile("openxr")]
public enum SoundObstacleMaterialTypeBD : uint
{
    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_ACOUSTIC_TILE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    AcousticTile = 0,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_BRICK_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Brick = 1,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_BRICK_PAINTED_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    BrickPainted = 2,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CARPET_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Carpet = 3,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CARPET_HEAVY_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    CarpetHeavy = 4,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CARPET_HEAVY_PADDED_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    CarpetHeavyPadded = 5,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CERAMIC_TILE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    CeramicTile = 6,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CONCRETE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Concrete = 7,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CONCRETE_ROUGH_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    ConcreteRough = 8,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CONCRETE_BLOCK_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    ConcreteBlock = 9,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CONCRETE_BLOCK_PAINTED_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    ConcreteBlockPainted = 10,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CURTAIN_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Curtain = 11,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_FOLIAGE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Foliage = 12,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_GLASS_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Glass = 13,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_GLASS_HEAVY_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    GlassHeavy = 14,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_GRASS_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Grass = 15,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_GRAVEL_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Gravel = 16,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_GYPSUM_BOARD_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    GypsumBoard = 17,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_PLASTER_ON_BRICK_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    PlasterOnBrick = 18,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_PLASTER_ON_CONCRETE_BLOCK_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    PlasterOnConcreteBlock = 19,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_SOIL_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Soil = 20,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_SOUND_PROOF_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    SoundProof = 21,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_SNOW_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Snow = 22,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_STEEL_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Steel = 23,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_WATER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Water = 24,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_WOOD_THIN_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    WoodThin = 25,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_WOOD_THICK_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    WoodThick = 26,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_WOOD_FLOOR_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    WoodFloor = 27,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_WOOD_ON_CONCRETE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    WoodOnConcrete = 28,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CUSTOM_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    Custom = 29,
}
