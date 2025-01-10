// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WINTRUST_DATA
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("LPVOID")]
    public void* pPolicyCallbackData;

    [NativeTypeName("LPVOID")]
    public void* pSIPClientData;

    [NativeTypeName("DWORD")]
    public uint dwUIChoice;

    [NativeTypeName("DWORD")]
    public uint fdwRevocationChecks;

    [NativeTypeName("DWORD")]
    public uint dwUnionChoice;

    [NativeTypeName("__AnonymousRecord_WinTrust_L117_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint dwStateAction;
    public HANDLE hWVTStateData;

    [NativeTypeName("WCHAR *")]
    public ushort* pwszURLReference;

    [NativeTypeName("DWORD")]
    public uint dwProvFlags;

    [NativeTypeName("DWORD")]
    public uint dwUIContext;

    [NativeTypeName("struct WINTRUST_SIGNATURE_SETTINGS_ *")]
    public WINTRUST_SIGNATURE_SETTINGS* pSignatureSettings;

    [UnscopedRef]
    public ref WINTRUST_FILE_INFO* pFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pFile; }
    }

    [UnscopedRef]
    public ref WINTRUST_CATALOG_INFO* pCatalog
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pCatalog; }
    }

    [UnscopedRef]
    public ref WINTRUST_BLOB_INFO* pBlob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pBlob; }
    }

    [UnscopedRef]
    public ref WINTRUST_SGNR_INFO* pSgnr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pSgnr; }
    }

    [UnscopedRef]
    public ref WINTRUST_CERT_INFO* pCert
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pCert; }
    }

    [UnscopedRef]
    public ref WINTRUST_DETACHED_SIG_INFO* pDetachedSig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pDetachedSig; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_FILE_INFO_ *")]
        public WINTRUST_FILE_INFO* pFile;

        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_CATALOG_INFO_ *")]
        public WINTRUST_CATALOG_INFO* pCatalog;

        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_BLOB_INFO_ *")]
        public WINTRUST_BLOB_INFO* pBlob;

        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_SGNR_INFO_ *")]
        public WINTRUST_SGNR_INFO* pSgnr;

        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_CERT_INFO_ *")]
        public WINTRUST_CERT_INFO* pCert;

        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_DETACHED_SIG_INFO_ *")]
        public WINTRUST_DETACHED_SIG_INFO* pDetachedSig;
    }
}
