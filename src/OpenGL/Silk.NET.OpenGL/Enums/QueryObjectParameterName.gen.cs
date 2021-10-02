// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "QueryObjectParameterName")]
    public enum QueryObjectParameterName : int
    {
        [NativeName("Name", "GL_QUERY_TARGET")]
        QueryTarget = 0x82EA,
        [NativeName("Name", "GL_QUERY_RESULT")]
        QueryResult = 0x8866,
        [NativeName("Name", "GL_QUERY_RESULT_AVAILABLE")]
        QueryResultAvailable = 0x8867,
        [NativeName("Name", "GL_QUERY_RESULT_NO_WAIT")]
        QueryResultNoWait = 0x9194,
    }
}
