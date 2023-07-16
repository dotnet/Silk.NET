// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='JOBOBJECT_BASIC_AND_IO_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_AND_IO_ACCOUNTING_INFORMATION"]/*'/>
public partial struct JOBOBJECT_BASIC_AND_IO_ACCOUNTING_INFORMATION
{
    /// <include file='JOBOBJECT_BASIC_AND_IO_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_AND_IO_ACCOUNTING_INFORMATION.BasicInfo"]/*'/>
    public JOBOBJECT_BASIC_ACCOUNTING_INFORMATION BasicInfo;
    /// <include file='JOBOBJECT_BASIC_AND_IO_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_AND_IO_ACCOUNTING_INFORMATION.IoInfo"]/*'/>
    public IO_COUNTERS IoInfo;
}