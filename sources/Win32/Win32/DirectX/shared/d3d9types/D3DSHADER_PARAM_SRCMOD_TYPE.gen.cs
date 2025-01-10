// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3DSHADER_PARAM_SRCMOD_TYPE
{
    D3DSPSM_NONE = 0 << 24,
    D3DSPSM_NEG = 1 << 24,
    D3DSPSM_BIAS = 2 << 24,
    D3DSPSM_BIASNEG = 3 << 24,
    D3DSPSM_SIGN = 4 << 24,
    D3DSPSM_SIGNNEG = 5 << 24,
    D3DSPSM_COMP = 6 << 24,
    D3DSPSM_X2 = 7 << 24,
    D3DSPSM_X2NEG = 8 << 24,
    D3DSPSM_DZ = 9 << 24,
    D3DSPSM_DW = 10 << 24,
    D3DSPSM_ABS = 11 << 24,
    D3DSPSM_ABSNEG = 12 << 24,
    D3DSPSM_NOT = 13 << 24,
    D3DSPSM_FORCE_DWORD = 0x7fffffff,
}
