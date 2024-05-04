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
    public unsafe partial class D3D9 : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "DIRECT3D_VERSION")]
        public const int Direct3DVersion = unchecked((int) 0x900);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SDK_VERSION")]
        public const int SdkVersion = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D9b_SDK_VERSION")]
        public const int D3D9bSdkVersion = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DMAXUSERCLIPPLANES")]
        public const int Maxuserclipplanes = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCS_LEFT")]
        public const int CSLeft = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCS_RIGHT")]
        public const int CSRight = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCS_TOP")]
        public const int CSTop = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCS_BOTTOM")]
        public const int CSBottom = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCS_FRONT")]
        public const int CSFront = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCS_BACK")]
        public const int CSBack = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCS_PLANE0")]
        public const int CSPlane0 = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCS_PLANE1")]
        public const int CSPlane1 = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCS_PLANE2")]
        public const int CSPlane2 = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCS_PLANE3")]
        public const int CSPlane3 = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCS_PLANE4")]
        public const int CSPlane4 = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCS_PLANE5")]
        public const int CSPlane5 = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCLEAR_TARGET")]
        public const int ClearTarget = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCLEAR_ZBUFFER")]
        public const int ClearZbuffer = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCLEAR_STENCIL")]
        public const int ClearStencil = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_MAX_SIMULTANEOUS_RENDERTARGETS")]
        public const int MaxSimultaneousRendertargets = unchecked((int) 0x4);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "D3DRENDERSTATE_WRAPBIAS")]
        public const uint RenderstateWrapbias = unchecked((uint) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DWRAP_U")]
        public const int WrapU = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DWRAP_V")]
        public const int WrapV = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DWRAP_W")]
        public const int WrapW = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DWRAPCOORD_0")]
        public const int Wrapcoord0 = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DWRAPCOORD_1")]
        public const int Wrapcoord1 = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DWRAPCOORD_2")]
        public const int Wrapcoord2 = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DWRAPCOORD_3")]
        public const int Wrapcoord3 = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DDMAPSAMPLER")]
        public const int Dmapsampler = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTSS_TCI_PASSTHRU")]
        public const int TssTciPassthru = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTSS_TCI_CAMERASPACENORMAL")]
        public const int TssTciCameraspacenormal = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTSS_TCI_CAMERASPACEPOSITION")]
        public const int TssTciCameraspaceposition = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTSS_TCI_CAMERASPACEREFLECTIONVECTOR")]
        public const int TssTciCameraspacereflectionvector = unchecked((int) 0x30000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTSS_TCI_SPHEREMAP")]
        public const int TssTciSpheremap = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTA_SELECTMASK")]
        public const int TASelectmask = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTA_DIFFUSE")]
        public const int TADiffuse = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTA_CURRENT")]
        public const int TACurrent = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTA_TEXTURE")]
        public const int TATexture = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTA_TFACTOR")]
        public const int TATfactor = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTA_SPECULAR")]
        public const int TASpecular = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTA_TEMP")]
        public const int TATemp = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTA_CONSTANT")]
        public const int TAConstant = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTA_COMPLEMENT")]
        public const int TAComplement = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DTA_ALPHAREPLICATE")]
        public const int TAAlphareplicate = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_RESERVED0")]
        public const int FvfReserved0 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_POSITION_MASK")]
        public const int FvfPositionMask = unchecked((int) 0x400E);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_XYZ")]
        public const int FvfXyz = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_XYZRHW")]
        public const int FvfXyzrhw = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_XYZB1")]
        public const int FvfXyzb1 = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_XYZB2")]
        public const int FvfXyzb2 = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_XYZB3")]
        public const int FvfXyzb3 = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_XYZB4")]
        public const int FvfXyzb4 = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_XYZB5")]
        public const int FvfXyzb5 = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_XYZW")]
        public const int FvfXyzw = unchecked((int) 0x4002);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_NORMAL")]
        public const int FvfNormal = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_PSIZE")]
        public const int FvfPsize = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_DIFFUSE")]
        public const int FvfDiffuse = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_SPECULAR")]
        public const int FvfSpecular = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEXCOUNT_MASK")]
        public const int FvfTexcountMask = unchecked((int) 0xF00);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEXCOUNT_SHIFT")]
        public const int FvfTexcountShift = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEX0")]
        public const int FvfTex0 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEX1")]
        public const int FvfTex1 = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEX2")]
        public const int FvfTex2 = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEX3")]
        public const int FvfTex3 = unchecked((int) 0x300);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEX4")]
        public const int FvfTex4 = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEX5")]
        public const int FvfTex5 = unchecked((int) 0x500);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEX6")]
        public const int FvfTex6 = unchecked((int) 0x600);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEX7")]
        public const int FvfTex7 = unchecked((int) 0x700);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEX8")]
        public const int FvfTex8 = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_LASTBETA_UBYTE4")]
        public const int FvfLastbetaUbyte4 = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_LASTBETA_D3DCOLOR")]
        public const int FvfLastbetaD3Dcolor = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_RESERVED2")]
        public const int FvfReserved2 = unchecked((int) 0x6000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXD3DDECLUSAGEINDEX")]
        public const int Maxd3Ddeclusageindex = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXD3DDECLLENGTH")]
        public const int Maxd3Ddecllength = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DDP_MAXTEXCOORD")]
        public const int DPMaxtexcoord = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSI_OPCODE_MASK")]
        public const int SIOpcodeMask = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSI_INSTLENGTH_MASK")]
        public const int SIInstlengthMask = unchecked((int) 0xF000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSI_INSTLENGTH_SHIFT")]
        public const int SIInstlengthShift = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSI_COISSUE")]
        public const int SICoissue = unchecked((int) 0x40000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_OPCODESPECIFICCONTROL_MASK")]
        public const int SPOpcodespecificcontrolMask = unchecked((int) 0xFF0000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_OPCODESPECIFICCONTROL_SHIFT")]
        public const int SPOpcodespecificcontrolShift = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSHADER_COMPARISON_SHIFT")]
        public const int ShaderComparisonShift = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_DCL_USAGE_SHIFT")]
        public const int SPDclUsageShift = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_DCL_USAGE_MASK")]
        public const int SPDclUsageMask = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_DCL_USAGEINDEX_SHIFT")]
        public const int SPDclUsageindexShift = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_DCL_USAGEINDEX_MASK")]
        public const int SPDclUsageindexMask = unchecked((int) 0xF0000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_TEXTURETYPE_SHIFT")]
        public const int SPTexturetypeShift = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_TEXTURETYPE_MASK")]
        public const int SPTexturetypeMask = unchecked((int) 0x78000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_REGNUM_MASK")]
        public const int SPRegnumMask = unchecked((int) 0x7FF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_WRITEMASK_0")]
        public const int SPWritemask0 = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_WRITEMASK_1")]
        public const int SPWritemask1 = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_WRITEMASK_2")]
        public const int SPWritemask2 = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_WRITEMASK_3")]
        public const int SPWritemask3 = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_WRITEMASK_ALL")]
        public const int SPWritemaskAll = unchecked((int) 0xF0000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_DSTMOD_SHIFT")]
        public const int SPDstmodShift = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_DSTMOD_MASK")]
        public const int SPDstmodMask = unchecked((int) 0xF00000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_DSTSHIFT_SHIFT")]
        public const int SPDstshiftShift = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_DSTSHIFT_MASK")]
        public const int SPDstshiftMask = unchecked((int) 0xF000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_REGTYPE_SHIFT")]
        public const int SPRegtypeShift = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_REGTYPE_SHIFT2")]
        public const int SPRegtypeShift2 = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_REGTYPE_MASK")]
        public const int SPRegtypeMask = unchecked((int) 0x70000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_REGTYPE_MASK2")]
        public const int SPRegtypeMask2 = unchecked((int) 0x1800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DVS_ADDRESSMODE_SHIFT")]
        public const int VSAddressmodeShift = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSHADER_ADDRESSMODE_SHIFT")]
        public const int ShaderAddressmodeShift = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DVS_SWIZZLE_SHIFT")]
        public const int VSSwizzleShift = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DVS_SWIZZLE_MASK")]
        public const int VSSwizzleMask = unchecked((int) 0xFF0000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_SWIZZLE_SHIFT")]
        public const int SPSwizzleShift = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_SWIZZLE_MASK")]
        public const int SPSwizzleMask = unchecked((int) 0xFF0000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_SRCMOD_SHIFT")]
        public const int SPSrcmodShift = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_SRCMOD_MASK")]
        public const int SPSrcmodMask = unchecked((int) 0xF000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_MIN_PRECISION_SHIFT")]
        public const int SPMinPrecisionShift = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSP_MIN_PRECISION_MASK")]
        public const int SPMinPrecisionMask = unchecked((int) 0xC000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSI_COMMENTSIZE_SHIFT")]
        public const int SICommentsizeShift = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DSI_COMMENTSIZE_MASK")]
        public const int SICommentsizeMask = unchecked((int) 0x7FFF0000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEXTUREFORMAT2")]
        public const int FvfTextureformat2 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEXTUREFORMAT1")]
        public const int FvfTextureformat1 = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEXTUREFORMAT3")]
        public const int FvfTextureformat3 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFVF_TEXTUREFORMAT4")]
        public const int FvfTextureformat4 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPRESENT_RATE_DEFAULT")]
        public const int PresentRateDefault = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPRESENTFLAG_LOCKABLE_BACKBUFFER")]
        public const int PresentflagLockableBackbuffer = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPRESENTFLAG_DISCARD_DEPTHSTENCIL")]
        public const int PresentflagDiscardDepthstencil = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPRESENTFLAG_DEVICECLIP")]
        public const int PresentflagDeviceclip = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPRESENTFLAG_VIDEO")]
        public const int PresentflagVideo = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPRESENTFLAG_NOAUTOROTATE")]
        public const int PresentflagNoautorotate = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPRESENTFLAG_UNPRUNEDMODE")]
        public const int PresentflagUnprunedmode = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPRESENTFLAG_OVERLAY_LIMITEDRGB")]
        public const int PresentflagOverlayLimitedrgb = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPRESENTFLAG_OVERLAY_YCbCr_BT709")]
        public const int PresentflagOverlayYCbCrBT709 = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPRESENTFLAG_OVERLAY_YCbCr_xvYCC")]
        public const int PresentflagOverlayYCbCrXvYcc = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPRESENTFLAG_RESTRICTED_CONTENT")]
        public const int PresentflagRestrictedContent = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPRESENTFLAG_RESTRICT_SHARED_RESOURCE_DRIVER")]
        public const int PresentflagRestrictSharedResourceDriver = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_RENDERTARGET")]
        public const int UsageRendertarget = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_DEPTHSTENCIL")]
        public const int UsageDepthstencil = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_DYNAMIC")]
        public const int UsageDynamic = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_NONSECURE")]
        public const int UsageNonsecure = unchecked((int) 0x800000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_AUTOGENMIPMAP")]
        public const int UsageAutogenmipmap = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_DMAP")]
        public const int UsageDmap = unchecked((int) 0x4000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_QUERY_LEGACYBUMPMAP")]
        public const int UsageQueryLegacybumpmap = unchecked((int) 0x8000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_QUERY_SRGBREAD")]
        public const int UsageQuerySrgbread = unchecked((int) 0x10000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_QUERY_FILTER")]
        public const int UsageQueryFilter = unchecked((int) 0x20000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_QUERY_SRGBWRITE")]
        public const int UsageQuerySrgbwrite = unchecked((int) 0x40000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_QUERY_POSTPIXELSHADER_BLENDING")]
        public const int UsageQueryPostpixelshaderBlending = unchecked((int) 0x80000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_QUERY_VERTEXTEXTURE")]
        public const int UsageQueryVertextexture = unchecked((int) 0x100000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_QUERY_WRAPANDMIP")]
        public const int UsageQueryWrapandmip = unchecked((int) 0x200000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_WRITEONLY")]
        public const int UsageWriteonly = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_SOFTWAREPROCESSING")]
        public const int UsageSoftwareprocessing = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_DONOTCLIP")]
        public const int UsageDonotclip = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_POINTS")]
        public const int UsagePoints = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_RTPATCHES")]
        public const int UsageRtpatches = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_NPATCHES")]
        public const int UsageNpatches = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_TEXTAPI")]
        public const int UsageTextapi = unchecked((int) 0x10000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_RESTRICTED_CONTENT")]
        public const int UsageRestrictedContent = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_RESTRICT_SHARED_RESOURCE")]
        public const int UsageRestrictSharedResource = unchecked((int) 0x2000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DUSAGE_RESTRICT_SHARED_RESOURCE_DRIVER")]
        public const int UsageRestrictSharedResourceDriver = unchecked((int) 0x1000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DLOCK_READONLY")]
        public const int LockReadonly = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DLOCK_DISCARD")]
        public const int LockDiscard = unchecked((int) 0x2000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DLOCK_NOOVERWRITE")]
        public const int LockNooverwrite = unchecked((int) 0x1000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DLOCK_NOSYSLOCK")]
        public const int LockNosyslock = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DLOCK_DONOTWAIT")]
        public const int LockDonotwait = unchecked((int) 0x4000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DLOCK_NO_DIRTY_UPDATE")]
        public const int LockNoDirtyUpdate = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAX_DEVICE_IDENTIFIER_STRING")]
        public const int MaxDeviceIdentifierString = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCOMPOSERECTS_MAXNUMRECTS")]
        public const int ComposerectsMaxnumrects = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCONVOLUTIONMONO_MAXWIDTH")]
        public const int ConvolutionmonoMaxwidth = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCONVOLUTIONMONO_MAXHEIGHT")]
        public const int ConvolutionmonoMaxheight = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFMT_A1_SURFACE_MAXWIDTH")]
        public const int FmtA1SurfaceMaxwidth = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DFMT_A1_SURFACE_MAXHEIGHT")]
        public const int FmtA1SurfaceMaxheight = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D9_RESOURCE_PRIORITY_MINIMUM")]
        public const int D3D9ResourcePriorityMinimum = unchecked((int) 0x28000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D9_RESOURCE_PRIORITY_LOW")]
        public const int D3D9ResourcePriorityLow = unchecked((int) 0x50000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D9_RESOURCE_PRIORITY_NORMAL")]
        public const int D3D9ResourcePriorityNormal = unchecked((int) 0x78000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D9_RESOURCE_PRIORITY_HIGH")]
        public const uint D3D9ResourcePriorityHigh = unchecked((uint) 0xFFFFFFFFA0000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D9_RESOURCE_PRIORITY_MAXIMUM")]
        public const uint D3D9ResourcePriorityMaximum = unchecked((uint) 0xFFFFFFFFC8000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_OMAC_SIZE")]
        public const int OmacSize = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DVS20_MAX_DYNAMICFLOWCONTROLDEPTH")]
        public const int VS20MaxDynamicflowcontroldepth = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DVS20_MIN_DYNAMICFLOWCONTROLDEPTH")]
        public const int VS20MinDynamicflowcontroldepth = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DVS20_MAX_NUMTEMPS")]
        public const int VS20MaxNumtemps = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DVS20_MIN_NUMTEMPS")]
        public const int VS20MinNumtemps = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DVS20_MAX_STATICFLOWCONTROLDEPTH")]
        public const int VS20MaxStaticflowcontroldepth = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DVS20_MIN_STATICFLOWCONTROLDEPTH")]
        public const int VS20MinStaticflowcontroldepth = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPS20_MAX_DYNAMICFLOWCONTROLDEPTH")]
        public const int PS20MaxDynamicflowcontroldepth = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPS20_MIN_DYNAMICFLOWCONTROLDEPTH")]
        public const int PS20MinDynamicflowcontroldepth = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPS20_MAX_NUMTEMPS")]
        public const int PS20MaxNumtemps = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPS20_MIN_NUMTEMPS")]
        public const int PS20MinNumtemps = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPS20_MAX_STATICFLOWCONTROLDEPTH")]
        public const int PS20MaxStaticflowcontroldepth = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPS20_MIN_STATICFLOWCONTROLDEPTH")]
        public const int PS20MinStaticflowcontroldepth = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPS20_MAX_NUMINSTRUCTIONSLOTS")]
        public const int PS20MaxNuminstructionslots = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DPS20_MIN_NUMINSTRUCTIONSLOTS")]
        public const int PS20MinNuminstructionslots = unchecked((int) 0x60);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DMIN30SHADERINSTRUCTIONS")]
        public const int Min30Shaderinstructions = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DMAX30SHADERINSTRUCTIONS")]
        public const int Max30Shaderinstructions = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DOVERLAYCAPS_FULLRANGERGB")]
        public const int OverlaycapsFullrangergb = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DOVERLAYCAPS_LIMITEDRANGERGB")]
        public const int OverlaycapsLimitedrangergb = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DOVERLAYCAPS_YCbCr_BT601")]
        public const int OverlaycapsYCbCrBT601 = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DOVERLAYCAPS_YCbCr_BT709")]
        public const int OverlaycapsYCbCrBT709 = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DOVERLAYCAPS_YCbCr_BT601_xvYCC")]
        public const int OverlaycapsYCbCrBT601XvYcc = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DOVERLAYCAPS_YCbCr_BT709_xvYCC")]
        public const int OverlaycapsYCbCrBT709XvYcc = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DOVERLAYCAPS_STRETCHX")]
        public const int OverlaycapsStretchx = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DOVERLAYCAPS_STRETCHY")]
        public const int OverlaycapsStretchy = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCPCAPS_SOFTWARE")]
        public const int CpcapsSoftware = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCPCAPS_HARDWARE")]
        public const int CpcapsHardware = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCPCAPS_PROTECTIONALWAYSON")]
        public const int CpcapsProtectionalwayson = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCPCAPS_PARTIALDECRYPTION")]
        public const int CpcapsPartialdecryption = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCPCAPS_CONTENTKEY")]
        public const int CpcapsContentkey = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCPCAPS_FRESHENSESSIONKEY")]
        public const int CpcapsFreshensessionkey = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCPCAPS_ENCRYPTEDREADBACK")]
        public const int CpcapsEncryptedreadback = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCPCAPS_ENCRYPTEDREADBACKKEY")]
        public const int CpcapsEncryptedreadbackkey = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCPCAPS_SEQUENTIAL_CTR_IV")]
        public const int CpcapsSequentialCtrIV = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCPCAPS_ENCRYPTSLICEDATAONLY")]
        public const int CpcapsEncryptslicedataonly = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS_OVERLAY")]
        public const int CapsOverlay = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS_READ_SCANLINE")]
        public const int CapsReadScanline = unchecked((int) 0x20000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS2_FULLSCREENGAMMA")]
        public const int Caps2Fullscreengamma = unchecked((int) 0x20000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS2_CANCALIBRATEGAMMA")]
        public const int Caps2Cancalibrategamma = unchecked((int) 0x100000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS2_RESERVED")]
        public const int Caps2Reserved = unchecked((int) 0x2000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS2_CANMANAGERESOURCE")]
        public const int Caps2Canmanageresource = unchecked((int) 0x10000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS2_DYNAMICTEXTURES")]
        public const int Caps2Dynamictextures = unchecked((int) 0x20000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS2_CANAUTOGENMIPMAP")]
        public const int Caps2Canautogenmipmap = unchecked((int) 0x40000000);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "D3DCAPS2_CANSHARERESOURCE")]
        public const uint Caps2Canshareresource = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "D3DCAPS3_RESERVED")]
        public const uint Caps3Reserved = unchecked((uint) 0xFFFFFFFF8000001F);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS3_ALPHA_FULLSCREEN_FLIP_OR_DISCARD")]
        public const int Caps3AlphaFullscreenFlipOrDiscard = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS3_LINEAR_TO_SRGB_PRESENTATION")]
        public const int Caps3LinearToSrgbPresentation = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS3_COPY_TO_VIDMEM")]
        public const int Caps3CopyToVidmem = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS3_COPY_TO_SYSTEMMEM")]
        public const int Caps3CopyToSystemmem = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS3_DXVAHD")]
        public const int Caps3Dxvahd = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCAPS3_DXVAHD_LIMITED")]
        public const int Caps3DxvahdLimited = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_INTERVAL_DEFAULT")]
        public const int PresentIntervalDefault = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_INTERVAL_ONE")]
        public const int PresentIntervalOne = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_INTERVAL_TWO")]
        public const int PresentIntervalTwo = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_INTERVAL_THREE")]
        public const int PresentIntervalThree = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_INTERVAL_FOUR")]
        public const int PresentIntervalFour = unchecked((int) 0x8);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "D3DPRESENT_INTERVAL_IMMEDIATE")]
        public const uint PresentIntervalImmediate = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCURSORCAPS_COLOR")]
        public const int CursorcapsColor = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCURSORCAPS_LOWRES")]
        public const int CursorcapsLowres = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_EXECUTESYSTEMMEMORY")]
        public const int DevcapsExecutesystemmemory = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_EXECUTEVIDEOMEMORY")]
        public const int DevcapsExecutevideomemory = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_TLVERTEXSYSTEMMEMORY")]
        public const int DevcapsTlvertexsystemmemory = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_TLVERTEXVIDEOMEMORY")]
        public const int DevcapsTlvertexvideomemory = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_TEXTURESYSTEMMEMORY")]
        public const int DevcapsTexturesystemmemory = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_TEXTUREVIDEOMEMORY")]
        public const int DevcapsTexturevideomemory = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_DRAWPRIMTLVERTEX")]
        public const int DevcapsDrawprimtlvertex = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_CANRENDERAFTERFLIP")]
        public const int DevcapsCanrenderafterflip = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_TEXTURENONLOCALVIDMEM")]
        public const int DevcapsTexturenonlocalvidmem = unchecked((int) 0x1000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_DRAWPRIMITIVES2")]
        public const int DevcapsDrawprimitives2 = unchecked((int) 0x2000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_SEPARATETEXTUREMEMORIES")]
        public const int DevcapsSeparatetexturememories = unchecked((int) 0x4000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_DRAWPRIMITIVES2EX")]
        public const int DevcapsDrawprimitives2EX = unchecked((int) 0x8000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_HWTRANSFORMANDLIGHT")]
        public const int DevcapsHwtransformandlight = unchecked((int) 0x10000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_CANBLTSYSTONONLOCAL")]
        public const int DevcapsCanbltsystononlocal = unchecked((int) 0x20000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_HWRASTERIZATION")]
        public const int DevcapsHwrasterization = unchecked((int) 0x80000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_PUREDEVICE")]
        public const int DevcapsPuredevice = unchecked((int) 0x100000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_QUINTICRTPATCHES")]
        public const int DevcapsQuinticrtpatches = unchecked((int) 0x200000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_RTPATCHES")]
        public const int DevcapsRtpatches = unchecked((int) 0x400000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_RTPATCHHANDLEZERO")]
        public const int DevcapsRtpatchhandlezero = unchecked((int) 0x800000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS_NPATCHES")]
        public const int DevcapsNpatches = unchecked((int) 0x1000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_MASKZ")]
        public const int PmisccapsMaskz = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_CULLNONE")]
        public const int PmisccapsCullnone = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_CULLCW")]
        public const int PmisccapsCullcw = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_CULLCCW")]
        public const int PmisccapsCullccw = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_COLORWRITEENABLE")]
        public const int PmisccapsColorwriteenable = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_CLIPPLANESCALEDPOINTS")]
        public const int PmisccapsClipplanescaledpoints = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_CLIPTLVERTS")]
        public const int PmisccapsCliptlverts = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_TSSARGTEMP")]
        public const int PmisccapsTssargtemp = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_BLENDOP")]
        public const int PmisccapsBlendop = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_NULLREFERENCE")]
        public const int PmisccapsNullreference = unchecked((int) 0x1000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_INDEPENDENTWRITEMASKS")]
        public const int PmisccapsIndependentwritemasks = unchecked((int) 0x4000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_PERSTAGECONSTANT")]
        public const int PmisccapsPerstageconstant = unchecked((int) 0x8000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_FOGANDSPECULARALPHA")]
        public const int PmisccapsFogandspecularalpha = unchecked((int) 0x10000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_SEPARATEALPHABLEND")]
        public const int PmisccapsSeparatealphablend = unchecked((int) 0x20000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_MRTINDEPENDENTBITDEPTHS")]
        public const int PmisccapsMrtindependentbitdepths = unchecked((int) 0x40000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_MRTPOSTPIXELSHADERBLENDING")]
        public const int PmisccapsMrtpostpixelshaderblending = unchecked((int) 0x80000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_FOGVERTEXCLAMPED")]
        public const int PmisccapsFogvertexclamped = unchecked((int) 0x100000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPMISCCAPS_POSTBLENDSRGBCONVERT")]
        public const int PmisccapsPostblendsrgbconvert = unchecked((int) 0x200000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DLINECAPS_TEXTURE")]
        public const int LinecapsTexture = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DLINECAPS_ZTEST")]
        public const int LinecapsZtest = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DLINECAPS_BLEND")]
        public const int LinecapsBlend = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DLINECAPS_ALPHACMP")]
        public const int LinecapsAlphacmp = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DLINECAPS_FOG")]
        public const int LinecapsFog = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DLINECAPS_ANTIALIAS")]
        public const int LinecapsAntialias = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_DITHER")]
        public const int PrastercapsDither = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_ZTEST")]
        public const int PrastercapsZtest = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_FOGVERTEX")]
        public const int PrastercapsFogvertex = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_FOGTABLE")]
        public const int PrastercapsFogtable = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_MIPMAPLODBIAS")]
        public const int PrastercapsMipmaplodbias = unchecked((int) 0x2000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_ZBUFFERLESSHSR")]
        public const int PrastercapsZbufferlesshsr = unchecked((int) 0x8000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_FOGRANGE")]
        public const int PrastercapsFogrange = unchecked((int) 0x10000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_ANISOTROPY")]
        public const int PrastercapsAnisotropy = unchecked((int) 0x20000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_WBUFFER")]
        public const int PrastercapsWbuffer = unchecked((int) 0x40000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_WFOG")]
        public const int PrastercapsWfog = unchecked((int) 0x100000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_ZFOG")]
        public const int PrastercapsZfog = unchecked((int) 0x200000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_COLORPERSPECTIVE")]
        public const int PrastercapsColorperspective = unchecked((int) 0x400000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_SCISSORTEST")]
        public const int PrastercapsScissortest = unchecked((int) 0x1000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_SLOPESCALEDEPTHBIAS")]
        public const int PrastercapsSlopescaledepthbias = unchecked((int) 0x2000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_DEPTHBIAS")]
        public const int PrastercapsDepthbias = unchecked((int) 0x4000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRASTERCAPS_MULTISAMPLE_TOGGLE")]
        public const int PrastercapsMultisampleToggle = unchecked((int) 0x8000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPCMPCAPS_NEVER")]
        public const int PcmpcapsNever = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPCMPCAPS_LESS")]
        public const int PcmpcapsLess = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPCMPCAPS_EQUAL")]
        public const int PcmpcapsEqual = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPCMPCAPS_LESSEQUAL")]
        public const int PcmpcapsLessequal = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPCMPCAPS_GREATER")]
        public const int PcmpcapsGreater = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPCMPCAPS_NOTEQUAL")]
        public const int PcmpcapsNotequal = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPCMPCAPS_GREATEREQUAL")]
        public const int PcmpcapsGreaterequal = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPCMPCAPS_ALWAYS")]
        public const int PcmpcapsAlways = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_ZERO")]
        public const int PblendcapsZero = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_ONE")]
        public const int PblendcapsOne = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_SRCCOLOR")]
        public const int PblendcapsSrccolor = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_INVSRCCOLOR")]
        public const int PblendcapsInvsrccolor = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_SRCALPHA")]
        public const int PblendcapsSrcalpha = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_INVSRCALPHA")]
        public const int PblendcapsInvsrcalpha = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_DESTALPHA")]
        public const int PblendcapsDestalpha = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_INVDESTALPHA")]
        public const int PblendcapsInvdestalpha = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_DESTCOLOR")]
        public const int PblendcapsDestcolor = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_INVDESTCOLOR")]
        public const int PblendcapsInvdestcolor = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_SRCALPHASAT")]
        public const int PblendcapsSrcalphasat = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_BOTHSRCALPHA")]
        public const int PblendcapsBothsrcalpha = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_BOTHINVSRCALPHA")]
        public const int PblendcapsBothinvsrcalpha = unchecked((int) 0x1000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_BLENDFACTOR")]
        public const int PblendcapsBlendfactor = unchecked((int) 0x2000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_SRCCOLOR2")]
        public const int PblendcapsSrccolor2 = unchecked((int) 0x4000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPBLENDCAPS_INVSRCCOLOR2")]
        public const int PblendcapsInvsrccolor2 = unchecked((int) 0x8000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPSHADECAPS_COLORGOURAUDRGB")]
        public const int PshadecapsColorgouraudrgb = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPSHADECAPS_SPECULARGOURAUDRGB")]
        public const int PshadecapsSpeculargouraudrgb = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPSHADECAPS_ALPHAGOURAUDBLEND")]
        public const int PshadecapsAlphagouraudblend = unchecked((int) 0x4000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPSHADECAPS_FOGGOURAUD")]
        public const int PshadecapsFoggouraud = unchecked((int) 0x80000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_PERSPECTIVE")]
        public const int PtexturecapsPerspective = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_POW2")]
        public const int PtexturecapsPow2 = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_ALPHA")]
        public const int PtexturecapsAlpha = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_SQUAREONLY")]
        public const int PtexturecapsSquareonly = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_TEXREPEATNOTSCALEDBYSIZE")]
        public const int PtexturecapsTexrepeatnotscaledbysize = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_ALPHAPALETTE")]
        public const int PtexturecapsAlphapalette = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_NONPOW2CONDITIONAL")]
        public const int PtexturecapsNonpow2Conditional = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_PROJECTED")]
        public const int PtexturecapsProjected = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_CUBEMAP")]
        public const int PtexturecapsCubemap = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_VOLUMEMAP")]
        public const int PtexturecapsVolumemap = unchecked((int) 0x2000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_MIPMAP")]
        public const int PtexturecapsMipmap = unchecked((int) 0x4000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_MIPVOLUMEMAP")]
        public const int PtexturecapsMipvolumemap = unchecked((int) 0x8000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_MIPCUBEMAP")]
        public const int PtexturecapsMipcubemap = unchecked((int) 0x10000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_CUBEMAP_POW2")]
        public const int PtexturecapsCubemapPow2 = unchecked((int) 0x20000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_VOLUMEMAP_POW2")]
        public const int PtexturecapsVolumemapPow2 = unchecked((int) 0x40000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTEXTURECAPS_NOPROJECTEDBUMPENV")]
        public const int PtexturecapsNoprojectedbumpenv = unchecked((int) 0x200000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTFILTERCAPS_MINFPOINT")]
        public const int PtfiltercapsMinfpoint = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTFILTERCAPS_MINFLINEAR")]
        public const int PtfiltercapsMinflinear = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTFILTERCAPS_MINFANISOTROPIC")]
        public const int PtfiltercapsMinfanisotropic = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTFILTERCAPS_MINFPYRAMIDALQUAD")]
        public const int PtfiltercapsMinfpyramidalquad = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTFILTERCAPS_MINFGAUSSIANQUAD")]
        public const int PtfiltercapsMinfgaussianquad = unchecked((int) 0x1000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTFILTERCAPS_MIPFPOINT")]
        public const int PtfiltercapsMipfpoint = unchecked((int) 0x10000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTFILTERCAPS_MIPFLINEAR")]
        public const int PtfiltercapsMipflinear = unchecked((int) 0x20000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTFILTERCAPS_CONVOLUTIONMONO")]
        public const int PtfiltercapsConvolutionmono = unchecked((int) 0x40000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTFILTERCAPS_MAGFPOINT")]
        public const int PtfiltercapsMagfpoint = unchecked((int) 0x1000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTFILTERCAPS_MAGFLINEAR")]
        public const int PtfiltercapsMagflinear = unchecked((int) 0x2000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTFILTERCAPS_MAGFANISOTROPIC")]
        public const int PtfiltercapsMagfanisotropic = unchecked((int) 0x4000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTFILTERCAPS_MAGFPYRAMIDALQUAD")]
        public const int PtfiltercapsMagfpyramidalquad = unchecked((int) 0x8000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTFILTERCAPS_MAGFGAUSSIANQUAD")]
        public const int PtfiltercapsMagfgaussianquad = unchecked((int) 0x10000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTADDRESSCAPS_WRAP")]
        public const int PtaddresscapsWrap = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTADDRESSCAPS_MIRROR")]
        public const int PtaddresscapsMirror = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTADDRESSCAPS_CLAMP")]
        public const int PtaddresscapsClamp = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTADDRESSCAPS_BORDER")]
        public const int PtaddresscapsBorder = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTADDRESSCAPS_INDEPENDENTUV")]
        public const int PtaddresscapsIndependentuv = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPTADDRESSCAPS_MIRRORONCE")]
        public const int PtaddresscapsMirroronce = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DSTENCILCAPS_KEEP")]
        public const int StencilcapsKeep = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DSTENCILCAPS_ZERO")]
        public const int StencilcapsZero = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DSTENCILCAPS_REPLACE")]
        public const int StencilcapsReplace = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DSTENCILCAPS_INCRSAT")]
        public const int StencilcapsIncrsat = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DSTENCILCAPS_DECRSAT")]
        public const int StencilcapsDecrsat = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DSTENCILCAPS_INVERT")]
        public const int StencilcapsInvert = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DSTENCILCAPS_INCR")]
        public const int StencilcapsIncr = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DSTENCILCAPS_DECR")]
        public const int StencilcapsDecr = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DSTENCILCAPS_TWOSIDED")]
        public const int StencilcapsTwosided = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_DISABLE")]
        public const int TexopcapsDisable = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_SELECTARG1")]
        public const int TexopcapsSelectarg1 = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_SELECTARG2")]
        public const int TexopcapsSelectarg2 = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_MODULATE")]
        public const int TexopcapsModulate = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_MODULATE2X")]
        public const int TexopcapsModulate2X = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_MODULATE4X")]
        public const int TexopcapsModulate4X = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_ADD")]
        public const int TexopcapsAdd = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_ADDSIGNED")]
        public const int TexopcapsAddsigned = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_ADDSIGNED2X")]
        public const int TexopcapsAddsigned2X = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_SUBTRACT")]
        public const int TexopcapsSubtract = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_ADDSMOOTH")]
        public const int TexopcapsAddsmooth = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_BLENDDIFFUSEALPHA")]
        public const int TexopcapsBlenddiffusealpha = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_BLENDTEXTUREALPHA")]
        public const int TexopcapsBlendtexturealpha = unchecked((int) 0x1000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_BLENDFACTORALPHA")]
        public const int TexopcapsBlendfactoralpha = unchecked((int) 0x2000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_BLENDTEXTUREALPHAPM")]
        public const int TexopcapsBlendtexturealphapm = unchecked((int) 0x4000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_BLENDCURRENTALPHA")]
        public const int TexopcapsBlendcurrentalpha = unchecked((int) 0x8000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_PREMODULATE")]
        public const int TexopcapsPremodulate = unchecked((int) 0x10000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_MODULATEALPHA_ADDCOLOR")]
        public const int TexopcapsModulatealphaAddcolor = unchecked((int) 0x20000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_MODULATECOLOR_ADDALPHA")]
        public const int TexopcapsModulatecolorAddalpha = unchecked((int) 0x40000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_MODULATEINVALPHA_ADDCOLOR")]
        public const int TexopcapsModulateinvalphaAddcolor = unchecked((int) 0x80000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_MODULATEINVCOLOR_ADDALPHA")]
        public const int TexopcapsModulateinvcolorAddalpha = unchecked((int) 0x100000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_BUMPENVMAP")]
        public const int TexopcapsBumpenvmap = unchecked((int) 0x200000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_BUMPENVMAPLUMINANCE")]
        public const int TexopcapsBumpenvmapluminance = unchecked((int) 0x400000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_DOTPRODUCT3")]
        public const int TexopcapsDotproduct3 = unchecked((int) 0x800000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_MULTIPLYADD")]
        public const int TexopcapsMultiplyadd = unchecked((int) 0x1000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DTEXOPCAPS_LERP")]
        public const int TexopcapsLerp = unchecked((int) 0x2000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DFVFCAPS_TEXCOORDCOUNTMASK")]
        public const int FvfcapsTexcoordcountmask = unchecked((int) 0xFFFF);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DFVFCAPS_DONOTSTRIPELEMENTS")]
        public const int FvfcapsDonotstripelements = unchecked((int) 0x80000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DFVFCAPS_PSIZE")]
        public const int FvfcapsPsize = unchecked((int) 0x100000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DVTXPCAPS_TEXGEN")]
        public const int VtxpcapsTexgen = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DVTXPCAPS_MATERIALSOURCE7")]
        public const int VtxpcapsMaterialsource7 = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DVTXPCAPS_DIRECTIONALLIGHTS")]
        public const int VtxpcapsDirectionallights = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DVTXPCAPS_POSITIONALLIGHTS")]
        public const int VtxpcapsPositionallights = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DVTXPCAPS_LOCALVIEWER")]
        public const int VtxpcapsLocalviewer = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DVTXPCAPS_TWEENING")]
        public const int VtxpcapsTweening = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DVTXPCAPS_TEXGEN_SPHEREMAP")]
        public const int VtxpcapsTexgenSpheremap = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DVTXPCAPS_NO_TEXGEN_NONLOCALVIEWER")]
        public const int VtxpcapsNoTexgenNonlocalviewer = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS2_STREAMOFFSET")]
        public const int Devcaps2Streamoffset = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS2_DMAPNPATCH")]
        public const int Devcaps2Dmapnpatch = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS2_ADAPTIVETESSRTPATCH")]
        public const int Devcaps2Adaptivetessrtpatch = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS2_ADAPTIVETESSNPATCH")]
        public const int Devcaps2Adaptivetessnpatch = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS2_CAN_STRETCHRECT_FROM_TEXTURES")]
        public const int Devcaps2CanStretchrectFromTextures = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS2_PRESAMPLEDDMAPNPATCH")]
        public const int Devcaps2Presampleddmapnpatch = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDEVCAPS2_VERTEXELEMENTSCANSHARESTREAMOFFSET")]
        public const int Devcaps2Vertexelementscansharestreamoffset = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDTCAPS_UBYTE4")]
        public const int DtcapsUbyte4 = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDTCAPS_UBYTE4N")]
        public const int DtcapsUbyte4N = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDTCAPS_SHORT2N")]
        public const int DtcapsShort2N = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDTCAPS_SHORT4N")]
        public const int DtcapsShort4N = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDTCAPS_USHORT2N")]
        public const int DtcapsUshort2N = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDTCAPS_USHORT4N")]
        public const int DtcapsUshort4N = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDTCAPS_UDEC3")]
        public const int DtcapsUdec3 = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDTCAPS_DEC3N")]
        public const int DtcapsDec3N = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDTCAPS_FLOAT16_2")]
        public const int DtcapsFloat162 = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DDTCAPS_FLOAT16_4")]
        public const int DtcapsFloat164 = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DSPD_IUNKNOWN")]
        public const int SpdIunknown = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_FPU_PRESERVE")]
        public const int CreateFpuPreserve = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_MULTITHREADED")]
        public const int CreateMultithreaded = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_PUREDEVICE")]
        public const int CreatePuredevice = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_SOFTWARE_VERTEXPROCESSING")]
        public const int CreateSoftwareVertexprocessing = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_HARDWARE_VERTEXPROCESSING")]
        public const int CreateHardwareVertexprocessing = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_MIXED_VERTEXPROCESSING")]
        public const int CreateMixedVertexprocessing = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_DISABLE_DRIVER_MANAGEMENT")]
        public const int CreateDisableDriverManagement = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_ADAPTERGROUP_DEVICE")]
        public const int CreateAdaptergroupDevice = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_DISABLE_DRIVER_MANAGEMENT_EX")]
        public const int CreateDisableDriverManagementEX = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_NOWINDOWCHANGES")]
        public const int CreateNowindowchanges = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_DISABLE_PSGP_THREADING")]
        public const int CreateDisablePsgpThreading = unchecked((int) 0x2000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_ENABLE_PRESENTSTATS")]
        public const int CreateEnablePresentstats = unchecked((int) 0x4000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_DISABLE_PRINTSCREEN")]
        public const int CreateDisablePrintscreen = unchecked((int) 0x8000);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCREATE_SCREENSAVER")]
        public const int CreateScreensaver = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DADAPTER_DEFAULT")]
        public const int AdapterDefault = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DENUM_WHQL_LEVEL")]
        public const int EnumWhqlLevel = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DENUM_NO_DRIVERVERSION")]
        public const int EnumNoDriverversion = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_BACK_BUFFERS_MAX")]
        public const int PresentBackBuffersMax = unchecked((int) 0x3);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_BACK_BUFFERS_MAX_EX")]
        public const int PresentBackBuffersMaxEX = unchecked((int) 0x1E);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DSGR_NO_CALIBRATION")]
        public const int SgrNoCalibration = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DSGR_CALIBRATE")]
        public const int SgrCalibrate = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DCURSOR_IMMEDIATE_UPDATE")]
        public const int CursorImmediateUpdate = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_DONOTWAIT")]
        public const int PresentDonotwait = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_LINEAR_CONTENT")]
        public const int PresentLinearContent = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_DONOTFLIP")]
        public const int PresentDonotflip = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_FLIPRESTART")]
        public const int PresentFliprestart = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_VIDEO_RESTRICT_TO_MONITOR")]
        public const int PresentVideoRestrictToMonitor = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_UPDATEOVERLAYONLY")]
        public const int PresentUpdateoverlayonly = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_HIDEOVERLAY")]
        public const int PresentHideoverlay = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_UPDATECOLORKEY")]
        public const int PresentUpdatecolorkey = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "D3DPRESENT_FORCEIMMEDIATE")]
        public const int PresentForceimmediate = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "_FACD3D")]
        public const int Facd3D = unchecked((int) 0x876);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 309, Column 21 in d3d9.h")]
        [NativeApi(EntryPoint = "Direct3DCreate9")]
        public unsafe partial IDirect3D9* Direct3DCreate9(uint SDKVersion);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 12 in d3d9.h")]
        [NativeApi(EntryPoint = "D3DPERF_BeginEvent")]
        public unsafe partial int PERFBeginEvent(uint col, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wszName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 12 in d3d9.h")]
        [NativeApi(EntryPoint = "D3DPERF_BeginEvent")]
        public partial int PERFBeginEvent(uint col, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wszName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 12 in d3d9.h")]
        [NativeApi(EntryPoint = "D3DPERF_BeginEvent")]
        public partial int PERFBeginEvent(uint col, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wszName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 12 in d3d9.h")]
        [NativeApi(EntryPoint = "D3DPERF_EndEvent")]
        public partial int PERFEndEvent();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 13 in d3d9.h")]
        [NativeApi(EntryPoint = "D3DPERF_SetMarker")]
        public unsafe partial void PERFSetMarker(uint col, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wszName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 13 in d3d9.h")]
        [NativeApi(EntryPoint = "D3DPERF_SetMarker")]
        public partial void PERFSetMarker(uint col, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wszName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 13 in d3d9.h")]
        [NativeApi(EntryPoint = "D3DPERF_SetMarker")]
        public partial void PERFSetMarker(uint col, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wszName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 13 in d3d9.h")]
        [NativeApi(EntryPoint = "D3DPERF_SetRegion")]
        public unsafe partial void PERFSetRegion(uint col, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wszName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 13 in d3d9.h")]
        [NativeApi(EntryPoint = "D3DPERF_SetRegion")]
        public partial void PERFSetRegion(uint col, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wszName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 13 in d3d9.h")]
        [NativeApi(EntryPoint = "D3DPERF_SetRegion")]
        public partial void PERFSetRegion(uint col, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wszName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 319, Column 13 in d3d9.h")]
        [NativeApi(EntryPoint = "D3DPERF_QueryRepeatFrame")]
        public partial Silk.NET.Core.Bool32 PERFQueryRepeatFrame();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 321, Column 13 in d3d9.h")]
        [NativeApi(EntryPoint = "D3DPERF_SetOptions")]
        public partial void PERFSetOptions(uint dwOptions);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 322, Column 14 in d3d9.h")]
        [NativeApi(EntryPoint = "D3DPERF_GetStatus")]
        public partial uint PERFGetStatus();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2030, Column 16 in d3d9.h")]
        [NativeApi(EntryPoint = "Direct3DCreate9Ex")]
        public unsafe partial int Direct3DCreate9Ex(uint SDKVersion, IDirect3D9Ex** arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2030, Column 16 in d3d9.h")]
        [NativeApi(EntryPoint = "Direct3DCreate9Ex")]
        public unsafe partial int Direct3DCreate9Ex(uint SDKVersion, ref IDirect3D9Ex* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2030, Column 16 in d3d9.h")]
        public unsafe int Direct3DCreate9Ex<TI0>(uint SDKVersion, ref ComPtr<TI0> arg1) where TI0 : unmanaged, IComVtbl<IDirect3D9Ex>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return Direct3DCreate9Ex(SDKVersion, (IDirect3D9Ex**) arg1.GetAddressOf());
        }


        public D3D9(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

