// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechRecoResult
{
    DISPID_SRRRecoContext = 1,
    DISPID_SRRTimes = (DISPID_SRRRecoContext + 1),
    DISPID_SRRAudioFormat = (DISPID_SRRTimes + 1),
    DISPID_SRRPhraseInfo = (DISPID_SRRAudioFormat + 1),
    DISPID_SRRAlternates = (DISPID_SRRPhraseInfo + 1),
    DISPID_SRRAudio = (DISPID_SRRAlternates + 1),
    DISPID_SRRSpeakAudio = (DISPID_SRRAudio + 1),
    DISPID_SRRSaveToMemory = (DISPID_SRRSpeakAudio + 1),
    DISPID_SRRDiscardResultInfo = (DISPID_SRRSaveToMemory + 1),
}
