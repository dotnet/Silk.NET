// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_thread_L59_C9")]
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
