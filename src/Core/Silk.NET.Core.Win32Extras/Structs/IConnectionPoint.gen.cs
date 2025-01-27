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
    [Guid("b196b286-bab4-101a-b69c-00aa00341d07")]
    [NativeName("Name", "IConnectionPoint")]
    public unsafe partial struct IConnectionPoint : IComVtbl<IConnectionPoint>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b196b286-bab4-101a-b69c-00aa00341d07");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IConnectionPoint val)
            => Unsafe.As<IConnectionPoint, Silk.NET.Core.Native.IUnknown>(ref val);

        public IConnectionPoint
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
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetConnectionInterface(Guid* pIID)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Guid*, int>)@this->LpVtbl[3])(@this, pIID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetConnectionInterface(ref Guid pIID)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pIIDPtr = &pIID)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Guid*, int>)@this->LpVtbl[3])(@this, pIIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetConnectionPointContainer(IConnectionPointContainer** ppCPC)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, IConnectionPointContainer**, int>)@this->LpVtbl[4])(@this, ppCPC);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetConnectionPointContainer(ref IConnectionPointContainer* ppCPC)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IConnectionPointContainer** ppCPCPtr = &ppCPC)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, IConnectionPointContainer**, int>)@this->LpVtbl[4])(@this, ppCPCPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(Silk.NET.Core.Native.IUnknown* pUnkSink, uint* pdwCookie)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[5])(@this, pUnkSink, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(Silk.NET.Core.Native.IUnknown* pUnkSink, ref uint pdwCookie)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[5])(@this, pUnkSink, pdwCookiePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise(ref Silk.NET.Core.Native.IUnknown pUnkSink, uint* pdwCookie)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkSinkPtr = &pUnkSink)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[5])(@this, pUnkSinkPtr, pdwCookie);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Advise(ref Silk.NET.Core.Native.IUnknown pUnkSink, ref uint pdwCookie)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkSinkPtr = &pUnkSink)
            {
                fixed (uint* pdwCookiePtr = &pdwCookie)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[5])(@this, pUnkSinkPtr, pdwCookiePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Unadvise(uint dwCookie)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, uint, int>)@this->LpVtbl[6])(@this, dwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumConnections(IEnumConnections** ppEnum)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, IEnumConnections**, int>)@this->LpVtbl[7])(@this, ppEnum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumConnections(ref IEnumConnections* ppEnum)
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumConnections** ppEnumPtr = &ppEnum)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, IEnumConnections**, int>)@this->LpVtbl[7])(@this, ppEnumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetConnectionPointContainer<TI0>(ref ComPtr<TI0> ppCPC) where TI0 : unmanaged, IComVtbl<IConnectionPointContainer>, IComVtbl<TI0>
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetConnectionPointContainer((IConnectionPointContainer**) ppCPC.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Advise<TI0>(ComPtr<TI0> pUnkSink, uint* pdwCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise((Silk.NET.Core.Native.IUnknown*) pUnkSink.Handle, pdwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly int Advise<TI0>(ComPtr<TI0> pUnkSink, ref uint pdwCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Advise((Silk.NET.Core.Native.IUnknown*) pUnkSink.Handle, ref pdwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumConnections<TI0>(ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<IEnumConnections>, IComVtbl<TI0>
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnumConnections((IEnumConnections**) ppEnum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IConnectionPoint*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
