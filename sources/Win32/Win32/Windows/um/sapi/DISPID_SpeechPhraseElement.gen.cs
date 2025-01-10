// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechPhraseElement
{
    DISPID_SPEAudioTimeOffset = 1,
    DISPID_SPEAudioSizeTime = (DISPID_SPEAudioTimeOffset + 1),
    DISPID_SPEAudioStreamOffset = (DISPID_SPEAudioSizeTime + 1),
    DISPID_SPEAudioSizeBytes = (DISPID_SPEAudioStreamOffset + 1),
    DISPID_SPERetainedStreamOffset = (DISPID_SPEAudioSizeBytes + 1),
    DISPID_SPERetainedSizeBytes = (DISPID_SPERetainedStreamOffset + 1),
    DISPID_SPEDisplayText = (DISPID_SPERetainedSizeBytes + 1),
    DISPID_SPELexicalForm = (DISPID_SPEDisplayText + 1),
    DISPID_SPEPronunciation = (DISPID_SPELexicalForm + 1),
    DISPID_SPEDisplayAttributes = (DISPID_SPEPronunciation + 1),
    DISPID_SPERequiredConfidence = (DISPID_SPEDisplayAttributes + 1),
    DISPID_SPEActualConfidence = (DISPID_SPERequiredConfidence + 1),
    DISPID_SPEEngineConfidence = (DISPID_SPEActualConfidence + 1),
}
