// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class HTTP
{
    [NativeTypeName("#define HTTP_STATUS_CONTINUE 100")]
    public const int HTTP_STATUS_CONTINUE = 100;

    [NativeTypeName("#define HTTP_STATUS_SWITCH_PROTOCOLS 101")]
    public const int HTTP_STATUS_SWITCH_PROTOCOLS = 101;

    [NativeTypeName("#define HTTP_STATUS_OK 200")]
    public const int HTTP_STATUS_OK = 200;

    [NativeTypeName("#define HTTP_STATUS_CREATED 201")]
    public const int HTTP_STATUS_CREATED = 201;

    [NativeTypeName("#define HTTP_STATUS_ACCEPTED 202")]
    public const int HTTP_STATUS_ACCEPTED = 202;

    [NativeTypeName("#define HTTP_STATUS_PARTIAL 203")]
    public const int HTTP_STATUS_PARTIAL = 203;

    [NativeTypeName("#define HTTP_STATUS_NO_CONTENT 204")]
    public const int HTTP_STATUS_NO_CONTENT = 204;

    [NativeTypeName("#define HTTP_STATUS_RESET_CONTENT 205")]
    public const int HTTP_STATUS_RESET_CONTENT = 205;

    [NativeTypeName("#define HTTP_STATUS_PARTIAL_CONTENT 206")]
    public const int HTTP_STATUS_PARTIAL_CONTENT = 206;

    [NativeTypeName("#define HTTP_STATUS_WEBDAV_MULTI_STATUS 207")]
    public const int HTTP_STATUS_WEBDAV_MULTI_STATUS = 207;

    [NativeTypeName("#define HTTP_STATUS_AMBIGUOUS 300")]
    public const int HTTP_STATUS_AMBIGUOUS = 300;

    [NativeTypeName("#define HTTP_STATUS_MOVED 301")]
    public const int HTTP_STATUS_MOVED = 301;

    [NativeTypeName("#define HTTP_STATUS_REDIRECT 302")]
    public const int HTTP_STATUS_REDIRECT = 302;

    [NativeTypeName("#define HTTP_STATUS_REDIRECT_METHOD 303")]
    public const int HTTP_STATUS_REDIRECT_METHOD = 303;

    [NativeTypeName("#define HTTP_STATUS_NOT_MODIFIED 304")]
    public const int HTTP_STATUS_NOT_MODIFIED = 304;

    [NativeTypeName("#define HTTP_STATUS_USE_PROXY 305")]
    public const int HTTP_STATUS_USE_PROXY = 305;

    [NativeTypeName("#define HTTP_STATUS_REDIRECT_KEEP_VERB 307")]
    public const int HTTP_STATUS_REDIRECT_KEEP_VERB = 307;

    [NativeTypeName("#define HTTP_STATUS_PERMANENT_REDIRECT 308")]
    public const int HTTP_STATUS_PERMANENT_REDIRECT = 308;

    [NativeTypeName("#define HTTP_STATUS_BAD_REQUEST 400")]
    public const int HTTP_STATUS_BAD_REQUEST = 400;

    [NativeTypeName("#define HTTP_STATUS_DENIED 401")]
    public const int HTTP_STATUS_DENIED = 401;

    [NativeTypeName("#define HTTP_STATUS_PAYMENT_REQ 402")]
    public const int HTTP_STATUS_PAYMENT_REQ = 402;

    [NativeTypeName("#define HTTP_STATUS_FORBIDDEN 403")]
    public const int HTTP_STATUS_FORBIDDEN = 403;

    [NativeTypeName("#define HTTP_STATUS_NOT_FOUND 404")]
    public const int HTTP_STATUS_NOT_FOUND = 404;

    [NativeTypeName("#define HTTP_STATUS_BAD_METHOD 405")]
    public const int HTTP_STATUS_BAD_METHOD = 405;

    [NativeTypeName("#define HTTP_STATUS_NONE_ACCEPTABLE 406")]
    public const int HTTP_STATUS_NONE_ACCEPTABLE = 406;

    [NativeTypeName("#define HTTP_STATUS_PROXY_AUTH_REQ 407")]
    public const int HTTP_STATUS_PROXY_AUTH_REQ = 407;

    [NativeTypeName("#define HTTP_STATUS_REQUEST_TIMEOUT 408")]
    public const int HTTP_STATUS_REQUEST_TIMEOUT = 408;

    [NativeTypeName("#define HTTP_STATUS_CONFLICT 409")]
    public const int HTTP_STATUS_CONFLICT = 409;

    [NativeTypeName("#define HTTP_STATUS_GONE 410")]
    public const int HTTP_STATUS_GONE = 410;

    [NativeTypeName("#define HTTP_STATUS_LENGTH_REQUIRED 411")]
    public const int HTTP_STATUS_LENGTH_REQUIRED = 411;

    [NativeTypeName("#define HTTP_STATUS_PRECOND_FAILED 412")]
    public const int HTTP_STATUS_PRECOND_FAILED = 412;

    [NativeTypeName("#define HTTP_STATUS_REQUEST_TOO_LARGE 413")]
    public const int HTTP_STATUS_REQUEST_TOO_LARGE = 413;

    [NativeTypeName("#define HTTP_STATUS_URI_TOO_LONG 414")]
    public const int HTTP_STATUS_URI_TOO_LONG = 414;

    [NativeTypeName("#define HTTP_STATUS_UNSUPPORTED_MEDIA 415")]
    public const int HTTP_STATUS_UNSUPPORTED_MEDIA = 415;

    [NativeTypeName("#define HTTP_STATUS_RETRY_WITH 449")]
    public const int HTTP_STATUS_RETRY_WITH = 449;

    [NativeTypeName("#define HTTP_STATUS_SERVER_ERROR 500")]
    public const int HTTP_STATUS_SERVER_ERROR = 500;

    [NativeTypeName("#define HTTP_STATUS_NOT_SUPPORTED 501")]
    public const int HTTP_STATUS_NOT_SUPPORTED = 501;

    [NativeTypeName("#define HTTP_STATUS_BAD_GATEWAY 502")]
    public const int HTTP_STATUS_BAD_GATEWAY = 502;

    [NativeTypeName("#define HTTP_STATUS_SERVICE_UNAVAIL 503")]
    public const int HTTP_STATUS_SERVICE_UNAVAIL = 503;

    [NativeTypeName("#define HTTP_STATUS_GATEWAY_TIMEOUT 504")]
    public const int HTTP_STATUS_GATEWAY_TIMEOUT = 504;

    [NativeTypeName("#define HTTP_STATUS_VERSION_NOT_SUP 505")]
    public const int HTTP_STATUS_VERSION_NOT_SUP = 505;

    [NativeTypeName("#define HTTP_STATUS_FIRST HTTP_STATUS_CONTINUE")]
    public const int HTTP_STATUS_FIRST = 100;

    [NativeTypeName("#define HTTP_STATUS_LAST HTTP_STATUS_VERSION_NOT_SUP")]
    public const int HTTP_STATUS_LAST = 505;
}
