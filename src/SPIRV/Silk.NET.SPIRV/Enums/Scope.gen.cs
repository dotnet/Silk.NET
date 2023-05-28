// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvScope_")]
    public enum Scope : int
    {
        [NativeName("Name", "SpvScopeCrossDevice")]
        CrossDevice = 0x0,
        [NativeName("Name", "SpvScopeDevice")]
        Device = 0x1,
        [NativeName("Name", "SpvScopeWorkgroup")]
        Workgroup = 0x2,
        [NativeName("Name", "SpvScopeSubgroup")]
        Subgroup = 0x3,
        [NativeName("Name", "SpvScopeInvocation")]
        Invocation = 0x4,
        [NativeName("Name", "SpvScopeQueueFamily")]
        QueueFamily = 0x5,
        [NativeName("Name", "SpvScopeQueueFamilyKHR")]
        QueueFamilyKhr = 0x5,
        [NativeName("Name", "SpvScopeShaderCallKHR")]
        ShaderCallKhr = 0x6,
        [NativeName("Name", "SpvScopeMax")]
        Max = 0x7FFFFFFF,
    }
}
