// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ArrayObjectPNameATI")]
    public enum ArrayObjectPNameATI : int
    {
        [Obsolete("Deprecated in favour of \"SizeAti\"")]
        [NativeName("Name", "GL_OBJECT_BUFFER_SIZE_ATI")]
        ObjectBufferSizeAti = 0x8764,
        [Obsolete("Deprecated in favour of \"UsageAti\"")]
        [NativeName("Name", "GL_OBJECT_BUFFER_USAGE_ATI")]
        ObjectBufferUsageAti = 0x8765,
        [NativeName("Name", "GL_OBJECT_BUFFER_SIZE_ATI")]
        SizeAti = 0x8764,
        [NativeName("Name", "GL_OBJECT_BUFFER_USAGE_ATI")]
        UsageAti = 0x8765,
    }
}
