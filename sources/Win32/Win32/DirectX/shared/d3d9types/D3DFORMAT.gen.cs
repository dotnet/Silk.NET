// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3DFORMAT
{
    D3DFMT_UNKNOWN = 0,
    D3DFMT_R8G8B8 = 20,
    D3DFMT_A8R8G8B8 = 21,
    D3DFMT_X8R8G8B8 = 22,
    D3DFMT_R5G6B5 = 23,
    D3DFMT_X1R5G5B5 = 24,
    D3DFMT_A1R5G5B5 = 25,
    D3DFMT_A4R4G4B4 = 26,
    D3DFMT_R3G3B2 = 27,
    D3DFMT_A8 = 28,
    D3DFMT_A8R3G3B2 = 29,
    D3DFMT_X4R4G4B4 = 30,
    D3DFMT_A2B10G10R10 = 31,
    D3DFMT_A8B8G8R8 = 32,
    D3DFMT_X8B8G8R8 = 33,
    D3DFMT_G16R16 = 34,
    D3DFMT_A2R10G10B10 = 35,
    D3DFMT_A16B16G16R16 = 36,
    D3DFMT_A8P8 = 40,
    D3DFMT_P8 = 41,
    D3DFMT_L8 = 50,
    D3DFMT_A8L8 = 51,
    D3DFMT_A4L4 = 52,
    D3DFMT_V8U8 = 60,
    D3DFMT_L6V5U5 = 61,
    D3DFMT_X8L8V8U8 = 62,
    D3DFMT_Q8W8V8U8 = 63,
    D3DFMT_V16U16 = 64,
    D3DFMT_A2W10V10U10 = 67,
    D3DFMT_UYVY =
        unchecked(
            (int)(
                (uint)((byte)('U'))
                | ((uint)((byte)('Y')) << 8)
                | ((uint)((byte)('V')) << 16)
                | ((uint)((byte)('Y')) << 24)
            )
        ),
    D3DFMT_R8G8_B8G8 =
        unchecked(
            (int)(
                (uint)((byte)('R'))
                | ((uint)((byte)('G')) << 8)
                | ((uint)((byte)('B')) << 16)
                | ((uint)((byte)('G')) << 24)
            )
        ),
    D3DFMT_YUY2 =
        unchecked(
            (int)(
                (uint)((byte)('Y'))
                | ((uint)((byte)('U')) << 8)
                | ((uint)((byte)('Y')) << 16)
                | ((uint)((byte)('2')) << 24)
            )
        ),
    D3DFMT_G8R8_G8B8 =
        unchecked(
            (int)(
                (uint)((byte)('G'))
                | ((uint)((byte)('R')) << 8)
                | ((uint)((byte)('G')) << 16)
                | ((uint)((byte)('B')) << 24)
            )
        ),
    D3DFMT_DXT1 =
        unchecked(
            (int)(
                (uint)((byte)('D'))
                | ((uint)((byte)('X')) << 8)
                | ((uint)((byte)('T')) << 16)
                | ((uint)((byte)('1')) << 24)
            )
        ),
    D3DFMT_DXT2 =
        unchecked(
            (int)(
                (uint)((byte)('D'))
                | ((uint)((byte)('X')) << 8)
                | ((uint)((byte)('T')) << 16)
                | ((uint)((byte)('2')) << 24)
            )
        ),
    D3DFMT_DXT3 =
        unchecked(
            (int)(
                (uint)((byte)('D'))
                | ((uint)((byte)('X')) << 8)
                | ((uint)((byte)('T')) << 16)
                | ((uint)((byte)('3')) << 24)
            )
        ),
    D3DFMT_DXT4 =
        unchecked(
            (int)(
                (uint)((byte)('D'))
                | ((uint)((byte)('X')) << 8)
                | ((uint)((byte)('T')) << 16)
                | ((uint)((byte)('4')) << 24)
            )
        ),
    D3DFMT_DXT5 =
        unchecked(
            (int)(
                (uint)((byte)('D'))
                | ((uint)((byte)('X')) << 8)
                | ((uint)((byte)('T')) << 16)
                | ((uint)((byte)('5')) << 24)
            )
        ),
    D3DFMT_D16_LOCKABLE = 70,
    D3DFMT_D32 = 71,
    D3DFMT_D15S1 = 73,
    D3DFMT_D24S8 = 75,
    D3DFMT_D24X8 = 77,
    D3DFMT_D24X4S4 = 79,
    D3DFMT_D16 = 80,
    D3DFMT_D32F_LOCKABLE = 82,
    D3DFMT_D24FS8 = 83,
    D3DFMT_D32_LOCKABLE = 84,
    D3DFMT_S8_LOCKABLE = 85,
    D3DFMT_L16 = 81,
    D3DFMT_VERTEXDATA = 100,
    D3DFMT_INDEX16 = 101,
    D3DFMT_INDEX32 = 102,
    D3DFMT_Q16W16V16U16 = 110,
    D3DFMT_MULTI2_ARGB8 =
        unchecked(
            (int)(
                (uint)((byte)('M'))
                | ((uint)((byte)('E')) << 8)
                | ((uint)((byte)('T')) << 16)
                | ((uint)((byte)('1')) << 24)
            )
        ),
    D3DFMT_R16F = 111,
    D3DFMT_G16R16F = 112,
    D3DFMT_A16B16G16R16F = 113,
    D3DFMT_R32F = 114,
    D3DFMT_G32R32F = 115,
    D3DFMT_A32B32G32R32F = 116,
    D3DFMT_CxV8U8 = 117,
    D3DFMT_A1 = 118,
    D3DFMT_A2B10G10R10_XR_BIAS = 119,
    D3DFMT_BINARYBUFFER = 199,
    D3DFMT_FORCE_DWORD = 0x7fffffff,
}
