// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS
{
    DCDC_DEFAULT = 0x0000,
    DCDC_DISABLE_FONT_UPDATE = 0x0001,
    DCDC_DISABLE_RELAYOUT = 0x0002,
}
