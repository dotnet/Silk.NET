// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='POWER_MONITOR_INVOCATION.xml' path='doc/member[@name="POWER_MONITOR_INVOCATION"]/*'/>
public partial struct POWER_MONITOR_INVOCATION
{
    /// <include file='POWER_MONITOR_INVOCATION.xml' path='doc/member[@name="POWER_MONITOR_INVOCATION.Console"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Console;
    /// <include file='POWER_MONITOR_INVOCATION.xml' path='doc/member[@name="POWER_MONITOR_INVOCATION.RequestReason"]/*'/>
    public POWER_MONITOR_REQUEST_REASON RequestReason;
}