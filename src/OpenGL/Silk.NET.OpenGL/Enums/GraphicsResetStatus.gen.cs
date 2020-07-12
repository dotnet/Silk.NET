// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "GraphicsResetStatus")]
    public enum GraphicsResetStatus
    {
        [NativeName("Name", "GL_NO_ERROR")]
        NoError = 0x0,
        [NativeName("Name", "GL_GUILTY_CONTEXT_RESET")]
        GuiltyContextReset = 0x8253,
        [NativeName("Name", "GL_INNOCENT_CONTEXT_RESET")]
        InnocentContextReset = 0x8254,
        [NativeName("Name", "GL_UNKNOWN_CONTEXT_RESET")]
        UnknownContextReset = 0x8255,
    }
}
