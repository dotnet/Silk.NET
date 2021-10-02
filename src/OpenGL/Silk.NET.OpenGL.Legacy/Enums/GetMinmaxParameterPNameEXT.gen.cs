// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "GetMinmaxParameterPNameEXT")]
    public enum GetMinmaxParameterPNameEXT : int
    {
        [NativeName("Name", "GL_MINMAX_FORMAT")]
        MinmaxFormat = 0x802F,
        [NativeName("Name", "GL_MINMAX_FORMAT_EXT")]
        MinmaxFormatExt = 0x802F,
        [NativeName("Name", "GL_MINMAX_SINK")]
        MinmaxSink = 0x8030,
        [NativeName("Name", "GL_MINMAX_SINK_EXT")]
        MinmaxSinkExt = 0x8030,
    }
}
