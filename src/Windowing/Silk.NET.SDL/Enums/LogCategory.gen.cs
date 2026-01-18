// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_LogCategory")]
    public enum LogCategory : int
    {
        [Obsolete("Deprecated in favour of \"Application\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_APPLICATION")]
        LogCategoryApplication = 0x0,
        [Obsolete("Deprecated in favour of \"Error\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_ERROR")]
        LogCategoryError = 0x1,
        [Obsolete("Deprecated in favour of \"Assert\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_ASSERT")]
        LogCategoryAssert = 0x2,
        [Obsolete("Deprecated in favour of \"System\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_SYSTEM")]
        LogCategorySystem = 0x3,
        [Obsolete("Deprecated in favour of \"Audio\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_AUDIO")]
        LogCategoryAudio = 0x4,
        [Obsolete("Deprecated in favour of \"Video\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_VIDEO")]
        LogCategoryVideo = 0x5,
        [Obsolete("Deprecated in favour of \"Render\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_RENDER")]
        LogCategoryRender = 0x6,
        [Obsolete("Deprecated in favour of \"Input\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_INPUT")]
        LogCategoryInput = 0x7,
        [Obsolete("Deprecated in favour of \"Test\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_TEST")]
        LogCategoryTest = 0x8,
        [Obsolete("Deprecated in favour of \"Reserved1\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED1")]
        LogCategoryReserved1 = 0x9,
        [Obsolete("Deprecated in favour of \"Reserved2\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED2")]
        LogCategoryReserved2 = 0xA,
        [Obsolete("Deprecated in favour of \"Reserved3\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED3")]
        LogCategoryReserved3 = 0xB,
        [Obsolete("Deprecated in favour of \"Reserved4\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED4")]
        LogCategoryReserved4 = 0xC,
        [Obsolete("Deprecated in favour of \"Reserved5\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED5")]
        LogCategoryReserved5 = 0xD,
        [Obsolete("Deprecated in favour of \"Reserved6\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED6")]
        LogCategoryReserved6 = 0xE,
        [Obsolete("Deprecated in favour of \"Reserved7\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED7")]
        LogCategoryReserved7 = 0xF,
        [Obsolete("Deprecated in favour of \"Reserved8\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED8")]
        LogCategoryReserved8 = 0x10,
        [Obsolete("Deprecated in favour of \"Reserved9\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED9")]
        LogCategoryReserved9 = 0x11,
        [Obsolete("Deprecated in favour of \"Reserved10\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED10")]
        LogCategoryReserved10 = 0x12,
        [Obsolete("Deprecated in favour of \"Custom\"")]
        [NativeName("Name", "SDL_LOG_CATEGORY_CUSTOM")]
        LogCategoryCustom = 0x13,
        [NativeName("Name", "SDL_LOG_CATEGORY_APPLICATION")]
        Application = 0x0,
        [NativeName("Name", "SDL_LOG_CATEGORY_ERROR")]
        Error = 0x1,
        [NativeName("Name", "SDL_LOG_CATEGORY_ASSERT")]
        Assert = 0x2,
        [NativeName("Name", "SDL_LOG_CATEGORY_SYSTEM")]
        System = 0x3,
        [NativeName("Name", "SDL_LOG_CATEGORY_AUDIO")]
        Audio = 0x4,
        [NativeName("Name", "SDL_LOG_CATEGORY_VIDEO")]
        Video = 0x5,
        [NativeName("Name", "SDL_LOG_CATEGORY_RENDER")]
        Render = 0x6,
        [NativeName("Name", "SDL_LOG_CATEGORY_INPUT")]
        Input = 0x7,
        [NativeName("Name", "SDL_LOG_CATEGORY_TEST")]
        Test = 0x8,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED1")]
        Reserved1 = 0x9,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED2")]
        Reserved2 = 0xA,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED3")]
        Reserved3 = 0xB,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED4")]
        Reserved4 = 0xC,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED5")]
        Reserved5 = 0xD,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED6")]
        Reserved6 = 0xE,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED7")]
        Reserved7 = 0xF,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED8")]
        Reserved8 = 0x10,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED9")]
        Reserved9 = 0x11,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED10")]
        Reserved10 = 0x12,
        [NativeName("Name", "SDL_LOG_CATEGORY_CUSTOM")]
        Custom = 0x13,
    }
}
