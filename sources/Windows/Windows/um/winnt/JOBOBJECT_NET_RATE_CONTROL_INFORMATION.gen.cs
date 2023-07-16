// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='JOBOBJECT_NET_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NET_RATE_CONTROL_INFORMATION"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct JOBOBJECT_NET_RATE_CONTROL_INFORMATION
{
    /// <include file='JOBOBJECT_NET_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NET_RATE_CONTROL_INFORMATION.MaxBandwidth"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong MaxBandwidth;
    /// <include file='JOBOBJECT_NET_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NET_RATE_CONTROL_INFORMATION.ControlFlags"]/*'/>
    public JOB_OBJECT_NET_RATE_CONTROL_FLAGS ControlFlags;
    /// <include file='JOBOBJECT_NET_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NET_RATE_CONTROL_INFORMATION.DscpTag"]/*'/>
    public byte DscpTag;
}