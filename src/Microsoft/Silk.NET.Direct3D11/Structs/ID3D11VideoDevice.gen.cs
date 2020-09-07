// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "ID3D11VideoDevice")]
    public unsafe partial struct ID3D11VideoDevice
    {
        public ID3D11VideoDevice
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoder);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoderPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pVideoDesc, ref VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoder);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pVideoDesc, ref VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                {
                    fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoderPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pVideoDesc, VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoder);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pVideoDesc, VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoderPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pVideoDesc, ref VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoder);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pVideoDesc, ref VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                    {
                        fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoderPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessor);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessorPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessor);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateAuthenticatedChannel(AuthenticatedChannelType ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannel);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateAuthenticatedChannel(AuthenticatedChannelType ChannelType, ref ID3D11AuthenticatedChannel* ppAuthenticatedChannel)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11AuthenticatedChannel** ppAuthenticatedChannelPtr = &ppAuthenticatedChannel)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannelPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                        {
                            fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResource, pDesc, ppVDOVView);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResource, pDesc, ppVDOVViewPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, ref VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, ref VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, ref VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, ref VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIView);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIViewPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIView);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                        {
                            fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIViewPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOView);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOViewPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOView);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                        {
                            fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOViewPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorEnumerator(VideoProcessorContentDesc* pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)LpVtbl[10])(@this, pDesc, ppEnum);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorEnumerator(VideoProcessorContentDesc* pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)LpVtbl[10])(@this, pDesc, ppEnumPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorEnumerator(ref VideoProcessorContentDesc pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)LpVtbl[10])(@this, pDescPtr, ppEnum);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorEnumerator(ref VideoProcessorContentDesc pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)LpVtbl[10])(@this, pDescPtr, ppEnumPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetVideoDecoderProfileCount()
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, uint>)LpVtbl[11])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderProfile(uint Index, Guid* pDecoderProfile)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, uint, Guid*, int>)LpVtbl[12])(@this, Index, pDecoderProfile);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetVideoDecoderProfile(uint Index, ref Guid pDecoderProfile)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, uint, Guid*, int>)LpVtbl[12])(@this, Index, pDecoderProfilePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderFormat(Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Silk.NET.DXGI.Format, int*, int>)LpVtbl[13])(@this, pDecoderProfile, Format, pSupported);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderFormat(Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Silk.NET.DXGI.Format, int*, int>)LpVtbl[13])(@this, pDecoderProfile, Format, pSupportedPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderFormat(ref Guid pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Silk.NET.DXGI.Format, int*, int>)LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupported);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckVideoDecoderFormat(ref Guid pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Silk.NET.DXGI.Format, int*, int>)LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupportedPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderConfigCount(VideoDecoderDesc* pDesc, uint* pCount)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, uint*, int>)LpVtbl[14])(@this, pDesc, pCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderConfigCount(VideoDecoderDesc* pDesc, ref uint pCount)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, uint*, int>)LpVtbl[14])(@this, pDesc, pCountPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderConfigCount(ref VideoDecoderDesc pDesc, uint* pCount)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, uint*, int>)LpVtbl[14])(@this, pDescPtr, pCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetVideoDecoderConfigCount(ref VideoDecoderDesc pDesc, ref uint pCount)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (uint* pCountPtr = &pCount)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, uint*, int>)LpVtbl[14])(@this, pDescPtr, pCountPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderConfig(VideoDecoderDesc* pDesc, uint Index, VideoDecoderConfig* pConfig)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)LpVtbl[15])(@this, pDesc, Index, pConfig);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderConfig(VideoDecoderDesc* pDesc, uint Index, ref VideoDecoderConfig pConfig)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)LpVtbl[15])(@this, pDesc, Index, pConfigPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderConfig(ref VideoDecoderDesc pDesc, uint Index, VideoDecoderConfig* pConfig)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)LpVtbl[15])(@this, pDescPtr, Index, pConfig);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetVideoDecoderConfig(ref VideoDecoderDesc pDesc, uint Index, ref VideoDecoderConfig pConfig)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)LpVtbl[15])(@this, pDescPtr, Index, pConfigPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(Guid* pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCaps);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(Guid* pCryptoType, Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCapsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(Guid* pCryptoType, ref Guid pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCaps);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(Guid* pCryptoType, ref Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCapsPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(ref Guid pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCaps);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(ref Guid pCryptoType, Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCapsPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(ref Guid pCryptoType, ref Guid pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCaps);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetContentProtectionCaps(ref Guid pCryptoType, ref Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCapsPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(Guid* pCryptoType, Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(Guid* pCryptoType, Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeTypePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(Guid* pCryptoType, ref Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeType);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(Guid* pCryptoType, ref Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(ref Guid pCryptoType, Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeType);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(ref Guid pCryptoType, Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeTypePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(ref Guid pCryptoType, ref Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeType);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckCryptoKeyExchange(ref Guid pCryptoType, ref Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, uint, void*, int>)LpVtbl[18])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, uint, T0*, int>)LpVtbl[18])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, uint, void*, int>)LpVtbl[18])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, uint, T0*, int>)LpVtbl[18])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[19])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[19])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[19])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D11VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[19])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

    }
}
