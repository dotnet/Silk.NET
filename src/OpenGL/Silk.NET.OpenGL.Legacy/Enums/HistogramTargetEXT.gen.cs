// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
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
