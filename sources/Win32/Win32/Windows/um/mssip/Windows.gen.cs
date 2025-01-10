// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mssip.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSIPGetSignedDataMsg(
        SIP_SUBJECTINFO* pSubjectInfo,
        [NativeTypeName("DWORD *")] uint* pdwEncodingType,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("DWORD *")] uint* pcbSignedDataMsg,
        byte* pbSignedDataMsg
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSIPPutSignedDataMsg(
        SIP_SUBJECTINFO* pSubjectInfo,
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("DWORD *")] uint* pdwIndex,
        [NativeTypeName("DWORD")] uint cbSignedDataMsg,
        byte* pbSignedDataMsg
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSIPCreateIndirectData(
        SIP_SUBJECTINFO* pSubjectInfo,
        [NativeTypeName("DWORD *")] uint* pcbIndirectData,
        SIP_INDIRECT_DATA* pIndirectData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSIPVerifyIndirectData(
        SIP_SUBJECTINFO* pSubjectInfo,
        SIP_INDIRECT_DATA* pIndirectData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSIPRemoveSignedDataMsg(
        SIP_SUBJECTINFO* pSubjectInfo,
        [NativeTypeName("DWORD")] uint dwIndex
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSIPLoad(
        [NativeTypeName("const GUID *")] Guid* pgSubject,
        [NativeTypeName("DWORD")] uint dwFlags,
        SIP_DISPATCH_INFO* pSipDispatch
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSIPRetrieveSubjectGuid(
        [NativeTypeName("LPCWSTR")] ushort* FileName,
        HANDLE hFileIn,
        Guid* pgSubject
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSIPRetrieveSubjectGuidForCatalogFile(
        [NativeTypeName("LPCWSTR")] ushort* FileName,
        HANDLE hFileIn,
        Guid* pgSubject
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSIPAddProvider(SIP_ADD_NEWPROVIDER* psNewProv);

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSIPRemoveProvider(Guid* pgProv);

    [DllImport("crypt32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL CryptSIPGetCaps(
        SIP_SUBJECTINFO* pSubjInfo,
        [NativeTypeName("SIP_CAP_SET *")] SIP_CAP_SET_V3* pCaps
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptSIPGetSealedDigest(
        SIP_SUBJECTINFO* pSubjectInfo,
        [NativeTypeName("const BYTE *")] byte* pSig,
        [NativeTypeName("DWORD")] uint dwSig,
        byte* pbDigest,
        [NativeTypeName("DWORD *")] uint* pcbDigest
    );

    [NativeTypeName("#define MSSIP_FLAGS_PROHIBIT_RESIZE_ON_CREATE 0x00010000")]
    public const int MSSIP_FLAGS_PROHIBIT_RESIZE_ON_CREATE = 0x00010000;

    [NativeTypeName("#define MSSIP_FLAGS_USE_CATALOG 0x00020000")]
    public const int MSSIP_FLAGS_USE_CATALOG = 0x00020000;

    [NativeTypeName("#define MSSIP_FLAGS_MULTI_HASH 0x00040000")]
    public const int MSSIP_FLAGS_MULTI_HASH = 0x00040000;

    [NativeTypeName("#define MSSIP_ADDINFO_NONE 0")]
    public const int MSSIP_ADDINFO_NONE = 0;

    [NativeTypeName("#define MSSIP_ADDINFO_FLAT 1")]
    public const int MSSIP_ADDINFO_FLAT = 1;

    [NativeTypeName("#define MSSIP_ADDINFO_CATMEMBER 2")]
    public const int MSSIP_ADDINFO_CATMEMBER = 2;

    [NativeTypeName("#define MSSIP_ADDINFO_BLOB 3")]
    public const int MSSIP_ADDINFO_BLOB = 3;

    [NativeTypeName("#define MSSIP_ADDINFO_DETACHEDSIG 4")]
    public const int MSSIP_ADDINFO_DETACHEDSIG = 4;

    [NativeTypeName("#define MSSIP_ADDINFO_NONMSSIP 500")]
    public const int MSSIP_ADDINFO_NONMSSIP = 500;

    [NativeTypeName("#define SIP_CAP_SET_VERSION_2 2")]
    public const int SIP_CAP_SET_VERSION_2 = 2;

    [NativeTypeName("#define SIP_CAP_SET_VERSION_3 3")]
    public const int SIP_CAP_SET_VERSION_3 = 3;

    [NativeTypeName("#define SIP_CAP_SET_CUR_VER 3")]
    public const int SIP_CAP_SET_CUR_VER = 3;

    [NativeTypeName("#define SIP_CAP_FLAG_SEALING 0x00000001")]
    public const int SIP_CAP_FLAG_SEALING = 0x00000001;

    [NativeTypeName("#define SIP_MAX_MAGIC_NUMBER 4")]
    public const int SIP_MAX_MAGIC_NUMBER = 4;
}
