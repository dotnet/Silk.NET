// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE"]/*'/>
public partial struct PPM_WMI_IDLE_STATE
{
    /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.Latency"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Latency;
    /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.Power"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Power;
    /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.TimeCheck"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeCheck;
    /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.PromotePercent"]/*'/>
    public byte PromotePercent;
    /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.DemotePercent"]/*'/>
    public byte DemotePercent;
    /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.StateType"]/*'/>
    public byte StateType;
    /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.Reserved"]/*'/>
    public byte Reserved;
    /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.StateFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StateFlags;
    /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.Context"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Context;
    /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.IdleHandler"]/*'/>
    [NativeTypeName("DWORD")]
    public uint IdleHandler;
    /// <include file='PPM_WMI_IDLE_STATE.xml' path='doc/member[@name="PPM_WMI_IDLE_STATE.Reserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved1;
}