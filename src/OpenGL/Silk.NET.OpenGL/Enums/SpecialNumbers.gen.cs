// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "SpecialNumbers")]
    public enum SpecialNumbers : int
    {
        [NativeName("Name", "GL_FALSE")]
        False = 0x0,
        [NativeName("Name", "GL_NO_ERROR")]
        NoError = 0x0,
        [NativeName("Name", "GL_ZERO")]
        Zero = 0x0,
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [NativeName("Name", "GL_NONE_OES")]
        NoneOes = 0x0,
        [NativeName("Name", "GL_TRUE")]
        True = 0x1,
        [NativeName("Name", "GL_ONE")]
        One = 0x1,
        [NativeName("Name", "GL_INVALID_INDEX")]
        InvalidIndex = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_ALL_PIXELS_AMD")]
        AllPixelsAmd = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_TIMEOUT_IGNORED")]
        TimeoutIgnored = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "GL_TIMEOUT_IGNORED_APPLE")]
        TimeoutIgnoredApple = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "GL_VERSION_ES_CL_1_0")]
        VersionESCL10 = 0x1,
        [NativeName("Name", "GL_VERSION_ES_CM_1_1")]
        VersionESCM11 = 0x1,
        [NativeName("Name", "GL_VERSION_ES_CL_1_1")]
        VersionESCL11 = 0x1,
        [NativeName("Name", "GL_UUID_SIZE_EXT")]
        UuidSizeExt = 0x16,
        [NativeName("Name", "GL_LUID_SIZE_EXT")]
        LuidSizeExt = 0x8,
    }
}
