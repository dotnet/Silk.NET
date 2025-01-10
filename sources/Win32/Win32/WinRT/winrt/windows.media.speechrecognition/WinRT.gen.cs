// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[79]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechContinuousRecognitionCompletedEventArgs =
        "Windows.Media.SpeechRecognition.ISpeechContinuousRecognitionCompletedEventArgs";

    [NativeTypeName("const WCHAR[85]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechContinuousRecognitionResultGeneratedEventArgs =
        "Windows.Media.SpeechRecognition.ISpeechContinuousRecognitionResultGeneratedEventArgs";

    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechContinuousRecognitionSession =
        "Windows.Media.SpeechRecognition.ISpeechContinuousRecognitionSession";

    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionCompilationResult =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionCompilationResult";

    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionConstraint =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionConstraint";

    [NativeTypeName("const WCHAR[72]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionGrammarFileConstraint =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionGrammarFileConstraint";

    [NativeTypeName("const WCHAR[79]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionGrammarFileConstraintFactory =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionGrammarFileConstraintFactory";

    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionHypothesis =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionHypothesis";

    [NativeTypeName("const WCHAR[79]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionHypothesisGeneratedEventArgs =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionHypothesisGeneratedEventArgs";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionListConstraint =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionListConstraint";

    [NativeTypeName("const WCHAR[72]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionListConstraintFactory =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionListConstraintFactory";

    [NativeTypeName("const WCHAR[76]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionQualityDegradingEventArgs =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionQualityDegradingEventArgs";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionResult =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionResult";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionResult2 =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionResult2";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionSemanticInterpretation =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionSemanticInterpretation";

    [NativeTypeName("const WCHAR[66]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionTopicConstraint =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionTopicConstraint";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionTopicConstraintFactory =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionTopicConstraintFactory";

    [NativeTypeName("const WCHAR[83]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognitionVoiceCommandDefinitionConstraint =
        "Windows.Media.SpeechRecognition.ISpeechRecognitionVoiceCommandDefinitionConstraint";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognizer =
        "Windows.Media.SpeechRecognition.ISpeechRecognizer";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognizer2 =
        "Windows.Media.SpeechRecognition.ISpeechRecognizer2";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognizerFactory =
        "Windows.Media.SpeechRecognition.ISpeechRecognizerFactory";

    [NativeTypeName("const WCHAR[71]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognizerStateChangedEventArgs =
        "Windows.Media.SpeechRecognition.ISpeechRecognizerStateChangedEventArgs";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognizerStatics =
        "Windows.Media.SpeechRecognition.ISpeechRecognizerStatics";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognizerStatics2 =
        "Windows.Media.SpeechRecognition.ISpeechRecognizerStatics2";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognizerTimeouts =
        "Windows.Media.SpeechRecognition.ISpeechRecognizerTimeouts";

    [NativeTypeName("const WCHAR[59]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_ISpeechRecognizerUIOptions =
        "Windows.Media.SpeechRecognition.ISpeechRecognizerUIOptions";

    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_IVoiceCommandManager =
        "Windows.Media.SpeechRecognition.IVoiceCommandManager";

    [NativeTypeName("const WCHAR[49]")]
    public const string InterfaceName_Windows_Media_SpeechRecognition_IVoiceCommandSet =
        "Windows.Media.SpeechRecognition.IVoiceCommandSet";

    [NativeTypeName("const WCHAR[78]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechContinuousRecognitionCompletedEventArgs =
        "Windows.Media.SpeechRecognition.SpeechContinuousRecognitionCompletedEventArgs";

    [NativeTypeName("const WCHAR[84]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechContinuousRecognitionResultGeneratedEventArgs =
        "Windows.Media.SpeechRecognition.SpeechContinuousRecognitionResultGeneratedEventArgs";

    [NativeTypeName("const WCHAR[67]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechContinuousRecognitionSession =
        "Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession";

    [NativeTypeName("const WCHAR[67]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognitionCompilationResult =
        "Windows.Media.SpeechRecognition.SpeechRecognitionCompilationResult";

    [NativeTypeName("const WCHAR[71]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognitionGrammarFileConstraint =
        "Windows.Media.SpeechRecognition.SpeechRecognitionGrammarFileConstraint";

    [NativeTypeName("const WCHAR[60]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognitionHypothesis =
        "Windows.Media.SpeechRecognition.SpeechRecognitionHypothesis";

    [NativeTypeName("const WCHAR[78]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognitionHypothesisGeneratedEventArgs =
        "Windows.Media.SpeechRecognition.SpeechRecognitionHypothesisGeneratedEventArgs";

    [NativeTypeName("const WCHAR[64]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognitionListConstraint =
        "Windows.Media.SpeechRecognition.SpeechRecognitionListConstraint";

    [NativeTypeName("const WCHAR[75]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognitionQualityDegradingEventArgs =
        "Windows.Media.SpeechRecognition.SpeechRecognitionQualityDegradingEventArgs";

    [NativeTypeName("const WCHAR[56]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognitionResult =
        "Windows.Media.SpeechRecognition.SpeechRecognitionResult";

    [NativeTypeName("const WCHAR[72]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognitionSemanticInterpretation =
        "Windows.Media.SpeechRecognition.SpeechRecognitionSemanticInterpretation";

    [NativeTypeName("const WCHAR[65]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognitionTopicConstraint =
        "Windows.Media.SpeechRecognition.SpeechRecognitionTopicConstraint";

    [NativeTypeName("const WCHAR[82]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognitionVoiceCommandDefinitionConstraint =
        "Windows.Media.SpeechRecognition.SpeechRecognitionVoiceCommandDefinitionConstraint";

    [NativeTypeName("const WCHAR[49]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognizer =
        "Windows.Media.SpeechRecognition.SpeechRecognizer";

    [NativeTypeName("const WCHAR[70]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognizerStateChangedEventArgs =
        "Windows.Media.SpeechRecognition.SpeechRecognizerStateChangedEventArgs";

    [NativeTypeName("const WCHAR[57]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognizerTimeouts =
        "Windows.Media.SpeechRecognition.SpeechRecognizerTimeouts";

    [NativeTypeName("const WCHAR[58]")]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_SpeechRecognizerUIOptions =
        "Windows.Media.SpeechRecognition.SpeechRecognizerUIOptions";

    [NativeTypeName("const WCHAR[52]")]
    [Obsolete(
        "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_VoiceCommandManager =
        "Windows.Media.SpeechRecognition.VoiceCommandManager";

    [NativeTypeName("const WCHAR[48]")]
    [Obsolete(
        "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_Media_SpeechRecognition_VoiceCommandSet =
        "Windows.Media.SpeechRecognition.VoiceCommandSet";
}
