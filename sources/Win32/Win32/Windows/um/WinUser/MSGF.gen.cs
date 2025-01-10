// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MSGF
{
    [NativeTypeName("#define MSGF_DIALOGBOX 0")]
    public const int MSGF_DIALOGBOX = 0;

    [NativeTypeName("#define MSGF_MESSAGEBOX 1")]
    public const int MSGF_MESSAGEBOX = 1;

    [NativeTypeName("#define MSGF_MENU 2")]
    public const int MSGF_MENU = 2;

    [NativeTypeName("#define MSGF_SCROLLBAR 5")]
    public const int MSGF_SCROLLBAR = 5;

    [NativeTypeName("#define MSGF_NEXTWINDOW 6")]
    public const int MSGF_NEXTWINDOW = 6;

    [NativeTypeName("#define MSGF_MAX 8")]
    public const int MSGF_MAX = 8;

    [NativeTypeName("#define MSGF_USER 4096")]
    public const int MSGF_USER = 4096;
}
