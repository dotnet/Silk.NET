// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum HTML_PAINT_EVENT_FLAGS
{
    HTMLPAINT_EVENT_TARGET = 0x1,
    HTMLPAINT_EVENT_SETCURSOR = 0x2,
    HTML_PAINT_EVENT_FLAGS_Max = 2147483647,
}
