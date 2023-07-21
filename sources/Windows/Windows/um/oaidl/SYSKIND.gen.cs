// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYSKIND.xml' path='doc/member[@name="SYSKIND"]/*' />
public enum SYSKIND
{
    /// <include file='SYSKIND.xml' path='doc/member[@name="SYSKIND.SYS_WIN16"]/*' />
    SYS_WIN16 = 0,

    /// <include file='SYSKIND.xml' path='doc/member[@name="SYSKIND.SYS_WIN32"]/*' />
    SYS_WIN32 = (SYS_WIN16 + 1),

    /// <include file='SYSKIND.xml' path='doc/member[@name="SYSKIND.SYS_MAC"]/*' />
    SYS_MAC = (SYS_WIN32 + 1),

    /// <include file='SYSKIND.xml' path='doc/member[@name="SYSKIND.SYS_WIN64"]/*' />
    SYS_WIN64 = (SYS_MAC + 1),
}
