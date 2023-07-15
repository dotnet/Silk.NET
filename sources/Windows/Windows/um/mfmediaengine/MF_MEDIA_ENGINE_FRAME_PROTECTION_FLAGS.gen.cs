// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAGS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAGS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAGS
{
    /// <include file='MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAGS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAGS.MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAG_PROTECTED"]/*'/>
    MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAG_PROTECTED = 0x1,
    /// <include file='MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAGS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAGS.MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAG_REQUIRES_SURFACE_PROTECTION"]/*'/>
    MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAG_REQUIRES_SURFACE_PROTECTION = 0x2,
    /// <include file='MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAGS.xml' path='doc/member[@name="MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAGS.MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAG_REQUIRES_ANTI_SCREEN_SCRAPE_PROTECTION"]/*'/>
    MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAG_REQUIRES_ANTI_SCREEN_SCRAPE_PROTECTION = 0x4,
}