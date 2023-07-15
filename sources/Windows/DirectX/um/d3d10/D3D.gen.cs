// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class D3D
{
    [NativeTypeName("#define D3D_MAJOR_VERSION ( 10 )")]
    public const int D3D_MAJOR_VERSION = (10);
    [NativeTypeName("#define D3D_MINOR_VERSION ( 0 )")]
    public const int D3D_MINOR_VERSION = (0);
    [NativeTypeName("#define D3D_SPEC_DATE_DAY ( 8 )")]
    public const int D3D_SPEC_DATE_DAY = (8);
    [NativeTypeName("#define D3D_SPEC_DATE_MONTH ( 8 )")]
    public const int D3D_SPEC_DATE_MONTH = (8);
    [NativeTypeName("#define D3D_SPEC_DATE_YEAR ( 2006 )")]
    public const int D3D_SPEC_DATE_YEAR = (2006);
    [NativeTypeName("#define D3D_SPEC_VERSION ( 1.050005 )")]
    public const double D3D_SPEC_VERSION = (1.050005);
}