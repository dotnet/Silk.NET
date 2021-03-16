// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ContextProfileMask")]
    public enum ContextProfileMask : int
    {
        [NativeName("Name", "GL_CONTEXT_CORE_PROFILE_BIT")]
        ContextCoreProfileBit = 0x1,
        [NativeName("Name", "GL_CONTEXT_COMPATIBILITY_PROFILE_BIT")]
        ContextCompatibilityProfileBit = 0x2,
    }
}
