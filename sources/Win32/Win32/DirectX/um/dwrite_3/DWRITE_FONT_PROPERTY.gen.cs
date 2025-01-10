// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DWRITE_FONT_PROPERTY
{
    public DWRITE_FONT_PROPERTY_ID propertyId;

    [NativeTypeName("const WCHAR *")]
    public ushort* propertyValue;

    [NativeTypeName("const WCHAR *")]
    public ushort* localeName;
}
