// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class WININET
{
    [NativeTypeName("#define WININET_E_OUT_OF_HANDLES _HRESULT_TYPEDEF_(0x80072EE1L)")]
    public const int WININET_E_OUT_OF_HANDLES = unchecked((int)(0x80072EE1));
    [NativeTypeName("#define WININET_E_TIMEOUT _HRESULT_TYPEDEF_(0x80072EE2L)")]
    public const int WININET_E_TIMEOUT = unchecked((int)(0x80072EE2));
    [NativeTypeName("#define WININET_E_EXTENDED_ERROR _HRESULT_TYPEDEF_(0x80072EE3L)")]
    public const int WININET_E_EXTENDED_ERROR = unchecked((int)(0x80072EE3));
    [NativeTypeName("#define WININET_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80072EE4L)")]
    public const int WININET_E_INTERNAL_ERROR = unchecked((int)(0x80072EE4));
    [NativeTypeName("#define WININET_E_INVALID_URL _HRESULT_TYPEDEF_(0x80072EE5L)")]
    public const int WININET_E_INVALID_URL = unchecked((int)(0x80072EE5));
    [NativeTypeName("#define WININET_E_UNRECOGNIZED_SCHEME _HRESULT_TYPEDEF_(0x80072EE6L)")]
    public const int WININET_E_UNRECOGNIZED_SCHEME = unchecked((int)(0x80072EE6));
    [NativeTypeName("#define WININET_E_NAME_NOT_RESOLVED _HRESULT_TYPEDEF_(0x80072EE7L)")]
    public const int WININET_E_NAME_NOT_RESOLVED = unchecked((int)(0x80072EE7));
    [NativeTypeName("#define WININET_E_PROTOCOL_NOT_FOUND _HRESULT_TYPEDEF_(0x80072EE8L)")]
    public const int WININET_E_PROTOCOL_NOT_FOUND = unchecked((int)(0x80072EE8));
    [NativeTypeName("#define WININET_E_INVALID_OPTION _HRESULT_TYPEDEF_(0x80072EE9L)")]
    public const int WININET_E_INVALID_OPTION = unchecked((int)(0x80072EE9));
    [NativeTypeName("#define WININET_E_BAD_OPTION_LENGTH _HRESULT_TYPEDEF_(0x80072EEAL)")]
    public const int WININET_E_BAD_OPTION_LENGTH = unchecked((int)(0x80072EEA));
    [NativeTypeName("#define WININET_E_OPTION_NOT_SETTABLE _HRESULT_TYPEDEF_(0x80072EEBL)")]
    public const int WININET_E_OPTION_NOT_SETTABLE = unchecked((int)(0x80072EEB));
    [NativeTypeName("#define WININET_E_SHUTDOWN _HRESULT_TYPEDEF_(0x80072EECL)")]
    public const int WININET_E_SHUTDOWN = unchecked((int)(0x80072EEC));
    [NativeTypeName("#define WININET_E_INCORRECT_USER_NAME _HRESULT_TYPEDEF_(0x80072EEDL)")]
    public const int WININET_E_INCORRECT_USER_NAME = unchecked((int)(0x80072EED));
    [NativeTypeName("#define WININET_E_INCORRECT_PASSWORD _HRESULT_TYPEDEF_(0x80072EEEL)")]
    public const int WININET_E_INCORRECT_PASSWORD = unchecked((int)(0x80072EEE));
    [NativeTypeName("#define WININET_E_LOGIN_FAILURE _HRESULT_TYPEDEF_(0x80072EEFL)")]
    public const int WININET_E_LOGIN_FAILURE = unchecked((int)(0x80072EEF));
    [NativeTypeName("#define WININET_E_INVALID_OPERATION _HRESULT_TYPEDEF_(0x80072EF0L)")]
    public const int WININET_E_INVALID_OPERATION = unchecked((int)(0x80072EF0));
    [NativeTypeName("#define WININET_E_OPERATION_CANCELLED _HRESULT_TYPEDEF_(0x80072EF1L)")]
    public const int WININET_E_OPERATION_CANCELLED = unchecked((int)(0x80072EF1));
    [NativeTypeName("#define WININET_E_INCORRECT_HANDLE_TYPE _HRESULT_TYPEDEF_(0x80072EF2L)")]
    public const int WININET_E_INCORRECT_HANDLE_TYPE = unchecked((int)(0x80072EF2));
    [NativeTypeName("#define WININET_E_INCORRECT_HANDLE_STATE _HRESULT_TYPEDEF_(0x80072EF3L)")]
    public const int WININET_E_INCORRECT_HANDLE_STATE = unchecked((int)(0x80072EF3));
    [NativeTypeName("#define WININET_E_NOT_PROXY_REQUEST _HRESULT_TYPEDEF_(0x80072EF4L)")]
    public const int WININET_E_NOT_PROXY_REQUEST = unchecked((int)(0x80072EF4));
    [NativeTypeName("#define WININET_E_REGISTRY_VALUE_NOT_FOUND _HRESULT_TYPEDEF_(0x80072EF5L)")]
    public const int WININET_E_REGISTRY_VALUE_NOT_FOUND = unchecked((int)(0x80072EF5));
    [NativeTypeName("#define WININET_E_BAD_REGISTRY_PARAMETER _HRESULT_TYPEDEF_(0x80072EF6L)")]
    public const int WININET_E_BAD_REGISTRY_PARAMETER = unchecked((int)(0x80072EF6));
    [NativeTypeName("#define WININET_E_NO_DIRECT_ACCESS _HRESULT_TYPEDEF_(0x80072EF7L)")]
    public const int WININET_E_NO_DIRECT_ACCESS = unchecked((int)(0x80072EF7));
    [NativeTypeName("#define WININET_E_NO_CONTEXT _HRESULT_TYPEDEF_(0x80072EF8L)")]
    public const int WININET_E_NO_CONTEXT = unchecked((int)(0x80072EF8));
    [NativeTypeName("#define WININET_E_NO_CALLBACK _HRESULT_TYPEDEF_(0x80072EF9L)")]
    public const int WININET_E_NO_CALLBACK = unchecked((int)(0x80072EF9));
    [NativeTypeName("#define WININET_E_REQUEST_PENDING _HRESULT_TYPEDEF_(0x80072EFAL)")]
    public const int WININET_E_REQUEST_PENDING = unchecked((int)(0x80072EFA));
    [NativeTypeName("#define WININET_E_INCORRECT_FORMAT _HRESULT_TYPEDEF_(0x80072EFBL)")]
    public const int WININET_E_INCORRECT_FORMAT = unchecked((int)(0x80072EFB));
    [NativeTypeName("#define WININET_E_ITEM_NOT_FOUND _HRESULT_TYPEDEF_(0x80072EFCL)")]
    public const int WININET_E_ITEM_NOT_FOUND = unchecked((int)(0x80072EFC));
    [NativeTypeName("#define WININET_E_CANNOT_CONNECT _HRESULT_TYPEDEF_(0x80072EFDL)")]
    public const int WININET_E_CANNOT_CONNECT = unchecked((int)(0x80072EFD));
    [NativeTypeName("#define WININET_E_CONNECTION_ABORTED _HRESULT_TYPEDEF_(0x80072EFEL)")]
    public const int WININET_E_CONNECTION_ABORTED = unchecked((int)(0x80072EFE));
    [NativeTypeName("#define WININET_E_CONNECTION_RESET _HRESULT_TYPEDEF_(0x80072EFFL)")]
    public const int WININET_E_CONNECTION_RESET = unchecked((int)(0x80072EFF));
    [NativeTypeName("#define WININET_E_FORCE_RETRY _HRESULT_TYPEDEF_(0x80072F00L)")]
    public const int WININET_E_FORCE_RETRY = unchecked((int)(0x80072F00));
    [NativeTypeName("#define WININET_E_INVALID_PROXY_REQUEST _HRESULT_TYPEDEF_(0x80072F01L)")]
    public const int WININET_E_INVALID_PROXY_REQUEST = unchecked((int)(0x80072F01));
    [NativeTypeName("#define WININET_E_NEED_UI _HRESULT_TYPEDEF_(0x80072F02L)")]
    public const int WININET_E_NEED_UI = unchecked((int)(0x80072F02));
    [NativeTypeName("#define WININET_E_HANDLE_EXISTS _HRESULT_TYPEDEF_(0x80072F04L)")]
    public const int WININET_E_HANDLE_EXISTS = unchecked((int)(0x80072F04));
    [NativeTypeName("#define WININET_E_SEC_CERT_DATE_INVALID _HRESULT_TYPEDEF_(0x80072F05L)")]
    public const int WININET_E_SEC_CERT_DATE_INVALID = unchecked((int)(0x80072F05));
    [NativeTypeName("#define WININET_E_SEC_CERT_CN_INVALID _HRESULT_TYPEDEF_(0x80072F06L)")]
    public const int WININET_E_SEC_CERT_CN_INVALID = unchecked((int)(0x80072F06));
    [NativeTypeName("#define WININET_E_HTTP_TO_HTTPS_ON_REDIR _HRESULT_TYPEDEF_(0x80072F07L)")]
    public const int WININET_E_HTTP_TO_HTTPS_ON_REDIR = unchecked((int)(0x80072F07));
    [NativeTypeName("#define WININET_E_HTTPS_TO_HTTP_ON_REDIR _HRESULT_TYPEDEF_(0x80072F08L)")]
    public const int WININET_E_HTTPS_TO_HTTP_ON_REDIR = unchecked((int)(0x80072F08));
    [NativeTypeName("#define WININET_E_MIXED_SECURITY _HRESULT_TYPEDEF_(0x80072F09L)")]
    public const int WININET_E_MIXED_SECURITY = unchecked((int)(0x80072F09));
    [NativeTypeName("#define WININET_E_CHG_POST_IS_NON_SECURE _HRESULT_TYPEDEF_(0x80072F0AL)")]
    public const int WININET_E_CHG_POST_IS_NON_SECURE = unchecked((int)(0x80072F0A));
    [NativeTypeName("#define WININET_E_POST_IS_NON_SECURE _HRESULT_TYPEDEF_(0x80072F0BL)")]
    public const int WININET_E_POST_IS_NON_SECURE = unchecked((int)(0x80072F0B));
    [NativeTypeName("#define WININET_E_CLIENT_AUTH_CERT_NEEDED _HRESULT_TYPEDEF_(0x80072F0CL)")]
    public const int WININET_E_CLIENT_AUTH_CERT_NEEDED = unchecked((int)(0x80072F0C));
    [NativeTypeName("#define WININET_E_INVALID_CA _HRESULT_TYPEDEF_(0x80072F0DL)")]
    public const int WININET_E_INVALID_CA = unchecked((int)(0x80072F0D));
    [NativeTypeName("#define WININET_E_CLIENT_AUTH_NOT_SETUP _HRESULT_TYPEDEF_(0x80072F0EL)")]
    public const int WININET_E_CLIENT_AUTH_NOT_SETUP = unchecked((int)(0x80072F0E));
    [NativeTypeName("#define WININET_E_ASYNC_THREAD_FAILED _HRESULT_TYPEDEF_(0x80072F0FL)")]
    public const int WININET_E_ASYNC_THREAD_FAILED = unchecked((int)(0x80072F0F));
    [NativeTypeName("#define WININET_E_REDIRECT_SCHEME_CHANGE _HRESULT_TYPEDEF_(0x80072F10L)")]
    public const int WININET_E_REDIRECT_SCHEME_CHANGE = unchecked((int)(0x80072F10));
    [NativeTypeName("#define WININET_E_DIALOG_PENDING _HRESULT_TYPEDEF_(0x80072F11L)")]
    public const int WININET_E_DIALOG_PENDING = unchecked((int)(0x80072F11));
    [NativeTypeName("#define WININET_E_RETRY_DIALOG _HRESULT_TYPEDEF_(0x80072F12L)")]
    public const int WININET_E_RETRY_DIALOG = unchecked((int)(0x80072F12));
    [NativeTypeName("#define WININET_E_NO_NEW_CONTAINERS _HRESULT_TYPEDEF_(0x80072F13L)")]
    public const int WININET_E_NO_NEW_CONTAINERS = unchecked((int)(0x80072F13));
    [NativeTypeName("#define WININET_E_HTTPS_HTTP_SUBMIT_REDIR _HRESULT_TYPEDEF_(0x80072F14L)")]
    public const int WININET_E_HTTPS_HTTP_SUBMIT_REDIR = unchecked((int)(0x80072F14));
    [NativeTypeName("#define WININET_E_SEC_CERT_ERRORS _HRESULT_TYPEDEF_(0x80072F17L)")]
    public const int WININET_E_SEC_CERT_ERRORS = unchecked((int)(0x80072F17));
    [NativeTypeName("#define WININET_E_SEC_CERT_REV_FAILED _HRESULT_TYPEDEF_(0x80072F19L)")]
    public const int WININET_E_SEC_CERT_REV_FAILED = unchecked((int)(0x80072F19));
    [NativeTypeName("#define WININET_E_HEADER_NOT_FOUND _HRESULT_TYPEDEF_(0x80072F76L)")]
    public const int WININET_E_HEADER_NOT_FOUND = unchecked((int)(0x80072F76));
    [NativeTypeName("#define WININET_E_DOWNLEVEL_SERVER _HRESULT_TYPEDEF_(0x80072F77L)")]
    public const int WININET_E_DOWNLEVEL_SERVER = unchecked((int)(0x80072F77));
    [NativeTypeName("#define WININET_E_INVALID_SERVER_RESPONSE _HRESULT_TYPEDEF_(0x80072F78L)")]
    public const int WININET_E_INVALID_SERVER_RESPONSE = unchecked((int)(0x80072F78));
    [NativeTypeName("#define WININET_E_INVALID_HEADER _HRESULT_TYPEDEF_(0x80072F79L)")]
    public const int WININET_E_INVALID_HEADER = unchecked((int)(0x80072F79));
    [NativeTypeName("#define WININET_E_INVALID_QUERY_REQUEST _HRESULT_TYPEDEF_(0x80072F7AL)")]
    public const int WININET_E_INVALID_QUERY_REQUEST = unchecked((int)(0x80072F7A));
    [NativeTypeName("#define WININET_E_HEADER_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x80072F7BL)")]
    public const int WININET_E_HEADER_ALREADY_EXISTS = unchecked((int)(0x80072F7B));
    [NativeTypeName("#define WININET_E_REDIRECT_FAILED _HRESULT_TYPEDEF_(0x80072F7CL)")]
    public const int WININET_E_REDIRECT_FAILED = unchecked((int)(0x80072F7C));
    [NativeTypeName("#define WININET_E_SECURITY_CHANNEL_ERROR _HRESULT_TYPEDEF_(0x80072F7DL)")]
    public const int WININET_E_SECURITY_CHANNEL_ERROR = unchecked((int)(0x80072F7D));
    [NativeTypeName("#define WININET_E_UNABLE_TO_CACHE_FILE _HRESULT_TYPEDEF_(0x80072F7EL)")]
    public const int WININET_E_UNABLE_TO_CACHE_FILE = unchecked((int)(0x80072F7E));
    [NativeTypeName("#define WININET_E_TCPIP_NOT_INSTALLED _HRESULT_TYPEDEF_(0x80072F7FL)")]
    public const int WININET_E_TCPIP_NOT_INSTALLED = unchecked((int)(0x80072F7F));
    [NativeTypeName("#define WININET_E_DISCONNECTED _HRESULT_TYPEDEF_(0x80072F83L)")]
    public const int WININET_E_DISCONNECTED = unchecked((int)(0x80072F83));
    [NativeTypeName("#define WININET_E_SERVER_UNREACHABLE _HRESULT_TYPEDEF_(0x80072F84L)")]
    public const int WININET_E_SERVER_UNREACHABLE = unchecked((int)(0x80072F84));
    [NativeTypeName("#define WININET_E_PROXY_SERVER_UNREACHABLE _HRESULT_TYPEDEF_(0x80072F85L)")]
    public const int WININET_E_PROXY_SERVER_UNREACHABLE = unchecked((int)(0x80072F85));
    [NativeTypeName("#define WININET_E_BAD_AUTO_PROXY_SCRIPT _HRESULT_TYPEDEF_(0x80072F86L)")]
    public const int WININET_E_BAD_AUTO_PROXY_SCRIPT = unchecked((int)(0x80072F86));
    [NativeTypeName("#define WININET_E_UNABLE_TO_DOWNLOAD_SCRIPT _HRESULT_TYPEDEF_(0x80072F87L)")]
    public const int WININET_E_UNABLE_TO_DOWNLOAD_SCRIPT = unchecked((int)(0x80072F87));
    [NativeTypeName("#define WININET_E_SEC_INVALID_CERT _HRESULT_TYPEDEF_(0x80072F89L)")]
    public const int WININET_E_SEC_INVALID_CERT = unchecked((int)(0x80072F89));
    [NativeTypeName("#define WININET_E_SEC_CERT_REVOKED _HRESULT_TYPEDEF_(0x80072F8AL)")]
    public const int WININET_E_SEC_CERT_REVOKED = unchecked((int)(0x80072F8A));
    [NativeTypeName("#define WININET_E_FAILED_DUETOSECURITYCHECK _HRESULT_TYPEDEF_(0x80072F8BL)")]
    public const int WININET_E_FAILED_DUETOSECURITYCHECK = unchecked((int)(0x80072F8B));
    [NativeTypeName("#define WININET_E_NOT_INITIALIZED _HRESULT_TYPEDEF_(0x80072F8CL)")]
    public const int WININET_E_NOT_INITIALIZED = unchecked((int)(0x80072F8C));
    [NativeTypeName("#define WININET_E_LOGIN_FAILURE_DISPLAY_ENTITY_BODY _HRESULT_TYPEDEF_(0x80072F8EL)")]
    public const int WININET_E_LOGIN_FAILURE_DISPLAY_ENTITY_BODY = unchecked((int)(0x80072F8E));
    [NativeTypeName("#define WININET_E_DECODING_FAILED _HRESULT_TYPEDEF_(0x80072F8FL)")]
    public const int WININET_E_DECODING_FAILED = unchecked((int)(0x80072F8F));
    [NativeTypeName("#define WININET_E_NOT_REDIRECTED _HRESULT_TYPEDEF_(0x80072F80L)")]
    public const int WININET_E_NOT_REDIRECTED = unchecked((int)(0x80072F80));
    [NativeTypeName("#define WININET_E_COOKIE_NEEDS_CONFIRMATION _HRESULT_TYPEDEF_(0x80072F81L)")]
    public const int WININET_E_COOKIE_NEEDS_CONFIRMATION = unchecked((int)(0x80072F81));
    [NativeTypeName("#define WININET_E_COOKIE_DECLINED _HRESULT_TYPEDEF_(0x80072F82L)")]
    public const int WININET_E_COOKIE_DECLINED = unchecked((int)(0x80072F82));
    [NativeTypeName("#define WININET_E_REDIRECT_NEEDS_CONFIRMATION _HRESULT_TYPEDEF_(0x80072F88L)")]
    public const int WININET_E_REDIRECT_NEEDS_CONFIRMATION = unchecked((int)(0x80072F88));
}