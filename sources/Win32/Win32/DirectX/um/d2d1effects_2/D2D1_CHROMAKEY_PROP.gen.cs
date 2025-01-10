// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D2D1_CHROMAKEY_PROP
{
    D2D1_CHROMAKEY_PROP_COLOR = 0,
    D2D1_CHROMAKEY_PROP_TOLERANCE = 1,
    D2D1_CHROMAKEY_PROP_INVERT_ALPHA = 2,
    D2D1_CHROMAKEY_PROP_FEATHER = 3,
    D2D1_CHROMAKEY_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
