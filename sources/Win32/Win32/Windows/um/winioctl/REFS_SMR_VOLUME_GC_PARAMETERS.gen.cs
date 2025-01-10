// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct REFS_SMR_VOLUME_GC_PARAMETERS
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Flags;
    public REFS_SMR_VOLUME_GC_ACTION Action;
    public REFS_SMR_VOLUME_GC_METHOD Method;

    [NativeTypeName("DWORD")]
    public uint IoGranularity;

    [NativeTypeName("DWORD")]
    public uint CompressionFormat;

    [NativeTypeName("DWORDLONG[8]")]
    public _Unused_e__FixedBuffer Unused;

    [InlineArray(8)]
    public partial struct _Unused_e__FixedBuffer
    {
        public ulong e0;
    }
}
