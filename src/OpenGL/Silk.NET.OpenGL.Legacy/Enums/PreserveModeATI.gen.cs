// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PreserveModeATI")]
    public enum PreserveModeATI : int
    {
        [NativeName("Name", "GL_PRESERVE_ATI")]
        PreserveAti = 0x8762,
        [NativeName("Name", "GL_DISCARD_ATI")]
        DiscardAti = 0x8763,
    }
}
