// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class TABLET
{
    [NativeTypeName("#define TABLET_DISABLE_PRESSANDHOLD 0x00000001")]
    public const int TABLET_DISABLE_PRESSANDHOLD = 0x00000001;
    [NativeTypeName("#define TABLET_DISABLE_PENTAPFEEDBACK 0x00000008")]
    public const int TABLET_DISABLE_PENTAPFEEDBACK = 0x00000008;
    [NativeTypeName("#define TABLET_DISABLE_PENBARRELFEEDBACK 0x00000010")]
    public const int TABLET_DISABLE_PENBARRELFEEDBACK = 0x00000010;
    [NativeTypeName("#define TABLET_DISABLE_TOUCHUIFORCEON 0x00000100")]
    public const int TABLET_DISABLE_TOUCHUIFORCEON = 0x00000100;
    [NativeTypeName("#define TABLET_DISABLE_TOUCHUIFORCEOFF 0x00000200")]
    public const int TABLET_DISABLE_TOUCHUIFORCEOFF = 0x00000200;
    [NativeTypeName("#define TABLET_DISABLE_TOUCHSWITCH 0x00008000")]
    public const int TABLET_DISABLE_TOUCHSWITCH = 0x00008000;
    [NativeTypeName("#define TABLET_DISABLE_FLICKS 0x00010000")]
    public const int TABLET_DISABLE_FLICKS = 0x00010000;
    [NativeTypeName("#define TABLET_ENABLE_FLICKSONCONTEXT 0x00020000")]
    public const int TABLET_ENABLE_FLICKSONCONTEXT = 0x00020000;
    [NativeTypeName("#define TABLET_ENABLE_FLICKLEARNINGMODE 0x00040000")]
    public const int TABLET_ENABLE_FLICKLEARNINGMODE = 0x00040000;
    [NativeTypeName("#define TABLET_DISABLE_SMOOTHSCROLLING 0x00080000")]
    public const int TABLET_DISABLE_SMOOTHSCROLLING = 0x00080000;
    [NativeTypeName("#define TABLET_DISABLE_FLICKFALLBACKKEYS 0x00100000")]
    public const int TABLET_DISABLE_FLICKFALLBACKKEYS = 0x00100000;
    [NativeTypeName("#define TABLET_ENABLE_MULTITOUCHDATA 0x01000000")]
    public const int TABLET_ENABLE_MULTITOUCHDATA = 0x01000000;
}