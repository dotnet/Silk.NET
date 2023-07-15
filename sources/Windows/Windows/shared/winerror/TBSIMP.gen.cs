// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class TBSIMP
{
    [NativeTypeName("#define TBSIMP_E_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x80290200L)")]
    public const int TBSIMP_E_BUFFER_TOO_SMALL = unchecked((int)(0x80290200));
    [NativeTypeName("#define TBSIMP_E_CLEANUP_FAILED _HRESULT_TYPEDEF_(0x80290201L)")]
    public const int TBSIMP_E_CLEANUP_FAILED = unchecked((int)(0x80290201));
    [NativeTypeName("#define TBSIMP_E_INVALID_CONTEXT_HANDLE _HRESULT_TYPEDEF_(0x80290202L)")]
    public const int TBSIMP_E_INVALID_CONTEXT_HANDLE = unchecked((int)(0x80290202));
    [NativeTypeName("#define TBSIMP_E_INVALID_CONTEXT_PARAM _HRESULT_TYPEDEF_(0x80290203L)")]
    public const int TBSIMP_E_INVALID_CONTEXT_PARAM = unchecked((int)(0x80290203));
    [NativeTypeName("#define TBSIMP_E_TPM_ERROR _HRESULT_TYPEDEF_(0x80290204L)")]
    public const int TBSIMP_E_TPM_ERROR = unchecked((int)(0x80290204));
    [NativeTypeName("#define TBSIMP_E_HASH_BAD_KEY _HRESULT_TYPEDEF_(0x80290205L)")]
    public const int TBSIMP_E_HASH_BAD_KEY = unchecked((int)(0x80290205));
    [NativeTypeName("#define TBSIMP_E_DUPLICATE_VHANDLE _HRESULT_TYPEDEF_(0x80290206L)")]
    public const int TBSIMP_E_DUPLICATE_VHANDLE = unchecked((int)(0x80290206));
    [NativeTypeName("#define TBSIMP_E_INVALID_OUTPUT_POINTER _HRESULT_TYPEDEF_(0x80290207L)")]
    public const int TBSIMP_E_INVALID_OUTPUT_POINTER = unchecked((int)(0x80290207));
    [NativeTypeName("#define TBSIMP_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80290208L)")]
    public const int TBSIMP_E_INVALID_PARAMETER = unchecked((int)(0x80290208));
    [NativeTypeName("#define TBSIMP_E_RPC_INIT_FAILED _HRESULT_TYPEDEF_(0x80290209L)")]
    public const int TBSIMP_E_RPC_INIT_FAILED = unchecked((int)(0x80290209));
    [NativeTypeName("#define TBSIMP_E_SCHEDULER_NOT_RUNNING _HRESULT_TYPEDEF_(0x8029020AL)")]
    public const int TBSIMP_E_SCHEDULER_NOT_RUNNING = unchecked((int)(0x8029020A));
    [NativeTypeName("#define TBSIMP_E_COMMAND_CANCELED _HRESULT_TYPEDEF_(0x8029020BL)")]
    public const int TBSIMP_E_COMMAND_CANCELED = unchecked((int)(0x8029020B));
    [NativeTypeName("#define TBSIMP_E_OUT_OF_MEMORY _HRESULT_TYPEDEF_(0x8029020CL)")]
    public const int TBSIMP_E_OUT_OF_MEMORY = unchecked((int)(0x8029020C));
    [NativeTypeName("#define TBSIMP_E_LIST_NO_MORE_ITEMS _HRESULT_TYPEDEF_(0x8029020DL)")]
    public const int TBSIMP_E_LIST_NO_MORE_ITEMS = unchecked((int)(0x8029020D));
    [NativeTypeName("#define TBSIMP_E_LIST_NOT_FOUND _HRESULT_TYPEDEF_(0x8029020EL)")]
    public const int TBSIMP_E_LIST_NOT_FOUND = unchecked((int)(0x8029020E));
    [NativeTypeName("#define TBSIMP_E_NOT_ENOUGH_SPACE _HRESULT_TYPEDEF_(0x8029020FL)")]
    public const int TBSIMP_E_NOT_ENOUGH_SPACE = unchecked((int)(0x8029020F));
    [NativeTypeName("#define TBSIMP_E_NOT_ENOUGH_TPM_CONTEXTS _HRESULT_TYPEDEF_(0x80290210L)")]
    public const int TBSIMP_E_NOT_ENOUGH_TPM_CONTEXTS = unchecked((int)(0x80290210));
    [NativeTypeName("#define TBSIMP_E_COMMAND_FAILED _HRESULT_TYPEDEF_(0x80290211L)")]
    public const int TBSIMP_E_COMMAND_FAILED = unchecked((int)(0x80290211));
    [NativeTypeName("#define TBSIMP_E_UNKNOWN_ORDINAL _HRESULT_TYPEDEF_(0x80290212L)")]
    public const int TBSIMP_E_UNKNOWN_ORDINAL = unchecked((int)(0x80290212));
    [NativeTypeName("#define TBSIMP_E_RESOURCE_EXPIRED _HRESULT_TYPEDEF_(0x80290213L)")]
    public const int TBSIMP_E_RESOURCE_EXPIRED = unchecked((int)(0x80290213));
    [NativeTypeName("#define TBSIMP_E_INVALID_RESOURCE _HRESULT_TYPEDEF_(0x80290214L)")]
    public const int TBSIMP_E_INVALID_RESOURCE = unchecked((int)(0x80290214));
    [NativeTypeName("#define TBSIMP_E_NOTHING_TO_UNLOAD _HRESULT_TYPEDEF_(0x80290215L)")]
    public const int TBSIMP_E_NOTHING_TO_UNLOAD = unchecked((int)(0x80290215));
    [NativeTypeName("#define TBSIMP_E_HASH_TABLE_FULL _HRESULT_TYPEDEF_(0x80290216L)")]
    public const int TBSIMP_E_HASH_TABLE_FULL = unchecked((int)(0x80290216));
    [NativeTypeName("#define TBSIMP_E_TOO_MANY_TBS_CONTEXTS _HRESULT_TYPEDEF_(0x80290217L)")]
    public const int TBSIMP_E_TOO_MANY_TBS_CONTEXTS = unchecked((int)(0x80290217));
    [NativeTypeName("#define TBSIMP_E_TOO_MANY_RESOURCES _HRESULT_TYPEDEF_(0x80290218L)")]
    public const int TBSIMP_E_TOO_MANY_RESOURCES = unchecked((int)(0x80290218));
    [NativeTypeName("#define TBSIMP_E_PPI_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80290219L)")]
    public const int TBSIMP_E_PPI_NOT_SUPPORTED = unchecked((int)(0x80290219));
    [NativeTypeName("#define TBSIMP_E_TPM_INCOMPATIBLE _HRESULT_TYPEDEF_(0x8029021AL)")]
    public const int TBSIMP_E_TPM_INCOMPATIBLE = unchecked((int)(0x8029021A));
    [NativeTypeName("#define TBSIMP_E_NO_EVENT_LOG _HRESULT_TYPEDEF_(0x8029021BL)")]
    public const int TBSIMP_E_NO_EVENT_LOG = unchecked((int)(0x8029021B));
}