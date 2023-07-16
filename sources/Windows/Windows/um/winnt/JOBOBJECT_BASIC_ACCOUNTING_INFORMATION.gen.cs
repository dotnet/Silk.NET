// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_ACCOUNTING_INFORMATION"]/*'/>
public partial struct JOBOBJECT_BASIC_ACCOUNTING_INFORMATION
{
    /// <include file='JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.TotalUserTime"]/*'/>
    public LARGE_INTEGER TotalUserTime;
    /// <include file='JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.TotalKernelTime"]/*'/>
    public LARGE_INTEGER TotalKernelTime;
    /// <include file='JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.ThisPeriodTotalUserTime"]/*'/>
    public LARGE_INTEGER ThisPeriodTotalUserTime;
    /// <include file='JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.ThisPeriodTotalKernelTime"]/*'/>
    public LARGE_INTEGER ThisPeriodTotalKernelTime;
    /// <include file='JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.TotalPageFaultCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TotalPageFaultCount;
    /// <include file='JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.TotalProcesses"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TotalProcesses;
    /// <include file='JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.ActiveProcesses"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ActiveProcesses;
    /// <include file='JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_ACCOUNTING_INFORMATION.TotalTerminatedProcesses"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TotalTerminatedProcesses;
}