// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3DSHADER_PARAM_REGISTER_TYPE
{
    D3DSPR_TEMP = 0,
    D3DSPR_INPUT = 1,
    D3DSPR_CONST = 2,
    D3DSPR_ADDR = 3,
    D3DSPR_TEXTURE = 3,
    D3DSPR_RASTOUT = 4,
    D3DSPR_ATTROUT = 5,
    D3DSPR_TEXCRDOUT = 6,
    D3DSPR_OUTPUT = 6,
    D3DSPR_CONSTINT = 7,
    D3DSPR_COLOROUT = 8,
    D3DSPR_DEPTHOUT = 9,
    D3DSPR_SAMPLER = 10,
    D3DSPR_CONST2 = 11,
    D3DSPR_CONST3 = 12,
    D3DSPR_CONST4 = 13,
    D3DSPR_CONSTBOOL = 14,
    D3DSPR_LOOP = 15,
    D3DSPR_TEMPFLOAT16 = 16,
    D3DSPR_MISCTYPE = 17,
    D3DSPR_LABEL = 18,
    D3DSPR_PREDICATE = 19,
    D3DSPR_FORCE_DWORD = 0x7fffffff,
}
