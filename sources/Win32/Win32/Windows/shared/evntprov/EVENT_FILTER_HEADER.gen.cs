// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EVENT_FILTER_HEADER
{
    public ushort Id;

    [NativeTypeName("UCHAR")]
    public byte Version;

    [NativeTypeName("UCHAR[5]")]
    public _Reserved_e__FixedBuffer Reserved;

    [NativeTypeName("ULONGLONG")]
    public ulong InstanceId;

    [NativeTypeName("ULONG")]
    public uint Size;

    [NativeTypeName("ULONG")]
    public uint NextOffset;

    [InlineArray(5)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
