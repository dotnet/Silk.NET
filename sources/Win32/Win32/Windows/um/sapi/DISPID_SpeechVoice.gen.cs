// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechVoice
{
    DISPID_SVStatus = 1,
    DISPID_SVVoice = (DISPID_SVStatus + 1),
    DISPID_SVAudioOutput = (DISPID_SVVoice + 1),
    DISPID_SVAudioOutputStream = (DISPID_SVAudioOutput + 1),
    DISPID_SVRate = (DISPID_SVAudioOutputStream + 1),
    DISPID_SVVolume = (DISPID_SVRate + 1),
    DISPID_SVAllowAudioOuputFormatChangesOnNextSet = (DISPID_SVVolume + 1),
    DISPID_SVEventInterests = (DISPID_SVAllowAudioOuputFormatChangesOnNextSet + 1),
    DISPID_SVPriority = (DISPID_SVEventInterests + 1),
    DISPID_SVAlertBoundary = (DISPID_SVPriority + 1),
    DISPID_SVSyncronousSpeakTimeout = (DISPID_SVAlertBoundary + 1),
    DISPID_SVSpeak = (DISPID_SVSyncronousSpeakTimeout + 1),
    DISPID_SVSpeakStream = (DISPID_SVSpeak + 1),
    DISPID_SVPause = (DISPID_SVSpeakStream + 1),
    DISPID_SVResume = (DISPID_SVPause + 1),
    DISPID_SVSkip = (DISPID_SVResume + 1),
    DISPID_SVGetVoices = (DISPID_SVSkip + 1),
    DISPID_SVGetAudioOutputs = (DISPID_SVGetVoices + 1),
    DISPID_SVWaitUntilDone = (DISPID_SVGetAudioOutputs + 1),
    DISPID_SVSpeakCompleteEvent = (DISPID_SVWaitUntilDone + 1),
    DISPID_SVIsUISupported = (DISPID_SVSpeakCompleteEvent + 1),
    DISPID_SVDisplayUI = (DISPID_SVIsUISupported + 1),
}
