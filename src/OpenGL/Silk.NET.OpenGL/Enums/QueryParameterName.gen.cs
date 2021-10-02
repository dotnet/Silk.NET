// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
