// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DCAPS9")]
    public unsafe partial struct Caps9
    {
        public Caps9
        (
            Devtype deviceType = default,
            uint adapterOrdinal = default,
            uint caps = default,
            uint caps2 = default,
            uint caps3 = default,
            uint presentationIntervals = default,
            uint cursorCaps = default,
            uint devCaps = default,
            uint primitiveMiscCaps = default,
            uint rasterCaps = default,
            uint zCmpCaps = default,
            uint srcBlendCaps = default,
            uint destBlendCaps = default,
            uint alphaCmpCaps = default,
            uint shadeCaps = default,
            uint textureCaps = default,
            uint textureFilterCaps = default,
            uint cubeTextureFilterCaps = default,
            uint volumeTextureFilterCaps = default,
            uint textureAddressCaps = default,
            uint volumeTextureAddressCaps = default,
            uint lineCaps = default,
            uint maxTextureWidth = default,
            uint maxTextureHeight = default,
            uint maxVolumeExtent = default,
            uint maxTextureRepeat = default,
            uint maxTextureAspectRatio = default,
            uint maxAnisotropy = default,
            float maxVertexW = default,
            float guardBandLeft = default,
            float guardBandTop = default,
            float guardBandRight = default,
            float guardBandBottom = default,
            float extentsAdjust = default,
            uint stencilCaps = default,
            uint fVFCaps = default,
            uint textureOpCaps = default,
            uint maxTextureBlendStages = default,
            uint maxSimultaneousTextures = default,
            uint vertexProcessingCaps = default,
            uint maxActiveLights = default,
            uint maxUserClipPlanes = default,
            uint maxVertexBlendMatrices = default,
            uint maxVertexBlendMatrixIndex = default,
            float maxPointSize = default,
            uint maxPrimitiveCount = default,
            uint maxVertexIndex = default,
            uint maxStreams = default,
            uint maxStreamStride = default,
            uint vertexShaderVersion = default,
            uint maxVertexShaderConst = default,
            uint pixelShaderVersion = default,
            float pixelShader1xMaxValue = default,
            uint devCaps2 = default,
            float maxNpatchTessellationLevel = default,
            uint reserved5 = default,
            uint masterAdapterOrdinal = default,
            uint adapterOrdinalInGroup = default,
            uint numberOfAdaptersInGroup = default,
            uint declTypes = default,
            uint numSimultaneousRTs = default,
            uint stretchRectFilterCaps = default,
            Vshadercaps20 vS20Caps = default,
            Pshadercaps20 pS20Caps = default,
            uint vertexTextureFilterCaps = default,
            uint maxVShaderInstructionsExecuted = default,
            uint maxPShaderInstructionsExecuted = default,
            uint maxVertexShader30InstructionSlots = default,
            uint maxPixelShader30InstructionSlots = default
        )
        {
            DeviceType = deviceType;
            AdapterOrdinal = adapterOrdinal;
            Caps = caps;
            Caps2 = caps2;
            Caps3 = caps3;
            PresentationIntervals = presentationIntervals;
            CursorCaps = cursorCaps;
            DevCaps = devCaps;
            PrimitiveMiscCaps = primitiveMiscCaps;
            RasterCaps = rasterCaps;
            ZCmpCaps = zCmpCaps;
            SrcBlendCaps = srcBlendCaps;
            DestBlendCaps = destBlendCaps;
            AlphaCmpCaps = alphaCmpCaps;
            ShadeCaps = shadeCaps;
            TextureCaps = textureCaps;
            TextureFilterCaps = textureFilterCaps;
            CubeTextureFilterCaps = cubeTextureFilterCaps;
            VolumeTextureFilterCaps = volumeTextureFilterCaps;
            TextureAddressCaps = textureAddressCaps;
            VolumeTextureAddressCaps = volumeTextureAddressCaps;
            LineCaps = lineCaps;
            MaxTextureWidth = maxTextureWidth;
            MaxTextureHeight = maxTextureHeight;
            MaxVolumeExtent = maxVolumeExtent;
            MaxTextureRepeat = maxTextureRepeat;
            MaxTextureAspectRatio = maxTextureAspectRatio;
            MaxAnisotropy = maxAnisotropy;
            MaxVertexW = maxVertexW;
            GuardBandLeft = guardBandLeft;
            GuardBandTop = guardBandTop;
            GuardBandRight = guardBandRight;
            GuardBandBottom = guardBandBottom;
            ExtentsAdjust = extentsAdjust;
            StencilCaps = stencilCaps;
            FVFCaps = fVFCaps;
            TextureOpCaps = textureOpCaps;
            MaxTextureBlendStages = maxTextureBlendStages;
            MaxSimultaneousTextures = maxSimultaneousTextures;
            VertexProcessingCaps = vertexProcessingCaps;
            MaxActiveLights = maxActiveLights;
            MaxUserClipPlanes = maxUserClipPlanes;
            MaxVertexBlendMatrices = maxVertexBlendMatrices;
            MaxVertexBlendMatrixIndex = maxVertexBlendMatrixIndex;
            MaxPointSize = maxPointSize;
            MaxPrimitiveCount = maxPrimitiveCount;
            MaxVertexIndex = maxVertexIndex;
            MaxStreams = maxStreams;
            MaxStreamStride = maxStreamStride;
            VertexShaderVersion = vertexShaderVersion;
            MaxVertexShaderConst = maxVertexShaderConst;
            PixelShaderVersion = pixelShaderVersion;
            PixelShader1xMaxValue = pixelShader1xMaxValue;
            DevCaps2 = devCaps2;
            MaxNpatchTessellationLevel = maxNpatchTessellationLevel;
            Reserved5 = reserved5;
            MasterAdapterOrdinal = masterAdapterOrdinal;
            AdapterOrdinalInGroup = adapterOrdinalInGroup;
            NumberOfAdaptersInGroup = numberOfAdaptersInGroup;
            DeclTypes = declTypes;
            NumSimultaneousRTs = numSimultaneousRTs;
            StretchRectFilterCaps = stretchRectFilterCaps;
            VS20Caps = vS20Caps;
            PS20Caps = pS20Caps;
            VertexTextureFilterCaps = vertexTextureFilterCaps;
            MaxVShaderInstructionsExecuted = maxVShaderInstructionsExecuted;
            MaxPShaderInstructionsExecuted = maxPShaderInstructionsExecuted;
            MaxVertexShader30InstructionSlots = maxVertexShader30InstructionSlots;
            MaxPixelShader30InstructionSlots = maxPixelShader30InstructionSlots;
        }


        [NativeName("Type", "D3DDEVTYPE")]
        [NativeName("Type.Name", "D3DDEVTYPE")]
        [NativeName("Name", "DeviceType")]
        public Devtype DeviceType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "AdapterOrdinal")]
        public uint AdapterOrdinal;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Caps")]
        public uint Caps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Caps2")]
        public uint Caps2;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Caps3")]
        public uint Caps3;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "PresentationIntervals")]
        public uint PresentationIntervals;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "CursorCaps")]
        public uint CursorCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DevCaps")]
        public uint DevCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "PrimitiveMiscCaps")]
        public uint PrimitiveMiscCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "RasterCaps")]
        public uint RasterCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "ZCmpCaps")]
        public uint ZCmpCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "SrcBlendCaps")]
        public uint SrcBlendCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DestBlendCaps")]
        public uint DestBlendCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "AlphaCmpCaps")]
        public uint AlphaCmpCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "ShadeCaps")]
        public uint ShadeCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TextureCaps")]
        public uint TextureCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TextureFilterCaps")]
        public uint TextureFilterCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "CubeTextureFilterCaps")]
        public uint CubeTextureFilterCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "VolumeTextureFilterCaps")]
        public uint VolumeTextureFilterCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TextureAddressCaps")]
        public uint TextureAddressCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "VolumeTextureAddressCaps")]
        public uint VolumeTextureAddressCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "LineCaps")]
        public uint LineCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxTextureWidth")]
        public uint MaxTextureWidth;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxTextureHeight")]
        public uint MaxTextureHeight;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVolumeExtent")]
        public uint MaxVolumeExtent;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxTextureRepeat")]
        public uint MaxTextureRepeat;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxTextureAspectRatio")]
        public uint MaxTextureAspectRatio;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxAnisotropy")]
        public uint MaxAnisotropy;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "MaxVertexW")]
        public float MaxVertexW;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "GuardBandLeft")]
        public float GuardBandLeft;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "GuardBandTop")]
        public float GuardBandTop;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "GuardBandRight")]
        public float GuardBandRight;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "GuardBandBottom")]
        public float GuardBandBottom;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "ExtentsAdjust")]
        public float ExtentsAdjust;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "StencilCaps")]
        public uint StencilCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "FVFCaps")]
        public uint FVFCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TextureOpCaps")]
        public uint TextureOpCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxTextureBlendStages")]
        public uint MaxTextureBlendStages;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxSimultaneousTextures")]
        public uint MaxSimultaneousTextures;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "VertexProcessingCaps")]
        public uint VertexProcessingCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxActiveLights")]
        public uint MaxActiveLights;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxUserClipPlanes")]
        public uint MaxUserClipPlanes;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVertexBlendMatrices")]
        public uint MaxVertexBlendMatrices;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVertexBlendMatrixIndex")]
        public uint MaxVertexBlendMatrixIndex;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "MaxPointSize")]
        public float MaxPointSize;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxPrimitiveCount")]
        public uint MaxPrimitiveCount;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVertexIndex")]
        public uint MaxVertexIndex;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxStreams")]
        public uint MaxStreams;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxStreamStride")]
        public uint MaxStreamStride;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "VertexShaderVersion")]
        public uint VertexShaderVersion;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVertexShaderConst")]
        public uint MaxVertexShaderConst;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "PixelShaderVersion")]
        public uint PixelShaderVersion;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "PixelShader1xMaxValue")]
        public float PixelShader1xMaxValue;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DevCaps2")]
        public uint DevCaps2;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "MaxNpatchTessellationLevel")]
        public float MaxNpatchTessellationLevel;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Reserved5")]
        public uint Reserved5;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MasterAdapterOrdinal")]
        public uint MasterAdapterOrdinal;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "AdapterOrdinalInGroup")]
        public uint AdapterOrdinalInGroup;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumberOfAdaptersInGroup")]
        public uint NumberOfAdaptersInGroup;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DeclTypes")]
        public uint DeclTypes;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumSimultaneousRTs")]
        public uint NumSimultaneousRTs;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "StretchRectFilterCaps")]
        public uint StretchRectFilterCaps;

        [NativeName("Type", "D3DVSHADERCAPS2_0")]
        [NativeName("Type.Name", "D3DVSHADERCAPS2_0")]
        [NativeName("Name", "VS20Caps")]
        public Vshadercaps20 VS20Caps;

        [NativeName("Type", "D3DPSHADERCAPS2_0")]
        [NativeName("Type.Name", "D3DPSHADERCAPS2_0")]
        [NativeName("Name", "PS20Caps")]
        public Pshadercaps20 PS20Caps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "VertexTextureFilterCaps")]
        public uint VertexTextureFilterCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVShaderInstructionsExecuted")]
        public uint MaxVShaderInstructionsExecuted;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxPShaderInstructionsExecuted")]
        public uint MaxPShaderInstructionsExecuted;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVertexShader30InstructionSlots")]
        public uint MaxVertexShader30InstructionSlots;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxPixelShader30InstructionSlots")]
        public uint MaxPixelShader30InstructionSlots;
    }
}
