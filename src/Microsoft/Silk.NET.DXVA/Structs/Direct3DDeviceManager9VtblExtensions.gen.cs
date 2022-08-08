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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResetDevice<TThis>(this TThis thisVtbl, Silk.NET.Direct3D9.IDirect3DDevice9* pDevice, uint resetToken) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Silk.NET.Direct3D9.IDirect3DDevice9*, uint, int>)@this->LpVtbl[3])(@this, pDevice, resetToken);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResetDevice<TThis>(this TThis thisVtbl, ref Silk.NET.Direct3D9.IDirect3DDevice9 pDevice, uint resetToken) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DDevice9* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Silk.NET.Direct3D9.IDirect3DDevice9*, uint, int>)@this->LpVtbl[3])(@this, pDevicePtr, resetToken);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenDeviceHandle<TThis>(this TThis thisVtbl, void** phDevice) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void**, int>)@this->LpVtbl[4])(@this, phDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenDeviceHandle<TThis>(this TThis thisVtbl, ref void* phDevice) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** phDevicePtr = &phDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void**, int>)@this->LpVtbl[4])(@this, phDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CloseDeviceHandle<TThis>(this TThis thisVtbl, void* hDevice) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[5])(@this, hDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CloseDeviceHandle<T0, TThis>(this TThis thisVtbl, ref T0 hDevice) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[5])(@this, hDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TestDevice<TThis>(this TThis thisVtbl, void* hDevice) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[6])(@this, hDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int TestDevice<T0, TThis>(this TThis thisVtbl, ref T0 hDevice) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[6])(@this, hDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockDevice<TThis>(this TThis thisVtbl, void* hDevice, Silk.NET.Direct3D9.IDirect3DDevice9** ppDevice, int fBlock) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, int, int>)@this->LpVtbl[7])(@this, hDevice, ppDevice, fBlock);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockDevice<TThis>(this TThis thisVtbl, void* hDevice, ref Silk.NET.Direct3D9.IDirect3DDevice9* ppDevice, int fBlock) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DDevice9** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, int, int>)@this->LpVtbl[7])(@this, hDevice, ppDevicePtr, fBlock);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockDevice<T0, TThis>(this TThis thisVtbl, ref T0 hDevice, Silk.NET.Direct3D9.IDirect3DDevice9** ppDevice, int fBlock) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, int, int>)@this->LpVtbl[7])(@this, hDevicePtr, ppDevice, fBlock);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockDevice<T0, TThis>(this TThis thisVtbl, ref T0 hDevice, ref Silk.NET.Direct3D9.IDirect3DDevice9* ppDevice, int fBlock) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            fixed (Silk.NET.Direct3D9.IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, int, int>)@this->LpVtbl[7])(@this, hDevicePtr, ppDevicePtr, fBlock);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnlockDevice<TThis>(this TThis thisVtbl, void* hDevice, int fSaveState) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int, int>)@this->LpVtbl[8])(@this, hDevice, fSaveState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnlockDevice<T0, TThis>(this TThis thisVtbl, ref T0 hDevice, int fSaveState) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int, int>)@this->LpVtbl[8])(@this, hDevicePtr, fSaveState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<TThis>(this TThis thisVtbl, void* hDevice, Guid* riid, void** ppService) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevice, riid, ppService);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<TThis>(this TThis thisVtbl, void* hDevice, Guid* riid, ref void* ppService) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppServicePtr = &ppService)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevice, riid, ppServicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<TThis>(this TThis thisVtbl, void* hDevice, ref Guid riid, void** ppService) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevice, riidPtr, ppService);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<TThis>(this TThis thisVtbl, void* hDevice, ref Guid riid, ref void* ppService) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetVideoService<T0, TThis>(this TThis thisVtbl, ref T0 hDevice, Guid* riid, void** ppService) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hDevicePtr = &hDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevicePtr, riid, ppService);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<T0, TThis>(this TThis thisVtbl, ref T0 hDevice, Guid* riid, ref void* ppService) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetVideoService<T0, TThis>(this TThis thisVtbl, ref T0 hDevice, ref Guid riid, void** ppService) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetVideoService<T0, TThis>(this TThis thisVtbl, ref T0 hDevice, ref Guid riid, ref void* ppService) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int ResetDevice<TThis>(this TThis thisVtbl, Span<Silk.NET.Direct3D9.IDirect3DDevice9> pDevice, uint resetToken) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ResetDevice(ref pDevice.GetPinnableReference(), resetToken);
    }

    /// <summary>To be documented.</summary>
    public static int CloseDeviceHandle<T0, TThis>(this TThis thisVtbl, Span<T0> hDevice) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CloseDeviceHandle(ref hDevice.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int TestDevice<T0, TThis>(this TThis thisVtbl, Span<T0> hDevice) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->TestDevice(ref hDevice.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockDevice<T0, TThis>(this TThis thisVtbl, Span<T0> hDevice, Silk.NET.Direct3D9.IDirect3DDevice9** ppDevice, int fBlock) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LockDevice(ref hDevice.GetPinnableReference(), ppDevice, fBlock);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockDevice<T0, TThis>(this TThis thisVtbl, Span<T0> hDevice, ref Silk.NET.Direct3D9.IDirect3DDevice9* ppDevice, int fBlock) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LockDevice(ref hDevice.GetPinnableReference(), ref ppDevice, fBlock);
    }

    /// <summary>To be documented.</summary>
    public static int UnlockDevice<T0, TThis>(this TThis thisVtbl, Span<T0> hDevice, int fSaveState) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UnlockDevice(ref hDevice.GetPinnableReference(), fSaveState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<TThis>(this TThis thisVtbl, void* hDevice, Span<Guid> riid, void** ppService) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoService(hDevice, ref riid.GetPinnableReference(), ppService);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<TThis>(this TThis thisVtbl, void* hDevice, Span<Guid> riid, ref void* ppService) where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoService(hDevice, ref riid.GetPinnableReference(), ref ppService);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<T0, TThis>(this TThis thisVtbl, Span<T0> hDevice, Guid* riid, void** ppService) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoService(ref hDevice.GetPinnableReference(), riid, ppService);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<T0, TThis>(this TThis thisVtbl, Span<T0> hDevice, Guid* riid, ref void* ppService) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoService(ref hDevice.GetPinnableReference(), riid, ref ppService);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<T0, TThis>(this TThis thisVtbl, Span<T0> hDevice, Span<Guid> riid, void** ppService) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoService(ref hDevice.GetPinnableReference(), ref riid.GetPinnableReference(), ppService);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService<T0, TThis>(this TThis thisVtbl, Span<T0> hDevice, Span<Guid> riid, ref void* ppService) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDeviceManager9>
    {
        var @this = (IDirect3DDeviceManager9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVideoService(ref hDevice.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppService);
    }

}
