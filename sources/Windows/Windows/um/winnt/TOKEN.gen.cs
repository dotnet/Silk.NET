// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static unsafe partial class TOKEN
{
    [NativeTypeName("#define TOKEN_ASSIGN_PRIMARY (0x0001)")]
    public const int TOKEN_ASSIGN_PRIMARY = (0x0001);
    [NativeTypeName("#define TOKEN_DUPLICATE (0x0002)")]
    public const int TOKEN_DUPLICATE = (0x0002);
    [NativeTypeName("#define TOKEN_IMPERSONATE (0x0004)")]
    public const int TOKEN_IMPERSONATE = (0x0004);
    [NativeTypeName("#define TOKEN_QUERY (0x0008)")]
    public const int TOKEN_QUERY = (0x0008);
    [NativeTypeName("#define TOKEN_QUERY_SOURCE (0x0010)")]
    public const int TOKEN_QUERY_SOURCE = (0x0010);
    [NativeTypeName("#define TOKEN_ADJUST_PRIVILEGES (0x0020)")]
    public const int TOKEN_ADJUST_PRIVILEGES = (0x0020);
    [NativeTypeName("#define TOKEN_ADJUST_GROUPS (0x0040)")]
    public const int TOKEN_ADJUST_GROUPS = (0x0040);
    [NativeTypeName("#define TOKEN_ADJUST_DEFAULT (0x0080)")]
    public const int TOKEN_ADJUST_DEFAULT = (0x0080);
    [NativeTypeName("#define TOKEN_ADJUST_SESSIONID (0x0100)")]
    public const int TOKEN_ADJUST_SESSIONID = (0x0100);
    [NativeTypeName("#define TOKEN_ALL_ACCESS_P (STANDARD_RIGHTS_REQUIRED  |\\\r\n                          TOKEN_ASSIGN_PRIMARY      |\\\r\n                          TOKEN_DUPLICATE           |\\\r\n                          TOKEN_IMPERSONATE         |\\\r\n                          TOKEN_QUERY               |\\\r\n                          TOKEN_QUERY_SOURCE        |\\\r\n                          TOKEN_ADJUST_PRIVILEGES   |\\\r\n                          TOKEN_ADJUST_GROUPS       |\\\r\n                          TOKEN_ADJUST_DEFAULT )")]
    public const int TOKEN_ALL_ACCESS_P = ((0x000F0000) | (0x0001) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020) | (0x0040) | (0x0080));
    [NativeTypeName("#define TOKEN_ALL_ACCESS (TOKEN_ALL_ACCESS_P |\\\r\n                          TOKEN_ADJUST_SESSIONID )")]
    public const int TOKEN_ALL_ACCESS = (((0x000F0000) | (0x0001) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020) | (0x0040) | (0x0080)) | (0x0100));
    [NativeTypeName("#define TOKEN_READ (STANDARD_RIGHTS_READ      |\\\r\n                          TOKEN_QUERY)")]
    public const int TOKEN_READ = (((0x00020000)) | (0x0008));
    [NativeTypeName("#define TOKEN_WRITE (STANDARD_RIGHTS_WRITE     |\\\r\n                          TOKEN_ADJUST_PRIVILEGES   |\\\r\n                          TOKEN_ADJUST_GROUPS       |\\\r\n                          TOKEN_ADJUST_DEFAULT)")]
    public const int TOKEN_WRITE = (((0x00020000)) | (0x0020) | (0x0040) | (0x0080));
    [NativeTypeName("#define TOKEN_EXECUTE (STANDARD_RIGHTS_EXECUTE)")]
    public const int TOKEN_EXECUTE = (((0x00020000)));
    [NativeTypeName("#define TOKEN_TRUST_CONSTRAINT_MASK (STANDARD_RIGHTS_READ  | \\\r\n                                       TOKEN_QUERY  |\\\r\n                                       TOKEN_QUERY_SOURCE )")]
    public const int TOKEN_TRUST_CONSTRAINT_MASK = (((0x00020000)) | (0x0008) | (0x0010));
    [NativeTypeName("#define TOKEN_TRUST_ALLOWED_MASK (TOKEN_TRUST_CONSTRAINT_MASK |\\\r\n                                    TOKEN_DUPLICATE              |\\\r\n                                    TOKEN_IMPERSONATE)")]
    public const int TOKEN_TRUST_ALLOWED_MASK = ((((0x00020000)) | (0x0008) | (0x0010)) | (0x0002) | (0x0004));
    [NativeTypeName("#define TOKEN_ACCESS_PSEUDO_HANDLE_WIN8 (TOKEN_QUERY | TOKEN_QUERY_SOURCE)")]
    public const int TOKEN_ACCESS_PSEUDO_HANDLE_WIN8 = ((0x0008) | (0x0010));
    [NativeTypeName("#define TOKEN_ACCESS_PSEUDO_HANDLE TOKEN_ACCESS_PSEUDO_HANDLE_WIN8")]
    public const int TOKEN_ACCESS_PSEUDO_HANDLE = ((0x0008) | (0x0010));
    [NativeTypeName("#define TOKEN_USER_MAX_SIZE (sizeof(TOKEN_USER) + SECURITY_MAX_SID_SIZE)")]
    public static uint TOKEN_USER_MAX_SIZE => unchecked((uint)(sizeof(TOKEN_USER)) + (12 - 4 + ((15) * 4)));

    [NativeTypeName("#define TOKEN_OWNER_MAX_SIZE (sizeof(TOKEN_OWNER) + SECURITY_MAX_SID_SIZE)")]
    public static uint TOKEN_OWNER_MAX_SIZE => unchecked((uint)(sizeof(TOKEN_OWNER)) + (12 - 4 + ((15) * 4)));

    [NativeTypeName("#define TOKEN_MANDATORY_POLICY_OFF 0x0")]
    public const int TOKEN_MANDATORY_POLICY_OFF = 0x0;
    [NativeTypeName("#define TOKEN_MANDATORY_POLICY_NO_WRITE_UP 0x1")]
    public const int TOKEN_MANDATORY_POLICY_NO_WRITE_UP = 0x1;
    [NativeTypeName("#define TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN 0x2")]
    public const int TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN = 0x2;
    [NativeTypeName("#define TOKEN_MANDATORY_POLICY_VALID_MASK (TOKEN_MANDATORY_POLICY_NO_WRITE_UP | \\\r\n                                                TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN)")]
    public const int TOKEN_MANDATORY_POLICY_VALID_MASK = (0x1 | 0x2);
    [NativeTypeName("#define TOKEN_INTEGRITY_LEVEL_MAX_SIZE ((((DWORD)(sizeof(TOKEN_MANDATORY_LABEL)) + sizeof(PVOID) - 1) & ~(sizeof(PVOID)-1)) + SECURITY_MAX_SID_SIZE)")]
    public static uint TOKEN_INTEGRITY_LEVEL_MAX_SIZE => unchecked((((uint)((uint)(sizeof(TOKEN_MANDATORY_LABEL))) + (uint)(sizeof(void*)) - 1) & ~((uint)(sizeof(void*)) - 1)) + (12 - 4 + ((15) * 4)));

    [NativeTypeName("#define TOKEN_SOURCE_LENGTH 8")]
    public const int TOKEN_SOURCE_LENGTH = 8;
    [NativeTypeName("#define TOKEN_APPCONTAINER_SID_MAX_SIZE (sizeof(TOKEN_APPCONTAINER_INFORMATION) + SECURITY_MAX_SID_SIZE)")]
    public static uint TOKEN_APPCONTAINER_SID_MAX_SIZE => unchecked((uint)(sizeof(TOKEN_APPCONTAINER_INFORMATION)) + (12 - 4 + ((15) * 4)));
}