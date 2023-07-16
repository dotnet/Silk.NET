// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class WS
{
    [NativeTypeName("#define WS_S_ASYNC _HRESULT_TYPEDEF_(0x003D0000L)")]
    public const int WS_S_ASYNC = ((int)(0x003D0000));
    [NativeTypeName("#define WS_S_END _HRESULT_TYPEDEF_(0x003D0001L)")]
    public const int WS_S_END = ((int)(0x003D0001));
    [NativeTypeName("#define WS_E_INVALID_FORMAT _HRESULT_TYPEDEF_(0x803D0000L)")]
    public const int WS_E_INVALID_FORMAT = unchecked((int)(0x803D0000));
    [NativeTypeName("#define WS_E_OBJECT_FAULTED _HRESULT_TYPEDEF_(0x803D0001L)")]
    public const int WS_E_OBJECT_FAULTED = unchecked((int)(0x803D0001));
    [NativeTypeName("#define WS_E_NUMERIC_OVERFLOW _HRESULT_TYPEDEF_(0x803D0002L)")]
    public const int WS_E_NUMERIC_OVERFLOW = unchecked((int)(0x803D0002));
    [NativeTypeName("#define WS_E_INVALID_OPERATION _HRESULT_TYPEDEF_(0x803D0003L)")]
    public const int WS_E_INVALID_OPERATION = unchecked((int)(0x803D0003));
    [NativeTypeName("#define WS_E_OPERATION_ABORTED _HRESULT_TYPEDEF_(0x803D0004L)")]
    public const int WS_E_OPERATION_ABORTED = unchecked((int)(0x803D0004));
    [NativeTypeName("#define WS_E_ENDPOINT_ACCESS_DENIED _HRESULT_TYPEDEF_(0x803D0005L)")]
    public const int WS_E_ENDPOINT_ACCESS_DENIED = unchecked((int)(0x803D0005));
    [NativeTypeName("#define WS_E_OPERATION_TIMED_OUT _HRESULT_TYPEDEF_(0x803D0006L)")]
    public const int WS_E_OPERATION_TIMED_OUT = unchecked((int)(0x803D0006));
    [NativeTypeName("#define WS_E_OPERATION_ABANDONED _HRESULT_TYPEDEF_(0x803D0007L)")]
    public const int WS_E_OPERATION_ABANDONED = unchecked((int)(0x803D0007));
    [NativeTypeName("#define WS_E_QUOTA_EXCEEDED _HRESULT_TYPEDEF_(0x803D0008L)")]
    public const int WS_E_QUOTA_EXCEEDED = unchecked((int)(0x803D0008));
    [NativeTypeName("#define WS_E_NO_TRANSLATION_AVAILABLE _HRESULT_TYPEDEF_(0x803D0009L)")]
    public const int WS_E_NO_TRANSLATION_AVAILABLE = unchecked((int)(0x803D0009));
    [NativeTypeName("#define WS_E_SECURITY_VERIFICATION_FAILURE _HRESULT_TYPEDEF_(0x803D000AL)")]
    public const int WS_E_SECURITY_VERIFICATION_FAILURE = unchecked((int)(0x803D000A));
    [NativeTypeName("#define WS_E_ADDRESS_IN_USE _HRESULT_TYPEDEF_(0x803D000BL)")]
    public const int WS_E_ADDRESS_IN_USE = unchecked((int)(0x803D000B));
    [NativeTypeName("#define WS_E_ADDRESS_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x803D000CL)")]
    public const int WS_E_ADDRESS_NOT_AVAILABLE = unchecked((int)(0x803D000C));
    [NativeTypeName("#define WS_E_ENDPOINT_NOT_FOUND _HRESULT_TYPEDEF_(0x803D000DL)")]
    public const int WS_E_ENDPOINT_NOT_FOUND = unchecked((int)(0x803D000D));
    [NativeTypeName("#define WS_E_ENDPOINT_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x803D000EL)")]
    public const int WS_E_ENDPOINT_NOT_AVAILABLE = unchecked((int)(0x803D000E));
    [NativeTypeName("#define WS_E_ENDPOINT_FAILURE _HRESULT_TYPEDEF_(0x803D000FL)")]
    public const int WS_E_ENDPOINT_FAILURE = unchecked((int)(0x803D000F));
    [NativeTypeName("#define WS_E_ENDPOINT_UNREACHABLE _HRESULT_TYPEDEF_(0x803D0010L)")]
    public const int WS_E_ENDPOINT_UNREACHABLE = unchecked((int)(0x803D0010));
    [NativeTypeName("#define WS_E_ENDPOINT_ACTION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803D0011L)")]
    public const int WS_E_ENDPOINT_ACTION_NOT_SUPPORTED = unchecked((int)(0x803D0011));
    [NativeTypeName("#define WS_E_ENDPOINT_TOO_BUSY _HRESULT_TYPEDEF_(0x803D0012L)")]
    public const int WS_E_ENDPOINT_TOO_BUSY = unchecked((int)(0x803D0012));
    [NativeTypeName("#define WS_E_ENDPOINT_FAULT_RECEIVED _HRESULT_TYPEDEF_(0x803D0013L)")]
    public const int WS_E_ENDPOINT_FAULT_RECEIVED = unchecked((int)(0x803D0013));
    [NativeTypeName("#define WS_E_ENDPOINT_DISCONNECTED _HRESULT_TYPEDEF_(0x803D0014L)")]
    public const int WS_E_ENDPOINT_DISCONNECTED = unchecked((int)(0x803D0014));
    [NativeTypeName("#define WS_E_PROXY_FAILURE _HRESULT_TYPEDEF_(0x803D0015L)")]
    public const int WS_E_PROXY_FAILURE = unchecked((int)(0x803D0015));
    [NativeTypeName("#define WS_E_PROXY_ACCESS_DENIED _HRESULT_TYPEDEF_(0x803D0016L)")]
    public const int WS_E_PROXY_ACCESS_DENIED = unchecked((int)(0x803D0016));
    [NativeTypeName("#define WS_E_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803D0017L)")]
    public const int WS_E_NOT_SUPPORTED = unchecked((int)(0x803D0017));
    [NativeTypeName("#define WS_E_PROXY_REQUIRES_BASIC_AUTH _HRESULT_TYPEDEF_(0x803D0018L)")]
    public const int WS_E_PROXY_REQUIRES_BASIC_AUTH = unchecked((int)(0x803D0018));
    [NativeTypeName("#define WS_E_PROXY_REQUIRES_DIGEST_AUTH _HRESULT_TYPEDEF_(0x803D0019L)")]
    public const int WS_E_PROXY_REQUIRES_DIGEST_AUTH = unchecked((int)(0x803D0019));
    [NativeTypeName("#define WS_E_PROXY_REQUIRES_NTLM_AUTH _HRESULT_TYPEDEF_(0x803D001AL)")]
    public const int WS_E_PROXY_REQUIRES_NTLM_AUTH = unchecked((int)(0x803D001A));
    [NativeTypeName("#define WS_E_PROXY_REQUIRES_NEGOTIATE_AUTH _HRESULT_TYPEDEF_(0x803D001BL)")]
    public const int WS_E_PROXY_REQUIRES_NEGOTIATE_AUTH = unchecked((int)(0x803D001B));
    [NativeTypeName("#define WS_E_SERVER_REQUIRES_BASIC_AUTH _HRESULT_TYPEDEF_(0x803D001CL)")]
    public const int WS_E_SERVER_REQUIRES_BASIC_AUTH = unchecked((int)(0x803D001C));
    [NativeTypeName("#define WS_E_SERVER_REQUIRES_DIGEST_AUTH _HRESULT_TYPEDEF_(0x803D001DL)")]
    public const int WS_E_SERVER_REQUIRES_DIGEST_AUTH = unchecked((int)(0x803D001D));
    [NativeTypeName("#define WS_E_SERVER_REQUIRES_NTLM_AUTH _HRESULT_TYPEDEF_(0x803D001EL)")]
    public const int WS_E_SERVER_REQUIRES_NTLM_AUTH = unchecked((int)(0x803D001E));
    [NativeTypeName("#define WS_E_SERVER_REQUIRES_NEGOTIATE_AUTH _HRESULT_TYPEDEF_(0x803D001FL)")]
    public const int WS_E_SERVER_REQUIRES_NEGOTIATE_AUTH = unchecked((int)(0x803D001F));
    [NativeTypeName("#define WS_E_INVALID_ENDPOINT_URL _HRESULT_TYPEDEF_(0x803D0020L)")]
    public const int WS_E_INVALID_ENDPOINT_URL = unchecked((int)(0x803D0020));
    [NativeTypeName("#define WS_E_OTHER _HRESULT_TYPEDEF_(0x803D0021L)")]
    public const int WS_E_OTHER = unchecked((int)(0x803D0021));
    [NativeTypeName("#define WS_E_SECURITY_TOKEN_EXPIRED _HRESULT_TYPEDEF_(0x803D0022L)")]
    public const int WS_E_SECURITY_TOKEN_EXPIRED = unchecked((int)(0x803D0022));
    [NativeTypeName("#define WS_E_SECURITY_SYSTEM_FAILURE _HRESULT_TYPEDEF_(0x803D0023L)")]
    public const int WS_E_SECURITY_SYSTEM_FAILURE = unchecked((int)(0x803D0023));
}