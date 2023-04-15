// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [Flags]
    [NativeName("Name", "SpvFunctionControlMask_")]
    public enum FunctionControlMask : int
    {
        [NativeName("Name", "SpvFunctionControlMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvFunctionControlInlineMask")]
        InlineMask = 0x1,
        [NativeName("Name", "SpvFunctionControlDontInlineMask")]
        DontInlineMask = 0x2,
        [NativeName("Name", "SpvFunctionControlPureMask")]
        PureMask = 0x4,
        [NativeName("Name", "SpvFunctionControlConstMask")]
        ConstMask = 0x8,
        [NativeName("Name", "SpvFunctionControlOptNoneINTELMask")]
        OptNoneIntelMask = 0x10000,
    }
}
