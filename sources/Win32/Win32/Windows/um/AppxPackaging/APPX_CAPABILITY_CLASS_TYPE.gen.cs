// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum APPX_CAPABILITY_CLASS_TYPE
{
    APPX_CAPABILITY_CLASS_DEFAULT = 0,
    APPX_CAPABILITY_CLASS_GENERAL = 0x1,
    APPX_CAPABILITY_CLASS_RESTRICTED = 0x2,
    APPX_CAPABILITY_CLASS_WINDOWS = 0x4,
    APPX_CAPABILITY_CLASS_ALL = 0x7,
    APPX_CAPABILITY_CLASS_CUSTOM = 0x8,
}
