// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='THREAD_NAME_INFORMATION.xml' path='doc/member[@name="THREAD_NAME_INFORMATION"]/*' />
public partial struct THREAD_NAME_INFORMATION
{
    /// <include file='THREAD_NAME_INFORMATION.xml' path='doc/member[@name="THREAD_NAME_INFORMATION.ThreadName"]/*' />
    public UNICODE_STRING ThreadName;
}
