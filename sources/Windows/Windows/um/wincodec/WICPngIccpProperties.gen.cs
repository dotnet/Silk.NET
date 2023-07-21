// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICPngIccpProperties.xml' path='doc/member[@name="WICPngIccpProperties"]/*' />
public enum WICPngIccpProperties
{
    /// <include file='WICPngIccpProperties.xml' path='doc/member[@name="WICPngIccpProperties.WICPngIccpProfileName"]/*' />
    WICPngIccpProfileName = 0x1,

    /// <include file='WICPngIccpProperties.xml' path='doc/member[@name="WICPngIccpProperties.WICPngIccpProfileData"]/*' />
    WICPngIccpProfileData = 0x2,

    /// <include file='WICPngIccpProperties.xml' path='doc/member[@name="WICPngIccpProperties.WICPngIccpProperties_FORCE_DWORD"]/*' />
    WICPngIccpProperties_FORCE_DWORD = 0x7fffffff,
}
