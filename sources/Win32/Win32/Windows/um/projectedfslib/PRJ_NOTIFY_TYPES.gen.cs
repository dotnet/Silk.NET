// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
[SupportedOSPlatform("windows10.0.17763.0")]
public enum PRJ_NOTIFY_TYPES
{
    PRJ_NOTIFY_NONE = 0x00000000,
    PRJ_NOTIFY_SUPPRESS_NOTIFICATIONS = 0x00000001,
    PRJ_NOTIFY_FILE_OPENED = 0x00000002,
    PRJ_NOTIFY_NEW_FILE_CREATED = 0x00000004,
    PRJ_NOTIFY_FILE_OVERWRITTEN = 0x00000008,
    PRJ_NOTIFY_PRE_DELETE = 0x00000010,
    PRJ_NOTIFY_PRE_RENAME = 0x00000020,
    PRJ_NOTIFY_PRE_SET_HARDLINK = 0x00000040,
    PRJ_NOTIFY_FILE_RENAMED = 0x00000080,
    PRJ_NOTIFY_HARDLINK_CREATED = 0x00000100,
    PRJ_NOTIFY_FILE_HANDLE_CLOSED_NO_MODIFICATION = 0x00000200,
    PRJ_NOTIFY_FILE_HANDLE_CLOSED_FILE_MODIFIED = 0x00000400,
    PRJ_NOTIFY_FILE_HANDLE_CLOSED_FILE_DELETED = 0x00000800,
    PRJ_NOTIFY_FILE_PRE_CONVERT_TO_FULL = 0x00001000,
    PRJ_NOTIFY_USE_EXISTING_MASK = unchecked((int)(0xFFFFFFFF)),
}
