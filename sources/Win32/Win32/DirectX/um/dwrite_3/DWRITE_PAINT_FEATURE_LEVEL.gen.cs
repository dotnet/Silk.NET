// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("INT32")]
public enum DWRITE_PAINT_FEATURE_LEVEL
{
    DWRITE_PAINT_FEATURE_LEVEL_NONE = 0,
    DWRITE_PAINT_FEATURE_LEVEL_COLR_V0 = 1,
    DWRITE_PAINT_FEATURE_LEVEL_COLR_V1 = 2,
}
