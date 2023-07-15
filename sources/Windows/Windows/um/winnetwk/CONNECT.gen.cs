// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class CONNECT
{
    [NativeTypeName("#define CONNECT_UPDATE_PROFILE 0x00000001")]
    public const int CONNECT_UPDATE_PROFILE = 0x00000001;
    [NativeTypeName("#define CONNECT_UPDATE_RECENT 0x00000002")]
    public const int CONNECT_UPDATE_RECENT = 0x00000002;
    [NativeTypeName("#define CONNECT_TEMPORARY 0x00000004")]
    public const int CONNECT_TEMPORARY = 0x00000004;
    [NativeTypeName("#define CONNECT_INTERACTIVE 0x00000008")]
    public const int CONNECT_INTERACTIVE = 0x00000008;
    [NativeTypeName("#define CONNECT_PROMPT 0x00000010")]
    public const int CONNECT_PROMPT = 0x00000010;
    [NativeTypeName("#define CONNECT_NEED_DRIVE 0x00000020")]
    public const int CONNECT_NEED_DRIVE = 0x00000020;
    [NativeTypeName("#define CONNECT_REFCOUNT 0x00000040")]
    public const int CONNECT_REFCOUNT = 0x00000040;
    [NativeTypeName("#define CONNECT_REDIRECT 0x00000080")]
    public const int CONNECT_REDIRECT = 0x00000080;
    [NativeTypeName("#define CONNECT_LOCALDRIVE 0x00000100")]
    public const int CONNECT_LOCALDRIVE = 0x00000100;
    [NativeTypeName("#define CONNECT_CURRENT_MEDIA 0x00000200")]
    public const int CONNECT_CURRENT_MEDIA = 0x00000200;
    [NativeTypeName("#define CONNECT_DEFERRED 0x00000400")]
    public const int CONNECT_DEFERRED = 0x00000400;
    [NativeTypeName("#define CONNECT_RESERVED 0xFF000000")]
    public const uint CONNECT_RESERVED = 0xFF000000;
    [NativeTypeName("#define CONNECT_COMMANDLINE 0x00000800")]
    public const int CONNECT_COMMANDLINE = 0x00000800;
    [NativeTypeName("#define CONNECT_CMD_SAVECRED 0x00001000")]
    public const int CONNECT_CMD_SAVECRED = 0x00001000;
    [NativeTypeName("#define CONNECT_CRED_RESET 0x00002000")]
    public const int CONNECT_CRED_RESET = 0x00002000;
    [NativeTypeName("#define CONNECT_REQUIRE_INTEGRITY 0x00004000")]
    public const int CONNECT_REQUIRE_INTEGRITY = 0x00004000;
    [NativeTypeName("#define CONNECT_REQUIRE_PRIVACY 0x00008000")]
    public const int CONNECT_REQUIRE_PRIVACY = 0x00008000;
    [NativeTypeName("#define CONNECT_WRITE_THROUGH_SEMANTICS 0x00010000")]
    public const int CONNECT_WRITE_THROUGH_SEMANTICS = 0x00010000;
    [NativeTypeName("#define CONNECT_GLOBAL_MAPPING 0x00040000")]
    public const int CONNECT_GLOBAL_MAPPING = 0x00040000;
}