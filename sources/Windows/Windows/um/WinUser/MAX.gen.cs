// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class MAX
{
    [NativeTypeName("#define MAX_TOUCH_COUNT 256")]
    public const int MAX_TOUCH_COUNT = 256;
    [NativeTypeName("#define MAX_TOUCH_PREDICTION_FILTER_TAPS 3")]
    public const int MAX_TOUCH_PREDICTION_FILTER_TAPS = 3;
    [NativeTypeName("#define MAX_LOGICALDPIOVERRIDE 2")]
    public const int MAX_LOGICALDPIOVERRIDE = 2;
    [NativeTypeName("#define MAX_STR_BLOCKREASON 256")]
    public const int MAX_STR_BLOCKREASON = 256;
}