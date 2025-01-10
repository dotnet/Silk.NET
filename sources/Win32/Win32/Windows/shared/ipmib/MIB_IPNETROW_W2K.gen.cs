// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_IPNETROW_W2K
{
    [NativeTypeName("IF_INDEX")]
    public uint dwIndex;

    [NativeTypeName("DWORD")]
    public uint dwPhysAddrLen;

    [NativeTypeName("UCHAR[8]")]
    public _bPhysAddr_e__FixedBuffer bPhysAddr;

    [NativeTypeName("DWORD")]
    public uint dwAddr;

    [NativeTypeName("DWORD")]
    public uint dwType;

    [InlineArray(8)]
    public partial struct _bPhysAddr_e__FixedBuffer
    {
        public byte e0;
    }
}
