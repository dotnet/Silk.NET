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
    [Guid("feaa2a8d-b3f3-43e4-b25c-d1de990a1ae1")]
    [NativeName("Name", "IWICMetadataBlockReader")]
    public unsafe partial struct IWICMetadataBlockReader : IComVtbl<IWICMetadataBlockReader>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("feaa2a8d-b3f3-43e4-b25c-d1de990a1ae1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICMetadataBlockReader val)
            => Unsafe.As<IWICMetadataBlockReader, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICMetadataBlockReader
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
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainerFormat(Guid* pguidContainerFormat)
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, Guid*, int>)@this->LpVtbl[3])(@this, pguidContainerFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContainerFormat(ref Guid pguidContainerFormat)
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidContainerFormatPtr = &pguidContainerFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, Guid*, int>)@this->LpVtbl[3])(@this, pguidContainerFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCount(uint* pcCount)
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, uint*, int>)@this->LpVtbl[4])(@this, pcCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCount(ref uint pcCount)
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcCountPtr = &pcCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, uint*, int>)@this->LpVtbl[4])(@this, pcCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetReaderByIndex(uint nIndex, IWICMetadataReader** ppIMetadataReader)
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, uint, IWICMetadataReader**, int>)@this->LpVtbl[5])(@this, nIndex, ppIMetadataReader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetReaderByIndex(uint nIndex, ref IWICMetadataReader* ppIMetadataReader)
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataReader** ppIMetadataReaderPtr = &ppIMetadataReader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, uint, IWICMetadataReader**, int>)@this->LpVtbl[5])(@this, nIndex, ppIMetadataReaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEnumerator(Silk.NET.Core.Win32Extras.IEnumUnknown** ppIEnumMetadata)
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, Silk.NET.Core.Win32Extras.IEnumUnknown**, int>)@this->LpVtbl[6])(@this, ppIEnumMetadata);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEnumerator(ref Silk.NET.Core.Win32Extras.IEnumUnknown* ppIEnumMetadata)
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IEnumUnknown** ppIEnumMetadataPtr = &ppIEnumMetadata)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataBlockReader*, Silk.NET.Core.Win32Extras.IEnumUnknown**, int>)@this->LpVtbl[6])(@this, ppIEnumMetadataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetReaderByIndex<TI0>(uint nIndex, ref ComPtr<TI0> ppIMetadataReader) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetReaderByIndex(nIndex, (IWICMetadataReader**) ppIMetadataReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICMetadataBlockReader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
