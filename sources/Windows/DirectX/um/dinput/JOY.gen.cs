// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class JOY
{
    [NativeTypeName("#define JOY_PASSDRIVERDATA 0x10000000l")]
    public const int JOY_PASSDRIVERDATA = 0x10000000;
    [NativeTypeName("#define JOY_HWS_ISHEADTRACKER 0x02000000l")]
    public const int JOY_HWS_ISHEADTRACKER = 0x02000000;
    [NativeTypeName("#define JOY_HWS_ISGAMEPORTDRIVER 0x04000000l")]
    public const int JOY_HWS_ISGAMEPORTDRIVER = 0x04000000;
    [NativeTypeName("#define JOY_HWS_ISANALOGPORTDRIVER 0x08000000l")]
    public const int JOY_HWS_ISANALOGPORTDRIVER = 0x08000000;
    [NativeTypeName("#define JOY_HWS_AUTOLOAD 0x10000000l")]
    public const int JOY_HWS_AUTOLOAD = 0x10000000;
    [NativeTypeName("#define JOY_HWS_NODEVNODE 0x20000000l")]
    public const int JOY_HWS_NODEVNODE = 0x20000000;
    [NativeTypeName("#define JOY_HWS_ISGAMEPORTBUS 0x80000000l")]
    public const uint JOY_HWS_ISGAMEPORTBUS = 0x80000000;
    [NativeTypeName("#define JOY_HWS_GAMEPORTBUSBUSY 0x00000001l")]
    public const int JOY_HWS_GAMEPORTBUSBUSY = 0x00000001;
    [NativeTypeName("#define JOY_US_VOLATILE 0x00000008L")]
    public const int JOY_US_VOLATILE = 0x00000008;
}