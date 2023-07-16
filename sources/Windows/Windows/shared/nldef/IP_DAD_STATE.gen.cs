// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IP_DAD_STATE.xml' path='doc/member[@name="IP_DAD_STATE"]/*'/>
public enum IP_DAD_STATE
{
    /// <include file='IP_DAD_STATE.xml' path='doc/member[@name="IP_DAD_STATE.NldsInvalid"]/*'/>
    NldsInvalid,
    /// <include file='IP_DAD_STATE.xml' path='doc/member[@name="IP_DAD_STATE.NldsTentative"]/*'/>
    NldsTentative,
    /// <include file='IP_DAD_STATE.xml' path='doc/member[@name="IP_DAD_STATE.NldsDuplicate"]/*'/>
    NldsDuplicate,
    /// <include file='IP_DAD_STATE.xml' path='doc/member[@name="IP_DAD_STATE.NldsDeprecated"]/*'/>
    NldsDeprecated,
    /// <include file='IP_DAD_STATE.xml' path='doc/member[@name="IP_DAD_STATE.NldsPreferred"]/*'/>
    NldsPreferred,
    /// <include file='IP_DAD_STATE.xml' path='doc/member[@name="IP_DAD_STATE.IpDadStateInvalid"]/*'/>
    IpDadStateInvalid = 0,
    /// <include file='IP_DAD_STATE.xml' path='doc/member[@name="IP_DAD_STATE.IpDadStateTentative"]/*'/>
    IpDadStateTentative,
    /// <include file='IP_DAD_STATE.xml' path='doc/member[@name="IP_DAD_STATE.IpDadStateDuplicate"]/*'/>
    IpDadStateDuplicate,
    /// <include file='IP_DAD_STATE.xml' path='doc/member[@name="IP_DAD_STATE.IpDadStateDeprecated"]/*'/>
    IpDadStateDeprecated,
    /// <include file='IP_DAD_STATE.xml' path='doc/member[@name="IP_DAD_STATE.IpDadStatePreferred"]/*'/>
    IpDadStatePreferred,
}