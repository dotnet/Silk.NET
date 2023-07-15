// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class EAS
{
    [NativeTypeName("#define EAS_E_POLICY_NOT_MANAGED_BY_OS _HRESULT_TYPEDEF_(0x80550001L)")]
    public const int EAS_E_POLICY_NOT_MANAGED_BY_OS = unchecked((int)(0x80550001));
    [NativeTypeName("#define EAS_E_POLICY_COMPLIANT_WITH_ACTIONS _HRESULT_TYPEDEF_(0x80550002L)")]
    public const int EAS_E_POLICY_COMPLIANT_WITH_ACTIONS = unchecked((int)(0x80550002));
    [NativeTypeName("#define EAS_E_REQUESTED_POLICY_NOT_ENFORCEABLE _HRESULT_TYPEDEF_(0x80550003L)")]
    public const int EAS_E_REQUESTED_POLICY_NOT_ENFORCEABLE = unchecked((int)(0x80550003));
    [NativeTypeName("#define EAS_E_CURRENT_USER_HAS_BLANK_PASSWORD _HRESULT_TYPEDEF_(0x80550004L)")]
    public const int EAS_E_CURRENT_USER_HAS_BLANK_PASSWORD = unchecked((int)(0x80550004));
    [NativeTypeName("#define EAS_E_REQUESTED_POLICY_PASSWORD_EXPIRATION_INCOMPATIBLE _HRESULT_TYPEDEF_(0x80550005L)")]
    public const int EAS_E_REQUESTED_POLICY_PASSWORD_EXPIRATION_INCOMPATIBLE = unchecked((int)(0x80550005));
    [NativeTypeName("#define EAS_E_USER_CANNOT_CHANGE_PASSWORD _HRESULT_TYPEDEF_(0x80550006L)")]
    public const int EAS_E_USER_CANNOT_CHANGE_PASSWORD = unchecked((int)(0x80550006));
    [NativeTypeName("#define EAS_E_ADMINS_HAVE_BLANK_PASSWORD _HRESULT_TYPEDEF_(0x80550007L)")]
    public const int EAS_E_ADMINS_HAVE_BLANK_PASSWORD = unchecked((int)(0x80550007));
    [NativeTypeName("#define EAS_E_ADMINS_CANNOT_CHANGE_PASSWORD _HRESULT_TYPEDEF_(0x80550008L)")]
    public const int EAS_E_ADMINS_CANNOT_CHANGE_PASSWORD = unchecked((int)(0x80550008));
    [NativeTypeName("#define EAS_E_LOCAL_CONTROLLED_USERS_CANNOT_CHANGE_PASSWORD _HRESULT_TYPEDEF_(0x80550009L)")]
    public const int EAS_E_LOCAL_CONTROLLED_USERS_CANNOT_CHANGE_PASSWORD = unchecked((int)(0x80550009));
    [NativeTypeName("#define EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CONNECTED_ADMINS _HRESULT_TYPEDEF_(0x8055000AL)")]
    public const int EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CONNECTED_ADMINS = unchecked((int)(0x8055000A));
    [NativeTypeName("#define EAS_E_CONNECTED_ADMINS_NEED_TO_CHANGE_PASSWORD _HRESULT_TYPEDEF_(0x8055000BL)")]
    public const int EAS_E_CONNECTED_ADMINS_NEED_TO_CHANGE_PASSWORD = unchecked((int)(0x8055000B));
    [NativeTypeName("#define EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CURRENT_CONNECTED_USER _HRESULT_TYPEDEF_(0x8055000CL)")]
    public const int EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CURRENT_CONNECTED_USER = unchecked((int)(0x8055000C));
    [NativeTypeName("#define EAS_E_CURRENT_CONNECTED_USER_NEED_TO_CHANGE_PASSWORD _HRESULT_TYPEDEF_(0x8055000DL)")]
    public const int EAS_E_CURRENT_CONNECTED_USER_NEED_TO_CHANGE_PASSWORD = unchecked((int)(0x8055000D));
}