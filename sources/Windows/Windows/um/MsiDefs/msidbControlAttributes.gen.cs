// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes"]/*' />
public enum msidbControlAttributes
{
    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesVisible"]/*' />
    msidbControlAttributesVisible = 0x00000001,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesEnabled"]/*' />
    msidbControlAttributesEnabled = 0x00000002,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesSunken"]/*' />
    msidbControlAttributesSunken = 0x00000004,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesIndirect"]/*' />
    msidbControlAttributesIndirect = 0x00000008,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesInteger"]/*' />
    msidbControlAttributesInteger = 0x00000010,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesRTLRO"]/*' />
    msidbControlAttributesRTLRO = 0x00000020,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesRightAligned"]/*' />
    msidbControlAttributesRightAligned = 0x00000040,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesLeftScroll"]/*' />
    msidbControlAttributesLeftScroll = 0x00000080,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesBiDi"]/*' />
    msidbControlAttributesBiDi = msidbControlAttributesRTLRO | msidbControlAttributesRightAligned | msidbControlAttributesLeftScroll,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesTransparent"]/*' />
    msidbControlAttributesTransparent = 0x00010000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesNoPrefix"]/*' />
    msidbControlAttributesNoPrefix = 0x00020000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesNoWrap"]/*' />
    msidbControlAttributesNoWrap = 0x00040000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesFormatSize"]/*' />
    msidbControlAttributesFormatSize = 0x00080000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesUsersLanguage"]/*' />
    msidbControlAttributesUsersLanguage = 0x00100000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesMultiline"]/*' />
    msidbControlAttributesMultiline = 0x00010000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesPasswordInput"]/*' />
    msidbControlAttributesPasswordInput = 0x00200000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesProgress95"]/*' />
    msidbControlAttributesProgress95 = 0x00010000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesRemovableVolume"]/*' />
    msidbControlAttributesRemovableVolume = 0x00010000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesFixedVolume"]/*' />
    msidbControlAttributesFixedVolume = 0x00020000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesRemoteVolume"]/*' />
    msidbControlAttributesRemoteVolume = 0x00040000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesCDROMVolume"]/*' />
    msidbControlAttributesCDROMVolume = 0x00080000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesRAMDiskVolume"]/*' />
    msidbControlAttributesRAMDiskVolume = 0x00100000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesFloppyVolume"]/*' />
    msidbControlAttributesFloppyVolume = 0x00200000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlShowRollbackCost"]/*' />
    msidbControlShowRollbackCost = 0x00400000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesSorted"]/*' />
    msidbControlAttributesSorted = 0x00010000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesComboList"]/*' />
    msidbControlAttributesComboList = 0x00020000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesImageHandle"]/*' />
    msidbControlAttributesImageHandle = 0x00010000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesPushLike"]/*' />
    msidbControlAttributesPushLike = 0x00020000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesBitmap"]/*' />
    msidbControlAttributesBitmap = 0x00040000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesIcon"]/*' />
    msidbControlAttributesIcon = 0x00080000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesFixedSize"]/*' />
    msidbControlAttributesFixedSize = 0x00100000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesIconSize16"]/*' />
    msidbControlAttributesIconSize16 = 0x00200000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesIconSize32"]/*' />
    msidbControlAttributesIconSize32 = 0x00400000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesIconSize48"]/*' />
    msidbControlAttributesIconSize48 = 0x00600000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesElevationShield"]/*' />
    msidbControlAttributesElevationShield = 0x00800000,

    /// <include file='msidbControlAttributes.xml' path='doc/member[@name="msidbControlAttributes.msidbControlAttributesHasBorder"]/*' />
    msidbControlAttributesHasBorder = 0x01000000,
}
