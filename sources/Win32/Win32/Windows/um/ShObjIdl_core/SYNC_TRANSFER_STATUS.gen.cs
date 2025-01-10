// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYNC_TRANSFER_STATUS
{
    STS_NONE = 0,
    STS_NEEDSUPLOAD = 0x1,
    STS_NEEDSDOWNLOAD = 0x2,
    STS_TRANSFERRING = 0x4,
    STS_PAUSED = 0x8,
    STS_HASERROR = 0x10,
    STS_FETCHING_METADATA = 0x20,
    STS_USER_REQUESTED_REFRESH = 0x40,
    STS_HASWARNING = 0x80,
    STS_EXCLUDED = 0x100,
    STS_INCOMPLETE = 0x200,
    STS_PLACEHOLDER_IFEMPTY = 0x400,
}
