// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS"]/*'/>
public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS
{
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.OutputMergerLogicOp"]/*'/>
    public BOOL OutputMergerLogicOp;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.UAVOnlyRenderingForcedSampleCount"]/*'/>
    public BOOL UAVOnlyRenderingForcedSampleCount;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.DiscardAPIsSeenByDriver"]/*'/>
    public BOOL DiscardAPIsSeenByDriver;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.FlagsForUpdateAndCopySeenByDriver"]/*'/>
    public BOOL FlagsForUpdateAndCopySeenByDriver;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.ClearView"]/*'/>
    public BOOL ClearView;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.CopyWithOverlap"]/*'/>
    public BOOL CopyWithOverlap;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.ConstantBufferPartialUpdate"]/*'/>
    public BOOL ConstantBufferPartialUpdate;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.ConstantBufferOffsetting"]/*'/>
    public BOOL ConstantBufferOffsetting;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.MapNoOverwriteOnDynamicConstantBuffer"]/*'/>
    public BOOL MapNoOverwriteOnDynamicConstantBuffer;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.MapNoOverwriteOnDynamicBufferSRV"]/*'/>
    public BOOL MapNoOverwriteOnDynamicBufferSRV;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.MultisampleRTVWithForcedSampleCountOne"]/*'/>
    public BOOL MultisampleRTVWithForcedSampleCountOne;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.SAD4ShaderInstructions"]/*'/>
    public BOOL SAD4ShaderInstructions;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.ExtendedDoublesShaderInstructions"]/*'/>
    public BOOL ExtendedDoublesShaderInstructions;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS.ExtendedResourceSharing"]/*'/>
    public BOOL ExtendedResourceSharing;
}