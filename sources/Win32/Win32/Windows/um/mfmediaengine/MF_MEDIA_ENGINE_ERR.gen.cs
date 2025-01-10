// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_ERR
{
    MF_MEDIA_ENGINE_ERR_NOERROR = 0,
    MF_MEDIA_ENGINE_ERR_ABORTED = 1,
    MF_MEDIA_ENGINE_ERR_NETWORK = 2,
    MF_MEDIA_ENGINE_ERR_DECODE = 3,
    MF_MEDIA_ENGINE_ERR_SRC_NOT_SUPPORTED = 4,
    MF_MEDIA_ENGINE_ERR_ENCRYPTED = 5,
}
