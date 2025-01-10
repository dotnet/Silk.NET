// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("UINT32")]
public enum DWRITE_FONT_AXIS_TAG : uint
{
    DWRITE_FONT_AXIS_TAG_WEIGHT =
        unchecked(
            (uint)(
                (uint)
                    (DWRITE_FONT_AXIS_TAG)(
                        ((uint)((byte)('t')) << 24)
                        | ((uint)((byte)('h')) << 16)
                        | ((uint)((byte)('g')) << 8)
                        | (uint)((byte)('w'))
                    )
            )
        ),
    DWRITE_FONT_AXIS_TAG_WIDTH =
        unchecked(
            (uint)(
                (uint)
                    (DWRITE_FONT_AXIS_TAG)(
                        ((uint)((byte)('h')) << 24)
                        | ((uint)((byte)('t')) << 16)
                        | ((uint)((byte)('d')) << 8)
                        | (uint)((byte)('w'))
                    )
            )
        ),
    DWRITE_FONT_AXIS_TAG_SLANT =
        unchecked(
            (uint)(
                (uint)
                    (DWRITE_FONT_AXIS_TAG)(
                        ((uint)((byte)('t')) << 24)
                        | ((uint)((byte)('n')) << 16)
                        | ((uint)((byte)('l')) << 8)
                        | (uint)((byte)('s'))
                    )
            )
        ),
    DWRITE_FONT_AXIS_TAG_OPTICAL_SIZE =
        unchecked(
            (uint)(
                (uint)
                    (DWRITE_FONT_AXIS_TAG)(
                        ((uint)((byte)('z')) << 24)
                        | ((uint)((byte)('s')) << 16)
                        | ((uint)((byte)('p')) << 8)
                        | (uint)((byte)('o'))
                    )
            )
        ),
    DWRITE_FONT_AXIS_TAG_ITALIC =
        unchecked(
            (uint)(
                (uint)
                    (DWRITE_FONT_AXIS_TAG)(
                        ((uint)((byte)('l')) << 24)
                        | ((uint)((byte)('a')) << 16)
                        | ((uint)((byte)('t')) << 8)
                        | (uint)((byte)('i'))
                    )
            )
        ),
}
