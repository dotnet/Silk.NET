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
    [Guid("a724b056-1b2e-4642-a6f3-db9420c52908")]
    [NativeName("Name", "IMFMediaEngineSupportsSourceTransfer")]
    public unsafe partial struct IMFMediaEngineSupportsSourceTransfer : IComVtbl<IMFMediaEngineSupportsSourceTransfer>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a724b056-1b2e-4642-a6f3-db9420c52908");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaEngineSupportsSourceTransfer val)
            => Unsafe.As<IMFMediaEngineSupportsSourceTransfer, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaEngineSupportsSourceTransfer
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
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ShouldTransferSource(int* pfShouldTransfer)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, int*, int>)@this->LpVtbl[3])(@this, pfShouldTransfer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ShouldTransferSource(ref int pfShouldTransfer)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfShouldTransferPtr = &pfShouldTransfer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, int*, int>)@this->LpVtbl[3])(@this, pfShouldTransferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetachMediaSource(IMFByteStream** ppByteStream, IMFMediaSource** ppMediaSource, IMFMediaSourceExtension** ppMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStream, ppMediaSource, ppMSE);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetachMediaSource(IMFByteStream** ppByteStream, IMFMediaSource** ppMediaSource, ref IMFMediaSourceExtension* ppMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaSourceExtension** ppMSEPtr = &ppMSE)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStream, ppMediaSource, ppMSEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetachMediaSource(IMFByteStream** ppByteStream, ref IMFMediaSource* ppMediaSource, IMFMediaSourceExtension** ppMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaSource** ppMediaSourcePtr = &ppMediaSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStream, ppMediaSourcePtr, ppMSE);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetachMediaSource(IMFByteStream** ppByteStream, ref IMFMediaSource* ppMediaSource, ref IMFMediaSourceExtension* ppMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaSource** ppMediaSourcePtr = &ppMediaSource)
            {
                fixed (IMFMediaSourceExtension** ppMSEPtr = &ppMSE)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStream, ppMediaSourcePtr, ppMSEPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetachMediaSource(ref IMFByteStream* ppByteStream, IMFMediaSource** ppMediaSource, IMFMediaSourceExtension** ppMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream** ppByteStreamPtr = &ppByteStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStreamPtr, ppMediaSource, ppMSE);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetachMediaSource(ref IMFByteStream* ppByteStream, IMFMediaSource** ppMediaSource, ref IMFMediaSourceExtension* ppMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream** ppByteStreamPtr = &ppByteStream)
            {
                fixed (IMFMediaSourceExtension** ppMSEPtr = &ppMSE)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStreamPtr, ppMediaSource, ppMSEPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetachMediaSource(ref IMFByteStream* ppByteStream, ref IMFMediaSource* ppMediaSource, IMFMediaSourceExtension** ppMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream** ppByteStreamPtr = &ppByteStream)
            {
                fixed (IMFMediaSource** ppMediaSourcePtr = &ppMediaSource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStreamPtr, ppMediaSourcePtr, ppMSE);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetachMediaSource(ref IMFByteStream* ppByteStream, ref IMFMediaSource* ppMediaSource, ref IMFMediaSourceExtension* ppMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream** ppByteStreamPtr = &ppByteStream)
            {
                fixed (IMFMediaSource** ppMediaSourcePtr = &ppMediaSource)
                {
                    fixed (IMFMediaSourceExtension** ppMSEPtr = &ppMSE)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)@this->LpVtbl[4])(@this, ppByteStreamPtr, ppMediaSourcePtr, ppMSEPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AttachMediaSource(IMFByteStream* pByteStream, IMFMediaSource* pMediaSource, IMFMediaSourceExtension* pMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStream, pMediaSource, pMSE);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AttachMediaSource(IMFByteStream* pByteStream, IMFMediaSource* pMediaSource, ref IMFMediaSourceExtension pMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaSourceExtension* pMSEPtr = &pMSE)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStream, pMediaSource, pMSEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AttachMediaSource(IMFByteStream* pByteStream, ref IMFMediaSource pMediaSource, IMFMediaSourceExtension* pMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaSource* pMediaSourcePtr = &pMediaSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStream, pMediaSourcePtr, pMSE);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AttachMediaSource(IMFByteStream* pByteStream, ref IMFMediaSource pMediaSource, ref IMFMediaSourceExtension pMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaSource* pMediaSourcePtr = &pMediaSource)
            {
                fixed (IMFMediaSourceExtension* pMSEPtr = &pMSE)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStream, pMediaSourcePtr, pMSEPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AttachMediaSource(ref IMFByteStream pByteStream, IMFMediaSource* pMediaSource, IMFMediaSourceExtension* pMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStreamPtr, pMediaSource, pMSE);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AttachMediaSource(ref IMFByteStream pByteStream, IMFMediaSource* pMediaSource, ref IMFMediaSourceExtension pMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (IMFMediaSourceExtension* pMSEPtr = &pMSE)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStreamPtr, pMediaSource, pMSEPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AttachMediaSource(ref IMFByteStream pByteStream, ref IMFMediaSource pMediaSource, IMFMediaSourceExtension* pMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (IMFMediaSource* pMediaSourcePtr = &pMediaSource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStreamPtr, pMediaSourcePtr, pMSE);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AttachMediaSource(ref IMFByteStream pByteStream, ref IMFMediaSource pMediaSource, ref IMFMediaSourceExtension pMSE)
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (IMFMediaSource* pMediaSourcePtr = &pMediaSource)
                {
                    fixed (IMFMediaSourceExtension* pMSEPtr = &pMSE)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)@this->LpVtbl[5])(@this, pByteStreamPtr, pMediaSourcePtr, pMSEPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetachMediaSource<TI0>(IMFByteStream** ppByteStream, IMFMediaSource** ppMediaSource, ref ComPtr<TI0> ppMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DetachMediaSource(ppByteStream, ppMediaSource, (IMFMediaSourceExtension**) ppMSE.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetachMediaSource<TI0>(IMFByteStream** ppByteStream, ref IMFMediaSource* ppMediaSource, ref ComPtr<TI0> ppMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DetachMediaSource(ppByteStream, ref ppMediaSource, (IMFMediaSourceExtension**) ppMSE.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetachMediaSource<TI0>(ref IMFByteStream* ppByteStream, IMFMediaSource** ppMediaSource, ref ComPtr<TI0> ppMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DetachMediaSource(ref ppByteStream, ppMediaSource, (IMFMediaSourceExtension**) ppMSE.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetachMediaSource<TI0>(ref IMFByteStream* ppByteStream, ref IMFMediaSource* ppMediaSource, ref ComPtr<TI0> ppMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DetachMediaSource(ref ppByteStream, ref ppMediaSource, (IMFMediaSourceExtension**) ppMSE.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AttachMediaSource<TI0>(IMFByteStream* pByteStream, IMFMediaSource* pMediaSource, ComPtr<TI0> pMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AttachMediaSource(pByteStream, pMediaSource, (IMFMediaSourceExtension*) pMSE.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AttachMediaSource<TI0>(IMFByteStream* pByteStream, ref IMFMediaSource pMediaSource, ComPtr<TI0> pMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AttachMediaSource(pByteStream, ref pMediaSource, (IMFMediaSourceExtension*) pMSE.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AttachMediaSource<TI0>(ref IMFByteStream pByteStream, IMFMediaSource* pMediaSource, ComPtr<TI0> pMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AttachMediaSource(ref pByteStream, pMediaSource, (IMFMediaSourceExtension*) pMSE.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AttachMediaSource<TI0>(ref IMFByteStream pByteStream, ref IMFMediaSource pMediaSource, ComPtr<TI0> pMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AttachMediaSource(ref pByteStream, ref pMediaSource, (IMFMediaSourceExtension*) pMSE.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineSupportsSourceTransfer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
