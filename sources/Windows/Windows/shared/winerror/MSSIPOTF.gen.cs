// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class MSSIPOTF
{
    [NativeTypeName("#define MSSIPOTF_E_OUTOFMEMRANGE _HRESULT_TYPEDEF_(0x80097001L)")]
    public const int MSSIPOTF_E_OUTOFMEMRANGE = unchecked((int)(0x80097001));

    [NativeTypeName("#define MSSIPOTF_E_CANTGETOBJECT _HRESULT_TYPEDEF_(0x80097002L)")]
    public const int MSSIPOTF_E_CANTGETOBJECT = unchecked((int)(0x80097002));

    [NativeTypeName("#define MSSIPOTF_E_NOHEADTABLE _HRESULT_TYPEDEF_(0x80097003L)")]
    public const int MSSIPOTF_E_NOHEADTABLE = unchecked((int)(0x80097003));

    [NativeTypeName("#define MSSIPOTF_E_BAD_MAGICNUMBER _HRESULT_TYPEDEF_(0x80097004L)")]
    public const int MSSIPOTF_E_BAD_MAGICNUMBER = unchecked((int)(0x80097004));

    [NativeTypeName("#define MSSIPOTF_E_BAD_OFFSET_TABLE _HRESULT_TYPEDEF_(0x80097005L)")]
    public const int MSSIPOTF_E_BAD_OFFSET_TABLE = unchecked((int)(0x80097005));

    [NativeTypeName("#define MSSIPOTF_E_TABLE_TAGORDER _HRESULT_TYPEDEF_(0x80097006L)")]
    public const int MSSIPOTF_E_TABLE_TAGORDER = unchecked((int)(0x80097006));

    [NativeTypeName("#define MSSIPOTF_E_TABLE_LONGWORD _HRESULT_TYPEDEF_(0x80097007L)")]
    public const int MSSIPOTF_E_TABLE_LONGWORD = unchecked((int)(0x80097007));

    [NativeTypeName("#define MSSIPOTF_E_BAD_FIRST_TABLE_PLACEMENT _HRESULT_TYPEDEF_(0x80097008L)")]
    public const int MSSIPOTF_E_BAD_FIRST_TABLE_PLACEMENT = unchecked((int)(0x80097008));

    [NativeTypeName("#define MSSIPOTF_E_TABLES_OVERLAP _HRESULT_TYPEDEF_(0x80097009L)")]
    public const int MSSIPOTF_E_TABLES_OVERLAP = unchecked((int)(0x80097009));

    [NativeTypeName("#define MSSIPOTF_E_TABLE_PADBYTES _HRESULT_TYPEDEF_(0x8009700AL)")]
    public const int MSSIPOTF_E_TABLE_PADBYTES = unchecked((int)(0x8009700A));

    [NativeTypeName("#define MSSIPOTF_E_FILETOOSMALL _HRESULT_TYPEDEF_(0x8009700BL)")]
    public const int MSSIPOTF_E_FILETOOSMALL = unchecked((int)(0x8009700B));

    [NativeTypeName("#define MSSIPOTF_E_TABLE_CHECKSUM _HRESULT_TYPEDEF_(0x8009700CL)")]
    public const int MSSIPOTF_E_TABLE_CHECKSUM = unchecked((int)(0x8009700C));

    [NativeTypeName("#define MSSIPOTF_E_FILE_CHECKSUM _HRESULT_TYPEDEF_(0x8009700DL)")]
    public const int MSSIPOTF_E_FILE_CHECKSUM = unchecked((int)(0x8009700D));

    [NativeTypeName("#define MSSIPOTF_E_FAILED_POLICY _HRESULT_TYPEDEF_(0x80097010L)")]
    public const int MSSIPOTF_E_FAILED_POLICY = unchecked((int)(0x80097010));

    [NativeTypeName("#define MSSIPOTF_E_FAILED_HINTS_CHECK _HRESULT_TYPEDEF_(0x80097011L)")]
    public const int MSSIPOTF_E_FAILED_HINTS_CHECK = unchecked((int)(0x80097011));

    [NativeTypeName("#define MSSIPOTF_E_NOT_OPENTYPE _HRESULT_TYPEDEF_(0x80097012L)")]
    public const int MSSIPOTF_E_NOT_OPENTYPE = unchecked((int)(0x80097012));

    [NativeTypeName("#define MSSIPOTF_E_FILE _HRESULT_TYPEDEF_(0x80097013L)")]
    public const int MSSIPOTF_E_FILE = unchecked((int)(0x80097013));

    [NativeTypeName("#define MSSIPOTF_E_CRYPT _HRESULT_TYPEDEF_(0x80097014L)")]
    public const int MSSIPOTF_E_CRYPT = unchecked((int)(0x80097014));

    [NativeTypeName("#define MSSIPOTF_E_BADVERSION _HRESULT_TYPEDEF_(0x80097015L)")]
    public const int MSSIPOTF_E_BADVERSION = unchecked((int)(0x80097015));

    [NativeTypeName("#define MSSIPOTF_E_DSIG_STRUCTURE _HRESULT_TYPEDEF_(0x80097016L)")]
    public const int MSSIPOTF_E_DSIG_STRUCTURE = unchecked((int)(0x80097016));

    [NativeTypeName("#define MSSIPOTF_E_PCONST_CHECK _HRESULT_TYPEDEF_(0x80097017L)")]
    public const int MSSIPOTF_E_PCONST_CHECK = unchecked((int)(0x80097017));

    [NativeTypeName("#define MSSIPOTF_E_STRUCTURE _HRESULT_TYPEDEF_(0x80097018L)")]
    public const int MSSIPOTF_E_STRUCTURE = unchecked((int)(0x80097018));
}
