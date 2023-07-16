// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NL_LINK_LOCAL_ADDRESS_BEHAVIOR.xml' path='doc/member[@name="NL_LINK_LOCAL_ADDRESS_BEHAVIOR"]/*'/>
public enum NL_LINK_LOCAL_ADDRESS_BEHAVIOR
{
    /// <include file='NL_LINK_LOCAL_ADDRESS_BEHAVIOR.xml' path='doc/member[@name="NL_LINK_LOCAL_ADDRESS_BEHAVIOR.LinkLocalAlwaysOff"]/*'/>
    LinkLocalAlwaysOff = 0,
    /// <include file='NL_LINK_LOCAL_ADDRESS_BEHAVIOR.xml' path='doc/member[@name="NL_LINK_LOCAL_ADDRESS_BEHAVIOR.LinkLocalDelayed"]/*'/>
    LinkLocalDelayed,
    /// <include file='NL_LINK_LOCAL_ADDRESS_BEHAVIOR.xml' path='doc/member[@name="NL_LINK_LOCAL_ADDRESS_BEHAVIOR.LinkLocalAlwaysOn"]/*'/>
    LinkLocalAlwaysOn,
    /// <include file='NL_LINK_LOCAL_ADDRESS_BEHAVIOR.xml' path='doc/member[@name="NL_LINK_LOCAL_ADDRESS_BEHAVIOR.LinkLocalUnchanged"]/*'/>
    LinkLocalUnchanged = -1,
}