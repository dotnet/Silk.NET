// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IDDrawExclModeVideo.xml' path='doc/member[@name="IDDrawExclModeVideo"]/*' />
[Guid("153ACC21-D83B-11D1-82BF-00A0C9696C8F")]
[NativeTypeName("struct IDDrawExclModeVideo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDDrawExclModeVideo : IDDrawExclModeVideo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDDrawExclModeVideo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDDrawExclModeVideo*, Guid*, void**, int>)(lpVtbl[0]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDDrawExclModeVideo*, uint>)(lpVtbl[1]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDDrawExclModeVideo*, uint>)(lpVtbl[2]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDDrawExclModeVideo.xml' path='doc/member[@name="IDDrawExclModeVideo.SetDDrawObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDDrawObject(IDirectDraw* pDDrawObject)
    {
        return ((delegate* unmanaged<IDDrawExclModeVideo*, IDirectDraw*, int>)(lpVtbl[3]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), pDDrawObject);
    }

    /// <include file='IDDrawExclModeVideo.xml' path='doc/member[@name="IDDrawExclModeVideo.GetDDrawObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDDrawObject(IDirectDraw** ppDDrawObject, BOOL* pbUsingExternal)
    {
        return ((delegate* unmanaged<IDDrawExclModeVideo*, IDirectDraw**, BOOL*, int>)(lpVtbl[4]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), ppDDrawObject, pbUsingExternal);
    }

    /// <include file='IDDrawExclModeVideo.xml' path='doc/member[@name="IDDrawExclModeVideo.SetDDrawSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDDrawSurface(IDirectDrawSurface* pDDrawSurface)
    {
        return ((delegate* unmanaged<IDDrawExclModeVideo*, IDirectDrawSurface*, int>)(lpVtbl[5]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), pDDrawSurface);
    }

    /// <include file='IDDrawExclModeVideo.xml' path='doc/member[@name="IDDrawExclModeVideo.GetDDrawSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDDrawSurface(IDirectDrawSurface** ppDDrawSurface, BOOL* pbUsingExternal)
    {
        return ((delegate* unmanaged<IDDrawExclModeVideo*, IDirectDrawSurface**, BOOL*, int>)(lpVtbl[6]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), ppDDrawSurface, pbUsingExternal);
    }

    /// <include file='IDDrawExclModeVideo.xml' path='doc/member[@name="IDDrawExclModeVideo.SetDrawParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDrawParameters([NativeTypeName("const RECT *")] RECT* prcSource, [NativeTypeName("const RECT *")] RECT* prcTarget)
    {
        return ((delegate* unmanaged<IDDrawExclModeVideo*, RECT*, RECT*, int>)(lpVtbl[7]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), prcSource, prcTarget);
    }

    /// <include file='IDDrawExclModeVideo.xml' path='doc/member[@name="IDDrawExclModeVideo.GetNativeVideoProps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetNativeVideoProps([NativeTypeName("DWORD *")] uint* pdwVideoWidth, [NativeTypeName("DWORD *")] uint* pdwVideoHeight, [NativeTypeName("DWORD *")] uint* pdwPictAspectRatioX, [NativeTypeName("DWORD *")] uint* pdwPictAspectRatioY)
    {
        return ((delegate* unmanaged<IDDrawExclModeVideo*, uint*, uint*, uint*, uint*, int>)(lpVtbl[8]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), pdwVideoWidth, pdwVideoHeight, pdwPictAspectRatioX, pdwPictAspectRatioY);
    }

    /// <include file='IDDrawExclModeVideo.xml' path='doc/member[@name="IDDrawExclModeVideo.SetCallbackInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetCallbackInterface(IDDrawExclModeVideoCallback* pCallback, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IDDrawExclModeVideo*, IDDrawExclModeVideoCallback*, uint, int>)(lpVtbl[9]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), pCallback, dwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDDrawObject(IDirectDraw* pDDrawObject);

        [VtblIndex(4)]
        HRESULT GetDDrawObject(IDirectDraw** ppDDrawObject, BOOL* pbUsingExternal);

        [VtblIndex(5)]
        HRESULT SetDDrawSurface(IDirectDrawSurface* pDDrawSurface);

        [VtblIndex(6)]
        HRESULT GetDDrawSurface(IDirectDrawSurface** ppDDrawSurface, BOOL* pbUsingExternal);

        [VtblIndex(7)]
        HRESULT SetDrawParameters([NativeTypeName("const RECT *")] RECT* prcSource, [NativeTypeName("const RECT *")] RECT* prcTarget);

        [VtblIndex(8)]
        HRESULT GetNativeVideoProps([NativeTypeName("DWORD *")] uint* pdwVideoWidth, [NativeTypeName("DWORD *")] uint* pdwVideoHeight, [NativeTypeName("DWORD *")] uint* pdwPictAspectRatioX, [NativeTypeName("DWORD *")] uint* pdwPictAspectRatioY);

        [VtblIndex(9)]
        HRESULT SetCallbackInterface(IDDrawExclModeVideoCallback* pCallback, [NativeTypeName("DWORD")] uint dwFlags);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IDirectDraw *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDraw*, int> SetDDrawObject;

        [NativeTypeName("HRESULT (IDirectDraw **, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDraw**, BOOL*, int> GetDDrawObject;

        [NativeTypeName("HRESULT (IDirectDrawSurface *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface*, int> SetDDrawSurface;

        [NativeTypeName("HRESULT (IDirectDrawSurface **, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface**, BOOL*, int> GetDDrawSurface;

        [NativeTypeName("HRESULT (const RECT *, const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, int> SetDrawParameters;

        [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, uint*, uint*, int> GetNativeVideoProps;

        [NativeTypeName("HRESULT (IDDrawExclModeVideoCallback *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDDrawExclModeVideoCallback*, uint, int> SetCallbackInterface;
    }
}
