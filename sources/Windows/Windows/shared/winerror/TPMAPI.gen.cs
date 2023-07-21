// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class TPMAPI
{
    [NativeTypeName("#define TPMAPI_E_INVALID_STATE _HRESULT_TYPEDEF_(0x80290100L)")]
    public const int TPMAPI_E_INVALID_STATE = unchecked((int)(0x80290100));

    [NativeTypeName("#define TPMAPI_E_NOT_ENOUGH_DATA _HRESULT_TYPEDEF_(0x80290101L)")]
    public const int TPMAPI_E_NOT_ENOUGH_DATA = unchecked((int)(0x80290101));

    [NativeTypeName("#define TPMAPI_E_TOO_MUCH_DATA _HRESULT_TYPEDEF_(0x80290102L)")]
    public const int TPMAPI_E_TOO_MUCH_DATA = unchecked((int)(0x80290102));

    [NativeTypeName("#define TPMAPI_E_INVALID_OUTPUT_POINTER _HRESULT_TYPEDEF_(0x80290103L)")]
    public const int TPMAPI_E_INVALID_OUTPUT_POINTER = unchecked((int)(0x80290103));

    [NativeTypeName("#define TPMAPI_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80290104L)")]
    public const int TPMAPI_E_INVALID_PARAMETER = unchecked((int)(0x80290104));

    [NativeTypeName("#define TPMAPI_E_OUT_OF_MEMORY _HRESULT_TYPEDEF_(0x80290105L)")]
    public const int TPMAPI_E_OUT_OF_MEMORY = unchecked((int)(0x80290105));

    [NativeTypeName("#define TPMAPI_E_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x80290106L)")]
    public const int TPMAPI_E_BUFFER_TOO_SMALL = unchecked((int)(0x80290106));

    [NativeTypeName("#define TPMAPI_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80290107L)")]
    public const int TPMAPI_E_INTERNAL_ERROR = unchecked((int)(0x80290107));

    [NativeTypeName("#define TPMAPI_E_ACCESS_DENIED _HRESULT_TYPEDEF_(0x80290108L)")]
    public const int TPMAPI_E_ACCESS_DENIED = unchecked((int)(0x80290108));

    [NativeTypeName("#define TPMAPI_E_AUTHORIZATION_FAILED _HRESULT_TYPEDEF_(0x80290109L)")]
    public const int TPMAPI_E_AUTHORIZATION_FAILED = unchecked((int)(0x80290109));

    [NativeTypeName("#define TPMAPI_E_INVALID_CONTEXT_HANDLE _HRESULT_TYPEDEF_(0x8029010AL)")]
    public const int TPMAPI_E_INVALID_CONTEXT_HANDLE = unchecked((int)(0x8029010A));

    [NativeTypeName("#define TPMAPI_E_TBS_COMMUNICATION_ERROR _HRESULT_TYPEDEF_(0x8029010BL)")]
    public const int TPMAPI_E_TBS_COMMUNICATION_ERROR = unchecked((int)(0x8029010B));

    [NativeTypeName("#define TPMAPI_E_TPM_COMMAND_ERROR _HRESULT_TYPEDEF_(0x8029010CL)")]
    public const int TPMAPI_E_TPM_COMMAND_ERROR = unchecked((int)(0x8029010C));

    [NativeTypeName("#define TPMAPI_E_MESSAGE_TOO_LARGE _HRESULT_TYPEDEF_(0x8029010DL)")]
    public const int TPMAPI_E_MESSAGE_TOO_LARGE = unchecked((int)(0x8029010D));

    [NativeTypeName("#define TPMAPI_E_INVALID_ENCODING _HRESULT_TYPEDEF_(0x8029010EL)")]
    public const int TPMAPI_E_INVALID_ENCODING = unchecked((int)(0x8029010E));

    [NativeTypeName("#define TPMAPI_E_INVALID_KEY_SIZE _HRESULT_TYPEDEF_(0x8029010FL)")]
    public const int TPMAPI_E_INVALID_KEY_SIZE = unchecked((int)(0x8029010F));

    [NativeTypeName("#define TPMAPI_E_ENCRYPTION_FAILED _HRESULT_TYPEDEF_(0x80290110L)")]
    public const int TPMAPI_E_ENCRYPTION_FAILED = unchecked((int)(0x80290110));

    [NativeTypeName("#define TPMAPI_E_INVALID_KEY_PARAMS _HRESULT_TYPEDEF_(0x80290111L)")]
    public const int TPMAPI_E_INVALID_KEY_PARAMS = unchecked((int)(0x80290111));

    [NativeTypeName("#define TPMAPI_E_INVALID_MIGRATION_AUTHORIZATION_BLOB _HRESULT_TYPEDEF_(0x80290112L)")]
    public const int TPMAPI_E_INVALID_MIGRATION_AUTHORIZATION_BLOB = unchecked((int)(0x80290112));

    [NativeTypeName("#define TPMAPI_E_INVALID_PCR_INDEX _HRESULT_TYPEDEF_(0x80290113L)")]
    public const int TPMAPI_E_INVALID_PCR_INDEX = unchecked((int)(0x80290113));

    [NativeTypeName("#define TPMAPI_E_INVALID_DELEGATE_BLOB _HRESULT_TYPEDEF_(0x80290114L)")]
    public const int TPMAPI_E_INVALID_DELEGATE_BLOB = unchecked((int)(0x80290114));

    [NativeTypeName("#define TPMAPI_E_INVALID_CONTEXT_PARAMS _HRESULT_TYPEDEF_(0x80290115L)")]
    public const int TPMAPI_E_INVALID_CONTEXT_PARAMS = unchecked((int)(0x80290115));

    [NativeTypeName("#define TPMAPI_E_INVALID_KEY_BLOB _HRESULT_TYPEDEF_(0x80290116L)")]
    public const int TPMAPI_E_INVALID_KEY_BLOB = unchecked((int)(0x80290116));

    [NativeTypeName("#define TPMAPI_E_INVALID_PCR_DATA _HRESULT_TYPEDEF_(0x80290117L)")]
    public const int TPMAPI_E_INVALID_PCR_DATA = unchecked((int)(0x80290117));

    [NativeTypeName("#define TPMAPI_E_INVALID_OWNER_AUTH _HRESULT_TYPEDEF_(0x80290118L)")]
    public const int TPMAPI_E_INVALID_OWNER_AUTH = unchecked((int)(0x80290118));

    [NativeTypeName("#define TPMAPI_E_FIPS_RNG_CHECK_FAILED _HRESULT_TYPEDEF_(0x80290119L)")]
    public const int TPMAPI_E_FIPS_RNG_CHECK_FAILED = unchecked((int)(0x80290119));

    [NativeTypeName("#define TPMAPI_E_EMPTY_TCG_LOG _HRESULT_TYPEDEF_(0x8029011AL)")]
    public const int TPMAPI_E_EMPTY_TCG_LOG = unchecked((int)(0x8029011A));

    [NativeTypeName("#define TPMAPI_E_INVALID_TCG_LOG_ENTRY _HRESULT_TYPEDEF_(0x8029011BL)")]
    public const int TPMAPI_E_INVALID_TCG_LOG_ENTRY = unchecked((int)(0x8029011B));

    [NativeTypeName("#define TPMAPI_E_TCG_SEPARATOR_ABSENT _HRESULT_TYPEDEF_(0x8029011CL)")]
    public const int TPMAPI_E_TCG_SEPARATOR_ABSENT = unchecked((int)(0x8029011C));

    [NativeTypeName("#define TPMAPI_E_TCG_INVALID_DIGEST_ENTRY _HRESULT_TYPEDEF_(0x8029011DL)")]
    public const int TPMAPI_E_TCG_INVALID_DIGEST_ENTRY = unchecked((int)(0x8029011D));

    [NativeTypeName("#define TPMAPI_E_POLICY_DENIES_OPERATION _HRESULT_TYPEDEF_(0x8029011EL)")]
    public const int TPMAPI_E_POLICY_DENIES_OPERATION = unchecked((int)(0x8029011E));

    [NativeTypeName("#define TPMAPI_E_NV_BITS_NOT_DEFINED _HRESULT_TYPEDEF_(0x8029011FL)")]
    public const int TPMAPI_E_NV_BITS_NOT_DEFINED = unchecked((int)(0x8029011F));

    [NativeTypeName("#define TPMAPI_E_NV_BITS_NOT_READY _HRESULT_TYPEDEF_(0x80290120L)")]
    public const int TPMAPI_E_NV_BITS_NOT_READY = unchecked((int)(0x80290120));

    [NativeTypeName("#define TPMAPI_E_SEALING_KEY_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80290121L)")]
    public const int TPMAPI_E_SEALING_KEY_NOT_AVAILABLE = unchecked((int)(0x80290121));

    [NativeTypeName("#define TPMAPI_E_NO_AUTHORIZATION_CHAIN_FOUND _HRESULT_TYPEDEF_(0x80290122L)")]
    public const int TPMAPI_E_NO_AUTHORIZATION_CHAIN_FOUND = unchecked((int)(0x80290122));

    [NativeTypeName("#define TPMAPI_E_SVN_COUNTER_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80290123L)")]
    public const int TPMAPI_E_SVN_COUNTER_NOT_AVAILABLE = unchecked((int)(0x80290123));

    [NativeTypeName("#define TPMAPI_E_OWNER_AUTH_NOT_NULL _HRESULT_TYPEDEF_(0x80290124L)")]
    public const int TPMAPI_E_OWNER_AUTH_NOT_NULL = unchecked((int)(0x80290124));

    [NativeTypeName("#define TPMAPI_E_ENDORSEMENT_AUTH_NOT_NULL _HRESULT_TYPEDEF_(0x80290125L)")]
    public const int TPMAPI_E_ENDORSEMENT_AUTH_NOT_NULL = unchecked((int)(0x80290125));

    [NativeTypeName("#define TPMAPI_E_AUTHORIZATION_REVOKED _HRESULT_TYPEDEF_(0x80290126L)")]
    public const int TPMAPI_E_AUTHORIZATION_REVOKED = unchecked((int)(0x80290126));

    [NativeTypeName("#define TPMAPI_E_MALFORMED_AUTHORIZATION_KEY _HRESULT_TYPEDEF_(0x80290127L)")]
    public const int TPMAPI_E_MALFORMED_AUTHORIZATION_KEY = unchecked((int)(0x80290127));

    [NativeTypeName("#define TPMAPI_E_AUTHORIZING_KEY_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80290128L)")]
    public const int TPMAPI_E_AUTHORIZING_KEY_NOT_SUPPORTED = unchecked((int)(0x80290128));

    [NativeTypeName("#define TPMAPI_E_INVALID_AUTHORIZATION_SIGNATURE _HRESULT_TYPEDEF_(0x80290129L)")]
    public const int TPMAPI_E_INVALID_AUTHORIZATION_SIGNATURE = unchecked((int)(0x80290129));

    [NativeTypeName("#define TPMAPI_E_MALFORMED_AUTHORIZATION_POLICY _HRESULT_TYPEDEF_(0x8029012AL)")]
    public const int TPMAPI_E_MALFORMED_AUTHORIZATION_POLICY = unchecked((int)(0x8029012A));

    [NativeTypeName("#define TPMAPI_E_MALFORMED_AUTHORIZATION_OTHER _HRESULT_TYPEDEF_(0x8029012BL)")]
    public const int TPMAPI_E_MALFORMED_AUTHORIZATION_OTHER = unchecked((int)(0x8029012B));

    [NativeTypeName("#define TPMAPI_E_SEALING_KEY_CHANGED _HRESULT_TYPEDEF_(0x8029012CL)")]
    public const int TPMAPI_E_SEALING_KEY_CHANGED = unchecked((int)(0x8029012C));

    [NativeTypeName("#define TPMAPI_E_INVALID_TPM_VERSION _HRESULT_TYPEDEF_(0x8029012DL)")]
    public const int TPMAPI_E_INVALID_TPM_VERSION = unchecked((int)(0x8029012D));

    [NativeTypeName("#define TPMAPI_E_INVALID_POLICYAUTH_BLOB_TYPE _HRESULT_TYPEDEF_(0x8029012EL)")]
    public const int TPMAPI_E_INVALID_POLICYAUTH_BLOB_TYPE = unchecked((int)(0x8029012E));
}
