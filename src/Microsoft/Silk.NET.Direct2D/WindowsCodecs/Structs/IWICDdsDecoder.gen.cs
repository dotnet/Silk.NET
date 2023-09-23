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
    [Guid("409cd537-8532-40cb-9774-e2feb2df4e9c")]
    [NativeName("Name", "IWICDdsDecoder")]
    public unsafe partial struct IWICDdsDecoder : IComVtbl<IWICDdsDecoder>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("409cd537-8532-40cb-9774-e2feb2df4e9c");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICDdsDecoder val)
            => Unsafe.As<IWICDdsDecoder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICDdsDecoder
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
            var @this = (IWICDdsDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICDdsDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICDdsDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICDdsDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICDdsDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICDdsDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParameters(DdsParameters* pParameters)
        {
            var @this = (IWICDdsDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, DdsParameters*, int>)@this->LpVtbl[3])(@this, pParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetParameters(ref DdsParameters pParameters)
        {
            var @this = (IWICDdsDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DdsParameters* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, DdsParameters*, int>)@this->LpVtbl[3])(@this, pParametersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrame(uint arrayIndex, uint mipLevel, uint sliceIndex, IWICBitmapFrameDecode** ppIBitmapFrame)
        {
            var @this = (IWICDdsDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, uint, uint, uint, IWICBitmapFrameDecode**, int>)@this->LpVtbl[4])(@this, arrayIndex, mipLevel, sliceIndex, ppIBitmapFrame);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrame(uint arrayIndex, uint mipLevel, uint sliceIndex, ref IWICBitmapFrameDecode* ppIBitmapFrame)
        {
            var @this = (IWICDdsDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameDecode** ppIBitmapFramePtr = &ppIBitmapFrame)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsDecoder*, uint, uint, uint, IWICBitmapFrameDecode**, int>)@this->LpVtbl[4])(@this, arrayIndex, mipLevel, sliceIndex, ppIBitmapFramePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICDdsDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrame<TI0>(uint arrayIndex, uint mipLevel, uint sliceIndex, ref ComPtr<TI0> ppIBitmapFrame) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameDecode>, IComVtbl<TI0>
        {
            var @this = (IWICDdsDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFrame(arrayIndex, mipLevel, sliceIndex, (IWICBitmapFrameDecode**) ppIBitmapFrame.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICDdsDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
