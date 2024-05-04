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
    [Guid("00675040-6908-45f8-86a3-49c7dfd6d9ad")]
    [NativeName("Name", "IWICPersistStream")]
    public unsafe partial struct IWICPersistStream : IComVtbl<IWICPersistStream>, IComVtbl<Silk.NET.Core.Win32Extras.IPersistStream>, IComVtbl<Silk.NET.Core.Win32Extras.IPersist>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00675040-6908-45f8-86a3-49c7dfd6d9ad");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Win32Extras.IPersistStream(IWICPersistStream val)
            => Unsafe.As<IWICPersistStream, Silk.NET.Core.Win32Extras.IPersistStream>(ref val);

        public static implicit operator Silk.NET.Core.Win32Extras.IPersist(IWICPersistStream val)
            => Unsafe.As<IWICPersistStream, Silk.NET.Core.Win32Extras.IPersist>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICPersistStream val)
            => Unsafe.As<IWICPersistStream, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICPersistStream
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
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassID(Guid* pClassID)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Guid*, int>)@this->LpVtbl[3])(@this, pClassID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClassID(ref Guid pClassID)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pClassIDPtr = &pClassID)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Guid*, int>)@this->LpVtbl[3])(@this, pClassIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsDirty()
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(Silk.NET.Core.Win32Extras.IStream* pStm)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[5])(@this, pStm);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load(ref Silk.NET.Core.Win32Extras.IStream pStm)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[5])(@this, pStmPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Save(Silk.NET.Core.Win32Extras.IStream* pStm, Silk.NET.Core.Bool32 fClearDirty)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pStm, fClearDirty);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Save(ref Silk.NET.Core.Win32Extras.IStream pStm, Silk.NET.Core.Bool32 fClearDirty)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pStmPtr, fClearDirty);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSizeMax(ulong* pcbSize)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, ulong*, int>)@this->LpVtbl[7])(@this, pcbSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSizeMax(ref ulong pcbSize)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pcbSizePtr = &pcbSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, ulong*, int>)@this->LpVtbl[7])(@this, pcbSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadEx(Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidPreferredVendor, uint dwPersistOptions)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Silk.NET.Core.Win32Extras.IStream*, Guid*, uint, int>)@this->LpVtbl[8])(@this, pIStream, pguidPreferredVendor, dwPersistOptions);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadEx(Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidPreferredVendor, uint dwPersistOptions)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidPreferredVendorPtr = &pguidPreferredVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Silk.NET.Core.Win32Extras.IStream*, Guid*, uint, int>)@this->LpVtbl[8])(@this, pIStream, pguidPreferredVendorPtr, dwPersistOptions);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadEx(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidPreferredVendor, uint dwPersistOptions)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Silk.NET.Core.Win32Extras.IStream*, Guid*, uint, int>)@this->LpVtbl[8])(@this, pIStreamPtr, pguidPreferredVendor, dwPersistOptions);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadEx(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidPreferredVendor, uint dwPersistOptions)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                fixed (Guid* pguidPreferredVendorPtr = &pguidPreferredVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Silk.NET.Core.Win32Extras.IStream*, Guid*, uint, int>)@this->LpVtbl[8])(@this, pIStreamPtr, pguidPreferredVendorPtr, dwPersistOptions);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveEx(Silk.NET.Core.Win32Extras.IStream* pIStream, uint dwPersistOptions, Silk.NET.Core.Bool32 fClearDirty)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Silk.NET.Core.Win32Extras.IStream*, uint, Silk.NET.Core.Bool32, int>)@this->LpVtbl[9])(@this, pIStream, dwPersistOptions, fClearDirty);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SaveEx(ref Silk.NET.Core.Win32Extras.IStream pIStream, uint dwPersistOptions, Silk.NET.Core.Bool32 fClearDirty)
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Silk.NET.Core.Win32Extras.IStream*, uint, Silk.NET.Core.Bool32, int>)@this->LpVtbl[9])(@this, pIStreamPtr, dwPersistOptions, fClearDirty);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Load<TI0>(ComPtr<TI0> pStm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Load((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Save<TI0>(ComPtr<TI0> pStm, Silk.NET.Core.Bool32 fClearDirty) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Save((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, fClearDirty);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadEx<TI0>(ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidPreferredVendor, uint dwPersistOptions) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadEx((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pguidPreferredVendor, dwPersistOptions);
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadEx<TI0>(ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidPreferredVendor, uint dwPersistOptions) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadEx((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, in pguidPreferredVendor, dwPersistOptions);
        }

        /// <summary>To be documented.</summary>
        public readonly int SaveEx<TI0>(ComPtr<TI0> pIStream, uint dwPersistOptions, Silk.NET.Core.Bool32 fClearDirty) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SaveEx((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, dwPersistOptions, fClearDirty);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICPersistStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
