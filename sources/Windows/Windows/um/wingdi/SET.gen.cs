// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SET
{
    [NativeTypeName("#define SET_ARC_DIRECTION 4102")]
    public const int SET_ARC_DIRECTION = 4102;
    [NativeTypeName("#define SET_BACKGROUND_COLOR 4103")]
    public const int SET_BACKGROUND_COLOR = 4103;
    [NativeTypeName("#define SET_POLY_MODE 4104")]
    public const int SET_POLY_MODE = 4104;
    [NativeTypeName("#define SET_SCREEN_ANGLE 4105")]
    public const int SET_SCREEN_ANGLE = 4105;
    [NativeTypeName("#define SET_SPREAD 4106")]
    public const int SET_SPREAD = 4106;
    [NativeTypeName("#define SET_CLIP_BOX 4108")]
    public const int SET_CLIP_BOX = 4108;
    [NativeTypeName("#define SET_BOUNDS 4109")]
    public const int SET_BOUNDS = 4109;
    [NativeTypeName("#define SET_MIRROR_MODE 4110")]
    public const int SET_MIRROR_MODE = 4110;
}