// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='AUDIO_EFFECT_STATE.xml' path='doc/member[@name="AUDIO_EFFECT_STATE"]/*' />
[SupportedOSPlatform("windows10.0.22621.0")]
public enum AUDIO_EFFECT_STATE
{
    /// <include file='AUDIO_EFFECT_STATE.xml' path='doc/member[@name="AUDIO_EFFECT_STATE.AUDIO_EFFECT_STATE_OFF"]/*' />
    AUDIO_EFFECT_STATE_OFF = 0,

    /// <include file='AUDIO_EFFECT_STATE.xml' path='doc/member[@name="AUDIO_EFFECT_STATE.AUDIO_EFFECT_STATE_ON"]/*' />
    AUDIO_EFFECT_STATE_ON = (AUDIO_EFFECT_STATE_OFF + 1),
}
