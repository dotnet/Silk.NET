// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L197_C9")]
    [NativeName("Name", "SDL_GLattr")]
    public enum GLattr : int
    {
        [NativeName("Name", "SDL_GL_RED_SIZE")]
        GLRedSize = 0x0,
        [NativeName("Name", "SDL_GL_GREEN_SIZE")]
        GLGreenSize = 0x1,
        [NativeName("Name", "SDL_GL_BLUE_SIZE")]
        GLBlueSize = 0x2,
        [NativeName("Name", "SDL_GL_ALPHA_SIZE")]
        GLAlphaSize = 0x3,
        [NativeName("Name", "SDL_GL_BUFFER_SIZE")]
        GLBufferSize = 0x4,
        [NativeName("Name", "SDL_GL_DOUBLEBUFFER")]
        GLDoublebuffer = 0x5,
        [NativeName("Name", "SDL_GL_DEPTH_SIZE")]
        GLDepthSize = 0x6,
        [NativeName("Name", "SDL_GL_STENCIL_SIZE")]
        GLStencilSize = 0x7,
        [NativeName("Name", "SDL_GL_ACCUM_RED_SIZE")]
        GLAccumRedSize = 0x8,
        [NativeName("Name", "SDL_GL_ACCUM_GREEN_SIZE")]
        GLAccumGreenSize = 0x9,
        [NativeName("Name", "SDL_GL_ACCUM_BLUE_SIZE")]
        GLAccumBlueSize = 0xA,
        [NativeName("Name", "SDL_GL_ACCUM_ALPHA_SIZE")]
        GLAccumAlphaSize = 0xB,
        [NativeName("Name", "SDL_GL_STEREO")]
        GLStereo = 0xC,
        [NativeName("Name", "SDL_GL_MULTISAMPLEBUFFERS")]
        GLMultisamplebuffers = 0xD,
        [NativeName("Name", "SDL_GL_MULTISAMPLESAMPLES")]
        GLMultisamplesamples = 0xE,
        [NativeName("Name", "SDL_GL_ACCELERATED_VISUAL")]
        GLAcceleratedVisual = 0xF,
        [NativeName("Name", "SDL_GL_RETAINED_BACKING")]
        GLRetainedBacking = 0x10,
        [NativeName("Name", "SDL_GL_CONTEXT_MAJOR_VERSION")]
        GLContextMajorVersion = 0x11,
        [NativeName("Name", "SDL_GL_CONTEXT_MINOR_VERSION")]
        GLContextMinorVersion = 0x12,
        [NativeName("Name", "SDL_GL_CONTEXT_EGL")]
        GLContextEgl = 0x13,
        [NativeName("Name", "SDL_GL_CONTEXT_FLAGS")]
        GLContextFlags = 0x14,
        [NativeName("Name", "SDL_GL_CONTEXT_PROFILE_MASK")]
        GLContextProfileMask = 0x15,
        [NativeName("Name", "SDL_GL_SHARE_WITH_CURRENT_CONTEXT")]
        GLShareWithCurrentContext = 0x16,
        [NativeName("Name", "SDL_GL_FRAMEBUFFER_SRGB_CAPABLE")]
        GLFramebufferSrgbCapable = 0x17,
        [NativeName("Name", "SDL_GL_CONTEXT_RELEASE_BEHAVIOR")]
        GLContextReleaseBehavior = 0x18,
        [NativeName("Name", "SDL_GL_CONTEXT_RESET_NOTIFICATION")]
        GLContextResetNotification = 0x19,
        [NativeName("Name", "SDL_GL_CONTEXT_NO_ERROR")]
        GLContextNoError = 0x1A,
    }
}
