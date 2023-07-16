// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DEVICEDUMP_PUBLIC_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PUBLIC_SUBSECTION"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct DEVICEDUMP_PUBLIC_SUBSECTION
{
    /// <include file='DEVICEDUMP_PUBLIC_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PUBLIC_SUBSECTION.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DEVICEDUMP_PUBLIC_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PUBLIC_SUBSECTION.GPLogTable"]/*'/>
    [NativeTypeName("GP_LOG_PAGE_DESCRIPTOR[16]")]
    public _GPLogTable_e__FixedBuffer GPLogTable;
    /// <include file='DEVICEDUMP_PUBLIC_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PUBLIC_SUBSECTION.szDescription"]/*'/>
    [NativeTypeName("CHAR[16]")]
    public fixed sbyte szDescription[16];
    /// <include file='DEVICEDUMP_PUBLIC_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PUBLIC_SUBSECTION.bData"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte bData[1];
    /// <include file='_GPLogTable_e__FixedBuffer.xml' path='doc/member[@name="_GPLogTable_e__FixedBuffer"]/*'/>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _GPLogTable_e__FixedBuffer
    {
        public GP_LOG_PAGE_DESCRIPTOR e0;
        public GP_LOG_PAGE_DESCRIPTOR e1;
        public GP_LOG_PAGE_DESCRIPTOR e2;
        public GP_LOG_PAGE_DESCRIPTOR e3;
        public GP_LOG_PAGE_DESCRIPTOR e4;
        public GP_LOG_PAGE_DESCRIPTOR e5;
        public GP_LOG_PAGE_DESCRIPTOR e6;
        public GP_LOG_PAGE_DESCRIPTOR e7;
        public GP_LOG_PAGE_DESCRIPTOR e8;
        public GP_LOG_PAGE_DESCRIPTOR e9;
        public GP_LOG_PAGE_DESCRIPTOR e10;
        public GP_LOG_PAGE_DESCRIPTOR e11;
        public GP_LOG_PAGE_DESCRIPTOR e12;
        public GP_LOG_PAGE_DESCRIPTOR e13;
        public GP_LOG_PAGE_DESCRIPTOR e14;
        public GP_LOG_PAGE_DESCRIPTOR e15;
        [UnscopedRef]
        public ref GP_LOG_PAGE_DESCRIPTOR this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<GP_LOG_PAGE_DESCRIPTOR> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
    }
}