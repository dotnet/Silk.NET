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
    [Guid("1ab42875-c57f-4be9-bd85-9cd78d6f55ee")]
    [NativeName("Name", "ID2D1ColorContext1")]
    public unsafe partial struct ID2D1ColorContext1 : IComVtbl<ID2D1ColorContext1>, IComVtbl<ID2D1ColorContext>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("1ab42875-c57f-4be9-bd85-9cd78d6f55ee");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1ColorContext(ID2D1ColorContext1 val)
            => Unsafe.As<ID2D1ColorContext1, ID2D1ColorContext>(ref val);

        public static implicit operator ID2D1Resource(ID2D1ColorContext1 val)
            => Unsafe.As<ID2D1ColorContext1, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1ColorContext1 val)
            => Unsafe.As<ID2D1ColorContext1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1ColorContext1
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
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly ColorSpace GetColorSpace()
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ColorSpace ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ColorSpace>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetProfileSize()
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, uint>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProfile(byte* profile, uint profileSize)
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, byte*, uint, int>)@this->LpVtbl[6])(@this, profile, profileSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetProfile(ref byte profile, uint profileSize)
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* profilePtr = &profile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, byte*, uint, int>)@this->LpVtbl[6])(@this, profilePtr, profileSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetProfile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize)
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var profilePtr = (byte*) SilkMarshal.StringToPtr(profile, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, byte*, uint, int>)@this->LpVtbl[6])(@this, profilePtr, profileSize);
            SilkMarshal.Free((nint)profilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ColorContextType GetColorContextType()
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ColorContextType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ColorContextType>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.DXGI.ColorSpaceType GetDXGIColorSpace()
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.DXGI.ColorSpaceType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, Silk.NET.DXGI.ColorSpaceType>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSimpleColorProfile(SimpleColorProfile* simpleProfile)
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, SimpleColorProfile*, int>)@this->LpVtbl[9])(@this, simpleProfile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSimpleColorProfile(ref SimpleColorProfile simpleProfile)
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SimpleColorProfile* simpleProfilePtr = &simpleProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, SimpleColorProfile*, int>)@this->LpVtbl[9])(@this, simpleProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFactory<TI0>(ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1ColorContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
