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

/// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO"]/*'/>
public unsafe partial struct SignerSignatureInfo
{
    /// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO.cbSize"]/*'/>

    [NativeTypeName("DWORD")]
    public uint CbSize;

    /// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO.algidHash"]/*'/>

    [NativeTypeName("ALG_ID")]
    public uint AlgidHash;

    /// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO.dwAttrChoice"]/*'/>

    [NativeTypeName("DWORD")]
    public uint DwAttrChoice;

    /// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_mssign32_L55_C9")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO.psAuthenticated"]/*'/>

    [NativeTypeName("PCRYPT_ATTRIBUTES")]
    public CryptAttributes* PsAuthenticated;

    /// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO.psUnauthenticated"]/*'/>

    [NativeTypeName("PCRYPT_ATTRIBUTES")]
    public CryptAttributes* PsUnauthenticated;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pAttrAuthcode"]/*'/>

    [UnscopedRef]
    public ref SignerAttrAuthcode* pAttrAuthcode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pAttrAuthcode; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pAttrAuthcode"]/*'/>

        [FieldOffset(0)]
        public SignerAttrAuthcode* pAttrAuthcode;
    }
}
