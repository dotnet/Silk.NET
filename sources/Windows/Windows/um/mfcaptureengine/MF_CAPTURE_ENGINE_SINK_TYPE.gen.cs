// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_CAPTURE_ENGINE_SINK_TYPE.xml' path='doc/member[@name="MF_CAPTURE_ENGINE_SINK_TYPE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum MF_CAPTURE_ENGINE_SINK_TYPE
{
    /// <include file='MF_CAPTURE_ENGINE_SINK_TYPE.xml' path='doc/member[@name="MF_CAPTURE_ENGINE_SINK_TYPE.MF_CAPTURE_ENGINE_SINK_TYPE_RECORD"]/*' />
    MF_CAPTURE_ENGINE_SINK_TYPE_RECORD = 0,

    /// <include file='MF_CAPTURE_ENGINE_SINK_TYPE.xml' path='doc/member[@name="MF_CAPTURE_ENGINE_SINK_TYPE.MF_CAPTURE_ENGINE_SINK_TYPE_PREVIEW"]/*' />
    MF_CAPTURE_ENGINE_SINK_TYPE_PREVIEW = 0x1,

    /// <include file='MF_CAPTURE_ENGINE_SINK_TYPE.xml' path='doc/member[@name="MF_CAPTURE_ENGINE_SINK_TYPE.MF_CAPTURE_ENGINE_SINK_TYPE_PHOTO"]/*' />
    MF_CAPTURE_ENGINE_SINK_TYPE_PHOTO = 0x2,
}
