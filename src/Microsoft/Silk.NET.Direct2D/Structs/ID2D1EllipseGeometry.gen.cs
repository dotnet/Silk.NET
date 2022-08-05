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
    [Guid("2cd906a4-12e2-11dc-9fed-001143a055f9")]
    [NativeName("Name", "ID2D1EllipseGeometry")]
    public unsafe partial struct ID2D1EllipseGeometry
    {
        public static readonly Guid Guid = new("2cd906a4-12e2-11dc-9fed-001143a055f9");

        public static implicit operator ID2D1Geometry(ID2D1EllipseGeometry val)
            => Unsafe.As<ID2D1EllipseGeometry, ID2D1Geometry>(ref val);

        public static implicit operator ID2D1Resource(ID2D1EllipseGeometry val)
            => Unsafe.As<ID2D1EllipseGeometry, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1EllipseGeometry val)
            => Unsafe.As<ID2D1EllipseGeometry, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1EllipseGeometry
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
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Factory**, void>)LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Factory**, void>)LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds(Silk.NET.Maths.Matrix3X2<float>* worldTransform, Silk.NET.Maths.Rectangle<float>* bounds)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[4])(@this, worldTransform, bounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds(Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref Silk.NET.Maths.Rectangle<float> bounds)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<float>* boundsPtr = &bounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[4])(@this, worldTransform, boundsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds(ref Silk.NET.Maths.Matrix3X2<float> worldTransform, Silk.NET.Maths.Rectangle<float>* bounds)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[4])(@this, worldTransformPtr, bounds);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBounds(ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref Silk.NET.Maths.Rectangle<float> bounds)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Rectangle<float>* boundsPtr = &bounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[4])(@this, worldTransformPtr, boundsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle* strokeStyle, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Rectangle<float>* bounds)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, bounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle* strokeStyle, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Rectangle<float> bounds)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<float>* boundsPtr = &bounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, boundsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle* strokeStyle, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, Silk.NET.Maths.Rectangle<float>* bounds)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, bounds);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle* strokeStyle, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Rectangle<float> bounds)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Rectangle<float>* boundsPtr = &bounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, boundsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Rectangle<float>* bounds)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[5])(@this, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, bounds);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Rectangle<float> bounds)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Rectangle<float>* boundsPtr = &bounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[5])(@this, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, boundsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, Silk.NET.Maths.Rectangle<float>* bounds)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[5])(@this, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, bounds);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWidenedBounds(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Rectangle<float> bounds)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (Silk.NET.Maths.Rectangle<float>* boundsPtr = &bounds)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[5])(@this, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, boundsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(D2D_POINT_2F point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, D2D_POINT_2F, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, contains);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(D2D_POINT_2F point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref int contains)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* containsPtr = &contains)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, D2D_POINT_2F, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, containsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(D2D_POINT_2F point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, D2D_POINT_2F, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, contains);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(D2D_POINT_2F point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref int contains)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (int* containsPtr = &contains)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, D2D_POINT_2F, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, containsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(D2D_POINT_2F point, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, D2D_POINT_2F, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)LpVtbl[6])(@this, point, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, contains);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(D2D_POINT_2F point, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref int contains)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (int* containsPtr = &contains)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, D2D_POINT_2F, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)LpVtbl[6])(@this, point, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, containsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(D2D_POINT_2F point, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, D2D_POINT_2F, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)LpVtbl[6])(@this, point, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, contains);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StrokeContainsPoint(D2D_POINT_2F point, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref int contains)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (int* containsPtr = &contains)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, D2D_POINT_2F, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)LpVtbl[6])(@this, point, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, containsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillContainsPoint(D2D_POINT_2F point, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, D2D_POINT_2F, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)LpVtbl[7])(@this, point, worldTransform, flatteningTolerance, contains);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillContainsPoint(D2D_POINT_2F point, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref int contains)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* containsPtr = &contains)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, D2D_POINT_2F, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)LpVtbl[7])(@this, point, worldTransform, flatteningTolerance, containsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillContainsPoint(D2D_POINT_2F point, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, D2D_POINT_2F, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)LpVtbl[7])(@this, point, worldTransformPtr, flatteningTolerance, contains);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FillContainsPoint(D2D_POINT_2F point, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref int contains)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (int* containsPtr = &contains)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, D2D_POINT_2F, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)LpVtbl[7])(@this, point, worldTransformPtr, flatteningTolerance, containsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ID2D1Geometry* inputGeometry, Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)LpVtbl[8])(@this, inputGeometry, inputGeometryTransform, flatteningTolerance, relation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ID2D1Geometry* inputGeometry, Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GeometryRelation* relationPtr = &relation)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)LpVtbl[8])(@this, inputGeometry, inputGeometryTransform, flatteningTolerance, relationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ID2D1Geometry* inputGeometry, ref Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)LpVtbl[8])(@this, inputGeometry, inputGeometryTransformPtr, flatteningTolerance, relation);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ID2D1Geometry* inputGeometry, ref Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
            {
                fixed (GeometryRelation* relationPtr = &relation)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)LpVtbl[8])(@this, inputGeometry, inputGeometryTransformPtr, flatteningTolerance, relationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ref ID2D1Geometry inputGeometry, Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)LpVtbl[8])(@this, inputGeometryPtr, inputGeometryTransform, flatteningTolerance, relation);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ref ID2D1Geometry inputGeometry, Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                fixed (GeometryRelation* relationPtr = &relation)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)LpVtbl[8])(@this, inputGeometryPtr, inputGeometryTransform, flatteningTolerance, relationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ref ID2D1Geometry inputGeometry, ref Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)LpVtbl[8])(@this, inputGeometryPtr, inputGeometryTransformPtr, flatteningTolerance, relation);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CompareWithGeometry(ref ID2D1Geometry inputGeometry, ref Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
                {
                    fixed (GeometryRelation* relationPtr = &relation)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)LpVtbl[8])(@this, inputGeometryPtr, inputGeometryTransformPtr, flatteningTolerance, relationPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Simplify(GeometrySimplificationOption simplificationOption, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[9])(@this, simplificationOption, worldTransform, flatteningTolerance, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Simplify(GeometrySimplificationOption simplificationOption, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[9])(@this, simplificationOption, worldTransform, flatteningTolerance, geometrySinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Simplify(GeometrySimplificationOption simplificationOption, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[9])(@this, simplificationOption, worldTransformPtr, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Simplify(GeometrySimplificationOption simplificationOption, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[9])(@this, simplificationOption, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Tessellate(Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1TessellationSink* tessellationSink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)LpVtbl[10])(@this, worldTransform, flatteningTolerance, tessellationSink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Tessellate(Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1TessellationSink tessellationSink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TessellationSink* tessellationSinkPtr = &tessellationSink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)LpVtbl[10])(@this, worldTransform, flatteningTolerance, tessellationSinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Tessellate(ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1TessellationSink* tessellationSink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)LpVtbl[10])(@this, worldTransformPtr, flatteningTolerance, tessellationSink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Tessellate(ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1TessellationSink tessellationSink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1TessellationSink* tessellationSinkPtr = &tessellationSink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)LpVtbl[10])(@this, worldTransformPtr, flatteningTolerance, tessellationSinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ID2D1Geometry* inputGeometry, CombineMode combineMode, Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ID2D1Geometry* inputGeometry, CombineMode combineMode, Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ID2D1Geometry* inputGeometry, CombineMode combineMode, ref Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransformPtr, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ID2D1Geometry* inputGeometry, CombineMode combineMode, ref Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransformPtr, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ref ID2D1Geometry inputGeometry, CombineMode combineMode, Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[11])(@this, inputGeometryPtr, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ref ID2D1Geometry inputGeometry, CombineMode combineMode, Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[11])(@this, inputGeometryPtr, combineMode, inputGeometryTransform, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ref ID2D1Geometry inputGeometry, CombineMode combineMode, ref Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[11])(@this, inputGeometryPtr, combineMode, inputGeometryTransformPtr, flatteningTolerance, geometrySink);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CombineWithGeometry(ref ID2D1Geometry inputGeometry, CombineMode combineMode, ref Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
                {
                    fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[11])(@this, inputGeometryPtr, combineMode, inputGeometryTransformPtr, flatteningTolerance, geometrySinkPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Outline(Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[12])(@this, worldTransform, flatteningTolerance, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Outline(Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[12])(@this, worldTransform, flatteningTolerance, geometrySinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Outline(ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[12])(@this, worldTransformPtr, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Outline(ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[12])(@this, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeArea(Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, float* area)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)LpVtbl[13])(@this, worldTransform, flatteningTolerance, area);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeArea(Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref float area)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* areaPtr = &area)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)LpVtbl[13])(@this, worldTransform, flatteningTolerance, areaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeArea(ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, float* area)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)LpVtbl[13])(@this, worldTransformPtr, flatteningTolerance, area);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ComputeArea(ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref float area)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (float* areaPtr = &area)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)LpVtbl[13])(@this, worldTransformPtr, flatteningTolerance, areaPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeLength(Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, float* length)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)LpVtbl[14])(@this, worldTransform, flatteningTolerance, length);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeLength(Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref float length)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* lengthPtr = &length)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)LpVtbl[14])(@this, worldTransform, flatteningTolerance, lengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeLength(ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, float* length)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)LpVtbl[14])(@this, worldTransformPtr, flatteningTolerance, length);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ComputeLength(ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref float length)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (float* lengthPtr = &length)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)LpVtbl[14])(@this, worldTransformPtr, flatteningTolerance, lengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, D2D_POINT_2F* point, D2D_POINT_2F* unitTangentVector)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, D2D_POINT_2F*, D2D_POINT_2F*, int>)LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, point, unitTangentVector);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, D2D_POINT_2F* point, ref D2D_POINT_2F unitTangentVector)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_POINT_2F* unitTangentVectorPtr = &unitTangentVector)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, D2D_POINT_2F*, D2D_POINT_2F*, int>)LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, point, unitTangentVectorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref D2D_POINT_2F point, D2D_POINT_2F* unitTangentVector)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_POINT_2F* pointPtr = &point)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, D2D_POINT_2F*, D2D_POINT_2F*, int>)LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, pointPtr, unitTangentVector);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref D2D_POINT_2F point, ref D2D_POINT_2F unitTangentVector)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_POINT_2F* pointPtr = &point)
            {
                fixed (D2D_POINT_2F* unitTangentVectorPtr = &unitTangentVector)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, D2D_POINT_2F*, D2D_POINT_2F*, int>)LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, pointPtr, unitTangentVectorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, D2D_POINT_2F* point, D2D_POINT_2F* unitTangentVector)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, D2D_POINT_2F*, D2D_POINT_2F*, int>)LpVtbl[15])(@this, length, worldTransformPtr, flatteningTolerance, point, unitTangentVector);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, D2D_POINT_2F* point, ref D2D_POINT_2F unitTangentVector)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (D2D_POINT_2F* unitTangentVectorPtr = &unitTangentVector)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, D2D_POINT_2F*, D2D_POINT_2F*, int>)LpVtbl[15])(@this, length, worldTransformPtr, flatteningTolerance, point, unitTangentVectorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref D2D_POINT_2F point, D2D_POINT_2F* unitTangentVector)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (D2D_POINT_2F* pointPtr = &point)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, D2D_POINT_2F*, D2D_POINT_2F*, int>)LpVtbl[15])(@this, length, worldTransformPtr, flatteningTolerance, pointPtr, unitTangentVector);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ComputePointAtLength(float length, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref D2D_POINT_2F point, ref D2D_POINT_2F unitTangentVector)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (D2D_POINT_2F* pointPtr = &point)
                {
                    fixed (D2D_POINT_2F* unitTangentVectorPtr = &unitTangentVector)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, D2D_POINT_2F*, D2D_POINT_2F*, int>)LpVtbl[15])(@this, length, worldTransformPtr, flatteningTolerance, pointPtr, unitTangentVectorPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ID2D1StrokeStyle* strokeStyle, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ID2D1StrokeStyle* strokeStyle, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ID2D1StrokeStyle* strokeStyle, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ID2D1StrokeStyle* strokeStyle, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[16])(@this, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[16])(@this, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[16])(@this, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, geometrySink);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Widen(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)LpVtbl[16])(@this, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetEllipse(Ellipse* ellipse)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Ellipse*, void>)LpVtbl[17])(@this, ellipse);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetEllipse(ref Ellipse ellipse)
        {
            var @this = (ID2D1EllipseGeometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Ellipse*, void>)LpVtbl[17])(@this, ellipsePtr);
            }
        }

    }
}
