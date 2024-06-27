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

namespace Silk.NET.Direct3D11
{
    [Guid("10ec4d5b-975a-4689-b9e4-d0aac30fe333")]
    [NativeName("Name", "ID3D11VideoDevice")]
    public unsafe partial struct ID3D11VideoDevice : IComVtbl<ID3D11VideoDevice>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("10ec4d5b-975a-4689-b9e4-d0aac30fe333");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11VideoDevice val)
            => Unsafe.As<ID3D11VideoDevice, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11VideoDevice
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
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoder);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                {
                    fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAuthenticatedChannel(AuthenticatedChannelType ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)@this->LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAuthenticatedChannel(AuthenticatedChannelType ChannelType, ref ID3D11AuthenticatedChannel* ppAuthenticatedChannel)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel** ppAuthenticatedChannelPtr = &ppAuthenticatedChannel)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)@this->LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDesc, ppVDOVView);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDesc, ppVDOVViewPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIView);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIViewPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIView);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIViewPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOView);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOViewPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOView);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOViewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOView);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOViewPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOView);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOViewPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorEnumerator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorContentDesc* pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDesc, ppEnum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorEnumerator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorContentDesc* pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDesc, ppEnumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorEnumerator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorContentDesc pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDescPtr, ppEnum);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorEnumerator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorContentDesc pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDescPtr, ppEnumPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetVideoDecoderProfileCount()
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, uint>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderProfile(uint Index, Guid* pDecoderProfile)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, uint, Guid*, int>)@this->LpVtbl[12])(@this, Index, pDecoderProfile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoDecoderProfile(uint Index, ref Guid pDecoderProfile)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, uint, Guid*, int>)@this->LpVtbl[12])(@this, Index, pDecoderProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfile, Format, pSupported);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfile, Format, pSupportedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoDecoderFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupported);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckVideoDecoderFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupportedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderConfigCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, uint* pCount)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDesc, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderConfigCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref uint pCount)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDesc, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderConfigCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, uint* pCount)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDescPtr, pCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoDecoderConfigCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref uint pCount)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDescPtr, pCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, uint Index, VideoDecoderConfig* pConfig)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDesc, Index, pConfig);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, uint Index, ref VideoDecoderConfig pConfig)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDesc, Index, pConfigPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, uint Index, VideoDecoderConfig* pConfig)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDescPtr, Index, pConfig);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoDecoderConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, uint Index, ref VideoDecoderConfig pConfig)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDescPtr, Index, pConfigPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCaps);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCapsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCaps);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCapsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCaps);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContentProtectionCaps([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCapsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeTypePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoKeyExchange([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeType);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckCryptoKeyExchange([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder(pVideoDesc, pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder(pVideoDesc, in pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder(in pVideoDesc, pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoDecoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder(in pVideoDesc, in pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessor<TI0, TI1>(ComPtr<TI0> pEnum, uint RateConversionIndex, ref ComPtr<TI1> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor((ID3D11VideoProcessorEnumerator*) pEnum.Handle, RateConversionIndex, (ID3D11VideoProcessor**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor<TI0>(ComPtr<TI0> pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor((ID3D11VideoProcessorEnumerator*) pEnum.Handle, RateConversionIndex, ref ppVideoProcessor);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessor<TI0>(ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ref ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor(ref pEnum, RateConversionIndex, (ID3D11VideoProcessor**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateAuthenticatedChannel<TI0>(AuthenticatedChannelType ChannelType, ref ComPtr<TI0> ppAuthenticatedChannel) where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateAuthenticatedChannel(ChannelType, (ID3D11AuthenticatedChannel**) ppAuthenticatedChannel.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCryptoSession = default;
            return @this->CreateCryptoSession(pCryptoType, pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCryptoSession(pCryptoType, pDecoderProfile, in pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCryptoSession = default;
            return @this->CreateCryptoSession(pCryptoType, in pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCryptoSession(pCryptoType, in pDecoderProfile, in pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCryptoSession = default;
            return @this->CreateCryptoSession(in pCryptoType, pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCryptoSession(in pCryptoType, pDecoderProfile, in pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCryptoSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCryptoSession = default;
            return @this->CreateCryptoSession(in pCryptoType, in pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCryptoSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCryptoSession(in pCryptoType, in pDecoderProfile, in pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView<TI0, TI1>(ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ref ComPtr<TI1> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderOutputView((ID3D11Resource*) pResource.Handle, pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView<TI0>(ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderOutputView((ID3D11Resource*) pResource.Handle, pDesc, ref ppVDOVView);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoDecoderOutputView<TI0, TI1>(ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ref ComPtr<TI1> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderOutputView((ID3D11Resource*) pResource.Handle, in pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView<TI0>(ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderOutputView((ID3D11Resource*) pResource.Handle, in pDesc, ref ppVDOVView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderOutputView<TI0>(ref ID3D11Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ref ComPtr<TI0> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderOutputView(ref pResource, pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoDecoderOutputView<TI0>(ref ID3D11Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ref ComPtr<TI0> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderOutputView(ref pResource, in pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0, TI1, TI2>(ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI2> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0, TI1>(ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, ref ppVPIView);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessorInputView<TI0, TI1, TI2>(ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ComPtr<TI2> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0, TI1>(ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, ref ppVPIView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0, TI1>(ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI1> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, ref pEnum, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0>(ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, ref pEnum, pDesc, ref ppVPIView);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessorInputView<TI0, TI1>(ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ComPtr<TI1> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, ref pEnum, in pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0>(ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, ref pEnum, in pDesc, ref ppVPIView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0, TI1>(ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI1> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0>(ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, ref ppVPIView);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessorInputView<TI0, TI1>(ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ComPtr<TI1> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0>(ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, ref ppVPIView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorInputView<TI0>(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(ref pResource, ref pEnum, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessorInputView<TI0>(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorInputView(ref pResource, ref pEnum, in pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0, TI1, TI2>(ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI2> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0, TI1>(ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, ref ppVPOView);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessorOutputView<TI0, TI1, TI2>(ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI2> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0, TI1>(ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, ref ppVPOView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0, TI1>(ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI1> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, ref pEnum, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0>(ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, ref pEnum, pDesc, ref ppVPOView);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessorOutputView<TI0, TI1>(ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI1> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, ref pEnum, in pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0>(ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, ref pEnum, in pDesc, ref ppVPOView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0, TI1>(ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI1> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0>(ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, ref ppVPOView);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessorOutputView<TI0, TI1>(ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI1> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0>(ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, ref ppVPOView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorOutputView<TI0>(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(ref pResource, ref pEnum, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessorOutputView<TI0>(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorOutputView(ref pResource, ref pEnum, in pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessorEnumerator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorContentDesc* pDesc, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorEnumerator(pDesc, (ID3D11VideoProcessorEnumerator**) ppEnum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessorEnumerator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorContentDesc pDesc, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessorEnumerator(in pDesc, (ID3D11VideoProcessorEnumerator**) ppEnum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCryptoSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCryptoSession(pCryptoType, pDecoderProfile, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCryptoSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCryptoSession(pCryptoType, in pDecoderProfile, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCryptoSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCryptoSession(in pCryptoType, pDecoderProfile, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateCryptoSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCryptoSession(in pCryptoType, in pDecoderProfile, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
