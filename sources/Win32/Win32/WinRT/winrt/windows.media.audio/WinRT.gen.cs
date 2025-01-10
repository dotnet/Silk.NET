// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioDeviceInputNode =
        "Windows.Media.Audio.IAudioDeviceInputNode";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioDeviceOutputNode =
        "Windows.Media.Audio.IAudioDeviceOutputNode";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioEffectsPackConfiguration =
        "Windows.Media.Audio.IAudioEffectsPackConfiguration";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioEffectsPackConfigurationStatics =
        "Windows.Media.Audio.IAudioEffectsPackConfigurationStatics";

    [NativeTypeName("const WCHAR[40]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioFileInputNode =
        "Windows.Media.Audio.IAudioFileInputNode";

    [NativeTypeName("const WCHAR[41]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioFileOutputNode =
        "Windows.Media.Audio.IAudioFileOutputNode";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioFrameCompletedEventArgs =
        "Windows.Media.Audio.IAudioFrameCompletedEventArgs";

    [NativeTypeName("const WCHAR[41]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioFrameInputNode =
        "Windows.Media.Audio.IAudioFrameInputNode";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioFrameOutputNode =
        "Windows.Media.Audio.IAudioFrameOutputNode";

    [NativeTypeName("const WCHAR[32]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioGraph =
        "Windows.Media.Audio.IAudioGraph";

    [NativeTypeName("const WCHAR[33]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioGraph2 =
        "Windows.Media.Audio.IAudioGraph2";

    [NativeTypeName("const WCHAR[33]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioGraph3 =
        "Windows.Media.Audio.IAudioGraph3";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioGraphConnection =
        "Windows.Media.Audio.IAudioGraphConnection";

    [NativeTypeName("const WCHAR[40]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioGraphSettings =
        "Windows.Media.Audio.IAudioGraphSettings";

    [NativeTypeName("const WCHAR[41]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioGraphSettings2 =
        "Windows.Media.Audio.IAudioGraphSettings2";

    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioGraphSettingsFactory =
        "Windows.Media.Audio.IAudioGraphSettingsFactory";

    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioGraphStatics =
        "Windows.Media.Audio.IAudioGraphStatics";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioGraphUnrecoverableErrorOccurredEventArgs =
        "Windows.Media.Audio.IAudioGraphUnrecoverableErrorOccurredEventArgs";

    [NativeTypeName("const WCHAR[36]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioInputNode =
        "Windows.Media.Audio.IAudioInputNode";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioInputNode2 =
        "Windows.Media.Audio.IAudioInputNode2";

    [NativeTypeName("const WCHAR[31]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioNode =
        "Windows.Media.Audio.IAudioNode";

    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioNodeEmitter =
        "Windows.Media.Audio.IAudioNodeEmitter";

    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioNodeEmitter2 =
        "Windows.Media.Audio.IAudioNodeEmitter2";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioNodeEmitterConeProperties =
        "Windows.Media.Audio.IAudioNodeEmitterConeProperties";

    [NativeTypeName("const WCHAR[48]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioNodeEmitterDecayModel =
        "Windows.Media.Audio.IAudioNodeEmitterDecayModel";

    [NativeTypeName("const WCHAR[55]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioNodeEmitterDecayModelStatics =
        "Windows.Media.Audio.IAudioNodeEmitterDecayModelStatics";

    [NativeTypeName("const WCHAR[45]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioNodeEmitterFactory =
        "Windows.Media.Audio.IAudioNodeEmitterFactory";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioNodeEmitterNaturalDecayModelProperties =
        "Windows.Media.Audio.IAudioNodeEmitterNaturalDecayModelProperties";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioNodeEmitterShape =
        "Windows.Media.Audio.IAudioNodeEmitterShape";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioNodeEmitterShapeStatics =
        "Windows.Media.Audio.IAudioNodeEmitterShapeStatics";

    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioNodeListener =
        "Windows.Media.Audio.IAudioNodeListener";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioNodeWithListener =
        "Windows.Media.Audio.IAudioNodeWithListener";

    [NativeTypeName("const WCHAR[45]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioPlaybackConnection =
        "Windows.Media.Audio.IAudioPlaybackConnection";

    [NativeTypeName("const WCHAR[55]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioPlaybackConnectionOpenResult =
        "Windows.Media.Audio.IAudioPlaybackConnectionOpenResult";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioPlaybackConnectionStatics =
        "Windows.Media.Audio.IAudioPlaybackConnectionStatics";

    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioStateMonitor =
        "Windows.Media.Audio.IAudioStateMonitor";

    [NativeTypeName("const WCHAR[46]")]
    public const string InterfaceName_Windows_Media_Audio_IAudioStateMonitorStatics =
        "Windows.Media.Audio.IAudioStateMonitorStatics";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Media_Audio_ICreateAudioDeviceInputNodeResult =
        "Windows.Media.Audio.ICreateAudioDeviceInputNodeResult";

    [NativeTypeName("const WCHAR[55]")]
    public const string InterfaceName_Windows_Media_Audio_ICreateAudioDeviceInputNodeResult2 =
        "Windows.Media.Audio.ICreateAudioDeviceInputNodeResult2";

    [NativeTypeName("const WCHAR[55]")]
    public const string InterfaceName_Windows_Media_Audio_ICreateAudioDeviceOutputNodeResult =
        "Windows.Media.Audio.ICreateAudioDeviceOutputNodeResult";

    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_Media_Audio_ICreateAudioDeviceOutputNodeResult2 =
        "Windows.Media.Audio.ICreateAudioDeviceOutputNodeResult2";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Media_Audio_ICreateAudioFileInputNodeResult =
        "Windows.Media.Audio.ICreateAudioFileInputNodeResult";

    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_Media_Audio_ICreateAudioFileInputNodeResult2 =
        "Windows.Media.Audio.ICreateAudioFileInputNodeResult2";

    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_Media_Audio_ICreateAudioFileOutputNodeResult =
        "Windows.Media.Audio.ICreateAudioFileOutputNodeResult";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Media_Audio_ICreateAudioFileOutputNodeResult2 =
        "Windows.Media.Audio.ICreateAudioFileOutputNodeResult2";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Media_Audio_ICreateAudioGraphResult =
        "Windows.Media.Audio.ICreateAudioGraphResult";

    [NativeTypeName("const WCHAR[45]")]
    public const string InterfaceName_Windows_Media_Audio_ICreateAudioGraphResult2 =
        "Windows.Media.Audio.ICreateAudioGraphResult2";

    [NativeTypeName("const WCHAR[59]")]
    public const string InterfaceName_Windows_Media_Audio_ICreateMediaSourceAudioInputNodeResult =
        "Windows.Media.Audio.ICreateMediaSourceAudioInputNodeResult";

    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_Media_Audio_ICreateMediaSourceAudioInputNodeResult2 =
        "Windows.Media.Audio.ICreateMediaSourceAudioInputNodeResult2";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Media_Audio_IEchoEffectDefinition =
        "Windows.Media.Audio.IEchoEffectDefinition";

    [NativeTypeName("const WCHAR[49]")]
    public const string InterfaceName_Windows_Media_Audio_IEchoEffectDefinitionFactory =
        "Windows.Media.Audio.IEchoEffectDefinitionFactory";

    [NativeTypeName("const WCHAR[35]")]
    public const string InterfaceName_Windows_Media_Audio_IEqualizerBand =
        "Windows.Media.Audio.IEqualizerBand";

    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_Media_Audio_IEqualizerEffectDefinition =
        "Windows.Media.Audio.IEqualizerEffectDefinition";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Media_Audio_IEqualizerEffectDefinitionFactory =
        "Windows.Media.Audio.IEqualizerEffectDefinitionFactory";

    [NativeTypeName("const WCHAR[59]")]
    public const string InterfaceName_Windows_Media_Audio_IFrameInputNodeQuantumStartedEventArgs =
        "Windows.Media.Audio.IFrameInputNodeQuantumStartedEventArgs";

    [NativeTypeName("const WCHAR[45]")]
    public const string InterfaceName_Windows_Media_Audio_ILimiterEffectDefinition =
        "Windows.Media.Audio.ILimiterEffectDefinition";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Media_Audio_ILimiterEffectDefinitionFactory =
        "Windows.Media.Audio.ILimiterEffectDefinitionFactory";

    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_Media_Audio_IMediaSourceAudioInputNode =
        "Windows.Media.Audio.IMediaSourceAudioInputNode";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Media_Audio_IReverbEffectDefinition =
        "Windows.Media.Audio.IReverbEffectDefinition";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Media_Audio_IReverbEffectDefinitionFactory =
        "Windows.Media.Audio.IReverbEffectDefinitionFactory";

    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_Media_Audio_ISetDefaultSpatialAudioFormatResult =
        "Windows.Media.Audio.ISetDefaultSpatialAudioFormatResult";

    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_Media_Audio_ISpatialAudioDeviceConfiguration =
        "Windows.Media.Audio.ISpatialAudioDeviceConfiguration";

    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_Media_Audio_ISpatialAudioDeviceConfigurationStatics =
        "Windows.Media.Audio.ISpatialAudioDeviceConfigurationStatics";

    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_Media_Audio_ISpatialAudioFormatConfiguration =
        "Windows.Media.Audio.ISpatialAudioFormatConfiguration";

    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_Media_Audio_ISpatialAudioFormatConfigurationStatics =
        "Windows.Media.Audio.ISpatialAudioFormatConfigurationStatics";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Media_Audio_ISpatialAudioFormatSubtypeStatics =
        "Windows.Media.Audio.ISpatialAudioFormatSubtypeStatics";

    [NativeTypeName("const WCHAR[55]")]
    public const string InterfaceName_Windows_Media_Audio_ISpatialAudioFormatSubtypeStatics2 =
        "Windows.Media.Audio.ISpatialAudioFormatSubtypeStatics2";

    [NativeTypeName("const WCHAR[41]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioDeviceInputNode =
        "Windows.Media.Audio.AudioDeviceInputNode";

    [NativeTypeName("const WCHAR[42]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioDeviceOutputNode =
        "Windows.Media.Audio.AudioDeviceOutputNode";

    [NativeTypeName("const WCHAR[50]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioEffectsPackConfiguration =
        "Windows.Media.Audio.AudioEffectsPackConfiguration";

    [NativeTypeName("const WCHAR[39]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioFileInputNode =
        "Windows.Media.Audio.AudioFileInputNode";

    [NativeTypeName("const WCHAR[40]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioFileOutputNode =
        "Windows.Media.Audio.AudioFileOutputNode";

    [NativeTypeName("const WCHAR[49]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioFrameCompletedEventArgs =
        "Windows.Media.Audio.AudioFrameCompletedEventArgs";

    [NativeTypeName("const WCHAR[40]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioFrameInputNode =
        "Windows.Media.Audio.AudioFrameInputNode";

    [NativeTypeName("const WCHAR[41]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioFrameOutputNode =
        "Windows.Media.Audio.AudioFrameOutputNode";

    [NativeTypeName("const WCHAR[31]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioGraph =
        "Windows.Media.Audio.AudioGraph";

    [NativeTypeName("const WCHAR[43]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioGraphBatchUpdater =
        "Windows.Media.Audio.AudioGraphBatchUpdater";

    [NativeTypeName("const WCHAR[41]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioGraphConnection =
        "Windows.Media.Audio.AudioGraphConnection";

    [NativeTypeName("const WCHAR[39]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioGraphSettings =
        "Windows.Media.Audio.AudioGraphSettings";

    [NativeTypeName("const WCHAR[66]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioGraphUnrecoverableErrorOccurredEventArgs =
        "Windows.Media.Audio.AudioGraphUnrecoverableErrorOccurredEventArgs";

    [NativeTypeName("const WCHAR[37]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioNodeEmitter =
        "Windows.Media.Audio.AudioNodeEmitter";

    [NativeTypeName("const WCHAR[51]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioNodeEmitterConeProperties =
        "Windows.Media.Audio.AudioNodeEmitterConeProperties";

    [NativeTypeName("const WCHAR[47]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioNodeEmitterDecayModel =
        "Windows.Media.Audio.AudioNodeEmitterDecayModel";

    [NativeTypeName("const WCHAR[64]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioNodeEmitterNaturalDecayModelProperties =
        "Windows.Media.Audio.AudioNodeEmitterNaturalDecayModelProperties";

    [NativeTypeName("const WCHAR[42]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioNodeEmitterShape =
        "Windows.Media.Audio.AudioNodeEmitterShape";

    [NativeTypeName("const WCHAR[38]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioNodeListener =
        "Windows.Media.Audio.AudioNodeListener";

    [NativeTypeName("const WCHAR[44]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioPlaybackConnection =
        "Windows.Media.Audio.AudioPlaybackConnection";

    [NativeTypeName("const WCHAR[54]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioPlaybackConnectionOpenResult =
        "Windows.Media.Audio.AudioPlaybackConnectionOpenResult";

    [NativeTypeName("const WCHAR[38]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioStateMonitor =
        "Windows.Media.Audio.AudioStateMonitor";

    [NativeTypeName("const WCHAR[36]")]
    public const string RuntimeClass_Windows_Media_Audio_AudioSubmixNode =
        "Windows.Media.Audio.AudioSubmixNode";

    [NativeTypeName("const WCHAR[53]")]
    public const string RuntimeClass_Windows_Media_Audio_CreateAudioDeviceInputNodeResult =
        "Windows.Media.Audio.CreateAudioDeviceInputNodeResult";

    [NativeTypeName("const WCHAR[54]")]
    public const string RuntimeClass_Windows_Media_Audio_CreateAudioDeviceOutputNodeResult =
        "Windows.Media.Audio.CreateAudioDeviceOutputNodeResult";

    [NativeTypeName("const WCHAR[51]")]
    public const string RuntimeClass_Windows_Media_Audio_CreateAudioFileInputNodeResult =
        "Windows.Media.Audio.CreateAudioFileInputNodeResult";

    [NativeTypeName("const WCHAR[52]")]
    public const string RuntimeClass_Windows_Media_Audio_CreateAudioFileOutputNodeResult =
        "Windows.Media.Audio.CreateAudioFileOutputNodeResult";

    [NativeTypeName("const WCHAR[43]")]
    public const string RuntimeClass_Windows_Media_Audio_CreateAudioGraphResult =
        "Windows.Media.Audio.CreateAudioGraphResult";

    [NativeTypeName("const WCHAR[58]")]
    public const string RuntimeClass_Windows_Media_Audio_CreateMediaSourceAudioInputNodeResult =
        "Windows.Media.Audio.CreateMediaSourceAudioInputNodeResult";

    [NativeTypeName("const WCHAR[41]")]
    public const string RuntimeClass_Windows_Media_Audio_EchoEffectDefinition =
        "Windows.Media.Audio.EchoEffectDefinition";

    [NativeTypeName("const WCHAR[34]")]
    public const string RuntimeClass_Windows_Media_Audio_EqualizerBand =
        "Windows.Media.Audio.EqualizerBand";

    [NativeTypeName("const WCHAR[46]")]
    public const string RuntimeClass_Windows_Media_Audio_EqualizerEffectDefinition =
        "Windows.Media.Audio.EqualizerEffectDefinition";

    [NativeTypeName("const WCHAR[58]")]
    public const string RuntimeClass_Windows_Media_Audio_FrameInputNodeQuantumStartedEventArgs =
        "Windows.Media.Audio.FrameInputNodeQuantumStartedEventArgs";

    [NativeTypeName("const WCHAR[44]")]
    public const string RuntimeClass_Windows_Media_Audio_LimiterEffectDefinition =
        "Windows.Media.Audio.LimiterEffectDefinition";

    [NativeTypeName("const WCHAR[46]")]
    public const string RuntimeClass_Windows_Media_Audio_MediaSourceAudioInputNode =
        "Windows.Media.Audio.MediaSourceAudioInputNode";

    [NativeTypeName("const WCHAR[43]")]
    public const string RuntimeClass_Windows_Media_Audio_ReverbEffectDefinition =
        "Windows.Media.Audio.ReverbEffectDefinition";

    [NativeTypeName("const WCHAR[55]")]
    public const string RuntimeClass_Windows_Media_Audio_SetDefaultSpatialAudioFormatResult =
        "Windows.Media.Audio.SetDefaultSpatialAudioFormatResult";

    [NativeTypeName("const WCHAR[52]")]
    public const string RuntimeClass_Windows_Media_Audio_SpatialAudioDeviceConfiguration =
        "Windows.Media.Audio.SpatialAudioDeviceConfiguration";

    [NativeTypeName("const WCHAR[52]")]
    public const string RuntimeClass_Windows_Media_Audio_SpatialAudioFormatConfiguration =
        "Windows.Media.Audio.SpatialAudioFormatConfiguration";

    [NativeTypeName("const WCHAR[46]")]
    public const string RuntimeClass_Windows_Media_Audio_SpatialAudioFormatSubtype =
        "Windows.Media.Audio.SpatialAudioFormatSubtype";
}
