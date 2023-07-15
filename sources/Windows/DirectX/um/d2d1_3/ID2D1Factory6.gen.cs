// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1Factory6.xml' path='doc/member[@name="ID2D1Factory6"]/*'/>
[Guid("F9976F46-F642-44C1-97CA-DA32EA2A2635")]
[NativeTypeName("struct ID2D1Factory6 : ID2D1Factory5")]
[NativeInheritance("ID2D1Factory5")]
public unsafe partial struct ID2D1Factory6 : ID2D1Factory6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Factory6));

    public void** lpVtbl;
    public HRESULT CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION &")] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, ID2D1DrawingStateBlock** drawingStateBlock)
    {
        return CreateDrawingStateBlock(drawingStateDescription, null, drawingStateBlock);
    }

    public HRESULT CreateDrawingStateBlock(ID2D1DrawingStateBlock** drawingStateBlock)
    {
        return CreateDrawingStateBlock(null, null, drawingStateBlock);
    }

    public HRESULT CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 &")] D2D1_DRAWING_STATE_DESCRIPTION1* drawingStateDescription, ID2D1DrawingStateBlock1** drawingStateBlock)
    {
        return CreateDrawingStateBlock(drawingStateDescription, null, drawingStateBlock);
    }

    public HRESULT CreateDrawingStateBlock(ID2D1DrawingStateBlock1** drawingStateBlock)
    {
        return CreateDrawingStateBlock(null, null, drawingStateBlock);
    }

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1Factory6*, uint> )(lpVtbl[1]))((ID2D1Factory6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1Factory6*, uint> )(lpVtbl[2]))((ID2D1Factory6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Factory.ReloadSystemMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReloadSystemMetrics()
    {
        return ((delegate* unmanaged<ID2D1Factory6*, int> )(lpVtbl[3]))((ID2D1Factory6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Factory.GetDesktopDpi"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [Obsolete("Deprecated. Use DisplayInformation::LogicalDpi for Windows Store Apps or GetDpiForWindow for desktop apps.")]
    public void GetDesktopDpi(float* dpiX, float* dpiY)
    {
        ((delegate* unmanaged<ID2D1Factory6*, float*, float*, void> )(lpVtbl[4]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dpiX, dpiY);
    }

    /// <inheritdoc cref = "ID2D1Factory.CreateRectangleGeometry"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateRectangleGeometry([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, D2D_RECT_F*, ID2D1RectangleGeometry**, int> )(lpVtbl[5]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), rectangle, rectangleGeometry);
    }

    /// <inheritdoc cref = "ID2D1Factory.CreateRoundedRectangleGeometry"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateRoundedRectangleGeometry([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, D2D1_ROUNDED_RECT*, ID2D1RoundedRectangleGeometry**, int> )(lpVtbl[6]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), roundedRectangle, roundedRectangleGeometry);
    }

    /// <inheritdoc cref = "ID2D1Factory.CreateEllipseGeometry"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateEllipseGeometry([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, D2D1_ELLIPSE*, ID2D1EllipseGeometry**, int> )(lpVtbl[7]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), ellipse, ellipseGeometry);
    }

    /// <inheritdoc cref = "ID2D1Factory.CreateGeometryGroup"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateGeometryGroup(D2D1_FILL_MODE fillMode, ID2D1Geometry** geometries, [NativeTypeName("UINT32")] uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, D2D1_FILL_MODE, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int> )(lpVtbl[8]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), fillMode, geometries, geometriesCount, geometryGroup);
    }

    /// <inheritdoc cref = "ID2D1Factory.CreateTransformedGeometry"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform, ID2D1TransformedGeometry** transformedGeometry)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, ID2D1Geometry*, D2D_MATRIX_3X2_F*, ID2D1TransformedGeometry**, int> )(lpVtbl[9]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), sourceGeometry, transform, transformedGeometry);
    }

    /// <inheritdoc cref = "ID2D1Factory.CreatePathGeometry"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreatePathGeometry(ID2D1PathGeometry** pathGeometry)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, ID2D1PathGeometry**, int> )(lpVtbl[10]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), pathGeometry);
    }

    /// <inheritdoc cref = "ID2D1Factory.CreateStrokeStyle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateStrokeStyle([NativeTypeName("const D2D1_STROKE_STYLE_PROPERTIES *")] D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1StrokeStyle** strokeStyle)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, D2D1_STROKE_STYLE_PROPERTIES*, float*, uint, ID2D1StrokeStyle**, int> )(lpVtbl[11]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
    }

    /// <inheritdoc cref = "ID2D1Factory.CreateDrawingStateBlock"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, D2D1_DRAWING_STATE_DESCRIPTION*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int> )(lpVtbl[12]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
    }

    /// <inheritdoc cref = "ID2D1Factory.CreateWicBitmapRenderTarget"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateWicBitmapRenderTarget(IWICBitmap* target, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, IWICBitmap*, D2D1_RENDER_TARGET_PROPERTIES*, ID2D1RenderTarget**, int> )(lpVtbl[13]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), target, renderTargetProperties, renderTarget);
    }

    /// <inheritdoc cref = "ID2D1Factory.CreateHwndRenderTarget"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateHwndRenderTarget([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("const D2D1_HWND_RENDER_TARGET_PROPERTIES *")] D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, D2D1_RENDER_TARGET_PROPERTIES*, D2D1_HWND_RENDER_TARGET_PROPERTIES*, ID2D1HwndRenderTarget**, int> )(lpVtbl[14]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
    }

    /// <inheritdoc cref = "ID2D1Factory.CreateDxgiSurfaceRenderTarget"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateDxgiSurfaceRenderTarget(IDXGISurface* dxgiSurface, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, IDXGISurface*, D2D1_RENDER_TARGET_PROPERTIES*, ID2D1RenderTarget**, int> )(lpVtbl[15]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiSurface, renderTargetProperties, renderTarget);
    }

    /// <inheritdoc cref = "ID2D1Factory.CreateDCRenderTarget"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateDCRenderTarget([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, D2D1_RENDER_TARGET_PROPERTIES*, ID2D1DCRenderTarget**, int> )(lpVtbl[16]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), renderTargetProperties, dcRenderTarget);
    }

    /// <inheritdoc cref = "ID2D1Factory1.CreateDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device** d2dDevice)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, IDXGIDevice*, ID2D1Device**, int> )(lpVtbl[17]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice);
    }

    /// <inheritdoc cref = "ID2D1Factory1.CreateStrokeStyle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateStrokeStyle([NativeTypeName("const D2D1_STROKE_STYLE_PROPERTIES1 *")] D2D1_STROKE_STYLE_PROPERTIES1* strokeStyleProperties, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1StrokeStyle1** strokeStyle)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, D2D1_STROKE_STYLE_PROPERTIES1*, float*, uint, ID2D1StrokeStyle1**, int> )(lpVtbl[18]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
    }

    /// <inheritdoc cref = "ID2D1Factory1.CreatePathGeometry"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreatePathGeometry(ID2D1PathGeometry1** pathGeometry)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, ID2D1PathGeometry1**, int> )(lpVtbl[19]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), pathGeometry);
    }

    /// <inheritdoc cref = "ID2D1Factory1.CreateDrawingStateBlock"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 *")] D2D1_DRAWING_STATE_DESCRIPTION1* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock1** drawingStateBlock)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, D2D1_DRAWING_STATE_DESCRIPTION1*, IDWriteRenderingParams*, ID2D1DrawingStateBlock1**, int> )(lpVtbl[20]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
    }

    /// <inheritdoc cref = "ID2D1Factory1.CreateGdiMetafile"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateGdiMetafile(IStream* metafileStream, ID2D1GdiMetafile** metafile)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, IStream*, ID2D1GdiMetafile**, int> )(lpVtbl[21]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), metafileStream, metafile);
    }

    /// <inheritdoc cref = "ID2D1Factory1.RegisterEffectFromStream"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT RegisterEffectFromStream([NativeTypeName("const IID &")] Guid* classId, IStream* propertyXml, [NativeTypeName("const D2D1_PROPERTY_BINDING *")] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, [NativeTypeName("const PD2D1_EFFECT_FACTORY")] delegate* unmanaged<IUnknown**, HRESULT> effectFactory)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, Guid*, IStream*, D2D1_PROPERTY_BINDING*, uint, delegate* unmanaged<IUnknown**, HRESULT> , int> )(lpVtbl[22]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), classId, propertyXml, bindings, bindingsCount, effectFactory);
    }

    /// <inheritdoc cref = "ID2D1Factory1.RegisterEffectFromString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT RegisterEffectFromString([NativeTypeName("const IID &")] Guid* classId, [NativeTypeName("PCWSTR")] ushort* propertyXml, [NativeTypeName("const D2D1_PROPERTY_BINDING *")] D2D1_PROPERTY_BINDING* bindings, [NativeTypeName("UINT32")] uint bindingsCount, [NativeTypeName("const PD2D1_EFFECT_FACTORY")] delegate* unmanaged<IUnknown**, HRESULT> effectFactory)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, Guid*, ushort*, D2D1_PROPERTY_BINDING*, uint, delegate* unmanaged<IUnknown**, HRESULT> , int> )(lpVtbl[23]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), classId, propertyXml, bindings, bindingsCount, effectFactory);
    }

    /// <inheritdoc cref = "ID2D1Factory1.UnregisterEffect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT UnregisterEffect([NativeTypeName("const IID &")] Guid* classId)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, Guid*, int> )(lpVtbl[24]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), classId);
    }

    /// <inheritdoc cref = "ID2D1Factory1.GetRegisteredEffects"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetRegisteredEffects([NativeTypeName("CLSID *")] Guid* effects, [NativeTypeName("UINT32")] uint effectsCount, [NativeTypeName("UINT32 *")] uint* effectsReturned, [NativeTypeName("UINT32 *")] uint* effectsRegistered)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, Guid*, uint, uint*, uint*, int> )(lpVtbl[25]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), effects, effectsCount, effectsReturned, effectsRegistered);
    }

    /// <inheritdoc cref = "ID2D1Factory1.GetEffectProperties"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetEffectProperties([NativeTypeName("const IID &")] Guid* effectId, ID2D1Properties** properties)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, Guid*, ID2D1Properties**, int> )(lpVtbl[26]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), effectId, properties);
    }

    /// <inheritdoc cref = "ID2D1Factory2.CreateDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device1** d2dDevice1)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, IDXGIDevice*, ID2D1Device1**, int> )(lpVtbl[27]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice1);
    }

    /// <inheritdoc cref = "ID2D1Factory3.CreateDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device2** d2dDevice2)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, IDXGIDevice*, ID2D1Device2**, int> )(lpVtbl[28]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice2);
    }

    /// <inheritdoc cref = "ID2D1Factory4.CreateDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device3** d2dDevice3)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, IDXGIDevice*, ID2D1Device3**, int> )(lpVtbl[29]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice3);
    }

    /// <inheritdoc cref = "ID2D1Factory5.CreateDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device4** d2dDevice4)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, IDXGIDevice*, ID2D1Device4**, int> )(lpVtbl[30]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice4);
    }

    /// <include file='ID2D1Factory6.xml' path='doc/member[@name="ID2D1Factory6.CreateDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device5** d2dDevice5)
    {
        return ((delegate* unmanaged<ID2D1Factory6*, IDXGIDevice*, ID2D1Device5**, int> )(lpVtbl[31]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice5);
    }

    public interface Interface : ID2D1Factory5.Interface
    {
        [VtblIndex(31)]
        HRESULT CreateDevice(IDXGIDevice* dxgiDevice, ID2D1Device5** d2dDevice5);
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
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReloadSystemMetrics;
        [NativeTypeName("void (FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        [Obsolete("Deprecated. Use DisplayInformation::LogicalDpi for Windows Store Apps or GetDpiForWindow for desktop apps.")]
        public delegate* unmanaged<TSelf*, float*, float*, void> GetDesktopDpi;
        [NativeTypeName("HRESULT (const D2D1_RECT_F *, ID2D1RectangleGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_RECT_F*, ID2D1RectangleGeometry**, int> CreateRectangleGeometry;
        [NativeTypeName("HRESULT (const D2D1_ROUNDED_RECT *, ID2D1RoundedRectangleGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_ROUNDED_RECT*, ID2D1RoundedRectangleGeometry**, int> CreateRoundedRectangleGeometry;
        [NativeTypeName("HRESULT (const D2D1_ELLIPSE *, ID2D1EllipseGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_ELLIPSE*, ID2D1EllipseGeometry**, int> CreateEllipseGeometry;
        [NativeTypeName("HRESULT (D2D1_FILL_MODE, ID2D1Geometry **, UINT32, ID2D1GeometryGroup **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_FILL_MODE, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int> CreateGeometryGroup;
        [NativeTypeName("HRESULT (ID2D1Geometry *, const D2D1_MATRIX_3X2_F *, ID2D1TransformedGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Geometry*, D2D_MATRIX_3X2_F*, ID2D1TransformedGeometry**, int> CreateTransformedGeometry;
        [NativeTypeName("HRESULT (ID2D1PathGeometry **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1PathGeometry**, int> CreatePathGeometry;
        [NativeTypeName("HRESULT (const D2D1_STROKE_STYLE_PROPERTIES *, const FLOAT *, UINT32, ID2D1StrokeStyle **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_STROKE_STYLE_PROPERTIES*, float*, uint, ID2D1StrokeStyle**, int> CreateStrokeStyle;
        [NativeTypeName("HRESULT (const D2D1_DRAWING_STATE_DESCRIPTION *, IDWriteRenderingParams *, ID2D1DrawingStateBlock **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_DRAWING_STATE_DESCRIPTION*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int> CreateDrawingStateBlock2;
        [NativeTypeName("HRESULT (IWICBitmap *, const D2D1_RENDER_TARGET_PROPERTIES *, ID2D1RenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmap*, D2D1_RENDER_TARGET_PROPERTIES*, ID2D1RenderTarget**, int> CreateWicBitmapRenderTarget;
        [NativeTypeName("HRESULT (const D2D1_RENDER_TARGET_PROPERTIES *, const D2D1_HWND_RENDER_TARGET_PROPERTIES *, ID2D1HwndRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_RENDER_TARGET_PROPERTIES*, D2D1_HWND_RENDER_TARGET_PROPERTIES*, ID2D1HwndRenderTarget**, int> CreateHwndRenderTarget;
        [NativeTypeName("HRESULT (IDXGISurface *, const D2D1_RENDER_TARGET_PROPERTIES *, ID2D1RenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGISurface*, D2D1_RENDER_TARGET_PROPERTIES*, ID2D1RenderTarget**, int> CreateDxgiSurfaceRenderTarget;
        [NativeTypeName("HRESULT (const D2D1_RENDER_TARGET_PROPERTIES *, ID2D1DCRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_RENDER_TARGET_PROPERTIES*, ID2D1DCRenderTarget**, int> CreateDCRenderTarget;
        [NativeTypeName("HRESULT (IDXGIDevice *, ID2D1Device **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIDevice*, ID2D1Device**, int> CreateDevice;
        [NativeTypeName("HRESULT (const D2D1_STROKE_STYLE_PROPERTIES1 *, const FLOAT *, UINT32, ID2D1StrokeStyle1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_STROKE_STYLE_PROPERTIES1*, float*, uint, ID2D1StrokeStyle1**, int> CreateStrokeStyle1;
        [NativeTypeName("HRESULT (ID2D1PathGeometry1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1PathGeometry1**, int> CreatePathGeometry1;
        [NativeTypeName("HRESULT (const D2D1_DRAWING_STATE_DESCRIPTION1 *, IDWriteRenderingParams *, ID2D1DrawingStateBlock1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_DRAWING_STATE_DESCRIPTION1*, IDWriteRenderingParams*, ID2D1DrawingStateBlock1**, int> CreateDrawingStateBlock5;
        [NativeTypeName("HRESULT (IStream *, ID2D1GdiMetafile **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, ID2D1GdiMetafile**, int> CreateGdiMetafile;
        [NativeTypeName("HRESULT (const IID &, IStream *, const D2D1_PROPERTY_BINDING *, UINT32, const PD2D1_EFFECT_FACTORY) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IStream*, D2D1_PROPERTY_BINDING*, uint, delegate* unmanaged<IUnknown**, HRESULT> , int> RegisterEffectFromStream;
        [NativeTypeName("HRESULT (const IID &, PCWSTR, const D2D1_PROPERTY_BINDING *, UINT32, const PD2D1_EFFECT_FACTORY) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, D2D1_PROPERTY_BINDING*, uint, delegate* unmanaged<IUnknown**, HRESULT> , int> RegisterEffectFromString;
        [NativeTypeName("HRESULT (const IID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> UnregisterEffect;
        [NativeTypeName("HRESULT (CLSID *, UINT32, UINT32 *, UINT32 *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, uint*, uint*, int> GetRegisteredEffects;
        [NativeTypeName("HRESULT (const IID &, ID2D1Properties **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ID2D1Properties**, int> GetEffectProperties;
        [NativeTypeName("HRESULT (IDXGIDevice *, ID2D1Device1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIDevice*, ID2D1Device1**, int> CreateDevice1;
        [NativeTypeName("HRESULT (IDXGIDevice *, ID2D1Device2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIDevice*, ID2D1Device2**, int> CreateDevice2;
        [NativeTypeName("HRESULT (IDXGIDevice *, ID2D1Device3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIDevice*, ID2D1Device3**, int> CreateDevice3;
        [NativeTypeName("HRESULT (IDXGIDevice *, ID2D1Device4 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIDevice*, ID2D1Device4**, int> CreateDevice4;
        [NativeTypeName("HRESULT (IDXGIDevice *, ID2D1Device5 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIDevice*, ID2D1Device5**, int> CreateDevice5;
    }
}