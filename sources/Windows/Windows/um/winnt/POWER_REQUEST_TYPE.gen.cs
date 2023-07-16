// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='POWER_REQUEST_TYPE.xml' path='doc/member[@name="POWER_REQUEST_TYPE"]/*'/>
public enum POWER_REQUEST_TYPE
{
    /// <include file='POWER_REQUEST_TYPE.xml' path='doc/member[@name="POWER_REQUEST_TYPE.PowerRequestDisplayRequired"]/*'/>
    PowerRequestDisplayRequired,
    /// <include file='POWER_REQUEST_TYPE.xml' path='doc/member[@name="POWER_REQUEST_TYPE.PowerRequestSystemRequired"]/*'/>
    PowerRequestSystemRequired,
    /// <include file='POWER_REQUEST_TYPE.xml' path='doc/member[@name="POWER_REQUEST_TYPE.PowerRequestAwayModeRequired"]/*'/>
    PowerRequestAwayModeRequired,
    /// <include file='POWER_REQUEST_TYPE.xml' path='doc/member[@name="POWER_REQUEST_TYPE.PowerRequestExecutionRequired"]/*'/>
    PowerRequestExecutionRequired,
}