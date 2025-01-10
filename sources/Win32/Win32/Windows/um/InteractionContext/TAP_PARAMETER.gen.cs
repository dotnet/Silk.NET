// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum TAP_PARAMETER
{
    TAP_PARAMETER_MIN_CONTACT_COUNT = 0x00000000,
    TAP_PARAMETER_MAX_CONTACT_COUNT = 0x00000001,
    TAP_PARAMETER_MAX = unchecked((int)(0xffffffff)),
}
