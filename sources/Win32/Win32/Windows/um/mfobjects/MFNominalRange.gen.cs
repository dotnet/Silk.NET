// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MFNominalRange
{
    MFNominalRange_Unknown = 0,
    MFNominalRange_Normal = 1,
    MFNominalRange_Wide = 2,
    MFNominalRange_0_255 = 1,
    MFNominalRange_16_235 = 2,
    MFNominalRange_48_208 = 3,
    MFNominalRange_64_127 = 4,
    MFNominalRange_Last = (MFNominalRange_64_127 + 1),
    MFNominalRange_ForceDWORD = 0x7fffffff,
}
