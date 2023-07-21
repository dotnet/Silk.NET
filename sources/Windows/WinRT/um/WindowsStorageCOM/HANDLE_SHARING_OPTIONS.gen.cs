// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.WinRT;

/// <include file='HANDLE_SHARING_OPTIONS.xml' path='doc/member[@name="HANDLE_SHARING_OPTIONS"]/*' />
[Flags]
[SupportedOSPlatform("windows10.0")]
public enum HANDLE_SHARING_OPTIONS
{
    /// <include file='HANDLE_SHARING_OPTIONS.xml' path='doc/member[@name="HANDLE_SHARING_OPTIONS.HSO_SHARE_NONE"]/*' />
    HSO_SHARE_NONE = 0,

    /// <include file='HANDLE_SHARING_OPTIONS.xml' path='doc/member[@name="HANDLE_SHARING_OPTIONS.HSO_SHARE_READ"]/*' />
    HSO_SHARE_READ = 0x1,

    /// <include file='HANDLE_SHARING_OPTIONS.xml' path='doc/member[@name="HANDLE_SHARING_OPTIONS.HSO_SHARE_WRITE"]/*' />
    HSO_SHARE_WRITE = 0x2,

    /// <include file='HANDLE_SHARING_OPTIONS.xml' path='doc/member[@name="HANDLE_SHARING_OPTIONS.HSO_SHARE_DELETE"]/*' />
    HSO_SHARE_DELETE = 0x4,
}
