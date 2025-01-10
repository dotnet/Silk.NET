// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3DRECTPATCH_INFO
{
    public uint StartVertexOffsetWidth;
    public uint StartVertexOffsetHeight;
    public uint Width;
    public uint Height;
    public uint Stride;
    public D3DBASISTYPE Basis;
    public D3DDEGREETYPE Degree;
}
