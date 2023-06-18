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

namespace Silk.NET.Direct2D
{
    [Guid("bd4ec2d2-0662-4bee-ba8e-6f29f032e096")]
    [NativeName("Name", "ID2D1Factory4")]
    public unsafe partial struct ID2D1Factory4 : IComVtbl<ID2D1Factory4>, IComVtbl<ID2D1Factory3>, IComVtbl<ID2D1Factory2>, IComVtbl<ID2D1Factory1>, IComVtbl<ID2D1Factory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("bd4ec2d2-0662-4bee-ba8e-6f29f032e096");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Factory3(ID2D1Factory4 val)
            => Unsafe.As<ID2D1Factory4, ID2D1Factory3>(ref val);

        public static implicit operator ID2D1Factory2(ID2D1Factory4 val)
            => Unsafe.As<ID2D1Factory4, ID2D1Factory2>(ref val);

        public static implicit operator ID2D1Factory1(ID2D1Factory4 val)
            => Unsafe.As<ID2D1Factory4, ID2D1Factory1>(ref val);

        public static implicit operator ID2D1Factory(ID2D1Factory4 val)
            => Unsafe.As<ID2D1Factory4, ID2D1Factory>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Factory4 val)
            => Unsafe.As<ID2D1Factory4, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Factory4
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReloadSystemMetrics()
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, int>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesktopDpi(float* dpiX, float* dpiY)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiX, dpiY);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectangle, rectangleGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRoundedRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectangle, roundedRectangleGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipseGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipse, ellipseGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup(FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometries, geometriesCount, geometryGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transform, transformedGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathGeometry(ID2D1PathGeometry** pathGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1PathGeometry**, int>)@this->LpVtbl[10])(@this, pathGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashes, dashesCount, strokeStyle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescription, textRenderingParams, drawingStateBlock);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetProperties, renderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetProperties, renderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDCRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetProperties, dcRenderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ID2D1Device** d2dDevice)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)@this->LpVtbl[17])(@this, dxgiDevice, d2dDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiMetafile(Silk.NET.Core.Win32Extras.IStream* metafileStream, ID2D1GdiMetafile** metafile)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Core.Win32Extras.IStream*, ID2D1GdiMetafile**, int>)@this->LpVtbl[21])(@this, metafileStream, metafile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromStream(Guid* classId, Silk.NET.Core.Win32Extras.IStream* propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[22])(@this, classId, propertyXml, bindings, bindingsCount, effectFactory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(Guid* classId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[23])(@this, classId, propertyXml, bindings, bindingsCount, effectFactory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnregisterEffect(Guid* classId)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, int>)@this->LpVtbl[24])(@this, classId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegisteredEffects(Guid* effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effects, effectsCount, effectsReturned, effectsRegistered);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectProperties(Guid* effectId, ID2D1Properties** properties)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, ID2D1Properties**, int>)@this->LpVtbl[26])(@this, effectId, properties);
            return ret;
        }

    }
}
