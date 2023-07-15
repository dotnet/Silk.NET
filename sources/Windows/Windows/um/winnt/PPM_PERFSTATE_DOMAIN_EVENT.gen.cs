// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PPM_PERFSTATE_DOMAIN_EVENT.xml' path='doc/member[@name="PPM_PERFSTATE_DOMAIN_EVENT"]/*'/>
public partial struct PPM_PERFSTATE_DOMAIN_EVENT
{
    /// <include file='PPM_PERFSTATE_DOMAIN_EVENT.xml' path='doc/member[@name="PPM_PERFSTATE_DOMAIN_EVENT.State"]/*'/>
    [NativeTypeName("DWORD")]
    public uint State;
    /// <include file='PPM_PERFSTATE_DOMAIN_EVENT.xml' path='doc/member[@name="PPM_PERFSTATE_DOMAIN_EVENT.Latency"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Latency;
    /// <include file='PPM_PERFSTATE_DOMAIN_EVENT.xml' path='doc/member[@name="PPM_PERFSTATE_DOMAIN_EVENT.Speed"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Speed;
    /// <include file='PPM_PERFSTATE_DOMAIN_EVENT.xml' path='doc/member[@name="PPM_PERFSTATE_DOMAIN_EVENT.Processors"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Processors;
}