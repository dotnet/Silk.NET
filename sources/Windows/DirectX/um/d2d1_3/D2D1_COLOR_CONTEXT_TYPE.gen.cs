// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_COLOR_CONTEXT_TYPE.xml' path='doc/member[@name="D2D1_COLOR_CONTEXT_TYPE"]/*' />
public enum D2D1_COLOR_CONTEXT_TYPE
{
    /// <include file='D2D1_COLOR_CONTEXT_TYPE.xml' path='doc/member[@name="D2D1_COLOR_CONTEXT_TYPE.D2D1_COLOR_CONTEXT_TYPE_ICC"]/*' />
    D2D1_COLOR_CONTEXT_TYPE_ICC = 0,

    /// <include file='D2D1_COLOR_CONTEXT_TYPE.xml' path='doc/member[@name="D2D1_COLOR_CONTEXT_TYPE.D2D1_COLOR_CONTEXT_TYPE_SIMPLE"]/*' />
    D2D1_COLOR_CONTEXT_TYPE_SIMPLE = 1,

    /// <include file='D2D1_COLOR_CONTEXT_TYPE.xml' path='doc/member[@name="D2D1_COLOR_CONTEXT_TYPE.D2D1_COLOR_CONTEXT_TYPE_DXGI"]/*' />
    D2D1_COLOR_CONTEXT_TYPE_DXGI = 2,

    /// <include file='D2D1_COLOR_CONTEXT_TYPE.xml' path='doc/member[@name="D2D1_COLOR_CONTEXT_TYPE.D2D1_COLOR_CONTEXT_TYPE_FORCE_DWORD"]/*' />
    D2D1_COLOR_CONTEXT_TYPE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
