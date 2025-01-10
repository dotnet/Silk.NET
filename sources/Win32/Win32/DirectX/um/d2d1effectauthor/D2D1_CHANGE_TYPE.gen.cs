// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum D2D1_CHANGE_TYPE
{
    D2D1_CHANGE_TYPE_NONE = 0,
    D2D1_CHANGE_TYPE_PROPERTIES = 1,
    D2D1_CHANGE_TYPE_CONTEXT = 2,
    D2D1_CHANGE_TYPE_GRAPH = 3,
    D2D1_CHANGE_TYPE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
