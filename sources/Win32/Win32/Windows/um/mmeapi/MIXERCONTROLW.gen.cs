// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERCONTROLW
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("DWORD")]
    public uint dwControlID;

    [NativeTypeName("DWORD")]
    public uint dwControlType;

    [NativeTypeName("DWORD")]
    public uint fdwControl;

    [NativeTypeName("DWORD")]
    public uint cMultipleItems;

    [NativeTypeName("WCHAR[16]")]
    public _szShortName_e__FixedBuffer szShortName;

    [NativeTypeName("WCHAR[64]")]
    public _szName_e__FixedBuffer szName;

    [NativeTypeName("__AnonymousRecord_mmeapi_L2081_C5")]
    public _Bounds_e__Union Bounds;

    [NativeTypeName("__AnonymousRecord_mmeapi_L2092_C5")]
    public _Metrics_e__Union Metrics;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _Bounds_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_mmeapi_L2082_C9")]
        public _Anonymous1_e__Struct Anonymous1;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_mmeapi_L2086_C9")]
        public _Anonymous2_e__Struct Anonymous2;

        [FieldOffset(0)]
        [NativeTypeName("DWORD[6]")]
        public _dwReserved_e__FixedBuffer dwReserved;

        [UnscopedRef]
        public ref int lMinimum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Anonymous1.lMinimum; }
        }

        [UnscopedRef]
        public ref int lMaximum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Anonymous1.lMaximum; }
        }

        [UnscopedRef]
        public ref uint dwMinimum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Anonymous2.dwMinimum; }
        }

        [UnscopedRef]
        public ref uint dwMaximum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Anonymous2.dwMaximum; }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _Anonymous1_e__Struct
        {
            [NativeTypeName("LONG")]
            public int lMinimum;

            [NativeTypeName("LONG")]
            public int lMaximum;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _Anonymous2_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint dwMinimum;

            [NativeTypeName("DWORD")]
            public uint dwMaximum;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        [InlineArray(6)]
        public partial struct _dwReserved_e__FixedBuffer
        {
            public uint e0;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _Metrics_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cSteps;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbCustomData;

        [FieldOffset(0)]
        [NativeTypeName("DWORD[6]")]
        public _dwReserved_e__FixedBuffer dwReserved;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        [InlineArray(6)]
        public partial struct _dwReserved_e__FixedBuffer
        {
            public uint e0;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    public partial struct _szShortName_e__FixedBuffer
    {
        public ushort e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(64)]
    public partial struct _szName_e__FixedBuffer
    {
        public ushort e0;
    }
}
