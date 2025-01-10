// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class HCBT
{
    [NativeTypeName("#define HCBT_MOVESIZE 0")]
    public const int HCBT_MOVESIZE = 0;

    [NativeTypeName("#define HCBT_MINMAX 1")]
    public const int HCBT_MINMAX = 1;

    [NativeTypeName("#define HCBT_QS 2")]
    public const int HCBT_QS = 2;

    [NativeTypeName("#define HCBT_CREATEWND 3")]
    public const int HCBT_CREATEWND = 3;

    [NativeTypeName("#define HCBT_DESTROYWND 4")]
    public const int HCBT_DESTROYWND = 4;

    [NativeTypeName("#define HCBT_ACTIVATE 5")]
    public const int HCBT_ACTIVATE = 5;

    [NativeTypeName("#define HCBT_CLICKSKIPPED 6")]
    public const int HCBT_CLICKSKIPPED = 6;

    [NativeTypeName("#define HCBT_KEYSKIPPED 7")]
    public const int HCBT_KEYSKIPPED = 7;

    [NativeTypeName("#define HCBT_SYSCOMMAND 8")]
    public const int HCBT_SYSCOMMAND = 8;

    [NativeTypeName("#define HCBT_SETFOCUS 9")]
    public const int HCBT_SETFOCUS = 9;
}
