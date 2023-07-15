// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo"]/*'/>
[Guid("DD1D7110-7836-11CF-BF47-00AA0055595A")]
[NativeTypeName("struct IFullScreenVideo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFullScreenVideo : IFullScreenVideo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFullScreenVideo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, Guid*, void**, int> )(lpVtbl[0]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFullScreenVideo*, uint> )(lpVtbl[1]))((IFullScreenVideo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFullScreenVideo*, uint> )(lpVtbl[2]))((IFullScreenVideo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.CountModes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CountModes([NativeTypeName("long *")] int* pModes)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, int*, int> )(lpVtbl[3]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), pModes);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.GetModeInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetModeInfo([NativeTypeName("long")] int Mode, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight, [NativeTypeName("long *")] int* pDepth)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, int, int*, int*, int*, int> )(lpVtbl[4]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Mode, pWidth, pHeight, pDepth);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.GetCurrentMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentMode([NativeTypeName("long *")] int* pMode)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, int*, int> )(lpVtbl[5]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), pMode);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.IsModeAvailable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsModeAvailable([NativeTypeName("long")] int Mode)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, int, int> )(lpVtbl[6]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Mode);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.IsModeEnabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsModeEnabled([NativeTypeName("long")] int Mode)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, int, int> )(lpVtbl[7]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Mode);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.SetEnabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetEnabled([NativeTypeName("long")] int Mode, [NativeTypeName("long")] int bEnabled)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, int, int, int> )(lpVtbl[8]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Mode, bEnabled);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.GetClipFactor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetClipFactor([NativeTypeName("long *")] int* pClipFactor)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, int*, int> )(lpVtbl[9]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), pClipFactor);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.SetClipFactor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetClipFactor([NativeTypeName("long")] int ClipFactor)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, int, int> )(lpVtbl[10]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), ClipFactor);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.SetMessageDrain"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetMessageDrain(HWND hwnd)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, HWND, int> )(lpVtbl[11]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.GetMessageDrain"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMessageDrain(HWND* hwnd)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, HWND*, int> )(lpVtbl[12]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.SetMonitor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetMonitor([NativeTypeName("long")] int Monitor)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, int, int> )(lpVtbl[13]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Monitor);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.GetMonitor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetMonitor([NativeTypeName("long *")] int* Monitor)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, int*, int> )(lpVtbl[14]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Monitor);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.HideOnDeactivate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT HideOnDeactivate([NativeTypeName("long")] int Hide)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, int, int> )(lpVtbl[15]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Hide);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.IsHideOnDeactivate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT IsHideOnDeactivate()
    {
        return ((delegate* unmanaged<IFullScreenVideo*, int> )(lpVtbl[16]))((IFullScreenVideo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.SetCaption"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetCaption([NativeTypeName("BSTR")] ushort* strCaption)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, ushort*, int> )(lpVtbl[17]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), strCaption);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.GetCaption"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetCaption([NativeTypeName("BSTR *")] ushort** pstrCaption)
    {
        return ((delegate* unmanaged<IFullScreenVideo*, ushort**, int> )(lpVtbl[18]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), pstrCaption);
    }

    /// <include file='IFullScreenVideo.xml' path='doc/member[@name="IFullScreenVideo.SetDefault"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetDefault()
    {
        return ((delegate* unmanaged<IFullScreenVideo*, int> )(lpVtbl[19]))((IFullScreenVideo*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CountModes([NativeTypeName("long *")] int* pModes);
        [VtblIndex(4)]
        HRESULT GetModeInfo([NativeTypeName("long")] int Mode, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight, [NativeTypeName("long *")] int* pDepth);
        [VtblIndex(5)]
        HRESULT GetCurrentMode([NativeTypeName("long *")] int* pMode);
        [VtblIndex(6)]
        HRESULT IsModeAvailable([NativeTypeName("long")] int Mode);
        [VtblIndex(7)]
        HRESULT IsModeEnabled([NativeTypeName("long")] int Mode);
        [VtblIndex(8)]
        HRESULT SetEnabled([NativeTypeName("long")] int Mode, [NativeTypeName("long")] int bEnabled);
        [VtblIndex(9)]
        HRESULT GetClipFactor([NativeTypeName("long *")] int* pClipFactor);
        [VtblIndex(10)]
        HRESULT SetClipFactor([NativeTypeName("long")] int ClipFactor);
        [VtblIndex(11)]
        HRESULT SetMessageDrain(HWND hwnd);
        [VtblIndex(12)]
        HRESULT GetMessageDrain(HWND* hwnd);
        [VtblIndex(13)]
        HRESULT SetMonitor([NativeTypeName("long")] int Monitor);
        [VtblIndex(14)]
        HRESULT GetMonitor([NativeTypeName("long *")] int* Monitor);
        [VtblIndex(15)]
        HRESULT HideOnDeactivate([NativeTypeName("long")] int Hide);
        [VtblIndex(16)]
        HRESULT IsHideOnDeactivate();
        [VtblIndex(17)]
        HRESULT SetCaption([NativeTypeName("BSTR")] ushort* strCaption);
        [VtblIndex(18)]
        HRESULT GetCaption([NativeTypeName("BSTR *")] ushort** pstrCaption);
        [VtblIndex(19)]
        HRESULT SetDefault();
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
    }
}