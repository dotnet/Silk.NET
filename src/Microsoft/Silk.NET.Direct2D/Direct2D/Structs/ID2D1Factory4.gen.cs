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
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
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
        public readonly unsafe void GetDesktopDpi(float* dpiX, ref float dpiY)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiX, dpiYPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesktopDpi(ref float dpiX, float* dpiY)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiXPtr, dpiY);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDesktopDpi(ref float dpiX, ref float dpiY)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                fixed (float* dpiYPtr = &dpiY)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, float*, float*, void>)@this->LpVtbl[4])(@this, dpiXPtr, dpiYPtr);
                }
            }
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
        public readonly unsafe int CreateRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rectangle, ref ID2D1RectangleGeometry* rectangleGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RectangleGeometry** rectangleGeometryPtr = &rectangleGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectangle, rectangleGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rectangle, ID2D1RectangleGeometry** rectangleGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* rectanglePtr = &rectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectanglePtr, rectangleGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rectangle, ref ID2D1RectangleGeometry* rectangleGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* rectanglePtr = &rectangle)
            {
                fixed (ID2D1RectangleGeometry** rectangleGeometryPtr = &rectangleGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Maths.Box2D<float>*, ID2D1RectangleGeometry**, int>)@this->LpVtbl[5])(@this, rectanglePtr, rectangleGeometryPtr);
                }
            }
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
        public readonly unsafe int CreateRoundedRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRectangle, ref ID2D1RoundedRectangleGeometry* roundedRectangleGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RoundedRectangleGeometry** roundedRectangleGeometryPtr = &roundedRectangleGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectangle, roundedRectangleGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRoundedRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RoundedRect roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RoundedRect* roundedRectanglePtr = &roundedRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectanglePtr, roundedRectangleGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRoundedRectangleGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RoundedRect roundedRectangle, ref ID2D1RoundedRectangleGeometry* roundedRectangleGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RoundedRect* roundedRectanglePtr = &roundedRectangle)
            {
                fixed (ID2D1RoundedRectangleGeometry** roundedRectangleGeometryPtr = &roundedRectangleGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)@this->LpVtbl[6])(@this, roundedRectanglePtr, roundedRectangleGeometryPtr);
                }
            }
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
        public readonly unsafe int CreateEllipseGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ref ID2D1EllipseGeometry* ellipseGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1EllipseGeometry** ellipseGeometryPtr = &ellipseGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipse, ellipseGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipseGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Ellipse ellipse, ID2D1EllipseGeometry** ellipseGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipsePtr, ellipseGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipseGeometry([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Ellipse ellipse, ref ID2D1EllipseGeometry* ellipseGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                fixed (ID2D1EllipseGeometry** ellipseGeometryPtr = &ellipseGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Ellipse*, ID2D1EllipseGeometry**, int>)@this->LpVtbl[7])(@this, ellipsePtr, ellipseGeometryPtr);
                }
            }
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
        public readonly unsafe int CreateGeometryGroup(FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GeometryGroup** geometryGroupPtr = &geometryGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometries, geometriesCount, geometryGroupPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup(FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry** geometriesPtr = &geometries)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometriesPtr, geometriesCount, geometryGroup);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup(FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry** geometriesPtr = &geometries)
            {
                fixed (ID2D1GeometryGroup** geometryGroupPtr = &geometryGroup)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)@this->LpVtbl[8])(@this, fillMode, geometriesPtr, geometriesCount, geometryGroupPtr);
                }
            }
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
        public readonly unsafe int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transform, transformedGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transformPtr, transformedGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometry, transformPtr, transformedGeometryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transform, transformedGeometry);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
            {
                fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transform, transformedGeometryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ID2D1TransformedGeometry** transformedGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transformPtr, transformedGeometry);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry(ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* sourceGeometryPtr = &sourceGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
                {
                    fixed (ID2D1TransformedGeometry** transformedGeometryPtr = &transformedGeometry)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, ID2D1TransformedGeometry**, int>)@this->LpVtbl[9])(@this, sourceGeometryPtr, transformPtr, transformedGeometryPtr);
                    }
                }
            }
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
        public readonly unsafe int CreatePathGeometry(ref ID2D1PathGeometry* pathGeometry)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1PathGeometry** pathGeometryPtr = &pathGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1PathGeometry**, int>)@this->LpVtbl[10])(@this, pathGeometryPtr);
            }
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
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashes, dashesCount, strokeStylePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dashesPtr = &dashes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashesPtr, dashesCount, strokeStyle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dashesPtr = &dashes)
            {
                fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStyleProperties, dashesPtr, dashesCount, strokeStylePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashes, dashesCount, strokeStyle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
            {
                fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashes, dashesCount, strokeStylePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
            {
                fixed (float* dashesPtr = &dashes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashesPtr, dashesCount, strokeStyle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ref ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StrokeStyleProperties* strokeStylePropertiesPtr = &strokeStyleProperties)
            {
                fixed (float* dashesPtr = &dashes)
                {
                    fixed (ID2D1StrokeStyle** strokeStylePtr = &strokeStyle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)@this->LpVtbl[11])(@this, strokeStylePropertiesPtr, dashesPtr, dashesCount, strokeStylePtr);
                    }
                }
            }
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
        public readonly unsafe int CreateDrawingStateBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescription, textRenderingParams, drawingStateBlockPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParams, drawingStateBlock);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ID2D1DrawingStateBlock* drawingStateBlock)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DrawingStateDescription* drawingStateDescriptionPtr = &drawingStateDescription)
            {
                fixed (ID2D1DrawingStateBlock** drawingStateBlockPtr = &drawingStateBlock)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, DrawingStateDescription*, IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)@this->LpVtbl[12])(@this, drawingStateDescriptionPtr, textRenderingParams, drawingStateBlockPtr);
                }
            }
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
        public readonly unsafe int CreateWicBitmapRenderTarget(IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetProperties, renderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetPropertiesPtr, renderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget(IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[13])(@this, target, renderTargetPropertiesPtr, renderTargetPtr);
                }
            }
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
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetPropertiesPtr, hwndRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
            {
                fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetProperties, hwndRenderTargetPropertiesPtr, hwndRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetProperties, hwndRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetProperties, hwndRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetPropertiesPtr, hwndRenderTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ref ID2D1HwndRenderTarget* hwndRenderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (HwndRenderTargetProperties* hwndRenderTargetPropertiesPtr = &hwndRenderTargetProperties)
                {
                    fixed (ID2D1HwndRenderTarget** hwndRenderTargetPtr = &hwndRenderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)@this->LpVtbl[14])(@this, renderTargetPropertiesPtr, hwndRenderTargetPropertiesPtr, hwndRenderTargetPtr);
                    }
                }
            }
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
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetProperties, renderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetPropertiesPtr, renderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurface, renderTargetPropertiesPtr, renderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetProperties, renderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
            {
                fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetProperties, renderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ID2D1RenderTarget** renderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
            {
                fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetPropertiesPtr, renderTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ID2D1RenderTarget* renderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* dxgiSurfacePtr = &dxgiSurface)
            {
                fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
                {
                    fixed (ID2D1RenderTarget** renderTargetPtr = &renderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)@this->LpVtbl[15])(@this, dxgiSurfacePtr, renderTargetPropertiesPtr, renderTargetPtr);
                    }
                }
            }
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
        public readonly unsafe int CreateDCRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ID2D1DCRenderTarget* dcRenderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1DCRenderTarget** dcRenderTargetPtr = &dcRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetProperties, dcRenderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDCRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetPropertiesPtr, dcRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDCRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ID2D1DCRenderTarget* dcRenderTarget)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                fixed (ID2D1DCRenderTarget** dcRenderTargetPtr = &dcRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)@this->LpVtbl[16])(@this, renderTargetPropertiesPtr, dcRenderTargetPtr);
                }
            }
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
        public readonly unsafe int CreateDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ref ID2D1Device* d2dDevice)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Device** d2dDevicePtr = &d2dDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)@this->LpVtbl[17])(@this, dxgiDevice, d2dDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ID2D1Device** d2dDevice)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIDevice* dxgiDevicePtr = &dxgiDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)@this->LpVtbl[17])(@this, dxgiDevicePtr, d2dDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ref ID2D1Device* d2dDevice)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIDevice* dxgiDevicePtr = &dxgiDevice)
            {
                fixed (ID2D1Device** d2dDevicePtr = &d2dDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.DXGI.IDXGIDevice*, ID2D1Device**, int>)@this->LpVtbl[17])(@this, dxgiDevicePtr, d2dDevicePtr);
                }
            }
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
        public readonly unsafe int CreateGdiMetafile(Silk.NET.Core.Win32Extras.IStream* metafileStream, ref ID2D1GdiMetafile* metafile)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GdiMetafile** metafilePtr = &metafile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Core.Win32Extras.IStream*, ID2D1GdiMetafile**, int>)@this->LpVtbl[21])(@this, metafileStream, metafilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiMetafile(ref Silk.NET.Core.Win32Extras.IStream metafileStream, ID2D1GdiMetafile** metafile)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* metafileStreamPtr = &metafileStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Core.Win32Extras.IStream*, ID2D1GdiMetafile**, int>)@this->LpVtbl[21])(@this, metafileStreamPtr, metafile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiMetafile(ref Silk.NET.Core.Win32Extras.IStream metafileStream, ref ID2D1GdiMetafile* metafile)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* metafileStreamPtr = &metafileStream)
            {
                fixed (ID2D1GdiMetafile** metafilePtr = &metafile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Silk.NET.Core.Win32Extras.IStream*, ID2D1GdiMetafile**, int>)@this->LpVtbl[21])(@this, metafileStreamPtr, metafilePtr);
                }
            }
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
        public readonly unsafe int RegisterEffectFromStream(Guid* classId, ref Silk.NET.Core.Win32Extras.IStream propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* propertyXmlPtr = &propertyXml)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[22])(@this, classId, propertyXmlPtr, bindings, bindingsCount, effectFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromStream(ref Guid classId, Silk.NET.Core.Win32Extras.IStream* propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[22])(@this, classIdPtr, propertyXml, bindings, bindingsCount, effectFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromStream(ref Guid classId, ref Silk.NET.Core.Win32Extras.IStream propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* propertyXmlPtr = &propertyXml)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, Silk.NET.Core.Win32Extras.IStream*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[22])(@this, classIdPtr, propertyXmlPtr, bindings, bindingsCount, effectFactory);
                }
            }
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
        public readonly unsafe int RegisterEffectFromString(Guid* classId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* propertyXmlPtr = &propertyXml)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[23])(@this, classId, propertyXmlPtr, bindings, bindingsCount, effectFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(Guid* classId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var propertyXmlPtr = (byte*) SilkMarshal.StringToPtr(propertyXml, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, byte*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[23])(@this, classId, propertyXmlPtr, bindings, bindingsCount, effectFactory);
            SilkMarshal.Free((nint)propertyXmlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(ref Guid classId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[23])(@this, classIdPtr, propertyXml, bindings, bindingsCount, effectFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(ref Guid classId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                fixed (char* propertyXmlPtr = &propertyXml)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, char*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[23])(@this, classIdPtr, propertyXmlPtr, bindings, bindingsCount, effectFactory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterEffectFromString(ref Guid classId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string propertyXml, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyBinding* bindings, uint bindingsCount, PfnPD2D1EffectFactory effectFactory)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
            var propertyXmlPtr = (byte*) SilkMarshal.StringToPtr(propertyXml, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, byte*, PropertyBinding*, uint, PfnPD2D1EffectFactory, int>)@this->LpVtbl[23])(@this, classIdPtr, propertyXmlPtr, bindings, bindingsCount, effectFactory);
            SilkMarshal.Free((nint)propertyXmlPtr);
            }
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
        public readonly int UnregisterEffect(ref Guid classId)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* classIdPtr = &classId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, int>)@this->LpVtbl[24])(@this, classIdPtr);
            }
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
        public readonly unsafe int GetRegisteredEffects(Guid* effects, uint effectsCount, uint* effectsReturned, ref uint effectsRegistered)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* effectsRegisteredPtr = &effectsRegistered)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effects, effectsCount, effectsReturned, effectsRegisteredPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegisteredEffects(Guid* effects, uint effectsCount, ref uint effectsReturned, uint* effectsRegistered)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* effectsReturnedPtr = &effectsReturned)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effects, effectsCount, effectsReturnedPtr, effectsRegistered);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegisteredEffects(Guid* effects, uint effectsCount, ref uint effectsReturned, ref uint effectsRegistered)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* effectsReturnedPtr = &effectsReturned)
            {
                fixed (uint* effectsRegisteredPtr = &effectsRegistered)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effects, effectsCount, effectsReturnedPtr, effectsRegisteredPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegisteredEffects(ref Guid effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectsPtr = &effects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effectsPtr, effectsCount, effectsReturned, effectsRegistered);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegisteredEffects(ref Guid effects, uint effectsCount, uint* effectsReturned, ref uint effectsRegistered)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectsPtr = &effects)
            {
                fixed (uint* effectsRegisteredPtr = &effectsRegistered)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effectsPtr, effectsCount, effectsReturned, effectsRegisteredPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegisteredEffects(ref Guid effects, uint effectsCount, ref uint effectsReturned, uint* effectsRegistered)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectsPtr = &effects)
            {
                fixed (uint* effectsReturnedPtr = &effectsReturned)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effectsPtr, effectsCount, effectsReturnedPtr, effectsRegistered);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRegisteredEffects(ref Guid effects, uint effectsCount, ref uint effectsReturned, ref uint effectsRegistered)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectsPtr = &effects)
            {
                fixed (uint* effectsReturnedPtr = &effectsReturned)
                {
                    fixed (uint* effectsRegisteredPtr = &effectsRegistered)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)@this->LpVtbl[25])(@this, effectsPtr, effectsCount, effectsReturnedPtr, effectsRegisteredPtr);
                    }
                }
            }
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

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectProperties(Guid* effectId, ref ID2D1Properties* properties)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Properties** propertiesPtr = &properties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, ID2D1Properties**, int>)@this->LpVtbl[26])(@this, effectId, propertiesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectProperties(ref Guid effectId, ID2D1Properties** properties)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectIdPtr = &effectId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, ID2D1Properties**, int>)@this->LpVtbl[26])(@this, effectIdPtr, properties);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectProperties(ref Guid effectId, ref ID2D1Properties* properties)
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectIdPtr = &effectId)
            {
                fixed (ID2D1Properties** propertiesPtr = &properties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, ID2D1Properties**, int>)@this->LpVtbl[26])(@this, effectIdPtr, propertiesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRectangleGeometry<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rectangle, ref ComPtr<TI0> rectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RectangleGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRectangleGeometry(rectangle, (ID2D1RectangleGeometry**) rectangleGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateRectangleGeometry<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> rectangle, ref ComPtr<TI0> rectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RectangleGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRectangleGeometry(in rectangle, (ID2D1RectangleGeometry**) rectangleGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRoundedRectangleGeometry<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRectangle, ref ComPtr<TI0> roundedRectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RoundedRectangleGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRoundedRectangleGeometry(roundedRectangle, (ID2D1RoundedRectangleGeometry**) roundedRectangleGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateRoundedRectangleGeometry<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RoundedRect roundedRectangle, ref ComPtr<TI0> roundedRectangleGeometry) where TI0 : unmanaged, IComVtbl<ID2D1RoundedRectangleGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRoundedRectangleGeometry(in roundedRectangle, (ID2D1RoundedRectangleGeometry**) roundedRectangleGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipseGeometry<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ref ComPtr<TI0> ellipseGeometry) where TI0 : unmanaged, IComVtbl<ID2D1EllipseGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEllipseGeometry(ellipse, (ID2D1EllipseGeometry**) ellipseGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEllipseGeometry<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Ellipse ellipse, ref ComPtr<TI0> ellipseGeometry) where TI0 : unmanaged, IComVtbl<ID2D1EllipseGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEllipseGeometry(in ellipse, (ID2D1EllipseGeometry**) ellipseGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGeometryGroup<TI0, TI1>(FillMode fillMode, ref ComPtr<TI0> geometries, uint geometriesCount, ref ComPtr<TI1> geometryGroup) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1GeometryGroup>, IComVtbl<TI1>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGeometryGroup(fillMode, (ID2D1Geometry**) geometries.GetAddressOf(), geometriesCount, (ID2D1GeometryGroup**) geometryGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup<TI0>(FillMode fillMode, ref ComPtr<TI0> geometries, uint geometriesCount, ref ID2D1GeometryGroup* geometryGroup) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGeometryGroup(fillMode, (ID2D1Geometry**) geometries.GetAddressOf(), geometriesCount, ref geometryGroup);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryGroup<TI0>(FillMode fillMode, ref ID2D1Geometry* geometries, uint geometriesCount, ref ComPtr<TI0> geometryGroup) where TI0 : unmanaged, IComVtbl<ID2D1GeometryGroup>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGeometryGroup(fillMode, ref geometries, geometriesCount, (ID2D1GeometryGroup**) geometryGroup.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry<TI0, TI1>(ComPtr<TI0> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ComPtr<TI1> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI1>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry<TI0>(ComPtr<TI0> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ID2D1TransformedGeometry* transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, transform, ref transformedGeometry);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTransformedGeometry<TI0, TI1>(ComPtr<TI0> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ComPtr<TI1> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI1>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, in transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry<TI0>(ComPtr<TI0> sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ID2D1TransformedGeometry* transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformedGeometry((ID2D1Geometry*) sourceGeometry.Handle, in transform, ref transformedGeometry);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedGeometry<TI0>(ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform, ref ComPtr<TI0> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformedGeometry(ref sourceGeometry, transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTransformedGeometry<TI0>(ref ID2D1Geometry sourceGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform, ref ComPtr<TI0> transformedGeometry) where TI0 : unmanaged, IComVtbl<ID2D1TransformedGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTransformedGeometry(ref sourceGeometry, in transform, (ID2D1TransformedGeometry**) transformedGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreatePathGeometry<TI0>(ref ComPtr<TI0> pathGeometry) where TI0 : unmanaged, IComVtbl<ID2D1PathGeometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePathGeometry((ID2D1PathGeometry**) pathGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStrokeStyle(strokeStyleProperties, dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] StrokeStyleProperties* strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStrokeStyle(strokeStyleProperties, in dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeStyle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStrokeStyle(in strokeStyleProperties, dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateStrokeStyle<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StrokeStyleProperties strokeStyleProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, ref ComPtr<TI0> strokeStyle) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStrokeStyle(in strokeStyleProperties, in dashes, dashesCount, (ID2D1StrokeStyle**) strokeStyle.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawingStateDescription* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDrawingStateBlock(drawingStateDescription, textRenderingParams, (ID2D1DrawingStateBlock**) drawingStateBlock.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDrawingStateBlock<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ref ComPtr<TI0> drawingStateBlock) where TI0 : unmanaged, IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDrawingStateBlock(in drawingStateDescription, textRenderingParams, (ID2D1DrawingStateBlock**) drawingStateBlock.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget<TI0>(IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateWicBitmapRenderTarget(target, renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWicBitmapRenderTarget<TI0>(IWICBitmap* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateWicBitmapRenderTarget(target, in renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHwndRenderTarget(renderTargetProperties, hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHwndRenderTarget(renderTargetProperties, in hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHwndRenderTarget<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HwndRenderTargetProperties* hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHwndRenderTarget(in renderTargetProperties, hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateHwndRenderTarget<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HwndRenderTargetProperties hwndRenderTargetProperties, ref ComPtr<TI0> hwndRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1HwndRenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHwndRenderTarget(in renderTargetProperties, in hwndRenderTargetProperties, (ID2D1HwndRenderTarget**) hwndRenderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget<TI0>(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDxgiSurfaceRenderTarget(dxgiSurface, renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget<TI0>(Silk.NET.DXGI.IDXGISurface* dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDxgiSurfaceRenderTarget(dxgiSurface, in renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDxgiSurfaceRenderTarget<TI0>(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface, renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDxgiSurfaceRenderTarget<TI0>(ref Silk.NET.DXGI.IDXGISurface dxgiSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDxgiSurfaceRenderTarget(ref dxgiSurface, in renderTargetProperties, (ID2D1RenderTarget**) renderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDCRenderTarget<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties, ref ComPtr<TI0> dcRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1DCRenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDCRenderTarget(renderTargetProperties, (ID2D1DCRenderTarget**) dcRenderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDCRenderTarget<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetProperties renderTargetProperties, ref ComPtr<TI0> dcRenderTarget) where TI0 : unmanaged, IComVtbl<ID2D1DCRenderTarget>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDCRenderTarget(in renderTargetProperties, (ID2D1DCRenderTarget**) dcRenderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice<TI0>(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ref ComPtr<TI0> d2dDevice) where TI0 : unmanaged, IComVtbl<ID2D1Device>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDevice(dxgiDevice, (ID2D1Device**) d2dDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDevice<TI0>(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ref ComPtr<TI0> d2dDevice) where TI0 : unmanaged, IComVtbl<ID2D1Device>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDevice(ref dxgiDevice, (ID2D1Device**) d2dDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiMetafile<TI0>(Silk.NET.Core.Win32Extras.IStream* metafileStream, ref ComPtr<TI0> metafile) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafile>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiMetafile(metafileStream, (ID2D1GdiMetafile**) metafile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGdiMetafile<TI0>(ref Silk.NET.Core.Win32Extras.IStream metafileStream, ref ComPtr<TI0> metafile) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafile>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiMetafile(ref metafileStream, (ID2D1GdiMetafile**) metafile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEffectProperties<TI0>(out ComPtr<TI0> properties) where TI0 : unmanaged, IComVtbl<ID2D1Properties>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            properties = default;
            return @this->GetEffectProperties(SilkMarshal.GuidPtrOf<TI0>(), (ID2D1Properties**) properties.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEffectProperties<TI0>(ref Guid effectId, ref ComPtr<TI0> properties) where TI0 : unmanaged, IComVtbl<ID2D1Properties>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetEffectProperties(ref effectId, (ID2D1Properties**) properties.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetEffectProperties<TI0>() where TI0 : unmanaged, IComVtbl<ID2D1Properties>, IComVtbl<TI0>
        {
            var @this = (ID2D1Factory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetEffectProperties(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
