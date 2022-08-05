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
    [Guid("db1800dd-0c34-4cf9-be90-31cc0a5653e1")]
    [NativeName("Name", "ID2D1SourceTransform")]
    public unsafe partial struct ID2D1SourceTransform
    {
        public static readonly Guid Guid = new("db1800dd-0c34-4cf9-be90-31cc0a5653e1");

        public static implicit operator ID2D1Transform(ID2D1SourceTransform val)
            => Unsafe.As<ID2D1SourceTransform, ID2D1Transform>(ref val);

        public static implicit operator ID2D1TransformNode(ID2D1SourceTransform val)
            => Unsafe.As<ID2D1SourceTransform, ID2D1TransformNode>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1SourceTransform val)
            => Unsafe.As<ID2D1SourceTransform, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1SourceTransform
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
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetInputCount()
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint>)LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapOutputRectToInputRects(Silk.NET.Maths.Rectangle<int>* outputRect, Silk.NET.Maths.Rectangle<int>* inputRects, uint inputRectsCount)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[4])(@this, outputRect, inputRects, inputRectsCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapOutputRectToInputRects(Silk.NET.Maths.Rectangle<int>* outputRect, ref Silk.NET.Maths.Rectangle<int> inputRects, uint inputRectsCount)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* inputRectsPtr = &inputRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[4])(@this, outputRect, inputRectsPtr, inputRectsCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapOutputRectToInputRects(ref Silk.NET.Maths.Rectangle<int> outputRect, Silk.NET.Maths.Rectangle<int>* inputRects, uint inputRectsCount)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* outputRectPtr = &outputRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[4])(@this, outputRectPtr, inputRects, inputRectsCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MapOutputRectToInputRects(ref Silk.NET.Maths.Rectangle<int> outputRect, ref Silk.NET.Maths.Rectangle<int> inputRects, uint inputRectsCount)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* outputRectPtr = &outputRect)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* inputRectsPtr = &inputRects)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[4])(@this, outputRectPtr, inputRectsPtr, inputRectsCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(Silk.NET.Maths.Rectangle<int>* inputRects, Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Rectangle<int>* outputRect, Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(Silk.NET.Maths.Rectangle<int>* inputRects, Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Rectangle<int>* outputRect, ref Silk.NET.Maths.Rectangle<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(Silk.NET.Maths.Rectangle<int>* inputRects, Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Rectangle<int> outputRect, Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* outputRectPtr = &outputRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(Silk.NET.Maths.Rectangle<int>* inputRects, Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Rectangle<int> outputRect, ref Silk.NET.Maths.Rectangle<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* outputRectPtr = &outputRect)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(Silk.NET.Maths.Rectangle<int>* inputRects, ref Silk.NET.Maths.Rectangle<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Rectangle<int>* outputRect, Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(Silk.NET.Maths.Rectangle<int>* inputRects, ref Silk.NET.Maths.Rectangle<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Rectangle<int>* outputRect, ref Silk.NET.Maths.Rectangle<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(Silk.NET.Maths.Rectangle<int>* inputRects, ref Silk.NET.Maths.Rectangle<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Rectangle<int> outputRect, Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* outputRectPtr = &outputRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(Silk.NET.Maths.Rectangle<int>* inputRects, ref Silk.NET.Maths.Rectangle<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Rectangle<int> outputRect, ref Silk.NET.Maths.Rectangle<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* outputRectPtr = &outputRect)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(ref Silk.NET.Maths.Rectangle<int> inputRects, Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Rectangle<int>* outputRect, Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* inputRectsPtr = &inputRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(ref Silk.NET.Maths.Rectangle<int> inputRects, Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Rectangle<int>* outputRect, ref Silk.NET.Maths.Rectangle<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(ref Silk.NET.Maths.Rectangle<int> inputRects, Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Rectangle<int> outputRect, Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* outputRectPtr = &outputRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(ref Silk.NET.Maths.Rectangle<int> inputRects, Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Rectangle<int> outputRect, ref Silk.NET.Maths.Rectangle<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* outputRectPtr = &outputRect)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(ref Silk.NET.Maths.Rectangle<int> inputRects, ref Silk.NET.Maths.Rectangle<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Rectangle<int>* outputRect, Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(ref Silk.NET.Maths.Rectangle<int> inputRects, ref Silk.NET.Maths.Rectangle<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Rectangle<int>* outputRect, ref Silk.NET.Maths.Rectangle<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInputRectsToOutputRect(ref Silk.NET.Maths.Rectangle<int> inputRects, ref Silk.NET.Maths.Rectangle<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Rectangle<int> outputRect, Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* outputRectPtr = &outputRect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRect);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MapInputRectsToOutputRect(ref Silk.NET.Maths.Rectangle<int> inputRects, ref Silk.NET.Maths.Rectangle<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Rectangle<int> outputRect, ref Silk.NET.Maths.Rectangle<int> outputOpaqueSubRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* inputRectsPtr = &inputRects)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* outputRectPtr = &outputRect)
                    {
                        fixed (Silk.NET.Maths.Rectangle<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapInvalidRect(uint inputIndex, Silk.NET.Maths.Rectangle<int> invalidInputRect, Silk.NET.Maths.Rectangle<int>* invalidOutputRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint, Silk.NET.Maths.Rectangle<int>, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[6])(@this, inputIndex, invalidInputRect, invalidOutputRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MapInvalidRect(uint inputIndex, Silk.NET.Maths.Rectangle<int> invalidInputRect, ref Silk.NET.Maths.Rectangle<int> invalidOutputRect)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* invalidOutputRectPtr = &invalidOutputRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint, Silk.NET.Maths.Rectangle<int>, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[6])(@this, inputIndex, invalidInputRect, invalidOutputRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetRenderInfo(ID2D1RenderInfo* renderInfo)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1RenderInfo*, int>)LpVtbl[7])(@this, renderInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRenderInfo(ref ID2D1RenderInfo renderInfo)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RenderInfo* renderInfoPtr = &renderInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1RenderInfo*, int>)LpVtbl[7])(@this, renderInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw(ID2D1Bitmap1* target, Silk.NET.Maths.Rectangle<int>* drawRect, D2D_POINT_2U targetOrigin)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1Bitmap1*, Silk.NET.Maths.Rectangle<int>*, D2D_POINT_2U, int>)LpVtbl[8])(@this, target, drawRect, targetOrigin);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw(ID2D1Bitmap1* target, ref Silk.NET.Maths.Rectangle<int> drawRect, D2D_POINT_2U targetOrigin)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* drawRectPtr = &drawRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1Bitmap1*, Silk.NET.Maths.Rectangle<int>*, D2D_POINT_2U, int>)LpVtbl[8])(@this, target, drawRectPtr, targetOrigin);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw(ref ID2D1Bitmap1 target, Silk.NET.Maths.Rectangle<int>* drawRect, D2D_POINT_2U targetOrigin)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap1* targetPtr = &target)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1Bitmap1*, Silk.NET.Maths.Rectangle<int>*, D2D_POINT_2U, int>)LpVtbl[8])(@this, targetPtr, drawRect, targetOrigin);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Draw(ref ID2D1Bitmap1 target, ref Silk.NET.Maths.Rectangle<int> drawRect, D2D_POINT_2U targetOrigin)
        {
            var @this = (ID2D1SourceTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap1* targetPtr = &target)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* drawRectPtr = &drawRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1Bitmap1*, Silk.NET.Maths.Rectangle<int>*, D2D_POINT_2U, int>)LpVtbl[8])(@this, targetPtr, drawRectPtr, targetOrigin);
                }
            }
            return ret;
        }

    }
}
