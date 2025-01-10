// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DML_GRAPH_DESC
{
    public uint InputCount;
    public uint OutputCount;
    public uint NodeCount;

    [NativeTypeName("const DML_GRAPH_NODE_DESC *")]
    public DML_GRAPH_NODE_DESC* Nodes;
    public uint InputEdgeCount;

    [NativeTypeName("const DML_GRAPH_EDGE_DESC *")]
    public DML_GRAPH_EDGE_DESC* InputEdges;
    public uint OutputEdgeCount;

    [NativeTypeName("const DML_GRAPH_EDGE_DESC *")]
    public DML_GRAPH_EDGE_DESC* OutputEdges;
    public uint IntermediateEdgeCount;

    [NativeTypeName("const DML_GRAPH_EDGE_DESC *")]
    public DML_GRAPH_EDGE_DESC* IntermediateEdges;
}
