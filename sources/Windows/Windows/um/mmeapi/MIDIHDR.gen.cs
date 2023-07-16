// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='MIDIHDR.xml' path='doc/member[@name="MIDIHDR"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIDIHDR
{
    /// <include file='MIDIHDR.xml' path='doc/member[@name="MIDIHDR.lpData"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpData;
    /// <include file='MIDIHDR.xml' path='doc/member[@name="MIDIHDR.dwBufferLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBufferLength;
    /// <include file='MIDIHDR.xml' path='doc/member[@name="MIDIHDR.dwBytesRecorded"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBytesRecorded;
    /// <include file='MIDIHDR.xml' path='doc/member[@name="MIDIHDR.dwUser"]/*'/>
    [NativeTypeName("DWORD_PTR")]
    public nuint dwUser;
    /// <include file='MIDIHDR.xml' path='doc/member[@name="MIDIHDR.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='MIDIHDR.xml' path='doc/member[@name="MIDIHDR.lpNext"]/*'/>
    [NativeTypeName("struct midihdr_tag *")]
    public MIDIHDR* lpNext;
    /// <include file='MIDIHDR.xml' path='doc/member[@name="MIDIHDR.reserved"]/*'/>
    [NativeTypeName("DWORD_PTR")]
    public nuint reserved;
    /// <include file='MIDIHDR.xml' path='doc/member[@name="MIDIHDR.dwOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOffset;
    /// <include file='MIDIHDR.xml' path='doc/member[@name="MIDIHDR.dwReserved"]/*'/>
    [NativeTypeName("DWORD_PTR[8]")]
    public _dwReserved_e__FixedBuffer dwReserved;
    /// <include file='_dwReserved_e__FixedBuffer.xml' path='doc/member[@name="_dwReserved_e__FixedBuffer"]/*'/>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _dwReserved_e__FixedBuffer
    {
        public nuint e0;
        public nuint e1;
        public nuint e2;
        public nuint e3;
        public nuint e4;
        public nuint e5;
        public nuint e6;
        public nuint e7;
        [UnscopedRef]
        public ref nuint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
    }
}