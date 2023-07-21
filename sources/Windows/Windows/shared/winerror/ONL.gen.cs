// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class ONL
{
    [NativeTypeName("#define ONL_E_INVALID_AUTHENTICATION_TARGET _HRESULT_TYPEDEF_(0x80860001L)")]
    public const int ONL_E_INVALID_AUTHENTICATION_TARGET = unchecked((int)(0x80860001));

    [NativeTypeName("#define ONL_E_ACCESS_DENIED_BY_TOU _HRESULT_TYPEDEF_(0x80860002L)")]
    public const int ONL_E_ACCESS_DENIED_BY_TOU = unchecked((int)(0x80860002));

    [NativeTypeName("#define ONL_E_INVALID_APPLICATION _HRESULT_TYPEDEF_(0x80860003L)")]
    public const int ONL_E_INVALID_APPLICATION = unchecked((int)(0x80860003));

    [NativeTypeName("#define ONL_E_PASSWORD_UPDATE_REQUIRED _HRESULT_TYPEDEF_(0x80860004L)")]
    public const int ONL_E_PASSWORD_UPDATE_REQUIRED = unchecked((int)(0x80860004));

    [NativeTypeName("#define ONL_E_ACCOUNT_UPDATE_REQUIRED _HRESULT_TYPEDEF_(0x80860005L)")]
    public const int ONL_E_ACCOUNT_UPDATE_REQUIRED = unchecked((int)(0x80860005));

    [NativeTypeName("#define ONL_E_FORCESIGNIN _HRESULT_TYPEDEF_(0x80860006L)")]
    public const int ONL_E_FORCESIGNIN = unchecked((int)(0x80860006));

    [NativeTypeName("#define ONL_E_ACCOUNT_LOCKED _HRESULT_TYPEDEF_(0x80860007L)")]
    public const int ONL_E_ACCOUNT_LOCKED = unchecked((int)(0x80860007));

    [NativeTypeName("#define ONL_E_PARENTAL_CONSENT_REQUIRED _HRESULT_TYPEDEF_(0x80860008L)")]
    public const int ONL_E_PARENTAL_CONSENT_REQUIRED = unchecked((int)(0x80860008));

    [NativeTypeName("#define ONL_E_EMAIL_VERIFICATION_REQUIRED _HRESULT_TYPEDEF_(0x80860009L)")]
    public const int ONL_E_EMAIL_VERIFICATION_REQUIRED = unchecked((int)(0x80860009));

    [NativeTypeName("#define ONL_E_ACCOUNT_SUSPENDED_COMPROIMISE _HRESULT_TYPEDEF_(0x8086000AL)")]
    public const int ONL_E_ACCOUNT_SUSPENDED_COMPROIMISE = unchecked((int)(0x8086000A));

    [NativeTypeName("#define ONL_E_ACCOUNT_SUSPENDED_ABUSE _HRESULT_TYPEDEF_(0x8086000BL)")]
    public const int ONL_E_ACCOUNT_SUSPENDED_ABUSE = unchecked((int)(0x8086000B));

    [NativeTypeName("#define ONL_E_ACTION_REQUIRED _HRESULT_TYPEDEF_(0x8086000CL)")]
    public const int ONL_E_ACTION_REQUIRED = unchecked((int)(0x8086000C));

    [NativeTypeName("#define ONL_CONNECTION_COUNT_LIMIT _HRESULT_TYPEDEF_(0x8086000DL)")]
    public const int ONL_CONNECTION_COUNT_LIMIT = unchecked((int)(0x8086000D));

    [NativeTypeName("#define ONL_E_CONNECTED_ACCOUNT_CAN_NOT_SIGNOUT _HRESULT_TYPEDEF_(0x8086000EL)")]
    public const int ONL_E_CONNECTED_ACCOUNT_CAN_NOT_SIGNOUT = unchecked((int)(0x8086000E));

    [NativeTypeName("#define ONL_E_USER_AUTHENTICATION_REQUIRED _HRESULT_TYPEDEF_(0x8086000FL)")]
    public const int ONL_E_USER_AUTHENTICATION_REQUIRED = unchecked((int)(0x8086000F));

    [NativeTypeName("#define ONL_E_REQUEST_THROTTLED _HRESULT_TYPEDEF_(0x80860010L)")]
    public const int ONL_E_REQUEST_THROTTLED = unchecked((int)(0x80860010));
}
