// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "SyncBehaviorFlags")]
    public enum SyncBehaviorFlags : int
    {
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
    }
}
