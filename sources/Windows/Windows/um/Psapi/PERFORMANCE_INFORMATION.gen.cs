// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION"]/*'/>
public partial struct PERFORMANCE_INFORMATION
{
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.cb"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cb;
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.CommitTotal"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint CommitTotal;
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.CommitLimit"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint CommitLimit;
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.CommitPeak"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint CommitPeak;
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.PhysicalTotal"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PhysicalTotal;
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.PhysicalAvailable"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PhysicalAvailable;
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.SystemCache"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint SystemCache;
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.KernelTotal"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint KernelTotal;
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.KernelPaged"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint KernelPaged;
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.KernelNonpaged"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint KernelNonpaged;
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.PageSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PageSize;
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.HandleCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint HandleCount;
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.ProcessCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ProcessCount;
    /// <include file='PERFORMANCE_INFORMATION.xml' path='doc/member[@name="PERFORMANCE_INFORMATION.ThreadCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ThreadCount;
}