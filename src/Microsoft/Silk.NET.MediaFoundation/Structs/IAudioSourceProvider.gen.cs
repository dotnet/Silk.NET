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
    [Guid("ebbaf249-afc2-4582-91c6-b60df2e84954")]
    [NativeName("Name", "IAudioSourceProvider")]
    public unsafe partial struct IAudioSourceProvider : IComVtbl<IAudioSourceProvider>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("ebbaf249-afc2-4582-91c6-b60df2e84954");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IAudioSourceProvider val)
            => Unsafe.As<IAudioSourceProvider, Silk.NET.Core.Native.IUnknown>(ref val);

        public IAudioSourceProvider
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
            var @this = (IAudioSourceProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IAudioSourceProvider*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IAudioSourceProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IAudioSourceProvider*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IAudioSourceProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IAudioSourceProvider*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IAudioSourceProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IAudioSourceProvider*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IAudioSourceProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IAudioSourceProvider*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IAudioSourceProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IAudioSourceProvider*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ProvideInput(uint dwSampleCount, uint* pdwChannelCount, float* pInterleavedAudioData)
        {
            var @this = (IAudioSourceProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IAudioSourceProvider*, uint, uint*, float*, int>)@this->LpVtbl[3])(@this, dwSampleCount, pdwChannelCount, pInterleavedAudioData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ProvideInput(uint dwSampleCount, uint* pdwChannelCount, ref float pInterleavedAudioData)
        {
            var @this = (IAudioSourceProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pInterleavedAudioDataPtr = &pInterleavedAudioData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IAudioSourceProvider*, uint, uint*, float*, int>)@this->LpVtbl[3])(@this, dwSampleCount, pdwChannelCount, pInterleavedAudioDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ProvideInput(uint dwSampleCount, ref uint pdwChannelCount, float* pInterleavedAudioData)
        {
            var @this = (IAudioSourceProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwChannelCountPtr = &pdwChannelCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IAudioSourceProvider*, uint, uint*, float*, int>)@this->LpVtbl[3])(@this, dwSampleCount, pdwChannelCountPtr, pInterleavedAudioData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ProvideInput(uint dwSampleCount, ref uint pdwChannelCount, ref float pInterleavedAudioData)
        {
            var @this = (IAudioSourceProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwChannelCountPtr = &pdwChannelCount)
            {
                fixed (float* pInterleavedAudioDataPtr = &pInterleavedAudioData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IAudioSourceProvider*, uint, uint*, float*, int>)@this->LpVtbl[3])(@this, dwSampleCount, pdwChannelCountPtr, pInterleavedAudioDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAudioSourceProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAudioSourceProvider*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
