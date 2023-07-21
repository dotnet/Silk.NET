// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WCM_MEDIA_TYPE.xml' path='doc/member[@name="WCM_MEDIA_TYPE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum WCM_MEDIA_TYPE
{
    /// <include file='WCM_MEDIA_TYPE.xml' path='doc/member[@name="WCM_MEDIA_TYPE.wcm_media_unknown"]/*' />
    wcm_media_unknown,

    /// <include file='WCM_MEDIA_TYPE.xml' path='doc/member[@name="WCM_MEDIA_TYPE.wcm_media_ethernet"]/*' />
    wcm_media_ethernet,

    /// <include file='WCM_MEDIA_TYPE.xml' path='doc/member[@name="WCM_MEDIA_TYPE.wcm_media_wlan"]/*' />
    wcm_media_wlan,

    /// <include file='WCM_MEDIA_TYPE.xml' path='doc/member[@name="WCM_MEDIA_TYPE.wcm_media_mbn"]/*' />
    wcm_media_mbn,

    /// <include file='WCM_MEDIA_TYPE.xml' path='doc/member[@name="WCM_MEDIA_TYPE.wcm_media_invalid"]/*' />
    wcm_media_invalid,

    /// <include file='WCM_MEDIA_TYPE.xml' path='doc/member[@name="WCM_MEDIA_TYPE.wcm_media_max"]/*' />
    wcm_media_max,
}
