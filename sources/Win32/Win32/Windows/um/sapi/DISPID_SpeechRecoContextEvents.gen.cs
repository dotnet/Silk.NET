// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechRecoContextEvents
{
    DISPID_SRCEStartStream = 1,
    DISPID_SRCEEndStream = (DISPID_SRCEStartStream + 1),
    DISPID_SRCEBookmark = (DISPID_SRCEEndStream + 1),
    DISPID_SRCESoundStart = (DISPID_SRCEBookmark + 1),
    DISPID_SRCESoundEnd = (DISPID_SRCESoundStart + 1),
    DISPID_SRCEPhraseStart = (DISPID_SRCESoundEnd + 1),
    DISPID_SRCERecognition = (DISPID_SRCEPhraseStart + 1),
    DISPID_SRCEHypothesis = (DISPID_SRCERecognition + 1),
    DISPID_SRCEPropertyNumberChange = (DISPID_SRCEHypothesis + 1),
    DISPID_SRCEPropertyStringChange = (DISPID_SRCEPropertyNumberChange + 1),
    DISPID_SRCEFalseRecognition = (DISPID_SRCEPropertyStringChange + 1),
    DISPID_SRCEInterference = (DISPID_SRCEFalseRecognition + 1),
    DISPID_SRCERequestUI = (DISPID_SRCEInterference + 1),
    DISPID_SRCERecognizerStateChange = (DISPID_SRCERequestUI + 1),
    DISPID_SRCEAdaptation = (DISPID_SRCERecognizerStateChange + 1),
    DISPID_SRCERecognitionForOtherContext = (DISPID_SRCEAdaptation + 1),
    DISPID_SRCEAudioLevel = (DISPID_SRCERecognitionForOtherContext + 1),
    DISPID_SRCEEnginePrivate = (DISPID_SRCEAudioLevel + 1),
}
