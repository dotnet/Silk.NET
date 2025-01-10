// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum APPX_FOOTPRINT_FILE_TYPE
{
    APPX_FOOTPRINT_FILE_TYPE_MANIFEST = 0,
    APPX_FOOTPRINT_FILE_TYPE_BLOCKMAP = 1,
    APPX_FOOTPRINT_FILE_TYPE_SIGNATURE = 2,
    APPX_FOOTPRINT_FILE_TYPE_CODEINTEGRITY = 3,
    APPX_FOOTPRINT_FILE_TYPE_CONTENTGROUPMAP = 4,
}
