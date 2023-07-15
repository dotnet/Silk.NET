// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SPPROP
{
    [NativeTypeName("#define SPPROP_RESOURCE_USAGE L\"ResourceUsage\"")]
    public const string SPPROP_RESOURCE_USAGE = "ResourceUsage";
    [NativeTypeName("#define SPPROP_HIGH_CONFIDENCE_THRESHOLD L\"HighConfidenceThreshold\"")]
    public const string SPPROP_HIGH_CONFIDENCE_THRESHOLD = "HighConfidenceThreshold";
    [NativeTypeName("#define SPPROP_NORMAL_CONFIDENCE_THRESHOLD L\"NormalConfidenceThreshold\"")]
    public const string SPPROP_NORMAL_CONFIDENCE_THRESHOLD = "NormalConfidenceThreshold";
    [NativeTypeName("#define SPPROP_LOW_CONFIDENCE_THRESHOLD L\"LowConfidenceThreshold\"")]
    public const string SPPROP_LOW_CONFIDENCE_THRESHOLD = "LowConfidenceThreshold";
    [NativeTypeName("#define SPPROP_RESPONSE_SPEED L\"ResponseSpeed\"")]
    public const string SPPROP_RESPONSE_SPEED = "ResponseSpeed";
    [NativeTypeName("#define SPPROP_COMPLEX_RESPONSE_SPEED L\"ComplexResponseSpeed\"")]
    public const string SPPROP_COMPLEX_RESPONSE_SPEED = "ComplexResponseSpeed";
    [NativeTypeName("#define SPPROP_ADAPTATION_ON L\"AdaptationOn\"")]
    public const string SPPROP_ADAPTATION_ON = "AdaptationOn";
    [NativeTypeName("#define SPPROP_PERSISTED_BACKGROUND_ADAPTATION L\"PersistedBackgroundAdaptation\"")]
    public const string SPPROP_PERSISTED_BACKGROUND_ADAPTATION = "PersistedBackgroundAdaptation";
    [NativeTypeName("#define SPPROP_PERSISTED_LANGUAGE_MODEL_ADAPTATION L\"PersistedLanguageModelAdaptation\"")]
    public const string SPPROP_PERSISTED_LANGUAGE_MODEL_ADAPTATION = "PersistedLanguageModelAdaptation";
    [NativeTypeName("#define SPPROP_UX_IS_LISTENING L\"UXIsListening\"")]
    public const string SPPROP_UX_IS_LISTENING = "UXIsListening";
}