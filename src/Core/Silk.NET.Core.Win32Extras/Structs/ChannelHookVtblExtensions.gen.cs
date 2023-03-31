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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class ChannelHookVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IChannelHook> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IChannelHook> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IChannelHook> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IChannelHook> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IChannelHook> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IChannelHook> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtent, riid, pDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, ref uint pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtent, riid, pDataSizePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtent, riidPtr, pDataSize);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, ref uint pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtent, riidPtr, pDataSizePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtentPtr, riid, pDataSize);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, ref uint pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtentPtr, riid, pDataSizePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtentPtr, riidPtr, pDataSize);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, ref uint pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtentPtr, riidPtr, pDataSizePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riid, pDataSize, pDataBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint* pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataBufferPtr = &pDataBuffer)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riid, pDataSize, pDataBufferPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, ref uint pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riid, pDataSizePtr, pDataBuffer);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, ref uint pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riid, pDataSizePtr, pDataBufferPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, uint* pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riidPtr, pDataSize, pDataBuffer);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, uint* pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riidPtr, pDataSize, pDataBufferPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, ref uint pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riidPtr, pDataSizePtr, pDataBuffer);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, ref uint pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riidPtr, pDataSizePtr, pDataBufferPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riid, pDataSize, pDataBuffer);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, uint* pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riid, pDataSize, pDataBufferPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, ref uint pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riid, pDataSizePtr, pDataBuffer);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, ref uint pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riid, pDataSizePtr, pDataBufferPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, uint* pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riidPtr, pDataSize, pDataBuffer);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, uint* pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riidPtr, pDataSize, pDataBufferPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, ref uint pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riidPtr, pDataSizePtr, pDataBuffer);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, ref uint pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataBufferPtr = &pDataBuffer)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riidPtr, pDataSizePtr, pDataBufferPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep, int hrFault)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtent, riid, cbDataSize, pDataBuffer, lDataRep, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataBufferPtr = &pDataBuffer)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtent, riid, cbDataSize, pDataBufferPtr, lDataRep, hrFault);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, uint cbDataSize, void* pDataBuffer, uint lDataRep, int hrFault)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtent, riidPtr, cbDataSize, pDataBuffer, lDataRep, hrFault);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtent, riidPtr, cbDataSize, pDataBufferPtr, lDataRep, hrFault);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep, int hrFault)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtentPtr, riid, cbDataSize, pDataBuffer, lDataRep, hrFault);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify<T0>(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtentPtr, riid, cbDataSize, pDataBufferPtr, lDataRep, hrFault);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, uint cbDataSize, void* pDataBuffer, uint lDataRep, int hrFault)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtentPtr, riidPtr, cbDataSize, pDataBuffer, lDataRep, hrFault);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClientNotify<T0>(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtentPtr, riidPtr, cbDataSize, pDataBufferPtr, lDataRep, hrFault);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtent, riid, cbDataSize, pDataBuffer, lDataRep);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataBufferPtr = &pDataBuffer)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtent, riid, cbDataSize, pDataBufferPtr, lDataRep);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, uint cbDataSize, void* pDataBuffer, uint lDataRep)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtent, riidPtr, cbDataSize, pDataBuffer, lDataRep);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtent, riidPtr, cbDataSize, pDataBufferPtr, lDataRep);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtentPtr, riid, cbDataSize, pDataBuffer, lDataRep);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify<T0>(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtentPtr, riid, cbDataSize, pDataBufferPtr, lDataRep);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, uint cbDataSize, void* pDataBuffer, uint lDataRep)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtentPtr, riidPtr, cbDataSize, pDataBuffer, lDataRep);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ServerNotify<T0>(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtentPtr, riidPtr, cbDataSize, pDataBufferPtr, lDataRep);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, int hrFault, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtent, riid, hrFault, pDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, int hrFault, ref uint pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtent, riid, hrFault, pDataSizePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, int hrFault, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtent, riidPtr, hrFault, pDataSize);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, int hrFault, ref uint pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtent, riidPtr, hrFault, pDataSizePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, int hrFault, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtentPtr, riid, hrFault, pDataSize);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, int hrFault, ref uint pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtentPtr, riid, hrFault, pDataSizePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, int hrFault, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtentPtr, riidPtr, hrFault, pDataSize);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, int hrFault, ref uint pDataSize)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtentPtr, riidPtr, hrFault, pDataSizePtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riid, pDataSize, pDataBuffer, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint* pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataBufferPtr = &pDataBuffer)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riid, pDataSize, pDataBufferPtr, hrFault);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, ref uint pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riid, pDataSizePtr, pDataBuffer, hrFault);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, ref uint pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riid, pDataSizePtr, pDataBufferPtr, hrFault);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, uint* pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riidPtr, pDataSize, pDataBuffer, hrFault);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, uint* pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riidPtr, pDataSize, pDataBufferPtr, hrFault);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, ref uint pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riidPtr, pDataSizePtr, pDataBuffer, hrFault);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, ref Guid riid, ref uint pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riidPtr, pDataSizePtr, pDataBufferPtr, hrFault);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riid, pDataSize, pDataBuffer, hrFault);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, uint* pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riid, pDataSize, pDataBufferPtr, hrFault);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, ref uint pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riid, pDataSizePtr, pDataBuffer, hrFault);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, Guid* riid, ref uint pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riid, pDataSizePtr, pDataBufferPtr, hrFault);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, uint* pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riidPtr, pDataSize, pDataBuffer, hrFault);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, uint* pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riidPtr, pDataSize, pDataBufferPtr, hrFault);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, ref uint pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riidPtr, pDataSizePtr, pDataBuffer, hrFault);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, ref Guid uExtent, ref Guid riid, ref uint pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Guid* uExtentPtr = &uExtent)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataBufferPtr = &pDataBuffer)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riidPtr, pDataSizePtr, pDataBufferPtr, hrFault);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IChannelHook> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IChannelHook> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IChannelHook> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, Span<uint> pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientGetSize(uExtent, riid, ref pDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientGetSize(uExtent, ref riid.GetPinnableReference(), pDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, Span<uint> pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientGetSize(uExtent, ref riid.GetPinnableReference(), ref pDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientGetSize(ref uExtent.GetPinnableReference(), riid, pDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, Span<uint> pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientGetSize(ref uExtent.GetPinnableReference(), riid, ref pDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientGetSize(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), pDataSize);
    }

    /// <summary>To be documented.</summary>
    public static void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, Span<uint> pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientGetSize(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), ref pDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint* pDataSize, Span<T0> pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(uExtent, riid, pDataSize, ref pDataBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, Span<uint> pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(uExtent, riid, ref pDataSize.GetPinnableReference(), pDataBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, Span<uint> pDataSize, Span<T0> pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(uExtent, riid, ref pDataSize.GetPinnableReference(), ref pDataBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, uint* pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(uExtent, ref riid.GetPinnableReference(), pDataSize, pDataBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, uint* pDataSize, Span<T0> pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(uExtent, ref riid.GetPinnableReference(), pDataSize, ref pDataBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, Span<uint> pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(uExtent, ref riid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pDataBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, Span<uint> pDataSize, Span<T0> pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(uExtent, ref riid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pDataBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(ref uExtent.GetPinnableReference(), riid, pDataSize, pDataBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, uint* pDataSize, Span<T0> pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(ref uExtent.GetPinnableReference(), riid, pDataSize, ref pDataBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, Span<uint> pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(ref uExtent.GetPinnableReference(), riid, ref pDataSize.GetPinnableReference(), pDataBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, Span<uint> pDataSize, Span<T0> pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(ref uExtent.GetPinnableReference(), riid, ref pDataSize.GetPinnableReference(), ref pDataBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, uint* pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), pDataSize, pDataBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, uint* pDataSize, Span<T0> pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), pDataSize, ref pDataBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, Span<uint> pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pDataBuffer);
    }

    /// <summary>To be documented.</summary>
    public static void ClientFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, Span<uint> pDataSize, Span<T0> pDataBuffer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientFillBuffer(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pDataBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint cbDataSize, Span<T0> pDataBuffer, uint lDataRep, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientNotify(uExtent, riid, cbDataSize, ref pDataBuffer.GetPinnableReference(), lDataRep, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, uint cbDataSize, void* pDataBuffer, uint lDataRep, int hrFault)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientNotify(uExtent, ref riid.GetPinnableReference(), cbDataSize, pDataBuffer, lDataRep, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, uint cbDataSize, Span<T0> pDataBuffer, uint lDataRep, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientNotify(uExtent, ref riid.GetPinnableReference(), cbDataSize, ref pDataBuffer.GetPinnableReference(), lDataRep, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep, int hrFault)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientNotify(ref uExtent.GetPinnableReference(), riid, cbDataSize, pDataBuffer, lDataRep, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify<T0>(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, uint cbDataSize, Span<T0> pDataBuffer, uint lDataRep, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientNotify(ref uExtent.GetPinnableReference(), riid, cbDataSize, ref pDataBuffer.GetPinnableReference(), lDataRep, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, uint cbDataSize, void* pDataBuffer, uint lDataRep, int hrFault)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientNotify(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), cbDataSize, pDataBuffer, lDataRep, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static void ClientNotify<T0>(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, uint cbDataSize, Span<T0> pDataBuffer, uint lDataRep, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClientNotify(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), cbDataSize, ref pDataBuffer.GetPinnableReference(), lDataRep, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint cbDataSize, Span<T0> pDataBuffer, uint lDataRep) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerNotify(uExtent, riid, cbDataSize, ref pDataBuffer.GetPinnableReference(), lDataRep);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, uint cbDataSize, void* pDataBuffer, uint lDataRep)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerNotify(uExtent, ref riid.GetPinnableReference(), cbDataSize, pDataBuffer, lDataRep);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, uint cbDataSize, Span<T0> pDataBuffer, uint lDataRep) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerNotify(uExtent, ref riid.GetPinnableReference(), cbDataSize, ref pDataBuffer.GetPinnableReference(), lDataRep);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerNotify(ref uExtent.GetPinnableReference(), riid, cbDataSize, pDataBuffer, lDataRep);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify<T0>(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, uint cbDataSize, Span<T0> pDataBuffer, uint lDataRep) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerNotify(ref uExtent.GetPinnableReference(), riid, cbDataSize, ref pDataBuffer.GetPinnableReference(), lDataRep);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, uint cbDataSize, void* pDataBuffer, uint lDataRep)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerNotify(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), cbDataSize, pDataBuffer, lDataRep);
    }

    /// <summary>To be documented.</summary>
    public static void ServerNotify<T0>(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, uint cbDataSize, Span<T0> pDataBuffer, uint lDataRep) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerNotify(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), cbDataSize, ref pDataBuffer.GetPinnableReference(), lDataRep);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, int hrFault, Span<uint> pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerGetSize(uExtent, riid, hrFault, ref pDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, int hrFault, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerGetSize(uExtent, ref riid.GetPinnableReference(), hrFault, pDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, int hrFault, Span<uint> pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerGetSize(uExtent, ref riid.GetPinnableReference(), hrFault, ref pDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, int hrFault, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerGetSize(ref uExtent.GetPinnableReference(), riid, hrFault, pDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, int hrFault, Span<uint> pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerGetSize(ref uExtent.GetPinnableReference(), riid, hrFault, ref pDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, int hrFault, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerGetSize(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), hrFault, pDataSize);
    }

    /// <summary>To be documented.</summary>
    public static void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, int hrFault, Span<uint> pDataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerGetSize(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), hrFault, ref pDataSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint* pDataSize, Span<T0> pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(uExtent, riid, pDataSize, ref pDataBuffer.GetPinnableReference(), hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, Span<uint> pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(uExtent, riid, ref pDataSize.GetPinnableReference(), pDataBuffer, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, Span<uint> pDataSize, Span<T0> pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(uExtent, riid, ref pDataSize.GetPinnableReference(), ref pDataBuffer.GetPinnableReference(), hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, uint* pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(uExtent, ref riid.GetPinnableReference(), pDataSize, pDataBuffer, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, uint* pDataSize, Span<T0> pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(uExtent, ref riid.GetPinnableReference(), pDataSize, ref pDataBuffer.GetPinnableReference(), hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, Span<uint> pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(uExtent, ref riid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pDataBuffer, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Span<Guid> riid, Span<uint> pDataSize, Span<T0> pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(uExtent, ref riid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pDataBuffer.GetPinnableReference(), hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(ref uExtent.GetPinnableReference(), riid, pDataSize, pDataBuffer, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, uint* pDataSize, Span<T0> pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(ref uExtent.GetPinnableReference(), riid, pDataSize, ref pDataBuffer.GetPinnableReference(), hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, Span<uint> pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(ref uExtent.GetPinnableReference(), riid, ref pDataSize.GetPinnableReference(), pDataBuffer, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Guid* riid, Span<uint> pDataSize, Span<T0> pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(ref uExtent.GetPinnableReference(), riid, ref pDataSize.GetPinnableReference(), ref pDataBuffer.GetPinnableReference(), hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, uint* pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), pDataSize, pDataBuffer, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, uint* pDataSize, Span<T0> pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), pDataSize, ref pDataBuffer.GetPinnableReference(), hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, Span<uint> pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pDataBuffer, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static void ServerFillBuffer<T0>(this ComPtr<IChannelHook> thisVtbl, Span<Guid> uExtent, Span<Guid> riid, Span<uint> pDataSize, Span<T0> pDataBuffer, int hrFault) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ServerFillBuffer(ref uExtent.GetPinnableReference(), ref riid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pDataBuffer.GetPinnableReference(), hrFault);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IChannelHook> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
