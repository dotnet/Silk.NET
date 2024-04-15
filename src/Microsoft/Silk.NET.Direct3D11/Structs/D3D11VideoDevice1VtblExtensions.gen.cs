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

public unsafe static class D3D11VideoDevice1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoDevice1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoDevice1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11VideoDevice1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11VideoDevice1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
        {
            fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
        {
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)@this->LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)@this->LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel(this ComPtr<ID3D11VideoDevice1> thisVtbl, AuthenticatedChannelType ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)@this->LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel(this ComPtr<ID3D11VideoDevice1> thisVtbl, AuthenticatedChannelType ChannelType, ref ID3D11AuthenticatedChannel* ppAuthenticatedChannel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11AuthenticatedChannel** ppAuthenticatedChannelPtr = &ppAuthenticatedChannel)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)@this->LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)@this->LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDesc, ppVDOVView);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDesc, ppVDOVViewPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)@this->LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIView);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIViewPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIView);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)@this->LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIViewPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOView);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOViewPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
        {
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOView);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOViewPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOView);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOViewPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOView);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
            {
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)@this->LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOViewPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorContentDesc* pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDesc, ppEnum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorContentDesc* pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDesc, ppEnumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorContentDesc pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDescPtr, ppEnum);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorContentDesc pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)@this->LpVtbl[10])(@this, pDescPtr, ppEnumPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetVideoDecoderProfileCount(this ComPtr<ID3D11VideoDevice1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, uint>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderProfile(this ComPtr<ID3D11VideoDevice1> thisVtbl, uint Index, Guid* pDecoderProfile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, uint, Guid*, int>)@this->LpVtbl[12])(@this, Index, pDecoderProfile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderProfile(this ComPtr<ID3D11VideoDevice1> thisVtbl, uint Index, ref Guid pDecoderProfile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, uint, Guid*, int>)@this->LpVtbl[12])(@this, Index, pDecoderProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfile, Format, pSupported);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pSupportedPtr = &pSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfile, Format, pSupportedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupported);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Silk.NET.DXGI.Format, int*, int>)@this->LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupportedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDesc, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDesc, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDescPtr, pCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, uint*, int>)@this->LpVtbl[14])(@this, pDescPtr, pCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, uint Index, VideoDecoderConfig* pConfig)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDesc, Index, pConfig);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, uint Index, ref VideoDecoderConfig pConfig)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDesc, Index, pConfigPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, uint Index, VideoDecoderConfig* pConfig)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDescPtr, Index, pConfig);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, uint Index, ref VideoDecoderConfig pConfig)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)@this->LpVtbl[15])(@this, pDescPtr, Index, pConfigPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCaps);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, VideoContentProtectionCaps*, int>)@this->LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCapsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, uint, Guid*, int>)@this->LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11VideoDevice1> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, void*, int>)@this->LpVtbl[18])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice1> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice1> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[19])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
        {
            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
        {
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
            {
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)@this->LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, ref uint pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, ref uint pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, ref uint pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCaps);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, ref uint pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, ref uint pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCaps);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, ref uint pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCaps);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, ref uint pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCapsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCaps);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, ref uint pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)@this->LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pSupportedPtr = &pSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pSupportedPtr = &pSupported)
        {
            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
        {
            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (int* pSupportedPtr = &pSupported)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)@this->LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
        {
            fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDesc);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDescPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDesc);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
            {
                fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDescPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDesc);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDescPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDesc);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
        {
            fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
            {
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)@this->LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDescPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(pVideoDesc, pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(pVideoDesc, in pConfig.GetPinnableReference(), ppDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(pVideoDesc, in pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(pVideoDesc, in pConfig.GetPinnableReference(), ref ppDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(in pVideoDesc.GetPinnableReference(), pConfig, ppDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(in pVideoDesc, pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(in pVideoDesc.GetPinnableReference(), pConfig, ref ppDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(in pVideoDesc.GetPinnableReference(), in pConfig.GetPinnableReference(), ppDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoder<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderConfig pConfig, ref ComPtr<TI0> ppDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder(in pVideoDesc, in pConfig, (ID3D11VideoDecoder**) ppDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pVideoDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pConfig, ref ID3D11VideoDecoder* ppDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(in pVideoDesc.GetPinnableReference(), in pConfig.GetPinnableReference(), ref ppDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessor<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pEnum, uint RateConversionIndex, ref ComPtr<TI1> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor((ID3D11VideoProcessorEnumerator*) pEnum.Handle, RateConversionIndex, (ID3D11VideoProcessor**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor((ID3D11VideoProcessorEnumerator*) pEnum.Handle, RateConversionIndex, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11VideoProcessorEnumerator> pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(ref pEnum.GetPinnableReference(), RateConversionIndex, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessor<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ref ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor(ref pEnum, RateConversionIndex, (ID3D11VideoProcessor**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11VideoProcessorEnumerator> pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(ref pEnum.GetPinnableReference(), RateConversionIndex, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static int CreateAuthenticatedChannel<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, AuthenticatedChannelType ChannelType, ref ComPtr<TI0> ppAuthenticatedChannel) where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateAuthenticatedChannel(ChannelType, (ID3D11AuthenticatedChannel**) ppAuthenticatedChannel.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCryptoSession = default;
        return @this->CreateCryptoSession(pCryptoType, pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, pDecoderProfile, in pKeyExchangeType.GetPinnableReference(), ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(pCryptoType, pDecoderProfile, in pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, pDecoderProfile, in pKeyExchangeType.GetPinnableReference(), ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, in pDecoderProfile.GetPinnableReference(), pKeyExchangeType, ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCryptoSession = default;
        return @this->CreateCryptoSession(pCryptoType, in pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, in pDecoderProfile.GetPinnableReference(), pKeyExchangeType, ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, in pDecoderProfile.GetPinnableReference(), in pKeyExchangeType.GetPinnableReference(), ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(pCryptoType, in pDecoderProfile, in pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, in pDecoderProfile.GetPinnableReference(), in pKeyExchangeType.GetPinnableReference(), ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), pDecoderProfile, pKeyExchangeType, ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCryptoSession = default;
        return @this->CreateCryptoSession(in pCryptoType, pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), pDecoderProfile, pKeyExchangeType, ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), pDecoderProfile, in pKeyExchangeType.GetPinnableReference(), ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(in pCryptoType, pDecoderProfile, in pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), pDecoderProfile, in pKeyExchangeType.GetPinnableReference(), ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), pKeyExchangeType, ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, out ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCryptoSession = default;
        return @this->CreateCryptoSession(in pCryptoType, in pDecoderProfile, SilkMarshal.GuidPtrOf<TI0>(), (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), pKeyExchangeType, ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), in pKeyExchangeType.GetPinnableReference(), ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pKeyExchangeType, ref ComPtr<TI0> ppCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(in pCryptoType, in pDecoderProfile, in pKeyExchangeType, (ID3D11CryptoSession**) ppCryptoSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), in pKeyExchangeType.GetPinnableReference(), ref ppCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ref ComPtr<TI1> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderOutputView((ID3D11Resource*) pResource.Handle, pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderOutputView((ID3D11Resource*) pResource.Handle, pDesc, ref ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderOutputViewDesc> pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderOutputView(pResource, in pDesc.GetPinnableReference(), ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoderOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ref ComPtr<TI1> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderOutputView((ID3D11Resource*) pResource.Handle, in pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderOutputViewDesc> pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderOutputView(pResource, in pDesc.GetPinnableReference(), ref ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderOutputView((ID3D11Resource*) pResource.Handle, in pDesc, ref ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderOutputView(ref pResource.GetPinnableReference(), pDesc, ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ref ComPtr<TI0> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderOutputView(ref pResource, pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderOutputView(ref pResource.GetPinnableReference(), pDesc, ref ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderOutputViewDesc> pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderOutputView(ref pResource.GetPinnableReference(), in pDesc.GetPinnableReference(), ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoderOutputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderOutputViewDesc pDesc, ref ComPtr<TI0> ppVDOVView) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderOutputView(ref pResource, in pDesc, (ID3D11VideoDecoderOutputView**) ppVDOVView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderOutputViewDesc> pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderOutputView(ref pResource.GetPinnableReference(), in pDesc.GetPinnableReference(), ref ppVDOVView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0, TI1, TI2>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI2> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorInputViewDesc> pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(pResource, pEnum, in pDesc.GetPinnableReference(), ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorInputView<TI0, TI1, TI2>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ComPtr<TI2> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorInputViewDesc> pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(pResource, pEnum, in pDesc.GetPinnableReference(), ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(pResource, ref pEnum.GetPinnableReference(), pDesc, ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI1> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, ref pEnum, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(pResource, ref pEnum.GetPinnableReference(), pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, ref pEnum, pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorInputViewDesc> pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(pResource, ref pEnum.GetPinnableReference(), in pDesc.GetPinnableReference(), ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorInputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ComPtr<TI1> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, ref pEnum, in pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorInputViewDesc> pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(pResource, ref pEnum.GetPinnableReference(), in pDesc.GetPinnableReference(), ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView((ID3D11Resource*) pResource.Handle, ref pEnum, in pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), pEnum, pDesc, ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI1> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), pEnum, pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorInputViewDesc> pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), pEnum, in pDesc.GetPinnableReference(), ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorInputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ComPtr<TI1> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorInputViewDesc> pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), pEnum, in pDesc.GetPinnableReference(), ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), pDesc, ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView(ref pResource, ref pEnum, pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), pDesc, ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorInputViewDesc> pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), in pDesc.GetPinnableReference(), ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorInputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorInputViewDesc pDesc, ref ComPtr<TI0> ppVPIView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorInputView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorInputView(ref pResource, ref pEnum, in pDesc, (ID3D11VideoProcessorInputView**) ppVPIView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorInputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorInputViewDesc> pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorInputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), in pDesc.GetPinnableReference(), ref ppVPIView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0, TI1, TI2>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI2> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorOutputViewDesc> pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(pResource, pEnum, in pDesc.GetPinnableReference(), ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorOutputView<TI0, TI1, TI2>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI2> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorOutputViewDesc> pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(pResource, pEnum, in pDesc.GetPinnableReference(), ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(pResource, ref pEnum.GetPinnableReference(), pDesc, ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI1> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, ref pEnum, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(pResource, ref pEnum.GetPinnableReference(), pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, ref pEnum, pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorOutputViewDesc> pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(pResource, ref pEnum.GetPinnableReference(), in pDesc.GetPinnableReference(), ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI1> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, ref pEnum, in pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, ID3D11Resource* pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorOutputViewDesc> pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(pResource, ref pEnum.GetPinnableReference(), in pDesc.GetPinnableReference(), ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ComPtr<TI0> pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView((ID3D11Resource*) pResource.Handle, ref pEnum, in pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), pEnum, pDesc, ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI1> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), pEnum, pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorOutputViewDesc> pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), pEnum, in pDesc.GetPinnableReference(), ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorOutputView<TI0, TI1>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI1> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, ID3D11VideoProcessorEnumerator* pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorOutputViewDesc> pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), pEnum, in pDesc.GetPinnableReference(), ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ComPtr<TI0> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource, (ID3D11VideoProcessorEnumerator*) pEnum.Handle, in pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), pDesc, ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource, ref pEnum, pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), pDesc, ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorOutputViewDesc> pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), in pDesc.GetPinnableReference(), ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorOutputView<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorOutputViewDesc pDesc, ref ComPtr<TI0> ppVPOView) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource, ref pEnum, in pDesc, (ID3D11VideoProcessorOutputView**) ppVPOView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorOutputView(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<ID3D11Resource> pResource, Span<ID3D11VideoProcessorEnumerator> pEnum, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorOutputViewDesc> pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorOutputView(ref pResource.GetPinnableReference(), ref pEnum.GetPinnableReference(), in pDesc.GetPinnableReference(), ref ppVPOView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorContentDesc* pDesc, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorEnumerator(pDesc, (ID3D11VideoProcessorEnumerator**) ppEnum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorContentDesc> pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorEnumerator(in pDesc.GetPinnableReference(), ppEnum);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessorEnumerator<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorContentDesc pDesc, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessorEnumerator(in pDesc, (ID3D11VideoProcessorEnumerator**) ppEnum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessorEnumerator(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessorContentDesc> pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessorEnumerator(in pDesc.GetPinnableReference(), ref ppEnum);
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderProfile(this ComPtr<ID3D11VideoDevice1> thisVtbl, uint Index, Span<Guid> pDecoderProfile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderProfile(Index, ref pDecoderProfile.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, Span<int> pSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderFormat(pDecoderProfile, Format, ref pSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderFormat(in pDecoderProfile.GetPinnableReference(), Format, pSupported);
    }

    /// <summary>To be documented.</summary>
    public static int CheckVideoDecoderFormat(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, Silk.NET.DXGI.Format Format, Span<int> pSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderFormat(in pDecoderProfile.GetPinnableReference(), Format, ref pSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderConfigCount(pDesc, ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderConfigCount(in pDesc.GetPinnableReference(), pCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderConfigCount(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderConfigCount(in pDesc.GetPinnableReference(), ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, uint Index, Span<VideoDecoderConfig> pConfig)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderConfig(pDesc, Index, ref pConfig.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, uint Index, VideoDecoderConfig* pConfig)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderConfig(in pDesc.GetPinnableReference(), Index, pConfig);
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderConfig(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, uint Index, Span<VideoDecoderConfig> pConfig)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderConfig(in pDesc.GetPinnableReference(), Index, ref pConfig.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, Span<VideoContentProtectionCaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(pCryptoType, pDecoderProfile, ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(pCryptoType, in pDecoderProfile.GetPinnableReference(), pCaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, Span<VideoContentProtectionCaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(pCryptoType, in pDecoderProfile.GetPinnableReference(), ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(in pCryptoType.GetPinnableReference(), pDecoderProfile, pCaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, Span<VideoContentProtectionCaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(in pCryptoType.GetPinnableReference(), pDecoderProfile, ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, VideoContentProtectionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), pCaps);
    }

    /// <summary>To be documented.</summary>
    public static int GetContentProtectionCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, Span<VideoContentProtectionCaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint Index, Span<Guid> pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(pCryptoType, pDecoderProfile, Index, ref pKeyExchangeType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(pCryptoType, in pDecoderProfile.GetPinnableReference(), Index, pKeyExchangeType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, uint Index, Span<Guid> pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(pCryptoType, in pDecoderProfile.GetPinnableReference(), Index, ref pKeyExchangeType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(in pCryptoType.GetPinnableReference(), pDecoderProfile, Index, pKeyExchangeType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint Index, Span<Guid> pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(in pCryptoType.GetPinnableReference(), pDecoderProfile, Index, ref pKeyExchangeType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), Index, pKeyExchangeType);
    }

    /// <summary>To be documented.</summary>
    public static int CheckCryptoKeyExchange(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, uint Index, Span<Guid> pKeyExchangeType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckCryptoKeyExchange(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), Index, ref pKeyExchangeType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice1> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D11VideoDevice1> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, Span<uint> pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, pDecoderProfile, pKeyExchangeType, ref pPrivateInputSize.GetPinnableReference(), pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, Span<uint> pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, pDecoderProfile, pKeyExchangeType, ref pPrivateInputSize.GetPinnableReference(), ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, pDecoderProfile, in pKeyExchangeType.GetPinnableReference(), pPrivateInputSize, pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, uint* pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, pDecoderProfile, in pKeyExchangeType.GetPinnableReference(), pPrivateInputSize, ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, Span<uint> pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, pDecoderProfile, in pKeyExchangeType.GetPinnableReference(), ref pPrivateInputSize.GetPinnableReference(), pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, Span<uint> pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, pDecoderProfile, in pKeyExchangeType.GetPinnableReference(), ref pPrivateInputSize.GetPinnableReference(), ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, in pDecoderProfile.GetPinnableReference(), pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, in pDecoderProfile.GetPinnableReference(), pKeyExchangeType, pPrivateInputSize, ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, Span<uint> pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, in pDecoderProfile.GetPinnableReference(), pKeyExchangeType, ref pPrivateInputSize.GetPinnableReference(), pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, Span<uint> pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, in pDecoderProfile.GetPinnableReference(), pKeyExchangeType, ref pPrivateInputSize.GetPinnableReference(), ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, in pDecoderProfile.GetPinnableReference(), in pKeyExchangeType.GetPinnableReference(), pPrivateInputSize, pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, uint* pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, in pDecoderProfile.GetPinnableReference(), in pKeyExchangeType.GetPinnableReference(), pPrivateInputSize, ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, Span<uint> pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, in pDecoderProfile.GetPinnableReference(), in pKeyExchangeType.GetPinnableReference(), ref pPrivateInputSize.GetPinnableReference(), pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, Span<uint> pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(pCryptoType, in pDecoderProfile.GetPinnableReference(), in pKeyExchangeType.GetPinnableReference(), ref pPrivateInputSize.GetPinnableReference(), ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), pDecoderProfile, pKeyExchangeType, pPrivateInputSize, ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, Span<uint> pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), pDecoderProfile, pKeyExchangeType, ref pPrivateInputSize.GetPinnableReference(), pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, Span<uint> pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), pDecoderProfile, pKeyExchangeType, ref pPrivateInputSize.GetPinnableReference(), ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), pDecoderProfile, in pKeyExchangeType.GetPinnableReference(), pPrivateInputSize, pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, uint* pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), pDecoderProfile, in pKeyExchangeType.GetPinnableReference(), pPrivateInputSize, ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, Span<uint> pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), pDecoderProfile, in pKeyExchangeType.GetPinnableReference(), ref pPrivateInputSize.GetPinnableReference(), pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, Span<uint> pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), pDecoderProfile, in pKeyExchangeType.GetPinnableReference(), ref pPrivateInputSize.GetPinnableReference(), ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, uint* pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), pKeyExchangeType, pPrivateInputSize, ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, Span<uint> pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), pKeyExchangeType, ref pPrivateInputSize.GetPinnableReference(), pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pKeyExchangeType, Span<uint> pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), pKeyExchangeType, ref pPrivateInputSize.GetPinnableReference(), ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), in pKeyExchangeType.GetPinnableReference(), pPrivateInputSize, pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, uint* pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), in pKeyExchangeType.GetPinnableReference(), pPrivateInputSize, ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, Span<uint> pPrivateInputSize, uint* pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), in pKeyExchangeType.GetPinnableReference(), ref pPrivateInputSize.GetPinnableReference(), pPrivateOutputSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetCryptoSessionPrivateDataSize(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pKeyExchangeType, Span<uint> pPrivateInputSize, Span<uint> pPrivateOutputSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCryptoSessionPrivateDataSize(in pCryptoType.GetPinnableReference(), in pDecoderProfile.GetPinnableReference(), in pKeyExchangeType.GetPinnableReference(), ref pPrivateInputSize.GetPinnableReference(), ref pPrivateOutputSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, Span<uint> pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, ref pDecoderCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, in pCryptoType.GetPinnableReference(), pDecoderCaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, Span<uint> pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, in pCryptoType.GetPinnableReference(), ref pDecoderCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(pDecoderProfile, SampleWidth, SampleHeight, in pFrameRate.GetPinnableReference(), BitRate, pCryptoType, pDecoderCaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, Span<uint> pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(pDecoderProfile, SampleWidth, SampleHeight, in pFrameRate.GetPinnableReference(), BitRate, pCryptoType, ref pDecoderCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(pDecoderProfile, SampleWidth, SampleHeight, in pFrameRate.GetPinnableReference(), BitRate, in pCryptoType.GetPinnableReference(), pDecoderCaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, Span<uint> pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(pDecoderProfile, SampleWidth, SampleHeight, in pFrameRate.GetPinnableReference(), BitRate, in pCryptoType.GetPinnableReference(), ref pDecoderCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(in pDecoderProfile.GetPinnableReference(), SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, Span<uint> pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(in pDecoderProfile.GetPinnableReference(), SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, ref pDecoderCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(in pDecoderProfile.GetPinnableReference(), SampleWidth, SampleHeight, pFrameRate, BitRate, in pCryptoType.GetPinnableReference(), pDecoderCaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, Span<uint> pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(in pDecoderProfile.GetPinnableReference(), SampleWidth, SampleHeight, pFrameRate, BitRate, in pCryptoType.GetPinnableReference(), ref pDecoderCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(in pDecoderProfile.GetPinnableReference(), SampleWidth, SampleHeight, in pFrameRate.GetPinnableReference(), BitRate, pCryptoType, pDecoderCaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, Span<uint> pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(in pDecoderProfile.GetPinnableReference(), SampleWidth, SampleHeight, in pFrameRate.GetPinnableReference(), BitRate, pCryptoType, ref pDecoderCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, uint* pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(in pDecoderProfile.GetPinnableReference(), SampleWidth, SampleHeight, in pFrameRate.GetPinnableReference(), BitRate, in pCryptoType.GetPinnableReference(), pDecoderCaps);
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoDecoderCaps(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecoderProfile, uint SampleWidth, uint SampleHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, uint BitRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, Span<uint> pDecoderCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoDecoderCaps(in pDecoderProfile.GetPinnableReference(), SampleWidth, SampleHeight, in pFrameRate.GetPinnableReference(), BitRate, in pCryptoType.GetPinnableReference(), ref pDecoderCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, pFrameRate, in pOutputDesc.GetPinnableReference(), pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, pFrameRate, in pOutputDesc.GetPinnableReference(), pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, pFrameRate, in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, pFrameRate, in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), pOutputDesc, pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), pOutputDesc, pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), pOutputDesc, ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), pOutputDesc, ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, pOutputDesc, pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, pOutputDesc, ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, pOutputDesc, ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, in pOutputDesc.GetPinnableReference(), pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, in pOutputDesc.GetPinnableReference(), pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), pOutputDesc, pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), pOutputDesc, pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), pOutputDesc, ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), pOutputDesc, ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, pFrameRate, in pOutputDesc.GetPinnableReference(), pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, pFrameRate, in pOutputDesc.GetPinnableReference(), pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, pFrameRate, in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, pFrameRate, in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), pOutputDesc, pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), pOutputDesc, pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), pOutputDesc, ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), pOutputDesc, ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, pOutputDesc, pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, pOutputDesc, ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, pOutputDesc, ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, in pOutputDesc.GetPinnableReference(), pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, in pOutputDesc.GetPinnableReference(), pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), pOutputDesc, pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), pOutputDesc, pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), pOutputDesc, ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), pOutputDesc, ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), pSupported, pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, int* pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), pSupported, ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, int* pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), pRealTimeHint);
    }

    /// <summary>To be documented.</summary>
    public static int CheckVideoDecoderDownsampling(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoSampleDesc> pOutputDesc, Span<int> pSupported, Span<int> pRealTimeHint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoDecoderDownsampling(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), in pOutputDesc.GetPinnableReference(), ref pSupported.GetPinnableReference(), ref pRealTimeHint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, Span<VideoSampleDesc> pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(pInputDesc, InputColorSpace, pInputConfig, pFrameRate, ref pRecommendedOutputDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(pInputDesc, InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), pRecommendedOutputDesc);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, Span<VideoSampleDesc> pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(pInputDesc, InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), ref pRecommendedOutputDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, pRecommendedOutputDesc);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, Span<VideoSampleDesc> pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, ref pRecommendedOutputDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), pRecommendedOutputDesc);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, Span<VideoSampleDesc> pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(pInputDesc, InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), ref pRecommendedOutputDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, Span<VideoSampleDesc> pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, pFrameRate, ref pRecommendedOutputDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), pRecommendedOutputDesc);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderConfig* pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, Span<VideoSampleDesc> pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(in pInputDesc.GetPinnableReference(), InputColorSpace, pInputConfig, in pFrameRate.GetPinnableReference(), ref pRecommendedOutputDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, pRecommendedOutputDesc);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pFrameRate, Span<VideoSampleDesc> pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), pFrameRate, ref pRecommendedOutputDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), pRecommendedOutputDesc);
    }

    /// <summary>To be documented.</summary>
    public static int RecommendVideoDecoderDownsampleParameters(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderConfig> pInputConfig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.Rational> pFrameRate, Span<VideoSampleDesc> pRecommendedOutputDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RecommendVideoDecoderDownsampleParameters(in pInputDesc.GetPinnableReference(), InputColorSpace, in pInputConfig.GetPinnableReference(), in pFrameRate.GetPinnableReference(), ref pRecommendedOutputDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCryptoSession(pCryptoType, pDecoderProfile, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCryptoSession(pCryptoType, in pDecoderProfile, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCryptoSession(in pCryptoType, pDecoderProfile, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCryptoSession<TI0>(this ComPtr<ID3D11VideoDevice1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecoderProfile) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCryptoSession(in pCryptoType, in pDecoderProfile, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
