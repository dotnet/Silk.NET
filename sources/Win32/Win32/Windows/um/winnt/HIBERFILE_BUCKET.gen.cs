// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct HIBERFILE_BUCKET
{
    [NativeTypeName("DWORD64")]
    public ulong MaxPhysicalMemory;

    [NativeTypeName("DWORD[3]")]
    public _PhysicalMemoryPercent_e__FixedBuffer PhysicalMemoryPercent;

    [InlineArray(3)]
    public partial struct _PhysicalMemoryPercent_e__FixedBuffer
    {
        public uint e0;
    }
}
