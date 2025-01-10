// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DVD_AUDIO_APPMODE
{
    DVD_AudioMode_None = 0,
    DVD_AudioMode_Karaoke = 1,
    DVD_AudioMode_Surround = 2,
    DVD_AudioMode_Other = 3,
}
