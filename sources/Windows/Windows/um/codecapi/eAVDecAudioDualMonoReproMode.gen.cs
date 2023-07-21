// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='eAVDecAudioDualMonoReproMode.xml' path='doc/member[@name="eAVDecAudioDualMonoReproMode"]/*' />
public enum eAVDecAudioDualMonoReproMode
{
    /// <include file='eAVDecAudioDualMonoReproMode.xml' path='doc/member[@name="eAVDecAudioDualMonoReproMode.eAVDecAudioDualMonoReproMode_STEREO"]/*' />
    eAVDecAudioDualMonoReproMode_STEREO = 0,

    /// <include file='eAVDecAudioDualMonoReproMode.xml' path='doc/member[@name="eAVDecAudioDualMonoReproMode.eAVDecAudioDualMonoReproMode_LEFT_MONO"]/*' />
    eAVDecAudioDualMonoReproMode_LEFT_MONO = 1,

    /// <include file='eAVDecAudioDualMonoReproMode.xml' path='doc/member[@name="eAVDecAudioDualMonoReproMode.eAVDecAudioDualMonoReproMode_RIGHT_MONO"]/*' />
    eAVDecAudioDualMonoReproMode_RIGHT_MONO = 2,

    /// <include file='eAVDecAudioDualMonoReproMode.xml' path='doc/member[@name="eAVDecAudioDualMonoReproMode.eAVDecAudioDualMonoReproMode_MIX_MONO"]/*' />
    eAVDecAudioDualMonoReproMode_MIX_MONO = 3,
}
