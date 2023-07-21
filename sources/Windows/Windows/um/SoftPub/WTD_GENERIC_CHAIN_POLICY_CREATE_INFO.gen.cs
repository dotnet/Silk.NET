// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='WTD_GENERIC_CHAIN_POLICY_CREATE_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_CREATE_INFO"]/*' />
public unsafe partial struct WTD_GENERIC_CHAIN_POLICY_CREATE_INFO
{
    /// <include file='WTD_GENERIC_CHAIN_POLICY_CREATE_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_CREATE_INFO.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_SoftPub_L160_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_CREATE_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_CREATE_INFO.hChainEngine"]/*' />
    public HCERTCHAINENGINE hChainEngine;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_CREATE_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_CREATE_INFO.pChainPara"]/*' />
    [NativeTypeName("PCERT_CHAIN_PARA")]
    public CERT_CHAIN_PARA* pChainPara;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_CREATE_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_CREATE_INFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_CREATE_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_CREATE_INFO.pvReserved"]/*' />
    public void* pvReserved;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbStruct"]/*' />
    [UnscopedRef]
    public ref uint cbStruct
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.cbStruct;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbSize"]/*' />
    [UnscopedRef]
    public ref uint cbSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.cbSize;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbStruct"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbSize"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbSize;
    }
}
