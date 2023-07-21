// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_MEDIA_ENGINE_CREATEFLAGS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_CREATEFLAGS"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_CREATEFLAGS
{
    /// <include file='MF_MEDIA_ENGINE_CREATEFLAGS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_CREATEFLAGS.MF_MEDIA_ENGINE_AUDIOONLY"]/*' />
    MF_MEDIA_ENGINE_AUDIOONLY = 0x1,

    /// <include file='MF_MEDIA_ENGINE_CREATEFLAGS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_CREATEFLAGS.MF_MEDIA_ENGINE_WAITFORSTABLE_STATE"]/*' />
    MF_MEDIA_ENGINE_WAITFORSTABLE_STATE = 0x2,

    /// <include file='MF_MEDIA_ENGINE_CREATEFLAGS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_CREATEFLAGS.MF_MEDIA_ENGINE_FORCEMUTE"]/*' />
    MF_MEDIA_ENGINE_FORCEMUTE = 0x4,

    /// <include file='MF_MEDIA_ENGINE_CREATEFLAGS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_CREATEFLAGS.MF_MEDIA_ENGINE_REAL_TIME_MODE"]/*' />
    MF_MEDIA_ENGINE_REAL_TIME_MODE = 0x8,

    /// <include file='MF_MEDIA_ENGINE_CREATEFLAGS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_CREATEFLAGS.MF_MEDIA_ENGINE_DISABLE_LOCAL_PLUGINS"]/*' />
    MF_MEDIA_ENGINE_DISABLE_LOCAL_PLUGINS = 0x10,

    /// <include file='MF_MEDIA_ENGINE_CREATEFLAGS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_CREATEFLAGS.MF_MEDIA_ENGINE_CREATEFLAGS_MASK"]/*' />
    MF_MEDIA_ENGINE_CREATEFLAGS_MASK = 0x1f,
}
