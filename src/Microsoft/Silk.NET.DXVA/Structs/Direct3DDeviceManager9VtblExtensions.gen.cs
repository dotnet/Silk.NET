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

namespace Silk.NET.DXVA;

public unsafe static class Direct3DDeviceManager9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirect3DDeviceManager9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3DDeviceManager9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResetDevice(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Silk.NET.Direct3D9.IDirect3DDevice9* pDevice, uint resetToken)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Silk.NET.Direct3D9.IDirect3DDevice9*, uint, int>)@this->LpVtbl[3])(@this, pDevice, resetToken);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResetDevice(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref Silk.NET.Direct3D9.IDirect3DDevice9 pDevice, uint resetToken)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DDevice9* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Silk.NET.Direct3D9.IDirect3DDevice9*, uint, int>)@this->LpVtbl[3])(@this, pDevicePtr, resetToken);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenDeviceHandle(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void** phDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void**, int>)@this->LpVtbl[4])(@this, phDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenDeviceHandle(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref void* phDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** phDevicePtr = &phDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void**, int>)@this->LpVtbl[4])(@this, phDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CloseDeviceHandle(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[5])(@this, hDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CloseDeviceHandle<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref T0 hDevice) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[5])(@this, hDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TestDevice(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[6])(@this, hDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int TestDevice<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref T0 hDevice) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[6])(@this, hDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockDevice(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice, Silk.NET.Direct3D9.IDirect3DDevice9** ppDevice, Silk.NET.Core.Bool32 fBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, hDevice, ppDevice, fBlock);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockDevice(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice, ref Silk.NET.Direct3D9.IDirect3DDevice9* ppDevice, Silk.NET.Core.Bool32 fBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DDevice9** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, hDevice, ppDevicePtr, fBlock);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockDevice<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref T0 hDevice, Silk.NET.Direct3D9.IDirect3DDevice9** ppDevice, Silk.NET.Core.Bool32 fBlock) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, hDevicePtr, ppDevice, fBlock);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockDevice<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref T0 hDevice, ref Silk.NET.Direct3D9.IDirect3DDevice9* ppDevice, Silk.NET.Core.Bool32 fBlock) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, hDevicePtr, ppDevicePtr, fBlock);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnlockDevice(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice, Silk.NET.Core.Bool32 fSaveState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[8])(@this, hDevice, fSaveState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnlockDevice<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref T0 hDevice, Silk.NET.Core.Bool32 fSaveState) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[8])(@this, hDevicePtr, fSaveState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice, Guid* riid, void** ppService)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevice, riid, ppService);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice, Guid* riid, ref void* ppService)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppServicePtr = &ppService)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevice, riid, ppServicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice, ref Guid riid, void** ppService)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevice, riidPtr, ppService);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice, ref Guid riid, ref void* ppService)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppServicePtr = &ppService)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevice, riidPtr, ppServicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref T0 hDevice, Guid* riid, void** ppService) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevicePtr, riid, ppService);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref T0 hDevice, Guid* riid, ref void* ppService) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            fixed (void** ppServicePtr = &ppService)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevicePtr, riid, ppServicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref T0 hDevice, ref Guid riid, void** ppService) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevicePtr, riidPtr, ppService);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref T0 hDevice, ref Guid riid, ref void* ppService) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppServicePtr = &ppService)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevicePtr, riidPtr, ppServicePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int ResetDevice(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DDevice9> pDevice, uint resetToken)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ResetDevice(ref pDevice.GetPinnableReference(), resetToken);
    }

    /// <summary>To be documented.</summary>
    public static int CloseDeviceHandle<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Span<T0> hDevice) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CloseDeviceHandle(ref hDevice.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int TestDevice<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Span<T0> hDevice) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TestDevice(ref hDevice.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockDevice<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Span<T0> hDevice, Silk.NET.Direct3D9.IDirect3DDevice9** ppDevice, Silk.NET.Core.Bool32 fBlock) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LockDevice(ref hDevice.GetPinnableReference(), ppDevice, fBlock);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockDevice<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Span<T0> hDevice, ref Silk.NET.Direct3D9.IDirect3DDevice9* ppDevice, Silk.NET.Core.Bool32 fBlock) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LockDevice(ref hDevice.GetPinnableReference(), ref ppDevice, fBlock);
    }

    /// <summary>To be documented.</summary>
    public static int UnlockDevice<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Span<T0> hDevice, Silk.NET.Core.Bool32 fSaveState) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UnlockDevice(ref hDevice.GetPinnableReference(), fSaveState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<TI0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice, out ComPtr<TI0> ppService) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppService = default;
        return @this->GetVideoService(hDevice, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppService.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice, Span<Guid> riid, void** ppService)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoService(hDevice, ref riid.GetPinnableReference(), ppService);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice, Span<Guid> riid, ref void* ppService)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoService(hDevice, ref riid.GetPinnableReference(), ref ppService);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Span<T0> hDevice, Guid* riid, void** ppService) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoService(ref hDevice.GetPinnableReference(), riid, ppService);
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoService<T0, TI0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref T0 hDevice, out ComPtr<TI0> ppService) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppService = default;
        return @this->GetVideoService(ref hDevice, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppService.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Span<T0> hDevice, Guid* riid, ref void* ppService) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoService(ref hDevice.GetPinnableReference(), riid, ref ppService);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Span<T0> hDevice, Span<Guid> riid, void** ppService) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoService(ref hDevice.GetPinnableReference(), ref riid.GetPinnableReference(), ppService);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<T0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Span<T0> hDevice, Span<Guid> riid, ref void* ppService) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoService(ref hDevice.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppService);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetVideoService<TI0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetVideoService(hDevice, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetVideoService<T0, TI0>(this ComPtr<IDirect3DDeviceManager9> thisVtbl, ref T0 hDevice) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetVideoService(ref hDevice, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
