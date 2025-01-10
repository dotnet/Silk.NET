// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum INTERACTION_ID
{
    INTERACTION_ID_NONE = 0x00000000,
    INTERACTION_ID_MANIPULATION = 0x00000001,
    INTERACTION_ID_TAP = 0x00000002,
    INTERACTION_ID_SECONDARY_TAP = 0x00000003,
    INTERACTION_ID_HOLD = 0x00000004,
    INTERACTION_ID_DRAG = 0x00000005,
    INTERACTION_ID_CROSS_SLIDE = 0x00000006,
    INTERACTION_ID_MAX = unchecked((int)(0xffffffff)),
}
