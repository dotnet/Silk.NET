// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum HTML_PAINT_ZORDER
{
    HTMLPAINT_ZORDER_NONE = 0,
    HTMLPAINT_ZORDER_REPLACE_ALL = 1,
    HTMLPAINT_ZORDER_REPLACE_CONTENT = 2,
    HTMLPAINT_ZORDER_REPLACE_BACKGROUND = 3,
    HTMLPAINT_ZORDER_BELOW_CONTENT = 4,
    HTMLPAINT_ZORDER_BELOW_FLOW = 5,
    HTMLPAINT_ZORDER_ABOVE_FLOW = 6,
    HTMLPAINT_ZORDER_ABOVE_CONTENT = 7,
    HTMLPAINT_ZORDER_WINDOW_TOP = 8,
    HTML_PAINT_ZORDER_Max = 2147483647,
}
