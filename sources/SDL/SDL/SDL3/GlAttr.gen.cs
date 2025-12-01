// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GLAttr")]
public enum GlAttr : uint
{
    [NativeName("SDL_GL_RED_SIZE")]
    RedSize,

    [NativeName("SDL_GL_GREEN_SIZE")]
    GreenSize,

    [NativeName("SDL_GL_BLUE_SIZE")]
    BlueSize,

    [NativeName("SDL_GL_ALPHA_SIZE")]
    AlphaSize,

    [NativeName("SDL_GL_BUFFER_SIZE")]
    BufferSize,

    [NativeName("SDL_GL_DOUBLEBUFFER")]
    Doublebuffer,

    [NativeName("SDL_GL_DEPTH_SIZE")]
    DepthSize,

    [NativeName("SDL_GL_STENCIL_SIZE")]
    StencilSize,

    [NativeName("SDL_GL_ACCUM_RED_SIZE")]
    AccumRedSize,

    [NativeName("SDL_GL_ACCUM_GREEN_SIZE")]
    AccumGreenSize,

    [NativeName("SDL_GL_ACCUM_BLUE_SIZE")]
    AccumBlueSize,

    [NativeName("SDL_GL_ACCUM_ALPHA_SIZE")]
    AccumAlphaSize,

    [NativeName("SDL_GL_STEREO")]
    Stereo,

    [NativeName("SDL_GL_MULTISAMPLEBUFFERS")]
    Multisamplebuffers,

    [NativeName("SDL_GL_MULTISAMPLESAMPLES")]
    Multisamplesamples,

    [NativeName("SDL_GL_ACCELERATED_VISUAL")]
    AcceleratedVisual,

    [NativeName("SDL_GL_RETAINED_BACKING")]
    RetainedBacking,

    [NativeName("SDL_GL_CONTEXT_MAJOR_VERSION")]
    ContextMajorVersion,

    [NativeName("SDL_GL_CONTEXT_MINOR_VERSION")]
    ContextMinorVersion,

    [NativeName("SDL_GL_CONTEXT_FLAGS")]
    ContextFlags,

    [NativeName("SDL_GL_CONTEXT_PROFILE_MASK")]
    ContextProfileMask,

    [NativeName("SDL_GL_SHARE_WITH_CURRENT_CONTEXT")]
    ShareWithCurrentContext,

    [NativeName("SDL_GL_FRAMEBUFFER_SRGB_CAPABLE")]
    FramebufferSrgbCapable,

    [NativeName("SDL_GL_CONTEXT_RELEASE_BEHAVIOR")]
    ContextReleaseBehavior,

    [NativeName("SDL_GL_CONTEXT_RESET_NOTIFICATION")]
    ContextResetNotification,

    [NativeName("SDL_GL_CONTEXT_NO_ERROR")]
    ContextNoError,

    [NativeName("SDL_GL_FLOATBUFFERS")]
    Floatbuffers,

    [NativeName("SDL_GL_EGL_PLATFORM")]
    EglPlatform,
}
