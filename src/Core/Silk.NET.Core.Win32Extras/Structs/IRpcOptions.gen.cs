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
    public unsafe partial struct IRpcOptions
    {
        public static readonly Guid Guid = new("00000144-0000-0000-c000-000000000046");

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
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Set(Silk.NET.Core.Native.IUnknown* pPrx, TagRPCOPTPROPERTIES dwProperty, nuint dwValue)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, TagRPCOPTPROPERTIES, nuint, int>)LpVtbl[3])(@this, pPrx, dwProperty, dwValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Set(ref Silk.NET.Core.Native.IUnknown pPrx, TagRPCOPTPROPERTIES dwProperty, nuint dwValue)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pPrxPtr = &pPrx)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, TagRPCOPTPROPERTIES, nuint, int>)LpVtbl[3])(@this, pPrxPtr, dwProperty, dwValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query(Silk.NET.Core.Native.IUnknown* pPrx, TagRPCOPTPROPERTIES dwProperty, nuint* pdwValue)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, TagRPCOPTPROPERTIES, nuint*, int>)LpVtbl[4])(@this, pPrx, dwProperty, pdwValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query(Silk.NET.Core.Native.IUnknown* pPrx, TagRPCOPTPROPERTIES dwProperty, ref nuint pdwValue)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pdwValuePtr = &pdwValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, TagRPCOPTPROPERTIES, nuint*, int>)LpVtbl[4])(@this, pPrx, dwProperty, pdwValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query(ref Silk.NET.Core.Native.IUnknown pPrx, TagRPCOPTPROPERTIES dwProperty, nuint* pdwValue)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pPrxPtr = &pPrx)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, TagRPCOPTPROPERTIES, nuint*, int>)LpVtbl[4])(@this, pPrxPtr, dwProperty, pdwValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Query(ref Silk.NET.Core.Native.IUnknown pPrx, TagRPCOPTPROPERTIES dwProperty, ref nuint pdwValue)
        {
            var @this = (IRpcOptions*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pPrxPtr = &pPrx)
            {
                fixed (nuint* pdwValuePtr = &pdwValue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, TagRPCOPTPROPERTIES, nuint*, int>)LpVtbl[4])(@this, pPrxPtr, dwProperty, pdwValuePtr);
                }
            }
            return ret;
        }

    }
}
