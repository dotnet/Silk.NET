// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum DWRITE_BASELINE
{
    DWRITE_BASELINE_DEFAULT,
    DWRITE_BASELINE_ROMAN,
    DWRITE_BASELINE_CENTRAL,
    DWRITE_BASELINE_MATH,
    DWRITE_BASELINE_HANGING,
    DWRITE_BASELINE_IDEOGRAPHIC_BOTTOM,
    DWRITE_BASELINE_IDEOGRAPHIC_TOP,
    DWRITE_BASELINE_MINIMUM,
    DWRITE_BASELINE_MAXIMUM,
}
