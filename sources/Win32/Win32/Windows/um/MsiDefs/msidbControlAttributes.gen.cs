// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum msidbControlAttributes
{
    msidbControlAttributesVisible = 0x00000001,
    msidbControlAttributesEnabled = 0x00000002,
    msidbControlAttributesSunken = 0x00000004,
    msidbControlAttributesIndirect = 0x00000008,
    msidbControlAttributesInteger = 0x00000010,
    msidbControlAttributesRTLRO = 0x00000020,
    msidbControlAttributesRightAligned = 0x00000040,
    msidbControlAttributesLeftScroll = 0x00000080,
    msidbControlAttributesBiDi =
        msidbControlAttributesRTLRO
        | msidbControlAttributesRightAligned
        | msidbControlAttributesLeftScroll,
    msidbControlAttributesTransparent = 0x00010000,
    msidbControlAttributesNoPrefix = 0x00020000,
    msidbControlAttributesNoWrap = 0x00040000,
    msidbControlAttributesFormatSize = 0x00080000,
    msidbControlAttributesUsersLanguage = 0x00100000,
    msidbControlAttributesMultiline = 0x00010000,
    msidbControlAttributesPasswordInput = 0x00200000,
    msidbControlAttributesProgress95 = 0x00010000,
    msidbControlAttributesRemovableVolume = 0x00010000,
    msidbControlAttributesFixedVolume = 0x00020000,
    msidbControlAttributesRemoteVolume = 0x00040000,
    msidbControlAttributesCDROMVolume = 0x00080000,
    msidbControlAttributesRAMDiskVolume = 0x00100000,
    msidbControlAttributesFloppyVolume = 0x00200000,
    msidbControlShowRollbackCost = 0x00400000,
    msidbControlAttributesSorted = 0x00010000,
    msidbControlAttributesComboList = 0x00020000,
    msidbControlAttributesImageHandle = 0x00010000,
    msidbControlAttributesPushLike = 0x00020000,
    msidbControlAttributesBitmap = 0x00040000,
    msidbControlAttributesIcon = 0x00080000,
    msidbControlAttributesFixedSize = 0x00100000,
    msidbControlAttributesIconSize16 = 0x00200000,
    msidbControlAttributesIconSize32 = 0x00400000,
    msidbControlAttributesIconSize48 = 0x00600000,
    msidbControlAttributesElevationShield = 0x00800000,
    msidbControlAttributesHasBorder = 0x01000000,
}
