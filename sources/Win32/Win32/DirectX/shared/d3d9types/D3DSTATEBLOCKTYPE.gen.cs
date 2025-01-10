// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3DSTATEBLOCKTYPE
{
    D3DSBT_ALL = 1,
    D3DSBT_PIXELSTATE = 2,
    D3DSBT_VERTEXSTATE = 3,
    D3DSBT_FORCE_DWORD = 0x7fffffff,
}
