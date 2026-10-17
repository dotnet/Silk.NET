// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSoundObstacleMaterialTypeBD")]
public enum SoundObstacleMaterialTypeBD : uint
{
    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_ACOUSTIC_TILE_BD")]
    AcousticTile = 0,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_BRICK_BD")]
    Brick = 1,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_BRICK_PAINTED_BD")]
    BrickPainted = 2,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CARPET_BD")]
    Carpet = 3,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CARPET_HEAVY_BD")]
    CarpetHeavy = 4,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CARPET_HEAVY_PADDED_BD")]
    CarpetHeavyPadded = 5,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CERAMIC_TILE_BD")]
    CeramicTile = 6,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CONCRETE_BD")]
    Concrete = 7,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CONCRETE_ROUGH_BD")]
    ConcreteRough = 8,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CONCRETE_BLOCK_BD")]
    ConcreteBlock = 9,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CONCRETE_BLOCK_PAINTED_BD")]
    ConcreteBlockPainted = 10,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CURTAIN_BD")]
    Curtain = 11,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_FOLIAGE_BD")]
    Foliage = 12,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_GLASS_BD")]
    Glass = 13,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_GLASS_HEAVY_BD")]
    GlassHeavy = 14,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_GRASS_BD")]
    Grass = 15,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_GRAVEL_BD")]
    Gravel = 16,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_GYPSUM_BOARD_BD")]
    GypsumBoard = 17,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_PLASTER_ON_BRICK_BD")]
    PlasterOnBrick = 18,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_PLASTER_ON_CONCRETE_BLOCK_BD")]
    PlasterOnConcreteBlock = 19,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_SOIL_BD")]
    Soil = 20,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_SOUND_PROOF_BD")]
    SoundProof = 21,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_SNOW_BD")]
    Snow = 22,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_STEEL_BD")]
    Steel = 23,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_WATER_BD")]
    Water = 24,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_WOOD_THIN_BD")]
    WoodThin = 25,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_WOOD_THICK_BD")]
    WoodThick = 26,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_WOOD_FLOOR_BD")]
    WoodFloor = 27,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_WOOD_ON_CONCRETE_BD")]
    WoodOnConcrete = 28,

    [NativeName("XR_SOUND_OBSTACLE_MATERIAL_TYPE_CUSTOM_BD")]
    Custom = 29,
}
