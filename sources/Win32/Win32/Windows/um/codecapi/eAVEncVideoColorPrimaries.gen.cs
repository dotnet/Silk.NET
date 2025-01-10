// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum eAVEncVideoColorPrimaries
{
    eAVEncVideoColorPrimaries_SameAsSource = 0,
    eAVEncVideoColorPrimaries_Reserved = 1,
    eAVEncVideoColorPrimaries_BT709 = 2,
    eAVEncVideoColorPrimaries_BT470_2_SysM = 3,
    eAVEncVideoColorPrimaries_BT470_2_SysBG = 4,
    eAVEncVideoColorPrimaries_SMPTE170M = 5,
    eAVEncVideoColorPrimaries_SMPTE240M = 6,
    eAVEncVideoColorPrimaries_EBU3231 = 7,
    eAVEncVideoColorPrimaries_SMPTE_C = 8,
}
