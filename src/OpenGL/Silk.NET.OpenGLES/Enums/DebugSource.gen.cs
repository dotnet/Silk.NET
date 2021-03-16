// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "DebugSource")]
    public enum DebugSource : int
    {
        [NativeName("Name", "GL_DONT_CARE")]
        DontCare = 0x1100,
        [NativeName("Name", "GL_DEBUG_SOURCE_API")]
        DebugSourceApi = 0x8246,
        [NativeName("Name", "GL_DEBUG_SOURCE_WINDOW_SYSTEM")]
        DebugSourceWindowSystem = 0x8247,
        [NativeName("Name", "GL_DEBUG_SOURCE_SHADER_COMPILER")]
        DebugSourceShaderCompiler = 0x8248,
        [NativeName("Name", "GL_DEBUG_SOURCE_THIRD_PARTY")]
        DebugSourceThirdParty = 0x8249,
        [NativeName("Name", "GL_DEBUG_SOURCE_APPLICATION")]
        DebugSourceApplication = 0x824A,
        [NativeName("Name", "GL_DEBUG_SOURCE_OTHER")]
        DebugSourceOther = 0x824B,
    }
}
