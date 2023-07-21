// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_MEDIA_ENGINE_PRELOAD.xml' path='doc/member[@name="MF_MEDIA_ENGINE_PRELOAD"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_PRELOAD
{
    /// <include file='MF_MEDIA_ENGINE_PRELOAD.xml' path='doc/member[@name="MF_MEDIA_ENGINE_PRELOAD.MF_MEDIA_ENGINE_PRELOAD_MISSING"]/*' />
    MF_MEDIA_ENGINE_PRELOAD_MISSING = 0,

    /// <include file='MF_MEDIA_ENGINE_PRELOAD.xml' path='doc/member[@name="MF_MEDIA_ENGINE_PRELOAD.MF_MEDIA_ENGINE_PRELOAD_EMPTY"]/*' />
    MF_MEDIA_ENGINE_PRELOAD_EMPTY = 1,

    /// <include file='MF_MEDIA_ENGINE_PRELOAD.xml' path='doc/member[@name="MF_MEDIA_ENGINE_PRELOAD.MF_MEDIA_ENGINE_PRELOAD_NONE"]/*' />
    MF_MEDIA_ENGINE_PRELOAD_NONE = 2,

    /// <include file='MF_MEDIA_ENGINE_PRELOAD.xml' path='doc/member[@name="MF_MEDIA_ENGINE_PRELOAD.MF_MEDIA_ENGINE_PRELOAD_METADATA"]/*' />
    MF_MEDIA_ENGINE_PRELOAD_METADATA = 3,

    /// <include file='MF_MEDIA_ENGINE_PRELOAD.xml' path='doc/member[@name="MF_MEDIA_ENGINE_PRELOAD.MF_MEDIA_ENGINE_PRELOAD_AUTOMATIC"]/*' />
    MF_MEDIA_ENGINE_PRELOAD_AUTOMATIC = 4,
}
