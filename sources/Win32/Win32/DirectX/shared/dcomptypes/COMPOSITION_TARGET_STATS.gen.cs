// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct COMPOSITION_TARGET_STATS
{
    public uint outstandingPresents;

    [NativeTypeName("UINT64")]
    public ulong presentTime;

    [NativeTypeName("UINT64")]
    public ulong vblankDuration;
    public COMPOSITION_STATS presentedStats;
    public COMPOSITION_STATS completedStats;
}
