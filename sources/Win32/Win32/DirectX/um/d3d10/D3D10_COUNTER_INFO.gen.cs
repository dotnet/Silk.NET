// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D10_COUNTER_INFO
{
    public D3D10_COUNTER LastDeviceDependentCounter;
    public uint NumSimultaneousCounters;

    [NativeTypeName("UINT8")]
    public byte NumDetectableParallelUnits;
}
