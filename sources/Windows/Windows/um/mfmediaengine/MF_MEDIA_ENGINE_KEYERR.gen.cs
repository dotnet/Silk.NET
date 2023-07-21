// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_MEDIA_ENGINE_KEYERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_KEYERR"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum MF_MEDIA_ENGINE_KEYERR
{
    /// <include file='MF_MEDIA_ENGINE_KEYERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_KEYERR.MF_MEDIAENGINE_KEYERR_UNKNOWN"]/*' />
    MF_MEDIAENGINE_KEYERR_UNKNOWN = 1,

    /// <include file='MF_MEDIA_ENGINE_KEYERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_KEYERR.MF_MEDIAENGINE_KEYERR_CLIENT"]/*' />
    MF_MEDIAENGINE_KEYERR_CLIENT = 2,

    /// <include file='MF_MEDIA_ENGINE_KEYERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_KEYERR.MF_MEDIAENGINE_KEYERR_SERVICE"]/*' />
    MF_MEDIAENGINE_KEYERR_SERVICE = 3,

    /// <include file='MF_MEDIA_ENGINE_KEYERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_KEYERR.MF_MEDIAENGINE_KEYERR_OUTPUT"]/*' />
    MF_MEDIAENGINE_KEYERR_OUTPUT = 4,

    /// <include file='MF_MEDIA_ENGINE_KEYERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_KEYERR.MF_MEDIAENGINE_KEYERR_HARDWARECHANGE"]/*' />
    MF_MEDIAENGINE_KEYERR_HARDWARECHANGE = 5,

    /// <include file='MF_MEDIA_ENGINE_KEYERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_KEYERR.MF_MEDIAENGINE_KEYERR_DOMAIN"]/*' />
    MF_MEDIAENGINE_KEYERR_DOMAIN = 6,
}
