// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GLAttr")]
public enum GlAttr
{
    [NativeName("SDL_GL_RED_SIZE")]
    RedSize = 0,

    [NativeName("SDL_GL_GREEN_SIZE")]
    GreenSize = 1,

    [NativeName("SDL_GL_BLUE_SIZE")]
    BlueSize = 2,

    [NativeName("SDL_GL_ALPHA_SIZE")]
    AlphaSize = 3,

    [NativeName("SDL_GL_BUFFER_SIZE")]
    BufferSize = 4,

    [NativeName("SDL_GL_DOUBLEBUFFER")]
    Doublebuffer = 5,

    [NativeName("SDL_GL_DEPTH_SIZE")]
    DepthSize = 6,

    [NativeName("SDL_GL_STENCIL_SIZE")]
    StencilSize = 7,

    [NativeName("SDL_GL_ACCUM_RED_SIZE")]
    AccumRedSize = 8,

    [NativeName("SDL_GL_ACCUM_GREEN_SIZE")]
    AccumGreenSize = 9,

    [NativeName("SDL_GL_ACCUM_BLUE_SIZE")]
    AccumBlueSize = 10,

    [NativeName("SDL_GL_ACCUM_ALPHA_SIZE")]
    AccumAlphaSize = 11,

    [NativeName("SDL_GL_STEREO")]
    Stereo = 12,

    [NativeName("SDL_GL_MULTISAMPLEBUFFERS")]
    Multisamplebuffers = 13,

    [NativeName("SDL_GL_MULTISAMPLESAMPLES")]
    Multisamplesamples = 14,

    [NativeName("SDL_GL_ACCELERATED_VISUAL")]
    AcceleratedVisual = 15,

    [NativeName("SDL_GL_RETAINED_BACKING")]
    RetainedBacking = 16,

    [NativeName("SDL_GL_CONTEXT_MAJOR_VERSION")]
    ContextMajorVersion = 17,

    [NativeName("SDL_GL_CONTEXT_MINOR_VERSION")]
    ContextMinorVersion = 18,

    [NativeName("SDL_GL_CONTEXT_FLAGS")]
    ContextFlags = 19,

    [NativeName("SDL_GL_CONTEXT_PROFILE_MASK")]
    ContextProfileMask = 20,

    [NativeName("SDL_GL_SHARE_WITH_CURRENT_CONTEXT")]
    ShareWithCurrentContext = 21,

    [NativeName("SDL_GL_FRAMEBUFFER_SRGB_CAPABLE")]
    FramebufferSrgbCapable = 22,

    [NativeName("SDL_GL_CONTEXT_RELEASE_BEHAVIOR")]
    ContextReleaseBehavior = 23,

    [NativeName("SDL_GL_CONTEXT_RESET_NOTIFICATION")]
    ContextResetNotification = 24,

    [NativeName("SDL_GL_CONTEXT_NO_ERROR")]
    ContextNoError = 25,

    [NativeName("SDL_GL_FLOATBUFFERS")]
    Floatbuffers = 26,

    [NativeName("SDL_GL_EGL_PLATFORM")]
    EglPlatform = 27,
}
