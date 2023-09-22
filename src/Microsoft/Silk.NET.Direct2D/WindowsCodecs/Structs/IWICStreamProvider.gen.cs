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

namespace Silk.NET.WindowsCodecs
{
    [Guid("449494bc-b468-4927-96d7-ba90d31ab505")]
    [NativeName("Name", "IWICStreamProvider")]
    public unsafe partial struct IWICStreamProvider : IComVtbl<IWICStreamProvider>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("449494bc-b468-4927-96d7-ba90d31ab505");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICStreamProvider val)
            => Unsafe.As<IWICStreamProvider, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICStreamProvider
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
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStream(Silk.NET.Core.Win32Extras.IStream** ppIStream)
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[3])(@this, ppIStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStream(ref Silk.NET.Core.Win32Extras.IStream* ppIStream)
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream** ppIStreamPtr = &ppIStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[3])(@this, ppIStreamPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPersistOptions(uint* pdwPersistOptions)
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, uint*, int>)@this->LpVtbl[4])(@this, pdwPersistOptions);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPersistOptions(ref uint pdwPersistOptions)
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwPersistOptionsPtr = &pdwPersistOptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, uint*, int>)@this->LpVtbl[4])(@this, pdwPersistOptionsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPreferredVendorGUID(Guid* pguidPreferredVendor)
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, int>)@this->LpVtbl[5])(@this, pguidPreferredVendor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPreferredVendorGUID(ref Guid pguidPreferredVendor)
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidPreferredVendorPtr = &pguidPreferredVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, int>)@this->LpVtbl[5])(@this, pguidPreferredVendorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RefreshStream()
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, int>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStream<TI0>(ref ComPtr<TI0> ppIStream) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetStream((Silk.NET.Core.Win32Extras.IStream**) ppIStream.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICStreamProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
