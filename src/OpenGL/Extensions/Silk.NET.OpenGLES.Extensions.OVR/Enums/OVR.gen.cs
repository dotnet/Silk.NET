// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OVR
{
    [NativeName("Name", "GLenum")]
    public enum OVR : int
    {
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR")]
        FramebufferAttachmentTextureNumViewsOvr = 0x9630,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR")]
        FramebufferAttachmentTextureBaseViewIndexOvr = 0x9632,
        [NativeName("Name", "GL_MAX_VIEWS_OVR")]
        MaxViewsOvr = 0x9631,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR")]
        FramebufferIncompleteViewTargetsOvr = 0x9633,
    }
}
