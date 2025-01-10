// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class BSF
{
    [NativeTypeName("#define BSF_QUERY 0x00000001")]
    public const int BSF_QUERY = 0x00000001;

    [NativeTypeName("#define BSF_IGNORECURRENTTASK 0x00000002")]
    public const int BSF_IGNORECURRENTTASK = 0x00000002;

    [NativeTypeName("#define BSF_FLUSHDISK 0x00000004")]
    public const int BSF_FLUSHDISK = 0x00000004;

    [NativeTypeName("#define BSF_NOHANG 0x00000008")]
    public const int BSF_NOHANG = 0x00000008;

    [NativeTypeName("#define BSF_POSTMESSAGE 0x00000010")]
    public const int BSF_POSTMESSAGE = 0x00000010;

    [NativeTypeName("#define BSF_FORCEIFHUNG 0x00000020")]
    public const int BSF_FORCEIFHUNG = 0x00000020;

    [NativeTypeName("#define BSF_NOTIMEOUTIFNOTHUNG 0x00000040")]
    public const int BSF_NOTIMEOUTIFNOTHUNG = 0x00000040;

    [NativeTypeName("#define BSF_ALLOWSFW 0x00000080")]
    public const int BSF_ALLOWSFW = 0x00000080;

    [NativeTypeName("#define BSF_SENDNOTIFYMESSAGE 0x00000100")]
    public const int BSF_SENDNOTIFYMESSAGE = 0x00000100;

    [NativeTypeName("#define BSF_RETURNHDESK 0x00000200")]
    public const int BSF_RETURNHDESK = 0x00000200;

    [NativeTypeName("#define BSF_LUID 0x00000400")]
    public const int BSF_LUID = 0x00000400;
}
