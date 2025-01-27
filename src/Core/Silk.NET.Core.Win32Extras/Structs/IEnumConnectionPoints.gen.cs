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
    [Guid("b196b285-bab4-101a-b69c-00aa00341d07")]
    [NativeName("Name", "IEnumConnectionPoints")]
    public unsafe partial struct IEnumConnectionPoints : IComVtbl<IEnumConnectionPoints>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b196b285-bab4-101a-b69c-00aa00341d07");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IEnumConnectionPoints val)
            => Unsafe.As<IEnumConnectionPoints, Silk.NET.Core.Native.IUnknown>(ref val);

        public IEnumConnectionPoints
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
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint cConnections, IConnectionPoint** ppCP, uint* pcFetched)
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint, IConnectionPoint**, uint*, int>)@this->LpVtbl[3])(@this, cConnections, ppCP, pcFetched);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint cConnections, IConnectionPoint** ppCP, ref uint pcFetched)
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcFetchedPtr = &pcFetched)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint, IConnectionPoint**, uint*, int>)@this->LpVtbl[3])(@this, cConnections, ppCP, pcFetchedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint cConnections, ref IConnectionPoint* ppCP, uint* pcFetched)
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IConnectionPoint** ppCPPtr = &ppCP)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint, IConnectionPoint**, uint*, int>)@this->LpVtbl[3])(@this, cConnections, ppCPPtr, pcFetched);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint cConnections, ref IConnectionPoint* ppCP, ref uint pcFetched)
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IConnectionPoint** ppCPPtr = &ppCP)
            {
                fixed (uint* pcFetchedPtr = &pcFetched)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint, IConnectionPoint**, uint*, int>)@this->LpVtbl[3])(@this, cConnections, ppCPPtr, pcFetchedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Skip(uint cConnections)
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint, int>)@this->LpVtbl[4])(@this, cConnections);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset()
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(IEnumConnectionPoints** ppEnum)
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, IEnumConnectionPoints**, int>)@this->LpVtbl[6])(@this, ppEnum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ref IEnumConnectionPoints* ppEnum)
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumConnectionPoints** ppEnumPtr = &ppEnum)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, IEnumConnectionPoints**, int>)@this->LpVtbl[6])(@this, ppEnumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next<TI0>(uint cConnections, ref ComPtr<TI0> ppCP, uint* pcFetched) where TI0 : unmanaged, IComVtbl<IConnectionPoint>, IComVtbl<TI0>
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Next(cConnections, (IConnectionPoint**) ppCP.GetAddressOf(), pcFetched);
        }

        /// <summary>To be documented.</summary>
        public readonly int Next<TI0>(uint cConnections, ref ComPtr<TI0> ppCP, ref uint pcFetched) where TI0 : unmanaged, IComVtbl<IConnectionPoint>, IComVtbl<TI0>
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Next(cConnections, (IConnectionPoint**) ppCP.GetAddressOf(), ref pcFetched);
        }

        /// <summary>To be documented.</summary>
        public readonly int Clone<TI0>(ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<IEnumConnectionPoints>, IComVtbl<TI0>
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Clone((IEnumConnectionPoints**) ppEnum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IEnumConnectionPoints*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
