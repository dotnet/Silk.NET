// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum HTML_PAINTER
{
    HTMLPAINTER_OPAQUE = 0x1,
    HTMLPAINTER_TRANSPARENT = 0x2,
    HTMLPAINTER_ALPHA = 0x4,
    HTMLPAINTER_COMPLEX = 0x8,
    HTMLPAINTER_OVERLAY = 0x10,
    HTMLPAINTER_HITTEST = 0x20,
    HTMLPAINTER_SURFACE = 0x100,
    HTMLPAINTER_3DSURFACE = 0x200,
    HTMLPAINTER_NOBAND = 0x400,
    HTMLPAINTER_NODC = 0x1000,
    HTMLPAINTER_NOPHYSICALCLIP = 0x2000,
    HTMLPAINTER_NOSAVEDC = 0x4000,
    HTMLPAINTER_SUPPORTS_XFORM = 0x8000,
    HTMLPAINTER_EXPAND = 0x10000,
    HTMLPAINTER_NOSCROLLBITS = 0x20000,
    HTML_PAINTER_Max = 2147483647,
}
