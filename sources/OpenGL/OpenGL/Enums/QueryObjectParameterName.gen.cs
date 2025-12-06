// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("QueryObjectParameterName")]
public enum QueryObjectParameterName : uint
{
    [NativeName("GL_QUERY_RESULT")]
    Result = 34918,

    [NativeName("GL_QUERY_RESULT_AVAILABLE")]
    ResultAvailable = 34919,

    [NativeName("GL_QUERY_RESULT_NO_WAIT")]
    ResultNoWait = 37268,

    [NativeName("GL_QUERY_TARGET")]
    Target = 33514,
}
