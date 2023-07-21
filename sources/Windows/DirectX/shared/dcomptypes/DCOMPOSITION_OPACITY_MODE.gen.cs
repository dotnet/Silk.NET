// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DCOMPOSITION_OPACITY_MODE.xml' path='doc/member[@name="DCOMPOSITION_OPACITY_MODE"]/*' />
public enum DCOMPOSITION_OPACITY_MODE
{
    /// <include file='DCOMPOSITION_OPACITY_MODE.xml' path='doc/member[@name="DCOMPOSITION_OPACITY_MODE.DCOMPOSITION_OPACITY_MODE_LAYER"]/*' />
    DCOMPOSITION_OPACITY_MODE_LAYER = 0,

    /// <include file='DCOMPOSITION_OPACITY_MODE.xml' path='doc/member[@name="DCOMPOSITION_OPACITY_MODE.DCOMPOSITION_OPACITY_MODE_MULTIPLY"]/*' />
    DCOMPOSITION_OPACITY_MODE_MULTIPLY = 1,

    /// <include file='DCOMPOSITION_OPACITY_MODE.xml' path='doc/member[@name="DCOMPOSITION_OPACITY_MODE.DCOMPOSITION_OPACITY_MODE_INHERIT"]/*' />
    DCOMPOSITION_OPACITY_MODE_INHERIT = unchecked((int)(0xffffffff)),
}
