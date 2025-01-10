// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DD1D7110-7836-11CF-BF47-00AA0055595A")]
[NativeTypeName("struct IFullScreenVideo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFullScreenVideo : IFullScreenVideo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFullScreenVideo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFullScreenVideo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFullScreenVideo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFullScreenVideo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CountModes([NativeTypeName("long *")] int* pModes)
    {
        return ((delegate* unmanaged<IFullScreenVideo, int*, int>)((*lpVtbl)[3]))(this, pModes);
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
        return ((delegate* unmanaged<IFullScreenVideo, int, int*, int*, int*, int>)((*lpVtbl)[4]))(
            this,
            Mode,
            pWidth,
            pHeight,
            pDepth
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentMode([NativeTypeName("long *")] int* pMode)
    {
        return ((delegate* unmanaged<IFullScreenVideo, int*, int>)((*lpVtbl)[5]))(this, pMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsModeAvailable([NativeTypeName("long")] int Mode)
    {
        return ((delegate* unmanaged<IFullScreenVideo, int, int>)((*lpVtbl)[6]))(this, Mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsModeEnabled([NativeTypeName("long")] int Mode)
    {
        return ((delegate* unmanaged<IFullScreenVideo, int, int>)((*lpVtbl)[7]))(this, Mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetEnabled(
        [NativeTypeName("long")] int Mode,
        [NativeTypeName("long")] int bEnabled
    )
    {
        return ((delegate* unmanaged<IFullScreenVideo, int, int, int>)((*lpVtbl)[8]))(
            this,
            Mode,
            bEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetClipFactor([NativeTypeName("long *")] int* pClipFactor)
    {
        return ((delegate* unmanaged<IFullScreenVideo, int*, int>)((*lpVtbl)[9]))(
            this,
            pClipFactor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetClipFactor([NativeTypeName("long")] int ClipFactor)
    {
        return ((delegate* unmanaged<IFullScreenVideo, int, int>)((*lpVtbl)[10]))(this, ClipFactor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetMessageDrain(HWND hwnd)
    {
        return ((delegate* unmanaged<IFullScreenVideo, HWND, int>)((*lpVtbl)[11]))(this, hwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMessageDrain(HWND* hwnd)
    {
        return ((delegate* unmanaged<IFullScreenVideo, HWND*, int>)((*lpVtbl)[12]))(this, hwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetMonitor([NativeTypeName("long")] int Monitor)
    {
        return ((delegate* unmanaged<IFullScreenVideo, int, int>)((*lpVtbl)[13]))(this, Monitor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetMonitor([NativeTypeName("long *")] int* Monitor)
    {
        return ((delegate* unmanaged<IFullScreenVideo, int*, int>)((*lpVtbl)[14]))(this, Monitor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT HideOnDeactivate([NativeTypeName("long")] int Hide)
    {
        return ((delegate* unmanaged<IFullScreenVideo, int, int>)((*lpVtbl)[15]))(this, Hide);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT IsHideOnDeactivate()
    {
        return ((delegate* unmanaged<IFullScreenVideo, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetCaption([NativeTypeName("BSTR")] ushort* strCaption)
    {
        return ((delegate* unmanaged<IFullScreenVideo, ushort*, int>)((*lpVtbl)[17]))(
            this,
            strCaption
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetCaption([NativeTypeName("BSTR *")] ushort** pstrCaption)
    {
        return ((delegate* unmanaged<IFullScreenVideo, ushort**, int>)((*lpVtbl)[18]))(
            this,
            pstrCaption
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetDefault()
    {
        return ((delegate* unmanaged<IFullScreenVideo, int>)((*lpVtbl)[19]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CountModes([NativeTypeName("long *")] int* pModes);

        [VtblIndex(4)]
        HRESULT GetModeInfo(
            [NativeTypeName("long")] int Mode,
            [NativeTypeName("long *")] int* pWidth,
            [NativeTypeName("long *")] int* pHeight,
            [NativeTypeName("long *")] int* pDepth
        );

        [VtblIndex(5)]
        HRESULT GetCurrentMode([NativeTypeName("long *")] int* pMode);

        [VtblIndex(6)]
        HRESULT IsModeAvailable([NativeTypeName("long")] int Mode);

        [VtblIndex(7)]
        HRESULT IsModeEnabled([NativeTypeName("long")] int Mode);

        [VtblIndex(8)]
        HRESULT SetEnabled(
            [NativeTypeName("long")] int Mode,
            [NativeTypeName("long")] int bEnabled
        );

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
    }

    /// <summary>Initializes a new instance of the <see cref = "IFullScreenVideo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFullScreenVideo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFullScreenVideo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFullScreenVideo(Silk.NET.Windows.IUnknown value)
    {
        return new IFullScreenVideo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFullScreenVideo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFullScreenVideo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFullScreenVideo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
