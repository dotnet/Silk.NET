// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_DEVICE_MANAGEMENT_STATUS
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;
    public STORAGE_DISK_HEALTH_STATUS Health;

    [NativeTypeName("DWORD")]
    public uint NumberOfOperationalStatus;

    [NativeTypeName("DWORD")]
    public uint NumberOfAdditionalReasons;

    [NativeTypeName("STORAGE_DISK_OPERATIONAL_STATUS[16]")]
    public _OperationalStatus_e__FixedBuffer OperationalStatus;

    [NativeTypeName("STORAGE_OPERATIONAL_REASON[1]")]
    public _AdditionalReasons_e__FixedBuffer AdditionalReasons;

    [InlineArray(16)]
    public partial struct _OperationalStatus_e__FixedBuffer
    {
        public STORAGE_DISK_OPERATIONAL_STATUS e0;
    }

    public partial struct _AdditionalReasons_e__FixedBuffer
    {
        public STORAGE_OPERATIONAL_REASON e0;

        [UnscopedRef]
        public ref STORAGE_OPERATIONAL_REASON this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_OPERATIONAL_REASON> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
