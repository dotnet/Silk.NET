// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='AUDIO_EFFECT.xml' path='doc/member[@name="AUDIO_EFFECT"]/*'/>
[SupportedOSPlatform("windows10.0.22621.0")]
public partial struct AUDIO_EFFECT
{
    /// <include file='AUDIO_EFFECT.xml' path='doc/member[@name="AUDIO_EFFECT.id"]/*'/>
    public Guid id;
    /// <include file='AUDIO_EFFECT.xml' path='doc/member[@name="AUDIO_EFFECT.canSetState"]/*'/>
    public BOOL canSetState;
    /// <include file='AUDIO_EFFECT.xml' path='doc/member[@name="AUDIO_EFFECT.state"]/*'/>
    public AUDIO_EFFECT_STATE state;
}