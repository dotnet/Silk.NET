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
    [Guid("0d85573c-01e3-4f7d-bfd9-0d60608bf3c3")]
    [NativeName("Name", "ID2D1ComputeTransform")]
    public unsafe partial struct ID2D1ComputeTransform : IComVtbl<ID2D1ComputeTransform>, IComVtbl<ID2D1Transform>, IComVtbl<ID2D1TransformNode>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0d85573c-01e3-4f7d-bfd9-0d60608bf3c3");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Transform(ID2D1ComputeTransform val)
            => Unsafe.As<ID2D1ComputeTransform, ID2D1Transform>(ref val);

        public static implicit operator ID2D1TransformNode(ID2D1ComputeTransform val)
            => Unsafe.As<ID2D1ComputeTransform, ID2D1TransformNode>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1ComputeTransform val)
            => Unsafe.As<ID2D1ComputeTransform, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1ComputeTransform
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
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetInputCount()
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapOutputRectToInputRects([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* inputRects, uint inputRectsCount)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[4])(@this, outputRect, inputRects, inputRectsCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapOutputRectToInputRects([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> inputRects, uint inputRectsCount)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[4])(@this, outputRect, inputRectsPtr, inputRectsCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapOutputRectToInputRects([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* inputRects, uint inputRectsCount)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[4])(@this, outputRectPtr, inputRects, inputRectsCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MapOutputRectToInputRects([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> inputRects, uint inputRectsCount)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[4])(@this, outputRectPtr, inputRectsPtr, inputRectsCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRect);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MapInputRectsToOutputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
                    {
                        fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInvalidRect(uint inputIndex, Silk.NET.Maths.Box2D<int> invalidInputRect, Silk.NET.Maths.Box2D<int>* invalidOutputRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, uint, Silk.NET.Maths.Box2D<int>, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[6])(@this, inputIndex, invalidInputRect, invalidOutputRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MapInvalidRect(uint inputIndex, Silk.NET.Maths.Box2D<int> invalidInputRect, ref Silk.NET.Maths.Box2D<int> invalidOutputRect)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* invalidOutputRectPtr = &invalidOutputRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, uint, Silk.NET.Maths.Box2D<int>, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[6])(@this, inputIndex, invalidInputRect, invalidOutputRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetComputeInfo(ID2D1ComputeInfo* computeInfo)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, ID2D1ComputeInfo*, int>)@this->LpVtbl[7])(@this, computeInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetComputeInfo(ref ID2D1ComputeInfo computeInfo)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ComputeInfo* computeInfoPtr = &computeInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, ID2D1ComputeInfo*, int>)@this->LpVtbl[7])(@this, computeInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, uint* dimensionX, uint* dimensionY, uint* dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionX, dimensionY, dimensionZ);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, uint* dimensionX, uint* dimensionY, ref uint dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* dimensionZPtr = &dimensionZ)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionX, dimensionY, dimensionZPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, uint* dimensionX, ref uint dimensionY, uint* dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* dimensionYPtr = &dimensionY)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionX, dimensionYPtr, dimensionZ);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, uint* dimensionX, ref uint dimensionY, ref uint dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* dimensionYPtr = &dimensionY)
            {
                fixed (uint* dimensionZPtr = &dimensionZ)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionX, dimensionYPtr, dimensionZPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, ref uint dimensionX, uint* dimensionY, uint* dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* dimensionXPtr = &dimensionX)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionXPtr, dimensionY, dimensionZ);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, ref uint dimensionX, uint* dimensionY, ref uint dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* dimensionXPtr = &dimensionX)
            {
                fixed (uint* dimensionZPtr = &dimensionZ)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionXPtr, dimensionY, dimensionZPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, ref uint dimensionX, ref uint dimensionY, uint* dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* dimensionXPtr = &dimensionX)
            {
                fixed (uint* dimensionYPtr = &dimensionY)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionXPtr, dimensionYPtr, dimensionZ);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, ref uint dimensionX, ref uint dimensionY, ref uint dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* dimensionXPtr = &dimensionX)
            {
                fixed (uint* dimensionYPtr = &dimensionY)
                {
                    fixed (uint* dimensionZPtr = &dimensionZ)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionXPtr, dimensionYPtr, dimensionZPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, uint* dimensionX, uint* dimensionY, uint* dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionX, dimensionY, dimensionZ);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, uint* dimensionX, uint* dimensionY, ref uint dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                fixed (uint* dimensionZPtr = &dimensionZ)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionX, dimensionY, dimensionZPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, uint* dimensionX, ref uint dimensionY, uint* dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                fixed (uint* dimensionYPtr = &dimensionY)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionX, dimensionYPtr, dimensionZ);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, uint* dimensionX, ref uint dimensionY, ref uint dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                fixed (uint* dimensionYPtr = &dimensionY)
                {
                    fixed (uint* dimensionZPtr = &dimensionZ)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionX, dimensionYPtr, dimensionZPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, ref uint dimensionX, uint* dimensionY, uint* dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                fixed (uint* dimensionXPtr = &dimensionX)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionXPtr, dimensionY, dimensionZ);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, ref uint dimensionX, uint* dimensionY, ref uint dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                fixed (uint* dimensionXPtr = &dimensionX)
                {
                    fixed (uint* dimensionZPtr = &dimensionZ)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionXPtr, dimensionY, dimensionZPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, ref uint dimensionX, ref uint dimensionY, uint* dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                fixed (uint* dimensionXPtr = &dimensionX)
                {
                    fixed (uint* dimensionYPtr = &dimensionY)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionXPtr, dimensionYPtr, dimensionZ);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CalculateThreadgroups([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, ref uint dimensionX, ref uint dimensionY, ref uint dimensionZ)
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                fixed (uint* dimensionXPtr = &dimensionX)
                {
                    fixed (uint* dimensionYPtr = &dimensionY)
                    {
                        fixed (uint* dimensionZPtr = &dimensionZ)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionXPtr, dimensionYPtr, dimensionZPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetComputeInfo<TI0>(ComPtr<TI0> computeInfo) where TI0 : unmanaged, IComVtbl<ID2D1ComputeInfo>, IComVtbl<TI0>
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetComputeInfo((ID2D1ComputeInfo*) computeInfo.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1ComputeTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
