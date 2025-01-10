// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPRECOSTATE
{
    SPRST_INACTIVE = 0,
    SPRST_ACTIVE = (SPRST_INACTIVE + 1),
    SPRST_ACTIVE_ALWAYS = (SPRST_ACTIVE + 1),
    SPRST_INACTIVE_WITH_PURGE = (SPRST_ACTIVE_ALWAYS + 1),
    SPRST_NUM_STATES = (SPRST_INACTIVE_WITH_PURGE + 1),
}
