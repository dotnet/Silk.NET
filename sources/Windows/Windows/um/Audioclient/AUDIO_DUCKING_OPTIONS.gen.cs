// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='AUDIO_DUCKING_OPTIONS.xml' path='doc/member[@name="AUDIO_DUCKING_OPTIONS"]/*' />
[Flags]
[SupportedOSPlatform("windows10.0.19043.0")]
public enum AUDIO_DUCKING_OPTIONS
{
    /// <include file='AUDIO_DUCKING_OPTIONS.xml' path='doc/member[@name="AUDIO_DUCKING_OPTIONS.AUDIO_DUCKING_OPTIONS_DEFAULT"]/*' />
    AUDIO_DUCKING_OPTIONS_DEFAULT = 0,

    /// <include file='AUDIO_DUCKING_OPTIONS.xml' path='doc/member[@name="AUDIO_DUCKING_OPTIONS.AUDIO_DUCKING_OPTIONS_DO_NOT_DUCK_OTHER_STREAMS"]/*' />
    AUDIO_DUCKING_OPTIONS_DO_NOT_DUCK_OTHER_STREAMS = 0x1,
}
