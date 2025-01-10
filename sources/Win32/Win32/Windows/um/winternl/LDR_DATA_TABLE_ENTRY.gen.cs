// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct LDR_DATA_TABLE_ENTRY
{
    [NativeTypeName("PVOID[2]")]
    public _Reserved1_e__FixedBuffer Reserved1;
    public LIST_ENTRY InMemoryOrderLinks;

    [NativeTypeName("PVOID[2]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    [NativeTypeName("PVOID")]
    public void* DllBase;

    [NativeTypeName("PVOID[2]")]
    public _Reserved3_e__FixedBuffer Reserved3;
    public UNICODE_STRING FullDllName;

    [NativeTypeName("BYTE[8]")]
    public _Reserved4_e__FixedBuffer Reserved4;

    [NativeTypeName("PVOID[3]")]
    public _Reserved5_e__FixedBuffer Reserved5;

    [NativeTypeName("__AnonymousRecord_winternl_L157_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("ULONG")]
    public uint TimeDateStamp;

    [UnscopedRef]
    public ref uint CheckSum
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.CheckSum; }
    }

    [UnscopedRef]
    public ref void* Reserved6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Reserved6; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint CheckSum;

        [FieldOffset(0)]
        [NativeTypeName("PVOID")]
        public void* Reserved6;
    }

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

    [InlineArray(8)]
    public partial struct _Reserved4_e__FixedBuffer
    {
        public byte e0;
    }

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
