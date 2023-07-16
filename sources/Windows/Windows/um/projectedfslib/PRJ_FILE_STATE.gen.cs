// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='PRJ_FILE_STATE.xml' path='doc/member[@name="PRJ_FILE_STATE"]/*'/>
[Flags]
[SupportedOSPlatform("windows10.0.17763.0")]
public enum PRJ_FILE_STATE
{
    /// <include file='PRJ_FILE_STATE.xml' path='doc/member[@name="PRJ_FILE_STATE.PRJ_FILE_STATE_PLACEHOLDER"]/*'/>
    PRJ_FILE_STATE_PLACEHOLDER = 0x00000001,
    /// <include file='PRJ_FILE_STATE.xml' path='doc/member[@name="PRJ_FILE_STATE.PRJ_FILE_STATE_HYDRATED_PLACEHOLDER"]/*'/>
    PRJ_FILE_STATE_HYDRATED_PLACEHOLDER = 0x00000002,
    /// <include file='PRJ_FILE_STATE.xml' path='doc/member[@name="PRJ_FILE_STATE.PRJ_FILE_STATE_DIRTY_PLACEHOLDER"]/*'/>
    PRJ_FILE_STATE_DIRTY_PLACEHOLDER = 0x00000004,
    /// <include file='PRJ_FILE_STATE.xml' path='doc/member[@name="PRJ_FILE_STATE.PRJ_FILE_STATE_FULL"]/*'/>
    PRJ_FILE_STATE_FULL = 0x00000008,
    /// <include file='PRJ_FILE_STATE.xml' path='doc/member[@name="PRJ_FILE_STATE.PRJ_FILE_STATE_TOMBSTONE"]/*'/>
    PRJ_FILE_STATE_TOMBSTONE = 0x00000010,
}