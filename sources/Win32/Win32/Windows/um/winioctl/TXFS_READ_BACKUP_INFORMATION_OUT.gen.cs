// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

/// <include file='TXFS_READ_BACKUP_INFORMATION_OUT.xml' path='doc/member[@name="TXFS_READ_BACKUP_INFORMATION_OUT"]/*'/>
public partial struct TXFS_READ_BACKUP_INFORMATION_OUT
{
    /// <include file='TXFS_READ_BACKUP_INFORMATION_OUT.xml' path='doc/member[@name="TXFS_READ_BACKUP_INFORMATION_OUT.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_winioctl_L13788_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BufferLength"]/*'/>

    [UnscopedRef]
    public ref uint BufferLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.BufferLength; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Buffer"]/*'/>

    [UnscopedRef]
    public Span<byte> Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.Buffer.AsSpan((int)(BufferLength)); }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BufferLength"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint BufferLength;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Buffer"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName("BYTE[1]")]
        public _Buffer_e__FixedBuffer Buffer;

        /// <include file='_Buffer_e__FixedBuffer.xml' path='doc/member[@name="_Buffer_e__FixedBuffer"]/*'/>

        public partial struct _Buffer_e__FixedBuffer
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
