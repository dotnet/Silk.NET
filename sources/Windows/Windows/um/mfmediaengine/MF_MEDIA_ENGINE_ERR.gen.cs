// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MF_MEDIA_ENGINE_ERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_ERR"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_ERR
{
    /// <include file='MF_MEDIA_ENGINE_ERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_ERR.MF_MEDIA_ENGINE_ERR_NOERROR"]/*'/>
    MF_MEDIA_ENGINE_ERR_NOERROR = 0,
    /// <include file='MF_MEDIA_ENGINE_ERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_ERR.MF_MEDIA_ENGINE_ERR_ABORTED"]/*'/>
    MF_MEDIA_ENGINE_ERR_ABORTED = 1,
    /// <include file='MF_MEDIA_ENGINE_ERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_ERR.MF_MEDIA_ENGINE_ERR_NETWORK"]/*'/>
    MF_MEDIA_ENGINE_ERR_NETWORK = 2,
    /// <include file='MF_MEDIA_ENGINE_ERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_ERR.MF_MEDIA_ENGINE_ERR_DECODE"]/*'/>
    MF_MEDIA_ENGINE_ERR_DECODE = 3,
    /// <include file='MF_MEDIA_ENGINE_ERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_ERR.MF_MEDIA_ENGINE_ERR_SRC_NOT_SUPPORTED"]/*'/>
    MF_MEDIA_ENGINE_ERR_SRC_NOT_SUPPORTED = 4,
    /// <include file='MF_MEDIA_ENGINE_ERR.xml' path='doc/member[@name="MF_MEDIA_ENGINE_ERR.MF_MEDIA_ENGINE_ERR_ENCRYPTED"]/*'/>
    MF_MEDIA_ENGINE_ERR_ENCRYPTED = 5,
}