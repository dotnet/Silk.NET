// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class PER_USER
{
    [NativeTypeName("#define PER_USER_POLICY_UNCHANGED (0x00)")]
    public const int PER_USER_POLICY_UNCHANGED = (0x00);
    [NativeTypeName("#define PER_USER_AUDIT_SUCCESS_INCLUDE (0x01)")]
    public const int PER_USER_AUDIT_SUCCESS_INCLUDE = (0x01);
    [NativeTypeName("#define PER_USER_AUDIT_SUCCESS_EXCLUDE (0x02)")]
    public const int PER_USER_AUDIT_SUCCESS_EXCLUDE = (0x02);
    [NativeTypeName("#define PER_USER_AUDIT_FAILURE_INCLUDE (0x04)")]
    public const int PER_USER_AUDIT_FAILURE_INCLUDE = (0x04);
    [NativeTypeName("#define PER_USER_AUDIT_FAILURE_EXCLUDE (0x08)")]
    public const int PER_USER_AUDIT_FAILURE_EXCLUDE = (0x08);
    [NativeTypeName("#define PER_USER_AUDIT_NONE (0x10)")]
    public const int PER_USER_AUDIT_NONE = (0x10);
}