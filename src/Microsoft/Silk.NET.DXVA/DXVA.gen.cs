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

namespace Silk.NET.DXVA
{
    public unsafe partial class DXVA : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_QUERYORREPLYFUNCFLAG_DECODER_PROBE_QUERY")]
        public const int QueryorreplyfuncflagDecoderProbeQuery = unchecked((int) 0xFFFFF1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_QUERYORREPLYFUNCFLAG_DECODER_LOCK_QUERY")]
        public const int QueryorreplyfuncflagDecoderLockQuery = unchecked((int) 0xFFFFF5);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_QUERYORREPLYFUNCFLAG_ACCEL_PROBE_OK_COPY")]
        public const int QueryorreplyfuncflagAccelProbeOKCopy = unchecked((int) 0xFFFFF8);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_QUERYORREPLYFUNCFLAG_ACCEL_PROBE_OK_PLUS")]
        public const int QueryorreplyfuncflagAccelProbeOKPlus = unchecked((int) 0xFFFFF9);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_QUERYORREPLYFUNCFLAG_ACCEL_LOCK_OK_COPY")]
        public const int QueryorreplyfuncflagAccelLockOKCopy = unchecked((int) 0xFFFFFC);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_QUERYORREPLYFUNCFLAG_ACCEL_PROBE_FALSE_PLUS")]
        public const int QueryorreplyfuncflagAccelProbeFalsePlus = unchecked((int) 0xFFFFFB);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_QUERYORREPLYFUNCFLAG_ACCEL_LOCK_FALSE_PLUS")]
        public const int QueryorreplyfuncflagAccelLockFalsePlus = unchecked((int) 0xFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_PICTURE_DECODE_BUFFER")]
        public const int PictureDecodeBuffer = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_MACROBLOCK_CONTROL_BUFFER")]
        public const int MacroblockControlBuffer = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_RESIDUAL_DIFFERENCE_BUFFER")]
        public const int ResidualDifferenceBuffer = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_DEBLOCKING_CONTROL_BUFFER")]
        public const int DeblockingControlBuffer = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_INVERSE_QUANTIZATION_MATRIX_BUFFER")]
        public const int InverseQuantizationMatrixBuffer = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_SLICE_CONTROL_BUFFER")]
        public const int SliceControlBuffer = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_BITSTREAM_DATA_BUFFER")]
        public const int BitstreamDataBuffer = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_AYUV_BUFFER")]
        public const int AyuvBuffer = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_IA44_SURFACE_BUFFER")]
        public const int IA44SurfaceBuffer = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_DPXD_SURFACE_BUFFER")]
        public const int DpxdSurfaceBuffer = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_HIGHLIGHT_BUFFER")]
        public const int HighlightBuffer = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_DCCMD_SURFACE_BUFFER")]
        public const int DccmdSurfaceBuffer = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_ALPHA_BLEND_COMBINATION_BUFFER")]
        public const int AlphaBlendCombinationBuffer = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_PICTURE_RESAMPLE_BUFFER")]
        public const int PictureResampleBuffer = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_READ_BACK_BUFFER")]
        public const int ReadBackBuffer = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_ExtColorData_ShiftBase")]
        public const int ExtColorDataShiftBase = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAX_DEINTERLACE_SURFACES")]
        public const int MaxDeinterlaceSurfaces = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_DeinterlaceBltFnCode")]
        public const int DeinterlaceBltFnCode = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_DeinterlaceBltExFnCode")]
        public const int DeinterlaceBltExFnCode = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAX_DEINTERLACE_DEVICE_GUIDS")]
        public const int MaxDeinterlaceDeviceGuids = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_DeinterlaceQueryAvailableModesFnCode")]
        public const int DeinterlaceQueryAvailableModesFnCode = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_DeinterlaceQueryModeCapsFnCode")]
        public const int DeinterlaceQueryModeCapsFnCode = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_ProcAmpControlQueryCapsFnCode")]
        public const int ProcAmpControlQueryCapsFnCode = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_ProcAmpControlQueryRangeFnCode")]
        public const int ProcAmpControlQueryRangeFnCode = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_ProcAmpControlBltFnCode")]
        public const int ProcAmpControlBltFnCode = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_COPPGetCertificateLengthFnCode")]
        public const int CoppgetCertificateLengthFnCode = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_COPPKeyExchangeFnCode")]
        public const int CoppkeyExchangeFnCode = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_COPPSequenceStartFnCode")]
        public const int CoppsequenceStartFnCode = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_COPPCommandFnCode")]
        public const int CoppcommandFnCode = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "COPP_DefaultProtectionLevel")]
        public const int CoppDefaultProtectionLevel = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "COPP_ImageAspectRatio_EN300294_Mask")]
        public const int CoppImageAspectRatioEN300294Mask = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA_COPPQueryStatusFnCode")]
        public const int CoppqueryStatusFnCode = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAX_SUBSTREAMS")]
        public const int MaxSubstreams = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA2_DECODE_GET_DRIVER_HANDLE")]
        public const int DXVA2DecodeGetDriverHandle = unchecked((int) 0x725);
        [NativeName("Type", "int")]
        [NativeName("Name", "DXVA2_DECODE_SPECIFY_ENCRYPTED_BLOCKS")]
        public const int DXVA2DecodeSpecifyEncryptedBlocks = unchecked((int) 0x724);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        [NativeApi(EntryPoint = "DXVAHD_CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int HDCreateDevice(Silk.NET.Direct3D9.IDirect3DDevice9Ex* pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HDContentDesc* pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, IDXVAHDDevice** ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        [NativeApi(EntryPoint = "DXVAHD_CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int HDCreateDevice(Silk.NET.Direct3D9.IDirect3DDevice9Ex* pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HDContentDesc* pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, ref IDXVAHDDevice* ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        [NativeApi(EntryPoint = "DXVAHD_CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int HDCreateDevice(Silk.NET.Direct3D9.IDirect3DDevice9Ex* pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HDContentDesc pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, IDXVAHDDevice** ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        [NativeApi(EntryPoint = "DXVAHD_CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int HDCreateDevice(Silk.NET.Direct3D9.IDirect3DDevice9Ex* pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HDContentDesc pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, ref IDXVAHDDevice* ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        [NativeApi(EntryPoint = "DXVAHD_CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int HDCreateDevice(ref Silk.NET.Direct3D9.IDirect3DDevice9Ex pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HDContentDesc* pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, IDXVAHDDevice** ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        [NativeApi(EntryPoint = "DXVAHD_CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int HDCreateDevice(ref Silk.NET.Direct3D9.IDirect3DDevice9Ex pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HDContentDesc* pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, ref IDXVAHDDevice* ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        [NativeApi(EntryPoint = "DXVAHD_CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int HDCreateDevice(ref Silk.NET.Direct3D9.IDirect3DDevice9Ex pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HDContentDesc pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, IDXVAHDDevice** ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        [NativeApi(EntryPoint = "DXVAHD_CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int HDCreateDevice(ref Silk.NET.Direct3D9.IDirect3DDevice9Ex pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HDContentDesc pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, ref IDXVAHDDevice* ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1967, Column 8 in dxva2api.h")]
        [NativeApi(EntryPoint = "DXVA2CreateDirect3DDeviceManager9", Convention = CallingConvention.StdCall)]
        public unsafe partial int DXVA2CreateDirect3DDeviceManager9(uint* pResetToken, IDirect3DDeviceManager9** ppDeviceManager);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1967, Column 8 in dxva2api.h")]
        [NativeApi(EntryPoint = "DXVA2CreateDirect3DDeviceManager9", Convention = CallingConvention.StdCall)]
        public unsafe partial int DXVA2CreateDirect3DDeviceManager9(uint* pResetToken, ref IDirect3DDeviceManager9* ppDeviceManager);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1967, Column 8 in dxva2api.h")]
        [NativeApi(EntryPoint = "DXVA2CreateDirect3DDeviceManager9", Convention = CallingConvention.StdCall)]
        public unsafe partial int DXVA2CreateDirect3DDeviceManager9(ref uint pResetToken, IDirect3DDeviceManager9** ppDeviceManager);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1967, Column 8 in dxva2api.h")]
        [NativeApi(EntryPoint = "DXVA2CreateDirect3DDeviceManager9", Convention = CallingConvention.StdCall)]
        public unsafe partial int DXVA2CreateDirect3DDeviceManager9(ref uint pResetToken, ref IDirect3DDeviceManager9* ppDeviceManager);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        [NativeApi(EntryPoint = "DXVA2CreateVideoService", Convention = CallingConvention.StdCall)]
        public unsafe partial int DXVA2CreateVideoService(Silk.NET.Direct3D9.IDirect3DDevice9* pDD, Guid* riid, void** ppService);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        [NativeApi(EntryPoint = "DXVA2CreateVideoService", Convention = CallingConvention.StdCall)]
        public unsafe partial int DXVA2CreateVideoService(Silk.NET.Direct3D9.IDirect3DDevice9* pDD, Guid* riid, ref void* ppService);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        [NativeApi(EntryPoint = "DXVA2CreateVideoService", Convention = CallingConvention.StdCall)]
        public unsafe partial int DXVA2CreateVideoService(Silk.NET.Direct3D9.IDirect3DDevice9* pDD, ref Guid riid, void** ppService);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        [NativeApi(EntryPoint = "DXVA2CreateVideoService", Convention = CallingConvention.StdCall)]
        public unsafe partial int DXVA2CreateVideoService(Silk.NET.Direct3D9.IDirect3DDevice9* pDD, ref Guid riid, ref void* ppService);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        [NativeApi(EntryPoint = "DXVA2CreateVideoService", Convention = CallingConvention.StdCall)]
        public unsafe partial int DXVA2CreateVideoService(ref Silk.NET.Direct3D9.IDirect3DDevice9 pDD, Guid* riid, void** ppService);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        [NativeApi(EntryPoint = "DXVA2CreateVideoService", Convention = CallingConvention.StdCall)]
        public unsafe partial int DXVA2CreateVideoService(ref Silk.NET.Direct3D9.IDirect3DDevice9 pDD, Guid* riid, ref void* ppService);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        [NativeApi(EntryPoint = "DXVA2CreateVideoService", Convention = CallingConvention.StdCall)]
        public unsafe partial int DXVA2CreateVideoService(ref Silk.NET.Direct3D9.IDirect3DDevice9 pDD, ref Guid riid, void** ppService);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        [NativeApi(EntryPoint = "DXVA2CreateVideoService", Convention = CallingConvention.StdCall)]
        public unsafe partial int DXVA2CreateVideoService(ref Silk.NET.Direct3D9.IDirect3DDevice9 pDD, ref Guid riid, ref void* ppService);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        public unsafe int HDCreateDevice<TI0>(Silk.NET.Direct3D9.IDirect3DDevice9Ex* pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HDContentDesc* pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDXVAHDDevice>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return HDCreateDevice(pD3DDevice, pContentDesc, Usage, pPlugin, (IDXVAHDDevice**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        public unsafe int HDCreateDevice<TI0>(Silk.NET.Direct3D9.IDirect3DDevice9Ex* pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HDContentDesc pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDXVAHDDevice>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return HDCreateDevice(pD3DDevice, in pContentDesc, Usage, pPlugin, (IDXVAHDDevice**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        public unsafe int HDCreateDevice<TI0>(ref Silk.NET.Direct3D9.IDirect3DDevice9Ex pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HDContentDesc* pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDXVAHDDevice>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return HDCreateDevice(ref pD3DDevice, pContentDesc, Usage, pPlugin, (IDXVAHDDevice**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 1 in dxvahd.h")]
        public unsafe int HDCreateDevice<TI0>(ref Silk.NET.Direct3D9.IDirect3DDevice9Ex pD3DDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HDContentDesc pContentDesc, HDDeviceUsage Usage, PfnPDXVAHDSWPlugin pPlugin, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDXVAHDDevice>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return HDCreateDevice(ref pD3DDevice, in pContentDesc, Usage, pPlugin, (IDXVAHDDevice**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1967, Column 8 in dxva2api.h")]
        public unsafe int DXVA2CreateDirect3DDeviceManager9<TI0>(uint* pResetToken, ref ComPtr<TI0> ppDeviceManager) where TI0 : unmanaged, IComVtbl<IDirect3DDeviceManager9>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return DXVA2CreateDirect3DDeviceManager9(pResetToken, (IDirect3DDeviceManager9**) ppDeviceManager.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1967, Column 8 in dxva2api.h")]
        public unsafe int DXVA2CreateDirect3DDeviceManager9<TI0>(ref uint pResetToken, ref ComPtr<TI0> ppDeviceManager) where TI0 : unmanaged, IComVtbl<IDirect3DDeviceManager9>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return DXVA2CreateDirect3DDeviceManager9(ref pResetToken, (IDirect3DDeviceManager9**) ppDeviceManager.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        public unsafe int DXVA2CreateVideoService<TI0>(Silk.NET.Direct3D9.IDirect3DDevice9* pDD, out ComPtr<TI0> ppService) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppService = default;
            return DXVA2CreateVideoService(pDD, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppService.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        public unsafe int DXVA2CreateVideoService<TI0>(ref Silk.NET.Direct3D9.IDirect3DDevice9 pDD, out ComPtr<TI0> ppService) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppService = default;
            return DXVA2CreateVideoService(ref pDD, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppService.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        public unsafe ComPtr<TI0> DXVA2CreateVideoService<TI0>(Silk.NET.Direct3D9.IDirect3DDevice9* pDD) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(DXVA2CreateVideoService(pDD, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1971, Column 8 in dxva2api.h")]
        public unsafe ComPtr<TI0> DXVA2CreateVideoService<TI0>(ref Silk.NET.Direct3D9.IDirect3DDevice9 pDD) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(DXVA2CreateVideoService(ref pDD, out ComPtr<TI0> silkRet));
            return silkRet;
        }


        public DXVA(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

