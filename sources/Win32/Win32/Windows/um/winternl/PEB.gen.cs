// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PEB
{
    [NativeTypeName("BYTE[2]")]
    public _Reserved1_e__FixedBuffer Reserved1;
    public byte BeingDebugged;

    [NativeTypeName("BYTE[1]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    [NativeTypeName("PVOID[2]")]
    public _Reserved3_e__FixedBuffer Reserved3;

    [NativeTypeName("PPEB_LDR_DATA")]
    public PEB_LDR_DATA* Ldr;

    [NativeTypeName("PRTL_USER_PROCESS_PARAMETERS")]
    public RTL_USER_PROCESS_PARAMETERS* ProcessParameters;

    [NativeTypeName("PVOID[3]")]
    public _Reserved4_e__FixedBuffer Reserved4;

    [NativeTypeName("PVOID")]
    public void* AtlThunkSListPtr;

    [NativeTypeName("PVOID")]
    public void* Reserved5;

    [NativeTypeName("ULONG")]
    public uint Reserved6;

    [NativeTypeName("PVOID")]
    public void* Reserved7;

    [NativeTypeName("ULONG")]
    public uint Reserved8;

    [NativeTypeName("ULONG")]
    public uint AtlThunkSListPtr32;

    [NativeTypeName("PVOID[45]")]
    public _Reserved9_e__FixedBuffer Reserved9;

    [NativeTypeName("BYTE[96]")]
    public _Reserved10_e__FixedBuffer Reserved10;

    [NativeTypeName("PPS_POST_PROCESS_INIT_ROUTINE")]
    public delegate* unmanaged<void> PostProcessInitRoutine;

    [NativeTypeName("BYTE[128]")]
    public _Reserved11_e__FixedBuffer Reserved11;

    [NativeTypeName("PVOID[1]")]
    public _Reserved12_e__FixedBuffer Reserved12;

    [NativeTypeName("ULONG")]
    public uint SessionId;

    [InlineArray(2)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public byte e0;
    }

    public partial struct _Reserved2_e__FixedBuffer
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

    public unsafe partial struct _Reserved4_e__FixedBuffer
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

    public unsafe partial struct _Reserved9_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public void* e3;
        public void* e4;
        public void* e5;
        public void* e6;
        public void* e7;
        public void* e8;
        public void* e9;
        public void* e10;
        public void* e11;
        public void* e12;
        public void* e13;
        public void* e14;
        public void* e15;
        public void* e16;
        public void* e17;
        public void* e18;
        public void* e19;
        public void* e20;
        public void* e21;
        public void* e22;
        public void* e23;
        public void* e24;
        public void* e25;
        public void* e26;
        public void* e27;
        public void* e28;
        public void* e29;
        public void* e30;
        public void* e31;
        public void* e32;
        public void* e33;
        public void* e34;
        public void* e35;
        public void* e36;
        public void* e37;
        public void* e38;
        public void* e39;
        public void* e40;
        public void* e41;
        public void* e42;
        public void* e43;
        public void* e44;
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

    [InlineArray(96)]
    public partial struct _Reserved10_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(128)]
    public partial struct _Reserved11_e__FixedBuffer
    {
        public byte e0;
    }

    public unsafe partial struct _Reserved12_e__FixedBuffer
    {
        public void* e0;
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
