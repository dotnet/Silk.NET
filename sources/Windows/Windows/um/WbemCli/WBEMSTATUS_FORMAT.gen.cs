// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WBEMSTATUS_FORMAT.xml' path='doc/member[@name="WBEMSTATUS_FORMAT"]/*' />
public enum WBEMSTATUS_FORMAT
{
    /// <include file='WBEMSTATUS_FORMAT.xml' path='doc/member[@name="WBEMSTATUS_FORMAT.WBEMSTATUS_FORMAT_NEWLINE"]/*' />
    WBEMSTATUS_FORMAT_NEWLINE = 0,

    /// <include file='WBEMSTATUS_FORMAT.xml' path='doc/member[@name="WBEMSTATUS_FORMAT.WBEMSTATUS_FORMAT_NO_NEWLINE"]/*' />
    WBEMSTATUS_FORMAT_NO_NEWLINE = 1,
}
