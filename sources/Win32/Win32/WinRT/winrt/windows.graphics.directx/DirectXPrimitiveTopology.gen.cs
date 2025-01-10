// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.directx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum DirectXPrimitiveTopology
{
    DirectXPrimitiveTopology_Undefined = 0,
    DirectXPrimitiveTopology_PointList = 1,
    DirectXPrimitiveTopology_LineList = 2,
    DirectXPrimitiveTopology_LineStrip = 3,
    DirectXPrimitiveTopology_TriangleList = 4,
    DirectXPrimitiveTopology_TriangleStrip = 5,
}
