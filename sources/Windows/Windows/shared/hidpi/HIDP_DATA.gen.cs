// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='HIDP_DATA.xml' path='doc/member[@name="HIDP_DATA"]/*' />
public partial struct HIDP_DATA
{
    /// <include file='HIDP_DATA.xml' path='doc/member[@name="HIDP_DATA.DataIndex"]/*' />
    public ushort DataIndex;

    /// <include file='HIDP_DATA.xml' path='doc/member[@name="HIDP_DATA.Reserved"]/*' />
    public ushort Reserved;

    /// <include file='HIDP_DATA.xml' path='doc/member[@name="HIDP_DATA.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_hidpi_L273_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RawValue"]/*' />
    [UnscopedRef]
    public ref uint RawValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.RawValue;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.On"]/*' />
    [UnscopedRef]
    public ref byte On
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.On;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RawValue"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint RawValue;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.On"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("BOOLEAN")]
        public byte On;
    }
}
