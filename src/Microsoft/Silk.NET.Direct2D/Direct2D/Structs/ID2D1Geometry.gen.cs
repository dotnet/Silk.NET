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
    [Guid("2cd906a1-12e2-11dc-9fed-001143a055f9")]
    [NativeName("Name", "ID2D1Geometry")]
    public unsafe partial struct ID2D1Geometry : IComVtbl<ID2D1Geometry>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("2cd906a1-12e2-11dc-9fed-001143a055f9");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Resource(ID2D1Geometry val)
            => Unsafe.As<ID2D1Geometry, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Geometry val)
            => Unsafe.As<ID2D1Geometry, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Geometry
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
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[4])(@this, worldTransform, bounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[4])(@this, worldTransform, boundsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBounds([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[4])(@this, worldTransformPtr, bounds);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBounds([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[4])(@this, worldTransformPtr, boundsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, bounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, boundsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, bounds);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, boundsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, bounds);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, boundsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, bounds);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWidenedBounds(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, boundsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, contains);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref int contains)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* containsPtr = &contains)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, containsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, contains);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref int contains)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (int* containsPtr = &contains)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, containsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, contains);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref int contains)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (int* containsPtr = &contains)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, containsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint(Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, contains);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StrokeContainsPoint(Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref int contains)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (int* containsPtr = &contains)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, containsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillContainsPoint(Silk.NET.Maths.Vector2D<float> point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[7])(@this, point, worldTransform, flatteningTolerance, contains);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillContainsPoint(Silk.NET.Maths.Vector2D<float> point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref int contains)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* containsPtr = &contains)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[7])(@this, point, worldTransform, flatteningTolerance, containsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FillContainsPoint(Silk.NET.Maths.Vector2D<float> point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, int* contains)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[7])(@this, point, worldTransformPtr, flatteningTolerance, contains);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FillContainsPoint(Silk.NET.Maths.Vector2D<float> point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref int contains)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (int* containsPtr = &contains)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[7])(@this, point, worldTransformPtr, flatteningTolerance, containsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ID2D1Geometry* inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometry, inputGeometryTransform, flatteningTolerance, relation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ID2D1Geometry* inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GeometryRelation* relationPtr = &relation)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometry, inputGeometryTransform, flatteningTolerance, relationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ID2D1Geometry* inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometry, inputGeometryTransformPtr, flatteningTolerance, relation);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ID2D1Geometry* inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
            {
                fixed (GeometryRelation* relationPtr = &relation)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometry, inputGeometryTransformPtr, flatteningTolerance, relationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ref ID2D1Geometry inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometryPtr, inputGeometryTransform, flatteningTolerance, relation);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ref ID2D1Geometry inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                fixed (GeometryRelation* relationPtr = &relation)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometryPtr, inputGeometryTransform, flatteningTolerance, relationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry(ref ID2D1Geometry inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometryPtr, inputGeometryTransformPtr, flatteningTolerance, relation);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CompareWithGeometry(ref ID2D1Geometry inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
                {
                    fixed (GeometryRelation* relationPtr = &relation)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometryPtr, inputGeometryTransformPtr, flatteningTolerance, relationPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Simplify(GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[9])(@this, simplificationOption, worldTransform, flatteningTolerance, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Simplify(GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[9])(@this, simplificationOption, worldTransform, flatteningTolerance, geometrySinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Simplify(GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[9])(@this, simplificationOption, worldTransformPtr, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Simplify(GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[9])(@this, simplificationOption, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Tessellate([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1TessellationSink* tessellationSink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)@this->LpVtbl[10])(@this, worldTransform, flatteningTolerance, tessellationSink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Tessellate([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1TessellationSink tessellationSink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TessellationSink* tessellationSinkPtr = &tessellationSink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)@this->LpVtbl[10])(@this, worldTransform, flatteningTolerance, tessellationSinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Tessellate([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1TessellationSink* tessellationSink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)@this->LpVtbl[10])(@this, worldTransformPtr, flatteningTolerance, tessellationSink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Tessellate([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1TessellationSink tessellationSink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1TessellationSink* tessellationSinkPtr = &tessellationSink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)@this->LpVtbl[10])(@this, worldTransformPtr, flatteningTolerance, tessellationSinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ID2D1Geometry* inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ID2D1Geometry* inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ID2D1Geometry* inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransformPtr, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ID2D1Geometry* inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransformPtr, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ref ID2D1Geometry inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometryPtr, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ref ID2D1Geometry inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometryPtr, combineMode, inputGeometryTransform, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry(ref ID2D1Geometry inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometryPtr, combineMode, inputGeometryTransformPtr, flatteningTolerance, geometrySink);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CombineWithGeometry(ref ID2D1Geometry inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
                {
                    fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometryPtr, combineMode, inputGeometryTransformPtr, flatteningTolerance, geometrySinkPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Outline([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, worldTransform, flatteningTolerance, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Outline([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, worldTransform, flatteningTolerance, geometrySinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Outline([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, worldTransformPtr, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Outline([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeArea([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, float* area)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[13])(@this, worldTransform, flatteningTolerance, area);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeArea([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref float area)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* areaPtr = &area)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[13])(@this, worldTransform, flatteningTolerance, areaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeArea([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, float* area)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[13])(@this, worldTransformPtr, flatteningTolerance, area);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ComputeArea([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref float area)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (float* areaPtr = &area)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[13])(@this, worldTransformPtr, flatteningTolerance, areaPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, float* length)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[14])(@this, worldTransform, flatteningTolerance, length);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref float length)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* lengthPtr = &length)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[14])(@this, worldTransform, flatteningTolerance, lengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, float* length)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[14])(@this, worldTransformPtr, flatteningTolerance, length);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ComputeLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref float length)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (float* lengthPtr = &length)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[14])(@this, worldTransformPtr, flatteningTolerance, lengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Vector2D<float>* point, Silk.NET.Maths.Vector2D<float>* unitTangentVector)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, point, unitTangentVector);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Vector2D<float>* point, ref Silk.NET.Maths.Vector2D<float> unitTangentVector)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* unitTangentVectorPtr = &unitTangentVector)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, point, unitTangentVectorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Vector2D<float> point, Silk.NET.Maths.Vector2D<float>* unitTangentVector)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* pointPtr = &point)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, pointPtr, unitTangentVector);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Vector2D<float> point, ref Silk.NET.Maths.Vector2D<float> unitTangentVector)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* pointPtr = &point)
            {
                fixed (Silk.NET.Maths.Vector2D<float>* unitTangentVectorPtr = &unitTangentVector)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, pointPtr, unitTangentVectorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, Silk.NET.Maths.Vector2D<float>* point, Silk.NET.Maths.Vector2D<float>* unitTangentVector)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransformPtr, flatteningTolerance, point, unitTangentVector);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, Silk.NET.Maths.Vector2D<float>* point, ref Silk.NET.Maths.Vector2D<float> unitTangentVector)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Vector2D<float>* unitTangentVectorPtr = &unitTangentVector)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransformPtr, flatteningTolerance, point, unitTangentVectorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputePointAtLength(float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Vector2D<float> point, Silk.NET.Maths.Vector2D<float>* unitTangentVector)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Vector2D<float>* pointPtr = &point)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransformPtr, flatteningTolerance, pointPtr, unitTangentVector);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ComputePointAtLength(float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Vector2D<float> point, ref Silk.NET.Maths.Vector2D<float> unitTangentVector)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Vector2D<float>* pointPtr = &point)
                {
                    fixed (Silk.NET.Maths.Vector2D<float>* unitTangentVectorPtr = &unitTangentVector)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransformPtr, flatteningTolerance, pointPtr, unitTangentVectorPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, geometrySink);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Widen(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1Geometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFactory<TI0>(ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds<TI0>(float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetWidenedBounds(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, worldTransform, flatteningTolerance, bounds);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds<TI0>(float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Box2D<float> bounds) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetWidenedBounds(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, worldTransform, flatteningTolerance, ref bounds);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWidenedBounds<TI0>(float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetWidenedBounds(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, in worldTransform, flatteningTolerance, bounds);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWidenedBounds<TI0>(float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Box2D<float> bounds) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetWidenedBounds(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, in worldTransform, flatteningTolerance, ref bounds);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint<TI0>(Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StrokeContainsPoint(point, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, worldTransform, flatteningTolerance, contains);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint<TI0>(Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref int contains) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StrokeContainsPoint(point, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, worldTransform, flatteningTolerance, ref contains);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StrokeContainsPoint<TI0>(Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, int* contains) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StrokeContainsPoint(point, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, in worldTransform, flatteningTolerance, contains);
        }

        /// <summary>To be documented.</summary>
        public readonly int StrokeContainsPoint<TI0>(Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref int contains) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StrokeContainsPoint(point, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, in worldTransform, flatteningTolerance, ref contains);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry<TI0>(ComPtr<TI0> inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompareWithGeometry((ID2D1Geometry*) inputGeometry.Handle, inputGeometryTransform, flatteningTolerance, relation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry<TI0>(ComPtr<TI0> inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompareWithGeometry((ID2D1Geometry*) inputGeometry.Handle, inputGeometryTransform, flatteningTolerance, ref relation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompareWithGeometry<TI0>(ComPtr<TI0> inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompareWithGeometry((ID2D1Geometry*) inputGeometry.Handle, in inputGeometryTransform, flatteningTolerance, relation);
        }

        /// <summary>To be documented.</summary>
        public readonly int CompareWithGeometry<TI0>(ComPtr<TI0> inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompareWithGeometry((ID2D1Geometry*) inputGeometry.Handle, in inputGeometryTransform, flatteningTolerance, ref relation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Simplify<TI0>(GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Simplify(simplificationOption, worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Simplify<TI0>(GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Simplify(simplificationOption, in worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Tessellate<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI0> tessellationSink) where TI0 : unmanaged, IComVtbl<ID2D1TessellationSink>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Tessellate(worldTransform, flatteningTolerance, (ID2D1TessellationSink*) tessellationSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Tessellate<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI0> tessellationSink) where TI0 : unmanaged, IComVtbl<ID2D1TessellationSink>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Tessellate(in worldTransform, flatteningTolerance, (ID2D1TessellationSink*) tessellationSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry<TI0, TI1>(ComPtr<TI0> inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ComPtr<TI1> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI1>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CombineWithGeometry((ID2D1Geometry*) inputGeometry.Handle, combineMode, inputGeometryTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry<TI0>(ComPtr<TI0> inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CombineWithGeometry((ID2D1Geometry*) inputGeometry.Handle, combineMode, inputGeometryTransform, flatteningTolerance, ref geometrySink);
        }

        /// <summary>To be documented.</summary>
        public readonly int CombineWithGeometry<TI0, TI1>(ComPtr<TI0> inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ComPtr<TI1> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI1>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CombineWithGeometry((ID2D1Geometry*) inputGeometry.Handle, combineMode, in inputGeometryTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int CombineWithGeometry<TI0>(ComPtr<TI0> inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CombineWithGeometry((ID2D1Geometry*) inputGeometry.Handle, combineMode, in inputGeometryTransform, flatteningTolerance, ref geometrySink);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CombineWithGeometry<TI0>(ref ID2D1Geometry inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CombineWithGeometry(ref inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int CombineWithGeometry<TI0>(ref ID2D1Geometry inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CombineWithGeometry(ref inputGeometry, combineMode, in inputGeometryTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Outline<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Outline(worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Outline<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Outline(in worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen<TI0, TI1>(float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI1> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI1>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Widen(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen<TI0>(float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Widen(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, worldTransform, flatteningTolerance, ref geometrySink);
        }

        /// <summary>To be documented.</summary>
        public readonly int Widen<TI0, TI1>(float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI1> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI1>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Widen(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, in worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Widen<TI0>(float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Widen(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, in worldTransform, flatteningTolerance, ref geometrySink);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Widen<TI0>(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Widen(strokeWidth, ref strokeStyle, worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Widen<TI0>(float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Widen(strokeWidth, ref strokeStyle, in worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1Geometry*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
