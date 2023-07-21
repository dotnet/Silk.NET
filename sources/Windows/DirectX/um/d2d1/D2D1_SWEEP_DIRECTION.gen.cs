// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_SWEEP_DIRECTION.xml' path='doc/member[@name="D2D1_SWEEP_DIRECTION"]/*' />
public enum D2D1_SWEEP_DIRECTION
{
    /// <include file='D2D1_SWEEP_DIRECTION.xml' path='doc/member[@name="D2D1_SWEEP_DIRECTION.D2D1_SWEEP_DIRECTION_COUNTER_CLOCKWISE"]/*' />
    D2D1_SWEEP_DIRECTION_COUNTER_CLOCKWISE = 0,

    /// <include file='D2D1_SWEEP_DIRECTION.xml' path='doc/member[@name="D2D1_SWEEP_DIRECTION.D2D1_SWEEP_DIRECTION_CLOCKWISE"]/*' />
    D2D1_SWEEP_DIRECTION_CLOCKWISE = 1,

    /// <include file='D2D1_SWEEP_DIRECTION.xml' path='doc/member[@name="D2D1_SWEEP_DIRECTION.D2D1_SWEEP_DIRECTION_FORCE_DWORD"]/*' />
    D2D1_SWEEP_DIRECTION_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
