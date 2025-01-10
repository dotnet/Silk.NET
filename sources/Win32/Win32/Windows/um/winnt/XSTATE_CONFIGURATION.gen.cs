// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct XSTATE_CONFIGURATION
{
    [NativeTypeName("DWORD64")]
    public ulong EnabledFeatures;

    [NativeTypeName("DWORD64")]
    public ulong EnabledVolatileFeatures;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("__AnonymousRecord_winnt_L14441_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("XSTATE_FEATURE[64]")]
    public _Features_e__FixedBuffer Features;

    [NativeTypeName("DWORD64")]
    public ulong EnabledSupervisorFeatures;

    [NativeTypeName("DWORD64")]
    public ulong AlignedFeatures;

    [NativeTypeName("DWORD")]
    public uint AllFeatureSize;

    [NativeTypeName("DWORD[64]")]
    public _AllFeatures_e__FixedBuffer AllFeatures;

    [NativeTypeName("DWORD64")]
    public ulong EnabledUserVisibleSupervisorFeatures;

    [NativeTypeName("DWORD64")]
    public ulong ExtendedFeatureDisableFeatures;

    [NativeTypeName("DWORD")]
    public uint AllNonLargeFeatureSize;

    [NativeTypeName("WORD")]
    public ushort MaxSveVectorLength;

    [NativeTypeName("WORD")]
    public ushort Spare1;

    [UnscopedRef]
    public ref uint ControlFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ControlFlags; }
    }
    public uint OptimizedSave
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.OptimizedSave; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.OptimizedSave = value; }
    }
    public uint CompactionEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.CompactionEnabled; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.CompactionEnabled = value; }
    }
    public uint ExtendedFeatureDisable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.ExtendedFeatureDisable; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.ExtendedFeatureDisable = value; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint ControlFlags;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L14443_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("DWORD : 1")]
            public uint OptimizedSave
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint CompactionEnabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 1) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint ExtendedFeatureDisable
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 2) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2); }
            }
        }
    }

    [InlineArray(64)]
    public partial struct _Features_e__FixedBuffer
    {
        public XSTATE_FEATURE e0;
    }

    [InlineArray(64)]
    public partial struct _AllFeatures_e__FixedBuffer
    {
        public uint e0;
    }
}
