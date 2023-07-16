// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MF_MEDIA_ENGINE_S3D_PACKING_MODE.xml' path='doc/member[@name="MF_MEDIA_ENGINE_S3D_PACKING_MODE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_S3D_PACKING_MODE
{
    /// <include file='MF_MEDIA_ENGINE_S3D_PACKING_MODE.xml' path='doc/member[@name="MF_MEDIA_ENGINE_S3D_PACKING_MODE.MF_MEDIA_ENGINE_S3D_PACKING_MODE_NONE"]/*'/>
    MF_MEDIA_ENGINE_S3D_PACKING_MODE_NONE = 0,
    /// <include file='MF_MEDIA_ENGINE_S3D_PACKING_MODE.xml' path='doc/member[@name="MF_MEDIA_ENGINE_S3D_PACKING_MODE.MF_MEDIA_ENGINE_S3D_PACKING_MODE_SIDE_BY_SIDE"]/*'/>
    MF_MEDIA_ENGINE_S3D_PACKING_MODE_SIDE_BY_SIDE = 1,
    /// <include file='MF_MEDIA_ENGINE_S3D_PACKING_MODE.xml' path='doc/member[@name="MF_MEDIA_ENGINE_S3D_PACKING_MODE.MF_MEDIA_ENGINE_S3D_PACKING_MODE_TOP_BOTTOM"]/*'/>
    MF_MEDIA_ENGINE_S3D_PACKING_MODE_TOP_BOTTOM = 2,
}