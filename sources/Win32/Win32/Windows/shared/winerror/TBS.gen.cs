// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class TBS
{
    [NativeTypeName("#define TBS_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80284001L)")]
    public const int TBS_E_INTERNAL_ERROR = unchecked((int)(0x80284001));

    [NativeTypeName("#define TBS_E_BAD_PARAMETER _HRESULT_TYPEDEF_(0x80284002L)")]
    public const int TBS_E_BAD_PARAMETER = unchecked((int)(0x80284002));

    [NativeTypeName("#define TBS_E_INVALID_OUTPUT_POINTER _HRESULT_TYPEDEF_(0x80284003L)")]
    public const int TBS_E_INVALID_OUTPUT_POINTER = unchecked((int)(0x80284003));

    [NativeTypeName("#define TBS_E_INVALID_CONTEXT _HRESULT_TYPEDEF_(0x80284004L)")]
    public const int TBS_E_INVALID_CONTEXT = unchecked((int)(0x80284004));

    [NativeTypeName("#define TBS_E_INSUFFICIENT_BUFFER _HRESULT_TYPEDEF_(0x80284005L)")]
    public const int TBS_E_INSUFFICIENT_BUFFER = unchecked((int)(0x80284005));

    [NativeTypeName("#define TBS_E_IOERROR _HRESULT_TYPEDEF_(0x80284006L)")]
    public const int TBS_E_IOERROR = unchecked((int)(0x80284006));

    [NativeTypeName("#define TBS_E_INVALID_CONTEXT_PARAM _HRESULT_TYPEDEF_(0x80284007L)")]
    public const int TBS_E_INVALID_CONTEXT_PARAM = unchecked((int)(0x80284007));

    [NativeTypeName("#define TBS_E_SERVICE_NOT_RUNNING _HRESULT_TYPEDEF_(0x80284008L)")]
    public const int TBS_E_SERVICE_NOT_RUNNING = unchecked((int)(0x80284008));

    [NativeTypeName("#define TBS_E_TOO_MANY_TBS_CONTEXTS _HRESULT_TYPEDEF_(0x80284009L)")]
    public const int TBS_E_TOO_MANY_TBS_CONTEXTS = unchecked((int)(0x80284009));

    [NativeTypeName("#define TBS_E_TOO_MANY_RESOURCES _HRESULT_TYPEDEF_(0x8028400AL)")]
    public const int TBS_E_TOO_MANY_RESOURCES = unchecked((int)(0x8028400A));

    [NativeTypeName("#define TBS_E_SERVICE_START_PENDING _HRESULT_TYPEDEF_(0x8028400BL)")]
    public const int TBS_E_SERVICE_START_PENDING = unchecked((int)(0x8028400B));

    [NativeTypeName("#define TBS_E_PPI_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8028400CL)")]
    public const int TBS_E_PPI_NOT_SUPPORTED = unchecked((int)(0x8028400C));

    [NativeTypeName("#define TBS_E_COMMAND_CANCELED _HRESULT_TYPEDEF_(0x8028400DL)")]
    public const int TBS_E_COMMAND_CANCELED = unchecked((int)(0x8028400D));

    [NativeTypeName("#define TBS_E_BUFFER_TOO_LARGE _HRESULT_TYPEDEF_(0x8028400EL)")]
    public const int TBS_E_BUFFER_TOO_LARGE = unchecked((int)(0x8028400E));

    [NativeTypeName("#define TBS_E_TPM_NOT_FOUND _HRESULT_TYPEDEF_(0x8028400FL)")]
    public const int TBS_E_TPM_NOT_FOUND = unchecked((int)(0x8028400F));

    [NativeTypeName("#define TBS_E_SERVICE_DISABLED _HRESULT_TYPEDEF_(0x80284010L)")]
    public const int TBS_E_SERVICE_DISABLED = unchecked((int)(0x80284010));

    [NativeTypeName("#define TBS_E_NO_EVENT_LOG _HRESULT_TYPEDEF_(0x80284011L)")]
    public const int TBS_E_NO_EVENT_LOG = unchecked((int)(0x80284011));

    [NativeTypeName("#define TBS_E_ACCESS_DENIED _HRESULT_TYPEDEF_(0x80284012L)")]
    public const int TBS_E_ACCESS_DENIED = unchecked((int)(0x80284012));

    [NativeTypeName("#define TBS_E_PROVISIONING_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80284013L)")]
    public const int TBS_E_PROVISIONING_NOT_ALLOWED = unchecked((int)(0x80284013));

    [NativeTypeName("#define TBS_E_PPI_FUNCTION_UNSUPPORTED _HRESULT_TYPEDEF_(0x80284014L)")]
    public const int TBS_E_PPI_FUNCTION_UNSUPPORTED = unchecked((int)(0x80284014));

    [NativeTypeName("#define TBS_E_OWNERAUTH_NOT_FOUND _HRESULT_TYPEDEF_(0x80284015L)")]
    public const int TBS_E_OWNERAUTH_NOT_FOUND = unchecked((int)(0x80284015));

    [NativeTypeName("#define TBS_E_PROVISIONING_INCOMPLETE _HRESULT_TYPEDEF_(0x80284016L)")]
    public const int TBS_E_PROVISIONING_INCOMPLETE = unchecked((int)(0x80284016));
}
