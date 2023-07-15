// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION"]/*'/>
public partial struct JOBOBJECT_BASIC_LIMIT_INFORMATION
{
    /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.PerProcessUserTimeLimit"]/*'/>
    public LARGE_INTEGER PerProcessUserTimeLimit;
    /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.PerJobUserTimeLimit"]/*'/>
    public LARGE_INTEGER PerJobUserTimeLimit;
    /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.LimitFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LimitFlags;
    /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.MinimumWorkingSetSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint MinimumWorkingSetSize;
    /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.MaximumWorkingSetSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint MaximumWorkingSetSize;
    /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.ActiveProcessLimit"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ActiveProcessLimit;
    /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.Affinity"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint Affinity;
    /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.PriorityClass"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PriorityClass;
    /// <include file='JOBOBJECT_BASIC_LIMIT_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_BASIC_LIMIT_INFORMATION.SchedulingClass"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SchedulingClass;
}