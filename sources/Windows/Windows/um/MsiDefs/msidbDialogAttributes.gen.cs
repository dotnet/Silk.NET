// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='msidbDialogAttributes.xml' path='doc/member[@name="msidbDialogAttributes"]/*'/>
public enum msidbDialogAttributes
{
    /// <include file='msidbDialogAttributes.xml' path='doc/member[@name="msidbDialogAttributes.msidbDialogAttributesVisible"]/*'/>
    msidbDialogAttributesVisible = 0x00000001,
    /// <include file='msidbDialogAttributes.xml' path='doc/member[@name="msidbDialogAttributes.msidbDialogAttributesModal"]/*'/>
    msidbDialogAttributesModal = 0x00000002,
    /// <include file='msidbDialogAttributes.xml' path='doc/member[@name="msidbDialogAttributes.msidbDialogAttributesMinimize"]/*'/>
    msidbDialogAttributesMinimize = 0x00000004,
    /// <include file='msidbDialogAttributes.xml' path='doc/member[@name="msidbDialogAttributes.msidbDialogAttributesSysModal"]/*'/>
    msidbDialogAttributesSysModal = 0x00000008,
    /// <include file='msidbDialogAttributes.xml' path='doc/member[@name="msidbDialogAttributes.msidbDialogAttributesKeepModeless"]/*'/>
    msidbDialogAttributesKeepModeless = 0x00000010,
    /// <include file='msidbDialogAttributes.xml' path='doc/member[@name="msidbDialogAttributes.msidbDialogAttributesTrackDiskSpace"]/*'/>
    msidbDialogAttributesTrackDiskSpace = 0x00000020,
    /// <include file='msidbDialogAttributes.xml' path='doc/member[@name="msidbDialogAttributes.msidbDialogAttributesUseCustomPalette"]/*'/>
    msidbDialogAttributesUseCustomPalette = 0x00000040,
    /// <include file='msidbDialogAttributes.xml' path='doc/member[@name="msidbDialogAttributes.msidbDialogAttributesRTLRO"]/*'/>
    msidbDialogAttributesRTLRO = 0x00000080,
    /// <include file='msidbDialogAttributes.xml' path='doc/member[@name="msidbDialogAttributes.msidbDialogAttributesRightAligned"]/*'/>
    msidbDialogAttributesRightAligned = 0x00000100,
    /// <include file='msidbDialogAttributes.xml' path='doc/member[@name="msidbDialogAttributes.msidbDialogAttributesLeftScroll"]/*'/>
    msidbDialogAttributesLeftScroll = 0x00000200,
    /// <include file='msidbDialogAttributes.xml' path='doc/member[@name="msidbDialogAttributes.msidbDialogAttributesBiDi"]/*'/>
    msidbDialogAttributesBiDi = msidbDialogAttributesRTLRO | msidbDialogAttributesRightAligned | msidbDialogAttributesLeftScroll,
    /// <include file='msidbDialogAttributes.xml' path='doc/member[@name="msidbDialogAttributes.msidbDialogAttributesError"]/*'/>
    msidbDialogAttributesError = 0x00010000,
}