// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_MEDIA_ENGINE_EXTENSION_TYPE.xml' path='doc/member[@name="MF_MEDIA_ENGINE_EXTENSION_TYPE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_EXTENSION_TYPE
{
    /// <include file='MF_MEDIA_ENGINE_EXTENSION_TYPE.xml' path='doc/member[@name="MF_MEDIA_ENGINE_EXTENSION_TYPE.MF_MEDIA_ENGINE_EXTENSION_TYPE_MEDIASOURCE"]/*' />
    MF_MEDIA_ENGINE_EXTENSION_TYPE_MEDIASOURCE = 0,

    /// <include file='MF_MEDIA_ENGINE_EXTENSION_TYPE.xml' path='doc/member[@name="MF_MEDIA_ENGINE_EXTENSION_TYPE.MF_MEDIA_ENGINE_EXTENSION_TYPE_BYTESTREAM"]/*' />
    MF_MEDIA_ENGINE_EXTENSION_TYPE_BYTESTREAM = 1,
}
