// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public enum APPX_PACKAGE_ARCHITECTURE2
{
    APPX_PACKAGE_ARCHITECTURE2_X86 = 0,
    APPX_PACKAGE_ARCHITECTURE2_ARM = 5,
    APPX_PACKAGE_ARCHITECTURE2_X64 = 9,
    APPX_PACKAGE_ARCHITECTURE2_NEUTRAL = 11,
    APPX_PACKAGE_ARCHITECTURE2_ARM64 = 12,
    APPX_PACKAGE_ARCHITECTURE2_X86_ON_ARM64 = 14,
    APPX_PACKAGE_ARCHITECTURE2_UNKNOWN = 0xffff,
}
