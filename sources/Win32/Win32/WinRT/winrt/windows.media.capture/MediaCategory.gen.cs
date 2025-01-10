// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum MediaCategory
{
    MediaCategory_Other = 0,
    MediaCategory_Communications = 1,
    MediaCategory_Media = 2,
    MediaCategory_GameChat = 3,
    MediaCategory_Speech = 4,
    MediaCategory_FarFieldSpeech = 5,
    MediaCategory_UniformSpeech = 6,
    MediaCategory_VoiceTyping = 7,
}
