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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("00000144-0000-0000-c000-000000000046")]
    [NativeName("Name", "IRpcOptions")]
    public unsafe partial struct IRpcOptions : IComVtbl<IRpcOptions>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000144-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IRpcOptions val)
            => Unsafe.As<IRpcOptions, Silk.NET.Core.Native.IUnknown>(ref val);

        public IRpcOptions
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
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Set(Silk.NET.Core.Native.IUnknown* pPrx, RPCOptProperties dwProperty, nuint dwValue)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, RPCOptProperties, nuint, int>)@this->LpVtbl[3])(@this, pPrx, dwProperty, dwValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Set(ref Silk.NET.Core.Native.IUnknown pPrx, RPCOptProperties dwProperty, nuint dwValue)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pPrxPtr = &pPrx)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, RPCOptProperties, nuint, int>)@this->LpVtbl[3])(@this, pPrxPtr, dwProperty, dwValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query(Silk.NET.Core.Native.IUnknown* pPrx, RPCOptProperties dwProperty, nuint* pdwValue)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, RPCOptProperties, nuint*, int>)@this->LpVtbl[4])(@this, pPrx, dwProperty, pdwValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query(Silk.NET.Core.Native.IUnknown* pPrx, RPCOptProperties dwProperty, ref nuint pdwValue)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pdwValuePtr = &pdwValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, RPCOptProperties, nuint*, int>)@this->LpVtbl[4])(@this, pPrx, dwProperty, pdwValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query(ref Silk.NET.Core.Native.IUnknown pPrx, RPCOptProperties dwProperty, nuint* pdwValue)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pPrxPtr = &pPrx)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, RPCOptProperties, nuint*, int>)@this->LpVtbl[4])(@this, pPrxPtr, dwProperty, pdwValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Query(ref Silk.NET.Core.Native.IUnknown pPrx, RPCOptProperties dwProperty, ref nuint pdwValue)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pPrxPtr = &pPrx)
            {
                fixed (nuint* pdwValuePtr = &pdwValue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, RPCOptProperties, nuint*, int>)@this->LpVtbl[4])(@this, pPrxPtr, dwProperty, pdwValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Set<TI0>(ComPtr<TI0> pPrx, RPCOptProperties dwProperty, nuint dwValue) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Set((Silk.NET.Core.Native.IUnknown*) pPrx.Handle, dwProperty, dwValue);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query<TI0>(ComPtr<TI0> pPrx, RPCOptProperties dwProperty, nuint* pdwValue) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Query((Silk.NET.Core.Native.IUnknown*) pPrx.Handle, dwProperty, pdwValue);
        }

        /// <summary>To be documented.</summary>
        public readonly int Query<TI0>(ComPtr<TI0> pPrx, RPCOptProperties dwProperty, ref nuint pdwValue) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Query((Silk.NET.Core.Native.IUnknown*) pPrx.Handle, dwProperty, ref pdwValue);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
