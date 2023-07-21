// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_MEDIA_ENGINE_NETWORK.xml' path='doc/member[@name="MF_MEDIA_ENGINE_NETWORK"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_NETWORK
{
    /// <include file='MF_MEDIA_ENGINE_NETWORK.xml' path='doc/member[@name="MF_MEDIA_ENGINE_NETWORK.MF_MEDIA_ENGINE_NETWORK_EMPTY"]/*' />
    MF_MEDIA_ENGINE_NETWORK_EMPTY = 0,

    /// <include file='MF_MEDIA_ENGINE_NETWORK.xml' path='doc/member[@name="MF_MEDIA_ENGINE_NETWORK.MF_MEDIA_ENGINE_NETWORK_IDLE"]/*' />
    MF_MEDIA_ENGINE_NETWORK_IDLE = 1,

    /// <include file='MF_MEDIA_ENGINE_NETWORK.xml' path='doc/member[@name="MF_MEDIA_ENGINE_NETWORK.MF_MEDIA_ENGINE_NETWORK_LOADING"]/*' />
    MF_MEDIA_ENGINE_NETWORK_LOADING = 2,

    /// <include file='MF_MEDIA_ENGINE_NETWORK.xml' path='doc/member[@name="MF_MEDIA_ENGINE_NETWORK.MF_MEDIA_ENGINE_NETWORK_NO_SOURCE"]/*' />
    MF_MEDIA_ENGINE_NETWORK_NO_SOURCE = 3,
}
