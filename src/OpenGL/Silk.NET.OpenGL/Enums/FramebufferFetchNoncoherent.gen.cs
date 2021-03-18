// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
