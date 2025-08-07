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
    [Guid("4d645ace-26aa-4688-9be1-df3516990b93")]
    [NativeName("Name", "IMFMediaEngineClassFactory")]
    public unsafe partial struct IMFMediaEngineClassFactory : IComVtbl<IMFMediaEngineClassFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("4d645ace-26aa-4688-9be1-df3516990b93");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaEngineClassFactory val)
            => Unsafe.As<IMFMediaEngineClassFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaEngineClassFactory
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
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(uint dwFlags, IMFAttributes* pAttr, IMFMediaEngine** ppPlayer)
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttr, ppPlayer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(uint dwFlags, IMFAttributes* pAttr, ref IMFMediaEngine* ppPlayer)
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaEngine** ppPlayerPtr = &ppPlayer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttr, ppPlayerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(uint dwFlags, ref IMFAttributes pAttr, IMFMediaEngine** ppPlayer)
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFAttributes* pAttrPtr = &pAttr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttrPtr, ppPlayer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(uint dwFlags, ref IMFAttributes pAttr, ref IMFMediaEngine* ppPlayer)
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFAttributes* pAttrPtr = &pAttr)
            {
                fixed (IMFMediaEngine** ppPlayerPtr = &ppPlayer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttrPtr, ppPlayerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTimeRange(IMFMediaTimeRange** ppTimeRange)
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, IMFMediaTimeRange**, int>)@this->LpVtbl[4])(@this, ppTimeRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTimeRange(ref IMFMediaTimeRange* ppTimeRange)
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaTimeRange** ppTimeRangePtr = &ppTimeRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, IMFMediaTimeRange**, int>)@this->LpVtbl[4])(@this, ppTimeRangePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateError(IMFMediaError** ppError)
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, IMFMediaError**, int>)@this->LpVtbl[5])(@this, ppError);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateError(ref IMFMediaError* ppError)
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaError** ppErrorPtr = &ppError)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, IMFMediaError**, int>)@this->LpVtbl[5])(@this, ppErrorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance<TI0>(uint dwFlags, IMFAttributes* pAttr, ref ComPtr<TI0> ppPlayer) where TI0 : unmanaged, IComVtbl<IMFMediaEngine>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInstance(dwFlags, pAttr, (IMFMediaEngine**) ppPlayer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateInstance<TI0>(uint dwFlags, ref IMFAttributes pAttr, ref ComPtr<TI0> ppPlayer) where TI0 : unmanaged, IComVtbl<IMFMediaEngine>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInstance(dwFlags, ref pAttr, (IMFMediaEngine**) ppPlayer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTimeRange<TI0>(ref ComPtr<TI0> ppTimeRange) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTimeRange((IMFMediaTimeRange**) ppTimeRange.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateError<TI0>(ref ComPtr<TI0> ppError) where TI0 : unmanaged, IComVtbl<IMFMediaError>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateError((IMFMediaError**) ppError.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
