// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NL_ROUTE_ORIGIN.xml' path='doc/member[@name="NL_ROUTE_ORIGIN"]/*'/>
public enum NL_ROUTE_ORIGIN
{
    /// <include file='NL_ROUTE_ORIGIN.xml' path='doc/member[@name="NL_ROUTE_ORIGIN.NlroManual"]/*'/>
    NlroManual,
    /// <include file='NL_ROUTE_ORIGIN.xml' path='doc/member[@name="NL_ROUTE_ORIGIN.NlroWellKnown"]/*'/>
    NlroWellKnown,
    /// <include file='NL_ROUTE_ORIGIN.xml' path='doc/member[@name="NL_ROUTE_ORIGIN.NlroDHCP"]/*'/>
    NlroDHCP,
    /// <include file='NL_ROUTE_ORIGIN.xml' path='doc/member[@name="NL_ROUTE_ORIGIN.NlroRouterAdvertisement"]/*'/>
    NlroRouterAdvertisement,
    /// <include file='NL_ROUTE_ORIGIN.xml' path='doc/member[@name="NL_ROUTE_ORIGIN.Nlro6to4"]/*'/>
    Nlro6to4,
}