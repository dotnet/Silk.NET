// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SpeechRecoEvents
{
    SREStreamEnd = (1 << 0),
    SRESoundStart = (1 << 1),
    SRESoundEnd = (1 << 2),
    SREPhraseStart = (1 << 3),
    SRERecognition = (1 << 4),
    SREHypothesis = (1 << 5),
    SREBookmark = (1 << 6),
    SREPropertyNumChange = (1 << 7),
    SREPropertyStringChange = (1 << 8),
    SREFalseRecognition = (1 << 9),
    SREInterference = (1 << 10),
    SRERequestUI = (1 << 11),
    SREStateChange = (1 << 12),
    SREAdaptation = (1 << 13),
    SREStreamStart = (1 << 14),
    SRERecoOtherContext = (1 << 15),
    SREAudioLevel = (1 << 16),
    SREPrivate = (1 << 18),
    SREAllEvents = 0x5ffff,
}
