// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SpeechRecognitionAudioProblem
{
    SpeechRecognitionAudioProblem_None = 0,
    SpeechRecognitionAudioProblem_TooNoisy = 1,
    SpeechRecognitionAudioProblem_NoSignal = 2,
    SpeechRecognitionAudioProblem_TooLoud = 3,
    SpeechRecognitionAudioProblem_TooQuiet = 4,
    SpeechRecognitionAudioProblem_TooFast = 5,
    SpeechRecognitionAudioProblem_TooSlow = 6,
}
