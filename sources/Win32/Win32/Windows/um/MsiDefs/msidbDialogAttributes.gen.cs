// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum msidbDialogAttributes
{
    msidbDialogAttributesVisible = 0x00000001,
    msidbDialogAttributesModal = 0x00000002,
    msidbDialogAttributesMinimize = 0x00000004,
    msidbDialogAttributesSysModal = 0x00000008,
    msidbDialogAttributesKeepModeless = 0x00000010,
    msidbDialogAttributesTrackDiskSpace = 0x00000020,
    msidbDialogAttributesUseCustomPalette = 0x00000040,
    msidbDialogAttributesRTLRO = 0x00000080,
    msidbDialogAttributesRightAligned = 0x00000100,
    msidbDialogAttributesLeftScroll = 0x00000200,
    msidbDialogAttributesBiDi =
        msidbDialogAttributesRTLRO
        | msidbDialogAttributesRightAligned
        | msidbDialogAttributesLeftScroll,
    msidbDialogAttributesError = 0x00010000,
}
