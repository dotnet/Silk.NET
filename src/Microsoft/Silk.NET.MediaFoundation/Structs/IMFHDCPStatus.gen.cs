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

namespace Silk.NET.MediaFoundation
{
    [Guid("de400f54-5bf1-40cf-8964-0bea136b1e3d")]
    [NativeName("Name", "IMFHDCPStatus")]
    public unsafe partial struct IMFHDCPStatus : IComVtbl<IMFHDCPStatus>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("de400f54-5bf1-40cf-8964-0bea136b1e3d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFHDCPStatus val)
            => Unsafe.As<IMFHDCPStatus, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFHDCPStatus
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
            var @this = (IMFHDCPStatus*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFHDCPStatus*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFHDCPStatus*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFHDCPStatus*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFHDCPStatus*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFHDCPStatus*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query(HdcpStatus* pStatus, int* pfStatus)
        {
            var @this = (IMFHDCPStatus*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, HdcpStatus*, int*, int>)@this->LpVtbl[3])(@this, pStatus, pfStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query(HdcpStatus* pStatus, ref int pfStatus)
        {
            var @this = (IMFHDCPStatus*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfStatusPtr = &pfStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, HdcpStatus*, int*, int>)@this->LpVtbl[3])(@this, pStatus, pfStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query(ref HdcpStatus pStatus, int* pfStatus)
        {
            var @this = (IMFHDCPStatus*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HdcpStatus* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, HdcpStatus*, int*, int>)@this->LpVtbl[3])(@this, pStatusPtr, pfStatus);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Query(ref HdcpStatus pStatus, ref int pfStatus)
        {
            var @this = (IMFHDCPStatus*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HdcpStatus* pStatusPtr = &pStatus)
            {
                fixed (int* pfStatusPtr = &pfStatus)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, HdcpStatus*, int*, int>)@this->LpVtbl[3])(@this, pStatusPtr, pfStatusPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Set(HdcpStatus status)
        {
            var @this = (IMFHDCPStatus*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, HdcpStatus, int>)@this->LpVtbl[4])(@this, status);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFHDCPStatus*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFHDCPStatus*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
