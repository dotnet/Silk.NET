// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIB_TCPROW_LH.xml' path='doc/member[@name="MIB_TCPROW_LH"]/*' />
public partial struct MIB_TCPROW_LH
{
    /// <include file='MIB_TCPROW_LH.xml' path='doc/member[@name="MIB_TCPROW_LH.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_tcpmib_L69_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='MIB_TCPROW_LH.xml' path='doc/member[@name="MIB_TCPROW_LH.dwLocalAddr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalAddr;

    /// <include file='MIB_TCPROW_LH.xml' path='doc/member[@name="MIB_TCPROW_LH.dwLocalPort"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalPort;

    /// <include file='MIB_TCPROW_LH.xml' path='doc/member[@name="MIB_TCPROW_LH.dwRemoteAddr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRemoteAddr;

    /// <include file='MIB_TCPROW_LH.xml' path='doc/member[@name="MIB_TCPROW_LH.dwRemotePort"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRemotePort;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwState"]/*' />
    [UnscopedRef]
    public ref uint dwState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwState;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.State"]/*' />
    [UnscopedRef]
    public ref MIB_TCP_STATE State
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.State;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwState"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwState;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.State"]/*' />
        [FieldOffset(0)]
        public MIB_TCP_STATE State;
    }
}
