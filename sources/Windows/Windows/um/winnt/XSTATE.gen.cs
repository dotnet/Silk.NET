// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class XSTATE
{
    [NativeTypeName("#define XSTATE_LEGACY_FLOATING_POINT (0)")]
    public const int XSTATE_LEGACY_FLOATING_POINT = (0);

    [NativeTypeName("#define XSTATE_LEGACY_SSE (1)")]
    public const int XSTATE_LEGACY_SSE = (1);

    [NativeTypeName("#define XSTATE_GSSE (2)")]
    public const int XSTATE_GSSE = (2);

    [NativeTypeName("#define XSTATE_AVX (XSTATE_GSSE)")]
    public const int XSTATE_AVX = ((2));

    [NativeTypeName("#define XSTATE_MPX_BNDREGS (3)")]
    public const int XSTATE_MPX_BNDREGS = (3);

    [NativeTypeName("#define XSTATE_MPX_BNDCSR (4)")]
    public const int XSTATE_MPX_BNDCSR = (4);

    [NativeTypeName("#define XSTATE_AVX512_KMASK (5)")]
    public const int XSTATE_AVX512_KMASK = (5);

    [NativeTypeName("#define XSTATE_AVX512_ZMM_H (6)")]
    public const int XSTATE_AVX512_ZMM_H = (6);

    [NativeTypeName("#define XSTATE_AVX512_ZMM (7)")]
    public const int XSTATE_AVX512_ZMM = (7);

    [NativeTypeName("#define XSTATE_IPT (8)")]
    public const int XSTATE_IPT = (8);

    [NativeTypeName("#define XSTATE_PASID (10)")]
    public const int XSTATE_PASID = (10);

    [NativeTypeName("#define XSTATE_CET_U (11)")]
    public const int XSTATE_CET_U = (11);

    [NativeTypeName("#define XSTATE_CET_S (12)")]
    public const int XSTATE_CET_S = (12);

    [NativeTypeName("#define XSTATE_AMX_TILE_CONFIG (17)")]
    public const int XSTATE_AMX_TILE_CONFIG = (17);

    [NativeTypeName("#define XSTATE_AMX_TILE_DATA (18)")]
    public const int XSTATE_AMX_TILE_DATA = (18);

    [NativeTypeName("#define XSTATE_LWP (62)")]
    public const int XSTATE_LWP = (62);

    [NativeTypeName("#define XSTATE_MASK_LEGACY_FLOATING_POINT (1ui64 << (XSTATE_LEGACY_FLOATING_POINT))")]
    public const ulong XSTATE_MASK_LEGACY_FLOATING_POINT = (1UL << ((0)));

    [NativeTypeName("#define XSTATE_MASK_LEGACY_SSE (1ui64 << (XSTATE_LEGACY_SSE))")]
    public const ulong XSTATE_MASK_LEGACY_SSE = (1UL << ((1)));

    [NativeTypeName("#define XSTATE_MASK_LEGACY (XSTATE_MASK_LEGACY_FLOATING_POINT | \\\r\n                                             XSTATE_MASK_LEGACY_SSE)")]
    public const ulong XSTATE_MASK_LEGACY = ((1UL << ((0))) | (1UL << ((1))));

    [NativeTypeName("#define XSTATE_MASK_GSSE (1ui64 << (XSTATE_GSSE))")]
    public const ulong XSTATE_MASK_GSSE = (1UL << ((2)));

    [NativeTypeName("#define XSTATE_MASK_AVX (XSTATE_MASK_GSSE)")]
    public const ulong XSTATE_MASK_AVX = ((1UL << ((2))));

    [NativeTypeName("#define XSTATE_MASK_MPX ((1ui64 << (XSTATE_MPX_BNDREGS)) | \\\r\n                                             (1ui64 << (XSTATE_MPX_BNDCSR)))")]
    public const ulong XSTATE_MASK_MPX = ((1UL << ((3))) | (1UL << ((4))));

    [NativeTypeName("#define XSTATE_MASK_AVX512 ((1ui64 << (XSTATE_AVX512_KMASK)) | \\\r\n                                             (1ui64 << (XSTATE_AVX512_ZMM_H)) | \\\r\n                                             (1ui64 << (XSTATE_AVX512_ZMM)))")]
    public const ulong XSTATE_MASK_AVX512 = ((1UL << ((5))) | (1UL << ((6))) | (1UL << ((7))));

    [NativeTypeName("#define XSTATE_MASK_IPT (1ui64 << (XSTATE_IPT))")]
    public const ulong XSTATE_MASK_IPT = (1UL << ((8)));

    [NativeTypeName("#define XSTATE_MASK_PASID (1ui64 << (XSTATE_PASID))")]
    public const ulong XSTATE_MASK_PASID = (1UL << ((10)));

    [NativeTypeName("#define XSTATE_MASK_CET_U (1ui64 << (XSTATE_CET_U))")]
    public const ulong XSTATE_MASK_CET_U = (1UL << ((11)));

    [NativeTypeName("#define XSTATE_MASK_CET_S (1ui64 << (XSTATE_CET_S))")]
    public const ulong XSTATE_MASK_CET_S = (1UL << ((12)));

    [NativeTypeName("#define XSTATE_MASK_AMX_TILE_CONFIG (1ui64 << (XSTATE_AMX_TILE_CONFIG))")]
    public const ulong XSTATE_MASK_AMX_TILE_CONFIG = (1UL << ((17)));

    [NativeTypeName("#define XSTATE_MASK_AMX_TILE_DATA (1ui64 << (XSTATE_AMX_TILE_DATA))")]
    public const ulong XSTATE_MASK_AMX_TILE_DATA = (1UL << ((18)));

    [NativeTypeName("#define XSTATE_MASK_LWP (1ui64 << (XSTATE_LWP))")]
    public const ulong XSTATE_MASK_LWP = (1UL << ((62)));

    [NativeTypeName("#define XSTATE_MASK_PERSISTENT ((1ui64 << (XSTATE_MPX_BNDCSR)) | \\\r\n                                             XSTATE_MASK_LWP)")]
    public const ulong XSTATE_MASK_PERSISTENT = ((1UL << ((4))) | (1UL << ((62))));

    [NativeTypeName("#define XSTATE_MASK_USER_VISIBLE_SUPERVISOR (XSTATE_MASK_CET_U)")]
    public const ulong XSTATE_MASK_USER_VISIBLE_SUPERVISOR = ((1UL << ((11))));

    [NativeTypeName("#define XSTATE_MASK_LARGE_FEATURES (XSTATE_MASK_AMX_TILE_DATA)")]
    public const ulong XSTATE_MASK_LARGE_FEATURES = ((1UL << ((18))));

    [NativeTypeName("#define XSTATE_COMPACTION_ENABLE (63)")]
    public const int XSTATE_COMPACTION_ENABLE = (63);

    [NativeTypeName("#define XSTATE_COMPACTION_ENABLE_MASK (1ui64 << (XSTATE_COMPACTION_ENABLE))")]
    public const ulong XSTATE_COMPACTION_ENABLE_MASK = (1UL << ((63)));

    [NativeTypeName("#define XSTATE_ALIGN_BIT (1)")]
    public const int XSTATE_ALIGN_BIT = (1);

    [NativeTypeName("#define XSTATE_ALIGN_MASK (1ui64 << (XSTATE_ALIGN_BIT))")]
    public const ulong XSTATE_ALIGN_MASK = (1UL << ((1)));

    [NativeTypeName("#define XSTATE_XFD_BIT (2)")]
    public const int XSTATE_XFD_BIT = (2);

    [NativeTypeName("#define XSTATE_XFD_MASK (1ui64 << (XSTATE_XFD_BIT))")]
    public const ulong XSTATE_XFD_MASK = (1UL << ((2)));

    [NativeTypeName("#define XSTATE_CONTROLFLAG_XSAVEOPT_MASK (1)")]
    public const int XSTATE_CONTROLFLAG_XSAVEOPT_MASK = (1);

    [NativeTypeName("#define XSTATE_CONTROLFLAG_XSAVEC_MASK (2)")]
    public const int XSTATE_CONTROLFLAG_XSAVEC_MASK = (2);

    [NativeTypeName("#define XSTATE_CONTROLFLAG_XFD_MASK (4)")]
    public const int XSTATE_CONTROLFLAG_XFD_MASK = (4);

    [NativeTypeName("#define XSTATE_CONTROLFLAG_VALID_MASK (XSTATE_CONTROLFLAG_XSAVEOPT_MASK | \\\r\n                                             XSTATE_CONTROLFLAG_XSAVEC_MASK | \\\r\n                                             XSTATE_CONTROLFLAG_XFD_MASK)")]
    public const int XSTATE_CONTROLFLAG_VALID_MASK = ((1) | (2) | (4));
}
