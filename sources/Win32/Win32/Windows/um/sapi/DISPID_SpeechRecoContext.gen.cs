// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechRecoContext
{
    DISPID_SRCRecognizer = 1,
    DISPID_SRCAudioInInterferenceStatus = (DISPID_SRCRecognizer + 1),
    DISPID_SRCRequestedUIType = (DISPID_SRCAudioInInterferenceStatus + 1),
    DISPID_SRCVoice = (DISPID_SRCRequestedUIType + 1),
    DISPID_SRAllowVoiceFormatMatchingOnNextSet = (DISPID_SRCVoice + 1),
    DISPID_SRCVoicePurgeEvent = (DISPID_SRAllowVoiceFormatMatchingOnNextSet + 1),
    DISPID_SRCEventInterests = (DISPID_SRCVoicePurgeEvent + 1),
    DISPID_SRCCmdMaxAlternates = (DISPID_SRCEventInterests + 1),
    DISPID_SRCState = (DISPID_SRCCmdMaxAlternates + 1),
    DISPID_SRCRetainedAudio = (DISPID_SRCState + 1),
    DISPID_SRCRetainedAudioFormat = (DISPID_SRCRetainedAudio + 1),
    DISPID_SRCPause = (DISPID_SRCRetainedAudioFormat + 1),
    DISPID_SRCResume = (DISPID_SRCPause + 1),
    DISPID_SRCCreateGrammar = (DISPID_SRCResume + 1),
    DISPID_SRCCreateResultFromMemory = (DISPID_SRCCreateGrammar + 1),
    DISPID_SRCBookmark = (DISPID_SRCCreateResultFromMemory + 1),
    DISPID_SRCSetAdaptationData = (DISPID_SRCBookmark + 1),
}
