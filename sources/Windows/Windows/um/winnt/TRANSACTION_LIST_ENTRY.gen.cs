// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='TRANSACTION_LIST_ENTRY.xml' path='doc/member[@name="TRANSACTION_LIST_ENTRY"]/*' />
public partial struct TRANSACTION_LIST_ENTRY
{
    /// <include file='TRANSACTION_LIST_ENTRY.xml' path='doc/member[@name="TRANSACTION_LIST_ENTRY.UOW"]/*' />
    [NativeTypeName("UOW")]
    public Guid UOW;
}
