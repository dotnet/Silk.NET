// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum LISTVIEWPARTS
{
    LVP_LISTITEM = 1,
    LVP_LISTGROUP = 2,
    LVP_LISTDETAIL = 3,
    LVP_LISTSORTEDDETAIL = 4,
    LVP_EMPTYTEXT = 5,
    LVP_GROUPHEADER = 6,
    LVP_GROUPHEADERLINE = 7,
    LVP_EXPANDBUTTON = 8,
    LVP_COLLAPSEBUTTON = 9,
    LVP_COLUMNDETAIL = 10,
}
