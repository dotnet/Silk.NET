// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvFunctionParameterAttribute_")]
    public enum FunctionParameterAttribute : int
    {
        [NativeName("Name", "SpvFunctionParameterAttributeZext")]
        Zext = 0x0,
        [NativeName("Name", "SpvFunctionParameterAttributeSext")]
        Sext = 0x1,
        [NativeName("Name", "SpvFunctionParameterAttributeByVal")]
        ByVal = 0x2,
        [NativeName("Name", "SpvFunctionParameterAttributeSret")]
        Sret = 0x3,
        [NativeName("Name", "SpvFunctionParameterAttributeNoAlias")]
        NoAlias = 0x4,
        [NativeName("Name", "SpvFunctionParameterAttributeNoCapture")]
        NoCapture = 0x5,
        [NativeName("Name", "SpvFunctionParameterAttributeNoWrite")]
        NoWrite = 0x6,
        [NativeName("Name", "SpvFunctionParameterAttributeNoReadWrite")]
        NoReadWrite = 0x7,
        [NativeName("Name", "SpvFunctionParameterAttributeRuntimeAlignedINTEL")]
        RuntimeAlignedIntel = 0x1734,
        [NativeName("Name", "SpvFunctionParameterAttributeMax")]
        Max = 0x7FFFFFFF,
    }
}
