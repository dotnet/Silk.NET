// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum DWRITE_FONT_SOURCE_TYPE
{
    DWRITE_FONT_SOURCE_TYPE_UNKNOWN,
    DWRITE_FONT_SOURCE_TYPE_PER_MACHINE,
    DWRITE_FONT_SOURCE_TYPE_PER_USER,
    DWRITE_FONT_SOURCE_TYPE_APPX_PACKAGE,
    DWRITE_FONT_SOURCE_TYPE_REMOTE_FONT_PROVIDER,
}
