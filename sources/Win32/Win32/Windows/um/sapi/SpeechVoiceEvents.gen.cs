// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SpeechVoiceEvents
{
    SVEStartInputStream = (1 << 1),
    SVEEndInputStream = (1 << 2),
    SVEVoiceChange = (1 << 3),
    SVEBookmark = (1 << 4),
    SVEWordBoundary = (1 << 5),
    SVEPhoneme = (1 << 6),
    SVESentenceBoundary = (1 << 7),
    SVEViseme = (1 << 8),
    SVEAudioLevel = (1 << 9),
    SVEPrivate = (1 << 15),
    SVEAllEvents = 0x83fe,
}
