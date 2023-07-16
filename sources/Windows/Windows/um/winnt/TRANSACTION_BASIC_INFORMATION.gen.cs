// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='TRANSACTION_BASIC_INFORMATION.xml' path='doc/member[@name="TRANSACTION_BASIC_INFORMATION"]/*'/>
public partial struct TRANSACTION_BASIC_INFORMATION
{
    /// <include file='TRANSACTION_BASIC_INFORMATION.xml' path='doc/member[@name="TRANSACTION_BASIC_INFORMATION.TransactionId"]/*'/>
    public Guid TransactionId;
    /// <include file='TRANSACTION_BASIC_INFORMATION.xml' path='doc/member[@name="TRANSACTION_BASIC_INFORMATION.State"]/*'/>
    [NativeTypeName("DWORD")]
    public uint State;
    /// <include file='TRANSACTION_BASIC_INFORMATION.xml' path='doc/member[@name="TRANSACTION_BASIC_INFORMATION.Outcome"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Outcome;
}