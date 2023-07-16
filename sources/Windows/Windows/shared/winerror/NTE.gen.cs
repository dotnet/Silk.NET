// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class NTE
{
    [NativeTypeName("#define NTE_BAD_UID _HRESULT_TYPEDEF_(0x80090001L)")]
    public const int NTE_BAD_UID = unchecked((int)(0x80090001));
    [NativeTypeName("#define NTE_BAD_HASH _HRESULT_TYPEDEF_(0x80090002L)")]
    public const int NTE_BAD_HASH = unchecked((int)(0x80090002));
    [NativeTypeName("#define NTE_BAD_KEY _HRESULT_TYPEDEF_(0x80090003L)")]
    public const int NTE_BAD_KEY = unchecked((int)(0x80090003));
    [NativeTypeName("#define NTE_BAD_LEN _HRESULT_TYPEDEF_(0x80090004L)")]
    public const int NTE_BAD_LEN = unchecked((int)(0x80090004));
    [NativeTypeName("#define NTE_BAD_DATA _HRESULT_TYPEDEF_(0x80090005L)")]
    public const int NTE_BAD_DATA = unchecked((int)(0x80090005));
    [NativeTypeName("#define NTE_BAD_SIGNATURE _HRESULT_TYPEDEF_(0x80090006L)")]
    public const int NTE_BAD_SIGNATURE = unchecked((int)(0x80090006));
    [NativeTypeName("#define NTE_BAD_VER _HRESULT_TYPEDEF_(0x80090007L)")]
    public const int NTE_BAD_VER = unchecked((int)(0x80090007));
    [NativeTypeName("#define NTE_BAD_ALGID _HRESULT_TYPEDEF_(0x80090008L)")]
    public const int NTE_BAD_ALGID = unchecked((int)(0x80090008));
    [NativeTypeName("#define NTE_BAD_FLAGS _HRESULT_TYPEDEF_(0x80090009L)")]
    public const int NTE_BAD_FLAGS = unchecked((int)(0x80090009));
    [NativeTypeName("#define NTE_BAD_TYPE _HRESULT_TYPEDEF_(0x8009000AL)")]
    public const int NTE_BAD_TYPE = unchecked((int)(0x8009000A));
    [NativeTypeName("#define NTE_BAD_KEY_STATE _HRESULT_TYPEDEF_(0x8009000BL)")]
    public const int NTE_BAD_KEY_STATE = unchecked((int)(0x8009000B));
    [NativeTypeName("#define NTE_BAD_HASH_STATE _HRESULT_TYPEDEF_(0x8009000CL)")]
    public const int NTE_BAD_HASH_STATE = unchecked((int)(0x8009000C));
    [NativeTypeName("#define NTE_NO_KEY _HRESULT_TYPEDEF_(0x8009000DL)")]
    public const int NTE_NO_KEY = unchecked((int)(0x8009000D));
    [NativeTypeName("#define NTE_NO_MEMORY _HRESULT_TYPEDEF_(0x8009000EL)")]
    public const int NTE_NO_MEMORY = unchecked((int)(0x8009000E));
    [NativeTypeName("#define NTE_EXISTS _HRESULT_TYPEDEF_(0x8009000FL)")]
    public const int NTE_EXISTS = unchecked((int)(0x8009000F));
    [NativeTypeName("#define NTE_PERM _HRESULT_TYPEDEF_(0x80090010L)")]
    public const int NTE_PERM = unchecked((int)(0x80090010));
    [NativeTypeName("#define NTE_NOT_FOUND _HRESULT_TYPEDEF_(0x80090011L)")]
    public const int NTE_NOT_FOUND = unchecked((int)(0x80090011));
    [NativeTypeName("#define NTE_DOUBLE_ENCRYPT _HRESULT_TYPEDEF_(0x80090012L)")]
    public const int NTE_DOUBLE_ENCRYPT = unchecked((int)(0x80090012));
    [NativeTypeName("#define NTE_BAD_PROVIDER _HRESULT_TYPEDEF_(0x80090013L)")]
    public const int NTE_BAD_PROVIDER = unchecked((int)(0x80090013));
    [NativeTypeName("#define NTE_BAD_PROV_TYPE _HRESULT_TYPEDEF_(0x80090014L)")]
    public const int NTE_BAD_PROV_TYPE = unchecked((int)(0x80090014));
    [NativeTypeName("#define NTE_BAD_PUBLIC_KEY _HRESULT_TYPEDEF_(0x80090015L)")]
    public const int NTE_BAD_PUBLIC_KEY = unchecked((int)(0x80090015));
    [NativeTypeName("#define NTE_BAD_KEYSET _HRESULT_TYPEDEF_(0x80090016L)")]
    public const int NTE_BAD_KEYSET = unchecked((int)(0x80090016));
    [NativeTypeName("#define NTE_PROV_TYPE_NOT_DEF _HRESULT_TYPEDEF_(0x80090017L)")]
    public const int NTE_PROV_TYPE_NOT_DEF = unchecked((int)(0x80090017));
    [NativeTypeName("#define NTE_PROV_TYPE_ENTRY_BAD _HRESULT_TYPEDEF_(0x80090018L)")]
    public const int NTE_PROV_TYPE_ENTRY_BAD = unchecked((int)(0x80090018));
    [NativeTypeName("#define NTE_KEYSET_NOT_DEF _HRESULT_TYPEDEF_(0x80090019L)")]
    public const int NTE_KEYSET_NOT_DEF = unchecked((int)(0x80090019));
    [NativeTypeName("#define NTE_KEYSET_ENTRY_BAD _HRESULT_TYPEDEF_(0x8009001AL)")]
    public const int NTE_KEYSET_ENTRY_BAD = unchecked((int)(0x8009001A));
    [NativeTypeName("#define NTE_PROV_TYPE_NO_MATCH _HRESULT_TYPEDEF_(0x8009001BL)")]
    public const int NTE_PROV_TYPE_NO_MATCH = unchecked((int)(0x8009001B));
    [NativeTypeName("#define NTE_SIGNATURE_FILE_BAD _HRESULT_TYPEDEF_(0x8009001CL)")]
    public const int NTE_SIGNATURE_FILE_BAD = unchecked((int)(0x8009001C));
    [NativeTypeName("#define NTE_PROVIDER_DLL_FAIL _HRESULT_TYPEDEF_(0x8009001DL)")]
    public const int NTE_PROVIDER_DLL_FAIL = unchecked((int)(0x8009001D));
    [NativeTypeName("#define NTE_PROV_DLL_NOT_FOUND _HRESULT_TYPEDEF_(0x8009001EL)")]
    public const int NTE_PROV_DLL_NOT_FOUND = unchecked((int)(0x8009001E));
    [NativeTypeName("#define NTE_BAD_KEYSET_PARAM _HRESULT_TYPEDEF_(0x8009001FL)")]
    public const int NTE_BAD_KEYSET_PARAM = unchecked((int)(0x8009001F));
    [NativeTypeName("#define NTE_FAIL _HRESULT_TYPEDEF_(0x80090020L)")]
    public const int NTE_FAIL = unchecked((int)(0x80090020));
    [NativeTypeName("#define NTE_SYS_ERR _HRESULT_TYPEDEF_(0x80090021L)")]
    public const int NTE_SYS_ERR = unchecked((int)(0x80090021));
    [NativeTypeName("#define NTE_SILENT_CONTEXT _HRESULT_TYPEDEF_(0x80090022L)")]
    public const int NTE_SILENT_CONTEXT = unchecked((int)(0x80090022));
    [NativeTypeName("#define NTE_TOKEN_KEYSET_STORAGE_FULL _HRESULT_TYPEDEF_(0x80090023L)")]
    public const int NTE_TOKEN_KEYSET_STORAGE_FULL = unchecked((int)(0x80090023));
    [NativeTypeName("#define NTE_TEMPORARY_PROFILE _HRESULT_TYPEDEF_(0x80090024L)")]
    public const int NTE_TEMPORARY_PROFILE = unchecked((int)(0x80090024));
    [NativeTypeName("#define NTE_FIXEDPARAMETER _HRESULT_TYPEDEF_(0x80090025L)")]
    public const int NTE_FIXEDPARAMETER = unchecked((int)(0x80090025));
    [NativeTypeName("#define NTE_INVALID_HANDLE _HRESULT_TYPEDEF_(0x80090026L)")]
    public const int NTE_INVALID_HANDLE = unchecked((int)(0x80090026));
    [NativeTypeName("#define NTE_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80090027L)")]
    public const int NTE_INVALID_PARAMETER = unchecked((int)(0x80090027));
    [NativeTypeName("#define NTE_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x80090028L)")]
    public const int NTE_BUFFER_TOO_SMALL = unchecked((int)(0x80090028));
    [NativeTypeName("#define NTE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80090029L)")]
    public const int NTE_NOT_SUPPORTED = unchecked((int)(0x80090029));
    [NativeTypeName("#define NTE_NO_MORE_ITEMS _HRESULT_TYPEDEF_(0x8009002AL)")]
    public const int NTE_NO_MORE_ITEMS = unchecked((int)(0x8009002A));
    [NativeTypeName("#define NTE_BUFFERS_OVERLAP _HRESULT_TYPEDEF_(0x8009002BL)")]
    public const int NTE_BUFFERS_OVERLAP = unchecked((int)(0x8009002B));
    [NativeTypeName("#define NTE_DECRYPTION_FAILURE _HRESULT_TYPEDEF_(0x8009002CL)")]
    public const int NTE_DECRYPTION_FAILURE = unchecked((int)(0x8009002C));
    [NativeTypeName("#define NTE_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x8009002DL)")]
    public const int NTE_INTERNAL_ERROR = unchecked((int)(0x8009002D));
    [NativeTypeName("#define NTE_UI_REQUIRED _HRESULT_TYPEDEF_(0x8009002EL)")]
    public const int NTE_UI_REQUIRED = unchecked((int)(0x8009002E));
    [NativeTypeName("#define NTE_HMAC_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8009002FL)")]
    public const int NTE_HMAC_NOT_SUPPORTED = unchecked((int)(0x8009002F));
    [NativeTypeName("#define NTE_DEVICE_NOT_READY _HRESULT_TYPEDEF_(0x80090030L)")]
    public const int NTE_DEVICE_NOT_READY = unchecked((int)(0x80090030));
    [NativeTypeName("#define NTE_AUTHENTICATION_IGNORED _HRESULT_TYPEDEF_(0x80090031L)")]
    public const int NTE_AUTHENTICATION_IGNORED = unchecked((int)(0x80090031));
    [NativeTypeName("#define NTE_VALIDATION_FAILED _HRESULT_TYPEDEF_(0x80090032L)")]
    public const int NTE_VALIDATION_FAILED = unchecked((int)(0x80090032));
    [NativeTypeName("#define NTE_INCORRECT_PASSWORD _HRESULT_TYPEDEF_(0x80090033L)")]
    public const int NTE_INCORRECT_PASSWORD = unchecked((int)(0x80090033));
    [NativeTypeName("#define NTE_ENCRYPTION_FAILURE _HRESULT_TYPEDEF_(0x80090034L)")]
    public const int NTE_ENCRYPTION_FAILURE = unchecked((int)(0x80090034));
    [NativeTypeName("#define NTE_DEVICE_NOT_FOUND _HRESULT_TYPEDEF_(0x80090035L)")]
    public const int NTE_DEVICE_NOT_FOUND = unchecked((int)(0x80090035));
    [NativeTypeName("#define NTE_USER_CANCELLED _HRESULT_TYPEDEF_(0x80090036L)")]
    public const int NTE_USER_CANCELLED = unchecked((int)(0x80090036));
    [NativeTypeName("#define NTE_PASSWORD_CHANGE_REQUIRED _HRESULT_TYPEDEF_(0x80090037L)")]
    public const int NTE_PASSWORD_CHANGE_REQUIRED = unchecked((int)(0x80090037));
    [NativeTypeName("#define NTE_NOT_ACTIVE_CONSOLE _HRESULT_TYPEDEF_(0x80090038L)")]
    public const int NTE_NOT_ACTIVE_CONSOLE = unchecked((int)(0x80090038));
    [NativeTypeName("#define NTE_OP_OK 0")]
    public const int NTE_OP_OK = 0;
}