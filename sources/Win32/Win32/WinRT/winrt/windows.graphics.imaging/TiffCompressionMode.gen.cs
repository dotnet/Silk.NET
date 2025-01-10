// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum TiffCompressionMode
{
    TiffCompressionMode_Automatic = 0,
    TiffCompressionMode_None = 1,
    TiffCompressionMode_Ccitt3 = 2,
    TiffCompressionMode_Ccitt4 = 3,
    TiffCompressionMode_Lzw = 4,
    TiffCompressionMode_Rle = 5,
    TiffCompressionMode_Zip = 6,
    TiffCompressionMode_LzwhDifferencing = 7,
}
