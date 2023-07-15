// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class HCS
{
    [NativeTypeName("#define HCS_E_TERMINATED_DURING_START _HRESULT_TYPEDEF_(0x80370100L)")]
    public const int HCS_E_TERMINATED_DURING_START = unchecked((int)(0x80370100));
    [NativeTypeName("#define HCS_E_IMAGE_MISMATCH _HRESULT_TYPEDEF_(0x80370101L)")]
    public const int HCS_E_IMAGE_MISMATCH = unchecked((int)(0x80370101));
    [NativeTypeName("#define HCS_E_HYPERV_NOT_INSTALLED _HRESULT_TYPEDEF_(0x80370102L)")]
    public const int HCS_E_HYPERV_NOT_INSTALLED = unchecked((int)(0x80370102));
    [NativeTypeName("#define HCS_E_INVALID_STATE _HRESULT_TYPEDEF_(0x80370105L)")]
    public const int HCS_E_INVALID_STATE = unchecked((int)(0x80370105));
    [NativeTypeName("#define HCS_E_UNEXPECTED_EXIT _HRESULT_TYPEDEF_(0x80370106L)")]
    public const int HCS_E_UNEXPECTED_EXIT = unchecked((int)(0x80370106));
    [NativeTypeName("#define HCS_E_TERMINATED _HRESULT_TYPEDEF_(0x80370107L)")]
    public const int HCS_E_TERMINATED = unchecked((int)(0x80370107));
    [NativeTypeName("#define HCS_E_CONNECT_FAILED _HRESULT_TYPEDEF_(0x80370108L)")]
    public const int HCS_E_CONNECT_FAILED = unchecked((int)(0x80370108));
    [NativeTypeName("#define HCS_E_CONNECTION_TIMEOUT _HRESULT_TYPEDEF_(0x80370109L)")]
    public const int HCS_E_CONNECTION_TIMEOUT = unchecked((int)(0x80370109));
    [NativeTypeName("#define HCS_E_CONNECTION_CLOSED _HRESULT_TYPEDEF_(0x8037010AL)")]
    public const int HCS_E_CONNECTION_CLOSED = unchecked((int)(0x8037010A));
    [NativeTypeName("#define HCS_E_UNKNOWN_MESSAGE _HRESULT_TYPEDEF_(0x8037010BL)")]
    public const int HCS_E_UNKNOWN_MESSAGE = unchecked((int)(0x8037010B));
    [NativeTypeName("#define HCS_E_UNSUPPORTED_PROTOCOL_VERSION _HRESULT_TYPEDEF_(0x8037010CL)")]
    public const int HCS_E_UNSUPPORTED_PROTOCOL_VERSION = unchecked((int)(0x8037010C));
    [NativeTypeName("#define HCS_E_INVALID_JSON _HRESULT_TYPEDEF_(0x8037010DL)")]
    public const int HCS_E_INVALID_JSON = unchecked((int)(0x8037010D));
    [NativeTypeName("#define HCS_E_SYSTEM_NOT_FOUND _HRESULT_TYPEDEF_(0x8037010EL)")]
    public const int HCS_E_SYSTEM_NOT_FOUND = unchecked((int)(0x8037010E));
    [NativeTypeName("#define HCS_E_SYSTEM_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x8037010FL)")]
    public const int HCS_E_SYSTEM_ALREADY_EXISTS = unchecked((int)(0x8037010F));
    [NativeTypeName("#define HCS_E_SYSTEM_ALREADY_STOPPED _HRESULT_TYPEDEF_(0x80370110L)")]
    public const int HCS_E_SYSTEM_ALREADY_STOPPED = unchecked((int)(0x80370110));
    [NativeTypeName("#define HCS_E_PROTOCOL_ERROR _HRESULT_TYPEDEF_(0x80370111L)")]
    public const int HCS_E_PROTOCOL_ERROR = unchecked((int)(0x80370111));
    [NativeTypeName("#define HCS_E_INVALID_LAYER _HRESULT_TYPEDEF_(0x80370112L)")]
    public const int HCS_E_INVALID_LAYER = unchecked((int)(0x80370112));
    [NativeTypeName("#define HCS_E_WINDOWS_INSIDER_REQUIRED _HRESULT_TYPEDEF_(0x80370113L)")]
    public const int HCS_E_WINDOWS_INSIDER_REQUIRED = unchecked((int)(0x80370113));
    [NativeTypeName("#define HCS_E_SERVICE_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80370114L)")]
    public const int HCS_E_SERVICE_NOT_AVAILABLE = unchecked((int)(0x80370114));
    [NativeTypeName("#define HCS_E_OPERATION_NOT_STARTED _HRESULT_TYPEDEF_(0x80370115L)")]
    public const int HCS_E_OPERATION_NOT_STARTED = unchecked((int)(0x80370115));
    [NativeTypeName("#define HCS_E_OPERATION_ALREADY_STARTED _HRESULT_TYPEDEF_(0x80370116L)")]
    public const int HCS_E_OPERATION_ALREADY_STARTED = unchecked((int)(0x80370116));
    [NativeTypeName("#define HCS_E_OPERATION_PENDING _HRESULT_TYPEDEF_(0x80370117L)")]
    public const int HCS_E_OPERATION_PENDING = unchecked((int)(0x80370117));
    [NativeTypeName("#define HCS_E_OPERATION_TIMEOUT _HRESULT_TYPEDEF_(0x80370118L)")]
    public const int HCS_E_OPERATION_TIMEOUT = unchecked((int)(0x80370118));
    [NativeTypeName("#define HCS_E_OPERATION_SYSTEM_CALLBACK_ALREADY_SET _HRESULT_TYPEDEF_(0x80370119L)")]
    public const int HCS_E_OPERATION_SYSTEM_CALLBACK_ALREADY_SET = unchecked((int)(0x80370119));
    [NativeTypeName("#define HCS_E_OPERATION_RESULT_ALLOCATION_FAILED _HRESULT_TYPEDEF_(0x8037011AL)")]
    public const int HCS_E_OPERATION_RESULT_ALLOCATION_FAILED = unchecked((int)(0x8037011A));
    [NativeTypeName("#define HCS_E_ACCESS_DENIED _HRESULT_TYPEDEF_(0x8037011BL)")]
    public const int HCS_E_ACCESS_DENIED = unchecked((int)(0x8037011B));
    [NativeTypeName("#define HCS_E_GUEST_CRITICAL_ERROR _HRESULT_TYPEDEF_(0x8037011CL)")]
    public const int HCS_E_GUEST_CRITICAL_ERROR = unchecked((int)(0x8037011C));
    [NativeTypeName("#define HCS_E_PROCESS_INFO_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x8037011DL)")]
    public const int HCS_E_PROCESS_INFO_NOT_AVAILABLE = unchecked((int)(0x8037011D));
    [NativeTypeName("#define HCS_E_SERVICE_DISCONNECT _HRESULT_TYPEDEF_(0x8037011EL)")]
    public const int HCS_E_SERVICE_DISCONNECT = unchecked((int)(0x8037011E));
    [NativeTypeName("#define HCS_E_PROCESS_ALREADY_STOPPED _HRESULT_TYPEDEF_(0x8037011FL)")]
    public const int HCS_E_PROCESS_ALREADY_STOPPED = unchecked((int)(0x8037011F));
    [NativeTypeName("#define HCS_E_SYSTEM_NOT_CONFIGURED_FOR_OPERATION _HRESULT_TYPEDEF_(0x80370120L)")]
    public const int HCS_E_SYSTEM_NOT_CONFIGURED_FOR_OPERATION = unchecked((int)(0x80370120));
    [NativeTypeName("#define HCS_E_OPERATION_ALREADY_CANCELLED _HRESULT_TYPEDEF_(0x80370121L)")]
    public const int HCS_E_OPERATION_ALREADY_CANCELLED = unchecked((int)(0x80370121));
}