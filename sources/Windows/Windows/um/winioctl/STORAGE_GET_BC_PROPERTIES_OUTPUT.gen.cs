// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_GET_BC_PROPERTIES_OUTPUT.xml' path='doc/member[@name="STORAGE_GET_BC_PROPERTIES_OUTPUT"]/*'/>
public partial struct STORAGE_GET_BC_PROPERTIES_OUTPUT
{
    /// <include file='STORAGE_GET_BC_PROPERTIES_OUTPUT.xml' path='doc/member[@name="STORAGE_GET_BC_PROPERTIES_OUTPUT.MaximumRequestsPerPeriod"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaximumRequestsPerPeriod;
    /// <include file='STORAGE_GET_BC_PROPERTIES_OUTPUT.xml' path='doc/member[@name="STORAGE_GET_BC_PROPERTIES_OUTPUT.MinimumPeriod"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MinimumPeriod;
    /// <include file='STORAGE_GET_BC_PROPERTIES_OUTPUT.xml' path='doc/member[@name="STORAGE_GET_BC_PROPERTIES_OUTPUT.MaximumRequestSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MaximumRequestSize;
    /// <include file='STORAGE_GET_BC_PROPERTIES_OUTPUT.xml' path='doc/member[@name="STORAGE_GET_BC_PROPERTIES_OUTPUT.EstimatedTimePerRequest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EstimatedTimePerRequest;
    /// <include file='STORAGE_GET_BC_PROPERTIES_OUTPUT.xml' path='doc/member[@name="STORAGE_GET_BC_PROPERTIES_OUTPUT.NumOutStandingRequests"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumOutStandingRequests;
    /// <include file='STORAGE_GET_BC_PROPERTIES_OUTPUT.xml' path='doc/member[@name="STORAGE_GET_BC_PROPERTIES_OUTPUT.RequestSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong RequestSize;
}