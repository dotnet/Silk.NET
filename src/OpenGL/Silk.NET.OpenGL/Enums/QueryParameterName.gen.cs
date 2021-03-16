// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "QueryParameterName")]
    public enum QueryParameterName : int
    {
        [NativeName("Name", "GL_QUERY_COUNTER_BITS")]
        QueryCounterBits = 0x8864,
        [NativeName("Name", "GL_CURRENT_QUERY")]
        CurrentQuery = 0x8865,
    }
}
