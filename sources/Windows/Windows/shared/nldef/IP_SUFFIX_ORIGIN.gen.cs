// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN"]/*'/>
public enum IP_SUFFIX_ORIGIN
{
    /// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN.NlsoOther"]/*'/>
    NlsoOther = 0,
    /// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN.NlsoManual"]/*'/>
    NlsoManual,
    /// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN.NlsoWellKnown"]/*'/>
    NlsoWellKnown,
    /// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN.NlsoDhcp"]/*'/>
    NlsoDhcp,
    /// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN.NlsoLinkLayerAddress"]/*'/>
    NlsoLinkLayerAddress,
    /// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN.NlsoRandom"]/*'/>
    NlsoRandom,
    /// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN.IpSuffixOriginOther"]/*'/>
    IpSuffixOriginOther = 0,
    /// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN.IpSuffixOriginManual"]/*'/>
    IpSuffixOriginManual,
    /// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN.IpSuffixOriginWellKnown"]/*'/>
    IpSuffixOriginWellKnown,
    /// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN.IpSuffixOriginDhcp"]/*'/>
    IpSuffixOriginDhcp,
    /// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN.IpSuffixOriginLinkLayerAddress"]/*'/>
    IpSuffixOriginLinkLayerAddress,
    /// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN.IpSuffixOriginRandom"]/*'/>
    IpSuffixOriginRandom,
    /// <include file='IP_SUFFIX_ORIGIN.xml' path='doc/member[@name="IP_SUFFIX_ORIGIN.IpSuffixOriginUnchanged"]/*'/>
    IpSuffixOriginUnchanged = 1 << 4,
}