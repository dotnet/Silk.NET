// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='styleBidi.xml' path='doc/member[@name="styleBidi"]/*' />
public enum styleBidi
{
    /// <include file='styleBidi.xml' path='doc/member[@name="styleBidi.styleBidiNotSet"]/*' />
    styleBidiNotSet = 0,

    /// <include file='styleBidi.xml' path='doc/member[@name="styleBidi.styleBidiNormal"]/*' />
    styleBidiNormal = 1,

    /// <include file='styleBidi.xml' path='doc/member[@name="styleBidi.styleBidiEmbed"]/*' />
    styleBidiEmbed = 2,

    /// <include file='styleBidi.xml' path='doc/member[@name="styleBidi.styleBidiOverride"]/*' />
    styleBidiOverride = 3,

    /// <include file='styleBidi.xml' path='doc/member[@name="styleBidi.styleBidiInherit"]/*' />
    styleBidiInherit = 4,

    /// <include file='styleBidi.xml' path='doc/member[@name="styleBidi.styleBidi_Max"]/*' />
    styleBidi_Max = 2147483647,
}
