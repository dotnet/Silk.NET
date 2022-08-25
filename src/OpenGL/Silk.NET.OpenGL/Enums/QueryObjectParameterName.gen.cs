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
        [Obsolete("Deprecated in favour of \"Target\"")]
        [NativeName("Name", "GL_QUERY_TARGET")]
        QueryTarget = 0x82EA,
        [Obsolete("Deprecated in favour of \"Result\"")]
        [NativeName("Name", "GL_QUERY_RESULT")]
        QueryResult = 0x8866,
        [Obsolete("Deprecated in favour of \"ResultAvailable\"")]
        [NativeName("Name", "GL_QUERY_RESULT_AVAILABLE")]
        QueryResultAvailable = 0x8867,
        [Obsolete("Deprecated in favour of \"ResultNoWait\"")]
        [NativeName("Name", "GL_QUERY_RESULT_NO_WAIT")]
        QueryResultNoWait = 0x9194,
        [NativeName("Name", "GL_QUERY_TARGET")]
        Target = 0x82EA,
        [NativeName("Name", "GL_QUERY_RESULT")]
        Result = 0x8866,
        [NativeName("Name", "GL_QUERY_RESULT_AVAILABLE")]
        ResultAvailable = 0x8867,
        [NativeName("Name", "GL_QUERY_RESULT_NO_WAIT")]
        ResultNoWait = 0x9194,
    }
}
