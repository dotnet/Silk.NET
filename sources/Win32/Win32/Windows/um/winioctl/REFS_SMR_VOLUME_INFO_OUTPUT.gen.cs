// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct REFS_SMR_VOLUME_INFO_OUTPUT
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Flags;
    public LARGE_INTEGER SizeOfRandomlyWritableTier;
    public LARGE_INTEGER FreeSpaceInRandomlyWritableTier;
    public LARGE_INTEGER SizeofSMRTier;
    public LARGE_INTEGER FreeSpaceInSMRTier;
    public LARGE_INTEGER UsableFreeSpaceInSMRTier;
    public REFS_SMR_VOLUME_GC_STATE VolumeGcState;

    [NativeTypeName("DWORD")]
    public uint VolumeGcLastStatus;

    [NativeTypeName("DWORD")]
    public uint CurrentGcBandFillPercentage;

    [NativeTypeName("DWORDLONG[6]")]
    public _Unused_e__FixedBuffer Unused;

    [InlineArray(6)]
    public partial struct _Unused_e__FixedBuffer
    {
        public ulong e0;
    }
}
