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

namespace Silk.NET.Direct3D12
{
    [Guid("e0d06420-9f31-47e8-ae9a-dd2ba25ac0bc")]
    [NativeName("Name", "ID3D12CompilerFactoryChild")]
    public unsafe partial struct ID3D12CompilerFactoryChild : IComVtbl<ID3D12CompilerFactoryChild>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("e0d06420-9f31-47e8-ae9a-dd2ba25ac0bc");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12CompilerFactoryChild val)
            => Unsafe.As<ID3D12CompilerFactoryChild, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12CompilerFactoryChild
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
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactoryChild*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactoryChild*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactoryChild*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactoryChild*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactoryChild*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactoryChild*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFactory(Guid* riid, void** ppCompilerFactory)
        {
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactoryChild*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppCompilerFactory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFactory(Guid* riid, ref void* ppCompilerFactory)
        {
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCompilerFactoryPtr = &ppCompilerFactory)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactoryChild*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppCompilerFactoryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFactory(ref Guid riid, void** ppCompilerFactory)
        {
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactoryChild*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppCompilerFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFactory(ref Guid riid, ref void* ppCompilerFactory)
        {
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCompilerFactoryPtr = &ppCompilerFactory)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactoryChild*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppCompilerFactoryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFactory<TI0>(out ComPtr<TI0> ppCompilerFactory) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerFactory = default;
            return @this->GetFactory(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerFactory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetFactory<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactoryChild*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetFactory(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
