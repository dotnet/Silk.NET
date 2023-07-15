// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='Uri_HOST_TYPE.xml' path='doc/member[@name="Uri_HOST_TYPE"]/*'/>
public enum Uri_HOST_TYPE
{
    /// <include file='Uri_HOST_TYPE.xml' path='doc/member[@name="Uri_HOST_TYPE.Uri_HOST_UNKNOWN"]/*'/>
    Uri_HOST_UNKNOWN = 0,
    /// <include file='Uri_HOST_TYPE.xml' path='doc/member[@name="Uri_HOST_TYPE.Uri_HOST_DNS"]/*'/>
    Uri_HOST_DNS = (Uri_HOST_UNKNOWN + 1),
    /// <include file='Uri_HOST_TYPE.xml' path='doc/member[@name="Uri_HOST_TYPE.Uri_HOST_IPV4"]/*'/>
    Uri_HOST_IPV4 = (Uri_HOST_DNS + 1),
    /// <include file='Uri_HOST_TYPE.xml' path='doc/member[@name="Uri_HOST_TYPE.Uri_HOST_IPV6"]/*'/>
    Uri_HOST_IPV6 = (Uri_HOST_IPV4 + 1),
    /// <include file='Uri_HOST_TYPE.xml' path='doc/member[@name="Uri_HOST_TYPE.Uri_HOST_IDN"]/*'/>
    Uri_HOST_IDN = (Uri_HOST_IPV6 + 1),
}