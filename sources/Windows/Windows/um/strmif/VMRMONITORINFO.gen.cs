// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO"]/*'/>
public unsafe partial struct VMRMONITORINFO
{
    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.guid"]/*'/>
    public VMRGUID guid;
    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.rcMonitor"]/*'/>
    public RECT rcMonitor;
    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.hMon"]/*'/>
    public HMONITOR hMon;
    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.szDevice"]/*'/>
    [NativeTypeName("wchar_t[32]")]
    public fixed ushort szDevice[32];
    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.szDescription"]/*'/>
    [NativeTypeName("wchar_t[256]")]
    public fixed ushort szDescription[256];
    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.liDriverVersion"]/*'/>
    public LARGE_INTEGER liDriverVersion;
    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.dwVendorId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVendorId;
    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.dwDeviceId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDeviceId;
    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.dwSubSysId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSubSysId;
    /// <include file='VMRMONITORINFO.xml' path='doc/member[@name="VMRMONITORINFO.dwRevision"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRevision;
}