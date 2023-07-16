// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class RO
{
    [NativeTypeName("#define RO_E_METADATA_NAME_NOT_FOUND _HRESULT_TYPEDEF_(0x8000000FL)")]
    public const int RO_E_METADATA_NAME_NOT_FOUND = unchecked((int)(0x8000000F));
    [NativeTypeName("#define RO_E_METADATA_NAME_IS_NAMESPACE _HRESULT_TYPEDEF_(0x80000010L)")]
    public const int RO_E_METADATA_NAME_IS_NAMESPACE = unchecked((int)(0x80000010));
    [NativeTypeName("#define RO_E_METADATA_INVALID_TYPE_FORMAT _HRESULT_TYPEDEF_(0x80000011L)")]
    public const int RO_E_METADATA_INVALID_TYPE_FORMAT = unchecked((int)(0x80000011));
    [NativeTypeName("#define RO_E_INVALID_METADATA_FILE _HRESULT_TYPEDEF_(0x80000012L)")]
    public const int RO_E_INVALID_METADATA_FILE = unchecked((int)(0x80000012));
    [NativeTypeName("#define RO_E_CLOSED _HRESULT_TYPEDEF_(0x80000013L)")]
    public const int RO_E_CLOSED = unchecked((int)(0x80000013));
    [NativeTypeName("#define RO_E_EXCLUSIVE_WRITE _HRESULT_TYPEDEF_(0x80000014L)")]
    public const int RO_E_EXCLUSIVE_WRITE = unchecked((int)(0x80000014));
    [NativeTypeName("#define RO_E_CHANGE_NOTIFICATION_IN_PROGRESS _HRESULT_TYPEDEF_(0x80000015L)")]
    public const int RO_E_CHANGE_NOTIFICATION_IN_PROGRESS = unchecked((int)(0x80000015));
    [NativeTypeName("#define RO_E_ERROR_STRING_NOT_FOUND _HRESULT_TYPEDEF_(0x80000016L)")]
    public const int RO_E_ERROR_STRING_NOT_FOUND = unchecked((int)(0x80000016));
    [NativeTypeName("#define RO_E_MUST_BE_AGILE _HRESULT_TYPEDEF_(0x8000001CL)")]
    public const int RO_E_MUST_BE_AGILE = unchecked((int)(0x8000001C));
    [NativeTypeName("#define RO_E_UNSUPPORTED_FROM_MTA _HRESULT_TYPEDEF_(0x8000001DL)")]
    public const int RO_E_UNSUPPORTED_FROM_MTA = unchecked((int)(0x8000001D));
    [NativeTypeName("#define RO_E_COMMITTED _HRESULT_TYPEDEF_(0x8000001EL)")]
    public const int RO_E_COMMITTED = unchecked((int)(0x8000001E));
    [NativeTypeName("#define RO_E_BLOCKED_CROSS_ASTA_CALL _HRESULT_TYPEDEF_(0x8000001FL)")]
    public const int RO_E_BLOCKED_CROSS_ASTA_CALL = unchecked((int)(0x8000001F));
    [NativeTypeName("#define RO_E_CANNOT_ACTIVATE_FULL_TRUST_SERVER _HRESULT_TYPEDEF_(0x80000020L)")]
    public const int RO_E_CANNOT_ACTIVATE_FULL_TRUST_SERVER = unchecked((int)(0x80000020));
    [NativeTypeName("#define RO_E_CANNOT_ACTIVATE_UNIVERSAL_APPLICATION_SERVER _HRESULT_TYPEDEF_(0x80000021L)")]
    public const int RO_E_CANNOT_ACTIVATE_UNIVERSAL_APPLICATION_SERVER = unchecked((int)(0x80000021));
}