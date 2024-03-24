// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Reflect
{
    [Flags]
    [NativeName("Name", "SpvReflectDecorationFlagBits")]
    public enum DecorationFlagBits : int
    {
        [NativeName("Name", "SPV_REFLECT_DECORATION_NONE")]
        None = 0x0,
        [NativeName("Name", "SPV_REFLECT_DECORATION_BLOCK")]
        Block = 0x1,
        [NativeName("Name", "SPV_REFLECT_DECORATION_BUFFER_BLOCK")]
        BufferBlock = 0x2,
        [NativeName("Name", "SPV_REFLECT_DECORATION_ROW_MAJOR")]
        RowMajor = 0x4,
        [NativeName("Name", "SPV_REFLECT_DECORATION_COLUMN_MAJOR")]
        ColumnMajor = 0x8,
        [NativeName("Name", "SPV_REFLECT_DECORATION_BUILT_IN")]
        BuiltIn = 0x10,
        [NativeName("Name", "SPV_REFLECT_DECORATION_NOPERSPECTIVE")]
        Noperspective = 0x20,
        [NativeName("Name", "SPV_REFLECT_DECORATION_FLAT")]
        Flat = 0x40,
        [NativeName("Name", "SPV_REFLECT_DECORATION_NON_WRITABLE")]
        NonWritable = 0x80,
        [NativeName("Name", "SPV_REFLECT_DECORATION_RELAXED_PRECISION")]
        RelaxedPrecision = 0x100,
        [NativeName("Name", "SPV_REFLECT_DECORATION_NON_READABLE")]
        NonReadable = 0x200,
        [NativeName("Name", "SPV_REFLECT_DECORATION_PATCH")]
        Patch = 0x400,
        [NativeName("Name", "SPV_REFLECT_DECORATION_PER_VERTEX")]
        PerVertex = 0x800,
        [NativeName("Name", "SPV_REFLECT_DECORATION_PER_TASK")]
        PerTask = 0x1000,
        [NativeName("Name", "SPV_REFLECT_DECORATION_WEIGHT_TEXTURE")]
        WeightTexture = 0x2000,
        [NativeName("Name", "SPV_REFLECT_DECORATION_BLOCK_MATCH_TEXTURE")]
        BlockMatchTexture = 0x4000,
    }
}
