// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum LISTITEMSTATES
{
    LISS_NORMAL = 1,
    LISS_HOT = 2,
    LISS_SELECTED = 3,
    LISS_DISABLED = 4,
    LISS_SELECTEDNOTFOCUS = 5,
    LISS_HOTSELECTED = 6,
}
