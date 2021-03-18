// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "MapAttribParameterNV")]
    public enum MapAttribParameterNV : int
    {
        [NativeName("Name", "GL_MAP_ATTRIB_U_ORDER_NV")]
        MapAttribUOrderNV = 0x86C3,
        [NativeName("Name", "GL_MAP_ATTRIB_V_ORDER_NV")]
        MapAttribVOrderNV = 0x86C4,
    }
}
