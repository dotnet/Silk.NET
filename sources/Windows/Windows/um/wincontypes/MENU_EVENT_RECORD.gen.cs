// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MENU_EVENT_RECORD.xml' path='doc/member[@name="MENU_EVENT_RECORD"]/*' />
public partial struct MENU_EVENT_RECORD
{
    /// <include file='MENU_EVENT_RECORD.xml' path='doc/member[@name="MENU_EVENT_RECORD.dwCommandId"]/*' />
    public uint dwCommandId;
}
