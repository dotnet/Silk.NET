// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='TRANSACTIONMANAGER_BASIC_INFORMATION.xml' path='doc/member[@name="TRANSACTIONMANAGER_BASIC_INFORMATION"]/*' />
public partial struct TRANSACTIONMANAGER_BASIC_INFORMATION
{
    /// <include file='TRANSACTIONMANAGER_BASIC_INFORMATION.xml' path='doc/member[@name="TRANSACTIONMANAGER_BASIC_INFORMATION.TmIdentity"]/*' />
    public Guid TmIdentity;

    /// <include file='TRANSACTIONMANAGER_BASIC_INFORMATION.xml' path='doc/member[@name="TRANSACTIONMANAGER_BASIC_INFORMATION.VirtualClock"]/*' />
    public LARGE_INTEGER VirtualClock;
}
