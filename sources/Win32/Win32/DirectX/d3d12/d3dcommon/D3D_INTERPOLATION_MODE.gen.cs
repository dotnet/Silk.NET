// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D_INTERPOLATION_MODE
{
    D3D_INTERPOLATION_UNDEFINED = 0,
    D3D_INTERPOLATION_CONSTANT = 1,
    D3D_INTERPOLATION_LINEAR = 2,
    D3D_INTERPOLATION_LINEAR_CENTROID = 3,
    D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE = 4,
    D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_CENTROID = 5,
    D3D_INTERPOLATION_LINEAR_SAMPLE = 6,
    D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_SAMPLE = 7,
}
