// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mssip.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SIP_SUBJECTINFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public Guid* pgSubjectType;
    public HANDLE hFile;

    [NativeTypeName("LPCWSTR")]
    public ushort* pwsFileName;

    [NativeTypeName("LPCWSTR")]
    public ushort* pwsDisplayName;

    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    [NativeTypeName("DWORD")]
    public uint dwIntVersion;
    public HCRYPTPROV hProv;
    public CRYPT_ALGORITHM_IDENTIFIER DigestAlgorithm;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwEncodingType;

    [NativeTypeName("DWORD")]
    public uint dwReserved2;

    [NativeTypeName("DWORD")]
    public uint fdwCAPISettings;

    [NativeTypeName("DWORD")]
    public uint fdwSecuritySettings;

    [NativeTypeName("DWORD")]
    public uint dwIndex;

    [NativeTypeName("DWORD")]
    public uint dwUnionChoice;

    [NativeTypeName("__AnonymousRecord_mssip_L115_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("LPVOID")]
    public void* pClientData;

    [UnscopedRef]
    public ref MS_ADDINFO_FLAT* psFlat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.psFlat; }
    }

    [UnscopedRef]
    public ref MS_ADDINFO_CATALOGMEMBER* psCatMember
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.psCatMember; }
    }

    [UnscopedRef]
    public ref MS_ADDINFO_BLOB* psBlob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.psBlob; }
    }

    [UnscopedRef]
    public ref MS_ADDINFO_DETACHEDSIG* psDetachedSig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.psDetachedSig; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct MS_ADDINFO_FLAT_ *")]
        public MS_ADDINFO_FLAT* psFlat;

        [FieldOffset(0)]
        [NativeTypeName("struct MS_ADDINFO_CATALOGMEMBER_ *")]
        public MS_ADDINFO_CATALOGMEMBER* psCatMember;

        [FieldOffset(0)]
        [NativeTypeName("struct MS_ADDINFO_BLOB_ *")]
        public MS_ADDINFO_BLOB* psBlob;

        [FieldOffset(0)]
        [NativeTypeName("struct MS_ADDINFO_DETACHEDSIG_ *")]
        public MS_ADDINFO_DETACHEDSIG* psDetachedSig;
    }
}
