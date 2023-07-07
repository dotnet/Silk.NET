// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L224_C9")]
    [NativeName("Name", "SDL_GLattr")]
    public enum GLattr : int
    {
        [Obsolete("Deprecated in favour of \"RedSize\"")]
        [NativeName("Name", "SDL_GL_RED_SIZE")]
        GLRedSize = 0x0,
        [Obsolete("Deprecated in favour of \"GreenSize\"")]
        [NativeName("Name", "SDL_GL_GREEN_SIZE")]
        GLGreenSize = 0x1,
        [Obsolete("Deprecated in favour of \"BlueSize\"")]
        [NativeName("Name", "SDL_GL_BLUE_SIZE")]
        GLBlueSize = 0x2,
        [Obsolete("Deprecated in favour of \"AlphaSize\"")]
        [NativeName("Name", "SDL_GL_ALPHA_SIZE")]
        GLAlphaSize = 0x3,
        [Obsolete("Deprecated in favour of \"BufferSize\"")]
        [NativeName("Name", "SDL_GL_BUFFER_SIZE")]
        GLBufferSize = 0x4,
        [Obsolete("Deprecated in favour of \"Doublebuffer\"")]
        [NativeName("Name", "SDL_GL_DOUBLEBUFFER")]
        GLDoublebuffer = 0x5,
        [Obsolete("Deprecated in favour of \"DepthSize\"")]
        [NativeName("Name", "SDL_GL_DEPTH_SIZE")]
        GLDepthSize = 0x6,
        [Obsolete("Deprecated in favour of \"StencilSize\"")]
        [NativeName("Name", "SDL_GL_STENCIL_SIZE")]
        GLStencilSize = 0x7,
        [Obsolete("Deprecated in favour of \"AccumRedSize\"")]
        [NativeName("Name", "SDL_GL_ACCUM_RED_SIZE")]
        GLAccumRedSize = 0x8,
        [Obsolete("Deprecated in favour of \"AccumGreenSize\"")]
        [NativeName("Name", "SDL_GL_ACCUM_GREEN_SIZE")]
        GLAccumGreenSize = 0x9,
        [Obsolete("Deprecated in favour of \"AccumBlueSize\"")]
        [NativeName("Name", "SDL_GL_ACCUM_BLUE_SIZE")]
        GLAccumBlueSize = 0xA,
        [Obsolete("Deprecated in favour of \"AccumAlphaSize\"")]
        [NativeName("Name", "SDL_GL_ACCUM_ALPHA_SIZE")]
        GLAccumAlphaSize = 0xB,
        [Obsolete("Deprecated in favour of \"Stereo\"")]
        [NativeName("Name", "SDL_GL_STEREO")]
        GLStereo = 0xC,
        [Obsolete("Deprecated in favour of \"Multisamplebuffers\"")]
        [NativeName("Name", "SDL_GL_MULTISAMPLEBUFFERS")]
        GLMultisamplebuffers = 0xD,
        [Obsolete("Deprecated in favour of \"Multisamplesamples\"")]
        [NativeName("Name", "SDL_GL_MULTISAMPLESAMPLES")]
        GLMultisamplesamples = 0xE,
        [Obsolete("Deprecated in favour of \"AcceleratedVisual\"")]
        [NativeName("Name", "SDL_GL_ACCELERATED_VISUAL")]
        GLAcceleratedVisual = 0xF,
        [Obsolete("Deprecated in favour of \"RetainedBacking\"")]
        [NativeName("Name", "SDL_GL_RETAINED_BACKING")]
        GLRetainedBacking = 0x10,
        [Obsolete("Deprecated in favour of \"ContextMajorVersion\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_MAJOR_VERSION")]
        GLContextMajorVersion = 0x11,
        [Obsolete("Deprecated in favour of \"ContextMinorVersion\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_MINOR_VERSION")]
        GLContextMinorVersion = 0x12,
        [Obsolete("Deprecated in favour of \"ContextEgl\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_EGL")]
        GLContextEgl = 0x13,
        [Obsolete("Deprecated in favour of \"ContextFlags\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_FLAGS")]
        GLContextFlags = 0x14,
        [Obsolete("Deprecated in favour of \"ContextProfileMask\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_PROFILE_MASK")]
        GLContextProfileMask = 0x15,
        [Obsolete("Deprecated in favour of \"ShareWithCurrentContext\"")]
        [NativeName("Name", "SDL_GL_SHARE_WITH_CURRENT_CONTEXT")]
        GLShareWithCurrentContext = 0x16,
        [Obsolete("Deprecated in favour of \"FramebufferSrgbCapable\"")]
        [NativeName("Name", "SDL_GL_FRAMEBUFFER_SRGB_CAPABLE")]
        GLFramebufferSrgbCapable = 0x17,
        [Obsolete("Deprecated in favour of \"ContextReleaseBehavior\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_RELEASE_BEHAVIOR")]
        GLContextReleaseBehavior = 0x18,
        [Obsolete("Deprecated in favour of \"ContextResetNotification\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_RESET_NOTIFICATION")]
        GLContextResetNotification = 0x19,
        [Obsolete("Deprecated in favour of \"ContextNoError\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_NO_ERROR")]
        GLContextNoError = 0x1A,
        [Obsolete("Deprecated in favour of \"Floatbuffers\"")]
        [NativeName("Name", "SDL_GL_FLOATBUFFERS")]
        GLFloatbuffers = 0x1B,
        [NativeName("Name", "SDL_GL_RED_SIZE")]
        RedSize = 0x0,
        [NativeName("Name", "SDL_GL_GREEN_SIZE")]
        GreenSize = 0x1,
        [NativeName("Name", "SDL_GL_BLUE_SIZE")]
        BlueSize = 0x2,
        [NativeName("Name", "SDL_GL_ALPHA_SIZE")]
        AlphaSize = 0x3,
        [NativeName("Name", "SDL_GL_BUFFER_SIZE")]
        BufferSize = 0x4,
        [NativeName("Name", "SDL_GL_DOUBLEBUFFER")]
        Doublebuffer = 0x5,
        [NativeName("Name", "SDL_GL_DEPTH_SIZE")]
        DepthSize = 0x6,
        [NativeName("Name", "SDL_GL_STENCIL_SIZE")]
        StencilSize = 0x7,
        [NativeName("Name", "SDL_GL_ACCUM_RED_SIZE")]
        AccumRedSize = 0x8,
        [NativeName("Name", "SDL_GL_ACCUM_GREEN_SIZE")]
        AccumGreenSize = 0x9,
        [NativeName("Name", "SDL_GL_ACCUM_BLUE_SIZE")]
        AccumBlueSize = 0xA,
        [NativeName("Name", "SDL_GL_ACCUM_ALPHA_SIZE")]
        AccumAlphaSize = 0xB,
        [NativeName("Name", "SDL_GL_STEREO")]
        Stereo = 0xC,
        [NativeName("Name", "SDL_GL_MULTISAMPLEBUFFERS")]
        Multisamplebuffers = 0xD,
        [NativeName("Name", "SDL_GL_MULTISAMPLESAMPLES")]
        Multisamplesamples = 0xE,
        [NativeName("Name", "SDL_GL_ACCELERATED_VISUAL")]
        AcceleratedVisual = 0xF,
        [NativeName("Name", "SDL_GL_RETAINED_BACKING")]
        RetainedBacking = 0x10,
        [NativeName("Name", "SDL_GL_CONTEXT_MAJOR_VERSION")]
        ContextMajorVersion = 0x11,
        [NativeName("Name", "SDL_GL_CONTEXT_MINOR_VERSION")]
        ContextMinorVersion = 0x12,
        [NativeName("Name", "SDL_GL_CONTEXT_EGL")]
        ContextEgl = 0x13,
        [NativeName("Name", "SDL_GL_CONTEXT_FLAGS")]
        ContextFlags = 0x14,
        [NativeName("Name", "SDL_GL_CONTEXT_PROFILE_MASK")]
        ContextProfileMask = 0x15,
        [NativeName("Name", "SDL_GL_SHARE_WITH_CURRENT_CONTEXT")]
        ShareWithCurrentContext = 0x16,
        [NativeName("Name", "SDL_GL_FRAMEBUFFER_SRGB_CAPABLE")]
        FramebufferSrgbCapable = 0x17,
        [NativeName("Name", "SDL_GL_CONTEXT_RELEASE_BEHAVIOR")]
        ContextReleaseBehavior = 0x18,
        [NativeName("Name", "SDL_GL_CONTEXT_RESET_NOTIFICATION")]
        ContextResetNotification = 0x19,
        [NativeName("Name", "SDL_GL_CONTEXT_NO_ERROR")]
        ContextNoError = 0x1A,
        [NativeName("Name", "SDL_GL_FLOATBUFFERS")]
        Floatbuffers = 0x1B,
    }
}
