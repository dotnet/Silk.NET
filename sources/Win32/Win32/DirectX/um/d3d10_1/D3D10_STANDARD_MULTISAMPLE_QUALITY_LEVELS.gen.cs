// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D10_STANDARD_MULTISAMPLE_QUALITY_LEVELS
{
    D3D10_STANDARD_MULTISAMPLE_PATTERN = unchecked((int)(0xffffffff)),
    D3D10_CENTER_MULTISAMPLE_PATTERN = unchecked((int)(0xfffffffe)),
}
