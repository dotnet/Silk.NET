// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class ABM
{
    [NativeTypeName("#define ABM_NEW 0x00000000")]
    public const int ABM_NEW = 0x00000000;

    [NativeTypeName("#define ABM_REMOVE 0x00000001")]
    public const int ABM_REMOVE = 0x00000001;

    [NativeTypeName("#define ABM_QUERYPOS 0x00000002")]
    public const int ABM_QUERYPOS = 0x00000002;

    [NativeTypeName("#define ABM_SETPOS 0x00000003")]
    public const int ABM_SETPOS = 0x00000003;

    [NativeTypeName("#define ABM_GETSTATE 0x00000004")]
    public const int ABM_GETSTATE = 0x00000004;

    [NativeTypeName("#define ABM_GETTASKBARPOS 0x00000005")]
    public const int ABM_GETTASKBARPOS = 0x00000005;

    [NativeTypeName("#define ABM_ACTIVATE 0x00000006")]
    public const int ABM_ACTIVATE = 0x00000006;

    [NativeTypeName("#define ABM_GETAUTOHIDEBAR 0x00000007")]
    public const int ABM_GETAUTOHIDEBAR = 0x00000007;

    [NativeTypeName("#define ABM_SETAUTOHIDEBAR 0x00000008")]
    public const int ABM_SETAUTOHIDEBAR = 0x00000008;

    [NativeTypeName("#define ABM_WINDOWPOSCHANGED 0x0000009")]
    public const int ABM_WINDOWPOSCHANGED = 0x0000009;

    [NativeTypeName("#define ABM_SETSTATE 0x0000000a")]
    public const int ABM_SETSTATE = 0x0000000a;

    [NativeTypeName("#define ABM_GETAUTOHIDEBAREX 0x0000000b")]
    public const int ABM_GETAUTOHIDEBAREX = 0x0000000b;

    [NativeTypeName("#define ABM_SETAUTOHIDEBAREX 0x0000000c")]
    public const int ABM_SETAUTOHIDEBAREX = 0x0000000c;
}
