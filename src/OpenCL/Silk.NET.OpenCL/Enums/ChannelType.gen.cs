// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_channel_type")]
    public enum ChannelType : int
    {
        [NativeName("Name", "CL_SNORM_INT8")]
        SNormInt8 = 0x10D0,
        [NativeName("Name", "CL_SNORM_INT16")]
        SNormInt16 = 0x10D1,
        [NativeName("Name", "CL_UNORM_INT8")]
        UnormInt8 = 0x10D2,
        [NativeName("Name", "CL_UNORM_INT16")]
        UnormInt16 = 0x10D3,
        [NativeName("Name", "CL_UNORM_SHORT_565")]
        UnormShort565 = 0x10D4,
        [NativeName("Name", "CL_UNORM_SHORT_555")]
        UnormShort555 = 0x10D5,
        [NativeName("Name", "CL_UNORM_INT_101010")]
        UnormInt101010 = 0x10D6,
        [NativeName("Name", "CL_SIGNED_INT8")]
        SignedInt8 = 0x10D7,
        [NativeName("Name", "CL_SIGNED_INT16")]
        SignedInt16 = 0x10D8,
        [NativeName("Name", "CL_SIGNED_INT32")]
        SignedInt32 = 0x10D9,
        [NativeName("Name", "CL_UNSIGNED_INT8")]
        UnsignedInt8 = 0x10DA,
        [NativeName("Name", "CL_UNSIGNED_INT16")]
        UnsignedInt16 = 0x10DB,
        [NativeName("Name", "CL_UNSIGNED_INT32")]
        UnsignedInt32 = 0x10DC,
        [NativeName("Name", "CL_HALF_FLOAT")]
        HalfFloat = 0x10DD,
        [NativeName("Name", "CL_FLOAT")]
        Float = 0x10DE,
        [NativeName("Name", "CL_UNORM_INT_101010_2")]
        UnormInt1010102 = 0x10E0,
        [NativeName("Name", "CL_UNORM_INT24")]
        UnormInt24 = 0x10DF,
        [NativeName("Name", "CL_UNSIGNED_INT_RAW10_EXT")]
        UnsignedIntRaw10Ext = 0x10E3,
        [NativeName("Name", "CL_UNSIGNED_INT_RAW12_EXT")]
        UnsignedIntRaw12Ext = 0x10E4,
        [NativeName("Name", "CL_UNORM_INT_2_101010_EXT")]
        UnormInt2101010Ext = 0x10E5,
    }
}
