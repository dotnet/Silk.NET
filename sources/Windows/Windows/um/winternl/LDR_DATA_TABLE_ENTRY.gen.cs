// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='LDR_DATA_TABLE_ENTRY.xml' path='doc/member[@name="LDR_DATA_TABLE_ENTRY"]/*'/>
public unsafe partial struct LDR_DATA_TABLE_ENTRY
{
    /// <include file='LDR_DATA_TABLE_ENTRY.xml' path='doc/member[@name="LDR_DATA_TABLE_ENTRY.Reserved1"]/*'/>
    [NativeTypeName("PVOID[2]")]
    public _Reserved1_e__FixedBuffer Reserved1;
    /// <include file='LDR_DATA_TABLE_ENTRY.xml' path='doc/member[@name="LDR_DATA_TABLE_ENTRY.InMemoryOrderLinks"]/*'/>
    public LIST_ENTRY InMemoryOrderLinks;
    /// <include file='LDR_DATA_TABLE_ENTRY.xml' path='doc/member[@name="LDR_DATA_TABLE_ENTRY.Reserved2"]/*'/>
    [NativeTypeName("PVOID[2]")]
    public _Reserved2_e__FixedBuffer Reserved2;
    /// <include file='LDR_DATA_TABLE_ENTRY.xml' path='doc/member[@name="LDR_DATA_TABLE_ENTRY.DllBase"]/*'/>
    [NativeTypeName("PVOID")]
    public void* DllBase;
    /// <include file='LDR_DATA_TABLE_ENTRY.xml' path='doc/member[@name="LDR_DATA_TABLE_ENTRY.Reserved3"]/*'/>
    [NativeTypeName("PVOID[2]")]
    public _Reserved3_e__FixedBuffer Reserved3;
    /// <include file='LDR_DATA_TABLE_ENTRY.xml' path='doc/member[@name="LDR_DATA_TABLE_ENTRY.FullDllName"]/*'/>
    public UNICODE_STRING FullDllName;
    /// <include file='LDR_DATA_TABLE_ENTRY.xml' path='doc/member[@name="LDR_DATA_TABLE_ENTRY.Reserved4"]/*'/>
    [NativeTypeName("BYTE[8]")]
    public fixed byte Reserved4[8];
    /// <include file='LDR_DATA_TABLE_ENTRY.xml' path='doc/member[@name="LDR_DATA_TABLE_ENTRY.Reserved5"]/*'/>
    [NativeTypeName("PVOID[3]")]
    public _Reserved5_e__FixedBuffer Reserved5;
    /// <include file='LDR_DATA_TABLE_ENTRY.xml' path='doc/member[@name="LDR_DATA_TABLE_ENTRY.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winternl_L157_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='LDR_DATA_TABLE_ENTRY.xml' path='doc/member[@name="LDR_DATA_TABLE_ENTRY.TimeDateStamp"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TimeDateStamp;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CheckSum"]/*'/>
    [UnscopedRef]
    public ref uint CheckSum
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.CheckSum;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved6"]/*'/>
    [UnscopedRef]
    public ref void* Reserved6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Reserved6;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CheckSum"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint CheckSum;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved6"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PVOID")]
        public void* Reserved6;
    }

    /// <include file='_Reserved1_e__FixedBuffer.xml' path='doc/member[@name="_Reserved1_e__FixedBuffer"]/*'/>
    public unsafe partial struct _Reserved1_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    /// <include file='_Reserved2_e__FixedBuffer.xml' path='doc/member[@name="_Reserved2_e__FixedBuffer"]/*'/>
    public unsafe partial struct _Reserved2_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    /// <include file='_Reserved3_e__FixedBuffer.xml' path='doc/member[@name="_Reserved3_e__FixedBuffer"]/*'/>
    public unsafe partial struct _Reserved3_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    /// <include file='_Reserved5_e__FixedBuffer.xml' path='doc/member[@name="_Reserved5_e__FixedBuffer"]/*'/>
    public unsafe partial struct _Reserved5_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}