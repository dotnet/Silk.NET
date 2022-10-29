// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "QueryCounterTarget")]
    public enum QueryCounterTarget : int
    {
        [NativeName("Name", "GL_TIMESTAMP")]
        Timestamp = 0x8E28,
        [NativeName("Name", "GL_TIMESTAMP_EXT")]
        TimestampExt = 0x8E28,
    }
}
