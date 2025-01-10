// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum MF_CAPTURE_ENGINE_STREAM_CATEGORY
{
    MF_CAPTURE_ENGINE_STREAM_CATEGORY_VIDEO_PREVIEW = 0,
    MF_CAPTURE_ENGINE_STREAM_CATEGORY_VIDEO_CAPTURE = 0x1,
    MF_CAPTURE_ENGINE_STREAM_CATEGORY_PHOTO_INDEPENDENT = 0x2,
    MF_CAPTURE_ENGINE_STREAM_CATEGORY_PHOTO_DEPENDENT = 0x3,
    MF_CAPTURE_ENGINE_STREAM_CATEGORY_AUDIO = 0x4,
    MF_CAPTURE_ENGINE_STREAM_CATEGORY_UNSUPPORTED = 0x5,
    MF_CAPTURE_ENGINE_STREAM_CATEGORY_METADATA = 0x6,
}
