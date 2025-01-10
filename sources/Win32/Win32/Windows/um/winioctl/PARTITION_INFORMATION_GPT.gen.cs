// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PARTITION_INFORMATION_GPT
{
    public Guid PartitionType;
    public Guid PartitionId;

    [NativeTypeName("DWORD64")]
    public ulong Attributes;

    [NativeTypeName("WCHAR[36]")]
    public _Name_e__FixedBuffer Name;

    [InlineArray(36)]
    public partial struct _Name_e__FixedBuffer
    {
        public ushort e0;
    }
}
