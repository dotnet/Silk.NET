// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    [NativeTypeName("#define AccFree LocalFree")]
    public static delegate*<HLOCAL, HLOCAL> AccFree => &LocalFree;

    [NativeTypeName("#define NO_INHERITANCE 0x0")]
    public const int NO_INHERITANCE = 0x0;
    [NativeTypeName("#define SUB_OBJECTS_ONLY_INHERIT 0x1")]
    public const int SUB_OBJECTS_ONLY_INHERIT = 0x1;
    [NativeTypeName("#define SUB_CONTAINERS_ONLY_INHERIT 0x2")]
    public const int SUB_CONTAINERS_ONLY_INHERIT = 0x2;
    [NativeTypeName("#define SUB_CONTAINERS_AND_OBJECTS_INHERIT 0x3")]
    public const int SUB_CONTAINERS_AND_OBJECTS_INHERIT = 0x3;
    [NativeTypeName("#define INHERIT_NO_PROPAGATE 0x4")]
    public const int INHERIT_NO_PROPAGATE = 0x4;
    [NativeTypeName("#define INHERIT_ONLY 0x8")]
    public const int INHERIT_ONLY = 0x8;
    [NativeTypeName("#define INHERITED_ACCESS_ENTRY 0x10")]
    public const int INHERITED_ACCESS_ENTRY = 0x10;
    [NativeTypeName("#define INHERITED_PARENT 0x10000000")]
    public const int INHERITED_PARENT = 0x10000000;
    [NativeTypeName("#define INHERITED_GRANDPARENT 0x20000000")]
    public const int INHERITED_GRANDPARENT = 0x20000000;
    [NativeTypeName("#define ACCCTRL_DEFAULT_PROVIDERA \"Windows NT Access Provider\"")]
    public static ReadOnlySpan<byte> ACCCTRL_DEFAULT_PROVIDERA => "Windows NT Access Provider"u8;

    [NativeTypeName("#define ACCCTRL_DEFAULT_PROVIDERW L\"Windows NT Access Provider\"")]
    public const string ACCCTRL_DEFAULT_PROVIDERW = "Windows NT Access Provider";
    [NativeTypeName("#define ACCCTRL_DEFAULT_PROVIDER ACCCTRL_DEFAULT_PROVIDERW")]
    public const string ACCCTRL_DEFAULT_PROVIDER = "Windows NT Access Provider";
}