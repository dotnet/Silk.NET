// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D2D1_SVG_PRESERVE_ASPECT_RATIO.xml' path='doc/member[@name="D2D1_SVG_PRESERVE_ASPECT_RATIO"]/*' />
public partial struct D2D1_SVG_PRESERVE_ASPECT_RATIO
{
    /// <include file='D2D1_SVG_PRESERVE_ASPECT_RATIO.xml' path='doc/member[@name="D2D1_SVG_PRESERVE_ASPECT_RATIO.defer"]/*' />
    public BOOL defer;

    /// <include file='D2D1_SVG_PRESERVE_ASPECT_RATIO.xml' path='doc/member[@name="D2D1_SVG_PRESERVE_ASPECT_RATIO.align"]/*' />
    public D2D1_SVG_ASPECT_ALIGN align;

    /// <include file='D2D1_SVG_PRESERVE_ASPECT_RATIO.xml' path='doc/member[@name="D2D1_SVG_PRESERVE_ASPECT_RATIO.meetOrSlice"]/*' />
    public D2D1_SVG_ASPECT_SCALING meetOrSlice;
}
