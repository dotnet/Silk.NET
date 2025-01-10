// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MEDIA_FLAGS
{
    MEDIA_BLANK = 0x1,
    MEDIA_RW = 0x2,
    MEDIA_WRITABLE = 0x4,
    MEDIA_FORMAT_UNUSABLE_BY_IMAPI = 0x8,
}
