// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "GetMinmaxParameterPNameEXT")]
    public enum GetMinmaxParameterPNameEXT : int
    {
        [Obsolete("Deprecated in favour of \"Format\"")]
        [NativeName("Name", "GL_MINMAX_FORMAT")]
        MinmaxFormat = 0x802F,
        [Obsolete("Deprecated in favour of \"FormatExt\"")]
        [NativeName("Name", "GL_MINMAX_FORMAT_EXT")]
        MinmaxFormatExt = 0x802F,
        [Obsolete("Deprecated in favour of \"Sink\"")]
        [NativeName("Name", "GL_MINMAX_SINK")]
        MinmaxSink = 0x8030,
        [Obsolete("Deprecated in favour of \"SinkExt\"")]
        [NativeName("Name", "GL_MINMAX_SINK_EXT")]
        MinmaxSinkExt = 0x8030,
        [NativeName("Name", "GL_MINMAX_FORMAT")]
        Format = 0x802F,
        [NativeName("Name", "GL_MINMAX_FORMAT_EXT")]
        FormatExt = 0x802F,
        [NativeName("Name", "GL_MINMAX_SINK")]
        Sink = 0x8030,
        [NativeName("Name", "GL_MINMAX_SINK_EXT")]
        SinkExt = 0x8030,
    }
}
