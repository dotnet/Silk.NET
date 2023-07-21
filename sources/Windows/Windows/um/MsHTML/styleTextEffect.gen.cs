// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='styleTextEffect.xml' path='doc/member[@name="styleTextEffect"]/*' />
public enum styleTextEffect
{
    /// <include file='styleTextEffect.xml' path='doc/member[@name="styleTextEffect.styleTextEffectNone"]/*' />
    styleTextEffectNone = 0,

    /// <include file='styleTextEffect.xml' path='doc/member[@name="styleTextEffect.styleTextEffectEmboss"]/*' />
    styleTextEffectEmboss = 1,

    /// <include file='styleTextEffect.xml' path='doc/member[@name="styleTextEffect.styleTextEffectEngrave"]/*' />
    styleTextEffectEngrave = 2,

    /// <include file='styleTextEffect.xml' path='doc/member[@name="styleTextEffect.styleTextEffectOutline"]/*' />
    styleTextEffectOutline = 3,

    /// <include file='styleTextEffect.xml' path='doc/member[@name="styleTextEffect.styleTextEffect_Max"]/*' />
    styleTextEffect_Max = 2147483647,
}
