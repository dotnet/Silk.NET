// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FramebufferStatus")]
    public enum FramebufferStatus : int
    {
        [NativeName("Name", "GL_FRAMEBUFFER_UNDEFINED")]
        FramebufferUndefined = 0x8219,
        [NativeName("Name", "GL_FRAMEBUFFER_COMPLETE")]
        FramebufferComplete = 0x8CD5,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT")]
        FramebufferIncompleteAttachment = 0x8CD6,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT")]
        FramebufferIncompleteMissingAttachment = 0x8CD7,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER")]
        FramebufferIncompleteDrawBuffer = 0x8CDB,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER")]
        FramebufferIncompleteReadBuffer = 0x8CDC,
        [NativeName("Name", "GL_FRAMEBUFFER_UNSUPPORTED")]
        FramebufferUnsupported = 0x8CDD,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE")]
        FramebufferIncompleteMultisample = 0x8D56,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS")]
        FramebufferIncompleteLayerTargets = 0x8DA8,
    }
}
