// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class HTTP
{
    [NativeTypeName("#define HTTP_E_STATUS_UNEXPECTED _HRESULT_TYPEDEF_(0x80190001L)")]
    public const int HTTP_E_STATUS_UNEXPECTED = unchecked((int)(0x80190001));

    [NativeTypeName("#define HTTP_E_STATUS_UNEXPECTED_REDIRECTION _HRESULT_TYPEDEF_(0x80190003L)")]
    public const int HTTP_E_STATUS_UNEXPECTED_REDIRECTION = unchecked((int)(0x80190003));

    [NativeTypeName("#define HTTP_E_STATUS_UNEXPECTED_CLIENT_ERROR _HRESULT_TYPEDEF_(0x80190004L)")]
    public const int HTTP_E_STATUS_UNEXPECTED_CLIENT_ERROR = unchecked((int)(0x80190004));

    [NativeTypeName("#define HTTP_E_STATUS_UNEXPECTED_SERVER_ERROR _HRESULT_TYPEDEF_(0x80190005L)")]
    public const int HTTP_E_STATUS_UNEXPECTED_SERVER_ERROR = unchecked((int)(0x80190005));

    [NativeTypeName("#define HTTP_E_STATUS_AMBIGUOUS _HRESULT_TYPEDEF_(0x8019012CL)")]
    public const int HTTP_E_STATUS_AMBIGUOUS = unchecked((int)(0x8019012C));

    [NativeTypeName("#define HTTP_E_STATUS_MOVED _HRESULT_TYPEDEF_(0x8019012DL)")]
    public const int HTTP_E_STATUS_MOVED = unchecked((int)(0x8019012D));

    [NativeTypeName("#define HTTP_E_STATUS_REDIRECT _HRESULT_TYPEDEF_(0x8019012EL)")]
    public const int HTTP_E_STATUS_REDIRECT = unchecked((int)(0x8019012E));

    [NativeTypeName("#define HTTP_E_STATUS_REDIRECT_METHOD _HRESULT_TYPEDEF_(0x8019012FL)")]
    public const int HTTP_E_STATUS_REDIRECT_METHOD = unchecked((int)(0x8019012F));

    [NativeTypeName("#define HTTP_E_STATUS_NOT_MODIFIED _HRESULT_TYPEDEF_(0x80190130L)")]
    public const int HTTP_E_STATUS_NOT_MODIFIED = unchecked((int)(0x80190130));

    [NativeTypeName("#define HTTP_E_STATUS_USE_PROXY _HRESULT_TYPEDEF_(0x80190131L)")]
    public const int HTTP_E_STATUS_USE_PROXY = unchecked((int)(0x80190131));

    [NativeTypeName("#define HTTP_E_STATUS_REDIRECT_KEEP_VERB _HRESULT_TYPEDEF_(0x80190133L)")]
    public const int HTTP_E_STATUS_REDIRECT_KEEP_VERB = unchecked((int)(0x80190133));

    [NativeTypeName("#define HTTP_E_STATUS_BAD_REQUEST _HRESULT_TYPEDEF_(0x80190190L)")]
    public const int HTTP_E_STATUS_BAD_REQUEST = unchecked((int)(0x80190190));

    [NativeTypeName("#define HTTP_E_STATUS_DENIED _HRESULT_TYPEDEF_(0x80190191L)")]
    public const int HTTP_E_STATUS_DENIED = unchecked((int)(0x80190191));

    [NativeTypeName("#define HTTP_E_STATUS_PAYMENT_REQ _HRESULT_TYPEDEF_(0x80190192L)")]
    public const int HTTP_E_STATUS_PAYMENT_REQ = unchecked((int)(0x80190192));

    [NativeTypeName("#define HTTP_E_STATUS_FORBIDDEN _HRESULT_TYPEDEF_(0x80190193L)")]
    public const int HTTP_E_STATUS_FORBIDDEN = unchecked((int)(0x80190193));

    [NativeTypeName("#define HTTP_E_STATUS_NOT_FOUND _HRESULT_TYPEDEF_(0x80190194L)")]
    public const int HTTP_E_STATUS_NOT_FOUND = unchecked((int)(0x80190194));

    [NativeTypeName("#define HTTP_E_STATUS_BAD_METHOD _HRESULT_TYPEDEF_(0x80190195L)")]
    public const int HTTP_E_STATUS_BAD_METHOD = unchecked((int)(0x80190195));

    [NativeTypeName("#define HTTP_E_STATUS_NONE_ACCEPTABLE _HRESULT_TYPEDEF_(0x80190196L)")]
    public const int HTTP_E_STATUS_NONE_ACCEPTABLE = unchecked((int)(0x80190196));

    [NativeTypeName("#define HTTP_E_STATUS_PROXY_AUTH_REQ _HRESULT_TYPEDEF_(0x80190197L)")]
    public const int HTTP_E_STATUS_PROXY_AUTH_REQ = unchecked((int)(0x80190197));

    [NativeTypeName("#define HTTP_E_STATUS_REQUEST_TIMEOUT _HRESULT_TYPEDEF_(0x80190198L)")]
    public const int HTTP_E_STATUS_REQUEST_TIMEOUT = unchecked((int)(0x80190198));

    [NativeTypeName("#define HTTP_E_STATUS_CONFLICT _HRESULT_TYPEDEF_(0x80190199L)")]
    public const int HTTP_E_STATUS_CONFLICT = unchecked((int)(0x80190199));

    [NativeTypeName("#define HTTP_E_STATUS_GONE _HRESULT_TYPEDEF_(0x8019019AL)")]
    public const int HTTP_E_STATUS_GONE = unchecked((int)(0x8019019A));

    [NativeTypeName("#define HTTP_E_STATUS_LENGTH_REQUIRED _HRESULT_TYPEDEF_(0x8019019BL)")]
    public const int HTTP_E_STATUS_LENGTH_REQUIRED = unchecked((int)(0x8019019B));

    [NativeTypeName("#define HTTP_E_STATUS_PRECOND_FAILED _HRESULT_TYPEDEF_(0x8019019CL)")]
    public const int HTTP_E_STATUS_PRECOND_FAILED = unchecked((int)(0x8019019C));

    [NativeTypeName("#define HTTP_E_STATUS_REQUEST_TOO_LARGE _HRESULT_TYPEDEF_(0x8019019DL)")]
    public const int HTTP_E_STATUS_REQUEST_TOO_LARGE = unchecked((int)(0x8019019D));

    [NativeTypeName("#define HTTP_E_STATUS_URI_TOO_LONG _HRESULT_TYPEDEF_(0x8019019EL)")]
    public const int HTTP_E_STATUS_URI_TOO_LONG = unchecked((int)(0x8019019E));

    [NativeTypeName("#define HTTP_E_STATUS_UNSUPPORTED_MEDIA _HRESULT_TYPEDEF_(0x8019019FL)")]
    public const int HTTP_E_STATUS_UNSUPPORTED_MEDIA = unchecked((int)(0x8019019F));

    [NativeTypeName("#define HTTP_E_STATUS_RANGE_NOT_SATISFIABLE _HRESULT_TYPEDEF_(0x801901A0L)")]
    public const int HTTP_E_STATUS_RANGE_NOT_SATISFIABLE = unchecked((int)(0x801901A0));

    [NativeTypeName("#define HTTP_E_STATUS_EXPECTATION_FAILED _HRESULT_TYPEDEF_(0x801901A1L)")]
    public const int HTTP_E_STATUS_EXPECTATION_FAILED = unchecked((int)(0x801901A1));

    [NativeTypeName("#define HTTP_E_STATUS_SERVER_ERROR _HRESULT_TYPEDEF_(0x801901F4L)")]
    public const int HTTP_E_STATUS_SERVER_ERROR = unchecked((int)(0x801901F4));

    [NativeTypeName("#define HTTP_E_STATUS_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x801901F5L)")]
    public const int HTTP_E_STATUS_NOT_SUPPORTED = unchecked((int)(0x801901F5));

    [NativeTypeName("#define HTTP_E_STATUS_BAD_GATEWAY _HRESULT_TYPEDEF_(0x801901F6L)")]
    public const int HTTP_E_STATUS_BAD_GATEWAY = unchecked((int)(0x801901F6));

    [NativeTypeName("#define HTTP_E_STATUS_SERVICE_UNAVAIL _HRESULT_TYPEDEF_(0x801901F7L)")]
    public const int HTTP_E_STATUS_SERVICE_UNAVAIL = unchecked((int)(0x801901F7));

    [NativeTypeName("#define HTTP_E_STATUS_GATEWAY_TIMEOUT _HRESULT_TYPEDEF_(0x801901F8L)")]
    public const int HTTP_E_STATUS_GATEWAY_TIMEOUT = unchecked((int)(0x801901F8));

    [NativeTypeName("#define HTTP_E_STATUS_VERSION_NOT_SUP _HRESULT_TYPEDEF_(0x801901F9L)")]
    public const int HTTP_E_STATUS_VERSION_NOT_SUP = unchecked((int)(0x801901F9));
}
