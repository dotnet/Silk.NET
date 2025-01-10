// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.22621.0")]
public enum AUDIO_EFFECT_STATE
{
    AUDIO_EFFECT_STATE_OFF = 0,
    AUDIO_EFFECT_STATE_ON = (AUDIO_EFFECT_STATE_OFF + 1),
}
