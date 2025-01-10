// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechRecognizer
{
    DISPID_SRRecognizer = 1,
    DISPID_SRAllowAudioInputFormatChangesOnNextSet = (DISPID_SRRecognizer + 1),
    DISPID_SRAudioInput = (DISPID_SRAllowAudioInputFormatChangesOnNextSet + 1),
    DISPID_SRAudioInputStream = (DISPID_SRAudioInput + 1),
    DISPID_SRIsShared = (DISPID_SRAudioInputStream + 1),
    DISPID_SRState = (DISPID_SRIsShared + 1),
    DISPID_SRStatus = (DISPID_SRState + 1),
    DISPID_SRProfile = (DISPID_SRStatus + 1),
    DISPID_SREmulateRecognition = (DISPID_SRProfile + 1),
    DISPID_SRCreateRecoContext = (DISPID_SREmulateRecognition + 1),
    DISPID_SRGetFormat = (DISPID_SRCreateRecoContext + 1),
    DISPID_SRSetPropertyNumber = (DISPID_SRGetFormat + 1),
    DISPID_SRGetPropertyNumber = (DISPID_SRSetPropertyNumber + 1),
    DISPID_SRSetPropertyString = (DISPID_SRGetPropertyNumber + 1),
    DISPID_SRGetPropertyString = (DISPID_SRSetPropertyString + 1),
    DISPID_SRIsUISupported = (DISPID_SRGetPropertyString + 1),
    DISPID_SRDisplayUI = (DISPID_SRIsUISupported + 1),
    DISPID_SRGetRecognizers = (DISPID_SRDisplayUI + 1),
    DISPID_SVGetAudioInputs = (DISPID_SRGetRecognizers + 1),
    DISPID_SVGetProfiles = (DISPID_SVGetAudioInputs + 1),
}
