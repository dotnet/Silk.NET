// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "QueryObjectParameterName")]
    public enum QueryObjectParameterName
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
