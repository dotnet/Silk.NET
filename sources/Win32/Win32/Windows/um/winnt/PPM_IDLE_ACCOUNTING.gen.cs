// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PPM_IDLE_ACCOUNTING
{
    [NativeTypeName("DWORD")]
    public uint StateCount;

    [NativeTypeName("DWORD")]
    public uint TotalTransitions;

    [NativeTypeName("DWORD")]
    public uint ResetCount;

    [NativeTypeName("DWORD64")]
    public ulong StartTime;

    [NativeTypeName("PPM_IDLE_STATE_ACCOUNTING[1]")]
    public _State_e__FixedBuffer State;

    public partial struct _State_e__FixedBuffer
    {
        public PPM_IDLE_STATE_ACCOUNTING e0;

        [UnscopedRef]
        public ref PPM_IDLE_STATE_ACCOUNTING this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PPM_IDLE_STATE_ACCOUNTING> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
