// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_ALLOCATE_BC_STREAM_INPUT
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint RequestsPerPeriod;

    [NativeTypeName("DWORD")]
    public uint Period;

    [NativeTypeName("BOOLEAN")]
    public byte RetryFailures;

    [NativeTypeName("BOOLEAN")]
    public byte Discardable;

    [NativeTypeName("BOOLEAN[2]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    [NativeTypeName("DWORD")]
    public uint AccessType;

    [NativeTypeName("DWORD")]
    public uint AccessMode;

    [InlineArray(2)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public byte e0;
    }
}
