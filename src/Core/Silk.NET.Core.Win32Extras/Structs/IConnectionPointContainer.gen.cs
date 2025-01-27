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
    [Guid("b196b284-bab4-101a-b69c-00aa00341d07")]
    [NativeName("Name", "IConnectionPointContainer")]
    public unsafe partial struct IConnectionPointContainer : IComVtbl<IConnectionPointContainer>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b196b284-bab4-101a-b69c-00aa00341d07");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IConnectionPointContainer val)
            => Unsafe.As<IConnectionPointContainer, Silk.NET.Core.Native.IUnknown>(ref val);

        public IConnectionPointContainer
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
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumConnectionPoints(IEnumConnectionPoints** ppEnum)
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, IEnumConnectionPoints**, int>)@this->LpVtbl[3])(@this, ppEnum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumConnectionPoints(ref IEnumConnectionPoints* ppEnum)
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumConnectionPoints** ppEnumPtr = &ppEnum)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, IEnumConnectionPoints**, int>)@this->LpVtbl[3])(@this, ppEnumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindConnectionPoint(Guid* riid, IConnectionPoint** ppCP)
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, IConnectionPoint**, int>)@this->LpVtbl[4])(@this, riid, ppCP);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindConnectionPoint(Guid* riid, ref IConnectionPoint* ppCP)
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IConnectionPoint** ppCPPtr = &ppCP)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, IConnectionPoint**, int>)@this->LpVtbl[4])(@this, riid, ppCPPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindConnectionPoint(ref Guid riid, IConnectionPoint** ppCP)
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, IConnectionPoint**, int>)@this->LpVtbl[4])(@this, riidPtr, ppCP);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindConnectionPoint(ref Guid riid, ref IConnectionPoint* ppCP)
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (IConnectionPoint** ppCPPtr = &ppCP)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, IConnectionPoint**, int>)@this->LpVtbl[4])(@this, riidPtr, ppCPPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumConnectionPoints<TI0>(ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<IEnumConnectionPoints>, IComVtbl<TI0>
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnumConnectionPoints((IEnumConnectionPoints**) ppEnum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int FindConnectionPoint<TI0>(out ComPtr<TI0> ppCP) where TI0 : unmanaged, IComVtbl<IConnectionPoint>, IComVtbl<TI0>
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCP = default;
            return @this->FindConnectionPoint(SilkMarshal.GuidPtrOf<TI0>(), (IConnectionPoint**) ppCP.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int FindConnectionPoint<TI0>(ref Guid riid, ref ComPtr<TI0> ppCP) where TI0 : unmanaged, IComVtbl<IConnectionPoint>, IComVtbl<TI0>
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindConnectionPoint(ref riid, (IConnectionPoint**) ppCP.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> FindConnectionPoint<TI0>() where TI0 : unmanaged, IComVtbl<IConnectionPoint>, IComVtbl<TI0>
        {
            var @this = (IConnectionPointContainer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->FindConnectionPoint(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
