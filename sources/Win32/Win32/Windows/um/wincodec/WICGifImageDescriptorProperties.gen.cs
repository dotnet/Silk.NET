// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WICGifImageDescriptorProperties
{
    WICGifImageDescriptorLeft = 0x1,
    WICGifImageDescriptorTop = 0x2,
    WICGifImageDescriptorWidth = 0x3,
    WICGifImageDescriptorHeight = 0x4,
    WICGifImageDescriptorLocalColorTableFlag = 0x5,
    WICGifImageDescriptorInterlaceFlag = 0x6,
    WICGifImageDescriptorSortFlag = 0x7,
    WICGifImageDescriptorLocalColorTableSize = 0x8,
    WICGifImageDescriptorProperties_FORCE_DWORD = 0x7fffffff,
}
