// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DML_INPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INPUT_GRAPH_EDGE_DESC"]/*' />
public unsafe partial struct DML_INPUT_GRAPH_EDGE_DESC
{
    /// <include file='DML_INPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INPUT_GRAPH_EDGE_DESC.GraphInputIndex"]/*' />
    public uint GraphInputIndex;

    /// <include file='DML_INPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INPUT_GRAPH_EDGE_DESC.ToNodeIndex"]/*' />
    public uint ToNodeIndex;

    /// <include file='DML_INPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INPUT_GRAPH_EDGE_DESC.ToNodeInputIndex"]/*' />
    public uint ToNodeInputIndex;

    /// <include file='DML_INPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INPUT_GRAPH_EDGE_DESC.Name"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* Name;
}
