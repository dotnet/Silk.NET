// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ArrayObjectPNameATI")]
    public enum ArrayObjectPNameATI : int
    {
        [NativeName("Name", "GL_OBJECT_BUFFER_SIZE_ATI")]
        ObjectBufferSizeAti = 0x8764,
        [NativeName("Name", "GL_OBJECT_BUFFER_USAGE_ATI")]
        ObjectBufferUsageAti = 0x8765,
    }
}
