// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.3")]
public enum APPX_BUNDLE_FOOTPRINT_FILE_TYPE
{
    APPX_BUNDLE_FOOTPRINT_FILE_TYPE_FIRST = 0,
    APPX_BUNDLE_FOOTPRINT_FILE_TYPE_MANIFEST = 0,
    APPX_BUNDLE_FOOTPRINT_FILE_TYPE_BLOCKMAP = 1,
    APPX_BUNDLE_FOOTPRINT_FILE_TYPE_SIGNATURE = 2,
    APPX_BUNDLE_FOOTPRINT_FILE_TYPE_LAST = 2,
}
