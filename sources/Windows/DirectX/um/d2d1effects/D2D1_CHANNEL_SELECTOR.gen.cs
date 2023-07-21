// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_CHANNEL_SELECTOR.xml' path='doc/member[@name="D2D1_CHANNEL_SELECTOR"]/*' />
public enum D2D1_CHANNEL_SELECTOR
{
    /// <include file='D2D1_CHANNEL_SELECTOR.xml' path='doc/member[@name="D2D1_CHANNEL_SELECTOR.D2D1_CHANNEL_SELECTOR_R"]/*' />
    D2D1_CHANNEL_SELECTOR_R = 0,

    /// <include file='D2D1_CHANNEL_SELECTOR.xml' path='doc/member[@name="D2D1_CHANNEL_SELECTOR.D2D1_CHANNEL_SELECTOR_G"]/*' />
    D2D1_CHANNEL_SELECTOR_G = 1,

    /// <include file='D2D1_CHANNEL_SELECTOR.xml' path='doc/member[@name="D2D1_CHANNEL_SELECTOR.D2D1_CHANNEL_SELECTOR_B"]/*' />
    D2D1_CHANNEL_SELECTOR_B = 2,

    /// <include file='D2D1_CHANNEL_SELECTOR.xml' path='doc/member[@name="D2D1_CHANNEL_SELECTOR.D2D1_CHANNEL_SELECTOR_A"]/*' />
    D2D1_CHANNEL_SELECTOR_A = 3,

    /// <include file='D2D1_CHANNEL_SELECTOR.xml' path='doc/member[@name="D2D1_CHANNEL_SELECTOR.D2D1_CHANNEL_SELECTOR_FORCE_DWORD"]/*' />
    D2D1_CHANNEL_SELECTOR_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
