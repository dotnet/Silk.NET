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
    [Guid("d59bab0a-68a2-455b-a5dc-9eb2854e2490")]
    [NativeName("Name", "ID2D1SvgPaint")]
    public unsafe partial struct ID2D1SvgPaint : IComVtbl<ID2D1SvgPaint>, IComVtbl<ID2D1SvgAttribute>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d59bab0a-68a2-455b-a5dc-9eb2854e2490");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1SvgAttribute(ID2D1SvgPaint val)
            => Unsafe.As<ID2D1SvgPaint, ID2D1SvgAttribute>(ref val);

        public static implicit operator ID2D1Resource(ID2D1SvgPaint val)
            => Unsafe.As<ID2D1SvgPaint, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1SvgPaint val)
            => Unsafe.As<ID2D1SvgPaint, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1SvgPaint
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
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetElement(ID2D1SvgElement** element)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, element);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetElement(ref ID2D1SvgElement* element)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgElement** elementPtr = &element)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, elementPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ID2D1SvgAttribute** attribute)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attribute);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ref ID2D1SvgAttribute* attribute)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgAttribute** attributePtr = &attribute)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attributePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPaintType(SvgPaintType paintType)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, SvgPaintType, int>)@this->LpVtbl[6])(@this, paintType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly SvgPaintType GetPaintType()
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            SvgPaintType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, SvgPaintType>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[8])(@this, color);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[8])(@this, colorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetColor(Silk.NET.DXGI.D3Dcolorvalue* color)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, void>)@this->LpVtbl[9])(@this, color);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetColor(ref Silk.NET.DXGI.D3Dcolorvalue color)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, void>)@this->LpVtbl[9])(@this, colorPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetId([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, int>)@this->LpVtbl[10])(@this, id);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetId([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char id)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* idPtr = &id)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, int>)@this->LpVtbl[10])(@this, idPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetId([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, byte*, int>)@this->LpVtbl[10])(@this, idPtr);
            SilkMarshal.Free((nint)idPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetId(char* id, uint idCount)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, uint, int>)@this->LpVtbl[11])(@this, id, idCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetId(ref char id, uint idCount)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* idPtr = &id)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, uint, int>)@this->LpVtbl[11])(@this, idPtr, idCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetId([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, uint idCount)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, byte*, uint, int>)@this->LpVtbl[11])(@this, idPtr, idCount);
            SilkMarshal.Free((nint)idPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetIdLength()
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFactory<TI0>(ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetElement<TI0>(ref ComPtr<TI0> element) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetElement((ID2D1SvgElement**) element.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Clone<TI0>(ref ComPtr<TI0> attribute) where TI0 : unmanaged, IComVtbl<ID2D1SvgAttribute>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Clone((ID2D1SvgAttribute**) attribute.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
