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
    [Guid("06152247-6f50-465a-9245-118bfd3b6007")]
    [NativeName("Name", "ID2D1Factory")]
    public unsafe partial struct ID2D1Factory : IComVtbl<ID2D1Factory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("06152247-6f50-465a-9245-118bfd3b6007");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Factory val)
            => Unsafe.As<ID2D1Factory, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Factory
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
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReloadSystemMetrics()
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, int>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesktopDpi(float* dpiX, float* dpiY)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Factory*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiX, dpiY);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesktopDpi(float* dpiX, ref float dpiY)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Factory*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiX, dpiYPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesktopDpi(ref float dpiX, float* dpiY)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Factory*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiXPtr, dpiY);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDesktopDpi(ref float dpiX, ref float dpiY)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                fixed (float* dpiYPtr = &dpiY)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1Factory*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiXPtr, dpiYPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectangle, rectangleGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rectangle, ref ID2D1RectangleGeometry* rectangleGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RectangleGeometry** rectangleGeometryPtr = &rectangleGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectangle, rectangleGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rectangle, ID2D1RectangleGeometry** rectangleGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* rectanglePtr = &rectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectanglePtr, rectangleGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rectangle, ref ID2D1RectangleGeometry* rectangleGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* rectanglePtr = &rectangle)
            {
                fixed (ID2D1RectangleGeometry** rectangleGeometryPtr = &rectangleGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectanglePtr, rectangleGeometryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRoundedRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectangle, roundedRectangleGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRoundedRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRectangle, ref ID2D1RoundedRectangleGeometry* roundedRectangleGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RoundedRectangleGeometry** roundedRectangleGeometryPtr = &roundedRectangleGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectangle, roundedRectangleGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRoundedRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RoundedRect roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RoundedRect* roundedRectanglePtr = &roundedRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectanglePtr, roundedRectangleGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRoundedRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RoundedRect roundedRectangle, ref ID2D1RoundedRectangleGeometry* roundedRectangleGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RoundedRect* roundedRectanglePtr = &roundedRectangle)
            {
                fixed (ID2D1RoundedRectangleGeometry** roundedRectangleGeometryPtr = &roundedRectangleGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectanglePtr, roundedRectangleGeometryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipseGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipse, ellipseGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipseGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ref ID2D1EllipseGeometry* ellipseGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1EllipseGeometry** ellipseGeometryPtr = &ellipseGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipse, ellipseGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipseGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Ellipse ellipse, ID2D1EllipseGeometry** ellipseGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipsePtr, ellipseGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipseGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Ellipse ellipse, ref ID2D1EllipseGeometry* ellipseGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                fixed (ID2D1EllipseGeometry** ellipseGeometryPtr = &ellipseGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipsePtr, ellipseGeometryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup(FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometries, geometriesCount, geometryGroup);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup(FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GeometryGroup** geometryGroupPtr = &geometryGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometries, geometriesCount, geometryGroupPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup(FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry** geometriesPtr = &geometries)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometriesPtr, geometriesCount, geometryGroup);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup(FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry** geometriesPtr = &geometries)
            {
                fixed (ID2D1GeometryGroup** geometryGroupPtr = &geometryGroup)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometriesPtr, geometriesCount, geometryGroupPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transform, transformedGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transform, transformedGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transformPtr, transformedGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transformPtr, transformedGeometryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transform, transformedGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
            {
                fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transform, transformedGeometryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transformPtr, transformedGeometry);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
                {
                    fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transformPtr, transformedGeometryPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathGeometry(ID2D1PathGeometry** pathGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1PathGeometry**, int>)@this->LpVtbl[10])(@this, pathGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathGeometry(ref ID2D1PathGeometry* pathGeometry)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1PathGeometry** pathGeometryPtr = &pathGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1PathGeometry**, int>)@this->LpVtbl[10])(@this, pathGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashes, dashesCount, strokeStyle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashes, dashesCount, strokeStylePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dashesPtr = &dashes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashesPtr, dashesCount, strokeStyle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dashesPtr = &dashes)
            {
                fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashesPtr, dashesCount, strokeStylePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashes, dashesCount, strokeStyle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
            {
                fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashes, dashesCount, strokeStylePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
            {
                fixed (float* dashesPtr = &dashes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashesPtr, dashesCount, strokeStyle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
            {
                fixed (float* dashesPtr = &dashes)
                {
                    fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashesPtr, dashesCount, strokeStylePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescription, textRenderingParams, drawingStateBlock);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescription, textRenderingParams, drawingStateBlockPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParams, drawingStateBlock);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
            {
                fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParams, drawingStateBlockPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetProperties, renderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetProperties, renderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetPropertiesPtr, renderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetPropertiesPtr, renderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetPropertiesPtr, hwndRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
            {
                fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetPropertiesPtr, hwndRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetProperties, hwndRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetProperties, hwndRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetPropertiesPtr, hwndRenderTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
                {
                    fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetPropertiesPtr, hwndRenderTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetProperties, renderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetProperties, renderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetPropertiesPtr, renderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetPropertiesPtr, renderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetProperties, renderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
            {
                fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetProperties, renderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
            {
                fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetPropertiesPtr, renderTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
            {
                fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
                {
                    fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetPropertiesPtr, renderTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDCRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetProperties, dcRenderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDCRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ID2D1DCRenderTarget* dcRenderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1DCRenderTarget** dcRenderTargetPtr = &dcRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetProperties, dcRenderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDCRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetPropertiesPtr, dcRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDCRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ID2D1DCRenderTarget* dcRenderTarget)
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1DCRenderTarget** dcRenderTargetPtr = &dcRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetPropertiesPtr, dcRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleGeometry<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rectangle, ref ComPtr<TI0> rectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RectangleGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRectangleGeometry(rectangle, (ID2D1RectangleGeometry**) rectangleGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateRectangleGeometry<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rectangle, ref ComPtr<TI0> rectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RectangleGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRectangleGeometry(in rectangle, (ID2D1RectangleGeometry**) rectangleGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRoundedRectangleGeometry<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRectangle, ref ComPtr<TI0> roundedRectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RoundedRectangleGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRoundedRectangleGeometry(roundedRectangle, (ID2D1RoundedRectangleGeometry**) roundedRectangleGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateRoundedRectangleGeometry<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RoundedRect roundedRectangle, ref ComPtr<TI0> roundedRectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RoundedRectangleGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRoundedRectangleGeometry(in roundedRectangle, (ID2D1RoundedRectangleGeometry**) roundedRectangleGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipseGeometry<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ref ComPtr<TI0> ellipseGeometry) where TI0 : unmanaged, IComVtbl<ID2D1EllipseGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEllipseGeometry(ellipse, (ID2D1EllipseGeometry**) ellipseGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEllipseGeometry<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Ellipse ellipse, ref ComPtr<TI0> ellipseGeometry) where TI0 : unmanaged, IComVtbl<ID2D1EllipseGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEllipseGeometry(in ellipse, (ID2D1EllipseGeometry**) ellipseGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGeometryGroup<TI0, TI1>(FillMode fillMode, ref ComPtr<TI0> geometries, uint geometriesCount, ref ComPtr<TI1> geometryGroup) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1GeometryGroup>, IComVtbl<TI1>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGeometryGroup(fillMode, (ID2D1Geometry**) geometries.GetAddressOf(), geometriesCount, (ID2D1GeometryGroup**) geometryGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup<TI0>(FillMode fillMode, ref ComPtr<TI0> geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGeometryGroup(fillMode, (ID2D1Geometry**) geometries.GetAddressOf(), geometriesCount, ref geometryGroup);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup<TI0>(FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ref ComPtr<TI0> geometryGroup) where TI0 : unmanaged, IComVtbl<ID2D1GeometryGroup>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGeometryGroup(fillMode, ref geometries, geometriesCount, (ID2D1GeometryGroup**) geometryGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry<TI0, TI1>(ComPtr<TI0> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ComPtr<TI1> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI1>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry<TI0>(ComPtr<TI0> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, transform, ref transformedGeometry);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTransformedGeometry<TI0, TI1>(ComPtr<TI0> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ComPtr<TI1> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI1>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, in transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry<TI0>(ComPtr<TI0> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, in transform, ref transformedGeometry);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry<TI0>(ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ComPtr<TI0> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformedGeometry(ref sourceGeometry, transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTransformedGeometry<TI0>(ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ComPtr<TI0> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformedGeometry(ref sourceGeometry, in transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreatePathGeometry<TI0>(ref ComPtr<TI0> pathGeometry) where TI0 : unmanaged, IComVtbl<ID2D1PathGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePathGeometry((ID2D1PathGeometry**) pathGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStrokeStyle(strokeStyleProperties, dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStrokeStyle(strokeStyleProperties, in dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStrokeStyle(in strokeStyleProperties, dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateStrokeStyle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStrokeStyle(in strokeStyleProperties, in dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDrawingStateBlock(drawingStateDescription, textRenderingParams, (ID2D1DrawingStateBlock**) drawingStateBlock.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDrawingStateBlock(in drawingStateDescription, textRenderingParams, (ID2D1DrawingStateBlock**) drawingStateBlock.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget<TI0>(IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateWicBitmapRenderTarget(target, renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget<TI0>(IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateWicBitmapRenderTarget(target, in renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHwndRenderTarget(renderTargetProperties, hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHwndRenderTarget(renderTargetProperties, in hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHwndRenderTarget(in renderTargetProperties, hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateHwndRenderTarget<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHwndRenderTarget(in renderTargetProperties, in hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget<TI0>(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDxgiSurfaceRenderTarget(dxgiSurface, renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget<TI0>(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDxgiSurfaceRenderTarget(dxgiSurface, in renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget<TI0>(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface, renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDxgiSurfaceRenderTarget<TI0>(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface, in renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDCRenderTarget<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> dcRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1DCRenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDCRenderTarget(renderTargetProperties, (ID2D1DCRenderTarget**) dcRenderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDCRenderTarget<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> dcRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1DCRenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDCRenderTarget(in renderTargetProperties, (ID2D1DCRenderTarget**) dcRenderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
