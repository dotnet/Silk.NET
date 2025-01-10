// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class HELP
{
    [NativeTypeName("#define HELP_CONTEXT 0x0001L")]
    public const int HELP_CONTEXT = 0x0001;

    [NativeTypeName("#define HELP_QUIT 0x0002L")]
    public const int HELP_QUIT = 0x0002;

    [NativeTypeName("#define HELP_INDEX 0x0003L")]
    public const int HELP_INDEX = 0x0003;

    [NativeTypeName("#define HELP_CONTENTS 0x0003L")]
    public const int HELP_CONTENTS = 0x0003;

    [NativeTypeName("#define HELP_HELPONHELP 0x0004L")]
    public const int HELP_HELPONHELP = 0x0004;

    [NativeTypeName("#define HELP_SETINDEX 0x0005L")]
    public const int HELP_SETINDEX = 0x0005;

    [NativeTypeName("#define HELP_SETCONTENTS 0x0005L")]
    public const int HELP_SETCONTENTS = 0x0005;

    [NativeTypeName("#define HELP_CONTEXTPOPUP 0x0008L")]
    public const int HELP_CONTEXTPOPUP = 0x0008;

    [NativeTypeName("#define HELP_FORCEFILE 0x0009L")]
    public const int HELP_FORCEFILE = 0x0009;

    [NativeTypeName("#define HELP_KEY 0x0101L")]
    public const int HELP_KEY = 0x0101;

    [NativeTypeName("#define HELP_COMMAND 0x0102L")]
    public const int HELP_COMMAND = 0x0102;

    [NativeTypeName("#define HELP_PARTIALKEY 0x0105L")]
    public const int HELP_PARTIALKEY = 0x0105;

    [NativeTypeName("#define HELP_MULTIKEY 0x0201L")]
    public const int HELP_MULTIKEY = 0x0201;

    [NativeTypeName("#define HELP_SETWINPOS 0x0203L")]
    public const int HELP_SETWINPOS = 0x0203;

    [NativeTypeName("#define HELP_CONTEXTMENU 0x000a")]
    public const int HELP_CONTEXTMENU = 0x000a;

    [NativeTypeName("#define HELP_FINDER 0x000b")]
    public const int HELP_FINDER = 0x000b;

    [NativeTypeName("#define HELP_WM_HELP 0x000c")]
    public const int HELP_WM_HELP = 0x000c;

    [NativeTypeName("#define HELP_SETPOPUP_POS 0x000d")]
    public const int HELP_SETPOPUP_POS = 0x000d;

    [NativeTypeName("#define HELP_TCARD 0x8000")]
    public const int HELP_TCARD = 0x8000;

    [NativeTypeName("#define HELP_TCARD_DATA 0x0010")]
    public const int HELP_TCARD_DATA = 0x0010;

    [NativeTypeName("#define HELP_TCARD_OTHER_CALLER 0x0011")]
    public const int HELP_TCARD_OTHER_CALLER = 0x0011;
}
