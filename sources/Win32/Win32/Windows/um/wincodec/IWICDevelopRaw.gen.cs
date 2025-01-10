// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FBEC5E44-F7BE-4B65-B7F8-C0C81FEF026D")]
[NativeTypeName("struct IWICDevelopRaw : IWICBitmapFrameDecode")]
[NativeInheritance("IWICBitmapFrameDecode")]
public unsafe partial struct IWICDevelopRaw : IWICDevelopRaw.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDevelopRaw));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICDevelopRaw, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICDevelopRaw, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSize(uint* puiWidth, uint* puiHeight)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, uint*, uint*, int>)((*lpVtbl)[3]))(
            this,
            puiWidth,
            puiHeight
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, Guid*, int>)((*lpVtbl)[4]))(
            this,
            pPixelFormat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetResolution(double* pDpiX, double* pDpiY)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double*, double*, int>)((*lpVtbl)[5]))(
            this,
            pDpiX,
            pDpiY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CopyPalette(IWICPalette pIPalette)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, IWICPalette, int>)((*lpVtbl)[6]))(
            this,
            pIPalette
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyPixels(
        [NativeTypeName("const WICRect *")] WICRect* prc,
        uint cbStride,
        uint cbBufferSize,
        byte* pbBuffer
    )
    {
        return (
            (delegate* unmanaged<IWICDevelopRaw, WICRect*, uint, uint, byte*, int>)((*lpVtbl)[7])
        )(this, prc, cbStride, cbBufferSize, pbBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMetadataQueryReader(IWICMetadataQueryReader* ppIMetadataQueryReader)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, IWICMetadataQueryReader*, int>)((*lpVtbl)[8]))(
            this,
            ppIMetadataQueryReader
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetColorContexts(
        uint cCount,
        IWICColorContext* ppIColorContexts,
        uint* pcActualCount
    )
    {
        return (
            (delegate* unmanaged<IWICDevelopRaw, uint, IWICColorContext*, uint*, int>)((*lpVtbl)[9])
        )(this, cCount, ppIColorContexts, pcActualCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetThumbnail(IWICBitmapSource* ppIThumbnail)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, IWICBitmapSource*, int>)((*lpVtbl)[10]))(
            this,
            ppIThumbnail
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT QueryRawCapabilitiesInfo(WICRawCapabilitiesInfo* pInfo)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, WICRawCapabilitiesInfo*, int>)((*lpVtbl)[11]))(
            this,
            pInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT LoadParameterSet(WICRawParameterSet ParameterSet)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, WICRawParameterSet, int>)((*lpVtbl)[12]))(
            this,
            ParameterSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCurrentParameterSet(IPropertyBag2* ppCurrentParameterSet)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, IPropertyBag2*, int>)((*lpVtbl)[13]))(
            this,
            ppCurrentParameterSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetExposureCompensation(double ev)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double, int>)((*lpVtbl)[14]))(this, ev);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetExposureCompensation(double* pEV)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double*, int>)((*lpVtbl)[15]))(this, pEV);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetWhitePointRGB(uint Red, uint Green, uint Blue)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, uint, uint, uint, int>)((*lpVtbl)[16]))(
            this,
            Red,
            Green,
            Blue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetWhitePointRGB(uint* pRed, uint* pGreen, uint* pBlue)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, uint*, uint*, uint*, int>)((*lpVtbl)[17]))(
            this,
            pRed,
            pGreen,
            pBlue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetNamedWhitePoint(WICNamedWhitePoint WhitePoint)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, WICNamedWhitePoint, int>)((*lpVtbl)[18]))(
            this,
            WhitePoint
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetNamedWhitePoint(WICNamedWhitePoint* pWhitePoint)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, WICNamedWhitePoint*, int>)((*lpVtbl)[19]))(
            this,
            pWhitePoint
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetWhitePointKelvin(uint WhitePointKelvin)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, uint, int>)((*lpVtbl)[20]))(
            this,
            WhitePointKelvin
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetWhitePointKelvin(uint* pWhitePointKelvin)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, uint*, int>)((*lpVtbl)[21]))(
            this,
            pWhitePointKelvin
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetKelvinRangeInfo(
        uint* pMinKelvinTemp,
        uint* pMaxKelvinTemp,
        uint* pKelvinTempStepValue
    )
    {
        return ((delegate* unmanaged<IWICDevelopRaw, uint*, uint*, uint*, int>)((*lpVtbl)[22]))(
            this,
            pMinKelvinTemp,
            pMaxKelvinTemp,
            pKelvinTempStepValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetContrast(double Contrast)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double, int>)((*lpVtbl)[23]))(this, Contrast);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetContrast(double* pContrast)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double*, int>)((*lpVtbl)[24]))(
            this,
            pContrast
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetGamma(double Gamma)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double, int>)((*lpVtbl)[25]))(this, Gamma);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetGamma(double* pGamma)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double*, int>)((*lpVtbl)[26]))(this, pGamma);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetSharpness(double Sharpness)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double, int>)((*lpVtbl)[27]))(this, Sharpness);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetSharpness(double* pSharpness)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double*, int>)((*lpVtbl)[28]))(
            this,
            pSharpness
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetSaturation(double Saturation)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double, int>)((*lpVtbl)[29]))(
            this,
            Saturation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetSaturation(double* pSaturation)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double*, int>)((*lpVtbl)[30]))(
            this,
            pSaturation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetTint(double Tint)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double, int>)((*lpVtbl)[31]))(this, Tint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetTint(double* pTint)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double*, int>)((*lpVtbl)[32]))(this, pTint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SetNoiseReduction(double NoiseReduction)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double, int>)((*lpVtbl)[33]))(
            this,
            NoiseReduction
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetNoiseReduction(double* pNoiseReduction)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double*, int>)((*lpVtbl)[34]))(
            this,
            pNoiseReduction
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SetDestinationColorContext(IWICColorContext pColorContext)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, IWICColorContext, int>)((*lpVtbl)[35]))(
            this,
            pColorContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT SetToneCurve(
        uint cbToneCurveSize,
        [NativeTypeName("const WICRawToneCurve *")] WICRawToneCurve* pToneCurve
    )
    {
        return ((delegate* unmanaged<IWICDevelopRaw, uint, WICRawToneCurve*, int>)((*lpVtbl)[36]))(
            this,
            cbToneCurveSize,
            pToneCurve
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT GetToneCurve(
        uint cbToneCurveBufferSize,
        WICRawToneCurve* pToneCurve,
        uint* pcbActualToneCurveBufferSize
    )
    {
        return (
            (delegate* unmanaged<IWICDevelopRaw, uint, WICRawToneCurve*, uint*, int>)((*lpVtbl)[37])
        )(this, cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT SetRotation(double Rotation)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double, int>)((*lpVtbl)[38]))(this, Rotation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT GetRotation(double* pRotation)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, double*, int>)((*lpVtbl)[39]))(
            this,
            pRotation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT SetRenderMode(WICRawRenderMode RenderMode)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, WICRawRenderMode, int>)((*lpVtbl)[40]))(
            this,
            RenderMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT GetRenderMode(WICRawRenderMode* pRenderMode)
    {
        return ((delegate* unmanaged<IWICDevelopRaw, WICRawRenderMode*, int>)((*lpVtbl)[41]))(
            this,
            pRenderMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT SetNotificationCallback(IWICDevelopRawNotificationCallback pCallback)
    {
        return (
            (delegate* unmanaged<IWICDevelopRaw, IWICDevelopRawNotificationCallback, int>)(
                (*lpVtbl)[42]
            )
        )(this, pCallback);
    }

    public interface Interface : IWICBitmapFrameDecode.Interface
    {
        [VtblIndex(11)]
        HRESULT QueryRawCapabilitiesInfo(WICRawCapabilitiesInfo* pInfo);

        [VtblIndex(12)]
        HRESULT LoadParameterSet(WICRawParameterSet ParameterSet);

        [VtblIndex(13)]
        HRESULT GetCurrentParameterSet(IPropertyBag2* ppCurrentParameterSet);

        [VtblIndex(14)]
        HRESULT SetExposureCompensation(double ev);

        [VtblIndex(15)]
        HRESULT GetExposureCompensation(double* pEV);

        [VtblIndex(16)]
        HRESULT SetWhitePointRGB(uint Red, uint Green, uint Blue);

        [VtblIndex(17)]
        HRESULT GetWhitePointRGB(uint* pRed, uint* pGreen, uint* pBlue);

        [VtblIndex(18)]
        HRESULT SetNamedWhitePoint(WICNamedWhitePoint WhitePoint);

        [VtblIndex(19)]
        HRESULT GetNamedWhitePoint(WICNamedWhitePoint* pWhitePoint);

        [VtblIndex(20)]
        HRESULT SetWhitePointKelvin(uint WhitePointKelvin);

        [VtblIndex(21)]
        HRESULT GetWhitePointKelvin(uint* pWhitePointKelvin);

        [VtblIndex(22)]
        HRESULT GetKelvinRangeInfo(
            uint* pMinKelvinTemp,
            uint* pMaxKelvinTemp,
            uint* pKelvinTempStepValue
        );

        [VtblIndex(23)]
        HRESULT SetContrast(double Contrast);

        [VtblIndex(24)]
        HRESULT GetContrast(double* pContrast);

        [VtblIndex(25)]
        HRESULT SetGamma(double Gamma);

        [VtblIndex(26)]
        HRESULT GetGamma(double* pGamma);

        [VtblIndex(27)]
        HRESULT SetSharpness(double Sharpness);

        [VtblIndex(28)]
        HRESULT GetSharpness(double* pSharpness);

        [VtblIndex(29)]
        HRESULT SetSaturation(double Saturation);

        [VtblIndex(30)]
        HRESULT GetSaturation(double* pSaturation);

        [VtblIndex(31)]
        HRESULT SetTint(double Tint);

        [VtblIndex(32)]
        HRESULT GetTint(double* pTint);

        [VtblIndex(33)]
        HRESULT SetNoiseReduction(double NoiseReduction);

        [VtblIndex(34)]
        HRESULT GetNoiseReduction(double* pNoiseReduction);

        [VtblIndex(35)]
        HRESULT SetDestinationColorContext(IWICColorContext pColorContext);

        [VtblIndex(36)]
        HRESULT SetToneCurve(
            uint cbToneCurveSize,
            [NativeTypeName("const WICRawToneCurve *")] WICRawToneCurve* pToneCurve
        );

        [VtblIndex(37)]
        HRESULT GetToneCurve(
            uint cbToneCurveBufferSize,
            WICRawToneCurve* pToneCurve,
            uint* pcbActualToneCurveBufferSize
        );

        [VtblIndex(38)]
        HRESULT SetRotation(double Rotation);

        [VtblIndex(39)]
        HRESULT GetRotation(double* pRotation);

        [VtblIndex(40)]
        HRESULT SetRenderMode(WICRawRenderMode RenderMode);

        [VtblIndex(41)]
        HRESULT GetRenderMode(WICRawRenderMode* pRenderMode);

        [VtblIndex(42)]
        HRESULT SetNotificationCallback(IWICDevelopRawNotificationCallback pCallback);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetSize;

        [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetPixelFormat;

        [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, double*, int> GetResolution;

        [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICPalette, int> CopyPalette;

        [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;

        [NativeTypeName("HRESULT (IWICMetadataQueryReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICMetadataQueryReader*, int> GetMetadataQueryReader;

        [NativeTypeName("HRESULT (UINT, IWICColorContext **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IWICColorContext*, uint*, int> GetColorContexts;

        [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource*, int> GetThumbnail;

        [NativeTypeName("HRESULT (WICRawCapabilitiesInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICRawCapabilitiesInfo*, int> QueryRawCapabilitiesInfo;

        [NativeTypeName("HRESULT (WICRawParameterSet) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICRawParameterSet, int> LoadParameterSet;

        [NativeTypeName("HRESULT (IPropertyBag2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyBag2*, int> GetCurrentParameterSet;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetExposureCompensation;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetExposureCompensation;

        [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> SetWhitePointRGB;

        [NativeTypeName("HRESULT (UINT *, UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, uint*, int> GetWhitePointRGB;

        [NativeTypeName("HRESULT (WICNamedWhitePoint) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICNamedWhitePoint, int> SetNamedWhitePoint;

        [NativeTypeName("HRESULT (WICNamedWhitePoint *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICNamedWhitePoint*, int> GetNamedWhitePoint;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetWhitePointKelvin;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetWhitePointKelvin;

        [NativeTypeName("HRESULT (UINT *, UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, uint*, int> GetKelvinRangeInfo;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetContrast;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetContrast;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetGamma;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetGamma;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetSharpness;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetSharpness;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetSaturation;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetSaturation;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetTint;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetTint;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetNoiseReduction;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetNoiseReduction;

        [NativeTypeName("HRESULT (IWICColorContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICColorContext, int> SetDestinationColorContext;

        [NativeTypeName("HRESULT (UINT, const WICRawToneCurve *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WICRawToneCurve*, int> SetToneCurve;

        [NativeTypeName("HRESULT (UINT, WICRawToneCurve *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WICRawToneCurve*, uint*, int> GetToneCurve;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetRotation;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetRotation;

        [NativeTypeName("HRESULT (WICRawRenderMode) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICRawRenderMode, int> SetRenderMode;

        [NativeTypeName("HRESULT (WICRawRenderMode *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICRawRenderMode*, int> GetRenderMode;

        [NativeTypeName("HRESULT (IWICDevelopRawNotificationCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IWICDevelopRawNotificationCallback,
            int> SetNotificationCallback;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICDevelopRaw"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICDevelopRaw(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWICBitmapFrameDecode"/> to <see cref = "IWICDevelopRaw"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWICBitmapFrameDecode"/> instance to be converted </param>
    public static explicit operator IWICDevelopRaw(Silk.NET.Windows.IWICBitmapFrameDecode value)
    {
        return new IWICDevelopRaw(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICDevelopRaw"/> to <see cref = "Silk.NET.Windows.IWICBitmapFrameDecode"/>.</summary>
    /// <param name = "value">The <see cref = "IWICDevelopRaw"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWICBitmapFrameDecode(IWICDevelopRaw value)
    {
        return new Silk.NET.Windows.IWICBitmapFrameDecode(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWICBitmapSource"/> to <see cref = "IWICDevelopRaw"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWICBitmapSource"/> instance to be converted </param>
    public static explicit operator IWICDevelopRaw(Silk.NET.Windows.IWICBitmapSource value)
    {
        return new IWICDevelopRaw(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICDevelopRaw"/> to <see cref = "Silk.NET.Windows.IWICBitmapSource"/>.</summary>
    /// <param name = "value">The <see cref = "IWICDevelopRaw"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWICBitmapSource(IWICDevelopRaw value)
    {
        return new Silk.NET.Windows.IWICBitmapSource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICDevelopRaw"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICDevelopRaw(Silk.NET.Windows.IUnknown value)
    {
        return new IWICDevelopRaw(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICDevelopRaw"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICDevelopRaw"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICDevelopRaw value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
