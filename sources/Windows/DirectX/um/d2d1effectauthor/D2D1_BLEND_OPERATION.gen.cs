// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_BLEND_OPERATION.xml' path='doc/member[@name="D2D1_BLEND_OPERATION"]/*' />
public enum D2D1_BLEND_OPERATION
{
    /// <include file='D2D1_BLEND_OPERATION.xml' path='doc/member[@name="D2D1_BLEND_OPERATION.D2D1_BLEND_OPERATION_ADD"]/*' />
    D2D1_BLEND_OPERATION_ADD = 1,

    /// <include file='D2D1_BLEND_OPERATION.xml' path='doc/member[@name="D2D1_BLEND_OPERATION.D2D1_BLEND_OPERATION_SUBTRACT"]/*' />
    D2D1_BLEND_OPERATION_SUBTRACT = 2,

    /// <include file='D2D1_BLEND_OPERATION.xml' path='doc/member[@name="D2D1_BLEND_OPERATION.D2D1_BLEND_OPERATION_REV_SUBTRACT"]/*' />
    D2D1_BLEND_OPERATION_REV_SUBTRACT = 3,

    /// <include file='D2D1_BLEND_OPERATION.xml' path='doc/member[@name="D2D1_BLEND_OPERATION.D2D1_BLEND_OPERATION_MIN"]/*' />
    D2D1_BLEND_OPERATION_MIN = 4,

    /// <include file='D2D1_BLEND_OPERATION.xml' path='doc/member[@name="D2D1_BLEND_OPERATION.D2D1_BLEND_OPERATION_MAX"]/*' />
    D2D1_BLEND_OPERATION_MAX = 5,

    /// <include file='D2D1_BLEND_OPERATION.xml' path='doc/member[@name="D2D1_BLEND_OPERATION.D2D1_BLEND_OPERATION_FORCE_DWORD"]/*' />
    D2D1_BLEND_OPERATION_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
