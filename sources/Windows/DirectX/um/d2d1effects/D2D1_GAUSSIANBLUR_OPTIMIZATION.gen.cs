// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_GAUSSIANBLUR_OPTIMIZATION.xml' path='doc/member[@name="D2D1_GAUSSIANBLUR_OPTIMIZATION"]/*' />
public enum D2D1_GAUSSIANBLUR_OPTIMIZATION
{
    /// <include file='D2D1_GAUSSIANBLUR_OPTIMIZATION.xml' path='doc/member[@name="D2D1_GAUSSIANBLUR_OPTIMIZATION.D2D1_GAUSSIANBLUR_OPTIMIZATION_SPEED"]/*' />
    D2D1_GAUSSIANBLUR_OPTIMIZATION_SPEED = 0,

    /// <include file='D2D1_GAUSSIANBLUR_OPTIMIZATION.xml' path='doc/member[@name="D2D1_GAUSSIANBLUR_OPTIMIZATION.D2D1_GAUSSIANBLUR_OPTIMIZATION_BALANCED"]/*' />
    D2D1_GAUSSIANBLUR_OPTIMIZATION_BALANCED = 1,

    /// <include file='D2D1_GAUSSIANBLUR_OPTIMIZATION.xml' path='doc/member[@name="D2D1_GAUSSIANBLUR_OPTIMIZATION.D2D1_GAUSSIANBLUR_OPTIMIZATION_QUALITY"]/*' />
    D2D1_GAUSSIANBLUR_OPTIMIZATION_QUALITY = 2,

    /// <include file='D2D1_GAUSSIANBLUR_OPTIMIZATION.xml' path='doc/member[@name="D2D1_GAUSSIANBLUR_OPTIMIZATION.D2D1_GAUSSIANBLUR_OPTIMIZATION_FORCE_DWORD"]/*' />
    D2D1_GAUSSIANBLUR_OPTIMIZATION_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
