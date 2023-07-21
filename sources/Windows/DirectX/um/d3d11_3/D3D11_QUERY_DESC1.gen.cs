// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_QUERY_DESC1.xml' path='doc/member[@name="D3D11_QUERY_DESC1"]/*' />
public partial struct D3D11_QUERY_DESC1
{
    /// <include file='D3D11_QUERY_DESC1.xml' path='doc/member[@name="D3D11_QUERY_DESC1.Query"]/*' />
    public D3D11_QUERY Query;

    /// <include file='D3D11_QUERY_DESC1.xml' path='doc/member[@name="D3D11_QUERY_DESC1.MiscFlags"]/*' />
    public uint MiscFlags;

    /// <include file='D3D11_QUERY_DESC1.xml' path='doc/member[@name="D3D11_QUERY_DESC1.ContextType"]/*' />
    public D3D11_CONTEXT_TYPE ContextType;
}
