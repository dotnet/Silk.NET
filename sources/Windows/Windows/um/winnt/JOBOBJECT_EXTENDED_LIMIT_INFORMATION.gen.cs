// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='JOBOBJECT_EXTENDED_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_EXTENDED_LIMIT_INFORMATION"]/*'/>
public partial struct JOBOBJECT_EXTENDED_LIMIT_INFORMATION
{
    /// <include file='JOBOBJECT_EXTENDED_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_EXTENDED_LIMIT_INFORMATION.BasicLimitInformation"]/*'/>
    public JOBOBJECT_BASIC_LIMIT_INFORMATION BasicLimitInformation;
    /// <include file='JOBOBJECT_EXTENDED_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_EXTENDED_LIMIT_INFORMATION.IoInfo"]/*'/>
    public IO_COUNTERS IoInfo;
    /// <include file='JOBOBJECT_EXTENDED_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_EXTENDED_LIMIT_INFORMATION.ProcessMemoryLimit"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint ProcessMemoryLimit;
    /// <include file='JOBOBJECT_EXTENDED_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_EXTENDED_LIMIT_INFORMATION.JobMemoryLimit"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint JobMemoryLimit;
    /// <include file='JOBOBJECT_EXTENDED_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_EXTENDED_LIMIT_INFORMATION.PeakProcessMemoryUsed"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PeakProcessMemoryUsed;
    /// <include file='JOBOBJECT_EXTENDED_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_EXTENDED_LIMIT_INFORMATION.PeakJobMemoryUsed"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PeakJobMemoryUsed;
}