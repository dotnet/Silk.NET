// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.render.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AudioRenderCategory
{
    AudioRenderCategory_Other = 0,

    [Obsolete(
        "ForegroundOnlyMedia is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    AudioRenderCategory_ForegroundOnlyMedia = 1,

    [Obsolete(
        "BackgroundCapableMedia is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    AudioRenderCategory_BackgroundCapableMedia = 2,
    AudioRenderCategory_Communications = 3,
    AudioRenderCategory_Alerts = 4,
    AudioRenderCategory_SoundEffects = 5,
    AudioRenderCategory_GameEffects = 6,
    AudioRenderCategory_GameMedia = 7,
    AudioRenderCategory_GameChat = 8,
    AudioRenderCategory_Speech = 9,
    AudioRenderCategory_Movie = 10,
    AudioRenderCategory_Media = 11,
}
