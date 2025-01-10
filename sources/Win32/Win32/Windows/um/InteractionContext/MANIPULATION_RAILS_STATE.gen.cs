// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum MANIPULATION_RAILS_STATE
{
    MANIPULATION_RAILS_STATE_UNDECIDED = 0x00000000,
    MANIPULATION_RAILS_STATE_FREE = 0x00000001,
    MANIPULATION_RAILS_STATE_RAILED = 0x00000002,
    MANIPULATION_RAILS_STATE_MAX = unchecked((int)(0xffffffff)),
}
