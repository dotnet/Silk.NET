// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

/// <include file='MIB_OPAQUE_INFO.xml' path='doc/member[@name="MIB_OPAQUE_INFO"]/*'/>
public partial struct MIB_OPAQUE_INFO
{
    /// <include file='MIB_OPAQUE_INFO.xml' path='doc/member[@name="MIB_OPAQUE_INFO.dwId"]/*'/>

    [NativeTypeName("DWORD")]
    public uint dwId;

    /// <include file='MIB_OPAQUE_INFO.xml' path='doc/member[@name="MIB_OPAQUE_INFO.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_Iprtrmib_L306_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ullAlign"]/*'/>

    [UnscopedRef]
    public ref ulong ullAlign
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ullAlign; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.rgbyData"]/*'/>

    [UnscopedRef]
    public Span<byte> rgbyData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.rgbyData.AsSpan(1); }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ullAlign"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong ullAlign;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.rgbyData"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName("BYTE[1]")]
        public _rgbyData_e__FixedBuffer rgbyData;

        /// <include file='_rgbyData_e__FixedBuffer.xml' path='doc/member[@name="_rgbyData_e__FixedBuffer"]/*'/>

        public partial struct _rgbyData_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Unsafe.Add(ref e0, index); }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
