// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10sdklayers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D10_MESSAGE_SEVERITY
{
    D3D10_MESSAGE_SEVERITY_CORRUPTION = 0,
    D3D10_MESSAGE_SEVERITY_ERROR = (D3D10_MESSAGE_SEVERITY_CORRUPTION + 1),
    D3D10_MESSAGE_SEVERITY_WARNING = (D3D10_MESSAGE_SEVERITY_ERROR + 1),
    D3D10_MESSAGE_SEVERITY_INFO = (D3D10_MESSAGE_SEVERITY_WARNING + 1),
    D3D10_MESSAGE_SEVERITY_MESSAGE = (D3D10_MESSAGE_SEVERITY_INFO + 1),
}
