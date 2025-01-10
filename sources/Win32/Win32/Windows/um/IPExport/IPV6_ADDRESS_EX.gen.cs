// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IPV6_ADDRESS_EX
{
    public ushort sin6_port;

    [NativeTypeName("ULONG")]
    public uint sin6_flowinfo;

    [NativeTypeName("USHORT[8]")]
    public _sin6_addr_e__FixedBuffer sin6_addr;

    [NativeTypeName("ULONG")]
    public uint sin6_scope_id;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(8)]
    public partial struct _sin6_addr_e__FixedBuffer
    {
        public ushort e0;
    }
}
