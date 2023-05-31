// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_basetype")]
    public enum Basetype : int
    {
        [NativeName("Name", "SPVC_BASETYPE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "SPVC_BASETYPE_VOID")]
        Void = 0x1,
        [NativeName("Name", "SPVC_BASETYPE_BOOLEAN")]
        Boolean = 0x2,
        [NativeName("Name", "SPVC_BASETYPE_INT8")]
        Int8 = 0x3,
        [NativeName("Name", "SPVC_BASETYPE_UINT8")]
        Uint8 = 0x4,
        [NativeName("Name", "SPVC_BASETYPE_INT16")]
        Int16 = 0x5,
        [NativeName("Name", "SPVC_BASETYPE_UINT16")]
        Uint16 = 0x6,
        [NativeName("Name", "SPVC_BASETYPE_INT32")]
        Int32 = 0x7,
        [NativeName("Name", "SPVC_BASETYPE_UINT32")]
        Uint32 = 0x8,
        [NativeName("Name", "SPVC_BASETYPE_INT64")]
        Int64 = 0x9,
        [NativeName("Name", "SPVC_BASETYPE_UINT64")]
        Uint64 = 0xA,
        [NativeName("Name", "SPVC_BASETYPE_ATOMIC_COUNTER")]
        AtomicCounter = 0xB,
        [NativeName("Name", "SPVC_BASETYPE_FP16")]
        FP16 = 0xC,
        [NativeName("Name", "SPVC_BASETYPE_FP32")]
        FP32 = 0xD,
        [NativeName("Name", "SPVC_BASETYPE_FP64")]
        FP64 = 0xE,
        [NativeName("Name", "SPVC_BASETYPE_STRUCT")]
        Struct = 0xF,
        [NativeName("Name", "SPVC_BASETYPE_IMAGE")]
        Image = 0x10,
        [NativeName("Name", "SPVC_BASETYPE_SAMPLED_IMAGE")]
        SampledImage = 0x11,
        [NativeName("Name", "SPVC_BASETYPE_SAMPLER")]
        Sampler = 0x12,
        [NativeName("Name", "SPVC_BASETYPE_ACCELERATION_STRUCTURE")]
        AccelerationStructure = 0x13,
        [NativeName("Name", "SPVC_BASETYPE_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
