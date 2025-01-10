// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechVoiceEvent
{
    DISPID_SVEStreamStart = 1,
    DISPID_SVEStreamEnd = (DISPID_SVEStreamStart + 1),
    DISPID_SVEVoiceChange = (DISPID_SVEStreamEnd + 1),
    DISPID_SVEBookmark = (DISPID_SVEVoiceChange + 1),
    DISPID_SVEWord = (DISPID_SVEBookmark + 1),
    DISPID_SVEPhoneme = (DISPID_SVEWord + 1),
    DISPID_SVESentenceBoundary = (DISPID_SVEPhoneme + 1),
    DISPID_SVEViseme = (DISPID_SVESentenceBoundary + 1),
    DISPID_SVEAudioLevel = (DISPID_SVEViseme + 1),
    DISPID_SVEEnginePrivate = (DISPID_SVEAudioLevel + 1),
}
