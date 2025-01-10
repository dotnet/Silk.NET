// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public partial struct PrintPageDescription
{
    [NativeTypeName("ABI::Windows::Foundation::Size")]
    public Size PageSize;

    [NativeTypeName("ABI::Windows::Foundation::Rect")]
    public Rect ImageableRect;

    [NativeTypeName("UINT32")]
    public uint DpiX;

    [NativeTypeName("UINT32")]
    public uint DpiY;
}
