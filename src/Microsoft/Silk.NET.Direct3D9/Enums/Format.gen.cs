// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DFORMAT")]
    public enum Format : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3DFMT_UNKNOWN")]
        FmtUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"R8G8B8\"")]
        [NativeName("Name", "D3DFMT_R8G8B8")]
        FmtR8G8B8 = 0x14,
        [Obsolete("Deprecated in favour of \"A8R8G8B8\"")]
        [NativeName("Name", "D3DFMT_A8R8G8B8")]
        FmtA8R8G8B8 = 0x15,
        [Obsolete("Deprecated in favour of \"X8R8G8B8\"")]
        [NativeName("Name", "D3DFMT_X8R8G8B8")]
        FmtX8R8G8B8 = 0x16,
        [Obsolete("Deprecated in favour of \"R5G6B5\"")]
        [NativeName("Name", "D3DFMT_R5G6B5")]
        FmtR5G6B5 = 0x17,
        [Obsolete("Deprecated in favour of \"X1R5G5B5\"")]
        [NativeName("Name", "D3DFMT_X1R5G5B5")]
        FmtX1R5G5B5 = 0x18,
        [Obsolete("Deprecated in favour of \"A1R5G5B5\"")]
        [NativeName("Name", "D3DFMT_A1R5G5B5")]
        FmtA1R5G5B5 = 0x19,
        [Obsolete("Deprecated in favour of \"A4R4G4B4\"")]
        [NativeName("Name", "D3DFMT_A4R4G4B4")]
        FmtA4R4G4B4 = 0x1A,
        [Obsolete("Deprecated in favour of \"R3G3B2\"")]
        [NativeName("Name", "D3DFMT_R3G3B2")]
        FmtR3G3B2 = 0x1B,
        [Obsolete("Deprecated in favour of \"A8\"")]
        [NativeName("Name", "D3DFMT_A8")]
        FmtA8 = 0x1C,
        [Obsolete("Deprecated in favour of \"A8R3G3B2\"")]
        [NativeName("Name", "D3DFMT_A8R3G3B2")]
        FmtA8R3G3B2 = 0x1D,
        [Obsolete("Deprecated in favour of \"X4R4G4B4\"")]
        [NativeName("Name", "D3DFMT_X4R4G4B4")]
        FmtX4R4G4B4 = 0x1E,
        [Obsolete("Deprecated in favour of \"A2B10G10R10\"")]
        [NativeName("Name", "D3DFMT_A2B10G10R10")]
        FmtA2B10G10R10 = 0x1F,
        [Obsolete("Deprecated in favour of \"A8B8G8R8\"")]
        [NativeName("Name", "D3DFMT_A8B8G8R8")]
        FmtA8B8G8R8 = 0x20,
        [Obsolete("Deprecated in favour of \"X8B8G8R8\"")]
        [NativeName("Name", "D3DFMT_X8B8G8R8")]
        FmtX8B8G8R8 = 0x21,
        [Obsolete("Deprecated in favour of \"G16R16\"")]
        [NativeName("Name", "D3DFMT_G16R16")]
        FmtG16R16 = 0x22,
        [Obsolete("Deprecated in favour of \"A2R10G10B10\"")]
        [NativeName("Name", "D3DFMT_A2R10G10B10")]
        FmtA2R10G10B10 = 0x23,
        [Obsolete("Deprecated in favour of \"A16B16G16R16\"")]
        [NativeName("Name", "D3DFMT_A16B16G16R16")]
        FmtA16B16G16R16 = 0x24,
        [Obsolete("Deprecated in favour of \"A8P8\"")]
        [NativeName("Name", "D3DFMT_A8P8")]
        FmtA8P8 = 0x28,
        [Obsolete("Deprecated in favour of \"P8\"")]
        [NativeName("Name", "D3DFMT_P8")]
        FmtP8 = 0x29,
        [Obsolete("Deprecated in favour of \"L8\"")]
        [NativeName("Name", "D3DFMT_L8")]
        FmtL8 = 0x32,
        [Obsolete("Deprecated in favour of \"A8L8\"")]
        [NativeName("Name", "D3DFMT_A8L8")]
        FmtA8L8 = 0x33,
        [Obsolete("Deprecated in favour of \"A4L4\"")]
        [NativeName("Name", "D3DFMT_A4L4")]
        FmtA4L4 = 0x34,
        [Obsolete("Deprecated in favour of \"V8U8\"")]
        [NativeName("Name", "D3DFMT_V8U8")]
        FmtV8U8 = 0x3C,
        [Obsolete("Deprecated in favour of \"L6V5U5\"")]
        [NativeName("Name", "D3DFMT_L6V5U5")]
        FmtL6V5U5 = 0x3D,
        [Obsolete("Deprecated in favour of \"X8L8V8U8\"")]
        [NativeName("Name", "D3DFMT_X8L8V8U8")]
        FmtX8L8V8U8 = 0x3E,
        [Obsolete("Deprecated in favour of \"Q8W8V8U8\"")]
        [NativeName("Name", "D3DFMT_Q8W8V8U8")]
        FmtQ8W8V8U8 = 0x3F,
        [Obsolete("Deprecated in favour of \"V16U16\"")]
        [NativeName("Name", "D3DFMT_V16U16")]
        FmtV16U16 = 0x40,
        [Obsolete("Deprecated in favour of \"A2W10V10U10\"")]
        [NativeName("Name", "D3DFMT_A2W10V10U10")]
        FmtA2W10V10U10 = 0x43,
        [Obsolete("Deprecated in favour of \"Uyvy\"")]
        [NativeName("Name", "D3DFMT_UYVY")]
        FmtUyvy = 0x59565955,
        [Obsolete("Deprecated in favour of \"R8G8B8G8\"")]
        [NativeName("Name", "D3DFMT_R8G8_B8G8")]
        FmtR8G8B8G8 = 0x47424752,
        [Obsolete("Deprecated in favour of \"Yuy2\"")]
        [NativeName("Name", "D3DFMT_YUY2")]
        FmtYuy2 = 0x32595559,
        [Obsolete("Deprecated in favour of \"G8R8G8B8\"")]
        [NativeName("Name", "D3DFMT_G8R8_G8B8")]
        FmtG8R8G8B8 = 0x42475247,
        [Obsolete("Deprecated in favour of \"Dxt1\"")]
        [NativeName("Name", "D3DFMT_DXT1")]
        FmtDxt1 = 0x31545844,
        [Obsolete("Deprecated in favour of \"Dxt2\"")]
        [NativeName("Name", "D3DFMT_DXT2")]
        FmtDxt2 = 0x32545844,
        [Obsolete("Deprecated in favour of \"Dxt3\"")]
        [NativeName("Name", "D3DFMT_DXT3")]
        FmtDxt3 = 0x33545844,
        [Obsolete("Deprecated in favour of \"Dxt4\"")]
        [NativeName("Name", "D3DFMT_DXT4")]
        FmtDxt4 = 0x34545844,
        [Obsolete("Deprecated in favour of \"Dxt5\"")]
        [NativeName("Name", "D3DFMT_DXT5")]
        FmtDxt5 = 0x35545844,
        [Obsolete("Deprecated in favour of \"D16Lockable\"")]
        [NativeName("Name", "D3DFMT_D16_LOCKABLE")]
        FmtD16Lockable = 0x46,
        [Obsolete("Deprecated in favour of \"D32\"")]
        [NativeName("Name", "D3DFMT_D32")]
        FmtD32 = 0x47,
        [Obsolete("Deprecated in favour of \"D15S1\"")]
        [NativeName("Name", "D3DFMT_D15S1")]
        FmtD15S1 = 0x49,
        [Obsolete("Deprecated in favour of \"D24S8\"")]
        [NativeName("Name", "D3DFMT_D24S8")]
        FmtD24S8 = 0x4B,
        [Obsolete("Deprecated in favour of \"D24X8\"")]
        [NativeName("Name", "D3DFMT_D24X8")]
        FmtD24X8 = 0x4D,
        [Obsolete("Deprecated in favour of \"D24X4S4\"")]
        [NativeName("Name", "D3DFMT_D24X4S4")]
        FmtD24X4S4 = 0x4F,
        [Obsolete("Deprecated in favour of \"D16\"")]
        [NativeName("Name", "D3DFMT_D16")]
        FmtD16 = 0x50,
        [Obsolete("Deprecated in favour of \"D32fLockable\"")]
        [NativeName("Name", "D3DFMT_D32F_LOCKABLE")]
        FmtD32fLockable = 0x52,
        [Obsolete("Deprecated in favour of \"D24fS8\"")]
        [NativeName("Name", "D3DFMT_D24FS8")]
        FmtD24fS8 = 0x53,
        [Obsolete("Deprecated in favour of \"D32Lockable\"")]
        [NativeName("Name", "D3DFMT_D32_LOCKABLE")]
        FmtD32Lockable = 0x54,
        [Obsolete("Deprecated in favour of \"S8Lockable\"")]
        [NativeName("Name", "D3DFMT_S8_LOCKABLE")]
        FmtS8Lockable = 0x55,
        [Obsolete("Deprecated in favour of \"L16\"")]
        [NativeName("Name", "D3DFMT_L16")]
        FmtL16 = 0x51,
        [Obsolete("Deprecated in favour of \"Vertexdata\"")]
        [NativeName("Name", "D3DFMT_VERTEXDATA")]
        FmtVertexdata = 0x64,
        [Obsolete("Deprecated in favour of \"Index16\"")]
        [NativeName("Name", "D3DFMT_INDEX16")]
        FmtIndex16 = 0x65,
        [Obsolete("Deprecated in favour of \"Index32\"")]
        [NativeName("Name", "D3DFMT_INDEX32")]
        FmtIndex32 = 0x66,
        [Obsolete("Deprecated in favour of \"Q16W16V16U16\"")]
        [NativeName("Name", "D3DFMT_Q16W16V16U16")]
        FmtQ16W16V16U16 = 0x6E,
        [Obsolete("Deprecated in favour of \"Multi2Argb8\"")]
        [NativeName("Name", "D3DFMT_MULTI2_ARGB8")]
        FmtMulti2Argb8 = 0x3154454D,
        [Obsolete("Deprecated in favour of \"R16f\"")]
        [NativeName("Name", "D3DFMT_R16F")]
        FmtR16f = 0x6F,
        [Obsolete("Deprecated in favour of \"G16R16f\"")]
        [NativeName("Name", "D3DFMT_G16R16F")]
        FmtG16R16f = 0x70,
        [Obsolete("Deprecated in favour of \"A16B16G16R16f\"")]
        [NativeName("Name", "D3DFMT_A16B16G16R16F")]
        FmtA16B16G16R16f = 0x71,
        [Obsolete("Deprecated in favour of \"R32f\"")]
        [NativeName("Name", "D3DFMT_R32F")]
        FmtR32f = 0x72,
        [Obsolete("Deprecated in favour of \"G32R32f\"")]
        [NativeName("Name", "D3DFMT_G32R32F")]
        FmtG32R32f = 0x73,
        [Obsolete("Deprecated in favour of \"A32B32G32R32f\"")]
        [NativeName("Name", "D3DFMT_A32B32G32R32F")]
        FmtA32B32G32R32f = 0x74,
        [Obsolete("Deprecated in favour of \"CxV8U8\"")]
        [NativeName("Name", "D3DFMT_CxV8U8")]
        FmtCxV8U8 = 0x75,
        [Obsolete("Deprecated in favour of \"A1\"")]
        [NativeName("Name", "D3DFMT_A1")]
        FmtA1 = 0x76,
        [Obsolete("Deprecated in favour of \"A2B10G10R10XRBias\"")]
        [NativeName("Name", "D3DFMT_A2B10G10R10_XR_BIAS")]
        FmtA2B10G10R10XRBias = 0x77,
        [Obsolete("Deprecated in favour of \"Binarybuffer\"")]
        [NativeName("Name", "D3DFMT_BINARYBUFFER")]
        FmtBinarybuffer = 0xC7,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DFMT_FORCE_DWORD")]
        FmtForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DFMT_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D3DFMT_R8G8B8")]
        R8G8B8 = 0x14,
        [NativeName("Name", "D3DFMT_A8R8G8B8")]
        A8R8G8B8 = 0x15,
        [NativeName("Name", "D3DFMT_X8R8G8B8")]
        X8R8G8B8 = 0x16,
        [NativeName("Name", "D3DFMT_R5G6B5")]
        R5G6B5 = 0x17,
        [NativeName("Name", "D3DFMT_X1R5G5B5")]
        X1R5G5B5 = 0x18,
        [NativeName("Name", "D3DFMT_A1R5G5B5")]
        A1R5G5B5 = 0x19,
        [NativeName("Name", "D3DFMT_A4R4G4B4")]
        A4R4G4B4 = 0x1A,
        [NativeName("Name", "D3DFMT_R3G3B2")]
        R3G3B2 = 0x1B,
        [NativeName("Name", "D3DFMT_A8")]
        A8 = 0x1C,
        [NativeName("Name", "D3DFMT_A8R3G3B2")]
        A8R3G3B2 = 0x1D,
        [NativeName("Name", "D3DFMT_X4R4G4B4")]
        X4R4G4B4 = 0x1E,
        [NativeName("Name", "D3DFMT_A2B10G10R10")]
        A2B10G10R10 = 0x1F,
        [NativeName("Name", "D3DFMT_A8B8G8R8")]
        A8B8G8R8 = 0x20,
        [NativeName("Name", "D3DFMT_X8B8G8R8")]
        X8B8G8R8 = 0x21,
        [NativeName("Name", "D3DFMT_G16R16")]
        G16R16 = 0x22,
        [NativeName("Name", "D3DFMT_A2R10G10B10")]
        A2R10G10B10 = 0x23,
        [NativeName("Name", "D3DFMT_A16B16G16R16")]
        A16B16G16R16 = 0x24,
        [NativeName("Name", "D3DFMT_A8P8")]
        A8P8 = 0x28,
        [NativeName("Name", "D3DFMT_P8")]
        P8 = 0x29,
        [NativeName("Name", "D3DFMT_L8")]
        L8 = 0x32,
        [NativeName("Name", "D3DFMT_A8L8")]
        A8L8 = 0x33,
        [NativeName("Name", "D3DFMT_A4L4")]
        A4L4 = 0x34,
        [NativeName("Name", "D3DFMT_V8U8")]
        V8U8 = 0x3C,
        [NativeName("Name", "D3DFMT_L6V5U5")]
        L6V5U5 = 0x3D,
        [NativeName("Name", "D3DFMT_X8L8V8U8")]
        X8L8V8U8 = 0x3E,
        [NativeName("Name", "D3DFMT_Q8W8V8U8")]
        Q8W8V8U8 = 0x3F,
        [NativeName("Name", "D3DFMT_V16U16")]
        V16U16 = 0x40,
        [NativeName("Name", "D3DFMT_A2W10V10U10")]
        A2W10V10U10 = 0x43,
        [NativeName("Name", "D3DFMT_UYVY")]
        Uyvy = 0x59565955,
        [NativeName("Name", "D3DFMT_R8G8_B8G8")]
        R8G8B8G8 = 0x47424752,
        [NativeName("Name", "D3DFMT_YUY2")]
        Yuy2 = 0x32595559,
        [NativeName("Name", "D3DFMT_G8R8_G8B8")]
        G8R8G8B8 = 0x42475247,
        [NativeName("Name", "D3DFMT_DXT1")]
        Dxt1 = 0x31545844,
        [NativeName("Name", "D3DFMT_DXT2")]
        Dxt2 = 0x32545844,
        [NativeName("Name", "D3DFMT_DXT3")]
        Dxt3 = 0x33545844,
        [NativeName("Name", "D3DFMT_DXT4")]
        Dxt4 = 0x34545844,
        [NativeName("Name", "D3DFMT_DXT5")]
        Dxt5 = 0x35545844,
        [NativeName("Name", "D3DFMT_D16_LOCKABLE")]
        D16Lockable = 0x46,
        [NativeName("Name", "D3DFMT_D32")]
        D32 = 0x47,
        [NativeName("Name", "D3DFMT_D15S1")]
        D15S1 = 0x49,
        [NativeName("Name", "D3DFMT_D24S8")]
        D24S8 = 0x4B,
        [NativeName("Name", "D3DFMT_D24X8")]
        D24X8 = 0x4D,
        [NativeName("Name", "D3DFMT_D24X4S4")]
        D24X4S4 = 0x4F,
        [NativeName("Name", "D3DFMT_D16")]
        D16 = 0x50,
        [NativeName("Name", "D3DFMT_D32F_LOCKABLE")]
        D32fLockable = 0x52,
        [NativeName("Name", "D3DFMT_D24FS8")]
        D24fS8 = 0x53,
        [NativeName("Name", "D3DFMT_D32_LOCKABLE")]
        D32Lockable = 0x54,
        [NativeName("Name", "D3DFMT_S8_LOCKABLE")]
        S8Lockable = 0x55,
        [NativeName("Name", "D3DFMT_L16")]
        L16 = 0x51,
        [NativeName("Name", "D3DFMT_VERTEXDATA")]
        Vertexdata = 0x64,
        [NativeName("Name", "D3DFMT_INDEX16")]
        Index16 = 0x65,
        [NativeName("Name", "D3DFMT_INDEX32")]
        Index32 = 0x66,
        [NativeName("Name", "D3DFMT_Q16W16V16U16")]
        Q16W16V16U16 = 0x6E,
        [NativeName("Name", "D3DFMT_MULTI2_ARGB8")]
        Multi2Argb8 = 0x3154454D,
        [NativeName("Name", "D3DFMT_R16F")]
        R16f = 0x6F,
        [NativeName("Name", "D3DFMT_G16R16F")]
        G16R16f = 0x70,
        [NativeName("Name", "D3DFMT_A16B16G16R16F")]
        A16B16G16R16f = 0x71,
        [NativeName("Name", "D3DFMT_R32F")]
        R32f = 0x72,
        [NativeName("Name", "D3DFMT_G32R32F")]
        G32R32f = 0x73,
        [NativeName("Name", "D3DFMT_A32B32G32R32F")]
        A32B32G32R32f = 0x74,
        [NativeName("Name", "D3DFMT_CxV8U8")]
        CxV8U8 = 0x75,
        [NativeName("Name", "D3DFMT_A1")]
        A1 = 0x76,
        [NativeName("Name", "D3DFMT_A2B10G10R10_XR_BIAS")]
        A2B10G10R10XRBias = 0x77,
        [NativeName("Name", "D3DFMT_BINARYBUFFER")]
        Binarybuffer = 0xC7,
        [NativeName("Name", "D3DFMT_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
