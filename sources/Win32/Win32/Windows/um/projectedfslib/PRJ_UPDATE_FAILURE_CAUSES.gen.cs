// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
[SupportedOSPlatform("windows10.0.17763.0")]
public enum PRJ_UPDATE_FAILURE_CAUSES
{
    PRJ_UPDATE_FAILURE_CAUSE_NONE = 0x00000000,
    PRJ_UPDATE_FAILURE_CAUSE_DIRTY_METADATA = 0x00000001,
    PRJ_UPDATE_FAILURE_CAUSE_DIRTY_DATA = 0x00000002,
    PRJ_UPDATE_FAILURE_CAUSE_TOMBSTONE = 0x00000004,
    PRJ_UPDATE_FAILURE_CAUSE_READ_ONLY = 0x00000008,
}
