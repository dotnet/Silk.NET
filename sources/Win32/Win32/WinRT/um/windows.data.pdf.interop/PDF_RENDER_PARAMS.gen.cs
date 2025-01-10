// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.data.pdf.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[SupportedOSPlatform("windows6.3")]
public partial struct PDF_RENDER_PARAMS
{
    public D2D_RECT_F SourceRect;

    [NativeTypeName("UINT32")]
    public uint DestinationWidth;

    [NativeTypeName("UINT32")]
    public uint DestinationHeight;

    [NativeTypeName("D2D_COLOR_F")]
    public DXGI_RGBA BackgroundColor;

    [NativeTypeName("BOOLEAN")]
    public byte IgnoreHighContrast;
}
