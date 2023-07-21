// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SIP_CAP_SET_V3.xml' path='doc/member[@name="SIP_CAP_SET_V3"]/*' />
public partial struct SIP_CAP_SET_V3
{
    /// <include file='SIP_CAP_SET_V3.xml' path='doc/member[@name="SIP_CAP_SET_V3.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SIP_CAP_SET_V3.xml' path='doc/member[@name="SIP_CAP_SET_V3.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='SIP_CAP_SET_V3.xml' path='doc/member[@name="SIP_CAP_SET_V3.isMultiSign"]/*' />
    public BOOL isMultiSign;

    /// <include file='SIP_CAP_SET_V3.xml' path='doc/member[@name="SIP_CAP_SET_V3.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_mssip_L193_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwFlags"]/*' />
    [UnscopedRef]
    public ref uint dwFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwFlags;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwReserved"]/*' />
    [UnscopedRef]
    public ref uint dwReserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwReserved;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwFlags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwReserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwReserved;
    }
}
