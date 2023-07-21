// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICGifImageDescriptorProperties.xml' path='doc/member[@name="WICGifImageDescriptorProperties"]/*' />
public enum WICGifImageDescriptorProperties
{
    /// <include file='WICGifImageDescriptorProperties.xml' path='doc/member[@name="WICGifImageDescriptorProperties.WICGifImageDescriptorLeft"]/*' />
    WICGifImageDescriptorLeft = 0x1,

    /// <include file='WICGifImageDescriptorProperties.xml' path='doc/member[@name="WICGifImageDescriptorProperties.WICGifImageDescriptorTop"]/*' />
    WICGifImageDescriptorTop = 0x2,

    /// <include file='WICGifImageDescriptorProperties.xml' path='doc/member[@name="WICGifImageDescriptorProperties.WICGifImageDescriptorWidth"]/*' />
    WICGifImageDescriptorWidth = 0x3,

    /// <include file='WICGifImageDescriptorProperties.xml' path='doc/member[@name="WICGifImageDescriptorProperties.WICGifImageDescriptorHeight"]/*' />
    WICGifImageDescriptorHeight = 0x4,

    /// <include file='WICGifImageDescriptorProperties.xml' path='doc/member[@name="WICGifImageDescriptorProperties.WICGifImageDescriptorLocalColorTableFlag"]/*' />
    WICGifImageDescriptorLocalColorTableFlag = 0x5,

    /// <include file='WICGifImageDescriptorProperties.xml' path='doc/member[@name="WICGifImageDescriptorProperties.WICGifImageDescriptorInterlaceFlag"]/*' />
    WICGifImageDescriptorInterlaceFlag = 0x6,

    /// <include file='WICGifImageDescriptorProperties.xml' path='doc/member[@name="WICGifImageDescriptorProperties.WICGifImageDescriptorSortFlag"]/*' />
    WICGifImageDescriptorSortFlag = 0x7,

    /// <include file='WICGifImageDescriptorProperties.xml' path='doc/member[@name="WICGifImageDescriptorProperties.WICGifImageDescriptorLocalColorTableSize"]/*' />
    WICGifImageDescriptorLocalColorTableSize = 0x8,

    /// <include file='WICGifImageDescriptorProperties.xml' path='doc/member[@name="WICGifImageDescriptorProperties.WICGifImageDescriptorProperties_FORCE_DWORD"]/*' />
    WICGifImageDescriptorProperties_FORCE_DWORD = 0x7fffffff,
}
