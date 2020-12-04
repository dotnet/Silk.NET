// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ListMode")]
    public enum ListMode
    {
        [NativeName("Name", "GL_COMPILE")]
        Compile = 0x1300,
        [NativeName("Name", "GL_COMPILE_AND_EXECUTE")]
        CompileAndExecute = 0x1301,
    }
}
