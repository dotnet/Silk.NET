// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "NormalPointerType")]
    public enum NormalPointerType : int
    {
        [NativeName("Name", "GL_BYTE")]
        Byte = 0x1400,
        [NativeName("Name", "GL_SHORT")]
        Short = 0x1402,
        [NativeName("Name", "GL_INT")]
        Int = 0x1404,
        [NativeName("Name", "GL_FLOAT")]
        Float = 0x1406,
        [NativeName("Name", "GL_DOUBLE")]
        Double = 0x140A,
    }
}
