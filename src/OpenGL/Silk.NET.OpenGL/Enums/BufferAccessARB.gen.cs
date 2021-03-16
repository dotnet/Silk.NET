// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "BufferAccessARB")]
    public enum BufferAccessARB : int
    {
        [NativeName("Name", "GL_READ_ONLY")]
        ReadOnly = 0x88B8,
        [NativeName("Name", "GL_WRITE_ONLY")]
        WriteOnly = 0x88B9,
        [NativeName("Name", "GL_READ_WRITE")]
        ReadWrite = 0x88BA,
    }
}
