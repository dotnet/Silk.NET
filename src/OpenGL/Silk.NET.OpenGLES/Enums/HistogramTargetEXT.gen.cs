// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "HistogramTargetEXT")]
    public enum HistogramTargetEXT : int
    {
        [NativeName("Name", "GL_HISTOGRAM")]
        Histogram = 0x8024,
        [NativeName("Name", "GL_HISTOGRAM_EXT")]
        HistogramExt = 0x8024,
        [NativeName("Name", "GL_PROXY_HISTOGRAM")]
        ProxyHistogram = 0x8025,
        [NativeName("Name", "GL_PROXY_HISTOGRAM_EXT")]
        ProxyHistogramExt = 0x8025,
    }
}
