// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT
{
    public D3D_OMAC omac;
    public Guid QueryType;
    public HANDLE hChannel;
    public uint SequenceNumber;
    public HRESULT ReturnCode;
}
