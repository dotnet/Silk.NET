// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.DirectX;
public static partial class DIPROP
{
    [NativeTypeName("#define DIPROP_BUFFERSIZE MAKEDIPROP(1)")]
    public static ref readonly Guid DIPROP_BUFFERSIZE => ref unchecked(*(Guid*)(1));

    [NativeTypeName("#define DIPROP_AXISMODE MAKEDIPROP(2)")]
    public static ref readonly Guid DIPROP_AXISMODE => ref unchecked(*(Guid*)(2));

    [NativeTypeName("#define DIPROP_GRANULARITY MAKEDIPROP(3)")]
    public static ref readonly Guid DIPROP_GRANULARITY => ref unchecked(*(Guid*)(3));

    [NativeTypeName("#define DIPROP_RANGE MAKEDIPROP(4)")]
    public static ref readonly Guid DIPROP_RANGE => ref unchecked(*(Guid*)(4));

    [NativeTypeName("#define DIPROP_DEADZONE MAKEDIPROP(5)")]
    public static ref readonly Guid DIPROP_DEADZONE => ref unchecked(*(Guid*)(5));

    [NativeTypeName("#define DIPROP_SATURATION MAKEDIPROP(6)")]
    public static ref readonly Guid DIPROP_SATURATION => ref unchecked(*(Guid*)(6));

    [NativeTypeName("#define DIPROP_FFGAIN MAKEDIPROP(7)")]
    public static ref readonly Guid DIPROP_FFGAIN => ref unchecked(*(Guid*)(7));

    [NativeTypeName("#define DIPROP_FFLOAD MAKEDIPROP(8)")]
    public static ref readonly Guid DIPROP_FFLOAD => ref unchecked(*(Guid*)(8));

    [NativeTypeName("#define DIPROP_AUTOCENTER MAKEDIPROP(9)")]
    public static ref readonly Guid DIPROP_AUTOCENTER => ref unchecked(*(Guid*)(9));

    [NativeTypeName("#define DIPROP_CALIBRATIONMODE MAKEDIPROP(10)")]
    public static ref readonly Guid DIPROP_CALIBRATIONMODE => ref unchecked(*(Guid*)(10));

    [NativeTypeName("#define DIPROP_CALIBRATION MAKEDIPROP(11)")]
    public static ref readonly Guid DIPROP_CALIBRATION => ref unchecked(*(Guid*)(11));

    [NativeTypeName("#define DIPROP_GUIDANDPATH MAKEDIPROP(12)")]
    public static ref readonly Guid DIPROP_GUIDANDPATH => ref unchecked(*(Guid*)(12));

    [NativeTypeName("#define DIPROP_INSTANCENAME MAKEDIPROP(13)")]
    public static ref readonly Guid DIPROP_INSTANCENAME => ref unchecked(*(Guid*)(13));

    [NativeTypeName("#define DIPROP_PRODUCTNAME MAKEDIPROP(14)")]
    public static ref readonly Guid DIPROP_PRODUCTNAME => ref unchecked(*(Guid*)(14));

    [NativeTypeName("#define DIPROP_JOYSTICKID MAKEDIPROP(15)")]
    public static ref readonly Guid DIPROP_JOYSTICKID => ref unchecked(*(Guid*)(15));

    [NativeTypeName("#define DIPROP_GETPORTDISPLAYNAME MAKEDIPROP(16)")]
    public static ref readonly Guid DIPROP_GETPORTDISPLAYNAME => ref unchecked(*(Guid*)(16));

    [NativeTypeName("#define DIPROP_PHYSICALRANGE MAKEDIPROP(18)")]
    public static ref readonly Guid DIPROP_PHYSICALRANGE => ref unchecked(*(Guid*)(18));

    [NativeTypeName("#define DIPROP_LOGICALRANGE MAKEDIPROP(19)")]
    public static ref readonly Guid DIPROP_LOGICALRANGE => ref unchecked(*(Guid*)(19));

    [NativeTypeName("#define DIPROP_KEYNAME MAKEDIPROP(20)")]
    public static ref readonly Guid DIPROP_KEYNAME => ref unchecked(*(Guid*)(20));

    [NativeTypeName("#define DIPROP_CPOINTS MAKEDIPROP(21)")]
    public static ref readonly Guid DIPROP_CPOINTS => ref unchecked(*(Guid*)(21));

    [NativeTypeName("#define DIPROP_APPDATA MAKEDIPROP(22)")]
    public static ref readonly Guid DIPROP_APPDATA => ref unchecked(*(Guid*)(22));

    [NativeTypeName("#define DIPROP_SCANCODE MAKEDIPROP(23)")]
    public static ref readonly Guid DIPROP_SCANCODE => ref unchecked(*(Guid*)(23));

    [NativeTypeName("#define DIPROP_VIDPID MAKEDIPROP(24)")]
    public static ref readonly Guid DIPROP_VIDPID => ref unchecked(*(Guid*)(24));

    [NativeTypeName("#define DIPROP_USERNAME MAKEDIPROP(25)")]
    public static ref readonly Guid DIPROP_USERNAME => ref unchecked(*(Guid*)(25));

    [NativeTypeName("#define DIPROP_TYPENAME MAKEDIPROP(26)")]
    public static ref readonly Guid DIPROP_TYPENAME => ref unchecked(*(Guid*)(26));
}