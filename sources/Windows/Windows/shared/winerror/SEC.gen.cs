// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SEC
{
    [NativeTypeName("#define SEC_E_OK ((HRESULT)0x00000000L)")]
    public const int SEC_E_OK = ((int)(0x00000000));

    [NativeTypeName("#define SEC_E_INSUFFICIENT_MEMORY _HRESULT_TYPEDEF_(0x80090300L)")]
    public const int SEC_E_INSUFFICIENT_MEMORY = unchecked((int)(0x80090300));

    [NativeTypeName("#define SEC_E_INVALID_HANDLE _HRESULT_TYPEDEF_(0x80090301L)")]
    public const int SEC_E_INVALID_HANDLE = unchecked((int)(0x80090301));

    [NativeTypeName("#define SEC_E_UNSUPPORTED_FUNCTION _HRESULT_TYPEDEF_(0x80090302L)")]
    public const int SEC_E_UNSUPPORTED_FUNCTION = unchecked((int)(0x80090302));

    [NativeTypeName("#define SEC_E_TARGET_UNKNOWN _HRESULT_TYPEDEF_(0x80090303L)")]
    public const int SEC_E_TARGET_UNKNOWN = unchecked((int)(0x80090303));

    [NativeTypeName("#define SEC_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80090304L)")]
    public const int SEC_E_INTERNAL_ERROR = unchecked((int)(0x80090304));

    [NativeTypeName("#define SEC_E_SECPKG_NOT_FOUND _HRESULT_TYPEDEF_(0x80090305L)")]
    public const int SEC_E_SECPKG_NOT_FOUND = unchecked((int)(0x80090305));

    [NativeTypeName("#define SEC_E_NOT_OWNER _HRESULT_TYPEDEF_(0x80090306L)")]
    public const int SEC_E_NOT_OWNER = unchecked((int)(0x80090306));

    [NativeTypeName("#define SEC_E_CANNOT_INSTALL _HRESULT_TYPEDEF_(0x80090307L)")]
    public const int SEC_E_CANNOT_INSTALL = unchecked((int)(0x80090307));

    [NativeTypeName("#define SEC_E_INVALID_TOKEN _HRESULT_TYPEDEF_(0x80090308L)")]
    public const int SEC_E_INVALID_TOKEN = unchecked((int)(0x80090308));

    [NativeTypeName("#define SEC_E_CANNOT_PACK _HRESULT_TYPEDEF_(0x80090309L)")]
    public const int SEC_E_CANNOT_PACK = unchecked((int)(0x80090309));

    [NativeTypeName("#define SEC_E_QOP_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8009030AL)")]
    public const int SEC_E_QOP_NOT_SUPPORTED = unchecked((int)(0x8009030A));

    [NativeTypeName("#define SEC_E_NO_IMPERSONATION _HRESULT_TYPEDEF_(0x8009030BL)")]
    public const int SEC_E_NO_IMPERSONATION = unchecked((int)(0x8009030B));

    [NativeTypeName("#define SEC_E_LOGON_DENIED _HRESULT_TYPEDEF_(0x8009030CL)")]
    public const int SEC_E_LOGON_DENIED = unchecked((int)(0x8009030C));

    [NativeTypeName("#define SEC_E_UNKNOWN_CREDENTIALS _HRESULT_TYPEDEF_(0x8009030DL)")]
    public const int SEC_E_UNKNOWN_CREDENTIALS = unchecked((int)(0x8009030D));

    [NativeTypeName("#define SEC_E_NO_CREDENTIALS _HRESULT_TYPEDEF_(0x8009030EL)")]
    public const int SEC_E_NO_CREDENTIALS = unchecked((int)(0x8009030E));

    [NativeTypeName("#define SEC_E_MESSAGE_ALTERED _HRESULT_TYPEDEF_(0x8009030FL)")]
    public const int SEC_E_MESSAGE_ALTERED = unchecked((int)(0x8009030F));

    [NativeTypeName("#define SEC_E_OUT_OF_SEQUENCE _HRESULT_TYPEDEF_(0x80090310L)")]
    public const int SEC_E_OUT_OF_SEQUENCE = unchecked((int)(0x80090310));

    [NativeTypeName("#define SEC_E_NO_AUTHENTICATING_AUTHORITY _HRESULT_TYPEDEF_(0x80090311L)")]
    public const int SEC_E_NO_AUTHENTICATING_AUTHORITY = unchecked((int)(0x80090311));

    [NativeTypeName("#define SEC_I_CONTINUE_NEEDED _HRESULT_TYPEDEF_(0x00090312L)")]
    public const int SEC_I_CONTINUE_NEEDED = ((int)(0x00090312));

    [NativeTypeName("#define SEC_I_COMPLETE_NEEDED _HRESULT_TYPEDEF_(0x00090313L)")]
    public const int SEC_I_COMPLETE_NEEDED = ((int)(0x00090313));

    [NativeTypeName("#define SEC_I_COMPLETE_AND_CONTINUE _HRESULT_TYPEDEF_(0x00090314L)")]
    public const int SEC_I_COMPLETE_AND_CONTINUE = ((int)(0x00090314));

    [NativeTypeName("#define SEC_I_LOCAL_LOGON _HRESULT_TYPEDEF_(0x00090315L)")]
    public const int SEC_I_LOCAL_LOGON = ((int)(0x00090315));

    [NativeTypeName("#define SEC_I_GENERIC_EXTENSION_RECEIVED _HRESULT_TYPEDEF_(0x00090316L)")]
    public const int SEC_I_GENERIC_EXTENSION_RECEIVED = ((int)(0x00090316));

    [NativeTypeName("#define SEC_E_BAD_PKGID _HRESULT_TYPEDEF_(0x80090316L)")]
    public const int SEC_E_BAD_PKGID = unchecked((int)(0x80090316));

    [NativeTypeName("#define SEC_E_CONTEXT_EXPIRED _HRESULT_TYPEDEF_(0x80090317L)")]
    public const int SEC_E_CONTEXT_EXPIRED = unchecked((int)(0x80090317));

    [NativeTypeName("#define SEC_I_CONTEXT_EXPIRED _HRESULT_TYPEDEF_(0x00090317L)")]
    public const int SEC_I_CONTEXT_EXPIRED = ((int)(0x00090317));

    [NativeTypeName("#define SEC_E_INCOMPLETE_MESSAGE _HRESULT_TYPEDEF_(0x80090318L)")]
    public const int SEC_E_INCOMPLETE_MESSAGE = unchecked((int)(0x80090318));

    [NativeTypeName("#define SEC_E_INCOMPLETE_CREDENTIALS _HRESULT_TYPEDEF_(0x80090320L)")]
    public const int SEC_E_INCOMPLETE_CREDENTIALS = unchecked((int)(0x80090320));

    [NativeTypeName("#define SEC_E_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x80090321L)")]
    public const int SEC_E_BUFFER_TOO_SMALL = unchecked((int)(0x80090321));

    [NativeTypeName("#define SEC_I_INCOMPLETE_CREDENTIALS _HRESULT_TYPEDEF_(0x00090320L)")]
    public const int SEC_I_INCOMPLETE_CREDENTIALS = ((int)(0x00090320));

    [NativeTypeName("#define SEC_I_RENEGOTIATE _HRESULT_TYPEDEF_(0x00090321L)")]
    public const int SEC_I_RENEGOTIATE = ((int)(0x00090321));

    [NativeTypeName("#define SEC_E_WRONG_PRINCIPAL _HRESULT_TYPEDEF_(0x80090322L)")]
    public const int SEC_E_WRONG_PRINCIPAL = unchecked((int)(0x80090322));

    [NativeTypeName("#define SEC_I_NO_LSA_CONTEXT _HRESULT_TYPEDEF_(0x00090323L)")]
    public const int SEC_I_NO_LSA_CONTEXT = ((int)(0x00090323));

    [NativeTypeName("#define SEC_E_TIME_SKEW _HRESULT_TYPEDEF_(0x80090324L)")]
    public const int SEC_E_TIME_SKEW = unchecked((int)(0x80090324));

    [NativeTypeName("#define SEC_E_UNTRUSTED_ROOT _HRESULT_TYPEDEF_(0x80090325L)")]
    public const int SEC_E_UNTRUSTED_ROOT = unchecked((int)(0x80090325));

    [NativeTypeName("#define SEC_E_ILLEGAL_MESSAGE _HRESULT_TYPEDEF_(0x80090326L)")]
    public const int SEC_E_ILLEGAL_MESSAGE = unchecked((int)(0x80090326));

    [NativeTypeName("#define SEC_E_CERT_UNKNOWN _HRESULT_TYPEDEF_(0x80090327L)")]
    public const int SEC_E_CERT_UNKNOWN = unchecked((int)(0x80090327));

    [NativeTypeName("#define SEC_E_CERT_EXPIRED _HRESULT_TYPEDEF_(0x80090328L)")]
    public const int SEC_E_CERT_EXPIRED = unchecked((int)(0x80090328));

    [NativeTypeName("#define SEC_E_ENCRYPT_FAILURE _HRESULT_TYPEDEF_(0x80090329L)")]
    public const int SEC_E_ENCRYPT_FAILURE = unchecked((int)(0x80090329));

    [NativeTypeName("#define SEC_E_DECRYPT_FAILURE _HRESULT_TYPEDEF_(0x80090330L)")]
    public const int SEC_E_DECRYPT_FAILURE = unchecked((int)(0x80090330));

    [NativeTypeName("#define SEC_E_ALGORITHM_MISMATCH _HRESULT_TYPEDEF_(0x80090331L)")]
    public const int SEC_E_ALGORITHM_MISMATCH = unchecked((int)(0x80090331));

    [NativeTypeName("#define SEC_E_SECURITY_QOS_FAILED _HRESULT_TYPEDEF_(0x80090332L)")]
    public const int SEC_E_SECURITY_QOS_FAILED = unchecked((int)(0x80090332));

    [NativeTypeName("#define SEC_E_UNFINISHED_CONTEXT_DELETED _HRESULT_TYPEDEF_(0x80090333L)")]
    public const int SEC_E_UNFINISHED_CONTEXT_DELETED = unchecked((int)(0x80090333));

    [NativeTypeName("#define SEC_E_NO_TGT_REPLY _HRESULT_TYPEDEF_(0x80090334L)")]
    public const int SEC_E_NO_TGT_REPLY = unchecked((int)(0x80090334));

    [NativeTypeName("#define SEC_E_NO_IP_ADDRESSES _HRESULT_TYPEDEF_(0x80090335L)")]
    public const int SEC_E_NO_IP_ADDRESSES = unchecked((int)(0x80090335));

    [NativeTypeName("#define SEC_E_WRONG_CREDENTIAL_HANDLE _HRESULT_TYPEDEF_(0x80090336L)")]
    public const int SEC_E_WRONG_CREDENTIAL_HANDLE = unchecked((int)(0x80090336));

    [NativeTypeName("#define SEC_E_CRYPTO_SYSTEM_INVALID _HRESULT_TYPEDEF_(0x80090337L)")]
    public const int SEC_E_CRYPTO_SYSTEM_INVALID = unchecked((int)(0x80090337));

    [NativeTypeName("#define SEC_E_MAX_REFERRALS_EXCEEDED _HRESULT_TYPEDEF_(0x80090338L)")]
    public const int SEC_E_MAX_REFERRALS_EXCEEDED = unchecked((int)(0x80090338));

    [NativeTypeName("#define SEC_E_MUST_BE_KDC _HRESULT_TYPEDEF_(0x80090339L)")]
    public const int SEC_E_MUST_BE_KDC = unchecked((int)(0x80090339));

    [NativeTypeName("#define SEC_E_STRONG_CRYPTO_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8009033AL)")]
    public const int SEC_E_STRONG_CRYPTO_NOT_SUPPORTED = unchecked((int)(0x8009033A));

    [NativeTypeName("#define SEC_E_TOO_MANY_PRINCIPALS _HRESULT_TYPEDEF_(0x8009033BL)")]
    public const int SEC_E_TOO_MANY_PRINCIPALS = unchecked((int)(0x8009033B));

    [NativeTypeName("#define SEC_E_NO_PA_DATA _HRESULT_TYPEDEF_(0x8009033CL)")]
    public const int SEC_E_NO_PA_DATA = unchecked((int)(0x8009033C));

    [NativeTypeName("#define SEC_E_PKINIT_NAME_MISMATCH _HRESULT_TYPEDEF_(0x8009033DL)")]
    public const int SEC_E_PKINIT_NAME_MISMATCH = unchecked((int)(0x8009033D));

    [NativeTypeName("#define SEC_E_SMARTCARD_LOGON_REQUIRED _HRESULT_TYPEDEF_(0x8009033EL)")]
    public const int SEC_E_SMARTCARD_LOGON_REQUIRED = unchecked((int)(0x8009033E));

    [NativeTypeName("#define SEC_E_SHUTDOWN_IN_PROGRESS _HRESULT_TYPEDEF_(0x8009033FL)")]
    public const int SEC_E_SHUTDOWN_IN_PROGRESS = unchecked((int)(0x8009033F));

    [NativeTypeName("#define SEC_E_KDC_INVALID_REQUEST _HRESULT_TYPEDEF_(0x80090340L)")]
    public const int SEC_E_KDC_INVALID_REQUEST = unchecked((int)(0x80090340));

    [NativeTypeName("#define SEC_E_KDC_UNABLE_TO_REFER _HRESULT_TYPEDEF_(0x80090341L)")]
    public const int SEC_E_KDC_UNABLE_TO_REFER = unchecked((int)(0x80090341));

    [NativeTypeName("#define SEC_E_KDC_UNKNOWN_ETYPE _HRESULT_TYPEDEF_(0x80090342L)")]
    public const int SEC_E_KDC_UNKNOWN_ETYPE = unchecked((int)(0x80090342));

    [NativeTypeName("#define SEC_E_UNSUPPORTED_PREAUTH _HRESULT_TYPEDEF_(0x80090343L)")]
    public const int SEC_E_UNSUPPORTED_PREAUTH = unchecked((int)(0x80090343));

    [NativeTypeName("#define SEC_E_DELEGATION_REQUIRED _HRESULT_TYPEDEF_(0x80090345L)")]
    public const int SEC_E_DELEGATION_REQUIRED = unchecked((int)(0x80090345));

    [NativeTypeName("#define SEC_E_BAD_BINDINGS _HRESULT_TYPEDEF_(0x80090346L)")]
    public const int SEC_E_BAD_BINDINGS = unchecked((int)(0x80090346));

    [NativeTypeName("#define SEC_E_MULTIPLE_ACCOUNTS _HRESULT_TYPEDEF_(0x80090347L)")]
    public const int SEC_E_MULTIPLE_ACCOUNTS = unchecked((int)(0x80090347));

    [NativeTypeName("#define SEC_E_NO_KERB_KEY _HRESULT_TYPEDEF_(0x80090348L)")]
    public const int SEC_E_NO_KERB_KEY = unchecked((int)(0x80090348));

    [NativeTypeName("#define SEC_E_CERT_WRONG_USAGE _HRESULT_TYPEDEF_(0x80090349L)")]
    public const int SEC_E_CERT_WRONG_USAGE = unchecked((int)(0x80090349));

    [NativeTypeName("#define SEC_E_DOWNGRADE_DETECTED _HRESULT_TYPEDEF_(0x80090350L)")]
    public const int SEC_E_DOWNGRADE_DETECTED = unchecked((int)(0x80090350));

    [NativeTypeName("#define SEC_E_SMARTCARD_CERT_REVOKED _HRESULT_TYPEDEF_(0x80090351L)")]
    public const int SEC_E_SMARTCARD_CERT_REVOKED = unchecked((int)(0x80090351));

    [NativeTypeName("#define SEC_E_ISSUING_CA_UNTRUSTED _HRESULT_TYPEDEF_(0x80090352L)")]
    public const int SEC_E_ISSUING_CA_UNTRUSTED = unchecked((int)(0x80090352));

    [NativeTypeName("#define SEC_E_REVOCATION_OFFLINE_C _HRESULT_TYPEDEF_(0x80090353L)")]
    public const int SEC_E_REVOCATION_OFFLINE_C = unchecked((int)(0x80090353));

    [NativeTypeName("#define SEC_E_PKINIT_CLIENT_FAILURE _HRESULT_TYPEDEF_(0x80090354L)")]
    public const int SEC_E_PKINIT_CLIENT_FAILURE = unchecked((int)(0x80090354));

    [NativeTypeName("#define SEC_E_SMARTCARD_CERT_EXPIRED _HRESULT_TYPEDEF_(0x80090355L)")]
    public const int SEC_E_SMARTCARD_CERT_EXPIRED = unchecked((int)(0x80090355));

    [NativeTypeName("#define SEC_E_NO_S4U_PROT_SUPPORT _HRESULT_TYPEDEF_(0x80090356L)")]
    public const int SEC_E_NO_S4U_PROT_SUPPORT = unchecked((int)(0x80090356));

    [NativeTypeName("#define SEC_E_CROSSREALM_DELEGATION_FAILURE _HRESULT_TYPEDEF_(0x80090357L)")]
    public const int SEC_E_CROSSREALM_DELEGATION_FAILURE = unchecked((int)(0x80090357));

    [NativeTypeName("#define SEC_E_REVOCATION_OFFLINE_KDC _HRESULT_TYPEDEF_(0x80090358L)")]
    public const int SEC_E_REVOCATION_OFFLINE_KDC = unchecked((int)(0x80090358));

    [NativeTypeName("#define SEC_E_ISSUING_CA_UNTRUSTED_KDC _HRESULT_TYPEDEF_(0x80090359L)")]
    public const int SEC_E_ISSUING_CA_UNTRUSTED_KDC = unchecked((int)(0x80090359));

    [NativeTypeName("#define SEC_E_KDC_CERT_EXPIRED _HRESULT_TYPEDEF_(0x8009035AL)")]
    public const int SEC_E_KDC_CERT_EXPIRED = unchecked((int)(0x8009035A));

    [NativeTypeName("#define SEC_E_KDC_CERT_REVOKED _HRESULT_TYPEDEF_(0x8009035BL)")]
    public const int SEC_E_KDC_CERT_REVOKED = unchecked((int)(0x8009035B));

    [NativeTypeName("#define SEC_I_SIGNATURE_NEEDED _HRESULT_TYPEDEF_(0x0009035CL)")]
    public const int SEC_I_SIGNATURE_NEEDED = ((int)(0x0009035C));

    [NativeTypeName("#define SEC_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x8009035DL)")]
    public const int SEC_E_INVALID_PARAMETER = unchecked((int)(0x8009035D));

    [NativeTypeName("#define SEC_E_DELEGATION_POLICY _HRESULT_TYPEDEF_(0x8009035EL)")]
    public const int SEC_E_DELEGATION_POLICY = unchecked((int)(0x8009035E));

    [NativeTypeName("#define SEC_E_POLICY_NLTM_ONLY _HRESULT_TYPEDEF_(0x8009035FL)")]
    public const int SEC_E_POLICY_NLTM_ONLY = unchecked((int)(0x8009035F));

    [NativeTypeName("#define SEC_I_NO_RENEGOTIATION _HRESULT_TYPEDEF_(0x00090360L)")]
    public const int SEC_I_NO_RENEGOTIATION = ((int)(0x00090360));

    [NativeTypeName("#define SEC_E_NO_CONTEXT _HRESULT_TYPEDEF_(0x80090361L)")]
    public const int SEC_E_NO_CONTEXT = unchecked((int)(0x80090361));

    [NativeTypeName("#define SEC_E_PKU2U_CERT_FAILURE _HRESULT_TYPEDEF_(0x80090362L)")]
    public const int SEC_E_PKU2U_CERT_FAILURE = unchecked((int)(0x80090362));

    [NativeTypeName("#define SEC_E_MUTUAL_AUTH_FAILED _HRESULT_TYPEDEF_(0x80090363L)")]
    public const int SEC_E_MUTUAL_AUTH_FAILED = unchecked((int)(0x80090363));

    [NativeTypeName("#define SEC_I_MESSAGE_FRAGMENT _HRESULT_TYPEDEF_(0x00090364L)")]
    public const int SEC_I_MESSAGE_FRAGMENT = ((int)(0x00090364));

    [NativeTypeName("#define SEC_E_ONLY_HTTPS_ALLOWED _HRESULT_TYPEDEF_(0x80090365L)")]
    public const int SEC_E_ONLY_HTTPS_ALLOWED = unchecked((int)(0x80090365));

    [NativeTypeName("#define SEC_I_CONTINUE_NEEDED_MESSAGE_OK _HRESULT_TYPEDEF_(0x00090366L)")]
    public const int SEC_I_CONTINUE_NEEDED_MESSAGE_OK = ((int)(0x00090366));

    [NativeTypeName("#define SEC_E_APPLICATION_PROTOCOL_MISMATCH _HRESULT_TYPEDEF_(0x80090367L)")]
    public const int SEC_E_APPLICATION_PROTOCOL_MISMATCH = unchecked((int)(0x80090367));

    [NativeTypeName("#define SEC_I_ASYNC_CALL_PENDING _HRESULT_TYPEDEF_(0x00090368L)")]
    public const int SEC_I_ASYNC_CALL_PENDING = ((int)(0x00090368));

    [NativeTypeName("#define SEC_E_INVALID_UPN_NAME _HRESULT_TYPEDEF_(0x80090369L)")]
    public const int SEC_E_INVALID_UPN_NAME = unchecked((int)(0x80090369));

    [NativeTypeName("#define SEC_E_EXT_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x8009036AL)")]
    public const int SEC_E_EXT_BUFFER_TOO_SMALL = unchecked((int)(0x8009036A));

    [NativeTypeName("#define SEC_E_INSUFFICIENT_BUFFERS _HRESULT_TYPEDEF_(0x8009036BL)")]
    public const int SEC_E_INSUFFICIENT_BUFFERS = unchecked((int)(0x8009036B));

    [NativeTypeName("#define SEC_E_NO_SPM SEC_E_INTERNAL_ERROR")]
    public const int SEC_E_NO_SPM = unchecked((int)(0x80090304));

    [NativeTypeName("#define SEC_E_NOT_SUPPORTED SEC_E_UNSUPPORTED_FUNCTION")]
    public const int SEC_E_NOT_SUPPORTED = unchecked((int)(0x80090302));
}
