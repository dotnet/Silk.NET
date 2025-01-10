// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum OLECMDID_VIEWPORT_MODE_FLAG
{
    OLECMDIDF_VIEWPORTMODE_FIXED_LAYOUT_WIDTH = 0x00000001,
    OLECMDIDF_VIEWPORTMODE_EXCLUDE_VISUAL_BOTTOM = 0x00000002,
    OLECMDIDF_VIEWPORTMODE_FIXED_LAYOUT_WIDTH_VALID = 0x00010000,
    OLECMDIDF_VIEWPORTMODE_EXCLUDE_VISUAL_BOTTOM_VALID = 0x00020000,
}
