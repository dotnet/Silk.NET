// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_PROTECTION_FLAGS
{
    MF_MEDIA_ENGINE_ENABLE_PROTECTED_CONTENT = 1,
    MF_MEDIA_ENGINE_USE_PMP_FOR_ALL_CONTENT = 2,
    MF_MEDIA_ENGINE_USE_UNPROTECTED_PMP = 4,
}
