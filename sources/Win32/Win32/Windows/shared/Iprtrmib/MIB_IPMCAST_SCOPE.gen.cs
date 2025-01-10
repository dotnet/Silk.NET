// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_IPMCAST_SCOPE
{
    [NativeTypeName("DWORD")]
    public uint dwGroupAddress;

    [NativeTypeName("DWORD")]
    public uint dwGroupMask;

    [NativeTypeName("SCOPE_NAME_BUFFER")]
    public _snNameBuffer_e__FixedBuffer snNameBuffer;

    [NativeTypeName("DWORD")]
    public uint dwStatus;

    [InlineArray(256)]
    public partial struct _snNameBuffer_e__FixedBuffer
    {
        public ushort e0;
    }
}
