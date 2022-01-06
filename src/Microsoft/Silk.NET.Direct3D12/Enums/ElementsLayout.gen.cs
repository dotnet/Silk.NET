// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_ELEMENTS_LAYOUT")]
    public enum ElementsLayout : int
    {
        [NativeName("Name", "D3D12_ELEMENTS_LAYOUT_ARRAY")]
        ElementsLayoutArray = 0x0,
        [NativeName("Name", "D3D12_ELEMENTS_LAYOUT_ARRAY_OF_POINTERS")]
        ElementsLayoutArrayOfPointers = 0x1,
    }
}
