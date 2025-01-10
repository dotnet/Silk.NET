// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_QUERY_DATA_PIPELINE_STATISTICS1
{
    [NativeTypeName("UINT64")]
    public ulong IAVertices;

    [NativeTypeName("UINT64")]
    public ulong IAPrimitives;

    [NativeTypeName("UINT64")]
    public ulong VSInvocations;

    [NativeTypeName("UINT64")]
    public ulong GSInvocations;

    [NativeTypeName("UINT64")]
    public ulong GSPrimitives;

    [NativeTypeName("UINT64")]
    public ulong CInvocations;

    [NativeTypeName("UINT64")]
    public ulong CPrimitives;

    [NativeTypeName("UINT64")]
    public ulong PSInvocations;

    [NativeTypeName("UINT64")]
    public ulong HSInvocations;

    [NativeTypeName("UINT64")]
    public ulong DSInvocations;

    [NativeTypeName("UINT64")]
    public ulong CSInvocations;

    [NativeTypeName("UINT64")]
    public ulong ASInvocations;

    [NativeTypeName("UINT64")]
    public ulong MSInvocations;

    [NativeTypeName("UINT64")]
    public ulong MSPrimitives;
}
