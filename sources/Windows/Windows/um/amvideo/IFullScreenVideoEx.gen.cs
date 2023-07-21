// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IFullScreenVideoEx.xml' path='doc/member[@name="IFullScreenVideoEx"]/*' />
[Guid("53479470-F1DD-11CF-BC42-00AA00AC74F6")]
[NativeTypeName("struct IFullScreenVideoEx : IFullScreenVideo")]
[NativeInheritance("IFullScreenVideo")]
public unsafe partial struct IFullScreenVideoEx : IFullScreenVideoEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFullScreenVideoEx));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, Guid*, void**, int>)(lpVtbl[0]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, uint>)(lpVtbl[1]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, uint>)(lpVtbl[2]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IFullScreenVideo.CountModes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CountModes([NativeTypeName("long *")] int* pModes)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[3]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pModes);
    }

    /// <inheritdoc cref="IFullScreenVideo.GetModeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetModeInfo([NativeTypeName("long")] int Mode, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight, [NativeTypeName("long *")] int* pDepth)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int, int*, int*, int*, int>)(lpVtbl[4]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode, pWidth, pHeight, pDepth);
    }

    /// <inheritdoc cref="IFullScreenVideo.GetCurrentMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentMode([NativeTypeName("long *")] int* pMode)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[5]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pMode);
    }

    /// <inheritdoc cref="IFullScreenVideo.IsModeAvailable" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsModeAvailable([NativeTypeName("long")] int Mode)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[6]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode);
    }

    /// <inheritdoc cref="IFullScreenVideo.IsModeEnabled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsModeEnabled([NativeTypeName("long")] int Mode)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[7]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode);
    }

    /// <inheritdoc cref="IFullScreenVideo.SetEnabled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetEnabled([NativeTypeName("long")] int Mode, [NativeTypeName("long")] int bEnabled)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int, int, int>)(lpVtbl[8]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode, bEnabled);
    }

    /// <inheritdoc cref="IFullScreenVideo.GetClipFactor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetClipFactor([NativeTypeName("long *")] int* pClipFactor)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[9]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pClipFactor);
    }

    /// <inheritdoc cref="IFullScreenVideo.SetClipFactor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetClipFactor([NativeTypeName("long")] int ClipFactor)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[10]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), ClipFactor);
    }

    /// <inheritdoc cref="IFullScreenVideo.SetMessageDrain" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetMessageDrain(HWND hwnd)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, HWND, int>)(lpVtbl[11]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <inheritdoc cref="IFullScreenVideo.GetMessageDrain" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMessageDrain(HWND* hwnd)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, HWND*, int>)(lpVtbl[12]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <inheritdoc cref="IFullScreenVideo.SetMonitor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetMonitor([NativeTypeName("long")] int Monitor)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[13]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Monitor);
    }

    /// <inheritdoc cref="IFullScreenVideo.GetMonitor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetMonitor([NativeTypeName("long *")] int* Monitor)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[14]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Monitor);
    }

    /// <inheritdoc cref="IFullScreenVideo.HideOnDeactivate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT HideOnDeactivate([NativeTypeName("long")] int Hide)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[15]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Hide);
    }

    /// <inheritdoc cref="IFullScreenVideo.IsHideOnDeactivate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT IsHideOnDeactivate()
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int>)(lpVtbl[16]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IFullScreenVideo.SetCaption" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetCaption([NativeTypeName("BSTR")] ushort* strCaption)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, ushort*, int>)(lpVtbl[17]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), strCaption);
    }

    /// <inheritdoc cref="IFullScreenVideo.GetCaption" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetCaption([NativeTypeName("BSTR *")] ushort** pstrCaption)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, ushort**, int>)(lpVtbl[18]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pstrCaption);
    }

    /// <inheritdoc cref="IFullScreenVideo.SetDefault" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetDefault()
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int>)(lpVtbl[19]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFullScreenVideoEx.xml' path='doc/member[@name="IFullScreenVideoEx.SetAcceleratorTable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetAcceleratorTable(HWND hwnd, HACCEL hAccel)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, HWND, HACCEL, int>)(lpVtbl[20]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), hwnd, hAccel);
    }

    /// <include file='IFullScreenVideoEx.xml' path='doc/member[@name="IFullScreenVideoEx.GetAcceleratorTable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetAcceleratorTable(HWND* phwnd, HACCEL* phAccel)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, HWND*, HACCEL*, int>)(lpVtbl[21]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), phwnd, phAccel);
    }

    /// <include file='IFullScreenVideoEx.xml' path='doc/member[@name="IFullScreenVideoEx.KeepPixelAspectRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT KeepPixelAspectRatio([NativeTypeName("long")] int KeepAspect)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[22]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), KeepAspect);
    }

    /// <include file='IFullScreenVideoEx.xml' path='doc/member[@name="IFullScreenVideoEx.IsKeepPixelAspectRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT IsKeepPixelAspectRatio([NativeTypeName("long *")] int* pKeepAspect)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[23]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pKeepAspect);
    }

    public interface Interface : IFullScreenVideo.Interface
    {
        [VtblIndex(20)]
        HRESULT SetAcceleratorTable(HWND hwnd, HACCEL hAccel);

        [VtblIndex(21)]
        HRESULT GetAcceleratorTable(HWND* phwnd, HACCEL* phAccel);

        [VtblIndex(22)]
        HRESULT KeepPixelAspectRatio([NativeTypeName("long")] int KeepAspect);

        [VtblIndex(23)]
        HRESULT IsKeepPixelAspectRatio([NativeTypeName("long *")] int* pKeepAspect);
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

        [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> CountModes;

        [NativeTypeName("HRESULT (long, long *, long *, long *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int*, int*, int> GetModeInfo;

        [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetCurrentMode;

        [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> IsModeAvailable;

        [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> IsModeEnabled;

        [NativeTypeName("HRESULT (long, long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetEnabled;

        [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetClipFactor;

        [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetClipFactor;

        [NativeTypeName("HRESULT (HWND) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> SetMessageDrain;

        [NativeTypeName("HRESULT (HWND *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetMessageDrain;

        [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetMonitor;

        [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetMonitor;

        [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> HideOnDeactivate;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsHideOnDeactivate;

        [NativeTypeName("HRESULT (BSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetCaption;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetCaption;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetDefault;

        [NativeTypeName("HRESULT (HWND, HACCEL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HACCEL, int> SetAcceleratorTable;

        [NativeTypeName("HRESULT (HWND *, HACCEL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, HACCEL*, int> GetAcceleratorTable;

        [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> KeepPixelAspectRatio;

        [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> IsKeepPixelAspectRatio;
    }
}
