// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("53479470-F1DD-11CF-BC42-00AA00AC74F6")]
[NativeTypeName("struct IFullScreenVideoEx : IFullScreenVideo")]
[NativeInheritance("IFullScreenVideo")]
public unsafe partial struct IFullScreenVideoEx : IFullScreenVideoEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFullScreenVideoEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CountModes([NativeTypeName("long *")] int* pModes)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int*, int>)((*lpVtbl)[3]))(this, pModes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetModeInfo(
        [NativeTypeName("long")] int Mode,
        [NativeTypeName("long *")] int* pWidth,
        [NativeTypeName("long *")] int* pHeight,
        [NativeTypeName("long *")] int* pDepth
    )
    {
        return (
            (delegate* unmanaged<IFullScreenVideoEx, int, int*, int*, int*, int>)((*lpVtbl)[4])
        )(this, Mode, pWidth, pHeight, pDepth);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentMode([NativeTypeName("long *")] int* pMode)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int*, int>)((*lpVtbl)[5]))(this, pMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsModeAvailable([NativeTypeName("long")] int Mode)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int, int>)((*lpVtbl)[6]))(this, Mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsModeEnabled([NativeTypeName("long")] int Mode)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int, int>)((*lpVtbl)[7]))(this, Mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetEnabled(
        [NativeTypeName("long")] int Mode,
        [NativeTypeName("long")] int bEnabled
    )
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int, int, int>)((*lpVtbl)[8]))(
            this,
            Mode,
            bEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetClipFactor([NativeTypeName("long *")] int* pClipFactor)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int*, int>)((*lpVtbl)[9]))(
            this,
            pClipFactor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetClipFactor([NativeTypeName("long")] int ClipFactor)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int, int>)((*lpVtbl)[10]))(
            this,
            ClipFactor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetMessageDrain(HWND hwnd)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, HWND, int>)((*lpVtbl)[11]))(this, hwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMessageDrain(HWND* hwnd)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, HWND*, int>)((*lpVtbl)[12]))(this, hwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetMonitor([NativeTypeName("long")] int Monitor)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int, int>)((*lpVtbl)[13]))(this, Monitor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetMonitor([NativeTypeName("long *")] int* Monitor)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int*, int>)((*lpVtbl)[14]))(this, Monitor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT HideOnDeactivate([NativeTypeName("long")] int Hide)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int, int>)((*lpVtbl)[15]))(this, Hide);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT IsHideOnDeactivate()
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetCaption([NativeTypeName("BSTR")] ushort* strCaption)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, ushort*, int>)((*lpVtbl)[17]))(
            this,
            strCaption
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetCaption([NativeTypeName("BSTR *")] ushort** pstrCaption)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, ushort**, int>)((*lpVtbl)[18]))(
            this,
            pstrCaption
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetDefault()
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int>)((*lpVtbl)[19]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetAcceleratorTable(HWND hwnd, HACCEL hAccel)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, HWND, HACCEL, int>)((*lpVtbl)[20]))(
            this,
            hwnd,
            hAccel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetAcceleratorTable(HWND* phwnd, HACCEL* phAccel)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, HWND*, HACCEL*, int>)((*lpVtbl)[21]))(
            this,
            phwnd,
            phAccel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT KeepPixelAspectRatio([NativeTypeName("long")] int KeepAspect)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int, int>)((*lpVtbl)[22]))(
            this,
            KeepAspect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT IsKeepPixelAspectRatio([NativeTypeName("long *")] int* pKeepAspect)
    {
        return ((delegate* unmanaged<IFullScreenVideoEx, int*, int>)((*lpVtbl)[23]))(
            this,
            pKeepAspect
        );
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

        [NativeTypeName(
            "HRESULT (long, long *, long *, long *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
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

        [NativeTypeName(
            "HRESULT (HWND *, HACCEL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HWND*, HACCEL*, int> GetAcceleratorTable;

        [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> KeepPixelAspectRatio;

        [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> IsKeepPixelAspectRatio;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFullScreenVideoEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFullScreenVideoEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IFullScreenVideo"/> to <see cref = "IFullScreenVideoEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IFullScreenVideo"/> instance to be converted </param>
    public static explicit operator IFullScreenVideoEx(Silk.NET.Windows.IFullScreenVideo value)
    {
        return new IFullScreenVideoEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFullScreenVideoEx"/> to <see cref = "Silk.NET.Windows.IFullScreenVideo"/>.</summary>
    /// <param name = "value">The <see cref = "IFullScreenVideoEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IFullScreenVideo(IFullScreenVideoEx value)
    {
        return new Silk.NET.Windows.IFullScreenVideo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFullScreenVideoEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFullScreenVideoEx(Silk.NET.Windows.IUnknown value)
    {
        return new IFullScreenVideoEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFullScreenVideoEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFullScreenVideoEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFullScreenVideoEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
