// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct HIDP_VALUE_CAPS
{
    [NativeTypeName("USAGE")]
    public ushort UsagePage;

    [NativeTypeName("UCHAR")]
    public byte ReportID;

    [NativeTypeName("BOOLEAN")]
    public byte IsAlias;
    public ushort BitField;
    public ushort LinkCollection;

    [NativeTypeName("USAGE")]
    public ushort LinkUsage;

    [NativeTypeName("USAGE")]
    public ushort LinkUsagePage;

    [NativeTypeName("BOOLEAN")]
    public byte IsRange;

    [NativeTypeName("BOOLEAN")]
    public byte IsStringRange;

    [NativeTypeName("BOOLEAN")]
    public byte IsDesignatorRange;

    [NativeTypeName("BOOLEAN")]
    public byte IsAbsolute;

    [NativeTypeName("BOOLEAN")]
    public byte HasNull;

    [NativeTypeName("UCHAR")]
    public byte Reserved;
    public ushort BitSize;
    public ushort ReportCount;

    [NativeTypeName("USHORT[5]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    [NativeTypeName("ULONG")]
    public uint UnitsExp;

    [NativeTypeName("ULONG")]
    public uint Units;

    [NativeTypeName("LONG")]
    public int LogicalMin;

    [NativeTypeName("LONG")]
    public int LogicalMax;

    [NativeTypeName("LONG")]
    public int PhysicalMin;

    [NativeTypeName("LONG")]
    public int PhysicalMax;

    [NativeTypeName("__AnonymousRecord_hidpi_L138_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._Range_e__Struct Range
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Range; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._NotRange_e__Struct NotRange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.NotRange; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_hidpi_L139_C9")]
        public _Range_e__Struct Range;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_hidpi_L146_C9")]
        public _NotRange_e__Struct NotRange;

        public partial struct _Range_e__Struct
        {
            [NativeTypeName("USAGE")]
            public ushort UsageMin;

            [NativeTypeName("USAGE")]
            public ushort UsageMax;
            public ushort StringMin;
            public ushort StringMax;
            public ushort DesignatorMin;
            public ushort DesignatorMax;
            public ushort DataIndexMin;
            public ushort DataIndexMax;
        }

        public partial struct _NotRange_e__Struct
        {
            [NativeTypeName("USAGE")]
            public ushort Usage;

            [NativeTypeName("USAGE")]
            public ushort Reserved1;
            public ushort StringIndex;
            public ushort Reserved2;
            public ushort DesignatorIndex;
            public ushort Reserved3;
            public ushort DataIndex;
            public ushort Reserved4;
        }
    }

    [InlineArray(5)]
    public partial struct _Reserved2_e__FixedBuffer
    {
        public ushort e0;
    }
}
