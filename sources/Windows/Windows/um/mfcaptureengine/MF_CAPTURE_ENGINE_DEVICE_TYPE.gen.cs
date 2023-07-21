// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_CAPTURE_ENGINE_DEVICE_TYPE.xml' path='doc/member[@name="MF_CAPTURE_ENGINE_DEVICE_TYPE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum MF_CAPTURE_ENGINE_DEVICE_TYPE
{
    /// <include file='MF_CAPTURE_ENGINE_DEVICE_TYPE.xml' path='doc/member[@name="MF_CAPTURE_ENGINE_DEVICE_TYPE.MF_CAPTURE_ENGINE_DEVICE_TYPE_AUDIO"]/*' />
    MF_CAPTURE_ENGINE_DEVICE_TYPE_AUDIO = 0,

    /// <include file='MF_CAPTURE_ENGINE_DEVICE_TYPE.xml' path='doc/member[@name="MF_CAPTURE_ENGINE_DEVICE_TYPE.MF_CAPTURE_ENGINE_DEVICE_TYPE_VIDEO"]/*' />
    MF_CAPTURE_ENGINE_DEVICE_TYPE_VIDEO = 0x1,
}
