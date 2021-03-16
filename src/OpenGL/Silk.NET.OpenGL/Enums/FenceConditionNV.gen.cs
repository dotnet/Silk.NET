// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FenceConditionNV")]
    public enum FenceConditionNV : int
    {
        [NativeName("Name", "GL_ALL_COMPLETED_NV")]
        AllCompletedNV = 0x84F2,
    }
}
