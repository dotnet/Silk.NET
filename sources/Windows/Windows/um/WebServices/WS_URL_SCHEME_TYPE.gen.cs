// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_URL_SCHEME_TYPE.xml' path='doc/member[@name="WS_URL_SCHEME_TYPE"]/*'/>
public enum WS_URL_SCHEME_TYPE
{
    /// <include file='WS_URL_SCHEME_TYPE.xml' path='doc/member[@name="WS_URL_SCHEME_TYPE.WS_URL_HTTP_SCHEME_TYPE"]/*'/>
    WS_URL_HTTP_SCHEME_TYPE = 0,
    /// <include file='WS_URL_SCHEME_TYPE.xml' path='doc/member[@name="WS_URL_SCHEME_TYPE.WS_URL_HTTPS_SCHEME_TYPE"]/*'/>
    WS_URL_HTTPS_SCHEME_TYPE = 1,
    /// <include file='WS_URL_SCHEME_TYPE.xml' path='doc/member[@name="WS_URL_SCHEME_TYPE.WS_URL_NETTCP_SCHEME_TYPE"]/*'/>
    WS_URL_NETTCP_SCHEME_TYPE = 2,
    /// <include file='WS_URL_SCHEME_TYPE.xml' path='doc/member[@name="WS_URL_SCHEME_TYPE.WS_URL_SOAPUDP_SCHEME_TYPE"]/*'/>
    WS_URL_SOAPUDP_SCHEME_TYPE = 3,
    /// <include file='WS_URL_SCHEME_TYPE.xml' path='doc/member[@name="WS_URL_SCHEME_TYPE.WS_URL_NETPIPE_SCHEME_TYPE"]/*'/>
    WS_URL_NETPIPE_SCHEME_TYPE = 4,
}