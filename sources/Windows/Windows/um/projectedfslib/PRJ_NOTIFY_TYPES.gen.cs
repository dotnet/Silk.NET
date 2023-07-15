// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES"]/*'/>
[Flags]
[SupportedOSPlatform("windows10.0.17763.0")]
public enum PRJ_NOTIFY_TYPES
{
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_NONE"]/*'/>
    PRJ_NOTIFY_NONE = 0x00000000,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_SUPPRESS_NOTIFICATIONS"]/*'/>
    PRJ_NOTIFY_SUPPRESS_NOTIFICATIONS = 0x00000001,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_FILE_OPENED"]/*'/>
    PRJ_NOTIFY_FILE_OPENED = 0x00000002,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_NEW_FILE_CREATED"]/*'/>
    PRJ_NOTIFY_NEW_FILE_CREATED = 0x00000004,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_FILE_OVERWRITTEN"]/*'/>
    PRJ_NOTIFY_FILE_OVERWRITTEN = 0x00000008,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_PRE_DELETE"]/*'/>
    PRJ_NOTIFY_PRE_DELETE = 0x00000010,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_PRE_RENAME"]/*'/>
    PRJ_NOTIFY_PRE_RENAME = 0x00000020,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_PRE_SET_HARDLINK"]/*'/>
    PRJ_NOTIFY_PRE_SET_HARDLINK = 0x00000040,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_FILE_RENAMED"]/*'/>
    PRJ_NOTIFY_FILE_RENAMED = 0x00000080,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_HARDLINK_CREATED"]/*'/>
    PRJ_NOTIFY_HARDLINK_CREATED = 0x00000100,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_FILE_HANDLE_CLOSED_NO_MODIFICATION"]/*'/>
    PRJ_NOTIFY_FILE_HANDLE_CLOSED_NO_MODIFICATION = 0x00000200,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_FILE_HANDLE_CLOSED_FILE_MODIFIED"]/*'/>
    PRJ_NOTIFY_FILE_HANDLE_CLOSED_FILE_MODIFIED = 0x00000400,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_FILE_HANDLE_CLOSED_FILE_DELETED"]/*'/>
    PRJ_NOTIFY_FILE_HANDLE_CLOSED_FILE_DELETED = 0x00000800,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_FILE_PRE_CONVERT_TO_FULL"]/*'/>
    PRJ_NOTIFY_FILE_PRE_CONVERT_TO_FULL = 0x00001000,
    /// <include file='PRJ_NOTIFY_TYPES.xml' path='doc/member[@name="PRJ_NOTIFY_TYPES.PRJ_NOTIFY_USE_EXISTING_MASK"]/*'/>
    PRJ_NOTIFY_USE_EXISTING_MASK = unchecked((int)(0xFFFFFFFF)),
}