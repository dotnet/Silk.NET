// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_UDP6ROW2
{
    [NativeTypeName("UCHAR[16]")]
    public _ucLocalAddr_e__FixedBuffer ucLocalAddr;

    [NativeTypeName("DWORD")]
    public uint dwLocalScopeId;

    [NativeTypeName("DWORD")]
    public uint dwLocalPort;

    [NativeTypeName("DWORD")]
    public uint dwOwningPid;
    public LARGE_INTEGER liCreateTimestamp;

    [NativeTypeName("__AnonymousRecord_udpmib_L177_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("ULONGLONG[16]")]
    public _OwningModuleInfo_e__FixedBuffer OwningModuleInfo;

    [NativeTypeName("UCHAR[16]")]
    public _ucRemoteAddr_e__FixedBuffer ucRemoteAddr;

    [NativeTypeName("DWORD")]
    public uint dwRemoteScopeId;

    [NativeTypeName("DWORD")]
    public uint dwRemotePort;
    public int SpecificPortBind
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.SpecificPortBind; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.SpecificPortBind = value; }
    }

    [UnscopedRef]
    public ref int dwFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwFlags; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_udpmib_L178_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        public int dwFlags;

        public partial struct _Anonymous_e__Struct
        {
            public int _bitfield;

            [NativeTypeName("int : 1")]
            public int SpecificPortBind
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield << 31) >> 31; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0x1) | (value & 0x1); }
            }
        }
    }

    [InlineArray(16)]
    public partial struct _ucLocalAddr_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _OwningModuleInfo_e__FixedBuffer
    {
        public ulong e0;
    }

    [InlineArray(16)]
    public partial struct _ucRemoteAddr_e__FixedBuffer
    {
        public byte e0;
    }
}
