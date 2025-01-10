// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum EDITPARTS
{
    EP_EDITTEXT = 1,
    EP_CARET = 2,
    EP_BACKGROUND = 3,
    EP_PASSWORD = 4,
    EP_BACKGROUNDWITHBORDER = 5,
    EP_EDITBORDER_NOSCROLL = 6,
    EP_EDITBORDER_HSCROLL = 7,
    EP_EDITBORDER_VSCROLL = 8,
    EP_EDITBORDER_HVSCROLL = 9,
}
