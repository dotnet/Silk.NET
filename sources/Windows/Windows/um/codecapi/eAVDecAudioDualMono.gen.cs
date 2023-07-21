// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='eAVDecAudioDualMono.xml' path='doc/member[@name="eAVDecAudioDualMono"]/*' />
public enum eAVDecAudioDualMono
{
    /// <include file='eAVDecAudioDualMono.xml' path='doc/member[@name="eAVDecAudioDualMono.eAVDecAudioDualMono_IsNotDualMono"]/*' />
    eAVDecAudioDualMono_IsNotDualMono = 0,

    /// <include file='eAVDecAudioDualMono.xml' path='doc/member[@name="eAVDecAudioDualMono.eAVDecAudioDualMono_IsDualMono"]/*' />
    eAVDecAudioDualMono_IsDualMono = 1,

    /// <include file='eAVDecAudioDualMono.xml' path='doc/member[@name="eAVDecAudioDualMono.eAVDecAudioDualMono_UnSpecified"]/*' />
    eAVDecAudioDualMono_UnSpecified = 2,
}
