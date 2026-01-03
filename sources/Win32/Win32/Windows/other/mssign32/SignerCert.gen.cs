// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='SIGNER_CERT.xml' path='doc/member[@name="SIGNER_CERT"]/*'/>
public unsafe partial struct SignerCert
{
    /// <include file='SIGNER_CERT.xml' path='doc/member[@name="SIGNER_CERT.cbSize"]/*'/>

    [NativeTypeName("DWORD")]
    public uint CbSize;

    /// <include file='SIGNER_CERT.xml' path='doc/member[@name="SIGNER_CERT.dwCertChoice"]/*'/>

    [NativeTypeName("DWORD")]
    public uint DwCertChoice;

    /// <include file='SIGNER_CERT.xml' path='doc/member[@name="SIGNER_CERT.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_mssign32_L111_C9")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='SIGNER_CERT.xml' path='doc/member[@name="SIGNER_CERT.hwnd"]/*'/>

    public HWND Hwnd;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszSpcFile"]/*'/>

    [UnscopedRef]
    public ref ushort* pwszSpcFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pwszSpcFile; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCertStoreInfo"]/*'/>

    [UnscopedRef]
    public ref SignerCertStoreInfo* pCertStoreInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pCertStoreInfo; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSpcChainInfo"]/*'/>

    [UnscopedRef]
    public ref SignerSpcChainInfo* pSpcChainInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pSpcChainInfo; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszSpcFile"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pwszSpcFile;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCertStoreInfo"]/*'/>

        [FieldOffset(0)]
        public SignerCertStoreInfo* pCertStoreInfo;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSpcChainInfo"]/*'/>

        [FieldOffset(0)]
        public SignerSpcChainInfo* pSpcChainInfo;
    }
}
