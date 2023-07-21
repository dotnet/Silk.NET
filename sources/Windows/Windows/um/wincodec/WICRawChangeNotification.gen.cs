// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class WICRawChangeNotification
{
    [NativeTypeName("#define WICRawChangeNotification_ExposureCompensation 0x00000001")]
    public const int WICRawChangeNotification_ExposureCompensation = 0x00000001;

    [NativeTypeName("#define WICRawChangeNotification_NamedWhitePoint 0x00000002")]
    public const int WICRawChangeNotification_NamedWhitePoint = 0x00000002;

    [NativeTypeName("#define WICRawChangeNotification_KelvinWhitePoint 0x00000004")]
    public const int WICRawChangeNotification_KelvinWhitePoint = 0x00000004;

    [NativeTypeName("#define WICRawChangeNotification_RGBWhitePoint 0x00000008")]
    public const int WICRawChangeNotification_RGBWhitePoint = 0x00000008;

    [NativeTypeName("#define WICRawChangeNotification_Contrast 0x00000010")]
    public const int WICRawChangeNotification_Contrast = 0x00000010;

    [NativeTypeName("#define WICRawChangeNotification_Gamma 0x00000020")]
    public const int WICRawChangeNotification_Gamma = 0x00000020;

    [NativeTypeName("#define WICRawChangeNotification_Sharpness 0x00000040")]
    public const int WICRawChangeNotification_Sharpness = 0x00000040;

    [NativeTypeName("#define WICRawChangeNotification_Saturation 0x00000080")]
    public const int WICRawChangeNotification_Saturation = 0x00000080;

    [NativeTypeName("#define WICRawChangeNotification_Tint 0x00000100")]
    public const int WICRawChangeNotification_Tint = 0x00000100;

    [NativeTypeName("#define WICRawChangeNotification_NoiseReduction 0x00000200")]
    public const int WICRawChangeNotification_NoiseReduction = 0x00000200;

    [NativeTypeName("#define WICRawChangeNotification_DestinationColorContext 0x00000400")]
    public const int WICRawChangeNotification_DestinationColorContext = 0x00000400;

    [NativeTypeName("#define WICRawChangeNotification_ToneCurve 0x00000800")]
    public const int WICRawChangeNotification_ToneCurve = 0x00000800;

    [NativeTypeName("#define WICRawChangeNotification_Rotation 0x00001000")]
    public const int WICRawChangeNotification_Rotation = 0x00001000;

    [NativeTypeName("#define WICRawChangeNotification_RenderMode 0x00002000")]
    public const int WICRawChangeNotification_RenderMode = 0x00002000;
}
