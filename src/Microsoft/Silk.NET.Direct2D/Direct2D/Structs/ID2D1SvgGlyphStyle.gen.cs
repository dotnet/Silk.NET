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
    [Guid("af671749-d241-4db8-8e41-dcc2e5c1a438")]
    [NativeName("Name", "ID2D1SvgGlyphStyle")]
    public unsafe partial struct ID2D1SvgGlyphStyle : IComVtbl<ID2D1SvgGlyphStyle>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("af671749-d241-4db8-8e41-dcc2e5c1a438");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Resource(ID2D1SvgGlyphStyle val)
            => Unsafe.As<ID2D1SvgGlyphStyle, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1SvgGlyphStyle val)
            => Unsafe.As<ID2D1SvgGlyphStyle, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1SvgGlyphStyle
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
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFill(ID2D1Brush* brush)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, int>)@this->LpVtbl[4])(@this, brush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFill(ref ID2D1Brush brush)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, int>)@this->LpVtbl[4])(@this, brushPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFill(ID2D1Brush** brush)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, void>)@this->LpVtbl[5])(@this, brush);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFill(ref ID2D1Brush* brush)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush** brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, void>)@this->LpVtbl[5])(@this, brushPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetStroke(ID2D1Brush* brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, float dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int>)@this->LpVtbl[6])(@this, brush, strokeWidth, dashes, dashesCount, dashOffset);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetStroke(ID2D1Brush* brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, float dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dashesPtr = &dashes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int>)@this->LpVtbl[6])(@this, brush, strokeWidth, dashesPtr, dashesCount, dashOffset);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetStroke(ref ID2D1Brush brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, float dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int>)@this->LpVtbl[6])(@this, brushPtr, strokeWidth, dashes, dashesCount, dashOffset);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStroke(ref ID2D1Brush brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, float dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (float* dashesPtr = &dashes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int>)@this->LpVtbl[6])(@this, brushPtr, strokeWidth, dashesPtr, dashesCount, dashOffset);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetStrokeDashesCount()
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, uint>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ID2D1Brush** brush, float* strokeWidth, float* dashes, uint dashesCount, float* dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidth, dashes, dashesCount, dashOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ID2D1Brush** brush, float* strokeWidth, float* dashes, uint dashesCount, ref float dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dashOffsetPtr = &dashOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidth, dashes, dashesCount, dashOffsetPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ID2D1Brush** brush, float* strokeWidth, ref float dashes, uint dashesCount, float* dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dashesPtr = &dashes)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidth, dashesPtr, dashesCount, dashOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ID2D1Brush** brush, float* strokeWidth, ref float dashes, uint dashesCount, ref float dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dashesPtr = &dashes)
            {
                fixed (float* dashOffsetPtr = &dashOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidth, dashesPtr, dashesCount, dashOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ID2D1Brush** brush, ref float strokeWidth, float* dashes, uint dashesCount, float* dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* strokeWidthPtr = &strokeWidth)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidthPtr, dashes, dashesCount, dashOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ID2D1Brush** brush, ref float strokeWidth, float* dashes, uint dashesCount, ref float dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* strokeWidthPtr = &strokeWidth)
            {
                fixed (float* dashOffsetPtr = &dashOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidthPtr, dashes, dashesCount, dashOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ID2D1Brush** brush, ref float strokeWidth, ref float dashes, uint dashesCount, float* dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* strokeWidthPtr = &strokeWidth)
            {
                fixed (float* dashesPtr = &dashes)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidthPtr, dashesPtr, dashesCount, dashOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ID2D1Brush** brush, ref float strokeWidth, ref float dashes, uint dashesCount, ref float dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* strokeWidthPtr = &strokeWidth)
            {
                fixed (float* dashesPtr = &dashes)
                {
                    fixed (float* dashOffsetPtr = &dashOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidthPtr, dashesPtr, dashesCount, dashOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ref ID2D1Brush* brush, float* strokeWidth, float* dashes, uint dashesCount, float* dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush** brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidth, dashes, dashesCount, dashOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ref ID2D1Brush* brush, float* strokeWidth, float* dashes, uint dashesCount, ref float dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush** brushPtr = &brush)
            {
                fixed (float* dashOffsetPtr = &dashOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidth, dashes, dashesCount, dashOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ref ID2D1Brush* brush, float* strokeWidth, ref float dashes, uint dashesCount, float* dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush** brushPtr = &brush)
            {
                fixed (float* dashesPtr = &dashes)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidth, dashesPtr, dashesCount, dashOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ref ID2D1Brush* brush, float* strokeWidth, ref float dashes, uint dashesCount, ref float dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush** brushPtr = &brush)
            {
                fixed (float* dashesPtr = &dashes)
                {
                    fixed (float* dashOffsetPtr = &dashOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidth, dashesPtr, dashesCount, dashOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ref ID2D1Brush* brush, ref float strokeWidth, float* dashes, uint dashesCount, float* dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush** brushPtr = &brush)
            {
                fixed (float* strokeWidthPtr = &strokeWidth)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidthPtr, dashes, dashesCount, dashOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ref ID2D1Brush* brush, ref float strokeWidth, float* dashes, uint dashesCount, ref float dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush** brushPtr = &brush)
            {
                fixed (float* strokeWidthPtr = &strokeWidth)
                {
                    fixed (float* dashOffsetPtr = &dashOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidthPtr, dashes, dashesCount, dashOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ref ID2D1Brush* brush, ref float strokeWidth, ref float dashes, uint dashesCount, float* dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush** brushPtr = &brush)
            {
                fixed (float* strokeWidthPtr = &strokeWidth)
                {
                    fixed (float* dashesPtr = &dashes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidthPtr, dashesPtr, dashesCount, dashOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke(ref ID2D1Brush* brush, ref float strokeWidth, ref float dashes, uint dashesCount, ref float dashOffset)
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush** brushPtr = &brush)
            {
                fixed (float* strokeWidthPtr = &strokeWidth)
                {
                    fixed (float* dashesPtr = &dashes)
                    {
                        fixed (float* dashOffsetPtr = &dashOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidthPtr, dashesPtr, dashesCount, dashOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFactory<TI0>(ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFill<TI0>(ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetFill((ID2D1Brush*) brush.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFill<TI0>(ref ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetFill((ID2D1Brush**) brush.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetStroke<TI0>(ComPtr<TI0> brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, float dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetStroke((ID2D1Brush*) brush.Handle, strokeWidth, dashes, dashesCount, dashOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStroke<TI0>(ComPtr<TI0> brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, float dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetStroke((ID2D1Brush*) brush.Handle, strokeWidth, in dashes, dashesCount, dashOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke<TI0>(ref ComPtr<TI0> brush, float* strokeWidth, float* dashes, uint dashesCount, float* dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), strokeWidth, dashes, dashesCount, dashOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke<TI0>(ref ComPtr<TI0> brush, float* strokeWidth, float* dashes, uint dashesCount, ref float dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), strokeWidth, dashes, dashesCount, ref dashOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke<TI0>(ref ComPtr<TI0> brush, float* strokeWidth, ref float dashes, uint dashesCount, float* dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), strokeWidth, ref dashes, dashesCount, dashOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke<TI0>(ref ComPtr<TI0> brush, float* strokeWidth, ref float dashes, uint dashesCount, ref float dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), strokeWidth, ref dashes, dashesCount, ref dashOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke<TI0>(ref ComPtr<TI0> brush, ref float strokeWidth, float* dashes, uint dashesCount, float* dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), ref strokeWidth, dashes, dashesCount, dashOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke<TI0>(ref ComPtr<TI0> brush, ref float strokeWidth, float* dashes, uint dashesCount, ref float dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), ref strokeWidth, dashes, dashesCount, ref dashOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetStroke<TI0>(ref ComPtr<TI0> brush, ref float strokeWidth, ref float dashes, uint dashesCount, float* dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), ref strokeWidth, ref dashes, dashesCount, dashOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetStroke<TI0>(ref ComPtr<TI0> brush, ref float strokeWidth, ref float dashes, uint dashesCount, ref float dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), ref strokeWidth, ref dashes, dashesCount, ref dashOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgGlyphStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
