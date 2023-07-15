// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS.xml' path='doc/member[@name="DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS"]/*'/>
[Flags]
public enum DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS
{
    /// <include file='DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS.xml' path='doc/member[@name="DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS.DCDC_DEFAULT"]/*'/>
    DCDC_DEFAULT = 0x0000,
    /// <include file='DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS.xml' path='doc/member[@name="DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS.DCDC_DISABLE_FONT_UPDATE"]/*'/>
    DCDC_DISABLE_FONT_UPDATE = 0x0001,
    /// <include file='DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS.xml' path='doc/member[@name="DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS.DCDC_DISABLE_RELAYOUT"]/*'/>
    DCDC_DISABLE_RELAYOUT = 0x0002,
}