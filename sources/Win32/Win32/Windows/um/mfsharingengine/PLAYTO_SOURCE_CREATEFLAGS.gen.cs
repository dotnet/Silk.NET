// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
[SupportedOSPlatform("windows6.2")]
public enum PLAYTO_SOURCE_CREATEFLAGS
{
    PLAYTO_SOURCE_NONE = 0,
    PLAYTO_SOURCE_IMAGE = 0x1,
    PLAYTO_SOURCE_AUDIO = 0x2,
    PLAYTO_SOURCE_VIDEO = 0x4,
    PLAYTO_SOURCE_PROTECTED = 0x8,
}
