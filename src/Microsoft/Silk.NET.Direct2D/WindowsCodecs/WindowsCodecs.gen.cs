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

namespace Silk.NET.WindowsCodecs
{
    public unsafe partial class WindowsCodecs : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "WINCODEC_SDK_VERSION1")]
        public const int WincodecSdkVersion1 = unchecked((int) 0x236);
        [NativeName("Type", "int")]
        [NativeName("Name", "WINCODEC_SDK_VERSION2")]
        public const int WincodecSdkVersion2 = unchecked((int) 0x237);
        [NativeName("Type", "int")]
        [NativeName("Name", "WINCODEC_SDK_VERSION")]
        public const int WincodecSdkVersion = unchecked((int) 0x237);
        [NativeName("Type", "int")]
        [NativeName("Name", "WIC_JPEG_MAX_COMPONENT_COUNT")]
        public const int JpegMaxComponentCount = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "WIC_JPEG_MAX_TABLE_INDEX")]
        public const int JpegMaxTableIndex = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "WIC_JPEG_SAMPLE_FACTORS_ONE")]
        public const int JpegSampleFactorsOne = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "WIC_JPEG_SAMPLE_FACTORS_THREE_420")]
        public const int JpegSampleFactorsThree420 = unchecked((int) 0x111122);
        [NativeName("Type", "int")]
        [NativeName("Name", "WIC_JPEG_SAMPLE_FACTORS_THREE_422")]
        public const int JpegSampleFactorsThree422 = unchecked((int) 0x111121);
        [NativeName("Type", "int")]
        [NativeName("Name", "WIC_JPEG_SAMPLE_FACTORS_THREE_440")]
        public const int JpegSampleFactorsThree440 = unchecked((int) 0x111112);
        [NativeName("Type", "int")]
        [NativeName("Name", "WIC_JPEG_SAMPLE_FACTORS_THREE_444")]
        public const int JpegSampleFactorsThree444 = unchecked((int) 0x111111);
        [NativeName("Type", "int")]
        [NativeName("Name", "WIC_JPEG_QUANTIZATION_BASELINE_ONE")]
        public const int JpegQuantizationBaselineOne = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "WIC_JPEG_QUANTIZATION_BASELINE_THREE")]
        public const int JpegQuantizationBaselineThree = unchecked((int) 0x10100);
        [NativeName("Type", "int")]
        [NativeName("Name", "WIC_JPEG_HUFFMAN_BASELINE_ONE")]
        public const int JpegHuffmanBaselineOne = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "WIC_JPEG_HUFFMAN_BASELINE_THREE")]
        public const int JpegHuffmanBaselineThree = unchecked((int) 0x111100);
        [NativeName("Type", "int")]
        [NativeName("Name", "FACILITY_WINCODEC_ERR")]
        public const int FacilityWincodecErr = unchecked((int) 0x898);
        [NativeName("Type", "int")]
        [NativeName("Name", "WINCODEC_ERR_BASE")]
        public const int WincodecErrBase = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_ExposureCompensation")]
        public const int RawChangeNotificationExposureCompensation = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_NamedWhitePoint")]
        public const int RawChangeNotificationNamedWhitePoint = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_KelvinWhitePoint")]
        public const int RawChangeNotificationKelvinWhitePoint = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_RGBWhitePoint")]
        public const int RawChangeNotificationRgbwhitePoint = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_Contrast")]
        public const int RawChangeNotificationContrast = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_Gamma")]
        public const int RawChangeNotificationGamma = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_Sharpness")]
        public const int RawChangeNotificationSharpness = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_Saturation")]
        public const int RawChangeNotificationSaturation = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_Tint")]
        public const int RawChangeNotificationTint = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_NoiseReduction")]
        public const int RawChangeNotificationNoiseReduction = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_DestinationColorContext")]
        public const int RawChangeNotificationDestinationColorContext = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_ToneCurve")]
        public const int RawChangeNotificationToneCurve = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_Rotation")]
        public const int RawChangeNotificationRotation = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "WICRawChangeNotification_RenderMode")]
        public const int RawChangeNotificationRenderMode = unchecked((int) 0x2000);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5244, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy(IWICBitmapCodecProgressNotification* This, IWICProgressCallback* pICallback, uint dwProgressFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5244, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy(IWICBitmapCodecProgressNotification* This, ref IWICProgressCallback pICallback, uint dwProgressFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5244, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy(ref IWICBitmapCodecProgressNotification This, IWICProgressCallback* pICallback, uint dwProgressFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5244, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Proxy", Convention = CallingConvention.StdCall)]
        public partial int IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy(ref IWICBitmapCodecProgressNotification This, ref IWICProgressCallback pICallback, uint dwProgressFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_Remote_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public partial void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoRemoteGetPatternsProxy(IWICBitmapDecoderInfo* This, BitmapPattern** ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoRemoteGetPatternsProxy(IWICBitmapDecoderInfo* This, BitmapPattern** ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoRemoteGetPatternsProxy(IWICBitmapDecoderInfo* This, ref BitmapPattern* ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoRemoteGetPatternsProxy(IWICBitmapDecoderInfo* This, ref BitmapPattern* ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoRemoteGetPatternsProxy(ref IWICBitmapDecoderInfo This, BitmapPattern** ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoRemoteGetPatternsProxy(ref IWICBitmapDecoderInfo This, BitmapPattern** ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoRemoteGetPatternsProxy(ref IWICBitmapDecoderInfo This, ref BitmapPattern* ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoRemoteGetPatternsProxy(ref IWICBitmapDecoderInfo This, ref BitmapPattern* ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public partial void IWICBitmapDecoderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICConvertBitmapSource", Convention = CallingConvention.StdCall)]
        public unsafe partial int ConvertBitmapSource(Guid* dstFormat, IWICBitmapSource* pISrc, IWICBitmapSource** ppIDst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICConvertBitmapSource", Convention = CallingConvention.StdCall)]
        public unsafe partial int ConvertBitmapSource(Guid* dstFormat, IWICBitmapSource* pISrc, ref IWICBitmapSource* ppIDst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICConvertBitmapSource", Convention = CallingConvention.StdCall)]
        public unsafe partial int ConvertBitmapSource(Guid* dstFormat, ref IWICBitmapSource pISrc, IWICBitmapSource** ppIDst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICConvertBitmapSource", Convention = CallingConvention.StdCall)]
        public unsafe partial int ConvertBitmapSource(Guid* dstFormat, ref IWICBitmapSource pISrc, ref IWICBitmapSource* ppIDst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICConvertBitmapSource", Convention = CallingConvention.StdCall)]
        public unsafe partial int ConvertBitmapSource(ref Guid dstFormat, IWICBitmapSource* pISrc, IWICBitmapSource** ppIDst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICConvertBitmapSource", Convention = CallingConvention.StdCall)]
        public unsafe partial int ConvertBitmapSource(ref Guid dstFormat, IWICBitmapSource* pISrc, ref IWICBitmapSource* ppIDst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICConvertBitmapSource", Convention = CallingConvention.StdCall)]
        public unsafe partial int ConvertBitmapSource(ref Guid dstFormat, ref IWICBitmapSource pISrc, IWICBitmapSource** ppIDst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICConvertBitmapSource", Convention = CallingConvention.StdCall)]
        public unsafe partial int ConvertBitmapSource(ref Guid dstFormat, ref IWICBitmapSource pISrc, ref IWICBitmapSource* ppIDst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSection", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSection(uint width, uint height, Guid* pixelFormat, void* hSection, uint stride, uint offset, IWICBitmap** ppIBitmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSection", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSection(uint width, uint height, Guid* pixelFormat, void* hSection, uint stride, uint offset, ref IWICBitmap* ppIBitmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSection", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSection<T0>(uint width, uint height, Guid* pixelFormat, ref T0 hSection, uint stride, uint offset, IWICBitmap** ppIBitmap) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSection", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSection<T0>(uint width, uint height, Guid* pixelFormat, ref T0 hSection, uint stride, uint offset, ref IWICBitmap* ppIBitmap) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSection", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSection(uint width, uint height, ref Guid pixelFormat, void* hSection, uint stride, uint offset, IWICBitmap** ppIBitmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSection", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSection(uint width, uint height, ref Guid pixelFormat, void* hSection, uint stride, uint offset, ref IWICBitmap* ppIBitmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSection", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSection<T0>(uint width, uint height, ref Guid pixelFormat, ref T0 hSection, uint stride, uint offset, IWICBitmap** ppIBitmap) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSection", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSection<T0>(uint width, uint height, ref Guid pixelFormat, ref T0 hSection, uint stride, uint offset, ref IWICBitmap* ppIBitmap) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSectionEx", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSectionEx(uint width, uint height, Guid* pixelFormat, void* hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, IWICBitmap** ppIBitmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSectionEx", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSectionEx(uint width, uint height, Guid* pixelFormat, void* hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, ref IWICBitmap* ppIBitmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSectionEx", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSectionEx<T0>(uint width, uint height, Guid* pixelFormat, ref T0 hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, IWICBitmap** ppIBitmap) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSectionEx", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSectionEx<T0>(uint width, uint height, Guid* pixelFormat, ref T0 hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, ref IWICBitmap* ppIBitmap) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSectionEx", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSectionEx(uint width, uint height, ref Guid pixelFormat, void* hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, IWICBitmap** ppIBitmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSectionEx", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSectionEx(uint width, uint height, ref Guid pixelFormat, void* hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, ref IWICBitmap* ppIBitmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSectionEx", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSectionEx<T0>(uint width, uint height, ref Guid pixelFormat, ref T0 hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, IWICBitmap** ppIBitmap) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICCreateBitmapFromSectionEx", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBitmapFromSectionEx<T0>(uint width, uint height, ref Guid pixelFormat, ref T0 hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, ref IWICBitmap* ppIBitmap) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapGuidToShortName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapGuidToShortName(Guid* guid, uint cchName, char* wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapGuidToShortName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapGuidToShortName(Guid* guid, uint cchName, char* wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapGuidToShortName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapGuidToShortName(Guid* guid, uint cchName, ref char wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapGuidToShortName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapGuidToShortName(Guid* guid, uint cchName, ref char wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapGuidToShortName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapGuidToShortName(Guid* guid, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapGuidToShortName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapGuidToShortName(Guid* guid, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapGuidToShortName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapGuidToShortName(ref Guid guid, uint cchName, char* wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapGuidToShortName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapGuidToShortName(ref Guid guid, uint cchName, char* wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapGuidToShortName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapGuidToShortName(ref Guid guid, uint cchName, ref char wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapGuidToShortName", Convention = CallingConvention.StdCall)]
        public partial int MapGuidToShortName(ref Guid guid, uint cchName, ref char wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapGuidToShortName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapGuidToShortName(ref Guid guid, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapGuidToShortName", Convention = CallingConvention.StdCall)]
        public partial int MapGuidToShortName(ref Guid guid, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7726, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapShortNameToGuid", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapShortNameToGuid([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzName, Guid* pguid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7726, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapShortNameToGuid", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapShortNameToGuid([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzName, ref Guid pguid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7726, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapShortNameToGuid", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapShortNameToGuid([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzName, Guid* pguid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7726, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapShortNameToGuid", Convention = CallingConvention.StdCall)]
        public partial int MapShortNameToGuid([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzName, ref Guid pguid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7726, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapShortNameToGuid", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapShortNameToGuid([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, Guid* pguid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7726, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapShortNameToGuid", Convention = CallingConvention.StdCall)]
        public partial int MapShortNameToGuid([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, ref Guid pguid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, char* pwzSchema, uint cchName, char* wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, char* pwzSchema, uint cchName, char* wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, char* pwzSchema, uint cchName, ref char wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, char* pwzSchema, uint cchName, ref char wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, char* pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, char* pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, ref char pwzSchema, uint cchName, char* wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, ref char pwzSchema, uint cchName, char* wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, ref char pwzSchema, uint cchName, ref char wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, ref char pwzSchema, uint cchName, ref char wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, ref char pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, ref char pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, char* wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, char* wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, ref char wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, ref char wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(Guid* guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, char* pwzSchema, uint cchName, char* wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, char* pwzSchema, uint cchName, char* wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, char* pwzSchema, uint cchName, ref char wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, char* pwzSchema, uint cchName, ref char wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, char* pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, char* pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, ref char pwzSchema, uint cchName, char* wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, ref char pwzSchema, uint cchName, char* wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, ref char pwzSchema, uint cchName, ref char wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public partial int MapSchemaToName(ref Guid guidMetadataFormat, ref char pwzSchema, uint cchName, ref char wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, ref char pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public partial int MapSchemaToName(ref Guid guidMetadataFormat, ref char pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, char* wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, char* wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, ref char wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public partial int MapSchemaToName(ref Guid guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, ref char wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public unsafe partial int MapSchemaToName(ref Guid guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, uint* pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        [NativeApi(EntryPoint = "WICMapSchemaToName", Convention = CallingConvention.StdCall)]
        public partial int MapSchemaToName(ref Guid guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, ref uint pcchActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8505, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy(IWICDevelopRaw* This, RawCapabilitiesInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8505, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy(IWICDevelopRaw* This, ref RawCapabilitiesInfo pInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8505, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy(ref IWICDevelopRaw This, RawCapabilitiesInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8505, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Proxy", Convention = CallingConvention.StdCall)]
        public partial int IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy(ref IWICDevelopRaw This, ref RawCapabilitiesInfo pInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public partial void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8517, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteSetToneCurveProxy(IWICDevelopRaw* This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurvePoint* aPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8517, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteSetToneCurveProxy(IWICDevelopRaw* This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RawToneCurvePoint aPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8517, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteSetToneCurveProxy(ref IWICDevelopRaw This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurvePoint* aPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8517, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public partial int IWICDevelopRawRemoteSetToneCurveProxy(ref IWICDevelopRaw This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RawToneCurvePoint aPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteSetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public partial void IWICDevelopRawRemoteSetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteGetToneCurveProxy(IWICDevelopRaw* This, uint* pcPoints, RawToneCurvePoint** paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteGetToneCurveProxy(IWICDevelopRaw* This, uint* pcPoints, ref RawToneCurvePoint* paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteGetToneCurveProxy(IWICDevelopRaw* This, ref uint pcPoints, RawToneCurvePoint** paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteGetToneCurveProxy(IWICDevelopRaw* This, ref uint pcPoints, ref RawToneCurvePoint* paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteGetToneCurveProxy(ref IWICDevelopRaw This, uint* pcPoints, RawToneCurvePoint** paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteGetToneCurveProxy(ref IWICDevelopRaw This, uint* pcPoints, ref RawToneCurvePoint* paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteGetToneCurveProxy(ref IWICDevelopRaw This, ref uint pcPoints, RawToneCurvePoint** paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawRemoteGetToneCurveProxy(ref IWICDevelopRaw This, ref uint pcPoints, ref RawToneCurvePoint* paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICDevelopRawRemoteGetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_Remote_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public partial void IWICDevelopRawRemoteGetToneCurveStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9275, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint BSTRUserSize(uint* arg0, uint arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9275, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint BSTRUserSize(uint* arg0, uint arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9275, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint BSTRUserSize(ref uint arg0, uint arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9275, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint BSTRUserSize(ref uint arg0, uint arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserMarshal(uint* arg0, byte* arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserMarshalS(uint* arg0, byte* arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserMarshal(uint* arg0, byte* arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserMarshalS(uint* arg0, byte* arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserMarshal(uint* arg0, ref byte arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserMarshalS(uint* arg0, ref byte arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserMarshal(uint* arg0, ref byte arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserMarshalS(uint* arg0, ref byte arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserMarshal(ref uint arg0, byte* arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserMarshalS(ref uint arg0, byte* arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserMarshal(ref uint arg0, byte* arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserMarshalS(ref uint arg0, byte* arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserMarshal(ref uint arg0, ref byte arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserMarshalS(ref uint arg0, ref byte arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserMarshal(ref uint arg0, ref byte arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserMarshalS(ref uint arg0, ref byte arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserUnmarshal(uint* arg0, byte* arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserUnmarshalS(uint* arg0, byte* arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserUnmarshal(uint* arg0, byte* arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserUnmarshalS(uint* arg0, byte* arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserUnmarshal(uint* arg0, ref byte arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserUnmarshalS(uint* arg0, ref byte arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserUnmarshal(uint* arg0, ref byte arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserUnmarshalS(uint* arg0, ref byte arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserUnmarshal(ref uint arg0, byte* arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserUnmarshalS(ref uint arg0, byte* arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserUnmarshal(ref uint arg0, byte* arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserUnmarshalS(ref uint arg0, byte* arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserUnmarshal(ref uint arg0, ref byte arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserUnmarshalS(ref uint arg0, ref byte arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserUnmarshal(ref uint arg0, ref byte arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserUnmarshalS(ref uint arg0, ref byte arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, char** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* BSTRUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "BSTR_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string BSTRUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref char* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9278, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void BSTRUserFree(uint* arg0, char** arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9278, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void BSTRUserFree(uint* arg0, ref char* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9278, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void BSTRUserFree(ref uint arg0, char** arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9278, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "BSTR_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void BSTRUserFree(ref uint arg0, ref char* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9280, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint HBITMAPUserSize(uint* arg0, uint arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9280, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint HBITMAPUserSize(uint* arg0, uint arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9280, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint HBITMAPUserSize(ref uint arg0, uint arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9280, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint HBITMAPUserSize(ref uint arg0, uint arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserMarshal(uint* arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserMarshalS(uint* arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserMarshal(uint* arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserMarshalS(uint* arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserMarshal(uint* arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserMarshalS(uint* arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserMarshal(uint* arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserMarshalS(uint* arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserMarshal(ref uint arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserMarshalS(ref uint arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserMarshal(ref uint arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserMarshalS(ref uint arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserMarshal(ref uint arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserMarshalS(ref uint arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserMarshal(ref uint arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserMarshalS(ref uint arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserUnmarshal(uint* arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserUnmarshalS(uint* arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserUnmarshal(uint* arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserUnmarshalS(uint* arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserUnmarshal(uint* arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserUnmarshalS(uint* arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserUnmarshal(uint* arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserUnmarshalS(uint* arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserUnmarshal(ref uint arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserUnmarshalS(ref uint arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserUnmarshal(ref uint arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserUnmarshalS(ref uint arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserUnmarshal(ref uint arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserUnmarshalS(ref uint arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserUnmarshal(ref uint arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserUnmarshalS(ref uint arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HBITMAPUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HBITMAP_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HBITMAPUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9283, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void HBITMAPUserFree(uint* arg0, void** arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9283, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void HBITMAPUserFree(uint* arg0, ref void* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9283, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void HBITMAPUserFree(ref uint arg0, void** arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9283, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HBITMAP_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void HBITMAPUserFree(ref uint arg0, ref void* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9285, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint HICONUserSize(uint* arg0, uint arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9285, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint HICONUserSize(uint* arg0, uint arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9285, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint HICONUserSize(ref uint arg0, uint arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9285, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint HICONUserSize(ref uint arg0, uint arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserMarshal(uint* arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserMarshalS(uint* arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserMarshal(uint* arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserMarshalS(uint* arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserMarshal(uint* arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserMarshalS(uint* arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserMarshal(uint* arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserMarshalS(uint* arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserMarshal(ref uint arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserMarshalS(ref uint arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserMarshal(ref uint arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserMarshalS(ref uint arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserMarshal(ref uint arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserMarshalS(ref uint arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserMarshal(ref uint arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserMarshalS(ref uint arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserUnmarshal(uint* arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserUnmarshalS(uint* arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserUnmarshal(uint* arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserUnmarshalS(uint* arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserUnmarshal(uint* arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserUnmarshalS(uint* arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserUnmarshal(uint* arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserUnmarshalS(uint* arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserUnmarshal(ref uint arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserUnmarshalS(ref uint arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserUnmarshal(ref uint arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserUnmarshalS(ref uint arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserUnmarshal(ref uint arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserUnmarshalS(ref uint arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserUnmarshal(ref uint arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserUnmarshalS(ref uint arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HICONUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HICON_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HICONUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9288, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void HICONUserFree(uint* arg0, void** arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9288, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void HICONUserFree(uint* arg0, ref void* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9288, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void HICONUserFree(ref uint arg0, void** arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9288, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HICON_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void HICONUserFree(ref uint arg0, ref void* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9290, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint HPALETTEUserSize(uint* arg0, uint arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9290, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint HPALETTEUserSize(uint* arg0, uint arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9290, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint HPALETTEUserSize(ref uint arg0, uint arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9290, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint HPALETTEUserSize(ref uint arg0, uint arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserMarshal(uint* arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserMarshalS(uint* arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserMarshal(uint* arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserMarshalS(uint* arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserMarshal(uint* arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserMarshalS(uint* arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserMarshal(uint* arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserMarshalS(uint* arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserMarshal(ref uint arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserMarshalS(ref uint arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserMarshal(ref uint arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserMarshalS(ref uint arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserMarshal(ref uint arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserMarshalS(ref uint arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserMarshal(ref uint arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserMarshalS(ref uint arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserUnmarshal(uint* arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserUnmarshalS(uint* arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserUnmarshal(uint* arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserUnmarshalS(uint* arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserUnmarshal(uint* arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserUnmarshalS(uint* arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserUnmarshal(uint* arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserUnmarshalS(uint* arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserUnmarshal(ref uint arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserUnmarshalS(ref uint arg0, byte* arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserUnmarshal(ref uint arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserUnmarshalS(ref uint arg0, byte* arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserUnmarshal(ref uint arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserUnmarshalS(ref uint arg0, ref byte arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserUnmarshal(ref uint arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserUnmarshalS(ref uint arg0, ref byte arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* HPALETTEUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "HPALETTE_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string HPALETTEUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9293, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void HPALETTEUserFree(uint* arg0, void** arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9293, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void HPALETTEUserFree(uint* arg0, ref void* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9293, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void HPALETTEUserFree(ref uint arg0, void** arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9293, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "HPALETTE_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void HPALETTEUserFree(ref uint arg0, ref void* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9295, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint LPSAFEARRAYUserSize(uint* arg0, uint arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9295, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint LPSAFEARRAYUserSize(uint* arg0, uint arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9295, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint LPSAFEARRAYUserSize(ref uint arg0, uint arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9295, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint LPSAFEARRAYUserSize(ref uint arg0, uint arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserMarshal(uint* arg0, byte* arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserMarshalS(uint* arg0, byte* arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserMarshal(uint* arg0, byte* arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserMarshalS(uint* arg0, byte* arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserMarshal(uint* arg0, ref byte arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserMarshalS(uint* arg0, ref byte arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserMarshal(uint* arg0, ref byte arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserMarshalS(uint* arg0, ref byte arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserMarshal(ref uint arg0, byte* arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserMarshalS(ref uint arg0, byte* arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserMarshal(ref uint arg0, byte* arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserMarshalS(ref uint arg0, byte* arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserMarshal(ref uint arg0, ref byte arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserMarshalS(ref uint arg0, ref byte arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserMarshal(ref uint arg0, ref byte arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserMarshalS(ref uint arg0, ref byte arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserUnmarshal(uint* arg0, byte* arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserUnmarshalS(uint* arg0, byte* arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserUnmarshal(uint* arg0, byte* arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserUnmarshalS(uint* arg0, byte* arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserUnmarshal(uint* arg0, ref byte arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserUnmarshalS(uint* arg0, ref byte arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserUnmarshal(uint* arg0, ref byte arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserUnmarshalS(uint* arg0, ref byte arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserUnmarshal(ref uint arg0, byte* arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserUnmarshalS(ref uint arg0, byte* arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserUnmarshal(ref uint arg0, byte* arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserUnmarshalS(ref uint arg0, byte* arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserUnmarshal(ref uint arg0, ref byte arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserUnmarshalS(ref uint arg0, ref byte arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserUnmarshal(ref uint arg0, ref byte arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserUnmarshalS(ref uint arg0, ref byte arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* LPSAFEARRAYUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string LPSAFEARRAYUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9298, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void LPSAFEARRAYUserFree(uint* arg0, Silk.NET.Core.Win32Extras.SafeArray** arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9298, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void LPSAFEARRAYUserFree(uint* arg0, ref Silk.NET.Core.Win32Extras.SafeArray* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9298, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void LPSAFEARRAYUserFree(ref uint arg0, Silk.NET.Core.Win32Extras.SafeArray** arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9298, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "LPSAFEARRAY_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void LPSAFEARRAYUserFree(ref uint arg0, ref Silk.NET.Core.Win32Extras.SafeArray* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9300, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint InProcPointerUserSize(uint* arg0, uint arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9300, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint InProcPointerUserSize(uint* arg0, uint arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9300, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint InProcPointerUserSize(ref uint arg0, uint arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9300, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint InProcPointerUserSize(ref uint arg0, uint arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserMarshal(uint* arg0, byte* arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserMarshalS(uint* arg0, byte* arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserMarshal(uint* arg0, byte* arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserMarshalS(uint* arg0, byte* arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserMarshal(uint* arg0, ref byte arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserMarshalS(uint* arg0, ref byte arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserMarshal(uint* arg0, ref byte arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserMarshalS(uint* arg0, ref byte arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserMarshal(ref uint arg0, byte* arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserMarshalS(ref uint arg0, byte* arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserMarshal(ref uint arg0, byte* arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserMarshalS(ref uint arg0, byte* arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserMarshal(ref uint arg0, ref byte arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserMarshalS(ref uint arg0, ref byte arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserMarshal(ref uint arg0, ref byte arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserMarshalS(ref uint arg0, ref byte arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserUnmarshal(uint* arg0, byte* arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserUnmarshalS(uint* arg0, byte* arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserUnmarshal(uint* arg0, byte* arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserUnmarshalS(uint* arg0, byte* arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserUnmarshal(uint* arg0, ref byte arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserUnmarshalS(uint* arg0, ref byte arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserUnmarshal(uint* arg0, ref byte arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserUnmarshalS(uint* arg0, ref byte arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserUnmarshal(ref uint arg0, byte* arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserUnmarshalS(ref uint arg0, byte* arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserUnmarshal(ref uint arg0, byte* arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserUnmarshalS(ref uint arg0, byte* arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserUnmarshal(ref uint arg0, ref byte arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserUnmarshalS(ref uint arg0, ref byte arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserUnmarshal(ref uint arg0, ref byte arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserUnmarshalS(ref uint arg0, ref byte arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, byte** arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* InProcPointerUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "WICInProcPointer_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string InProcPointerUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref byte* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9303, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void InProcPointerUserFree(uint* arg0, byte** arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9303, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void InProcPointerUserFree(uint* arg0, ref byte* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9303, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void InProcPointerUserFree(ref uint arg0, byte** arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9303, Column 39 in wincodec.h")]
        [NativeApi(EntryPoint = "WICInProcPointer_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void InProcPointerUserFree(ref uint arg0, ref byte* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9305, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_RegisterProgressNotification_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy(IWICBitmapCodecProgressNotification* This, PfnProgressNotification pfnProgressNotification, void* pvData, uint dwProgressFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9305, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_RegisterProgressNotification_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy<T0>(IWICBitmapCodecProgressNotification* This, PfnProgressNotification pfnProgressNotification, ref T0 pvData, uint dwProgressFlags) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9305, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_RegisterProgressNotification_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy(ref IWICBitmapCodecProgressNotification This, PfnProgressNotification pfnProgressNotification, void* pvData, uint dwProgressFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9305, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_RegisterProgressNotification_Proxy", Convention = CallingConvention.StdCall)]
        public partial int IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy<T0>(ref IWICBitmapCodecProgressNotification This, PfnProgressNotification pfnProgressNotification, ref T0 pvData, uint dwProgressFlags) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9314, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub(IWICBitmapCodecProgressNotification* This, IWICProgressCallback* pICallback, uint dwProgressFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9314, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub(IWICBitmapCodecProgressNotification* This, ref IWICProgressCallback pICallback, uint dwProgressFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9314, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub(ref IWICBitmapCodecProgressNotification This, IWICProgressCallback* pICallback, uint dwProgressFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9314, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapCodecProgressNotification_RegisterProgressNotification_Stub", Convention = CallingConvention.StdCall)]
        public partial int IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub(ref IWICBitmapCodecProgressNotification This, ref IWICProgressCallback pICallback, uint dwProgressFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(IWICBitmapDecoderInfo* This, uint cbSizePatterns, BitmapPattern* pPatterns, uint* pcPatterns, uint* pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(IWICBitmapDecoderInfo* This, uint cbSizePatterns, BitmapPattern* pPatterns, uint* pcPatterns, ref uint pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(IWICBitmapDecoderInfo* This, uint cbSizePatterns, BitmapPattern* pPatterns, ref uint pcPatterns, uint* pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(IWICBitmapDecoderInfo* This, uint cbSizePatterns, BitmapPattern* pPatterns, ref uint pcPatterns, ref uint pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(IWICBitmapDecoderInfo* This, uint cbSizePatterns, ref BitmapPattern pPatterns, uint* pcPatterns, uint* pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(IWICBitmapDecoderInfo* This, uint cbSizePatterns, ref BitmapPattern pPatterns, uint* pcPatterns, ref uint pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(IWICBitmapDecoderInfo* This, uint cbSizePatterns, ref BitmapPattern pPatterns, ref uint pcPatterns, uint* pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(IWICBitmapDecoderInfo* This, uint cbSizePatterns, ref BitmapPattern pPatterns, ref uint pcPatterns, ref uint pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(ref IWICBitmapDecoderInfo This, uint cbSizePatterns, BitmapPattern* pPatterns, uint* pcPatterns, uint* pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(ref IWICBitmapDecoderInfo This, uint cbSizePatterns, BitmapPattern* pPatterns, uint* pcPatterns, ref uint pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(ref IWICBitmapDecoderInfo This, uint cbSizePatterns, BitmapPattern* pPatterns, ref uint pcPatterns, uint* pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(ref IWICBitmapDecoderInfo This, uint cbSizePatterns, BitmapPattern* pPatterns, ref uint pcPatterns, ref uint pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(ref IWICBitmapDecoderInfo This, uint cbSizePatterns, ref BitmapPattern pPatterns, uint* pcPatterns, uint* pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(ref IWICBitmapDecoderInfo This, uint cbSizePatterns, ref BitmapPattern pPatterns, uint* pcPatterns, ref uint pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsProxy(ref IWICBitmapDecoderInfo This, uint cbSizePatterns, ref BitmapPattern pPatterns, ref uint pcPatterns, uint* pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public partial int IWICBitmapDecoderInfoGetPatternsProxy(ref IWICBitmapDecoderInfo This, uint cbSizePatterns, ref BitmapPattern pPatterns, ref uint pcPatterns, ref uint pcbPatternsActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsStub(IWICBitmapDecoderInfo* This, BitmapPattern** ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsStub(IWICBitmapDecoderInfo* This, BitmapPattern** ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsStub(IWICBitmapDecoderInfo* This, ref BitmapPattern* ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsStub(IWICBitmapDecoderInfo* This, ref BitmapPattern* ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsStub(ref IWICBitmapDecoderInfo This, BitmapPattern** ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsStub(ref IWICBitmapDecoderInfo This, BitmapPattern** ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsStub(ref IWICBitmapDecoderInfo This, ref BitmapPattern* ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICBitmapDecoderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICBitmapDecoderInfoGetPatternsStub(ref IWICBitmapDecoderInfo This, ref BitmapPattern* ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9335, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_QueryRawCapabilitiesInfo_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawQueryRawCapabilitiesInfoProxy(IWICDevelopRaw* This, RawCapabilitiesInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9335, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_QueryRawCapabilitiesInfo_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawQueryRawCapabilitiesInfoProxy(IWICDevelopRaw* This, ref RawCapabilitiesInfo pInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9335, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_QueryRawCapabilitiesInfo_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawQueryRawCapabilitiesInfoProxy(ref IWICDevelopRaw This, RawCapabilitiesInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9335, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_QueryRawCapabilitiesInfo_Proxy", Convention = CallingConvention.StdCall)]
        public partial int IWICDevelopRawQueryRawCapabilitiesInfoProxy(ref IWICDevelopRaw This, ref RawCapabilitiesInfo pInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9340, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawQueryRawCapabilitiesInfoStub(IWICDevelopRaw* This, RawCapabilitiesInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9340, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawQueryRawCapabilitiesInfoStub(IWICDevelopRaw* This, ref RawCapabilitiesInfo pInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9340, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawQueryRawCapabilitiesInfoStub(ref IWICDevelopRaw This, RawCapabilitiesInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9340, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_QueryRawCapabilitiesInfo_Stub", Convention = CallingConvention.StdCall)]
        public partial int IWICDevelopRawQueryRawCapabilitiesInfoStub(ref IWICDevelopRaw This, ref RawCapabilitiesInfo pInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9344, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_SetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawSetToneCurveProxy(IWICDevelopRaw* This, uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurve* pToneCurve);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9344, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_SetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawSetToneCurveProxy(IWICDevelopRaw* This, uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RawToneCurve pToneCurve);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9344, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_SetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawSetToneCurveProxy(ref IWICDevelopRaw This, uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurve* pToneCurve);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9344, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_SetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public partial int IWICDevelopRawSetToneCurveProxy(ref IWICDevelopRaw This, uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RawToneCurve pToneCurve);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9351, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawSetToneCurveStub(IWICDevelopRaw* This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurvePoint* aPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9351, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawSetToneCurveStub(IWICDevelopRaw* This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RawToneCurvePoint aPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9351, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawSetToneCurveStub(ref IWICDevelopRaw This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurvePoint* aPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9351, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_SetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public partial int IWICDevelopRawSetToneCurveStub(ref IWICDevelopRaw This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RawToneCurvePoint aPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveProxy(IWICDevelopRaw* This, uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, uint* pcbActualToneCurveBufferSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveProxy(IWICDevelopRaw* This, uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, ref uint pcbActualToneCurveBufferSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveProxy(IWICDevelopRaw* This, uint cbToneCurveBufferSize, ref RawToneCurve pToneCurve, uint* pcbActualToneCurveBufferSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveProxy(IWICDevelopRaw* This, uint cbToneCurveBufferSize, ref RawToneCurve pToneCurve, ref uint pcbActualToneCurveBufferSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveProxy(ref IWICDevelopRaw This, uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, uint* pcbActualToneCurveBufferSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveProxy(ref IWICDevelopRaw This, uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, ref uint pcbActualToneCurveBufferSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveProxy(ref IWICDevelopRaw This, uint cbToneCurveBufferSize, ref RawToneCurve pToneCurve, uint* pcbActualToneCurveBufferSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Proxy", Convention = CallingConvention.StdCall)]
        public partial int IWICDevelopRawGetToneCurveProxy(ref IWICDevelopRaw This, uint cbToneCurveBufferSize, ref RawToneCurve pToneCurve, ref uint pcbActualToneCurveBufferSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveStub(IWICDevelopRaw* This, uint* pcPoints, RawToneCurvePoint** paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveStub(IWICDevelopRaw* This, uint* pcPoints, ref RawToneCurvePoint* paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveStub(IWICDevelopRaw* This, ref uint pcPoints, RawToneCurvePoint** paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveStub(IWICDevelopRaw* This, ref uint pcPoints, ref RawToneCurvePoint* paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveStub(ref IWICDevelopRaw This, uint* pcPoints, RawToneCurvePoint** paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveStub(ref IWICDevelopRaw This, uint* pcPoints, ref RawToneCurvePoint* paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveStub(ref IWICDevelopRaw This, ref uint pcPoints, RawToneCurvePoint** paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        [NativeApi(EntryPoint = "IWICDevelopRaw_GetToneCurve_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICDevelopRawGetToneCurveStub(ref IWICDevelopRaw This, ref uint pcPoints, ref RawToneCurvePoint* paPoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, MetadataPattern** ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, ref MetadataPattern* ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, MetadataPattern** ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoRemoteGetPatternsProxy(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, ref MetadataPattern* ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataReaderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_Remote_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public partial void IWICMetadataReaderInfoRemoteGetPatternsStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoRemoteGetHeaderProxy(IWICMetadataWriterInfo* This, Guid* guidContainerFormat, MetadataHeader* pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoRemoteGetHeaderProxy(IWICMetadataWriterInfo* This, Guid* guidContainerFormat, ref MetadataHeader pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoRemoteGetHeaderProxy(IWICMetadataWriterInfo* This, ref Guid guidContainerFormat, MetadataHeader* pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoRemoteGetHeaderProxy(IWICMetadataWriterInfo* This, ref Guid guidContainerFormat, ref MetadataHeader pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoRemoteGetHeaderProxy(ref IWICMetadataWriterInfo This, Guid* guidContainerFormat, MetadataHeader* pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoRemoteGetHeaderProxy(ref IWICMetadataWriterInfo This, Guid* guidContainerFormat, ref MetadataHeader pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoRemoteGetHeaderProxy(ref IWICMetadataWriterInfo This, ref Guid guidContainerFormat, MetadataHeader* pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public partial int IWICMetadataWriterInfoRemoteGetHeaderProxy(ref IWICMetadataWriterInfo This, ref Guid guidContainerFormat, ref MetadataHeader pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial void IWICMetadataWriterInfoRemoteGetHeaderStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, uint* _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_Remote_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public partial void IWICMetadataWriterInfoRemoteGetHeaderStub(ref Silk.NET.Core.Win32Extras.IRpcStubBuffer This, ref Silk.NET.Core.Win32Extras.IRpcChannelBuffer _pRpcChannelBuffer, ref Silk.NET.Core.Win32Extras.RPCMessage _pRpcMessage, ref uint _pdwStubPhase);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, Guid* pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, ref Guid pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref Silk.NET.Core.Win32Extras.IStream pIStream, Guid* pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref Guid pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, Guid* pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, ref Guid pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref Silk.NET.Core.Win32Extras.IStream pIStream, Guid* pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref Guid pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, Guid* pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, ref Guid pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref Silk.NET.Core.Win32Extras.IStream pIStream, Guid* pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref Guid pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, Guid* pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, ref Guid pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int MatchMetadataContent(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref Silk.NET.Core.Win32Extras.IStream pIStream, Guid* pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICMatchMetadataContent", Convention = CallingConvention.StdCall)]
        public partial int MatchMetadataContent(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref Guid pguidMetadataFormat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICSerializeMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeMetadataContent(Guid* guidContainerFormat, IWICMetadataWriter* pIWriter, uint dwPersistOptions, Silk.NET.Core.Win32Extras.IStream* pIStream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICSerializeMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeMetadataContent(Guid* guidContainerFormat, IWICMetadataWriter* pIWriter, uint dwPersistOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICSerializeMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeMetadataContent(Guid* guidContainerFormat, ref IWICMetadataWriter pIWriter, uint dwPersistOptions, Silk.NET.Core.Win32Extras.IStream* pIStream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICSerializeMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeMetadataContent(Guid* guidContainerFormat, ref IWICMetadataWriter pIWriter, uint dwPersistOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICSerializeMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeMetadataContent(ref Guid guidContainerFormat, IWICMetadataWriter* pIWriter, uint dwPersistOptions, Silk.NET.Core.Win32Extras.IStream* pIStream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICSerializeMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeMetadataContent(ref Guid guidContainerFormat, IWICMetadataWriter* pIWriter, uint dwPersistOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICSerializeMetadataContent", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeMetadataContent(ref Guid guidContainerFormat, ref IWICMetadataWriter pIWriter, uint dwPersistOptions, Silk.NET.Core.Win32Extras.IStream* pIStream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICSerializeMetadataContent", Convention = CallingConvention.StdCall)]
        public partial int SerializeMetadataContent(ref Guid guidContainerFormat, ref IWICMetadataWriter pIWriter, uint dwPersistOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICGetMetadataContentSize", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetMetadataContentSize(Guid* guidContainerFormat, IWICMetadataWriter* pIWriter, ulong* pcbSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICGetMetadataContentSize", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetMetadataContentSize(Guid* guidContainerFormat, IWICMetadataWriter* pIWriter, ref ulong pcbSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICGetMetadataContentSize", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetMetadataContentSize(Guid* guidContainerFormat, ref IWICMetadataWriter pIWriter, ulong* pcbSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICGetMetadataContentSize", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetMetadataContentSize(Guid* guidContainerFormat, ref IWICMetadataWriter pIWriter, ref ulong pcbSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICGetMetadataContentSize", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetMetadataContentSize(ref Guid guidContainerFormat, IWICMetadataWriter* pIWriter, ulong* pcbSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICGetMetadataContentSize", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetMetadataContentSize(ref Guid guidContainerFormat, IWICMetadataWriter* pIWriter, ref ulong pcbSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICGetMetadataContentSize", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetMetadataContentSize(ref Guid guidContainerFormat, ref IWICMetadataWriter pIWriter, ulong* pcbSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "WICGetMetadataContentSize", Convention = CallingConvention.StdCall)]
        public partial int GetMetadataContentSize(ref Guid guidContainerFormat, ref IWICMetadataWriter pIWriter, ref ulong pcbSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2432, Column 39 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint CLIPFORMATUserSize(uint* arg0, uint arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2432, Column 39 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint CLIPFORMATUserSize(uint* arg0, uint arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2432, Column 39 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserSize", Convention = CallingConvention.StdCall)]
        public unsafe partial uint CLIPFORMATUserSize(ref uint arg0, uint arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2432, Column 39 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserSize", Convention = CallingConvention.StdCall)]
        public partial uint CLIPFORMATUserSize(ref uint arg0, uint arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserMarshal(uint* arg0, byte* arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserMarshalS(uint* arg0, byte* arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserMarshal(uint* arg0, byte* arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserMarshalS(uint* arg0, byte* arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserMarshal(uint* arg0, ref byte arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserMarshalS(uint* arg0, ref byte arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserMarshal(uint* arg0, ref byte arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserMarshalS(uint* arg0, ref byte arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserMarshal(ref uint arg0, byte* arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserMarshalS(ref uint arg0, byte* arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserMarshal(ref uint arg0, byte* arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserMarshalS(ref uint arg0, byte* arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserMarshal(ref uint arg0, ref byte arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserMarshalS(ref uint arg0, ref byte arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserMarshal(ref uint arg0, ref byte arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public partial string CLIPFORMATUserMarshalS(ref uint arg0, ref byte arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserMarshal", Convention = CallingConvention.StdCall)]
        public partial string CLIPFORMATUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserUnmarshal(uint* arg0, byte* arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserUnmarshalS(uint* arg0, byte* arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserUnmarshal(uint* arg0, byte* arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserUnmarshalS(uint* arg0, byte* arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserUnmarshal(uint* arg0, ref byte arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserUnmarshalS(uint* arg0, ref byte arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserUnmarshal(uint* arg0, ref byte arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserUnmarshalS(uint* arg0, ref byte arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserUnmarshal(ref uint arg0, byte* arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserUnmarshalS(ref uint arg0, byte* arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserUnmarshal(ref uint arg0, byte* arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserUnmarshalS(ref uint arg0, byte* arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserUnmarshal(ref uint arg0, ref byte arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserUnmarshalS(ref uint arg0, ref byte arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserUnmarshal(ref uint arg0, ref byte arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public partial string CLIPFORMATUserUnmarshalS(ref uint arg0, ref byte arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial string CLIPFORMATUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ushort* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public unsafe partial byte* CLIPFORMATUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserUnmarshal", Convention = CallingConvention.StdCall)]
        public partial string CLIPFORMATUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref ushort arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2435, Column 39 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void CLIPFORMATUserFree(uint* arg0, ushort* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2435, Column 39 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void CLIPFORMATUserFree(uint* arg0, ref ushort arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2435, Column 39 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserFree", Convention = CallingConvention.StdCall)]
        public unsafe partial void CLIPFORMATUserFree(ref uint arg0, ushort* arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2435, Column 39 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "CLIPFORMAT_UserFree", Convention = CallingConvention.StdCall)]
        public partial void CLIPFORMATUserFree(ref uint arg0, ref ushort arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Proxy", Convention = CallingConvention.StdCall)]
        public partial int IWICMetadataReaderInfoGetPatternsProxy(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(IWICMetadataReaderInfo* This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, MetadataPattern** ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(IWICMetadataReaderInfo* This, ref Guid guidContainerFormat, ref MetadataPattern* ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(ref IWICMetadataReaderInfo This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, MetadataPattern** ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataReaderInfo_GetPatterns_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataReaderInfoGetPatternsStub(ref IWICMetadataReaderInfo This, ref Guid guidContainerFormat, ref MetadataPattern* ppPatterns, ref uint pcPatterns);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(IWICMetadataWriterInfo* This, Guid* guidContainerFormat, uint cbSize, MetadataHeader* pHeader, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(IWICMetadataWriterInfo* This, Guid* guidContainerFormat, uint cbSize, MetadataHeader* pHeader, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(IWICMetadataWriterInfo* This, Guid* guidContainerFormat, uint cbSize, ref MetadataHeader pHeader, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(IWICMetadataWriterInfo* This, Guid* guidContainerFormat, uint cbSize, ref MetadataHeader pHeader, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(IWICMetadataWriterInfo* This, ref Guid guidContainerFormat, uint cbSize, MetadataHeader* pHeader, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(IWICMetadataWriterInfo* This, ref Guid guidContainerFormat, uint cbSize, MetadataHeader* pHeader, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(IWICMetadataWriterInfo* This, ref Guid guidContainerFormat, uint cbSize, ref MetadataHeader pHeader, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(IWICMetadataWriterInfo* This, ref Guid guidContainerFormat, uint cbSize, ref MetadataHeader pHeader, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(ref IWICMetadataWriterInfo This, Guid* guidContainerFormat, uint cbSize, MetadataHeader* pHeader, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(ref IWICMetadataWriterInfo This, Guid* guidContainerFormat, uint cbSize, MetadataHeader* pHeader, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(ref IWICMetadataWriterInfo This, Guid* guidContainerFormat, uint cbSize, ref MetadataHeader pHeader, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(ref IWICMetadataWriterInfo This, Guid* guidContainerFormat, uint cbSize, ref MetadataHeader pHeader, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(ref IWICMetadataWriterInfo This, ref Guid guidContainerFormat, uint cbSize, MetadataHeader* pHeader, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(ref IWICMetadataWriterInfo This, ref Guid guidContainerFormat, uint cbSize, MetadataHeader* pHeader, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderProxy(ref IWICMetadataWriterInfo This, ref Guid guidContainerFormat, uint cbSize, ref MetadataHeader pHeader, uint* pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Proxy", Convention = CallingConvention.StdCall)]
        public partial int IWICMetadataWriterInfoGetHeaderProxy(ref IWICMetadataWriterInfo This, ref Guid guidContainerFormat, uint cbSize, ref MetadataHeader pHeader, ref uint pcbActual);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderStub(IWICMetadataWriterInfo* This, Guid* guidContainerFormat, MetadataHeader* pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderStub(IWICMetadataWriterInfo* This, Guid* guidContainerFormat, ref MetadataHeader pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderStub(IWICMetadataWriterInfo* This, ref Guid guidContainerFormat, MetadataHeader* pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderStub(IWICMetadataWriterInfo* This, ref Guid guidContainerFormat, ref MetadataHeader pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderStub(ref IWICMetadataWriterInfo This, Guid* guidContainerFormat, MetadataHeader* pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderStub(ref IWICMetadataWriterInfo This, Guid* guidContainerFormat, ref MetadataHeader pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public unsafe partial int IWICMetadataWriterInfoGetHeaderStub(ref IWICMetadataWriterInfo This, ref Guid guidContainerFormat, MetadataHeader* pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        [NativeApi(EntryPoint = "IWICMetadataWriterInfo_GetHeader_Stub", Convention = CallingConvention.StdCall)]
        public partial int IWICMetadataWriterInfoGetHeaderStub(ref IWICMetadataWriterInfo This, ref Guid guidContainerFormat, ref MetadataHeader pHeader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5244, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy<TI0, TI1>(ComPtr<TI0> This, ComPtr<TI1> pICallback, uint dwProgressFlags) where TI0 : unmanaged, IComVtbl<IWICBitmapCodecProgressNotification>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICProgressCallback>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy((IWICBitmapCodecProgressNotification*) This.Handle, (IWICProgressCallback*) pICallback.Handle, dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5244, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy<TI0>(ComPtr<TI0> This, ref IWICProgressCallback pICallback, uint dwProgressFlags) where TI0 : unmanaged, IComVtbl<IWICBitmapCodecProgressNotification>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy((IWICBitmapCodecProgressNotification*) This.Handle, ref pICallback, dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5244, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy<TI0>(ref IWICBitmapCodecProgressNotification This, ComPtr<TI0> pICallback, uint dwProgressFlags) where TI0 : unmanaged, IComVtbl<IWICProgressCallback>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy(ref This, (IWICProgressCallback*) pICallback.Handle, dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoRemoteGetPatternsProxy<TI0>(ComPtr<TI0> This, BitmapPattern** ppPatterns, uint* pcPatterns) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoRemoteGetPatternsProxy((IWICBitmapDecoderInfo*) This.Handle, ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoRemoteGetPatternsProxy<TI0>(ComPtr<TI0> This, BitmapPattern** ppPatterns, ref uint pcPatterns) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoRemoteGetPatternsProxy((IWICBitmapDecoderInfo*) This.Handle, ppPatterns, ref pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoRemoteGetPatternsProxy<TI0>(ComPtr<TI0> This, ref BitmapPattern* ppPatterns, uint* pcPatterns) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoRemoteGetPatternsProxy((IWICBitmapDecoderInfo*) This.Handle, ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoRemoteGetPatternsProxy<TI0>(ComPtr<TI0> This, ref BitmapPattern* ppPatterns, ref uint pcPatterns) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoRemoteGetPatternsProxy((IWICBitmapDecoderInfo*) This.Handle, ref ppPatterns, ref pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        public unsafe int ConvertBitmapSource<TI0, TI1>(Guid* dstFormat, ComPtr<TI0> pISrc, ref ComPtr<TI1> ppIDst) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return ConvertBitmapSource(dstFormat, (IWICBitmapSource*) pISrc.Handle, (IWICBitmapSource**) ppIDst.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        public unsafe int ConvertBitmapSource<TI0>(Guid* dstFormat, ComPtr<TI0> pISrc, ref IWICBitmapSource* ppIDst) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return ConvertBitmapSource(dstFormat, (IWICBitmapSource*) pISrc.Handle, ref ppIDst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        public unsafe int ConvertBitmapSource<TI0>(Guid* dstFormat, ref IWICBitmapSource pISrc, ref ComPtr<TI0> ppIDst) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return ConvertBitmapSource(dstFormat, ref pISrc, (IWICBitmapSource**) ppIDst.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        public unsafe int ConvertBitmapSource<TI0, TI1>(ref Guid dstFormat, ComPtr<TI0> pISrc, ref ComPtr<TI1> ppIDst) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return ConvertBitmapSource(ref dstFormat, (IWICBitmapSource*) pISrc.Handle, (IWICBitmapSource**) ppIDst.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        public unsafe int ConvertBitmapSource<TI0>(ref Guid dstFormat, ComPtr<TI0> pISrc, ref IWICBitmapSource* ppIDst) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return ConvertBitmapSource(ref dstFormat, (IWICBitmapSource*) pISrc.Handle, ref ppIDst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        public unsafe int ConvertBitmapSource<TI0>(ref Guid dstFormat, ref IWICBitmapSource pISrc, ref ComPtr<TI0> ppIDst) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return ConvertBitmapSource(ref dstFormat, ref pISrc, (IWICBitmapSource**) ppIDst.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        public unsafe int CreateBitmapFromSection<TI0>(uint width, uint height, Guid* pixelFormat, void* hSection, uint stride, uint offset, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateBitmapFromSection(width, height, pixelFormat, hSection, stride, offset, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        public unsafe int CreateBitmapFromSection<T0, TI0>(uint width, uint height, Guid* pixelFormat, ref T0 hSection, uint stride, uint offset, ref ComPtr<TI0> ppIBitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateBitmapFromSection(width, height, pixelFormat, ref hSection, stride, offset, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        public unsafe int CreateBitmapFromSection<TI0>(uint width, uint height, ref Guid pixelFormat, void* hSection, uint stride, uint offset, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateBitmapFromSection(width, height, ref pixelFormat, hSection, stride, offset, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        public unsafe int CreateBitmapFromSection<T0, TI0>(uint width, uint height, ref Guid pixelFormat, ref T0 hSection, uint stride, uint offset, ref ComPtr<TI0> ppIBitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateBitmapFromSection(width, height, ref pixelFormat, ref hSection, stride, offset, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        public unsafe int CreateBitmapFromSectionEx<TI0>(uint width, uint height, Guid* pixelFormat, void* hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateBitmapFromSectionEx(width, height, pixelFormat, hSection, stride, offset, desiredAccessLevel, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        public unsafe int CreateBitmapFromSectionEx<T0, TI0>(uint width, uint height, Guid* pixelFormat, ref T0 hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, ref ComPtr<TI0> ppIBitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateBitmapFromSectionEx(width, height, pixelFormat, ref hSection, stride, offset, desiredAccessLevel, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        public unsafe int CreateBitmapFromSectionEx<TI0>(uint width, uint height, ref Guid pixelFormat, void* hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateBitmapFromSectionEx(width, height, ref pixelFormat, hSection, stride, offset, desiredAccessLevel, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        public unsafe int CreateBitmapFromSectionEx<T0, TI0>(uint width, uint height, ref Guid pixelFormat, ref T0 hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, ref ComPtr<TI0> ppIBitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateBitmapFromSectionEx(width, height, ref pixelFormat, ref hSection, stride, offset, desiredAccessLevel, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8505, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy<TI0>(ComPtr<TI0> This, RawCapabilitiesInfo* pInfo) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy((IWICDevelopRaw*) This.Handle, pInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8505, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy<TI0>(ComPtr<TI0> This, ref RawCapabilitiesInfo pInfo) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy((IWICDevelopRaw*) This.Handle, ref pInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8517, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawRemoteSetToneCurveProxy<TI0>(ComPtr<TI0> This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurvePoint* aPoints) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawRemoteSetToneCurveProxy((IWICDevelopRaw*) This.Handle, cPoints, aPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8517, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawRemoteSetToneCurveProxy<TI0>(ComPtr<TI0> This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RawToneCurvePoint aPoints) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawRemoteSetToneCurveProxy((IWICDevelopRaw*) This.Handle, cPoints, in aPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawRemoteGetToneCurveProxy<TI0>(ComPtr<TI0> This, uint* pcPoints, RawToneCurvePoint** paPoints) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawRemoteGetToneCurveProxy((IWICDevelopRaw*) This.Handle, pcPoints, paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawRemoteGetToneCurveProxy<TI0>(ComPtr<TI0> This, uint* pcPoints, ref RawToneCurvePoint* paPoints) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawRemoteGetToneCurveProxy((IWICDevelopRaw*) This.Handle, pcPoints, ref paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawRemoteGetToneCurveProxy<TI0>(ComPtr<TI0> This, ref uint pcPoints, RawToneCurvePoint** paPoints) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawRemoteGetToneCurveProxy((IWICDevelopRaw*) This.Handle, ref pcPoints, paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawRemoteGetToneCurveProxy<TI0>(ComPtr<TI0> This, ref uint pcPoints, ref RawToneCurvePoint* paPoints) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawRemoteGetToneCurveProxy((IWICDevelopRaw*) This.Handle, ref pcPoints, ref paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9275, Column 39 in wincodec.h")]
        public unsafe uint BSTRUserSize(uint* arg0, uint arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserSize(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9275, Column 39 in wincodec.h")]
        public unsafe uint BSTRUserSize(ref uint arg0, uint arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserSize(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public unsafe byte* BSTRUserMarshal(uint* arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserMarshal(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string BSTRUserMarshalS(uint* arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserMarshalS(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public unsafe byte* BSTRUserMarshal(uint* arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserMarshal(arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string BSTRUserMarshalS(uint* arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserMarshalS(arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public unsafe byte* BSTRUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserMarshal(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string BSTRUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserMarshalS(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public unsafe byte* BSTRUserMarshal(ref uint arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserMarshal(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string BSTRUserMarshalS(ref uint arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserMarshalS(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public unsafe byte* BSTRUserMarshal(ref uint arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserMarshal(ref arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string BSTRUserMarshalS(ref uint arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserMarshalS(ref arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public unsafe byte* BSTRUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserMarshal(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string BSTRUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserMarshalS(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public unsafe byte* BSTRUserUnmarshal(uint* arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserUnmarshal(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string BSTRUserUnmarshalS(uint* arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserUnmarshalS(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public unsafe byte* BSTRUserUnmarshal(uint* arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserUnmarshal(arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string BSTRUserUnmarshalS(uint* arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserUnmarshalS(arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public unsafe byte* BSTRUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserUnmarshal(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string BSTRUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserUnmarshalS(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public unsafe byte* BSTRUserUnmarshal(ref uint arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserUnmarshal(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string BSTRUserUnmarshalS(ref uint arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserUnmarshalS(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public unsafe byte* BSTRUserUnmarshal(ref uint arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserUnmarshal(ref arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string BSTRUserUnmarshalS(ref uint arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserUnmarshalS(ref arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public unsafe byte* BSTRUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserUnmarshal(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string BSTRUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (char**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = BSTRUserUnmarshalS(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9278, Column 39 in wincodec.h")]
        public unsafe void BSTRUserFree(uint* arg0, string[] arg1Sa)
        {
            // StringArrayOverloader
            var arg1 = (char**) SilkMarshal.StringArrayToPtr(arg1Sa);
            BSTRUserFree(arg0, arg1);
            SilkMarshal.CopyPtrToStringArray((nint) arg1, arg1Sa);
            SilkMarshal.Free((nint) arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9278, Column 39 in wincodec.h")]
        public unsafe void BSTRUserFree(ref uint arg0, string[] arg1Sa)
        {
            // StringArrayOverloader
            var arg1 = (char**) SilkMarshal.StringArrayToPtr(arg1Sa);
            BSTRUserFree(ref arg0, arg1);
            SilkMarshal.CopyPtrToStringArray((nint) arg1, arg1Sa);
            SilkMarshal.Free((nint) arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9300, Column 39 in wincodec.h")]
        public unsafe uint InProcPointerUserSize(uint* arg0, uint arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserSize(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9300, Column 39 in wincodec.h")]
        public unsafe uint InProcPointerUserSize(ref uint arg0, uint arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserSize(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public unsafe byte* InProcPointerUserMarshal(uint* arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserMarshal(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string InProcPointerUserMarshalS(uint* arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserMarshalS(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public unsafe byte* InProcPointerUserMarshal(uint* arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserMarshal(arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string InProcPointerUserMarshalS(uint* arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserMarshalS(arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public unsafe byte* InProcPointerUserMarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserMarshal(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string InProcPointerUserMarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserMarshalS(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public unsafe byte* InProcPointerUserMarshal(ref uint arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserMarshal(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string InProcPointerUserMarshalS(ref uint arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserMarshalS(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public unsafe byte* InProcPointerUserMarshal(ref uint arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserMarshal(ref arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string InProcPointerUserMarshalS(ref uint arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserMarshalS(ref arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public unsafe byte* InProcPointerUserMarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserMarshal(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string InProcPointerUserMarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserMarshalS(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public unsafe byte* InProcPointerUserUnmarshal(uint* arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserUnmarshal(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string InProcPointerUserUnmarshalS(uint* arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserUnmarshalS(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public unsafe byte* InProcPointerUserUnmarshal(uint* arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserUnmarshal(arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string InProcPointerUserUnmarshalS(uint* arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserUnmarshalS(arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public unsafe byte* InProcPointerUserUnmarshal(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserUnmarshal(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string InProcPointerUserUnmarshalS(uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserUnmarshalS(arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public unsafe byte* InProcPointerUserUnmarshal(ref uint arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserUnmarshal(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string InProcPointerUserUnmarshalS(ref uint arg0, byte* arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserUnmarshalS(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public unsafe byte* InProcPointerUserUnmarshal(ref uint arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserUnmarshal(ref arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string InProcPointerUserUnmarshalS(ref uint arg0, ref byte arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserUnmarshalS(ref arg0, ref arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public unsafe byte* InProcPointerUserUnmarshal(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserUnmarshal(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public unsafe string InProcPointerUserUnmarshalS(ref uint arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, string[] arg2Sa)
        {
            // StringArrayOverloader
            var arg2 = (byte**) SilkMarshal.StringArrayToPtr(arg2Sa);
            var ret = InProcPointerUserUnmarshalS(ref arg0, arg1, arg2);
            SilkMarshal.CopyPtrToStringArray((nint) arg2, arg2Sa);
            SilkMarshal.Free((nint) arg2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9303, Column 39 in wincodec.h")]
        public unsafe void InProcPointerUserFree(uint* arg0, string[] arg1Sa)
        {
            // StringArrayOverloader
            var arg1 = (byte**) SilkMarshal.StringArrayToPtr(arg1Sa);
            InProcPointerUserFree(arg0, arg1);
            SilkMarshal.CopyPtrToStringArray((nint) arg1, arg1Sa);
            SilkMarshal.Free((nint) arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9303, Column 39 in wincodec.h")]
        public unsafe void InProcPointerUserFree(ref uint arg0, string[] arg1Sa)
        {
            // StringArrayOverloader
            var arg1 = (byte**) SilkMarshal.StringArrayToPtr(arg1Sa);
            InProcPointerUserFree(ref arg0, arg1);
            SilkMarshal.CopyPtrToStringArray((nint) arg1, arg1Sa);
            SilkMarshal.Free((nint) arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9305, Column 41 in wincodec.h")]
        public unsafe int IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy<TI0>(ComPtr<TI0> This, PfnProgressNotification pfnProgressNotification, void* pvData, uint dwProgressFlags) where TI0 : unmanaged, IComVtbl<IWICBitmapCodecProgressNotification>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy((IWICBitmapCodecProgressNotification*) This.Handle, pfnProgressNotification, pvData, dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9305, Column 41 in wincodec.h")]
        public unsafe int IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy<T0, TI0>(ComPtr<TI0> This, PfnProgressNotification pfnProgressNotification, ref T0 pvData, uint dwProgressFlags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IWICBitmapCodecProgressNotification>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy((IWICBitmapCodecProgressNotification*) This.Handle, pfnProgressNotification, ref pvData, dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9314, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub<TI0, TI1>(ComPtr<TI0> This, ComPtr<TI1> pICallback, uint dwProgressFlags) where TI0 : unmanaged, IComVtbl<IWICBitmapCodecProgressNotification>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICProgressCallback>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub((IWICBitmapCodecProgressNotification*) This.Handle, (IWICProgressCallback*) pICallback.Handle, dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9314, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub<TI0>(ComPtr<TI0> This, ref IWICProgressCallback pICallback, uint dwProgressFlags) where TI0 : unmanaged, IComVtbl<IWICBitmapCodecProgressNotification>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub((IWICBitmapCodecProgressNotification*) This.Handle, ref pICallback, dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9314, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub<TI0>(ref IWICBitmapCodecProgressNotification This, ComPtr<TI0> pICallback, uint dwProgressFlags) where TI0 : unmanaged, IComVtbl<IWICProgressCallback>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub(ref This, (IWICProgressCallback*) pICallback.Handle, dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, uint cbSizePatterns, BitmapPattern* pPatterns, uint* pcPatterns, uint* pcbPatternsActual) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoGetPatternsProxy((IWICBitmapDecoderInfo*) This.Handle, cbSizePatterns, pPatterns, pcPatterns, pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, uint cbSizePatterns, BitmapPattern* pPatterns, uint* pcPatterns, ref uint pcbPatternsActual) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoGetPatternsProxy((IWICBitmapDecoderInfo*) This.Handle, cbSizePatterns, pPatterns, pcPatterns, ref pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, uint cbSizePatterns, BitmapPattern* pPatterns, ref uint pcPatterns, uint* pcbPatternsActual) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoGetPatternsProxy((IWICBitmapDecoderInfo*) This.Handle, cbSizePatterns, pPatterns, ref pcPatterns, pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, uint cbSizePatterns, BitmapPattern* pPatterns, ref uint pcPatterns, ref uint pcbPatternsActual) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoGetPatternsProxy((IWICBitmapDecoderInfo*) This.Handle, cbSizePatterns, pPatterns, ref pcPatterns, ref pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, uint cbSizePatterns, ref BitmapPattern pPatterns, uint* pcPatterns, uint* pcbPatternsActual) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoGetPatternsProxy((IWICBitmapDecoderInfo*) This.Handle, cbSizePatterns, ref pPatterns, pcPatterns, pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, uint cbSizePatterns, ref BitmapPattern pPatterns, uint* pcPatterns, ref uint pcbPatternsActual) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoGetPatternsProxy((IWICBitmapDecoderInfo*) This.Handle, cbSizePatterns, ref pPatterns, pcPatterns, ref pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, uint cbSizePatterns, ref BitmapPattern pPatterns, ref uint pcPatterns, uint* pcbPatternsActual) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoGetPatternsProxy((IWICBitmapDecoderInfo*) This.Handle, cbSizePatterns, ref pPatterns, ref pcPatterns, pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, uint cbSizePatterns, ref BitmapPattern pPatterns, ref uint pcPatterns, ref uint pcbPatternsActual) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoGetPatternsProxy((IWICBitmapDecoderInfo*) This.Handle, cbSizePatterns, ref pPatterns, ref pcPatterns, ref pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoGetPatternsStub<TI0>(ComPtr<TI0> This, BitmapPattern** ppPatterns, uint* pcPatterns) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoGetPatternsStub((IWICBitmapDecoderInfo*) This.Handle, ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoGetPatternsStub<TI0>(ComPtr<TI0> This, BitmapPattern** ppPatterns, ref uint pcPatterns) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoGetPatternsStub((IWICBitmapDecoderInfo*) This.Handle, ppPatterns, ref pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoGetPatternsStub<TI0>(ComPtr<TI0> This, ref BitmapPattern* ppPatterns, uint* pcPatterns) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoGetPatternsStub((IWICBitmapDecoderInfo*) This.Handle, ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        public unsafe int IWICBitmapDecoderInfoGetPatternsStub<TI0>(ComPtr<TI0> This, ref BitmapPattern* ppPatterns, ref uint pcPatterns) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICBitmapDecoderInfoGetPatternsStub((IWICBitmapDecoderInfo*) This.Handle, ref ppPatterns, ref pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9335, Column 41 in wincodec.h")]
        public unsafe int IWICDevelopRawQueryRawCapabilitiesInfoProxy<TI0>(ComPtr<TI0> This, RawCapabilitiesInfo* pInfo) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawQueryRawCapabilitiesInfoProxy((IWICDevelopRaw*) This.Handle, pInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9335, Column 41 in wincodec.h")]
        public unsafe int IWICDevelopRawQueryRawCapabilitiesInfoProxy<TI0>(ComPtr<TI0> This, ref RawCapabilitiesInfo pInfo) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawQueryRawCapabilitiesInfoProxy((IWICDevelopRaw*) This.Handle, ref pInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9340, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawQueryRawCapabilitiesInfoStub<TI0>(ComPtr<TI0> This, RawCapabilitiesInfo* pInfo) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawQueryRawCapabilitiesInfoStub((IWICDevelopRaw*) This.Handle, pInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9340, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawQueryRawCapabilitiesInfoStub<TI0>(ComPtr<TI0> This, ref RawCapabilitiesInfo pInfo) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawQueryRawCapabilitiesInfoStub((IWICDevelopRaw*) This.Handle, ref pInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9344, Column 41 in wincodec.h")]
        public unsafe int IWICDevelopRawSetToneCurveProxy<TI0>(ComPtr<TI0> This, uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurve* pToneCurve) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawSetToneCurveProxy((IWICDevelopRaw*) This.Handle, cbToneCurveSize, pToneCurve);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9344, Column 41 in wincodec.h")]
        public unsafe int IWICDevelopRawSetToneCurveProxy<TI0>(ComPtr<TI0> This, uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RawToneCurve pToneCurve) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawSetToneCurveProxy((IWICDevelopRaw*) This.Handle, cbToneCurveSize, in pToneCurve);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9351, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawSetToneCurveStub<TI0>(ComPtr<TI0> This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurvePoint* aPoints) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawSetToneCurveStub((IWICDevelopRaw*) This.Handle, cPoints, aPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9351, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawSetToneCurveStub<TI0>(ComPtr<TI0> This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RawToneCurvePoint aPoints) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawSetToneCurveStub((IWICDevelopRaw*) This.Handle, cPoints, in aPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        public unsafe int IWICDevelopRawGetToneCurveProxy<TI0>(ComPtr<TI0> This, uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, uint* pcbActualToneCurveBufferSize) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawGetToneCurveProxy((IWICDevelopRaw*) This.Handle, cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        public unsafe int IWICDevelopRawGetToneCurveProxy<TI0>(ComPtr<TI0> This, uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, ref uint pcbActualToneCurveBufferSize) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawGetToneCurveProxy((IWICDevelopRaw*) This.Handle, cbToneCurveBufferSize, pToneCurve, ref pcbActualToneCurveBufferSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        public unsafe int IWICDevelopRawGetToneCurveProxy<TI0>(ComPtr<TI0> This, uint cbToneCurveBufferSize, ref RawToneCurve pToneCurve, uint* pcbActualToneCurveBufferSize) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawGetToneCurveProxy((IWICDevelopRaw*) This.Handle, cbToneCurveBufferSize, ref pToneCurve, pcbActualToneCurveBufferSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        public unsafe int IWICDevelopRawGetToneCurveProxy<TI0>(ComPtr<TI0> This, uint cbToneCurveBufferSize, ref RawToneCurve pToneCurve, ref uint pcbActualToneCurveBufferSize) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawGetToneCurveProxy((IWICDevelopRaw*) This.Handle, cbToneCurveBufferSize, ref pToneCurve, ref pcbActualToneCurveBufferSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawGetToneCurveStub<TI0>(ComPtr<TI0> This, uint* pcPoints, RawToneCurvePoint** paPoints) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawGetToneCurveStub((IWICDevelopRaw*) This.Handle, pcPoints, paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawGetToneCurveStub<TI0>(ComPtr<TI0> This, uint* pcPoints, ref RawToneCurvePoint* paPoints) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawGetToneCurveStub((IWICDevelopRaw*) This.Handle, pcPoints, ref paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawGetToneCurveStub<TI0>(ComPtr<TI0> This, ref uint pcPoints, RawToneCurvePoint** paPoints) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawGetToneCurveStub((IWICDevelopRaw*) This.Handle, ref pcPoints, paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        public unsafe int IWICDevelopRawGetToneCurveStub<TI0>(ComPtr<TI0> This, ref uint pcPoints, ref RawToneCurvePoint* paPoints) where TI0 : unmanaged, IComVtbl<IWICDevelopRaw>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICDevelopRawGetToneCurveStub((IWICDevelopRaw*) This.Handle, ref pcPoints, ref paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoRemoteGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, ref uint pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoRemoteGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, ppPatterns, ref pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoRemoteGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, ref uint pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoRemoteGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, ref ppPatterns, ref pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoRemoteGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, MetadataPattern** ppPatterns, ref uint pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoRemoteGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, ppPatterns, ref pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoRemoteGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, ref MetadataPattern* ppPatterns, ref uint pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoRemoteGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, ref ppPatterns, ref pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoRemoteGetHeaderProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, MetadataHeader* pHeader) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoRemoteGetHeaderProxy((IWICMetadataWriterInfo*) This.Handle, guidContainerFormat, pHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoRemoteGetHeaderProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, ref MetadataHeader pHeader) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoRemoteGetHeaderProxy((IWICMetadataWriterInfo*) This.Handle, guidContainerFormat, ref pHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoRemoteGetHeaderProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, MetadataHeader* pHeader) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoRemoteGetHeaderProxy((IWICMetadataWriterInfo*) This.Handle, ref guidContainerFormat, pHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoRemoteGetHeaderProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, ref MetadataHeader pHeader) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoRemoteGetHeaderProxy((IWICMetadataWriterInfo*) This.Handle, ref guidContainerFormat, ref pHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public unsafe int MatchMetadataContent<TI0>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ComPtr<TI0> pIStream, Guid* pguidMetadataFormat) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return MatchMetadataContent(guidContainerFormat, pguidVendor, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public unsafe int MatchMetadataContent<TI0>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ComPtr<TI0> pIStream, ref Guid pguidMetadataFormat) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return MatchMetadataContent(guidContainerFormat, pguidVendor, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public unsafe int MatchMetadataContent<TI0>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ComPtr<TI0> pIStream, Guid* pguidMetadataFormat) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return MatchMetadataContent(guidContainerFormat, in pguidVendor, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public unsafe int MatchMetadataContent<TI0>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ComPtr<TI0> pIStream, ref Guid pguidMetadataFormat) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return MatchMetadataContent(guidContainerFormat, in pguidVendor, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public unsafe int MatchMetadataContent<TI0>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ComPtr<TI0> pIStream, Guid* pguidMetadataFormat) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return MatchMetadataContent(ref guidContainerFormat, pguidVendor, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public unsafe int MatchMetadataContent<TI0>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ComPtr<TI0> pIStream, ref Guid pguidMetadataFormat) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return MatchMetadataContent(ref guidContainerFormat, pguidVendor, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public unsafe int MatchMetadataContent<TI0>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ComPtr<TI0> pIStream, Guid* pguidMetadataFormat) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return MatchMetadataContent(ref guidContainerFormat, in pguidVendor, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public unsafe int MatchMetadataContent<TI0>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ComPtr<TI0> pIStream, ref Guid pguidMetadataFormat) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return MatchMetadataContent(ref guidContainerFormat, in pguidVendor, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        public unsafe int SerializeMetadataContent<TI0, TI1>(Guid* guidContainerFormat, ComPtr<TI0> pIWriter, uint dwPersistOptions, ComPtr<TI1> pIStream) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return SerializeMetadataContent(guidContainerFormat, (IWICMetadataWriter*) pIWriter.Handle, dwPersistOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        public unsafe int SerializeMetadataContent<TI0>(Guid* guidContainerFormat, ComPtr<TI0> pIWriter, uint dwPersistOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SerializeMetadataContent(guidContainerFormat, (IWICMetadataWriter*) pIWriter.Handle, dwPersistOptions, ref pIStream);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        public unsafe int SerializeMetadataContent<TI0>(Guid* guidContainerFormat, ref IWICMetadataWriter pIWriter, uint dwPersistOptions, ComPtr<TI0> pIStream) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SerializeMetadataContent(guidContainerFormat, ref pIWriter, dwPersistOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        public unsafe int SerializeMetadataContent<TI0, TI1>(ref Guid guidContainerFormat, ComPtr<TI0> pIWriter, uint dwPersistOptions, ComPtr<TI1> pIStream) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return SerializeMetadataContent(ref guidContainerFormat, (IWICMetadataWriter*) pIWriter.Handle, dwPersistOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        public unsafe int SerializeMetadataContent<TI0>(ref Guid guidContainerFormat, ComPtr<TI0> pIWriter, uint dwPersistOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SerializeMetadataContent(ref guidContainerFormat, (IWICMetadataWriter*) pIWriter.Handle, dwPersistOptions, ref pIStream);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        public unsafe int SerializeMetadataContent<TI0>(ref Guid guidContainerFormat, ref IWICMetadataWriter pIWriter, uint dwPersistOptions, ComPtr<TI0> pIStream) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SerializeMetadataContent(ref guidContainerFormat, ref pIWriter, dwPersistOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        public unsafe int GetMetadataContentSize<TI0>(Guid* guidContainerFormat, ComPtr<TI0> pIWriter, ulong* pcbSize) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return GetMetadataContentSize(guidContainerFormat, (IWICMetadataWriter*) pIWriter.Handle, pcbSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        public unsafe int GetMetadataContentSize<TI0>(Guid* guidContainerFormat, ComPtr<TI0> pIWriter, ref ulong pcbSize) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return GetMetadataContentSize(guidContainerFormat, (IWICMetadataWriter*) pIWriter.Handle, ref pcbSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        public unsafe int GetMetadataContentSize<TI0>(ref Guid guidContainerFormat, ComPtr<TI0> pIWriter, ulong* pcbSize) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return GetMetadataContentSize(ref guidContainerFormat, (IWICMetadataWriter*) pIWriter.Handle, pcbSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        public unsafe int GetMetadataContentSize<TI0>(ref Guid guidContainerFormat, ComPtr<TI0> pIWriter, ref ulong pcbSize) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return GetMetadataContentSize(ref guidContainerFormat, (IWICMetadataWriter*) pIWriter.Handle, ref pcbSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, cbSize, pPattern, pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, ref uint pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, cbSize, pPattern, pcCount, ref pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, uint* pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, cbSize, pPattern, ref pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, ref uint pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, cbSize, pPattern, ref pcCount, ref pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, uint* pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, cbSize, ref pPattern, pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, ref uint pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, cbSize, ref pPattern, pcCount, ref pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, uint* pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, cbSize, ref pPattern, ref pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, ref uint pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, cbSize, ref pPattern, ref pcCount, ref pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, cbSize, pPattern, pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, ref uint pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, cbSize, pPattern, pcCount, ref pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, uint* pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, cbSize, pPattern, ref pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, ref uint pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, cbSize, pPattern, ref pcCount, ref pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, uint* pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, cbSize, ref pPattern, pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, ref uint pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, cbSize, ref pPattern, pcCount, ref pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, uint* pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, cbSize, ref pPattern, ref pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, ref uint pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsProxy((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, cbSize, ref pPattern, ref pcCount, ref pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsStub<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsStub((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsStub<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, ref uint pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsStub((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, ppPatterns, ref pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsStub<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsStub((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsStub<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, ref uint pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsStub((IWICMetadataReaderInfo*) This.Handle, guidContainerFormat, ref ppPatterns, ref pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsStub<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsStub((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsStub<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, MetadataPattern** ppPatterns, ref uint pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsStub((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, ppPatterns, ref pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsStub<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsStub((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataReaderInfoGetPatternsStub<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, ref MetadataPattern* ppPatterns, ref uint pcPatterns) where TI0 : unmanaged, IComVtbl<IWICMetadataReaderInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataReaderInfoGetPatternsStub((IWICMetadataReaderInfo*) This.Handle, ref guidContainerFormat, ref ppPatterns, ref pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoGetHeaderProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, uint cbSize, MetadataHeader* pHeader, uint* pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoGetHeaderProxy((IWICMetadataWriterInfo*) This.Handle, guidContainerFormat, cbSize, pHeader, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoGetHeaderProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, uint cbSize, MetadataHeader* pHeader, ref uint pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoGetHeaderProxy((IWICMetadataWriterInfo*) This.Handle, guidContainerFormat, cbSize, pHeader, ref pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoGetHeaderProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, uint cbSize, ref MetadataHeader pHeader, uint* pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoGetHeaderProxy((IWICMetadataWriterInfo*) This.Handle, guidContainerFormat, cbSize, ref pHeader, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoGetHeaderProxy<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, uint cbSize, ref MetadataHeader pHeader, ref uint pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoGetHeaderProxy((IWICMetadataWriterInfo*) This.Handle, guidContainerFormat, cbSize, ref pHeader, ref pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoGetHeaderProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, uint cbSize, MetadataHeader* pHeader, uint* pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoGetHeaderProxy((IWICMetadataWriterInfo*) This.Handle, ref guidContainerFormat, cbSize, pHeader, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoGetHeaderProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, uint cbSize, MetadataHeader* pHeader, ref uint pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoGetHeaderProxy((IWICMetadataWriterInfo*) This.Handle, ref guidContainerFormat, cbSize, pHeader, ref pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoGetHeaderProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, uint cbSize, ref MetadataHeader pHeader, uint* pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoGetHeaderProxy((IWICMetadataWriterInfo*) This.Handle, ref guidContainerFormat, cbSize, ref pHeader, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoGetHeaderProxy<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, uint cbSize, ref MetadataHeader pHeader, ref uint pcbActual) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoGetHeaderProxy((IWICMetadataWriterInfo*) This.Handle, ref guidContainerFormat, cbSize, ref pHeader, ref pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoGetHeaderStub<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, MetadataHeader* pHeader) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoGetHeaderStub((IWICMetadataWriterInfo*) This.Handle, guidContainerFormat, pHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoGetHeaderStub<TI0>(ComPtr<TI0> This, Guid* guidContainerFormat, ref MetadataHeader pHeader) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoGetHeaderStub((IWICMetadataWriterInfo*) This.Handle, guidContainerFormat, ref pHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoGetHeaderStub<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, MetadataHeader* pHeader) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoGetHeaderStub((IWICMetadataWriterInfo*) This.Handle, ref guidContainerFormat, pHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        public unsafe int IWICMetadataWriterInfoGetHeaderStub<TI0>(ComPtr<TI0> This, ref Guid guidContainerFormat, ref MetadataHeader pHeader) where TI0 : unmanaged, IComVtbl<IWICMetadataWriterInfo>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return IWICMetadataWriterInfoGetHeaderStub((IWICMetadataWriterInfo*) This.Handle, ref guidContainerFormat, ref pHeader);
        }


        public WindowsCodecs(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

