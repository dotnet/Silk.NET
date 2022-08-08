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

namespace Silk.NET.Direct3D9;

public unsafe static class Direct3DSurface9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, IDirect3DDevice9** ppDevice) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref IDirect3DDevice9* ppDevice) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, uint SizeOfData, uint Flags) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid refguid, void* pData, uint SizeOfData, uint Flags) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, uint* pSizeOfData) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, ref uint pSizeOfData) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pSizeOfDataPtr = &pSizeOfData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid refguid, void* pData, uint* pSizeOfData) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid refguid, void* pData, ref uint pSizeOfData) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FreePrivateData<TThis>(this TThis thisVtbl, Guid* refguid) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, int>)@this->LpVtbl[6])(@this, refguid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FreePrivateData<TThis>(this TThis thisVtbl, ref Guid refguid) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, int>)@this->LpVtbl[6])(@this, refguidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint SetPriority<TThis>(this TThis thisVtbl, uint PriorityNew) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, uint, uint>)@this->LpVtbl[7])(@this, PriorityNew);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPriority<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, uint>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PreLoad<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, void>)@this->LpVtbl[9])(@this);
    }

    /// <summary>To be documented.</summary>
    public static Resourcetype GetType<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        Resourcetype ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Resourcetype>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainer<TThis>(this TThis thisVtbl, Guid* riid, void** ppContainer) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void**, int>)@this->LpVtbl[11])(@this, riid, ppContainer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainer<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppContainer) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppContainerPtr = &ppContainer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void**, int>)@this->LpVtbl[11])(@this, riid, ppContainerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainer<TThis>(this TThis thisVtbl, ref Guid riid, void** ppContainer) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void**, int>)@this->LpVtbl[11])(@this, riidPtr, ppContainer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainer<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppContainer) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppContainerPtr = &ppContainer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, Guid*, void**, int>)@this->LpVtbl[11])(@this, riidPtr, ppContainerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, SurfaceDesc* pDesc) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, SurfaceDesc*, int>)@this->LpVtbl[12])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref SurfaceDesc pDesc) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, SurfaceDesc*, int>)@this->LpVtbl[12])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockRect<TThis>(this TThis thisVtbl, LockedRect* pLockedRect, Silk.NET.Maths.Rectangle<int>* pRect, uint Flags) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)@this->LpVtbl[13])(@this, pLockedRect, pRect, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockRect<TThis>(this TThis thisVtbl, LockedRect* pLockedRect, ref Silk.NET.Maths.Rectangle<int> pRect, uint Flags) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)@this->LpVtbl[13])(@this, pLockedRect, pRectPtr, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockRect<TThis>(this TThis thisVtbl, ref LockedRect pLockedRect, Silk.NET.Maths.Rectangle<int>* pRect, uint Flags) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (LockedRect* pLockedRectPtr = &pLockedRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)@this->LpVtbl[13])(@this, pLockedRectPtr, pRect, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LockRect<TThis>(this TThis thisVtbl, ref LockedRect pLockedRect, ref Silk.NET.Maths.Rectangle<int> pRect, uint Flags) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (LockedRect* pLockedRectPtr = &pLockedRect)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)@this->LpVtbl[13])(@this, pLockedRectPtr, pRectPtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnlockRect<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, int>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDC<TThis>(this TThis thisVtbl, nint* phdc) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, nint*, int>)@this->LpVtbl[15])(@this, phdc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDC<TThis>(this TThis thisVtbl, ref nint phdc) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (nint* phdcPtr = &phdc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, nint*, int>)@this->LpVtbl[15])(@this, phdcPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseDC<TThis>(this TThis thisVtbl, nint hdc) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSurface9*, nint, int>)@this->LpVtbl[16])(@this, hdc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, Span<T0> pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(refguid, ref pData.GetPinnableReference(), SizeOfData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> refguid, void* pData, uint SizeOfData, uint Flags) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref refguid.GetPinnableReference(), pData, SizeOfData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> refguid, Span<T0> pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref refguid.GetPinnableReference(), ref pData.GetPinnableReference(), SizeOfData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, Span<uint> pSizeOfData) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(refguid, pData, ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, Span<T0> pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(refguid, ref pData.GetPinnableReference(), pSizeOfData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, Span<T0> pData, Span<uint> pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(refguid, ref pData.GetPinnableReference(), ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> refguid, void* pData, uint* pSizeOfData) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), pData, pSizeOfData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> refguid, void* pData, Span<uint> pSizeOfData) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), pData, ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> refguid, Span<T0> pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), ref pData.GetPinnableReference(), pSizeOfData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> refguid, Span<T0> pData, Span<uint> pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), ref pData.GetPinnableReference(), ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FreePrivateData<TThis>(this TThis thisVtbl, Span<Guid> refguid) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->FreePrivateData(ref refguid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainer<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppContainer) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetContainer(ref riid.GetPinnableReference(), ppContainer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainer<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppContainer) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetContainer(ref riid.GetPinnableReference(), ref ppContainer);
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, Span<SurfaceDesc> pDesc) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockRect<TThis>(this TThis thisVtbl, LockedRect* pLockedRect, Span<Silk.NET.Maths.Rectangle<int>> pRect, uint Flags) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LockRect(pLockedRect, ref pRect.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockRect<TThis>(this TThis thisVtbl, Span<LockedRect> pLockedRect, Silk.NET.Maths.Rectangle<int>* pRect, uint Flags) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LockRect(ref pLockedRect.GetPinnableReference(), pRect, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int LockRect<TThis>(this TThis thisVtbl, Span<LockedRect> pLockedRect, Span<Silk.NET.Maths.Rectangle<int>> pRect, uint Flags) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LockRect(ref pLockedRect.GetPinnableReference(), ref pRect.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static int GetDC<TThis>(this TThis thisVtbl, Span<nint> phdc) where TThis : IComVtbl<IDirect3DSurface9>
    {
        var @this = (IDirect3DSurface9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDC(ref phdc.GetPinnableReference());
    }

}
