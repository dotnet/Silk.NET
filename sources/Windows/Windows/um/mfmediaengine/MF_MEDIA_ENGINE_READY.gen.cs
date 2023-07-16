// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MF_MEDIA_ENGINE_READY.xml' path='doc/member[@name="MF_MEDIA_ENGINE_READY"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_READY
{
    /// <include file='MF_MEDIA_ENGINE_READY.xml' path='doc/member[@name="MF_MEDIA_ENGINE_READY.MF_MEDIA_ENGINE_READY_HAVE_NOTHING"]/*'/>
    MF_MEDIA_ENGINE_READY_HAVE_NOTHING = 0,
    /// <include file='MF_MEDIA_ENGINE_READY.xml' path='doc/member[@name="MF_MEDIA_ENGINE_READY.MF_MEDIA_ENGINE_READY_HAVE_METADATA"]/*'/>
    MF_MEDIA_ENGINE_READY_HAVE_METADATA = 1,
    /// <include file='MF_MEDIA_ENGINE_READY.xml' path='doc/member[@name="MF_MEDIA_ENGINE_READY.MF_MEDIA_ENGINE_READY_HAVE_CURRENT_DATA"]/*'/>
    MF_MEDIA_ENGINE_READY_HAVE_CURRENT_DATA = 2,
    /// <include file='MF_MEDIA_ENGINE_READY.xml' path='doc/member[@name="MF_MEDIA_ENGINE_READY.MF_MEDIA_ENGINE_READY_HAVE_FUTURE_DATA"]/*'/>
    MF_MEDIA_ENGINE_READY_HAVE_FUTURE_DATA = 3,
    /// <include file='MF_MEDIA_ENGINE_READY.xml' path='doc/member[@name="MF_MEDIA_ENGINE_READY.MF_MEDIA_ENGINE_READY_HAVE_ENOUGH_DATA"]/*'/>
    MF_MEDIA_ENGINE_READY_HAVE_ENOUGH_DATA = 4,
}