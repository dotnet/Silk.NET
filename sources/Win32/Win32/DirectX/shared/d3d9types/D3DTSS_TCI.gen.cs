// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DTSS_TCI
{
    [NativeTypeName("#define D3DTSS_TCI_PASSTHRU 0x00000000")]
    public const int D3DTSS_TCI_PASSTHRU = 0x00000000;

    [NativeTypeName("#define D3DTSS_TCI_CAMERASPACENORMAL 0x00010000")]
    public const int D3DTSS_TCI_CAMERASPACENORMAL = 0x00010000;

    [NativeTypeName("#define D3DTSS_TCI_CAMERASPACEPOSITION 0x00020000")]
    public const int D3DTSS_TCI_CAMERASPACEPOSITION = 0x00020000;

    [NativeTypeName("#define D3DTSS_TCI_CAMERASPACEREFLECTIONVECTOR 0x00030000")]
    public const int D3DTSS_TCI_CAMERASPACEREFLECTIONVECTOR = 0x00030000;

    [NativeTypeName("#define D3DTSS_TCI_SPHEREMAP 0x00040000")]
    public const int D3DTSS_TCI_SPHEREMAP = 0x00040000;
}
