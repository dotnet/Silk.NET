// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class OSS
{
    [NativeTypeName("#define OSS_MORE_BUF _HRESULT_TYPEDEF_(0x80093001L)")]
    public const int OSS_MORE_BUF = unchecked((int)(0x80093001));

    [NativeTypeName("#define OSS_NEGATIVE_UINTEGER _HRESULT_TYPEDEF_(0x80093002L)")]
    public const int OSS_NEGATIVE_UINTEGER = unchecked((int)(0x80093002));

    [NativeTypeName("#define OSS_PDU_RANGE _HRESULT_TYPEDEF_(0x80093003L)")]
    public const int OSS_PDU_RANGE = unchecked((int)(0x80093003));

    [NativeTypeName("#define OSS_MORE_INPUT _HRESULT_TYPEDEF_(0x80093004L)")]
    public const int OSS_MORE_INPUT = unchecked((int)(0x80093004));

    [NativeTypeName("#define OSS_DATA_ERROR _HRESULT_TYPEDEF_(0x80093005L)")]
    public const int OSS_DATA_ERROR = unchecked((int)(0x80093005));

    [NativeTypeName("#define OSS_BAD_ARG _HRESULT_TYPEDEF_(0x80093006L)")]
    public const int OSS_BAD_ARG = unchecked((int)(0x80093006));

    [NativeTypeName("#define OSS_BAD_VERSION _HRESULT_TYPEDEF_(0x80093007L)")]
    public const int OSS_BAD_VERSION = unchecked((int)(0x80093007));

    [NativeTypeName("#define OSS_OUT_MEMORY _HRESULT_TYPEDEF_(0x80093008L)")]
    public const int OSS_OUT_MEMORY = unchecked((int)(0x80093008));

    [NativeTypeName("#define OSS_PDU_MISMATCH _HRESULT_TYPEDEF_(0x80093009L)")]
    public const int OSS_PDU_MISMATCH = unchecked((int)(0x80093009));

    [NativeTypeName("#define OSS_LIMITED _HRESULT_TYPEDEF_(0x8009300AL)")]
    public const int OSS_LIMITED = unchecked((int)(0x8009300A));

    [NativeTypeName("#define OSS_BAD_PTR _HRESULT_TYPEDEF_(0x8009300BL)")]
    public const int OSS_BAD_PTR = unchecked((int)(0x8009300B));

    [NativeTypeName("#define OSS_BAD_TIME _HRESULT_TYPEDEF_(0x8009300CL)")]
    public const int OSS_BAD_TIME = unchecked((int)(0x8009300C));

    [NativeTypeName("#define OSS_INDEFINITE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8009300DL)")]
    public const int OSS_INDEFINITE_NOT_SUPPORTED = unchecked((int)(0x8009300D));

    [NativeTypeName("#define OSS_MEM_ERROR _HRESULT_TYPEDEF_(0x8009300EL)")]
    public const int OSS_MEM_ERROR = unchecked((int)(0x8009300E));

    [NativeTypeName("#define OSS_BAD_TABLE _HRESULT_TYPEDEF_(0x8009300FL)")]
    public const int OSS_BAD_TABLE = unchecked((int)(0x8009300F));

    [NativeTypeName("#define OSS_TOO_LONG _HRESULT_TYPEDEF_(0x80093010L)")]
    public const int OSS_TOO_LONG = unchecked((int)(0x80093010));

    [NativeTypeName("#define OSS_CONSTRAINT_VIOLATED _HRESULT_TYPEDEF_(0x80093011L)")]
    public const int OSS_CONSTRAINT_VIOLATED = unchecked((int)(0x80093011));

    [NativeTypeName("#define OSS_FATAL_ERROR _HRESULT_TYPEDEF_(0x80093012L)")]
    public const int OSS_FATAL_ERROR = unchecked((int)(0x80093012));

    [NativeTypeName("#define OSS_ACCESS_SERIALIZATION_ERROR _HRESULT_TYPEDEF_(0x80093013L)")]
    public const int OSS_ACCESS_SERIALIZATION_ERROR = unchecked((int)(0x80093013));

    [NativeTypeName("#define OSS_NULL_TBL _HRESULT_TYPEDEF_(0x80093014L)")]
    public const int OSS_NULL_TBL = unchecked((int)(0x80093014));

    [NativeTypeName("#define OSS_NULL_FCN _HRESULT_TYPEDEF_(0x80093015L)")]
    public const int OSS_NULL_FCN = unchecked((int)(0x80093015));

    [NativeTypeName("#define OSS_BAD_ENCRULES _HRESULT_TYPEDEF_(0x80093016L)")]
    public const int OSS_BAD_ENCRULES = unchecked((int)(0x80093016));

    [NativeTypeName("#define OSS_UNAVAIL_ENCRULES _HRESULT_TYPEDEF_(0x80093017L)")]
    public const int OSS_UNAVAIL_ENCRULES = unchecked((int)(0x80093017));

    [NativeTypeName("#define OSS_CANT_OPEN_TRACE_WINDOW _HRESULT_TYPEDEF_(0x80093018L)")]
    public const int OSS_CANT_OPEN_TRACE_WINDOW = unchecked((int)(0x80093018));

    [NativeTypeName("#define OSS_UNIMPLEMENTED _HRESULT_TYPEDEF_(0x80093019L)")]
    public const int OSS_UNIMPLEMENTED = unchecked((int)(0x80093019));

    [NativeTypeName("#define OSS_OID_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x8009301AL)")]
    public const int OSS_OID_DLL_NOT_LINKED = unchecked((int)(0x8009301A));

    [NativeTypeName("#define OSS_CANT_OPEN_TRACE_FILE _HRESULT_TYPEDEF_(0x8009301BL)")]
    public const int OSS_CANT_OPEN_TRACE_FILE = unchecked((int)(0x8009301B));

    [NativeTypeName("#define OSS_TRACE_FILE_ALREADY_OPEN _HRESULT_TYPEDEF_(0x8009301CL)")]
    public const int OSS_TRACE_FILE_ALREADY_OPEN = unchecked((int)(0x8009301C));

    [NativeTypeName("#define OSS_TABLE_MISMATCH _HRESULT_TYPEDEF_(0x8009301DL)")]
    public const int OSS_TABLE_MISMATCH = unchecked((int)(0x8009301D));

    [NativeTypeName("#define OSS_TYPE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8009301EL)")]
    public const int OSS_TYPE_NOT_SUPPORTED = unchecked((int)(0x8009301E));

    [NativeTypeName("#define OSS_REAL_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x8009301FL)")]
    public const int OSS_REAL_DLL_NOT_LINKED = unchecked((int)(0x8009301F));

    [NativeTypeName("#define OSS_REAL_CODE_NOT_LINKED _HRESULT_TYPEDEF_(0x80093020L)")]
    public const int OSS_REAL_CODE_NOT_LINKED = unchecked((int)(0x80093020));

    [NativeTypeName("#define OSS_OUT_OF_RANGE _HRESULT_TYPEDEF_(0x80093021L)")]
    public const int OSS_OUT_OF_RANGE = unchecked((int)(0x80093021));

    [NativeTypeName("#define OSS_COPIER_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x80093022L)")]
    public const int OSS_COPIER_DLL_NOT_LINKED = unchecked((int)(0x80093022));

    [NativeTypeName("#define OSS_CONSTRAINT_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x80093023L)")]
    public const int OSS_CONSTRAINT_DLL_NOT_LINKED = unchecked((int)(0x80093023));

    [NativeTypeName("#define OSS_COMPARATOR_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x80093024L)")]
    public const int OSS_COMPARATOR_DLL_NOT_LINKED = unchecked((int)(0x80093024));

    [NativeTypeName("#define OSS_COMPARATOR_CODE_NOT_LINKED _HRESULT_TYPEDEF_(0x80093025L)")]
    public const int OSS_COMPARATOR_CODE_NOT_LINKED = unchecked((int)(0x80093025));

    [NativeTypeName("#define OSS_MEM_MGR_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x80093026L)")]
    public const int OSS_MEM_MGR_DLL_NOT_LINKED = unchecked((int)(0x80093026));

    [NativeTypeName("#define OSS_PDV_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x80093027L)")]
    public const int OSS_PDV_DLL_NOT_LINKED = unchecked((int)(0x80093027));

    [NativeTypeName("#define OSS_PDV_CODE_NOT_LINKED _HRESULT_TYPEDEF_(0x80093028L)")]
    public const int OSS_PDV_CODE_NOT_LINKED = unchecked((int)(0x80093028));

    [NativeTypeName("#define OSS_API_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x80093029L)")]
    public const int OSS_API_DLL_NOT_LINKED = unchecked((int)(0x80093029));

    [NativeTypeName("#define OSS_BERDER_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x8009302AL)")]
    public const int OSS_BERDER_DLL_NOT_LINKED = unchecked((int)(0x8009302A));

    [NativeTypeName("#define OSS_PER_DLL_NOT_LINKED _HRESULT_TYPEDEF_(0x8009302BL)")]
    public const int OSS_PER_DLL_NOT_LINKED = unchecked((int)(0x8009302B));

    [NativeTypeName("#define OSS_OPEN_TYPE_ERROR _HRESULT_TYPEDEF_(0x8009302CL)")]
    public const int OSS_OPEN_TYPE_ERROR = unchecked((int)(0x8009302C));

    [NativeTypeName("#define OSS_MUTEX_NOT_CREATED _HRESULT_TYPEDEF_(0x8009302DL)")]
    public const int OSS_MUTEX_NOT_CREATED = unchecked((int)(0x8009302D));

    [NativeTypeName("#define OSS_CANT_CLOSE_TRACE_FILE _HRESULT_TYPEDEF_(0x8009302EL)")]
    public const int OSS_CANT_CLOSE_TRACE_FILE = unchecked((int)(0x8009302E));
}
