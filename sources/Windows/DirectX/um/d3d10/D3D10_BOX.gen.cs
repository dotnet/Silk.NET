// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D10_BOX.xml' path='doc/member[@name="D3D10_BOX"]/*' />
public partial struct D3D10_BOX
{
    /// <include file='D3D10_BOX.xml' path='doc/member[@name="D3D10_BOX.left"]/*' />
    public uint left;

    /// <include file='D3D10_BOX.xml' path='doc/member[@name="D3D10_BOX.top"]/*' />
    public uint top;

    /// <include file='D3D10_BOX.xml' path='doc/member[@name="D3D10_BOX.front"]/*' />
    public uint front;

    /// <include file='D3D10_BOX.xml' path='doc/member[@name="D3D10_BOX.right"]/*' />
    public uint right;

    /// <include file='D3D10_BOX.xml' path='doc/member[@name="D3D10_BOX.bottom"]/*' />
    public uint bottom;

    /// <include file='D3D10_BOX.xml' path='doc/member[@name="D3D10_BOX.back"]/*' />
    public uint back;
}
