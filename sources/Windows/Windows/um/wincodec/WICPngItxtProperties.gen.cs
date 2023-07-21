// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICPngItxtProperties.xml' path='doc/member[@name="WICPngItxtProperties"]/*' />
public enum WICPngItxtProperties
{
    /// <include file='WICPngItxtProperties.xml' path='doc/member[@name="WICPngItxtProperties.WICPngItxtKeyword"]/*' />
    WICPngItxtKeyword = 0x1,

    /// <include file='WICPngItxtProperties.xml' path='doc/member[@name="WICPngItxtProperties.WICPngItxtCompressionFlag"]/*' />
    WICPngItxtCompressionFlag = 0x2,

    /// <include file='WICPngItxtProperties.xml' path='doc/member[@name="WICPngItxtProperties.WICPngItxtLanguageTag"]/*' />
    WICPngItxtLanguageTag = 0x3,

    /// <include file='WICPngItxtProperties.xml' path='doc/member[@name="WICPngItxtProperties.WICPngItxtTranslatedKeyword"]/*' />
    WICPngItxtTranslatedKeyword = 0x4,

    /// <include file='WICPngItxtProperties.xml' path='doc/member[@name="WICPngItxtProperties.WICPngItxtText"]/*' />
    WICPngItxtText = 0x5,

    /// <include file='WICPngItxtProperties.xml' path='doc/member[@name="WICPngItxtProperties.WICPngItxtProperties_FORCE_DWORD"]/*' />
    WICPngItxtProperties_FORCE_DWORD = 0x7fffffff,
}
