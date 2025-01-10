// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PPM_IDLE_STATE_ACCOUNTING_EX
{
    [NativeTypeName("DWORD64")]
    public ulong TotalTime;

    [NativeTypeName("DWORD")]
    public uint IdleTransitions;

    [NativeTypeName("DWORD")]
    public uint FailedTransitions;

    [NativeTypeName("DWORD")]
    public uint InvalidBucketIndex;

    [NativeTypeName("DWORD")]
    public uint MinTimeUs;

    [NativeTypeName("DWORD")]
    public uint MaxTimeUs;

    [NativeTypeName("DWORD")]
    public uint CancelledTransitions;

    [NativeTypeName("PPM_IDLE_STATE_BUCKET_EX[16]")]
    public _IdleTimeBuckets_e__FixedBuffer IdleTimeBuckets;

    [InlineArray(16)]
    public partial struct _IdleTimeBuckets_e__FixedBuffer
    {
        public PPM_IDLE_STATE_BUCKET_EX e0;
    }
}
