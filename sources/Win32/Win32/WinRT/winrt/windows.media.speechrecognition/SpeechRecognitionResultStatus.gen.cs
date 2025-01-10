// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SpeechRecognitionResultStatus
{
    SpeechRecognitionResultStatus_Success = 0,
    SpeechRecognitionResultStatus_TopicLanguageNotSupported = 1,
    SpeechRecognitionResultStatus_GrammarLanguageMismatch = 2,
    SpeechRecognitionResultStatus_GrammarCompilationFailure = 3,
    SpeechRecognitionResultStatus_AudioQualityFailure = 4,
    SpeechRecognitionResultStatus_UserCanceled = 5,
    SpeechRecognitionResultStatus_Unknown = 6,
    SpeechRecognitionResultStatus_TimeoutExceeded = 7,
    SpeechRecognitionResultStatus_PauseLimitExceeded = 8,
    SpeechRecognitionResultStatus_NetworkFailure = 9,
    SpeechRecognitionResultStatus_MicrophoneUnavailable = 10,
}
