// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
[SupportedOSPlatform("windows10.0.17134.0")]
public enum DWM_TAB_WINDOW_REQUIREMENTS
{
    DWMTWR_NONE = 0x0000,
    DWMTWR_IMPLEMENTED_BY_SYSTEM = 0x0001,
    DWMTWR_WINDOW_RELATIONSHIP = 0x0002,
    DWMTWR_WINDOW_STYLES = 0x0004,
    DWMTWR_WINDOW_REGION = 0x0008,
    DWMTWR_WINDOW_DWM_ATTRIBUTES = 0x0010,
    DWMTWR_WINDOW_MARGINS = 0x0020,
    DWMTWR_TABBING_ENABLED = 0x0040,
    DWMTWR_USER_POLICY = 0x0080,
    DWMTWR_GROUP_POLICY = 0x0100,
    DWMTWR_APP_COMPAT = 0x0200,
}
