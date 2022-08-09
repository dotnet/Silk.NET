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

public unsafe static class D3D11VideoContext1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice<TThis>(this TThis thisVtbl, ID3D11Device** ppDevice) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice<TThis>(this TThis thisVtbl, ref ID3D11Device* ppDevice) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Device** ppDevicePtr = &ppDevice)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, ref void* ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppBufferPtr = &ppBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, void** ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pBufferSizePtr = &pBufferSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, ref void* ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pBufferSizePtr = &pBufferSize)
        {
            fixed (void** ppBufferPtr = &ppBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, ref void* ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (void** ppBufferPtr = &ppBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, void** ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (uint* pBufferSizePtr = &pBufferSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, ref void* ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (uint* pBufferSizePtr = &pBufferSize)
            {
                fixed (void** ppBufferPtr = &ppBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReleaseDecoderBuffer<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)@this->LpVtbl[8])(@this, pDecoder, Type);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseDecoderBuffer<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)@this->LpVtbl[8])(@this, pDecoderPtr, Type);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKey);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame<T0, TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pContentKeyPtr = &pContentKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKeyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKey);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame<T0, TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKeyPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKey);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame<T0, TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKeyPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKey);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DecoderBeginFrame<T0, TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKeyPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderEndFrame<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, int>)@this->LpVtbl[10])(@this, pDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DecoderEndFrame<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, int>)@this->LpVtbl[10])(@this, pDecoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitDecoderBuffers<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, uint NumBuffers, VideoDecoderBufferDesc* pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)@this->LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitDecoderBuffers<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderBufferDesc* pBufferDescPtr = &pBufferDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)@this->LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitDecoderBuffers<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, uint NumBuffers, VideoDecoderBufferDesc* pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)@this->LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SubmitDecoderBuffers<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (VideoDecoderBufferDesc* pBufferDescPtr = &pBufferDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)@this->LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderExtension<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, VideoDecoderExtension* pExtensionData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)@this->LpVtbl[12])(@this, pDecoder, pExtensionData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderExtension<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, ref VideoDecoderExtension pExtensionData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderExtension* pExtensionDataPtr = &pExtensionData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)@this->LpVtbl[12])(@this, pDecoder, pExtensionDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderExtension<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, VideoDecoderExtension* pExtensionData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)@this->LpVtbl[12])(@this, pDecoderPtr, pExtensionData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DecoderExtension<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, ref VideoDecoderExtension pExtensionData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (VideoDecoderExtension* pExtensionDataPtr = &pExtensionData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)@this->LpVtbl[12])(@this, pDecoderPtr, pExtensionDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputTargetRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int Enable, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[13])(@this, pVideoProcessor, Enable, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputTargetRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[13])(@this, pVideoProcessor, Enable, pRectPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputTargetRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int Enable, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRect);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputTargetRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRectPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputBackgroundColor<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int YCbCr, VideoColor* pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, VideoColor*, void>)@this->LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputBackgroundColor<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int YCbCr, ref VideoColor pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoColor* pColorPtr = &pColor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, VideoColor*, void>)@this->LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColorPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputBackgroundColor<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int YCbCr, VideoColor* pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, VideoColor*, void>)@this->LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColor);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputBackgroundColor<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int YCbCr, ref VideoColor pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoColor* pColorPtr = &pColor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, VideoColor*, void>)@this->LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColorPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputColorSpace<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, VideoProcessorColorSpace* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[15])(@this, pVideoProcessor, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputColorSpace<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorColorSpace pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[15])(@this, pVideoProcessor, pColorSpacePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputColorSpace<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorColorSpace* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpace);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputColorSpace<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorColorSpace pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpacePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputAlphaFillMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)@this->LpVtbl[16])(@this, pVideoProcessor, AlphaFillMode, StreamIndex);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputAlphaFillMode<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)@this->LpVtbl[16])(@this, pVideoProcessorPtr, AlphaFillMode, StreamIndex);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputConstriction<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int Enable, Silk.NET.Maths.Vector2D<int> Size) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Vector2D<int>, void>)@this->LpVtbl[17])(@this, pVideoProcessor, Enable, Size);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputConstriction<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int Enable, Silk.NET.Maths.Vector2D<int> Size) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Vector2D<int>, void>)@this->LpVtbl[17])(@this, pVideoProcessorPtr, Enable, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputStereoMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int Enable) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, void>)@this->LpVtbl[18])(@this, pVideoProcessor, Enable);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputStereoMode<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int Enable) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, void>)@this->LpVtbl[18])(@this, pVideoProcessorPtr, Enable);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension<T0, TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessorSetOutputExtension<T0, TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* Enabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessor, Enabled, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* Enabled, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessor, Enabled, pRectPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref int Enabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* EnabledPtr = &Enabled)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRect);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref int Enabled, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* EnabledPtr = &Enabled)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRectPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int* Enabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRect);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int* Enabled, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRectPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref int Enabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* EnabledPtr = &Enabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRect);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref int Enabled, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* EnabledPtr = &Enabled)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRectPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* pYCbCr, VideoColor* pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* pYCbCr, ref VideoColor pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoColor* pColorPtr = &pColor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColorPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref int pYCbCr, VideoColor* pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pYCbCrPtr = &pYCbCr)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref int pYCbCr, ref VideoColor pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pYCbCrPtr = &pYCbCr)
        {
            fixed (VideoColor* pColorPtr = &pColor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColorPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int* pYCbCr, VideoColor* pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int* pYCbCr, ref VideoColor pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoColor* pColorPtr = &pColor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColorPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref int pYCbCr, VideoColor* pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pYCbCrPtr = &pYCbCr)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref int pYCbCr, ref VideoColor pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pYCbCrPtr = &pYCbCr)
            {
                fixed (VideoColor* pColorPtr = &pColor)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColorPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputColorSpace<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, VideoProcessorColorSpace* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[22])(@this, pVideoProcessor, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputColorSpace<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorColorSpace pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[22])(@this, pVideoProcessor, pColorSpacePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputColorSpace<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorColorSpace* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpace);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputColorSpace<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorColorSpace pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpacePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, ref uint pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (uint* pStreamIndexPtr = &pStreamIndex)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndexPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, uint* pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndex);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, ref uint pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
        {
            fixed (uint* pStreamIndexPtr = &pStreamIndex)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndexPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndex);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, ref uint pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (uint* pStreamIndexPtr = &pStreamIndex)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndexPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, uint* pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndex);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, ref uint pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
            {
                fixed (uint* pStreamIndexPtr = &pStreamIndex)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndexPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* pEnabled, Silk.NET.Maths.Vector2D<int>* pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSizePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled, Silk.NET.Maths.Vector2D<int>* pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSize);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSizePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled, Silk.NET.Maths.Vector2D<int>* pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSize);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSizePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled, Silk.NET.Maths.Vector2D<int>* pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSize);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSizePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputStereoMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[25])(@this, pVideoProcessor, pEnabled);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputStereoMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[25])(@this, pVideoProcessor, pEnabledPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputStereoMode<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[25])(@this, pVideoProcessorPtr, pEnabled);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputStereoMode<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[25])(@this, pVideoProcessorPtr, pEnabledPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension<T0, TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessorGetOutputExtension<T0, TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamFrameFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)@this->LpVtbl[27])(@this, pVideoProcessor, StreamIndex, FrameFormat);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamFrameFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)@this->LpVtbl[27])(@this, pVideoProcessorPtr, StreamIndex, FrameFormat);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamColorSpace<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamColorSpace<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamColorSpace<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamColorSpace<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamOutputRate<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamOutputRate<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamSourceRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamSourceRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamSourceRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamSourceRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamDestRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamDestRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamDestRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamDestRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamAlpha<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, float Alpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, float, void>)@this->LpVtbl[32])(@this, pVideoProcessor, StreamIndex, Enable, Alpha);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamAlpha<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, float Alpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, float, void>)@this->LpVtbl[32])(@this, pVideoProcessorPtr, StreamIndex, Enable, Alpha);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPalette<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPalette<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (uint* pEntriesPtr = &pEntries)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPalette<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamPalette<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (uint* pEntriesPtr = &pEntries)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
        {
            fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, float Lower, float Upper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, float, float, void>)@this->LpVtbl[35])(@this, pVideoProcessor, StreamIndex, Enable, Lower, Upper);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamLumaKey<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, float Lower, float Upper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, float, float, void>)@this->LpVtbl[35])(@this, pVideoProcessorPtr, StreamIndex, Enable, Lower, Upper);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorStereoFormat Format, int LeftViewFrame0, int BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, VideoProcessorStereoFormat, int, int, VideoProcessorStereoFlipMode, int, void>)@this->LpVtbl[36])(@this, pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorStereoFormat Format, int LeftViewFrame0, int BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, VideoProcessorStereoFormat, int, int, VideoProcessorStereoFlipMode, int, void>)@this->LpVtbl[36])(@this, pVideoProcessorPtr, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamAutoProcessingMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, void>)@this->LpVtbl[37])(@this, pVideoProcessor, StreamIndex, Enable);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamAutoProcessingMode<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, void>)@this->LpVtbl[37])(@this, pVideoProcessorPtr, StreamIndex, Enable);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamFilter<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int Enable, int Level) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int, int, void>)@this->LpVtbl[38])(@this, pVideoProcessor, StreamIndex, Filter, Enable, Level);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamFilter<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int Enable, int Level) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int, int, void>)@this->LpVtbl[38])(@this, pVideoProcessorPtr, StreamIndex, Filter, Enable, Level);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension<T0, TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessorSetStreamExtension<T0, TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFrameFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)@this->LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFrameFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoFrameFormat pFrameFormat) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoFrameFormat* pFrameFormatPtr = &pFrameFormat)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)@this->LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormatPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFrameFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)@this->LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormat);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamFrameFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoFrameFormat pFrameFormat) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoFrameFormat* pFrameFormatPtr = &pFrameFormat)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)@this->LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormatPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamColorSpace<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamColorSpace<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamColorSpace<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamColorSpace<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pRepeatFramePtr = &pRepeatFrame)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pRepeatFramePtr = &pRepeatFrame)
        {
            fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
        {
            fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
        {
            fixed (int* pRepeatFramePtr = &pRepeatFrame)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
        {
            fixed (int* pRepeatFramePtr = &pRepeatFrame)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pRepeatFramePtr = &pRepeatFrame)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pRepeatFramePtr = &pRepeatFrame)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlpha);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (float* pAlphaPtr = &pAlpha)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlphaPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlpha);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            fixed (float* pAlphaPtr = &pAlpha)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlphaPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlpha);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (float* pAlphaPtr = &pAlpha)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlphaPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlpha);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pAlphaPtr = &pAlpha)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlphaPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPalette<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPalette<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (uint* pEntriesPtr = &pEntries)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPalette<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamPalette<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (uint* pEntriesPtr = &pEntries)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
        {
            fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, ref float pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (float* pUpperPtr = &pUpper)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpperPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (float* pLowerPtr = &pLower)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpper);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, ref float pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (float* pLowerPtr = &pLower)
        {
            fixed (float* pUpperPtr = &pUpper)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpper);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, ref float pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            fixed (float* pUpperPtr = &pUpper)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            fixed (float* pLowerPtr = &pLower)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, ref float pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            fixed (float* pLowerPtr = &pLower)
            {
                fixed (float* pUpperPtr = &pUpper)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpper);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, ref float pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (float* pUpperPtr = &pUpper)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpperPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (float* pLowerPtr = &pLower)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpper);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, ref float pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (float* pLowerPtr = &pLower)
            {
                fixed (float* pUpperPtr = &pUpper)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpper);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, ref float pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pUpperPtr = &pUpper)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, ref float pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    fixed (float* pUpperPtr = &pUpper)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* MonoOffsetPtr = &MonoOffset)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
        {
            fixed (int* MonoOffsetPtr = &MonoOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
        {
            fixed (int* MonoOffsetPtr = &MonoOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
        {
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
        {
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
        {
            fixed (int* MonoOffsetPtr = &MonoOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
        {
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
        {
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (int* MonoOffsetPtr = &MonoOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* MonoOffsetPtr = &MonoOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* MonoOffsetPtr = &MonoOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                fixed (int* MonoOffsetPtr = &MonoOffset)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAutoProcessingMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, void>)@this->LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabled);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAutoProcessingMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, void>)@this->LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabledPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAutoProcessingMode<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, void>)@this->LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabled);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamAutoProcessingMode<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, void>)@this->LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, ref int pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pLevelPtr = &pLevel)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevelPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, int* pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevel);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, ref int pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnabledPtr = &pEnabled)
        {
            fixed (int* pLevelPtr = &pLevel)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevel);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, ref int pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pLevelPtr = &pLevel)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevelPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, int* pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevel);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, ref int pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (int* pLevelPtr = &pLevel)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension<T0, TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessorGetStreamExtension<T0, TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreamsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreams);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
        {
            fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreams);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreamsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreams);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessorBlt<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
            {
                fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateCryptoSessionKeyExchange<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[54])(@this, pCryptoSession, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateCryptoSessionKeyExchange<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[54])(@this, pCryptoSession, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateCryptoSessionKeyExchange<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateCryptoSessionKeyExchange<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (void* pIVPtr = &pIV)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIVPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIV);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIVPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void EncryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (void* pIVPtr = &pIV)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (void* pContentKeyPtr = &pContentKey)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (void* pContentKeyPtr = &pContentKey)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (void* pIVPtr = &pIV)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            fixed (void* pIVPtr = &pIV)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void StartSessionKeyRefresh<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, void* pRandomNumber) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, void>)@this->LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumber);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void StartSessionKeyRefresh<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, ref T0 pRandomNumber) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (void* pRandomNumberPtr = &pRandomNumber)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, void>)@this->LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumberPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void StartSessionKeyRefresh<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, uint RandomNumberSize, void* pRandomNumber) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, void>)@this->LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumber);
        }
    }

    /// <summary>To be documented.</summary>
    public static void StartSessionKeyRefresh<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, uint RandomNumberSize, ref T0 pRandomNumber) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (void* pRandomNumberPtr = &pRandomNumber)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, void>)@this->LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumberPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FinishSessionKeyRefresh<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, void>)@this->LpVtbl[58])(@this, pCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static void FinishSessionKeyRefresh<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, void>)@this->LpVtbl[58])(@this, pCryptoSessionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncryptionBltKey<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint KeySize, void* pReadbackKey) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKey);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncryptionBltKey<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint KeySize, ref T0 pReadbackKey) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pReadbackKeyPtr = &pReadbackKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKeyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncryptionBltKey<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, uint KeySize, void* pReadbackKey) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKey);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetEncryptionBltKey<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, uint KeySize, ref T0 pReadbackKey) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (void* pReadbackKeyPtr = &pReadbackKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKeyPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateAuthenticatedChannelKeyExchange<TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, int>)@this->LpVtbl[60])(@this, pChannel, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateAuthenticatedChannelKeyExchange<T0, TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, int>)@this->LpVtbl[60])(@this, pChannel, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateAuthenticatedChannelKeyExchange<TThis>(this TThis thisVtbl, ref ID3D11AuthenticatedChannel pChannel, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, int>)@this->LpVtbl[60])(@this, pChannelPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateAuthenticatedChannelKeyExchange<T0, TThis>(this TThis thisVtbl, ref ID3D11AuthenticatedChannel pChannel, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, int>)@this->LpVtbl[60])(@this, pChannelPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel<TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, uint OutputSize, void* pOutput) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pInputPtr = &pInput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutput);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel<T0, T1, TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pInputPtr = &pInput)
        {
            fixed (void* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutputPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel<TThis>(this TThis thisVtbl, ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, uint OutputSize, void* pOutput) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutput);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
        {
            fixed (void* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutputPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
        {
            fixed (void* pInputPtr = &pInput)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutput);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryAuthenticatedChannel<T0, T1, TThis>(this TThis thisVtbl, ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
        {
            fixed (void* pInputPtr = &pInput)
            {
                fixed (void* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutputPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel<TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, AuthenticatedConfigureOutput* pOutput) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel<TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, ref AuthenticatedConfigureOutput pOutput) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pInputPtr = &pInput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutput);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, ref AuthenticatedConfigureOutput pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pInputPtr = &pInput)
        {
            fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutputPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel<TThis>(this TThis thisVtbl, ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, AuthenticatedConfigureOutput* pOutput) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutput);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel<TThis>(this TThis thisVtbl, ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, ref AuthenticatedConfigureOutput pOutput) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
        {
            fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutputPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
        {
            fixed (void* pInputPtr = &pInput)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutput);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ConfigureAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, ref AuthenticatedConfigureOutput pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
        {
            fixed (void* pInputPtr = &pInput)
            {
                fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutputPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamRotation<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorRotation Rotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, VideoProcessorRotation, void>)@this->LpVtbl[63])(@this, pVideoProcessor, StreamIndex, Enable, Rotation);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamRotation<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorRotation Rotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, VideoProcessorRotation, void>)@this->LpVtbl[63])(@this, pVideoProcessorPtr, StreamIndex, Enable, Rotation);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorRotation pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotationPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorRotation* pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotation);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorRotation pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotationPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotation);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorRotation pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotationPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorRotation* pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotation);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorRotation pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotationPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitDecoderBuffers1<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, uint NumBuffers, VideoDecoderBufferDesc1* pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc1*, int>)@this->LpVtbl[65])(@this, pDecoder, NumBuffers, pBufferDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitDecoderBuffers1<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc1 pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderBufferDesc1* pBufferDescPtr = &pBufferDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc1*, int>)@this->LpVtbl[65])(@this, pDecoder, NumBuffers, pBufferDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitDecoderBuffers1<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, uint NumBuffers, VideoDecoderBufferDesc1* pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc1*, int>)@this->LpVtbl[65])(@this, pDecoderPtr, NumBuffers, pBufferDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SubmitDecoderBuffers1<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc1 pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (VideoDecoderBufferDesc1* pBufferDescPtr = &pBufferDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc1*, int>)@this->LpVtbl[65])(@this, pDecoderPtr, NumBuffers, pBufferDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, void* pPrivatInputData, ulong* pPrivateOutputData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSession, PrivateInputSize, pPrivatInputData, pPrivateOutputData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, void* pPrivatInputData, ref ulong pPrivateOutputData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ulong* pPrivateOutputDataPtr = &pPrivateOutputData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSession, PrivateInputSize, pPrivatInputData, pPrivateOutputDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, ref T0 pPrivatInputData, ulong* pPrivateOutputData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pPrivatInputDataPtr = &pPrivatInputData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSession, PrivateInputSize, pPrivatInputDataPtr, pPrivateOutputData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, ref T0 pPrivatInputData, ref ulong pPrivateOutputData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pPrivatInputDataPtr = &pPrivatInputData)
        {
            fixed (ulong* pPrivateOutputDataPtr = &pPrivateOutputData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSession, PrivateInputSize, pPrivatInputDataPtr, pPrivateOutputDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, void* pPrivatInputData, ulong* pPrivateOutputData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSessionPtr, PrivateInputSize, pPrivatInputData, pPrivateOutputData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, void* pPrivatInputData, ref ulong pPrivateOutputData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (ulong* pPrivateOutputDataPtr = &pPrivateOutputData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSessionPtr, PrivateInputSize, pPrivatInputData, pPrivateOutputDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, ref T0 pPrivatInputData, ulong* pPrivateOutputData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (void* pPrivatInputDataPtr = &pPrivatInputData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSessionPtr, PrivateInputSize, pPrivatInputDataPtr, pPrivateOutputData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDataForNewHardwareKey<T0, TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, ref T0 pPrivatInputData, ref ulong pPrivateOutputData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (void* pPrivatInputDataPtr = &pPrivatInputData)
            {
                fixed (ulong* pPrivateOutputDataPtr = &pPrivateOutputData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSessionPtr, PrivateInputSize, pPrivatInputDataPtr, pPrivateOutputDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoSessionStatus<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, CryptoSessionStatus* pStatus) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, CryptoSessionStatus*, int>)@this->LpVtbl[67])(@this, pCryptoSession, pStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoSessionStatus<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ref CryptoSessionStatus pStatus) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (CryptoSessionStatus* pStatusPtr = &pStatus)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, CryptoSessionStatus*, int>)@this->LpVtbl[67])(@this, pCryptoSession, pStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoSessionStatus<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, CryptoSessionStatus* pStatus) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, CryptoSessionStatus*, int>)@this->LpVtbl[67])(@this, pCryptoSessionPtr, pStatus);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckCryptoSessionStatus<TThis>(this TThis thisVtbl, ref ID3D11CryptoSession pCryptoSession, ref CryptoSessionStatus pStatus) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
        {
            fixed (CryptoSessionStatus* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, CryptoSessionStatus*, int>)@this->LpVtbl[67])(@this, pCryptoSessionPtr, pStatusPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderEnableDownsampling<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoSampleDesc* pOutputDesc, uint ReferenceFrameCount) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, Silk.NET.DXGI.ColorSpaceType, VideoSampleDesc*, uint, int>)@this->LpVtbl[68])(@this, pDecoder, InputColorSpace, pOutputDesc, ReferenceFrameCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderEnableDownsampling<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoSampleDesc pOutputDesc, uint ReferenceFrameCount) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, Silk.NET.DXGI.ColorSpaceType, VideoSampleDesc*, uint, int>)@this->LpVtbl[68])(@this, pDecoder, InputColorSpace, pOutputDescPtr, ReferenceFrameCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderEnableDownsampling<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoSampleDesc* pOutputDesc, uint ReferenceFrameCount) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, Silk.NET.DXGI.ColorSpaceType, VideoSampleDesc*, uint, int>)@this->LpVtbl[68])(@this, pDecoderPtr, InputColorSpace, pOutputDesc, ReferenceFrameCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DecoderEnableDownsampling<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoSampleDesc pOutputDesc, uint ReferenceFrameCount) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, Silk.NET.DXGI.ColorSpaceType, VideoSampleDesc*, uint, int>)@this->LpVtbl[68])(@this, pDecoderPtr, InputColorSpace, pOutputDescPtr, ReferenceFrameCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderUpdateDownsampling<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, VideoSampleDesc* pOutputDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoSampleDesc*, int>)@this->LpVtbl[69])(@this, pDecoder, pOutputDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderUpdateDownsampling<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, ref VideoSampleDesc pOutputDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoSampleDesc*, int>)@this->LpVtbl[69])(@this, pDecoder, pOutputDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderUpdateDownsampling<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, VideoSampleDesc* pOutputDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoSampleDesc*, int>)@this->LpVtbl[69])(@this, pDecoderPtr, pOutputDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DecoderUpdateDownsampling<TThis>(this TThis thisVtbl, ref ID3D11VideoDecoder pDecoder, ref VideoSampleDesc pOutputDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
        {
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoSampleDesc*, int>)@this->LpVtbl[69])(@this, pDecoderPtr, pOutputDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputColorSpace1<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.ColorSpaceType ColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType, void>)@this->LpVtbl[70])(@this, pVideoProcessor, ColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputColorSpace1<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.DXGI.ColorSpaceType ColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType, void>)@this->LpVtbl[70])(@this, pVideoProcessorPtr, ColorSpace);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputShaderUsage<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int ShaderUsage) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, void>)@this->LpVtbl[71])(@this, pVideoProcessor, ShaderUsage);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputShaderUsage<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int ShaderUsage) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int, void>)@this->LpVtbl[71])(@this, pVideoProcessorPtr, ShaderUsage);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputColorSpace1<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.ColorSpaceType* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[72])(@this, pVideoProcessor, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputColorSpace1<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref Silk.NET.DXGI.ColorSpaceType pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.DXGI.ColorSpaceType* pColorSpacePtr = &pColorSpace)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[72])(@this, pVideoProcessor, pColorSpacePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputColorSpace1<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.DXGI.ColorSpaceType* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[72])(@this, pVideoProcessorPtr, pColorSpace);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputColorSpace1<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref Silk.NET.DXGI.ColorSpaceType pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.DXGI.ColorSpaceType* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[72])(@this, pVideoProcessorPtr, pColorSpacePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputShaderUsage<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* pShaderUsage) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[73])(@this, pVideoProcessor, pShaderUsage);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputShaderUsage<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ref int pShaderUsage) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pShaderUsagePtr = &pShaderUsage)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[73])(@this, pVideoProcessor, pShaderUsagePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputShaderUsage<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, int* pShaderUsage) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[73])(@this, pVideoProcessorPtr, pShaderUsage);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputShaderUsage<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, ref int pShaderUsage) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pShaderUsagePtr = &pShaderUsage)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[73])(@this, pVideoProcessorPtr, pShaderUsagePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamColorSpace1<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType ColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType, void>)@this->LpVtbl[74])(@this, pVideoProcessor, StreamIndex, ColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamColorSpace1<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType ColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType, void>)@this->LpVtbl[74])(@this, pVideoProcessorPtr, StreamIndex, ColorSpace);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, int FlipHorizontal, int FlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, int, int, void>)@this->LpVtbl[75])(@this, pVideoProcessor, StreamIndex, Enable, FlipHorizontal, FlipVertical);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamMirror<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, int FlipHorizontal, int FlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int, int, int, void>)@this->LpVtbl[75])(@this, pVideoProcessorPtr, StreamIndex, Enable, FlipHorizontal, FlipVertical);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamColorSpace1<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[76])(@this, pVideoProcessor, StreamIndex, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamColorSpace1<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Silk.NET.DXGI.ColorSpaceType pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.DXGI.ColorSpaceType* pColorSpacePtr = &pColorSpace)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[76])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamColorSpace1<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[76])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamColorSpace1<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Silk.NET.DXGI.ColorSpaceType pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (Silk.NET.DXGI.ColorSpaceType* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[76])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, ref int pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pFlipVerticalPtr = &pFlipVertical)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontal, pFlipVerticalPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontalPtr, pFlipVertical);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, ref int pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
        {
            fixed (int* pFlipVerticalPtr = &pFlipVertical)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontalPtr, pFlipVerticalPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFlipHorizontal, pFlipVertical);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, ref int pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pFlipVerticalPtr = &pFlipVertical)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFlipHorizontal, pFlipVerticalPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFlipHorizontalPtr, pFlipVertical);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, ref int pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (int* pEnablePtr = &pEnable)
        {
            fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
            {
                fixed (int* pFlipVerticalPtr = &pFlipVertical)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFlipHorizontalPtr, pFlipVerticalPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, ref int pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pFlipVerticalPtr = &pFlipVertical)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFlipHorizontal, pFlipVerticalPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFlipHorizontalPtr, pFlipVertical);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, ref int pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
            {
                fixed (int* pFlipVerticalPtr = &pFlipVertical)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFlipHorizontalPtr, pFlipVerticalPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFlipHorizontal, pFlipVertical);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, ref int pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pFlipVerticalPtr = &pFlipVertical)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFlipHorizontal, pFlipVerticalPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFlipHorizontalPtr, pFlipVertical);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, ref int pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                {
                    fixed (int* pFlipVerticalPtr = &pFlipVertical)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFlipHorizontalPtr, pFlipVerticalPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, VideoProcessorStreamBehaviorHint* pStreams, uint* pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, VideoProcessorStreamBehaviorHint* pStreams, ref uint pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pBehaviorHintsPtr = &pBehaviorHints)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHintsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, ref VideoProcessorStreamBehaviorHint pStreams, uint* pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorStreamBehaviorHint* pStreamsPtr = &pStreams)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreamsPtr, pBehaviorHints);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, ref VideoProcessorStreamBehaviorHint pStreams, ref uint pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessorStreamBehaviorHint* pStreamsPtr = &pStreams)
        {
            fixed (uint* pBehaviorHintsPtr = &pBehaviorHints)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreamsPtr, pBehaviorHintsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, VideoProcessorStreamBehaviorHint* pStreams, uint* pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessorPtr, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, VideoProcessorStreamBehaviorHint* pStreams, ref uint pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (uint* pBehaviorHintsPtr = &pBehaviorHints)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessorPtr, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHintsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, ref VideoProcessorStreamBehaviorHint pStreams, uint* pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStreamBehaviorHint* pStreamsPtr = &pStreams)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessorPtr, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreamsPtr, pBehaviorHints);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, ref ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, ref VideoProcessorStreamBehaviorHint pStreams, ref uint pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessorStreamBehaviorHint* pStreamsPtr = &pStreams)
            {
                fixed (uint* pBehaviorHintsPtr = &pBehaviorHints)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessorPtr, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreamsPtr, pBehaviorHintsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetDevice<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GetDevice((ID3D11Device**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, Span<uint> pBufferSize, void** ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderBuffer(pDecoder, Type, ref pBufferSize.GetPinnableReference(), ppBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, Span<uint> pBufferSize, ref void* ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderBuffer(pDecoder, Type, ref pBufferSize.GetPinnableReference(), ref ppBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderBuffer(ref pDecoder.GetPinnableReference(), Type, pBufferSize, ppBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, ref void* ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderBuffer(ref pDecoder.GetPinnableReference(), Type, pBufferSize, ref ppBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, VideoDecoderBufferType Type, Span<uint> pBufferSize, void** ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderBuffer(ref pDecoder.GetPinnableReference(), Type, ref pBufferSize.GetPinnableReference(), ppBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, VideoDecoderBufferType Type, Span<uint> pBufferSize, ref void* ppBuffer) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDecoderBuffer(ref pDecoder.GetPinnableReference(), Type, ref pBufferSize.GetPinnableReference(), ref ppBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseDecoderBuffer<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, VideoDecoderBufferType Type) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ReleaseDecoderBuffer(ref pDecoder.GetPinnableReference(), Type);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame<T0, TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, Span<T0> pContentKey) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderBeginFrame(pDecoder, pView, ContentKeySize, ref pContentKey.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, Span<ID3D11VideoDecoderOutputView> pView, uint ContentKeySize, void* pContentKey) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderBeginFrame(pDecoder, ref pView.GetPinnableReference(), ContentKeySize, pContentKey);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame<T0, TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, Span<ID3D11VideoDecoderOutputView> pView, uint ContentKeySize, Span<T0> pContentKey) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderBeginFrame(pDecoder, ref pView.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderBeginFrame(ref pDecoder.GetPinnableReference(), pView, ContentKeySize, pContentKey);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame<T0, TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, Span<T0> pContentKey) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderBeginFrame(ref pDecoder.GetPinnableReference(), pView, ContentKeySize, ref pContentKey.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, Span<ID3D11VideoDecoderOutputView> pView, uint ContentKeySize, void* pContentKey) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderBeginFrame(ref pDecoder.GetPinnableReference(), ref pView.GetPinnableReference(), ContentKeySize, pContentKey);
    }

    /// <summary>To be documented.</summary>
    public static int DecoderBeginFrame<T0, TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, Span<ID3D11VideoDecoderOutputView> pView, uint ContentKeySize, Span<T0> pContentKey) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderBeginFrame(ref pDecoder.GetPinnableReference(), ref pView.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DecoderEndFrame<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderEndFrame(ref pDecoder.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitDecoderBuffers<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, uint NumBuffers, Span<VideoDecoderBufferDesc> pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SubmitDecoderBuffers(pDecoder, NumBuffers, ref pBufferDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitDecoderBuffers<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, uint NumBuffers, VideoDecoderBufferDesc* pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SubmitDecoderBuffers(ref pDecoder.GetPinnableReference(), NumBuffers, pBufferDesc);
    }

    /// <summary>To be documented.</summary>
    public static int SubmitDecoderBuffers<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, uint NumBuffers, Span<VideoDecoderBufferDesc> pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SubmitDecoderBuffers(ref pDecoder.GetPinnableReference(), NumBuffers, ref pBufferDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderExtension<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, Span<VideoDecoderExtension> pExtensionData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderExtension(pDecoder, ref pExtensionData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderExtension<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, VideoDecoderExtension* pExtensionData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderExtension(ref pDecoder.GetPinnableReference(), pExtensionData);
    }

    /// <summary>To be documented.</summary>
    public static int DecoderExtension<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, Span<VideoDecoderExtension> pExtensionData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderExtension(ref pDecoder.GetPinnableReference(), ref pExtensionData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputTargetRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int Enable, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputTargetRect(pVideoProcessor, Enable, ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputTargetRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int Enable, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputTargetRect(ref pVideoProcessor.GetPinnableReference(), Enable, pRect);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputTargetRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int Enable, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputTargetRect(ref pVideoProcessor.GetPinnableReference(), Enable, ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputBackgroundColor<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int YCbCr, Span<VideoColor> pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputBackgroundColor(pVideoProcessor, YCbCr, ref pColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputBackgroundColor<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int YCbCr, VideoColor* pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputBackgroundColor(ref pVideoProcessor.GetPinnableReference(), YCbCr, pColor);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputBackgroundColor<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int YCbCr, Span<VideoColor> pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputBackgroundColor(ref pVideoProcessor.GetPinnableReference(), YCbCr, ref pColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputColorSpace<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<VideoProcessorColorSpace> pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputColorSpace(pVideoProcessor, ref pColorSpace.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputColorSpace<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, VideoProcessorColorSpace* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputColorSpace(ref pVideoProcessor.GetPinnableReference(), pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputColorSpace<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<VideoProcessorColorSpace> pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputColorSpace(ref pVideoProcessor.GetPinnableReference(), ref pColorSpace.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputAlphaFillMode<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputAlphaFillMode(ref pVideoProcessor.GetPinnableReference(), AlphaFillMode, StreamIndex);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputConstriction<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int Enable, Silk.NET.Maths.Vector2D<int> Size) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputConstriction(ref pVideoProcessor.GetPinnableReference(), Enable, Size);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputStereoMode<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int Enable) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputStereoMode(ref pVideoProcessor.GetPinnableReference(), Enable);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetOutputExtension(pVideoProcessor, pExtensionGuid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<Guid> pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetOutputExtension(pVideoProcessor, ref pExtensionGuid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<Guid> pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetOutputExtension(pVideoProcessor, ref pExtensionGuid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetOutputExtension(ref pVideoProcessor.GetPinnableReference(), pExtensionGuid, DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension<T0, TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Guid* pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetOutputExtension(ref pVideoProcessor.GetPinnableReference(), pExtensionGuid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<Guid> pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetOutputExtension(ref pVideoProcessor.GetPinnableReference(), ref pExtensionGuid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessorSetOutputExtension<T0, TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<Guid> pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetOutputExtension(ref pVideoProcessor.GetPinnableReference(), ref pExtensionGuid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* Enabled, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputTargetRect(pVideoProcessor, Enabled, ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<int> Enabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputTargetRect(pVideoProcessor, ref Enabled.GetPinnableReference(), pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<int> Enabled, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputTargetRect(pVideoProcessor, ref Enabled.GetPinnableReference(), ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int* Enabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputTargetRect(ref pVideoProcessor.GetPinnableReference(), Enabled, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int* Enabled, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputTargetRect(ref pVideoProcessor.GetPinnableReference(), Enabled, ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<int> Enabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputTargetRect(ref pVideoProcessor.GetPinnableReference(), ref Enabled.GetPinnableReference(), pRect);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputTargetRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<int> Enabled, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputTargetRect(ref pVideoProcessor.GetPinnableReference(), ref Enabled.GetPinnableReference(), ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* pYCbCr, Span<VideoColor> pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputBackgroundColor(pVideoProcessor, pYCbCr, ref pColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<int> pYCbCr, VideoColor* pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputBackgroundColor(pVideoProcessor, ref pYCbCr.GetPinnableReference(), pColor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<int> pYCbCr, Span<VideoColor> pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputBackgroundColor(pVideoProcessor, ref pYCbCr.GetPinnableReference(), ref pColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int* pYCbCr, VideoColor* pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputBackgroundColor(ref pVideoProcessor.GetPinnableReference(), pYCbCr, pColor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int* pYCbCr, Span<VideoColor> pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputBackgroundColor(ref pVideoProcessor.GetPinnableReference(), pYCbCr, ref pColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<int> pYCbCr, VideoColor* pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputBackgroundColor(ref pVideoProcessor.GetPinnableReference(), ref pYCbCr.GetPinnableReference(), pColor);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputBackgroundColor<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<int> pYCbCr, Span<VideoColor> pColor) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputBackgroundColor(ref pVideoProcessor.GetPinnableReference(), ref pYCbCr.GetPinnableReference(), ref pColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputColorSpace<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<VideoProcessorColorSpace> pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputColorSpace(pVideoProcessor, ref pColorSpace.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputColorSpace<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, VideoProcessorColorSpace* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputColorSpace(ref pVideoProcessor.GetPinnableReference(), pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputColorSpace<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<VideoProcessorColorSpace> pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputColorSpace(ref pVideoProcessor.GetPinnableReference(), ref pColorSpace.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, Span<uint> pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputAlphaFillMode(pVideoProcessor, pAlphaFillMode, ref pStreamIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<VideoProcessorAlphaFillMode> pAlphaFillMode, uint* pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputAlphaFillMode(pVideoProcessor, ref pAlphaFillMode.GetPinnableReference(), pStreamIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<VideoProcessorAlphaFillMode> pAlphaFillMode, Span<uint> pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputAlphaFillMode(pVideoProcessor, ref pAlphaFillMode.GetPinnableReference(), ref pStreamIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputAlphaFillMode(ref pVideoProcessor.GetPinnableReference(), pAlphaFillMode, pStreamIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, Span<uint> pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputAlphaFillMode(ref pVideoProcessor.GetPinnableReference(), pAlphaFillMode, ref pStreamIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<VideoProcessorAlphaFillMode> pAlphaFillMode, uint* pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputAlphaFillMode(ref pVideoProcessor.GetPinnableReference(), ref pAlphaFillMode.GetPinnableReference(), pStreamIndex);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputAlphaFillMode<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<VideoProcessorAlphaFillMode> pAlphaFillMode, Span<uint> pStreamIndex) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputAlphaFillMode(ref pVideoProcessor.GetPinnableReference(), ref pAlphaFillMode.GetPinnableReference(), ref pStreamIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* pEnabled, Span<Silk.NET.Maths.Vector2D<int>> pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputConstriction(pVideoProcessor, pEnabled, ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<int> pEnabled, Silk.NET.Maths.Vector2D<int>* pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputConstriction(pVideoProcessor, ref pEnabled.GetPinnableReference(), pSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<int> pEnabled, Span<Silk.NET.Maths.Vector2D<int>> pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputConstriction(pVideoProcessor, ref pEnabled.GetPinnableReference(), ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int* pEnabled, Silk.NET.Maths.Vector2D<int>* pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputConstriction(ref pVideoProcessor.GetPinnableReference(), pEnabled, pSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int* pEnabled, Span<Silk.NET.Maths.Vector2D<int>> pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputConstriction(ref pVideoProcessor.GetPinnableReference(), pEnabled, ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<int> pEnabled, Silk.NET.Maths.Vector2D<int>* pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputConstriction(ref pVideoProcessor.GetPinnableReference(), ref pEnabled.GetPinnableReference(), pSize);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputConstriction<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<int> pEnabled, Span<Silk.NET.Maths.Vector2D<int>> pSize) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputConstriction(ref pVideoProcessor.GetPinnableReference(), ref pEnabled.GetPinnableReference(), ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputStereoMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<int> pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputStereoMode(pVideoProcessor, ref pEnabled.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputStereoMode<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int* pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputStereoMode(ref pVideoProcessor.GetPinnableReference(), pEnabled);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputStereoMode<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<int> pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputStereoMode(ref pVideoProcessor.GetPinnableReference(), ref pEnabled.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetOutputExtension(pVideoProcessor, pExtensionGuid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<Guid> pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetOutputExtension(pVideoProcessor, ref pExtensionGuid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<Guid> pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetOutputExtension(pVideoProcessor, ref pExtensionGuid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetOutputExtension(ref pVideoProcessor.GetPinnableReference(), pExtensionGuid, DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension<T0, TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Guid* pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetOutputExtension(ref pVideoProcessor.GetPinnableReference(), pExtensionGuid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<Guid> pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetOutputExtension(ref pVideoProcessor.GetPinnableReference(), ref pExtensionGuid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessorGetOutputExtension<T0, TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<Guid> pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetOutputExtension(ref pVideoProcessor.GetPinnableReference(), ref pExtensionGuid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamFrameFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamFrameFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, FrameFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamColorSpace<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<VideoProcessorColorSpace> pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamColorSpace(pVideoProcessor, StreamIndex, ref pColorSpace.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamColorSpace<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamColorSpace(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamColorSpace<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<VideoProcessorColorSpace> pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamColorSpace(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pColorSpace.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, Span<Silk.NET.DXGI.Rational> pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamOutputRate(pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, ref pCustomRate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamOutputRate<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamOutputRate(ref pVideoProcessor.GetPinnableReference(), StreamIndex, OutputRate, RepeatFrame, pCustomRate);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamOutputRate<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, Span<Silk.NET.DXGI.Rational> pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamOutputRate(ref pVideoProcessor.GetPinnableReference(), StreamIndex, OutputRate, RepeatFrame, ref pCustomRate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamSourceRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamSourceRect(pVideoProcessor, StreamIndex, Enable, ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamSourceRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamSourceRect(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable, pRect);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamSourceRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamSourceRect(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable, ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamDestRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamDestRect(pVideoProcessor, StreamIndex, Enable, ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamDestRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamDestRect(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable, pRect);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamDestRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamDestRect(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable, ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamAlpha<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable, float Alpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamAlpha(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable, Alpha);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPalette<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, Span<uint> pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamPalette(pVideoProcessor, StreamIndex, Count, ref pEntries.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPalette<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamPalette(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Count, pEntries);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamPalette<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, uint Count, Span<uint> pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamPalette(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Count, ref pEntries.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, Span<Silk.NET.DXGI.Rational> pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamPixelAspectRatio(pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, ref pDestinationAspectRatio.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Span<Silk.NET.DXGI.Rational> pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamPixelAspectRatio(pVideoProcessor, StreamIndex, Enable, ref pSourceAspectRatio.GetPinnableReference(), pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Span<Silk.NET.DXGI.Rational> pSourceAspectRatio, Span<Silk.NET.DXGI.Rational> pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamPixelAspectRatio(pVideoProcessor, StreamIndex, Enable, ref pSourceAspectRatio.GetPinnableReference(), ref pDestinationAspectRatio.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamPixelAspectRatio(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, Span<Silk.NET.DXGI.Rational> pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamPixelAspectRatio(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable, pSourceAspectRatio, ref pDestinationAspectRatio.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable, Span<Silk.NET.DXGI.Rational> pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamPixelAspectRatio(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable, ref pSourceAspectRatio.GetPinnableReference(), pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable, Span<Silk.NET.DXGI.Rational> pSourceAspectRatio, Span<Silk.NET.DXGI.Rational> pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamPixelAspectRatio(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable, ref pSourceAspectRatio.GetPinnableReference(), ref pDestinationAspectRatio.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamLumaKey<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable, float Lower, float Upper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamLumaKey(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable, Lower, Upper);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorStereoFormat Format, int LeftViewFrame0, int BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamAutoProcessingMode<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamAutoProcessingMode(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamFilter<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int Enable, int Level) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamFilter(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Filter, Enable, Level);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetStreamExtension(pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<Guid> pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetStreamExtension(pVideoProcessor, StreamIndex, ref pExtensionGuid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<Guid> pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetStreamExtension(pVideoProcessor, StreamIndex, ref pExtensionGuid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetStreamExtension(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pExtensionGuid, DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension<T0, TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetStreamExtension(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pExtensionGuid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<Guid> pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetStreamExtension(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pExtensionGuid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessorSetStreamExtension<T0, TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<Guid> pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorSetStreamExtension(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pExtensionGuid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFrameFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<VideoFrameFormat> pFrameFormat) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamFrameFormat(pVideoProcessor, StreamIndex, ref pFrameFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFrameFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamFrameFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pFrameFormat);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamFrameFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<VideoFrameFormat> pFrameFormat) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamFrameFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pFrameFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamColorSpace<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<VideoProcessorColorSpace> pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamColorSpace(pVideoProcessor, StreamIndex, ref pColorSpace.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamColorSpace<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamColorSpace(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamColorSpace<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<VideoProcessorColorSpace> pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamColorSpace(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pColorSpace.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Span<Silk.NET.DXGI.Rational> pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, ref pCustomRate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, Span<int> pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(pVideoProcessor, StreamIndex, pOutputRate, ref pRepeatFrame.GetPinnableReference(), pCustomRate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, Span<int> pRepeatFrame, Span<Silk.NET.DXGI.Rational> pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(pVideoProcessor, StreamIndex, pOutputRate, ref pRepeatFrame.GetPinnableReference(), ref pCustomRate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<VideoProcessorOutputRate> pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(pVideoProcessor, StreamIndex, ref pOutputRate.GetPinnableReference(), pRepeatFrame, pCustomRate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<VideoProcessorOutputRate> pOutputRate, int* pRepeatFrame, Span<Silk.NET.DXGI.Rational> pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(pVideoProcessor, StreamIndex, ref pOutputRate.GetPinnableReference(), pRepeatFrame, ref pCustomRate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<VideoProcessorOutputRate> pOutputRate, Span<int> pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(pVideoProcessor, StreamIndex, ref pOutputRate.GetPinnableReference(), ref pRepeatFrame.GetPinnableReference(), pCustomRate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<VideoProcessorOutputRate> pOutputRate, Span<int> pRepeatFrame, Span<Silk.NET.DXGI.Rational> pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(pVideoProcessor, StreamIndex, ref pOutputRate.GetPinnableReference(), ref pRepeatFrame.GetPinnableReference(), ref pCustomRate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Span<Silk.NET.DXGI.Rational> pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pOutputRate, pRepeatFrame, ref pCustomRate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, Span<int> pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pOutputRate, ref pRepeatFrame.GetPinnableReference(), pCustomRate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, Span<int> pRepeatFrame, Span<Silk.NET.DXGI.Rational> pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pOutputRate, ref pRepeatFrame.GetPinnableReference(), ref pCustomRate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<VideoProcessorOutputRate> pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pOutputRate.GetPinnableReference(), pRepeatFrame, pCustomRate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<VideoProcessorOutputRate> pOutputRate, int* pRepeatFrame, Span<Silk.NET.DXGI.Rational> pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pOutputRate.GetPinnableReference(), pRepeatFrame, ref pCustomRate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<VideoProcessorOutputRate> pOutputRate, Span<int> pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pOutputRate.GetPinnableReference(), ref pRepeatFrame.GetPinnableReference(), pCustomRate);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamOutputRate<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<VideoProcessorOutputRate> pOutputRate, Span<int> pRepeatFrame, Span<Silk.NET.DXGI.Rational> pCustomRate) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamOutputRate(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pOutputRate.GetPinnableReference(), ref pRepeatFrame.GetPinnableReference(), ref pCustomRate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamSourceRect(pVideoProcessor, StreamIndex, pEnabled, ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamSourceRect(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamSourceRect(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamSourceRect(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamSourceRect(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamSourceRect(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), pRect);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamSourceRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamSourceRect(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamDestRect(pVideoProcessor, StreamIndex, pEnabled, ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamDestRect(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamDestRect(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamDestRect(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamDestRect(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamDestRect(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), pRect);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamDestRect<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamDestRect(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Span<float> pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamAlpha(pVideoProcessor, StreamIndex, pEnabled, ref pAlpha.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, float* pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamAlpha(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), pAlpha);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<float> pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamAlpha(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), ref pAlpha.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamAlpha(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, pAlpha);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, Span<float> pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamAlpha(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, ref pAlpha.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, float* pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamAlpha(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), pAlpha);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamAlpha<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<float> pAlpha) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamAlpha(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), ref pAlpha.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPalette<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, Span<uint> pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPalette(pVideoProcessor, StreamIndex, Count, ref pEntries.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPalette<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPalette(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Count, pEntries);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamPalette<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, uint Count, Span<uint> pEntries) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPalette(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Count, ref pEntries.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Span<Silk.NET.DXGI.Rational> pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, ref pDestinationAspectRatio.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Span<Silk.NET.DXGI.Rational> pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(pVideoProcessor, StreamIndex, pEnabled, ref pSourceAspectRatio.GetPinnableReference(), pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Span<Silk.NET.DXGI.Rational> pSourceAspectRatio, Span<Silk.NET.DXGI.Rational> pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(pVideoProcessor, StreamIndex, pEnabled, ref pSourceAspectRatio.GetPinnableReference(), ref pDestinationAspectRatio.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), pSourceAspectRatio, pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Span<Silk.NET.DXGI.Rational> pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), pSourceAspectRatio, ref pDestinationAspectRatio.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<Silk.NET.DXGI.Rational> pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), ref pSourceAspectRatio.GetPinnableReference(), pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<Silk.NET.DXGI.Rational> pSourceAspectRatio, Span<Silk.NET.DXGI.Rational> pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), ref pSourceAspectRatio.GetPinnableReference(), ref pDestinationAspectRatio.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Span<Silk.NET.DXGI.Rational> pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, pSourceAspectRatio, ref pDestinationAspectRatio.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, Span<Silk.NET.DXGI.Rational> pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, ref pSourceAspectRatio.GetPinnableReference(), pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, Span<Silk.NET.DXGI.Rational> pSourceAspectRatio, Span<Silk.NET.DXGI.Rational> pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, ref pSourceAspectRatio.GetPinnableReference(), ref pDestinationAspectRatio.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), pSourceAspectRatio, pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Span<Silk.NET.DXGI.Rational> pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), pSourceAspectRatio, ref pDestinationAspectRatio.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<Silk.NET.DXGI.Rational> pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), ref pSourceAspectRatio.GetPinnableReference(), pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamPixelAspectRatio<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<Silk.NET.DXGI.Rational> pSourceAspectRatio, Span<Silk.NET.DXGI.Rational> pDestinationAspectRatio) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamPixelAspectRatio(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), ref pSourceAspectRatio.GetPinnableReference(), ref pDestinationAspectRatio.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, Span<float> pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(pVideoProcessor, StreamIndex, pEnabled, pLower, ref pUpper.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Span<float> pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(pVideoProcessor, StreamIndex, pEnabled, ref pLower.GetPinnableReference(), pUpper);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Span<float> pLower, Span<float> pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(pVideoProcessor, StreamIndex, pEnabled, ref pLower.GetPinnableReference(), ref pUpper.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, float* pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), pLower, pUpper);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, float* pLower, Span<float> pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), pLower, ref pUpper.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<float> pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), ref pLower.GetPinnableReference(), pUpper);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<float> pLower, Span<float> pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference(), ref pLower.GetPinnableReference(), ref pUpper.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, pLower, pUpper);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, Span<float> pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, pLower, ref pUpper.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, Span<float> pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, ref pLower.GetPinnableReference(), pUpper);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled, Span<float> pLower, Span<float> pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled, ref pLower.GetPinnableReference(), ref pUpper.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, float* pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), pLower, pUpper);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, float* pLower, Span<float> pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), pLower, ref pUpper.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<float> pLower, float* pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), ref pLower.GetPinnableReference(), pUpper);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamLumaKey<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled, Span<float> pLower, Span<float> pUpper) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamLumaKey(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference(), ref pLower.GetPinnableReference(), ref pUpper.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorStereoFormat* pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFormat, ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, int* pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), pLeftViewFrame0, ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, int* pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), pBaseViewFrame0, ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), pFlipMode, ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, int* MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamStereoFormat<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorStereoFormat> pFormat, Span<int> pLeftViewFrame0, Span<int> pBaseViewFrame0, Span<VideoProcessorStereoFlipMode> pFlipMode, Span<int> MonoOffset) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamStereoFormat(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFormat.GetPinnableReference(), ref pLeftViewFrame0.GetPinnableReference(), ref pBaseViewFrame0.GetPinnableReference(), ref pFlipMode.GetPinnableReference(), ref MonoOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAutoProcessingMode<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamAutoProcessingMode(pVideoProcessor, StreamIndex, ref pEnabled.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAutoProcessingMode<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamAutoProcessingMode(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnabled);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamAutoProcessingMode<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnabled) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamAutoProcessingMode(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnabled.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, Span<int> pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamFilter(pVideoProcessor, StreamIndex, Filter, pEnabled, ref pLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, Span<int> pEnabled, int* pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamFilter(pVideoProcessor, StreamIndex, Filter, ref pEnabled.GetPinnableReference(), pLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, Span<int> pEnabled, Span<int> pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamFilter(pVideoProcessor, StreamIndex, Filter, ref pEnabled.GetPinnableReference(), ref pLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamFilter(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Filter, pEnabled, pLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, Span<int> pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamFilter(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Filter, pEnabled, ref pLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, Span<int> pEnabled, int* pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamFilter(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Filter, ref pEnabled.GetPinnableReference(), pLevel);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamFilter<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, Span<int> pEnabled, Span<int> pLevel) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamFilter(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Filter, ref pEnabled.GetPinnableReference(), ref pLevel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetStreamExtension(pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<Guid> pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetStreamExtension(pVideoProcessor, StreamIndex, ref pExtensionGuid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension<T0, TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<Guid> pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetStreamExtension(pVideoProcessor, StreamIndex, ref pExtensionGuid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetStreamExtension(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pExtensionGuid, DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension<T0, TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetStreamExtension(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pExtensionGuid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<Guid> pExtensionGuid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetStreamExtension(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pExtensionGuid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessorGetStreamExtension<T0, TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<Guid> pExtensionGuid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetStreamExtension(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pExtensionGuid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, Span<VideoProcessorStream> pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorBlt(pVideoProcessor, pView, OutputFrame, StreamCount, ref pStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<ID3D11VideoProcessorOutputView> pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorBlt(pVideoProcessor, ref pView.GetPinnableReference(), OutputFrame, StreamCount, pStreams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<ID3D11VideoProcessorOutputView> pView, uint OutputFrame, uint StreamCount, Span<VideoProcessorStream> pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorBlt(pVideoProcessor, ref pView.GetPinnableReference(), OutputFrame, StreamCount, ref pStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorBlt(ref pVideoProcessor.GetPinnableReference(), pView, OutputFrame, StreamCount, pStreams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, Span<VideoProcessorStream> pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorBlt(ref pVideoProcessor.GetPinnableReference(), pView, OutputFrame, StreamCount, ref pStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<ID3D11VideoProcessorOutputView> pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorBlt(ref pVideoProcessor.GetPinnableReference(), ref pView.GetPinnableReference(), OutputFrame, StreamCount, pStreams);
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessorBlt<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<ID3D11VideoProcessorOutputView> pView, uint OutputFrame, uint StreamCount, Span<VideoProcessorStream> pStreams) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorBlt(ref pVideoProcessor.GetPinnableReference(), ref pView.GetPinnableReference(), OutputFrame, StreamCount, ref pStreams.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateCryptoSessionKeyExchange<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->NegotiateCryptoSessionKeyExchange(pCryptoSession, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateCryptoSessionKeyExchange<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->NegotiateCryptoSessionKeyExchange(ref pCryptoSession.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateCryptoSessionKeyExchange<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->NegotiateCryptoSessionKeyExchange(ref pCryptoSession.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(pCryptoSession, pSrcSurface, pDstSurface, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(pCryptoSession, pSrcSurface, ref pDstSurface.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(pCryptoSession, pSrcSurface, ref pDstSurface.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), pDstSurface, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), pDstSurface, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, pDstSurface, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, pDstSurface, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, ref pDstSurface.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, ref pDstSurface.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), pDstSurface, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), pDstSurface, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static void EncryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EncryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, pSrcSurface, ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), pDstSurface, pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), pDstSurface, pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(pCryptoSession, ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, ID3D11Texture2D* pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), pSrcSurface, ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), pDstSurface, pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), pDstSurface, pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, ID3D11Texture2D* pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), pDstSurface, ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), pEncryptedBlockInfo, ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, Span<T0> pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, pContentKey, IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static void DecryptionBlt<T0, T1, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<ID3D11Texture2D> pSrcSurface, Span<ID3D11Texture2D> pDstSurface, Span<EncryptedBlockInfo> pEncryptedBlockInfo, uint ContentKeySize, Span<T0> pContentKey, uint IVSize, Span<T1> pIV) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DecryptionBlt(ref pCryptoSession.GetPinnableReference(), ref pSrcSurface.GetPinnableReference(), ref pDstSurface.GetPinnableReference(), ref pEncryptedBlockInfo.GetPinnableReference(), ContentKeySize, ref pContentKey.GetPinnableReference(), IVSize, ref pIV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void StartSessionKeyRefresh<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, Span<T0> pRandomNumber) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->StartSessionKeyRefresh(pCryptoSession, RandomNumberSize, ref pRandomNumber.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void StartSessionKeyRefresh<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, uint RandomNumberSize, void* pRandomNumber) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->StartSessionKeyRefresh(ref pCryptoSession.GetPinnableReference(), RandomNumberSize, pRandomNumber);
    }

    /// <summary>To be documented.</summary>
    public static void StartSessionKeyRefresh<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, uint RandomNumberSize, Span<T0> pRandomNumber) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->StartSessionKeyRefresh(ref pCryptoSession.GetPinnableReference(), RandomNumberSize, ref pRandomNumber.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void FinishSessionKeyRefresh<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->FinishSessionKeyRefresh(ref pCryptoSession.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncryptionBltKey<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint KeySize, Span<T0> pReadbackKey) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetEncryptionBltKey(pCryptoSession, KeySize, ref pReadbackKey.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncryptionBltKey<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, uint KeySize, void* pReadbackKey) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetEncryptionBltKey(ref pCryptoSession.GetPinnableReference(), KeySize, pReadbackKey);
    }

    /// <summary>To be documented.</summary>
    public static int GetEncryptionBltKey<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, uint KeySize, Span<T0> pReadbackKey) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetEncryptionBltKey(ref pCryptoSession.GetPinnableReference(), KeySize, ref pReadbackKey.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateAuthenticatedChannelKeyExchange<T0, TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->NegotiateAuthenticatedChannelKeyExchange(pChannel, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateAuthenticatedChannelKeyExchange<TThis>(this TThis thisVtbl, Span<ID3D11AuthenticatedChannel> pChannel, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->NegotiateAuthenticatedChannelKeyExchange(ref pChannel.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateAuthenticatedChannelKeyExchange<T0, TThis>(this TThis thisVtbl, Span<ID3D11AuthenticatedChannel> pChannel, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->NegotiateAuthenticatedChannelKeyExchange(ref pChannel.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, uint OutputSize, Span<T0> pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryAuthenticatedChannel(pChannel, InputSize, pInput, OutputSize, ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, Span<T0> pInput, uint OutputSize, void* pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryAuthenticatedChannel(pChannel, InputSize, ref pInput.GetPinnableReference(), OutputSize, pOutput);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel<T0, T1, TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, Span<T0> pInput, uint OutputSize, Span<T1> pOutput) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryAuthenticatedChannel(pChannel, InputSize, ref pInput.GetPinnableReference(), OutputSize, ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel<TThis>(this TThis thisVtbl, Span<ID3D11AuthenticatedChannel> pChannel, uint InputSize, void* pInput, uint OutputSize, void* pOutput) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryAuthenticatedChannel(ref pChannel.GetPinnableReference(), InputSize, pInput, OutputSize, pOutput);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, Span<ID3D11AuthenticatedChannel> pChannel, uint InputSize, void* pInput, uint OutputSize, Span<T0> pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryAuthenticatedChannel(ref pChannel.GetPinnableReference(), InputSize, pInput, OutputSize, ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, Span<ID3D11AuthenticatedChannel> pChannel, uint InputSize, Span<T0> pInput, uint OutputSize, void* pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryAuthenticatedChannel(ref pChannel.GetPinnableReference(), InputSize, ref pInput.GetPinnableReference(), OutputSize, pOutput);
    }

    /// <summary>To be documented.</summary>
    public static int QueryAuthenticatedChannel<T0, T1, TThis>(this TThis thisVtbl, Span<ID3D11AuthenticatedChannel> pChannel, uint InputSize, Span<T0> pInput, uint OutputSize, Span<T1> pOutput) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryAuthenticatedChannel(ref pChannel.GetPinnableReference(), InputSize, ref pInput.GetPinnableReference(), OutputSize, ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel<TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, Span<AuthenticatedConfigureOutput> pOutput) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ConfigureAuthenticatedChannel(pChannel, InputSize, pInput, ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, Span<T0> pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ConfigureAuthenticatedChannel(pChannel, InputSize, ref pInput.GetPinnableReference(), pOutput);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, Span<T0> pInput, Span<AuthenticatedConfigureOutput> pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ConfigureAuthenticatedChannel(pChannel, InputSize, ref pInput.GetPinnableReference(), ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel<TThis>(this TThis thisVtbl, Span<ID3D11AuthenticatedChannel> pChannel, uint InputSize, void* pInput, AuthenticatedConfigureOutput* pOutput) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ConfigureAuthenticatedChannel(ref pChannel.GetPinnableReference(), InputSize, pInput, pOutput);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel<TThis>(this TThis thisVtbl, Span<ID3D11AuthenticatedChannel> pChannel, uint InputSize, void* pInput, Span<AuthenticatedConfigureOutput> pOutput) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ConfigureAuthenticatedChannel(ref pChannel.GetPinnableReference(), InputSize, pInput, ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, Span<ID3D11AuthenticatedChannel> pChannel, uint InputSize, Span<T0> pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ConfigureAuthenticatedChannel(ref pChannel.GetPinnableReference(), InputSize, ref pInput.GetPinnableReference(), pOutput);
    }

    /// <summary>To be documented.</summary>
    public static int ConfigureAuthenticatedChannel<T0, TThis>(this TThis thisVtbl, Span<ID3D11AuthenticatedChannel> pChannel, uint InputSize, Span<T0> pInput, Span<AuthenticatedConfigureOutput> pOutput) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ConfigureAuthenticatedChannel(ref pChannel.GetPinnableReference(), InputSize, ref pInput.GetPinnableReference(), ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamRotation<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorRotation Rotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamRotation(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable, Rotation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorRotation> pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamRotation(pVideoProcessor, StreamIndex, pEnable, ref pRotation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorRotation* pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamRotation(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pRotation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorRotation> pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamRotation(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pRotation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamRotation(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pRotation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<VideoProcessorRotation> pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamRotation(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pRotation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, VideoProcessorRotation* pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamRotation(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pRotation);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamRotation<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<VideoProcessorRotation> pRotation) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamRotation(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pRotation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitDecoderBuffers1<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, uint NumBuffers, Span<VideoDecoderBufferDesc1> pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SubmitDecoderBuffers1(pDecoder, NumBuffers, ref pBufferDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitDecoderBuffers1<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, uint NumBuffers, VideoDecoderBufferDesc1* pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SubmitDecoderBuffers1(ref pDecoder.GetPinnableReference(), NumBuffers, pBufferDesc);
    }

    /// <summary>To be documented.</summary>
    public static int SubmitDecoderBuffers1<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, uint NumBuffers, Span<VideoDecoderBufferDesc1> pBufferDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SubmitDecoderBuffers1(ref pDecoder.GetPinnableReference(), NumBuffers, ref pBufferDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, void* pPrivatInputData, Span<ulong> pPrivateOutputData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDataForNewHardwareKey(pCryptoSession, PrivateInputSize, pPrivatInputData, ref pPrivateOutputData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, Span<T0> pPrivatInputData, ulong* pPrivateOutputData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDataForNewHardwareKey(pCryptoSession, PrivateInputSize, ref pPrivatInputData.GetPinnableReference(), pPrivateOutputData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey<T0, TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, Span<T0> pPrivatInputData, Span<ulong> pPrivateOutputData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDataForNewHardwareKey(pCryptoSession, PrivateInputSize, ref pPrivatInputData.GetPinnableReference(), ref pPrivateOutputData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, uint PrivateInputSize, void* pPrivatInputData, ulong* pPrivateOutputData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDataForNewHardwareKey(ref pCryptoSession.GetPinnableReference(), PrivateInputSize, pPrivatInputData, pPrivateOutputData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, uint PrivateInputSize, void* pPrivatInputData, Span<ulong> pPrivateOutputData) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDataForNewHardwareKey(ref pCryptoSession.GetPinnableReference(), PrivateInputSize, pPrivatInputData, ref pPrivateOutputData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, uint PrivateInputSize, Span<T0> pPrivatInputData, ulong* pPrivateOutputData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDataForNewHardwareKey(ref pCryptoSession.GetPinnableReference(), PrivateInputSize, ref pPrivatInputData.GetPinnableReference(), pPrivateOutputData);
    }

    /// <summary>To be documented.</summary>
    public static int GetDataForNewHardwareKey<T0, TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, uint PrivateInputSize, Span<T0> pPrivatInputData, Span<ulong> pPrivateOutputData) where T0 : unmanaged where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDataForNewHardwareKey(ref pCryptoSession.GetPinnableReference(), PrivateInputSize, ref pPrivatInputData.GetPinnableReference(), ref pPrivateOutputData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoSessionStatus<TThis>(this TThis thisVtbl, ID3D11CryptoSession* pCryptoSession, Span<CryptoSessionStatus> pStatus) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckCryptoSessionStatus(pCryptoSession, ref pStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoSessionStatus<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, CryptoSessionStatus* pStatus) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckCryptoSessionStatus(ref pCryptoSession.GetPinnableReference(), pStatus);
    }

    /// <summary>To be documented.</summary>
    public static int CheckCryptoSessionStatus<TThis>(this TThis thisVtbl, Span<ID3D11CryptoSession> pCryptoSession, Span<CryptoSessionStatus> pStatus) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckCryptoSessionStatus(ref pCryptoSession.GetPinnableReference(), ref pStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderEnableDownsampling<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, Span<VideoSampleDesc> pOutputDesc, uint ReferenceFrameCount) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderEnableDownsampling(pDecoder, InputColorSpace, ref pOutputDesc.GetPinnableReference(), ReferenceFrameCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderEnableDownsampling<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoSampleDesc* pOutputDesc, uint ReferenceFrameCount) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderEnableDownsampling(ref pDecoder.GetPinnableReference(), InputColorSpace, pOutputDesc, ReferenceFrameCount);
    }

    /// <summary>To be documented.</summary>
    public static int DecoderEnableDownsampling<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, Span<VideoSampleDesc> pOutputDesc, uint ReferenceFrameCount) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderEnableDownsampling(ref pDecoder.GetPinnableReference(), InputColorSpace, ref pOutputDesc.GetPinnableReference(), ReferenceFrameCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderUpdateDownsampling<TThis>(this TThis thisVtbl, ID3D11VideoDecoder* pDecoder, Span<VideoSampleDesc> pOutputDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderUpdateDownsampling(pDecoder, ref pOutputDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderUpdateDownsampling<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, VideoSampleDesc* pOutputDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderUpdateDownsampling(ref pDecoder.GetPinnableReference(), pOutputDesc);
    }

    /// <summary>To be documented.</summary>
    public static int DecoderUpdateDownsampling<TThis>(this TThis thisVtbl, Span<ID3D11VideoDecoder> pDecoder, Span<VideoSampleDesc> pOutputDesc) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DecoderUpdateDownsampling(ref pDecoder.GetPinnableReference(), ref pOutputDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputColorSpace1<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Silk.NET.DXGI.ColorSpaceType ColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputColorSpace1(ref pVideoProcessor.GetPinnableReference(), ColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetOutputShaderUsage<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int ShaderUsage) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetOutputShaderUsage(ref pVideoProcessor.GetPinnableReference(), ShaderUsage);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputColorSpace1<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<Silk.NET.DXGI.ColorSpaceType> pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputColorSpace1(pVideoProcessor, ref pColorSpace.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputColorSpace1<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Silk.NET.DXGI.ColorSpaceType* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputColorSpace1(ref pVideoProcessor.GetPinnableReference(), pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputColorSpace1<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<Silk.NET.DXGI.ColorSpaceType> pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputColorSpace1(ref pVideoProcessor.GetPinnableReference(), ref pColorSpace.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputShaderUsage<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Span<int> pShaderUsage) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputShaderUsage(pVideoProcessor, ref pShaderUsage.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputShaderUsage<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, int* pShaderUsage) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputShaderUsage(ref pVideoProcessor.GetPinnableReference(), pShaderUsage);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetOutputShaderUsage<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, Span<int> pShaderUsage) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetOutputShaderUsage(ref pVideoProcessor.GetPinnableReference(), ref pShaderUsage.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamColorSpace1<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType ColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamColorSpace1(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorSetStreamMirror<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int Enable, int FlipHorizontal, int FlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorSetStreamMirror(ref pVideoProcessor.GetPinnableReference(), StreamIndex, Enable, FlipHorizontal, FlipVertical);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamColorSpace1<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<Silk.NET.DXGI.ColorSpaceType> pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamColorSpace1(pVideoProcessor, StreamIndex, ref pColorSpace.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamColorSpace1<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType* pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamColorSpace1(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamColorSpace1<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<Silk.NET.DXGI.ColorSpaceType> pColorSpace) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamColorSpace1(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pColorSpace.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, Span<int> pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(pVideoProcessor, StreamIndex, pEnable, pFlipHorizontal, ref pFlipVertical.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<int> pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(pVideoProcessor, StreamIndex, pEnable, ref pFlipHorizontal.GetPinnableReference(), pFlipVertical);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, Span<int> pFlipHorizontal, Span<int> pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(pVideoProcessor, StreamIndex, pEnable, ref pFlipHorizontal.GetPinnableReference(), ref pFlipVertical.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, int* pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFlipHorizontal, pFlipVertical);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, int* pFlipHorizontal, Span<int> pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), pFlipHorizontal, ref pFlipVertical.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<int> pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFlipHorizontal.GetPinnableReference(), pFlipVertical);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<int> pFlipHorizontal, Span<int> pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(pVideoProcessor, StreamIndex, ref pEnable.GetPinnableReference(), ref pFlipHorizontal.GetPinnableReference(), ref pFlipVertical.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, Span<int> pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, pFlipHorizontal, ref pFlipVertical.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<int> pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFlipHorizontal.GetPinnableReference(), pFlipVertical);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, int* pEnable, Span<int> pFlipHorizontal, Span<int> pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(ref pVideoProcessor.GetPinnableReference(), StreamIndex, pEnable, ref pFlipHorizontal.GetPinnableReference(), ref pFlipVertical.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, int* pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFlipHorizontal, pFlipVertical);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, int* pFlipHorizontal, Span<int> pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), pFlipHorizontal, ref pFlipVertical.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<int> pFlipHorizontal, int* pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFlipHorizontal.GetPinnableReference(), pFlipVertical);
    }

    /// <summary>To be documented.</summary>
    public static void VideoProcessorGetStreamMirror<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint StreamIndex, Span<int> pEnable, Span<int> pFlipHorizontal, Span<int> pFlipVertical) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VideoProcessorGetStreamMirror(ref pVideoProcessor.GetPinnableReference(), StreamIndex, ref pEnable.GetPinnableReference(), ref pFlipHorizontal.GetPinnableReference(), ref pFlipVertical.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, VideoProcessorStreamBehaviorHint* pStreams, Span<uint> pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetBehaviorHints(pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, ref pBehaviorHints.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, Span<VideoProcessorStreamBehaviorHint> pStreams, uint* pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetBehaviorHints(pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, ref pStreams.GetPinnableReference(), pBehaviorHints);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, Span<VideoProcessorStreamBehaviorHint> pStreams, Span<uint> pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetBehaviorHints(pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, ref pStreams.GetPinnableReference(), ref pBehaviorHints.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, VideoProcessorStreamBehaviorHint* pStreams, uint* pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetBehaviorHints(ref pVideoProcessor.GetPinnableReference(), OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, VideoProcessorStreamBehaviorHint* pStreams, Span<uint> pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetBehaviorHints(ref pVideoProcessor.GetPinnableReference(), OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, ref pBehaviorHints.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, Span<VideoProcessorStreamBehaviorHint> pStreams, uint* pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetBehaviorHints(ref pVideoProcessor.GetPinnableReference(), OutputWidth, OutputHeight, OutputFormat, StreamCount, ref pStreams.GetPinnableReference(), pBehaviorHints);
    }

    /// <summary>To be documented.</summary>
    public static int VideoProcessorGetBehaviorHints<TThis>(this TThis thisVtbl, Span<ID3D11VideoProcessor> pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, Span<VideoProcessorStreamBehaviorHint> pStreams, Span<uint> pBehaviorHints) where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->VideoProcessorGetBehaviorHints(ref pVideoProcessor.GetPinnableReference(), OutputWidth, OutputHeight, OutputFormat, StreamCount, ref pStreams.GetPinnableReference(), ref pBehaviorHints.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D11VideoContext1>
    {
        var @this = (ID3D11VideoContext1*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
