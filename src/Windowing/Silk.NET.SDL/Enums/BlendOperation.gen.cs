// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_blendmode_L65_C9")]
    [NativeName("Name", "SDL_BlendOperation")]
    public enum BlendOperation : int
    {
        [NativeName("Name", "SDL_BLENDOPERATION_ADD")]
        BlendoperationAdd = 0x1,
        [NativeName("Name", "SDL_BLENDOPERATION_SUBTRACT")]
        BlendoperationSubtract = 0x2,
        [NativeName("Name", "SDL_BLENDOPERATION_REV_SUBTRACT")]
        BlendoperationRevSubtract = 0x3,
        [NativeName("Name", "SDL_BLENDOPERATION_MINIMUM")]
        BlendoperationMinimum = 0x4,
        [NativeName("Name", "SDL_BLENDOPERATION_MAXIMUM")]
        BlendoperationMaximum = 0x5,
    }
}
