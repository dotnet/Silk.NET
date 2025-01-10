// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WICTiffCompressionOption
{
    WICTiffCompressionDontCare = 0,
    WICTiffCompressionNone = 0x1,
    WICTiffCompressionCCITT3 = 0x2,
    WICTiffCompressionCCITT4 = 0x3,
    WICTiffCompressionLZW = 0x4,
    WICTiffCompressionRLE = 0x5,
    WICTiffCompressionZIP = 0x6,
    WICTiffCompressionLZWHDifferencing = 0x7,
    WICTIFFCOMPRESSIONOPTION_FORCE_DWORD = 0x7fffffff,
}
