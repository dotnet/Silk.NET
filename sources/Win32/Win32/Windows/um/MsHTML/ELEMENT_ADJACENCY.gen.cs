// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum ELEMENT_ADJACENCY
{
    ELEM_ADJ_BeforeBegin = 0,
    ELEM_ADJ_AfterBegin = 1,
    ELEM_ADJ_BeforeEnd = 2,
    ELEM_ADJ_AfterEnd = 3,
    ELEMENT_ADJACENCY_Max = 2147483647,
}
