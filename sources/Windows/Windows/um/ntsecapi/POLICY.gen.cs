// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class POLICY
{
    [NativeTypeName("#define POLICY_AUDIT_EVENT_UNCHANGED (0x00000000L)")]
    public const int POLICY_AUDIT_EVENT_UNCHANGED = (0x00000000);

    [NativeTypeName("#define POLICY_AUDIT_EVENT_SUCCESS (0x00000001L)")]
    public const int POLICY_AUDIT_EVENT_SUCCESS = (0x00000001);

    [NativeTypeName("#define POLICY_AUDIT_EVENT_FAILURE (0x00000002L)")]
    public const int POLICY_AUDIT_EVENT_FAILURE = (0x00000002);

    [NativeTypeName("#define POLICY_AUDIT_EVENT_NONE (0x00000004L)")]
    public const int POLICY_AUDIT_EVENT_NONE = (0x00000004);

    [NativeTypeName("#define POLICY_AUDIT_EVENT_MASK (POLICY_AUDIT_EVENT_SUCCESS | \\\r\n     POLICY_AUDIT_EVENT_FAILURE | \\\r\n     POLICY_AUDIT_EVENT_UNCHANGED | \\\r\n     POLICY_AUDIT_EVENT_NONE)")]
    public const int POLICY_AUDIT_EVENT_MASK = ((0x00000001) | (0x00000002) | (0x00000000) | (0x00000004));

    [NativeTypeName("#define POLICY_VIEW_LOCAL_INFORMATION 0x00000001L")]
    public const int POLICY_VIEW_LOCAL_INFORMATION = 0x00000001;

    [NativeTypeName("#define POLICY_VIEW_AUDIT_INFORMATION 0x00000002L")]
    public const int POLICY_VIEW_AUDIT_INFORMATION = 0x00000002;

    [NativeTypeName("#define POLICY_GET_PRIVATE_INFORMATION 0x00000004L")]
    public const int POLICY_GET_PRIVATE_INFORMATION = 0x00000004;

    [NativeTypeName("#define POLICY_TRUST_ADMIN 0x00000008L")]
    public const int POLICY_TRUST_ADMIN = 0x00000008;

    [NativeTypeName("#define POLICY_CREATE_ACCOUNT 0x00000010L")]
    public const int POLICY_CREATE_ACCOUNT = 0x00000010;

    [NativeTypeName("#define POLICY_CREATE_SECRET 0x00000020L")]
    public const int POLICY_CREATE_SECRET = 0x00000020;

    [NativeTypeName("#define POLICY_CREATE_PRIVILEGE 0x00000040L")]
    public const int POLICY_CREATE_PRIVILEGE = 0x00000040;

    [NativeTypeName("#define POLICY_SET_DEFAULT_QUOTA_LIMITS 0x00000080L")]
    public const int POLICY_SET_DEFAULT_QUOTA_LIMITS = 0x00000080;

    [NativeTypeName("#define POLICY_SET_AUDIT_REQUIREMENTS 0x00000100L")]
    public const int POLICY_SET_AUDIT_REQUIREMENTS = 0x00000100;

    [NativeTypeName("#define POLICY_AUDIT_LOG_ADMIN 0x00000200L")]
    public const int POLICY_AUDIT_LOG_ADMIN = 0x00000200;

    [NativeTypeName("#define POLICY_SERVER_ADMIN 0x00000400L")]
    public const int POLICY_SERVER_ADMIN = 0x00000400;

    [NativeTypeName("#define POLICY_LOOKUP_NAMES 0x00000800L")]
    public const int POLICY_LOOKUP_NAMES = 0x00000800;

    [NativeTypeName("#define POLICY_NOTIFICATION 0x00001000L")]
    public const int POLICY_NOTIFICATION = 0x00001000;

    [NativeTypeName("#define POLICY_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED         |\\\r\n                               POLICY_VIEW_LOCAL_INFORMATION    |\\\r\n                               POLICY_VIEW_AUDIT_INFORMATION    |\\\r\n                               POLICY_GET_PRIVATE_INFORMATION   |\\\r\n                               POLICY_TRUST_ADMIN               |\\\r\n                               POLICY_CREATE_ACCOUNT            |\\\r\n                               POLICY_CREATE_SECRET             |\\\r\n                               POLICY_CREATE_PRIVILEGE          |\\\r\n                               POLICY_SET_DEFAULT_QUOTA_LIMITS  |\\\r\n                               POLICY_SET_AUDIT_REQUIREMENTS    |\\\r\n                               POLICY_AUDIT_LOG_ADMIN           |\\\r\n                               POLICY_SERVER_ADMIN              |\\\r\n                               POLICY_LOOKUP_NAMES)")]
    public const int POLICY_ALL_ACCESS = ((0x000F0000) | 0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000040 | 0x00000080 | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800);

    [NativeTypeName("#define POLICY_READ (STANDARD_RIGHTS_READ             |\\\r\n                               POLICY_VIEW_AUDIT_INFORMATION    |\\\r\n                               POLICY_GET_PRIVATE_INFORMATION)")]
    public const int POLICY_READ = (((0x00020000)) | 0x00000002 | 0x00000004);

    [NativeTypeName("#define POLICY_WRITE (STANDARD_RIGHTS_WRITE            |\\\r\n                               POLICY_TRUST_ADMIN               |\\\r\n                               POLICY_CREATE_ACCOUNT            |\\\r\n                               POLICY_CREATE_SECRET             |\\\r\n                               POLICY_CREATE_PRIVILEGE          |\\\r\n                               POLICY_SET_DEFAULT_QUOTA_LIMITS  |\\\r\n                               POLICY_SET_AUDIT_REQUIREMENTS    |\\\r\n                               POLICY_AUDIT_LOG_ADMIN           |\\\r\n                               POLICY_SERVER_ADMIN)")]
    public const int POLICY_WRITE = (((0x00020000)) | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000040 | 0x00000080 | 0x00000100 | 0x00000200 | 0x00000400);

    [NativeTypeName("#define POLICY_EXECUTE (STANDARD_RIGHTS_EXECUTE          |\\\r\n                               POLICY_VIEW_LOCAL_INFORMATION    |\\\r\n                               POLICY_LOOKUP_NAMES)")]
    public const int POLICY_EXECUTE = (((0x00020000)) | 0x00000001 | 0x00000800);

    [NativeTypeName("#define POLICY_KERBEROS_VALIDATE_CLIENT 0x00000080")]
    public const int POLICY_KERBEROS_VALIDATE_CLIENT = 0x00000080;
}
