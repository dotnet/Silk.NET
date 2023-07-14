// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_CHANGE_TYPE")]
    public enum ChangeType : int
    {
        [NativeName("Name", "D2D1_CHANGE_TYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_CHANGE_TYPE_PROPERTIES")]
        Properties = 0x1,
        [NativeName("Name", "D2D1_CHANGE_TYPE_CONTEXT")]
        Context = 0x2,
        [NativeName("Name", "D2D1_CHANGE_TYPE_GRAPH")]
        Graph = 0x3,
        [NativeName("Name", "D2D1_CHANGE_TYPE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
