// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WIC8BIMIptcDigestProperties.xml' path='doc/member[@name="WIC8BIMIptcDigestProperties"]/*' />
public enum WIC8BIMIptcDigestProperties
{
    /// <include file='WIC8BIMIptcDigestProperties.xml' path='doc/member[@name="WIC8BIMIptcDigestProperties.WIC8BIMIptcDigestPString"]/*' />
    WIC8BIMIptcDigestPString = 0x1,

    /// <include file='WIC8BIMIptcDigestProperties.xml' path='doc/member[@name="WIC8BIMIptcDigestProperties.WIC8BIMIptcDigestIptcDigest"]/*' />
    WIC8BIMIptcDigestIptcDigest = 0x2,

    /// <include file='WIC8BIMIptcDigestProperties.xml' path='doc/member[@name="WIC8BIMIptcDigestProperties.WIC8BIMIptcDigestProperties_FORCE_DWORD"]/*' />
    WIC8BIMIptcDigestProperties_FORCE_DWORD = 0x7fffffff,
}
