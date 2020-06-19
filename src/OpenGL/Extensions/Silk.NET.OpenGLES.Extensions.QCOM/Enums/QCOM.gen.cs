// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    public enum QCOM
    {
        AlphaTestQCom = 0xBC0,
        AlphaTestFuncQCom = 0xBC1,
        AlphaTestRefQCom = 0xBC2,
        BinningControlHintQCom = 0x8FB0,
        CpuOptimizedQCom = 0x8FB1,
        GpuOptimizedQCom = 0x8FB2,
        RenderDirectToFramebufferQCom = 0x8FB3,
        TextureWidthQCom = 0x8BD2,
        TextureHeightQCom = 0x8BD3,
        TextureDepthQCom = 0x8BD4,
        TextureInternalFormatQCom = 0x8BD5,
        TextureFormatQCom = 0x8BD6,
        TextureTypeQCom = 0x8BD7,
        TextureImageValidQCom = 0x8BD8,
        TextureNumLevelsQCom = 0x8BD9,
        TextureTargetQCom = 0x8BDA,
        TextureObjectValidQCom = 0x8BDB,
        StateRestore = 0x8BDC,
        FoveationEnableBitQCom = 0x1,
        FoveationScaledBinMethodBitQCom = 0x2,
        PerfmonGlobalModeQCom = 0x8FA0,
        FramebufferFetchNoncoherentQCom = 0x96A2,
        TextureFoveatedFeatureBitsQCom = 0x8BFB,
        TextureFoveatedMinPixelDensityQCom = 0x8BFC,
        TextureFoveatedFeatureQueryQCom = 0x8BFD,
        TextureFoveatedNumFocalPointsQueryQCom = 0x8BFE,
        FramebufferIncompleteFoveationQCom = 0x8BFF,
        FoveationSubsampledLayoutMethodBitQCom = 0x4,
        MaxShaderSubsampledImageUnitsQCom = 0x8FA1,
        ColorBufferBit0QCom = 0x1,
        ColorBufferBit1QCom = 0x2,
        ColorBufferBit2QCom = 0x4,
        ColorBufferBit3QCom = 0x8,
        ColorBufferBit4QCom = 0x10,
        ColorBufferBit5QCom = 0x20,
        ColorBufferBit6QCom = 0x40,
        ColorBufferBit7QCom = 0x80,
        DepthBufferBit0QCom = 0x100,
        DepthBufferBit1QCom = 0x200,
        DepthBufferBit2QCom = 0x400,
        DepthBufferBit3QCom = 0x800,
        DepthBufferBit4QCom = 0x1000,
        DepthBufferBit5QCom = 0x2000,
        DepthBufferBit6QCom = 0x4000,
        DepthBufferBit7QCom = 0x8000,
        StencilBufferBit0QCom = 0x10000,
        StencilBufferBit1QCom = 0x20000,
        StencilBufferBit2QCom = 0x40000,
        StencilBufferBit3QCom = 0x80000,
        StencilBufferBit4QCom = 0x100000,
        StencilBufferBit5QCom = 0x200000,
        StencilBufferBit6QCom = 0x400000,
        StencilBufferBit7QCom = 0x800000,
        MultisampleBufferBit0QCom = 0x1000000,
        MultisampleBufferBit1QCom = 0x2000000,
        MultisampleBufferBit2QCom = 0x4000000,
        MultisampleBufferBit3QCom = 0x8000000,
        MultisampleBufferBit4QCom = 0x10000000,
        MultisampleBufferBit5QCom = 0x20000000,
        MultisampleBufferBit6QCom = 0x40000000,
        MultisampleBufferBit7QCom = unchecked((int)0x80000000),
        WriteonlyRenderingQCom = 0x8823,
    }
}
