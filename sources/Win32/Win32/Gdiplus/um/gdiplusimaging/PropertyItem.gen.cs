// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public unsafe partial struct PropertyItem
{
    [NativeTypeName("PROPID")]
    public uint id;

    [NativeTypeName("ULONG")]
    public uint length;

    [NativeTypeName("WORD")]
    public ushort type;
    public void* value;
}
