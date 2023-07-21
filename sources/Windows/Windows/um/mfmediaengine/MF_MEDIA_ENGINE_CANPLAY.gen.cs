// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_MEDIA_ENGINE_CANPLAY.xml' path='doc/member[@name="MF_MEDIA_ENGINE_CANPLAY"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_CANPLAY
{
    /// <include file='MF_MEDIA_ENGINE_CANPLAY.xml' path='doc/member[@name="MF_MEDIA_ENGINE_CANPLAY.MF_MEDIA_ENGINE_CANPLAY_NOT_SUPPORTED"]/*' />
    MF_MEDIA_ENGINE_CANPLAY_NOT_SUPPORTED = 0,

    /// <include file='MF_MEDIA_ENGINE_CANPLAY.xml' path='doc/member[@name="MF_MEDIA_ENGINE_CANPLAY.MF_MEDIA_ENGINE_CANPLAY_MAYBE"]/*' />
    MF_MEDIA_ENGINE_CANPLAY_MAYBE = 1,

    /// <include file='MF_MEDIA_ENGINE_CANPLAY.xml' path='doc/member[@name="MF_MEDIA_ENGINE_CANPLAY.MF_MEDIA_ENGINE_CANPLAY_PROBABLY"]/*' />
    MF_MEDIA_ENGINE_CANPLAY_PROBABLY = 2,
}
