// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='THREAD_POWER_THROTTLING_STATE.xml' path='doc/member[@name="THREAD_POWER_THROTTLING_STATE"]/*'/>
public partial struct THREAD_POWER_THROTTLING_STATE
{
    /// <include file='THREAD_POWER_THROTTLING_STATE.xml' path='doc/member[@name="THREAD_POWER_THROTTLING_STATE.Version"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Version;
    /// <include file='THREAD_POWER_THROTTLING_STATE.xml' path='doc/member[@name="THREAD_POWER_THROTTLING_STATE.ControlMask"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ControlMask;
    /// <include file='THREAD_POWER_THROTTLING_STATE.xml' path='doc/member[@name="THREAD_POWER_THROTTLING_STATE.StateMask"]/*'/>
    [NativeTypeName("ULONG")]
    public uint StateMask;
}