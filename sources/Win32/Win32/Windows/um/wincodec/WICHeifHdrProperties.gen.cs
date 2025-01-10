// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.18362.0")]
public enum WICHeifHdrProperties
{
    WICHeifHdrMaximumLuminanceLevel = 0x1,
    WICHeifHdrMaximumFrameAverageLuminanceLevel = 0x2,
    WICHeifHdrMinimumMasteringDisplayLuminanceLevel = 0x3,
    WICHeifHdrMaximumMasteringDisplayLuminanceLevel = 0x4,
    WICHeifHdrCustomVideoPrimaries = 0x5,
    WICHeifHdrProperties_FORCE_DWORD = 0x7fffffff,
}
