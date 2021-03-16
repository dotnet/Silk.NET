// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FramebufferFetchNoncoherent")]
    public enum FramebufferFetchNoncoherent : int
    {
        [NativeName("Name", "GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM")]
        FramebufferFetchNoncoherentQCom = 0x96A2,
    }
}
