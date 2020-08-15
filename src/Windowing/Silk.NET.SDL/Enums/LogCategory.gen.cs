// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_log_L64_C9")]
    [NativeName("Name", "SDL_LogCategory")]
    public enum LogCategory
    {
        [NativeName("Name", "SDL_LOG_CATEGORY_APPLICATION")]
        LogCategoryApplication = 0x0,
        [NativeName("Name", "SDL_LOG_CATEGORY_ERROR")]
        LogCategoryError = 0x1,
        [NativeName("Name", "SDL_LOG_CATEGORY_ASSERT")]
        LogCategoryAssert = 0x2,
        [NativeName("Name", "SDL_LOG_CATEGORY_SYSTEM")]
        LogCategorySystem = 0x3,
        [NativeName("Name", "SDL_LOG_CATEGORY_AUDIO")]
        LogCategoryAudio = 0x4,
        [NativeName("Name", "SDL_LOG_CATEGORY_VIDEO")]
        LogCategoryVideo = 0x5,
        [NativeName("Name", "SDL_LOG_CATEGORY_RENDER")]
        LogCategoryRender = 0x6,
        [NativeName("Name", "SDL_LOG_CATEGORY_INPUT")]
        LogCategoryInput = 0x7,
        [NativeName("Name", "SDL_LOG_CATEGORY_TEST")]
        LogCategoryTest = 0x8,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED1")]
        LogCategoryReserved1 = 0x9,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED2")]
        LogCategoryReserved2 = 0xA,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED3")]
        LogCategoryReserved3 = 0xB,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED4")]
        LogCategoryReserved4 = 0xC,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED5")]
        LogCategoryReserved5 = 0xD,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED6")]
        LogCategoryReserved6 = 0xE,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED7")]
        LogCategoryReserved7 = 0xF,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED8")]
        LogCategoryReserved8 = 0x10,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED9")]
        LogCategoryReserved9 = 0x11,
        [NativeName("Name", "SDL_LOG_CATEGORY_RESERVED10")]
        LogCategoryReserved10 = 0x12,
        [NativeName("Name", "SDL_LOG_CATEGORY_CUSTOM")]
        LogCategoryCustom = 0x13,
    }
}
