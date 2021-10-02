// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            Devtype? deviceType = null,
            uint? adapterOrdinal = null,
            uint? caps = null,
            uint? caps2 = null,
            uint? caps3 = null,
            uint? presentationIntervals = null,
            uint? cursorCaps = null,
            uint? devCaps = null,
            uint? primitiveMiscCaps = null,
            uint? rasterCaps = null,
            uint? zCmpCaps = null,
            uint? srcBlendCaps = null,
            uint? destBlendCaps = null,
            uint? alphaCmpCaps = null,
            uint? shadeCaps = null,
            uint? textureCaps = null,
            uint? textureFilterCaps = null,
            uint? cubeTextureFilterCaps = null,
            uint? volumeTextureFilterCaps = null,
            uint? textureAddressCaps = null,
            uint? volumeTextureAddressCaps = null,
            uint? lineCaps = null,
            uint? maxTextureWidth = null,
            uint? maxTextureHeight = null,
            uint? maxVolumeExtent = null,
            uint? maxTextureRepeat = null,
            uint? maxTextureAspectRatio = null,
            uint? maxAnisotropy = null,
            float? maxVertexW = null,
            float? guardBandLeft = null,
            float? guardBandTop = null,
            float? guardBandRight = null,
            float? guardBandBottom = null,
            float? extentsAdjust = null,
            uint? stencilCaps = null,
            uint? fVFCaps = null,
            uint? textureOpCaps = null,
            uint? maxTextureBlendStages = null,
            uint? maxSimultaneousTextures = null,
            uint? vertexProcessingCaps = null,
            uint? maxActiveLights = null,
            uint? maxUserClipPlanes = null,
            uint? maxVertexBlendMatrices = null,
            uint? maxVertexBlendMatrixIndex = null,
            float? maxPointSize = null,
            uint? maxPrimitiveCount = null,
            uint? maxVertexIndex = null,
            uint? maxStreams = null,
            uint? maxStreamStride = null,
            uint? vertexShaderVersion = null,
            uint? maxVertexShaderConst = null,
            uint? pixelShaderVersion = null,
            float? pixelShader1xMaxValue = null,
            uint? devCaps2 = null,
            float? maxNpatchTessellationLevel = null,
            uint? reserved5 = null,
            uint? masterAdapterOrdinal = null,
            uint? adapterOrdinalInGroup = null,
            uint? numberOfAdaptersInGroup = null,
            uint? declTypes = null,
            uint? numSimultaneousRTs = null,
            uint? stretchRectFilterCaps = null,
            Vshadercaps20? vS20Caps = null,
            Pshadercaps20? pS20Caps = null,
            uint? vertexTextureFilterCaps = null,
            uint? maxVShaderInstructionsExecuted = null,
            uint? maxPShaderInstructionsExecuted = null,
            uint? maxVertexShader30InstructionSlots = null,
            uint? maxPixelShader30InstructionSlots = null
        ) : this()
        {
            if (deviceType is not null)
            {
                DeviceType = deviceType.Value;
            }

            if (adapterOrdinal is not null)
            {
                AdapterOrdinal = adapterOrdinal.Value;
            }

            if (caps is not null)
            {
                Caps = caps.Value;
            }

            if (caps2 is not null)
            {
                Caps2 = caps2.Value;
            }

            if (caps3 is not null)
            {
                Caps3 = caps3.Value;
            }

            if (presentationIntervals is not null)
            {
                PresentationIntervals = presentationIntervals.Value;
            }

            if (cursorCaps is not null)
            {
                CursorCaps = cursorCaps.Value;
            }

            if (devCaps is not null)
            {
                DevCaps = devCaps.Value;
            }

            if (primitiveMiscCaps is not null)
            {
                PrimitiveMiscCaps = primitiveMiscCaps.Value;
            }

            if (rasterCaps is not null)
            {
                RasterCaps = rasterCaps.Value;
            }

            if (zCmpCaps is not null)
            {
                ZCmpCaps = zCmpCaps.Value;
            }

            if (srcBlendCaps is not null)
            {
                SrcBlendCaps = srcBlendCaps.Value;
            }

            if (destBlendCaps is not null)
            {
                DestBlendCaps = destBlendCaps.Value;
            }

            if (alphaCmpCaps is not null)
            {
                AlphaCmpCaps = alphaCmpCaps.Value;
            }

            if (shadeCaps is not null)
            {
                ShadeCaps = shadeCaps.Value;
            }

            if (textureCaps is not null)
            {
                TextureCaps = textureCaps.Value;
            }

            if (textureFilterCaps is not null)
            {
                TextureFilterCaps = textureFilterCaps.Value;
            }

            if (cubeTextureFilterCaps is not null)
            {
                CubeTextureFilterCaps = cubeTextureFilterCaps.Value;
            }

            if (volumeTextureFilterCaps is not null)
            {
                VolumeTextureFilterCaps = volumeTextureFilterCaps.Value;
            }

            if (textureAddressCaps is not null)
            {
                TextureAddressCaps = textureAddressCaps.Value;
            }

            if (volumeTextureAddressCaps is not null)
            {
                VolumeTextureAddressCaps = volumeTextureAddressCaps.Value;
            }

            if (lineCaps is not null)
            {
                LineCaps = lineCaps.Value;
            }

            if (maxTextureWidth is not null)
            {
                MaxTextureWidth = maxTextureWidth.Value;
            }

            if (maxTextureHeight is not null)
            {
                MaxTextureHeight = maxTextureHeight.Value;
            }

            if (maxVolumeExtent is not null)
            {
                MaxVolumeExtent = maxVolumeExtent.Value;
            }

            if (maxTextureRepeat is not null)
            {
                MaxTextureRepeat = maxTextureRepeat.Value;
            }

            if (maxTextureAspectRatio is not null)
            {
                MaxTextureAspectRatio = maxTextureAspectRatio.Value;
            }

            if (maxAnisotropy is not null)
            {
                MaxAnisotropy = maxAnisotropy.Value;
            }

            if (maxVertexW is not null)
            {
                MaxVertexW = maxVertexW.Value;
            }

            if (guardBandLeft is not null)
            {
                GuardBandLeft = guardBandLeft.Value;
            }

            if (guardBandTop is not null)
            {
                GuardBandTop = guardBandTop.Value;
            }

            if (guardBandRight is not null)
            {
                GuardBandRight = guardBandRight.Value;
            }

            if (guardBandBottom is not null)
            {
                GuardBandBottom = guardBandBottom.Value;
            }

            if (extentsAdjust is not null)
            {
                ExtentsAdjust = extentsAdjust.Value;
            }

            if (stencilCaps is not null)
            {
                StencilCaps = stencilCaps.Value;
            }

            if (fVFCaps is not null)
            {
                FVFCaps = fVFCaps.Value;
            }

            if (textureOpCaps is not null)
            {
                TextureOpCaps = textureOpCaps.Value;
            }

            if (maxTextureBlendStages is not null)
            {
                MaxTextureBlendStages = maxTextureBlendStages.Value;
            }

            if (maxSimultaneousTextures is not null)
            {
                MaxSimultaneousTextures = maxSimultaneousTextures.Value;
            }

            if (vertexProcessingCaps is not null)
            {
                VertexProcessingCaps = vertexProcessingCaps.Value;
            }

            if (maxActiveLights is not null)
            {
                MaxActiveLights = maxActiveLights.Value;
            }

            if (maxUserClipPlanes is not null)
            {
                MaxUserClipPlanes = maxUserClipPlanes.Value;
            }

            if (maxVertexBlendMatrices is not null)
            {
                MaxVertexBlendMatrices = maxVertexBlendMatrices.Value;
            }

            if (maxVertexBlendMatrixIndex is not null)
            {
                MaxVertexBlendMatrixIndex = maxVertexBlendMatrixIndex.Value;
            }

            if (maxPointSize is not null)
            {
                MaxPointSize = maxPointSize.Value;
            }

            if (maxPrimitiveCount is not null)
            {
                MaxPrimitiveCount = maxPrimitiveCount.Value;
            }

            if (maxVertexIndex is not null)
            {
                MaxVertexIndex = maxVertexIndex.Value;
            }

            if (maxStreams is not null)
            {
                MaxStreams = maxStreams.Value;
            }

            if (maxStreamStride is not null)
            {
                MaxStreamStride = maxStreamStride.Value;
            }

            if (vertexShaderVersion is not null)
            {
                VertexShaderVersion = vertexShaderVersion.Value;
            }

            if (maxVertexShaderConst is not null)
            {
                MaxVertexShaderConst = maxVertexShaderConst.Value;
            }

            if (pixelShaderVersion is not null)
            {
                PixelShaderVersion = pixelShaderVersion.Value;
            }

            if (pixelShader1xMaxValue is not null)
            {
                PixelShader1xMaxValue = pixelShader1xMaxValue.Value;
            }

            if (devCaps2 is not null)
            {
                DevCaps2 = devCaps2.Value;
            }

            if (maxNpatchTessellationLevel is not null)
            {
                MaxNpatchTessellationLevel = maxNpatchTessellationLevel.Value;
            }

            if (reserved5 is not null)
            {
                Reserved5 = reserved5.Value;
            }

            if (masterAdapterOrdinal is not null)
            {
                MasterAdapterOrdinal = masterAdapterOrdinal.Value;
            }

            if (adapterOrdinalInGroup is not null)
            {
                AdapterOrdinalInGroup = adapterOrdinalInGroup.Value;
            }

            if (numberOfAdaptersInGroup is not null)
            {
                NumberOfAdaptersInGroup = numberOfAdaptersInGroup.Value;
            }

            if (declTypes is not null)
            {
                DeclTypes = declTypes.Value;
            }

            if (numSimultaneousRTs is not null)
            {
                NumSimultaneousRTs = numSimultaneousRTs.Value;
            }

            if (stretchRectFilterCaps is not null)
            {
                StretchRectFilterCaps = stretchRectFilterCaps.Value;
            }

            if (vS20Caps is not null)
            {
                VS20Caps = vS20Caps.Value;
            }

            if (pS20Caps is not null)
            {
                PS20Caps = pS20Caps.Value;
            }

            if (vertexTextureFilterCaps is not null)
            {
                VertexTextureFilterCaps = vertexTextureFilterCaps.Value;
            }

            if (maxVShaderInstructionsExecuted is not null)
            {
                MaxVShaderInstructionsExecuted = maxVShaderInstructionsExecuted.Value;
            }

            if (maxPShaderInstructionsExecuted is not null)
            {
                MaxPShaderInstructionsExecuted = maxPShaderInstructionsExecuted.Value;
            }

            if (maxVertexShader30InstructionSlots is not null)
            {
                MaxVertexShader30InstructionSlots = maxVertexShader30InstructionSlots.Value;
            }

            if (maxPixelShader30InstructionSlots is not null)
            {
                MaxPixelShader30InstructionSlots = maxPixelShader30InstructionSlots.Value;
            }
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
