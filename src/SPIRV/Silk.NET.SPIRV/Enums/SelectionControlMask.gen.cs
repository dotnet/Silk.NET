// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvSelectionControlMask_")]
    public enum SelectionControlMask : int
    {
        [NativeName("Name", "SpvSelectionControlMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvSelectionControlFlattenMask")]
        FlattenMask = 0x1,
        [NativeName("Name", "SpvSelectionControlDontFlattenMask")]
        DontFlattenMask = 0x2,
    }
}
