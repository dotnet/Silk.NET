// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.directx.direct3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum Direct3DUsage
{
    Direct3DUsage_Default = 0,
    Direct3DUsage_Immutable = 1,
    Direct3DUsage_Dynamic = 2,
    Direct3DUsage_Staging = 3,
}
