// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3DCAPS9
{
    public D3DDEVTYPE DeviceType;
    public uint AdapterOrdinal;

    [NativeTypeName("DWORD")]
    public uint Caps;

    [NativeTypeName("DWORD")]
    public uint Caps2;

    [NativeTypeName("DWORD")]
    public uint Caps3;

    [NativeTypeName("DWORD")]
    public uint PresentationIntervals;

    [NativeTypeName("DWORD")]
    public uint CursorCaps;

    [NativeTypeName("DWORD")]
    public uint DevCaps;

    [NativeTypeName("DWORD")]
    public uint PrimitiveMiscCaps;

    [NativeTypeName("DWORD")]
    public uint RasterCaps;

    [NativeTypeName("DWORD")]
    public uint ZCmpCaps;

    [NativeTypeName("DWORD")]
    public uint SrcBlendCaps;

    [NativeTypeName("DWORD")]
    public uint DestBlendCaps;

    [NativeTypeName("DWORD")]
    public uint AlphaCmpCaps;

    [NativeTypeName("DWORD")]
    public uint ShadeCaps;

    [NativeTypeName("DWORD")]
    public uint TextureCaps;

    [NativeTypeName("DWORD")]
    public uint TextureFilterCaps;

    [NativeTypeName("DWORD")]
    public uint CubeTextureFilterCaps;

    [NativeTypeName("DWORD")]
    public uint VolumeTextureFilterCaps;

    [NativeTypeName("DWORD")]
    public uint TextureAddressCaps;

    [NativeTypeName("DWORD")]
    public uint VolumeTextureAddressCaps;

    [NativeTypeName("DWORD")]
    public uint LineCaps;

    [NativeTypeName("DWORD")]
    public uint MaxTextureWidth;

    [NativeTypeName("DWORD")]
    public uint MaxTextureHeight;

    [NativeTypeName("DWORD")]
    public uint MaxVolumeExtent;

    [NativeTypeName("DWORD")]
    public uint MaxTextureRepeat;

    [NativeTypeName("DWORD")]
    public uint MaxTextureAspectRatio;

    [NativeTypeName("DWORD")]
    public uint MaxAnisotropy;
    public float MaxVertexW;
    public float GuardBandLeft;
    public float GuardBandTop;
    public float GuardBandRight;
    public float GuardBandBottom;
    public float ExtentsAdjust;

    [NativeTypeName("DWORD")]
    public uint StencilCaps;

    [NativeTypeName("DWORD")]
    public uint FVFCaps;

    [NativeTypeName("DWORD")]
    public uint TextureOpCaps;

    [NativeTypeName("DWORD")]
    public uint MaxTextureBlendStages;

    [NativeTypeName("DWORD")]
    public uint MaxSimultaneousTextures;

    [NativeTypeName("DWORD")]
    public uint VertexProcessingCaps;

    [NativeTypeName("DWORD")]
    public uint MaxActiveLights;

    [NativeTypeName("DWORD")]
    public uint MaxUserClipPlanes;

    [NativeTypeName("DWORD")]
    public uint MaxVertexBlendMatrices;

    [NativeTypeName("DWORD")]
    public uint MaxVertexBlendMatrixIndex;
    public float MaxPointSize;

    [NativeTypeName("DWORD")]
    public uint MaxPrimitiveCount;

    [NativeTypeName("DWORD")]
    public uint MaxVertexIndex;

    [NativeTypeName("DWORD")]
    public uint MaxStreams;

    [NativeTypeName("DWORD")]
    public uint MaxStreamStride;

    [NativeTypeName("DWORD")]
    public uint VertexShaderVersion;

    [NativeTypeName("DWORD")]
    public uint MaxVertexShaderConst;

    [NativeTypeName("DWORD")]
    public uint PixelShaderVersion;
    public float PixelShader1xMaxValue;

    [NativeTypeName("DWORD")]
    public uint DevCaps2;
    public float MaxNpatchTessellationLevel;

    [NativeTypeName("DWORD")]
    public uint Reserved5;
    public uint MasterAdapterOrdinal;
    public uint AdapterOrdinalInGroup;
    public uint NumberOfAdaptersInGroup;

    [NativeTypeName("DWORD")]
    public uint DeclTypes;

    [NativeTypeName("DWORD")]
    public uint NumSimultaneousRTs;

    [NativeTypeName("DWORD")]
    public uint StretchRectFilterCaps;
    public D3DVSHADERCAPS2_0 VS20Caps;
    public D3DPSHADERCAPS2_0 PS20Caps;

    [NativeTypeName("DWORD")]
    public uint VertexTextureFilterCaps;

    [NativeTypeName("DWORD")]
    public uint MaxVShaderInstructionsExecuted;

    [NativeTypeName("DWORD")]
    public uint MaxPShaderInstructionsExecuted;

    [NativeTypeName("DWORD")]
    public uint MaxVertexShader30InstructionSlots;

    [NativeTypeName("DWORD")]
    public uint MaxPixelShader30InstructionSlots;
}
