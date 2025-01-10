// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3DSAMPLER_TEXTURE_TYPE
{
    D3DSTT_UNKNOWN = 0 << 27,
    D3DSTT_2D = 2 << 27,
    D3DSTT_CUBE = 3 << 27,
    D3DSTT_VOLUME = 4 << 27,
    D3DSTT_FORCE_DWORD = 0x7fffffff,
}
