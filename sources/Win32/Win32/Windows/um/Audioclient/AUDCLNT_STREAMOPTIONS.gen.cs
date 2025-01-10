// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
[SupportedOSPlatform("windows6.3")]
public enum AUDCLNT_STREAMOPTIONS
{
    AUDCLNT_STREAMOPTIONS_NONE = 0,
    AUDCLNT_STREAMOPTIONS_RAW = 0x1,
    AUDCLNT_STREAMOPTIONS_MATCH_FORMAT = 0x2,
    AUDCLNT_STREAMOPTIONS_AMBISONICS = 0x4,
    AUDCLNT_STREAMOPTIONS_POST_VOLUME_LOOPBACK = 0x8,
}
