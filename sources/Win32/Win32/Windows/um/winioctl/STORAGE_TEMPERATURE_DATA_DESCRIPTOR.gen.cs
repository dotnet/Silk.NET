// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_TEMPERATURE_DATA_DESCRIPTOR
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;
    public short CriticalTemperature;
    public short WarningTemperature;

    [NativeTypeName("WORD")]
    public ushort InfoCount;

    [NativeTypeName("BYTE[2]")]
    public _Reserved0_e__FixedBuffer Reserved0;

    [NativeTypeName("DWORD[2]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    [NativeTypeName("STORAGE_TEMPERATURE_INFO[1]")]
    public _TemperatureInfo_e__FixedBuffer TemperatureInfo;

    [InlineArray(2)]
    public partial struct _Reserved0_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public uint e0;
    }

    public partial struct _TemperatureInfo_e__FixedBuffer
    {
        public STORAGE_TEMPERATURE_INFO e0;

        [UnscopedRef]
        public ref STORAGE_TEMPERATURE_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_TEMPERATURE_INFO> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
