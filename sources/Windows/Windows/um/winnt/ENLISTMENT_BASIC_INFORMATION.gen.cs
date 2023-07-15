// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='ENLISTMENT_BASIC_INFORMATION.xml' path='doc/member[@name="ENLISTMENT_BASIC_INFORMATION"]/*'/>
public partial struct ENLISTMENT_BASIC_INFORMATION
{
    /// <include file='ENLISTMENT_BASIC_INFORMATION.xml' path='doc/member[@name="ENLISTMENT_BASIC_INFORMATION.EnlistmentId"]/*'/>
    public Guid EnlistmentId;
    /// <include file='ENLISTMENT_BASIC_INFORMATION.xml' path='doc/member[@name="ENLISTMENT_BASIC_INFORMATION.TransactionId"]/*'/>
    public Guid TransactionId;
    /// <include file='ENLISTMENT_BASIC_INFORMATION.xml' path='doc/member[@name="ENLISTMENT_BASIC_INFORMATION.ResourceManagerId"]/*'/>
    public Guid ResourceManagerId;
}