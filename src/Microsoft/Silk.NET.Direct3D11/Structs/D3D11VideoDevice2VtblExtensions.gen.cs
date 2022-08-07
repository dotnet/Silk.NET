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

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11VideoDevice2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, VideoDecoderDesc* pVideoDesc, ref VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, VideoDecoderDesc* pVideoDesc, ref VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
        {
            fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pVideoDesc, VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pVideoDesc, VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pVideoDesc, ref VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pVideoDesc, ref VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel<TThis>(this TThis thisVtbl, AuthenticatedChannelType ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)@this->LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel<TThis>(this TThis thisVtbl, AuthenticatedChannelType ChannelType, ref ID3D11AuthenticatedChannel* ppAuthenticatedChannel) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11AuthenticatedChannel** ppAuthenticatedChannelPtr = &ppAuthenticatedChannel)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)@this->LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDesc, ppVDOVView);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDesc, ppVDOVViewPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ref VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ref VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ref VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ref VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIView);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIViewPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIView);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIViewPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOView);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOViewPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOView);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOViewPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator<TThis>(this TThis thisVtbl, VideoProcessorContentDesc* pDesc, ID3D11VideoProcessorEnumerator** ppEnum) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDesc, ppEnum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator<TThis>(this TThis thisVtbl, VideoProcessorContentDesc* pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDesc, ppEnumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator<TThis>(this TThis thisVtbl, ref VideoProcessorContentDesc pDesc, ID3D11VideoProcessorEnumerator** ppEnum) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDescPtr, ppEnum);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator<TThis>(this TThis thisVtbl, ref VideoProcessorContentDesc pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDescPtr, ppEnumPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetVideoDecoderProfileCount<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, uint>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderProfile<TThis>(this TThis thisVtbl, uint Index, Guid* pDecoderProfile) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, uint, Guid*, int>)@this->LpVtbl[12])(@this, Index, pDecoderProfile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderProfile<TThis>(this TThis thisVtbl, uint Index, ref Guid pDecoderProfile) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, uint, Guid*, int>)@this->LpVtbl[12])(@this, Index, pDecoderProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderFormat<TThis>(this TThis thisVtbl, Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfile, Format, pSupported);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderFormat<TThis>(this TThis thisVtbl, Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pSupportedPtr = &pSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfile, Format, pSupportedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderFormat<TThis>(this TThis thisVtbl, ref Guid pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupported);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckVideoDecoderFormat<TThis>(this TThis thisVtbl, ref Guid pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupportedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfigCount<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, uint* pCount) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDesc, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfigCount<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ref uint pCount) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDesc, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfigCount<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, uint* pCount) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDescPtr, pCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderConfigCount<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ref uint pCount) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDescPtr, pCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfig<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, uint Index, VideoDecoderConfig* pConfig) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDesc, Index, pConfig);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfig<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, uint Index, ref VideoDecoderConfig pConfig) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDesc, Index, pConfigPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfig<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, uint Index, VideoDecoderConfig* pConfig) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDescPtr, Index, pConfig);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderConfig<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, uint Index, ref VideoDecoderConfig pConfig) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDescPtr, Index, pConfigPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, VideoContentProtectionCaps* pCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, VideoContentProtectionCaps* pCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCaps);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetContentProtectionCaps<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCapsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckCryptoKeyExchange<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
        {
            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCryptoSessionPrivateDataSize<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, Guid* pCryptoType, uint* pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, Guid* pCryptoType, ref uint pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, ref Guid pCryptoType, uint* pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, ref Guid pCryptoType, ref uint pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, Guid* pCryptoType, uint* pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, Guid* pCryptoType, ref uint pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, ref Guid pCryptoType, uint* pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCaps);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, ref Guid pCryptoType, ref uint pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, Guid* pCryptoType, uint* pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, Guid* pCryptoType, ref uint pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, ref Guid pCryptoType, uint* pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCaps);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, ref Guid pCryptoType, ref uint pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, Guid* pCryptoType, uint* pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCaps);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, Guid* pCryptoType, ref uint pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCapsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, ref Guid pCryptoType, uint* pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCaps);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderCaps<TThis>(this TThis thisVtbl, ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, ref Guid pCryptoType, ref uint pDecoderCaps) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pSupportedPtr = &pSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pSupportedPtr = &pSupported)
        {
            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
        {
            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckVideoDecoderDownsampling<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDesc);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDescPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDesc);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDescPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDesc);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDescPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDesc);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RecommendVideoDecoderDownsampleParameters<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDescPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckFeatureSupport<TThis>(this TThis thisVtbl, FeatureVideo Feature, void* pFeatureSupportData, uint FeatureSupportDataSize) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, FeatureVideo, void*, uint, int>)@this->LpVtbl[24])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0, TThis>(this TThis thisVtbl, FeatureVideo Feature, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, FeatureVideo, void*, uint, int>)@this->LpVtbl[24])(@this, Feature, pFeatureSupportDataPtr, FeatureSupportDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateCryptoSessionKeyExchangeMT<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11CryptoSession*, CryptoSessionKeyExchangeFlags, uint, void*, int>)@this->LpVtbl[25])(@this, pCryptoSession, flags, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateCryptoSessionKeyExchangeMT<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11CryptoSession*, CryptoSessionKeyExchangeFlags, uint, void*, int>)@this->LpVtbl[25])(@this, pCryptoSession, flags, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateCryptoSessionKeyExchangeMT<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11CryptoSession*, CryptoSessionKeyExchangeFlags, uint, void*, int>)@this->LpVtbl[25])(@this, pCryptoSessionPtr, flags, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateCryptoSessionKeyExchangeMT<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoDevice2>
    {
        var @this = (ID3D11VideoDevice2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice2*, ID3D11CryptoSession*, CryptoSessionKeyExchangeFlags, uint, void*, int>)@this->LpVtbl[25])(@this, pCryptoSessionPtr, flags, DataSize, pDataPtr);
            }
        }
        return ret;
    }

}
