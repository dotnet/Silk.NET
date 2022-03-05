// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_thread_L64_C9")]
    [NativeName("Name", "SDL_ThreadPriority")]
    public enum ThreadPriority : int
    {
        [NativeName("Name", "SDL_THREAD_PRIORITY_LOW")]
        ThreadPriorityLow = 0x0,
        [NativeName("Name", "SDL_THREAD_PRIORITY_NORMAL")]
        ThreadPriorityNormal = 0x1,
        [NativeName("Name", "SDL_THREAD_PRIORITY_HIGH")]
        ThreadPriorityHigh = 0x2,
        [NativeName("Name", "SDL_THREAD_PRIORITY_TIME_CRITICAL")]
        ThreadPriorityTimeCritical = 0x3,
    }
}
