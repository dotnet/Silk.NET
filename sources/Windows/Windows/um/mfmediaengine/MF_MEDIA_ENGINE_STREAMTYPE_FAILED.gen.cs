// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MF_MEDIA_ENGINE_STREAMTYPE_FAILED.xml' path='doc/member[@name="MF_MEDIA_ENGINE_STREAMTYPE_FAILED"]/*'/>
public enum MF_MEDIA_ENGINE_STREAMTYPE_FAILED
{
    /// <include file='MF_MEDIA_ENGINE_STREAMTYPE_FAILED.xml' path='doc/member[@name="MF_MEDIA_ENGINE_STREAMTYPE_FAILED.MF_MEDIA_ENGINE_STREAMTYPE_FAILED_UNKNOWN"]/*'/>
    MF_MEDIA_ENGINE_STREAMTYPE_FAILED_UNKNOWN = 0,
    /// <include file='MF_MEDIA_ENGINE_STREAMTYPE_FAILED.xml' path='doc/member[@name="MF_MEDIA_ENGINE_STREAMTYPE_FAILED.MF_MEDIA_ENGINE_STREAMTYPE_FAILED_AUDIO"]/*'/>
    MF_MEDIA_ENGINE_STREAMTYPE_FAILED_AUDIO = 1,
    /// <include file='MF_MEDIA_ENGINE_STREAMTYPE_FAILED.xml' path='doc/member[@name="MF_MEDIA_ENGINE_STREAMTYPE_FAILED.MF_MEDIA_ENGINE_STREAMTYPE_FAILED_VIDEO"]/*'/>
    MF_MEDIA_ENGINE_STREAMTYPE_FAILED_VIDEO = 2,
}