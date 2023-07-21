// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_MEDIA_ENGINE_OPM_STATUS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_OPM_STATUS"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum MF_MEDIA_ENGINE_OPM_STATUS
{
    /// <include file='MF_MEDIA_ENGINE_OPM_STATUS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_OPM_STATUS.MF_MEDIA_ENGINE_OPM_NOT_REQUESTED"]/*' />
    MF_MEDIA_ENGINE_OPM_NOT_REQUESTED = 0,

    /// <include file='MF_MEDIA_ENGINE_OPM_STATUS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_OPM_STATUS.MF_MEDIA_ENGINE_OPM_ESTABLISHED"]/*' />
    MF_MEDIA_ENGINE_OPM_ESTABLISHED = 1,

    /// <include file='MF_MEDIA_ENGINE_OPM_STATUS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_OPM_STATUS.MF_MEDIA_ENGINE_OPM_FAILED_VM"]/*' />
    MF_MEDIA_ENGINE_OPM_FAILED_VM = 2,

    /// <include file='MF_MEDIA_ENGINE_OPM_STATUS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_OPM_STATUS.MF_MEDIA_ENGINE_OPM_FAILED_BDA"]/*' />
    MF_MEDIA_ENGINE_OPM_FAILED_BDA = 3,

    /// <include file='MF_MEDIA_ENGINE_OPM_STATUS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_OPM_STATUS.MF_MEDIA_ENGINE_OPM_FAILED_UNSIGNED_DRIVER"]/*' />
    MF_MEDIA_ENGINE_OPM_FAILED_UNSIGNED_DRIVER = 4,

    /// <include file='MF_MEDIA_ENGINE_OPM_STATUS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_OPM_STATUS.MF_MEDIA_ENGINE_OPM_FAILED"]/*' />
    MF_MEDIA_ENGINE_OPM_FAILED = 5,
}
