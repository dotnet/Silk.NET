// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mssip.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO"]/*'/>
public unsafe partial struct SIP_SUBJECTINFO
{
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.pgSubjectType"]/*'/>
    public Guid* pgSubjectType;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.hFile"]/*'/>
    public HANDLE hFile;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.pwsFileName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pwsFileName;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.pwsDisplayName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pwsDisplayName;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.dwReserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved1;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.dwIntVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwIntVersion;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.hProv"]/*'/>
    public HCRYPTPROV hProv;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.DigestAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER DigestAlgorithm;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.dwEncodingType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwEncodingType;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.dwReserved2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved2;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.fdwCAPISettings"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fdwCAPISettings;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.fdwSecuritySettings"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fdwSecuritySettings;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.dwIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwIndex;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.dwUnionChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwUnionChoice;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_mssip_L114_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='SIP_SUBJECTINFO.xml' path='doc/member[@name="SIP_SUBJECTINFO.pClientData"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* pClientData;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.psFlat"]/*'/>
    [UnscopedRef]
    public ref MS_ADDINFO_FLAT* psFlat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.psFlat;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.psCatMember"]/*'/>
    [UnscopedRef]
    public ref MS_ADDINFO_CATALOGMEMBER* psCatMember
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.psCatMember;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.psBlob"]/*'/>
    [UnscopedRef]
    public ref MS_ADDINFO_BLOB* psBlob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.psBlob;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.psFlat"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct MS_ADDINFO_FLAT_ *")]
        public MS_ADDINFO_FLAT* psFlat;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.psCatMember"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct MS_ADDINFO_CATALOGMEMBER_ *")]
        public MS_ADDINFO_CATALOGMEMBER* psCatMember;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.psBlob"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct MS_ADDINFO_BLOB_ *")]
        public MS_ADDINFO_BLOB* psBlob;
    }
}