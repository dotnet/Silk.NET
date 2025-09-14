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
    [Guid("f1c0ca52-92a3-4f00-b4ce-f35691efd9d9")]
    [NativeName("Name", "ID2D1SvgStrokeDashArray")]
    public unsafe partial struct ID2D1SvgStrokeDashArray : IComVtbl<ID2D1SvgStrokeDashArray>, IComVtbl<ID2D1SvgAttribute>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("f1c0ca52-92a3-4f00-b4ce-f35691efd9d9");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1SvgAttribute(ID2D1SvgStrokeDashArray val)
            => Unsafe.As<ID2D1SvgStrokeDashArray, ID2D1SvgAttribute>(ref val);

        public static implicit operator ID2D1Resource(ID2D1SvgStrokeDashArray val)
            => Unsafe.As<ID2D1SvgStrokeDashArray, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1SvgStrokeDashArray val)
            => Unsafe.As<ID2D1SvgStrokeDashArray, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1SvgStrokeDashArray
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
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetElement(ID2D1SvgElement** element)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, element);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetElement(ref ID2D1SvgElement* element)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgElement** elementPtr = &element)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, elementPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ID2D1SvgAttribute** attribute)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attribute);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ref ID2D1SvgAttribute* attribute)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgAttribute** attributePtr = &attribute)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attributePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveDashesAtEnd(uint dashesCount)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, uint, int>)@this->LpVtbl[6])(@this, dashesCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateDashes([Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, uint startIndex)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, float*, uint, uint, int>)@this->LpVtbl[8])(@this, dashes, dashesCount, startIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateDashes([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float dashes, uint dashesCount, uint startIndex)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dashesPtr = &dashes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, float*, uint, uint, int>)@this->LpVtbl[8])(@this, dashesPtr, dashesCount, startIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDashes(float* dashes, uint dashesCount, uint startIndex)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, float*, uint, uint, int>)@this->LpVtbl[10])(@this, dashes, dashesCount, startIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDashes(ref float dashes, uint dashesCount, uint startIndex)
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dashesPtr = &dashes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, float*, uint, uint, int>)@this->LpVtbl[10])(@this, dashesPtr, dashesCount, startIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetDashesCount()
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgStrokeDashArray*, uint>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFactory<TI0>(ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetElement<TI0>(ref ComPtr<TI0> element) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetElement((ID2D1SvgElement**) element.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Clone<TI0>(ref ComPtr<TI0> attribute) where TI0 : unmanaged, IComVtbl<ID2D1SvgAttribute>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Clone((ID2D1SvgAttribute**) attribute.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgStrokeDashArray*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
