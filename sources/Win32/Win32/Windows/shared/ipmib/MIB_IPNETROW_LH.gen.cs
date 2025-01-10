// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_IPNETROW_LH
{
    [NativeTypeName("IF_INDEX")]
    public uint dwIndex;

    [NativeTypeName("DWORD")]
    public uint dwPhysAddrLen;

    [NativeTypeName("UCHAR[8]")]
    public _bPhysAddr_e__FixedBuffer bPhysAddr;

    [NativeTypeName("DWORD")]
    public uint dwAddr;

    [NativeTypeName("__AnonymousRecord_ipmib_L159_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint dwType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwType; }
    }

    [UnscopedRef]
    public ref MIB_IPNET_TYPE Type
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Type; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwType;

        [FieldOffset(0)]
        public MIB_IPNET_TYPE Type;
    }

    [InlineArray(8)]
    public partial struct _bPhysAddr_e__FixedBuffer
    {
        public byte e0;
    }
}
