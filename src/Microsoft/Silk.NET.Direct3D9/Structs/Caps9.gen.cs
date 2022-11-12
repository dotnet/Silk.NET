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
            int? caps = null,
            int? caps2 = null,
            int? caps3 = null,
            int? presentationIntervals = null,
            int? cursorCaps = null,
            int? devCaps = null,
            int? primitiveMiscCaps = null,
            int? rasterCaps = null,
            int? zCmpCaps = null,
            int? srcBlendCaps = null,
            int? destBlendCaps = null,
            int? alphaCmpCaps = null,
            int? shadeCaps = null,
            int? textureCaps = null,
            int? textureFilterCaps = null,
            int? cubeTextureFilterCaps = null,
            int? volumeTextureFilterCaps = null,
            int? textureAddressCaps = null,
            int? volumeTextureAddressCaps = null,
            int? lineCaps = null,
            int? maxTextureWidth = null,
            int? maxTextureHeight = null,
            int? maxVolumeExtent = null,
            int? maxTextureRepeat = null,
            int? maxTextureAspectRatio = null,
            int? maxAnisotropy = null,
            float? maxVertexW = null,
            float? guardBandLeft = null,
            float? guardBandTop = null,
            float? guardBandRight = null,
            float? guardBandBottom = null,
            float? extentsAdjust = null,
            int? stencilCaps = null,
            int? fVFCaps = null,
            int? textureOpCaps = null,
            int? maxTextureBlendStages = null,
            int? maxSimultaneousTextures = null,
            int? vertexProcessingCaps = null,
            int? maxActiveLights = null,
            int? maxUserClipPlanes = null,
            int? maxVertexBlendMatrices = null,
            int? maxVertexBlendMatrixIndex = null,
            float? maxPointSize = null,
            int? maxPrimitiveCount = null,
            int? maxVertexIndex = null,
            int? maxStreams = null,
            int? maxStreamStride = null,
            int? vertexShaderVersion = null,
            int? maxVertexShaderConst = null,
            int? pixelShaderVersion = null,
            float? pixelShader1xMaxValue = null,
            int? devCaps2 = null,
            float? maxNpatchTessellationLevel = null,
            int? reserved5 = null,
            uint? masterAdapterOrdinal = null,
            uint? adapterOrdinalInGroup = null,
            uint? numberOfAdaptersInGroup = null,
            int? declTypes = null,
            int? numSimultaneousRTs = null,
            int? stretchRectFilterCaps = null,
            Vshadercaps20? vS20Caps = null,
            Pshadercaps20? pS20Caps = null,
            int? vertexTextureFilterCaps = null,
            int? maxVShaderInstructionsExecuted = null,
            int? maxPShaderInstructionsExecuted = null,
            int? maxVertexShader30InstructionSlots = null,
            int? maxPixelShader30InstructionSlots = null
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
        public int Caps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Caps2")]
        public int Caps2;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Caps3")]
        public int Caps3;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "PresentationIntervals")]
        public int PresentationIntervals;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "CursorCaps")]
        public int CursorCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DevCaps")]
        public int DevCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "PrimitiveMiscCaps")]
        public int PrimitiveMiscCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "RasterCaps")]
        public int RasterCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "ZCmpCaps")]
        public int ZCmpCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "SrcBlendCaps")]
        public int SrcBlendCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DestBlendCaps")]
        public int DestBlendCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "AlphaCmpCaps")]
        public int AlphaCmpCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "ShadeCaps")]
        public int ShadeCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TextureCaps")]
        public int TextureCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TextureFilterCaps")]
        public int TextureFilterCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "CubeTextureFilterCaps")]
        public int CubeTextureFilterCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "VolumeTextureFilterCaps")]
        public int VolumeTextureFilterCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TextureAddressCaps")]
        public int TextureAddressCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "VolumeTextureAddressCaps")]
        public int VolumeTextureAddressCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "LineCaps")]
        public int LineCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxTextureWidth")]
        public int MaxTextureWidth;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxTextureHeight")]
        public int MaxTextureHeight;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVolumeExtent")]
        public int MaxVolumeExtent;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxTextureRepeat")]
        public int MaxTextureRepeat;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxTextureAspectRatio")]
        public int MaxTextureAspectRatio;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxAnisotropy")]
        public int MaxAnisotropy;

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
        public int StencilCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "FVFCaps")]
        public int FVFCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TextureOpCaps")]
        public int TextureOpCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxTextureBlendStages")]
        public int MaxTextureBlendStages;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxSimultaneousTextures")]
        public int MaxSimultaneousTextures;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "VertexProcessingCaps")]
        public int VertexProcessingCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxActiveLights")]
        public int MaxActiveLights;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxUserClipPlanes")]
        public int MaxUserClipPlanes;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVertexBlendMatrices")]
        public int MaxVertexBlendMatrices;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVertexBlendMatrixIndex")]
        public int MaxVertexBlendMatrixIndex;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "MaxPointSize")]
        public float MaxPointSize;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxPrimitiveCount")]
        public int MaxPrimitiveCount;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVertexIndex")]
        public int MaxVertexIndex;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxStreams")]
        public int MaxStreams;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxStreamStride")]
        public int MaxStreamStride;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "VertexShaderVersion")]
        public int VertexShaderVersion;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVertexShaderConst")]
        public int MaxVertexShaderConst;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "PixelShaderVersion")]
        public int PixelShaderVersion;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "PixelShader1xMaxValue")]
        public float PixelShader1xMaxValue;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DevCaps2")]
        public int DevCaps2;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "MaxNpatchTessellationLevel")]
        public float MaxNpatchTessellationLevel;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Reserved5")]
        public int Reserved5;

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
        public int DeclTypes;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumSimultaneousRTs")]
        public int NumSimultaneousRTs;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "StretchRectFilterCaps")]
        public int StretchRectFilterCaps;

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
        public int VertexTextureFilterCaps;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVShaderInstructionsExecuted")]
        public int MaxVShaderInstructionsExecuted;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxPShaderInstructionsExecuted")]
        public int MaxPShaderInstructionsExecuted;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxVertexShader30InstructionSlots")]
        public int MaxVertexShader30InstructionSlots;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MaxPixelShader30InstructionSlots")]
        public int MaxPixelShader30InstructionSlots;
    }
}
