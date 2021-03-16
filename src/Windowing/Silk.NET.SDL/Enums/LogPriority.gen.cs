// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_log_L102_C9")]
    [NativeName("Name", "SDL_LogPriority")]
    public enum LogPriority : int
    {
        [NativeName("Name", "SDL_LOG_PRIORITY_VERBOSE")]
        LogPriorityVerbose = 0x1,
        [NativeName("Name", "SDL_LOG_PRIORITY_DEBUG")]
        LogPriorityDebug = 0x2,
        [NativeName("Name", "SDL_LOG_PRIORITY_INFO")]
        LogPriorityInfo = 0x3,
        [NativeName("Name", "SDL_LOG_PRIORITY_WARN")]
        LogPriorityWarn = 0x4,
        [NativeName("Name", "SDL_LOG_PRIORITY_ERROR")]
        LogPriorityError = 0x5,
        [NativeName("Name", "SDL_LOG_PRIORITY_CRITICAL")]
        LogPriorityCritical = 0x6,
        [NativeName("Name", "SDL_NUM_LOG_PRIORITIES")]
        NumLogPriorities = 0x7,
    }
}
