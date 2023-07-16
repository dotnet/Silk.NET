// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PPM_PERFSTATE_EVENT.xml' path='doc/member[@name="PPM_PERFSTATE_EVENT"]/*'/>
public partial struct PPM_PERFSTATE_EVENT
{
    /// <include file='PPM_PERFSTATE_EVENT.xml' path='doc/member[@name="PPM_PERFSTATE_EVENT.State"]/*'/>
    [NativeTypeName("DWORD")]
    public uint State;
    /// <include file='PPM_PERFSTATE_EVENT.xml' path='doc/member[@name="PPM_PERFSTATE_EVENT.Status"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Status;
    /// <include file='PPM_PERFSTATE_EVENT.xml' path='doc/member[@name="PPM_PERFSTATE_EVENT.Latency"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Latency;
    /// <include file='PPM_PERFSTATE_EVENT.xml' path='doc/member[@name="PPM_PERFSTATE_EVENT.Speed"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Speed;
    /// <include file='PPM_PERFSTATE_EVENT.xml' path='doc/member[@name="PPM_PERFSTATE_EVENT.Processor"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Processor;
}