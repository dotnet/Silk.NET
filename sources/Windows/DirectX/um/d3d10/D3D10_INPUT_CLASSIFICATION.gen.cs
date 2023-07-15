// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_INPUT_CLASSIFICATION.xml' path='doc/member[@name="D3D10_INPUT_CLASSIFICATION"]/*'/>
public enum D3D10_INPUT_CLASSIFICATION
{
    /// <include file='D3D10_INPUT_CLASSIFICATION.xml' path='doc/member[@name="D3D10_INPUT_CLASSIFICATION.D3D10_INPUT_PER_VERTEX_DATA"]/*'/>
    D3D10_INPUT_PER_VERTEX_DATA = 0,
    /// <include file='D3D10_INPUT_CLASSIFICATION.xml' path='doc/member[@name="D3D10_INPUT_CLASSIFICATION.D3D10_INPUT_PER_INSTANCE_DATA"]/*'/>
    D3D10_INPUT_PER_INSTANCE_DATA = 1,
}