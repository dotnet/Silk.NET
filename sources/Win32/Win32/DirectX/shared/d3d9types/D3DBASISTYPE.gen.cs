// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3DBASISTYPE
{
    D3DBASIS_BEZIER = 0,
    D3DBASIS_BSPLINE = 1,
    D3DBASIS_CATMULL_ROM = 2,
    D3DBASIS_FORCE_DWORD = 0x7fffffff,
}
