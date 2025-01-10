// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PPM_WMI_IDLE_STATES
{
    [NativeTypeName("DWORD")]
    public uint Type;

    [NativeTypeName("DWORD")]
    public uint Count;

    [NativeTypeName("DWORD")]
    public uint TargetState;

    [NativeTypeName("DWORD")]
    public uint OldState;

    [NativeTypeName("DWORD64")]
    public ulong TargetProcessors;

    [NativeTypeName("PPM_WMI_IDLE_STATE[1]")]
    public _State_e__FixedBuffer State;

    public partial struct _State_e__FixedBuffer
    {
        public PPM_WMI_IDLE_STATE e0;

        [UnscopedRef]
        public ref PPM_WMI_IDLE_STATE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PPM_WMI_IDLE_STATE> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
