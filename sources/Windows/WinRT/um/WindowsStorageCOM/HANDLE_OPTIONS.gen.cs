// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.WinRT;

/// <include file='HANDLE_OPTIONS.xml' path='doc/member[@name="HANDLE_OPTIONS"]/*' />
[Flags]
[SupportedOSPlatform("windows10.0")]
public enum HANDLE_OPTIONS
{
    /// <include file='HANDLE_OPTIONS.xml' path='doc/member[@name="HANDLE_OPTIONS.HO_NONE"]/*' />
    HO_NONE = 0,

    /// <include file='HANDLE_OPTIONS.xml' path='doc/member[@name="HANDLE_OPTIONS.HO_OPEN_REQUIRING_OPLOCK"]/*' />
    HO_OPEN_REQUIRING_OPLOCK = 0x40000,

    /// <include file='HANDLE_OPTIONS.xml' path='doc/member[@name="HANDLE_OPTIONS.HO_DELETE_ON_CLOSE"]/*' />
    HO_DELETE_ON_CLOSE = 0x4000000,

    /// <include file='HANDLE_OPTIONS.xml' path='doc/member[@name="HANDLE_OPTIONS.HO_SEQUENTIAL_SCAN"]/*' />
    HO_SEQUENTIAL_SCAN = 0x8000000,

    /// <include file='HANDLE_OPTIONS.xml' path='doc/member[@name="HANDLE_OPTIONS.HO_RANDOM_ACCESS"]/*' />
    HO_RANDOM_ACCESS = 0x10000000,

    /// <include file='HANDLE_OPTIONS.xml' path='doc/member[@name="HANDLE_OPTIONS.HO_NO_BUFFERING"]/*' />
    HO_NO_BUFFERING = 0x20000000,

    /// <include file='HANDLE_OPTIONS.xml' path='doc/member[@name="HANDLE_OPTIONS.HO_OVERLAPPED"]/*' />
    HO_OVERLAPPED = 0x40000000,

    /// <include file='HANDLE_OPTIONS.xml' path='doc/member[@name="HANDLE_OPTIONS.HO_WRITE_THROUGH"]/*' />
    HO_WRITE_THROUGH = unchecked((int)(0x80000000)),
}
