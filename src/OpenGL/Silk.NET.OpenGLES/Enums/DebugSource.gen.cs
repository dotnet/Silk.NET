// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    public enum DebugSource
    {
        DontCare = 0x1100,
        DebugSourceApi = 0x8246,
        DebugSourceWindowSystem = 0x8247,
        DebugSourceShaderCompiler = 0x8248,
        DebugSourceThirdParty = 0x8249,
        DebugSourceApplication = 0x824A,
        DebugSourceOther = 0x824B,
    }
}
