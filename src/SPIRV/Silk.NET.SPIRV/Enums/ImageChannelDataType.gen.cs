// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvImageChannelDataType_")]
    public enum ImageChannelDataType : int
    {
        [NativeName("Name", "SpvImageChannelDataTypeSnormInt8")]
        SnormInt8 = 0x0,
        [NativeName("Name", "SpvImageChannelDataTypeSnormInt16")]
        SnormInt16 = 0x1,
        [NativeName("Name", "SpvImageChannelDataTypeUnormInt8")]
        UnormInt8 = 0x2,
        [NativeName("Name", "SpvImageChannelDataTypeUnormInt16")]
        UnormInt16 = 0x3,
        [NativeName("Name", "SpvImageChannelDataTypeUnormShort565")]
        UnormShort565 = 0x4,
        [NativeName("Name", "SpvImageChannelDataTypeUnormShort555")]
        UnormShort555 = 0x5,
        [NativeName("Name", "SpvImageChannelDataTypeUnormInt101010")]
        UnormInt101010 = 0x6,
        [NativeName("Name", "SpvImageChannelDataTypeSignedInt8")]
        SignedInt8 = 0x7,
        [NativeName("Name", "SpvImageChannelDataTypeSignedInt16")]
        SignedInt16 = 0x8,
        [NativeName("Name", "SpvImageChannelDataTypeSignedInt32")]
        SignedInt32 = 0x9,
        [NativeName("Name", "SpvImageChannelDataTypeUnsignedInt8")]
        UnsignedInt8 = 0xA,
        [NativeName("Name", "SpvImageChannelDataTypeUnsignedInt16")]
        UnsignedInt16 = 0xB,
        [NativeName("Name", "SpvImageChannelDataTypeUnsignedInt32")]
        UnsignedInt32 = 0xC,
        [NativeName("Name", "SpvImageChannelDataTypeHalfFloat")]
        HalfFloat = 0xD,
        [NativeName("Name", "SpvImageChannelDataTypeFloat")]
        Float = 0xE,
        [NativeName("Name", "SpvImageChannelDataTypeUnormInt24")]
        UnormInt24 = 0xF,
        [NativeName("Name", "SpvImageChannelDataTypeUnormInt101010_2")]
        UnormInt1010102 = 0x10,
        [NativeName("Name", "SpvImageChannelDataTypeMax")]
        Max = 0x7FFFFFFF,
    }
}
