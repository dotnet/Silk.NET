// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SPDUI
{
    [NativeTypeName("#define SPDUI_EngineProperties L\"EngineProperties\"")]
    public const string SPDUI_EngineProperties = "EngineProperties";

    [NativeTypeName("#define SPDUI_AddRemoveWord L\"AddRemoveWord\"")]
    public const string SPDUI_AddRemoveWord = "AddRemoveWord";

    [NativeTypeName("#define SPDUI_UserTraining L\"UserTraining\"")]
    public const string SPDUI_UserTraining = "UserTraining";

    [NativeTypeName("#define SPDUI_MicTraining L\"MicTraining\"")]
    public const string SPDUI_MicTraining = "MicTraining";

    [NativeTypeName("#define SPDUI_RecoProfileProperties L\"RecoProfileProperties\"")]
    public const string SPDUI_RecoProfileProperties = "RecoProfileProperties";

    [NativeTypeName("#define SPDUI_AudioProperties L\"AudioProperties\"")]
    public const string SPDUI_AudioProperties = "AudioProperties";

    [NativeTypeName("#define SPDUI_AudioVolume L\"AudioVolume\"")]
    public const string SPDUI_AudioVolume = "AudioVolume";

    [NativeTypeName("#define SPDUI_UserEnrollment L\"UserEnrollment\"")]
    public const string SPDUI_UserEnrollment = "UserEnrollment";

    [NativeTypeName("#define SPDUI_ShareData L\"ShareData\"")]
    public const string SPDUI_ShareData = "ShareData";

    [NativeTypeName("#define SPDUI_Tutorial L\"Tutorial\"")]
    public const string SPDUI_Tutorial = "Tutorial";
}
