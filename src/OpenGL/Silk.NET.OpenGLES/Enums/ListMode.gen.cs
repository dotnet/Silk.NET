// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ListMode")]
    public enum ListMode : int
    {
        [System.Obsolete]
        [NativeName("Name", "GL_COMPILE")]
        Compile = 0x1300,
        [System.Obsolete]
        [NativeName("Name", "GL_COMPILE_AND_EXECUTE")]
        CompileAndExecute = 0x1301,
    }
}
