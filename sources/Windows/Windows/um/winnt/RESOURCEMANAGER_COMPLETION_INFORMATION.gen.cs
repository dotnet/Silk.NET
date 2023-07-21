// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='RESOURCEMANAGER_COMPLETION_INFORMATION.xml' path='doc/member[@name="RESOURCEMANAGER_COMPLETION_INFORMATION"]/*' />
public partial struct RESOURCEMANAGER_COMPLETION_INFORMATION
{
    /// <include file='RESOURCEMANAGER_COMPLETION_INFORMATION.xml' path='doc/member[@name="RESOURCEMANAGER_COMPLETION_INFORMATION.IoCompletionPortHandle"]/*' />
    public HANDLE IoCompletionPortHandle;

    /// <include file='RESOURCEMANAGER_COMPLETION_INFORMATION.xml' path='doc/member[@name="RESOURCEMANAGER_COMPLETION_INFORMATION.CompletionKey"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint CompletionKey;
}
