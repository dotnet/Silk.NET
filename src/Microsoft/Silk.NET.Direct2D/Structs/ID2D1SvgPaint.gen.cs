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
    public unsafe partial struct ID2D1SvgPaint
    {
        public static readonly Guid Guid = new("d59bab0a-68a2-455b-a5dc-9eb2854e2490");

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
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1Factory**, void>)LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1Factory**, void>)LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetElement(ID2D1SvgElement** element)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgElement**, void>)LpVtbl[4])(@this, element);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetElement(ref ID2D1SvgElement* element)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgElement** elementPtr = &element)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgElement**, void>)LpVtbl[4])(@this, elementPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ID2D1SvgAttribute** attribute)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgAttribute**, int>)LpVtbl[5])(@this, attribute);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ref ID2D1SvgAttribute* attribute)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgAttribute** attributePtr = &attribute)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgAttribute**, int>)LpVtbl[5])(@this, attributePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPaintType(SvgPaintType paintType)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, SvgPaintType, int>)LpVtbl[6])(@this, paintType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly SvgPaintType GetPaintType()
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            SvgPaintType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, SvgPaintType>)LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetColor(Silk.NET.DXGI.D3Dcolorvalue* color)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, int>)LpVtbl[8])(@this, color);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetColor(ref Silk.NET.DXGI.D3Dcolorvalue color)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, int>)LpVtbl[8])(@this, colorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetColor(Silk.NET.DXGI.D3Dcolorvalue* color)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, void>)LpVtbl[9])(@this, color);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetColor(ref Silk.NET.DXGI.D3Dcolorvalue color)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, void>)LpVtbl[9])(@this, colorPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetId(char* id)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, int>)LpVtbl[10])(@this, id);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetId(ref char id)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* idPtr = &id)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, int>)LpVtbl[10])(@this, idPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetId([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, byte*, int>)LpVtbl[10])(@this, idPtr);
            SilkMarshal.Free((nint)idPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetId(char* id, uint idCount)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, uint, int>)LpVtbl[11])(@this, id, idCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetId(ref char id, uint idCount)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* idPtr = &id)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, uint, int>)LpVtbl[11])(@this, idPtr, idCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetId([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, uint idCount)
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, byte*, uint, int>)LpVtbl[11])(@this, idPtr, idCount);
            SilkMarshal.Free((nint)idPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetIdLength()
        {
            var @this = (ID2D1SvgPaint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)LpVtbl[12])(@this);
            return ret;
        }

    }
}
