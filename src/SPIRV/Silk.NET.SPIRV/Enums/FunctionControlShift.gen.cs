// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [Flags]
    [NativeName("Name", "SpvFunctionControlShift_")]
    public enum FunctionControlShift : int
    {
        [NativeName("Name", "SpvFunctionControlInlineShift")]
        InlineShift = 0x0,
        [NativeName("Name", "SpvFunctionControlDontInlineShift")]
        DontInlineShift = 0x1,
        [NativeName("Name", "SpvFunctionControlPureShift")]
        PureShift = 0x2,
        [NativeName("Name", "SpvFunctionControlConstShift")]
        ConstShift = 0x3,
        [NativeName("Name", "SpvFunctionControlOptNoneINTELShift")]
        OptNoneIntelShift = 0x10,
        [NativeName("Name", "SpvFunctionControlMax")]
        Max = 0x7FFFFFFF,
    }
}
