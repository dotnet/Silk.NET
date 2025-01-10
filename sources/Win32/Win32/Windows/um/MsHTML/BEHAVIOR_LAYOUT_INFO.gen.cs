// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum BEHAVIOR_LAYOUT_INFO
{
    BEHAVIORLAYOUTINFO_FULLDELEGATION = 0x1,
    BEHAVIORLAYOUTINFO_MODIFYNATURAL = 0x2,
    BEHAVIORLAYOUTINFO_MAPSIZE = 0x4,
    BEHAVIOR_LAYOUT_INFO_Max = 2147483647,
}
