// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvSelectionControlShift_")]
    public enum SelectionControlShift : int
    {
        [NativeName("Name", "SpvSelectionControlFlattenShift")]
        FlattenShift = 0x0,
        [NativeName("Name", "SpvSelectionControlDontFlattenShift")]
        DontFlattenShift = 0x1,
        [NativeName("Name", "SpvSelectionControlMax")]
        Max = 0x7FFFFFFF,
    }
}
