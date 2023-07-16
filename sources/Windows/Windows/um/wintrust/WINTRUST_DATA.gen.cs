// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA"]/*'/>
public unsafe partial struct WINTRUST_DATA
{
    /// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA.pPolicyCallbackData"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* pPolicyCallbackData;
    /// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA.pSIPClientData"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* pSIPClientData;
    /// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA.dwUIChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwUIChoice;
    /// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA.fdwRevocationChecks"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fdwRevocationChecks;
    /// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA.dwUnionChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwUnionChoice;
    /// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_WinTrust_L116_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA.dwStateAction"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStateAction;
    /// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA.hWVTStateData"]/*'/>
    public HANDLE hWVTStateData;
    /// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA.pwszURLReference"]/*'/>
    [NativeTypeName("WCHAR *")]
    public ushort* pwszURLReference;
    /// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA.dwProvFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProvFlags;
    /// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA.dwUIContext"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwUIContext;
    /// <include file='WINTRUST_DATA.xml' path='doc/member[@name="WINTRUST_DATA.pSignatureSettings"]/*'/>
    [NativeTypeName("struct WINTRUST_SIGNATURE_SETTINGS_ *")]
    public WINTRUST_SIGNATURE_SETTINGS* pSignatureSettings;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pFile"]/*'/>
    [UnscopedRef]
    public ref WINTRUST_FILE_INFO* pFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pFile;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCatalog"]/*'/>
    [UnscopedRef]
    public ref WINTRUST_CATALOG_INFO* pCatalog
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pCatalog;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pBlob"]/*'/>
    [UnscopedRef]
    public ref WINTRUST_BLOB_INFO* pBlob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pBlob;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSgnr"]/*'/>
    [UnscopedRef]
    public ref WINTRUST_SGNR_INFO* pSgnr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pSgnr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCert"]/*'/>
    [UnscopedRef]
    public ref WINTRUST_CERT_INFO* pCert
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pCert;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pFile"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_FILE_INFO_ *")]
        public WINTRUST_FILE_INFO* pFile;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCatalog"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_CATALOG_INFO_ *")]
        public WINTRUST_CATALOG_INFO* pCatalog;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pBlob"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_BLOB_INFO_ *")]
        public WINTRUST_BLOB_INFO* pBlob;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSgnr"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_SGNR_INFO_ *")]
        public WINTRUST_SGNR_INFO* pSgnr;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCert"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_CERT_INFO_ *")]
        public WINTRUST_CERT_INFO* pCert;
    }
}