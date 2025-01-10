// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum PLACEHOLDER_STATES
{
    PS_NONE = 0,
    PS_MARKED_FOR_OFFLINE_AVAILABILITY = 0x1,
    PS_FULL_PRIMARY_STREAM_AVAILABLE = 0x2,
    PS_CREATE_FILE_ACCESSIBLE = 0x4,
    PS_CLOUDFILE_PLACEHOLDER = 0x8,
    PS_DEFAULT =
        (
            (PS_MARKED_FOR_OFFLINE_AVAILABILITY | PS_FULL_PRIMARY_STREAM_AVAILABLE)
            | PS_CREATE_FILE_ACCESSIBLE
        ),
    PS_ALL =
        (
            (
                (PS_MARKED_FOR_OFFLINE_AVAILABILITY | PS_FULL_PRIMARY_STREAM_AVAILABLE)
                | PS_CREATE_FILE_ACCESSIBLE
            ) | PS_CLOUDFILE_PLACEHOLDER
        ),
}
