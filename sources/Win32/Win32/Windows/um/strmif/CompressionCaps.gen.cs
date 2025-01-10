// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CompressionCaps
{
    CompressionCaps_CanQuality = 0x1,
    CompressionCaps_CanCrunch = 0x2,
    CompressionCaps_CanKeyFrame = 0x4,
    CompressionCaps_CanBFrame = 0x8,
    CompressionCaps_CanWindow = 0x10,
}
