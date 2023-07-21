// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_RENDERING_CONTROLS.xml' path='doc/member[@name="D2D1_RENDERING_CONTROLS"]/*' />
public partial struct D2D1_RENDERING_CONTROLS
{
    /// <include file='D2D1_RENDERING_CONTROLS.xml' path='doc/member[@name="D2D1_RENDERING_CONTROLS.bufferPrecision"]/*' />
    public D2D1_BUFFER_PRECISION bufferPrecision;

    /// <include file='D2D1_RENDERING_CONTROLS.xml' path='doc/member[@name="D2D1_RENDERING_CONTROLS.tileSize"]/*' />
    [NativeTypeName("D2D1_SIZE_U")]
    public D2D_SIZE_U tileSize;
}
