// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3DCOMPOSERECTSOP
{
    D3DCOMPOSERECTS_COPY = 1,
    D3DCOMPOSERECTS_OR = 2,
    D3DCOMPOSERECTS_AND = 3,
    D3DCOMPOSERECTS_NEG = 4,
    D3DCOMPOSERECTS_FORCE_DWORD = 0x7fffffff,
}
