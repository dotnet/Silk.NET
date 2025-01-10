// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SpeechRecognizerState
{
    SpeechRecognizerState_Idle = 0,
    SpeechRecognizerState_Capturing = 1,
    SpeechRecognizerState_Processing = 2,
    SpeechRecognizerState_SoundStarted = 3,
    SpeechRecognizerState_SoundEnded = 4,
    SpeechRecognizerState_SpeechDetected = 5,
    SpeechRecognizerState_Paused = 6,
}
