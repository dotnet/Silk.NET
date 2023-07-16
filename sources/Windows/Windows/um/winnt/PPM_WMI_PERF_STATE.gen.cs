// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE"]/*'/>
public partial struct PPM_WMI_PERF_STATE
{
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Frequency"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Frequency;
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Power"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Power;
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.PercentFrequency"]/*'/>
    public byte PercentFrequency;
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.IncreaseLevel"]/*'/>
    public byte IncreaseLevel;
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.DecreaseLevel"]/*'/>
    public byte DecreaseLevel;
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Type"]/*'/>
    public byte Type;
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.IncreaseTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint IncreaseTime;
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.DecreaseTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DecreaseTime;
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Control"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Control;
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Status"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Status;
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.HitCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint HitCount;
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Reserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved1;
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Reserved2"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Reserved2;
    /// <include file='PPM_WMI_PERF_STATE.xml' path='doc/member[@name="PPM_WMI_PERF_STATE.Reserved3"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Reserved3;
}