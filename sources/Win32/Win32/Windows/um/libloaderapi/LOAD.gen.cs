// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class LOAD
{
    [NativeTypeName("#define LOAD_LIBRARY_AS_DATAFILE 0x00000002")]
    public const int LOAD_LIBRARY_AS_DATAFILE = 0x00000002;

    [NativeTypeName("#define LOAD_WITH_ALTERED_SEARCH_PATH 0x00000008")]
    public const int LOAD_WITH_ALTERED_SEARCH_PATH = 0x00000008;

    [NativeTypeName("#define LOAD_IGNORE_CODE_AUTHZ_LEVEL 0x00000010")]
    public const int LOAD_IGNORE_CODE_AUTHZ_LEVEL = 0x00000010;

    [NativeTypeName("#define LOAD_LIBRARY_AS_IMAGE_RESOURCE 0x00000020")]
    public const int LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x00000020;

    [NativeTypeName("#define LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE 0x00000040")]
    public const int LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 0x00000040;

    [NativeTypeName("#define LOAD_LIBRARY_REQUIRE_SIGNED_TARGET 0x00000080")]
    public const int LOAD_LIBRARY_REQUIRE_SIGNED_TARGET = 0x00000080;

    [NativeTypeName("#define LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR 0x00000100")]
    public const int LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR = 0x00000100;

    [NativeTypeName("#define LOAD_LIBRARY_SEARCH_APPLICATION_DIR 0x00000200")]
    public const int LOAD_LIBRARY_SEARCH_APPLICATION_DIR = 0x00000200;

    [NativeTypeName("#define LOAD_LIBRARY_SEARCH_USER_DIRS 0x00000400")]
    public const int LOAD_LIBRARY_SEARCH_USER_DIRS = 0x00000400;

    [NativeTypeName("#define LOAD_LIBRARY_SEARCH_SYSTEM32 0x00000800")]
    public const int LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800;

    [NativeTypeName("#define LOAD_LIBRARY_SEARCH_DEFAULT_DIRS 0x00001000")]
    public const int LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 0x00001000;

    [NativeTypeName("#define LOAD_LIBRARY_SAFE_CURRENT_DIRS 0x00002000")]
    public const int LOAD_LIBRARY_SAFE_CURRENT_DIRS = 0x00002000;

    [NativeTypeName("#define LOAD_LIBRARY_SEARCH_SYSTEM32_NO_FORWARDER 0x00004000")]
    public const int LOAD_LIBRARY_SEARCH_SYSTEM32_NO_FORWARDER = 0x00004000;

    [NativeTypeName("#define LOAD_LIBRARY_OS_INTEGRITY_CONTINUITY 0x00008000")]
    public const int LOAD_LIBRARY_OS_INTEGRITY_CONTINUITY = 0x00008000;
}
