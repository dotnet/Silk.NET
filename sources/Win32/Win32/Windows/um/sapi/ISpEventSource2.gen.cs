// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2373A435-6A4B-429E-A6AC-D4231A61975B")]
[NativeTypeName("struct ISpEventSource2 : ISpEventSource")]
[NativeInheritance("ISpEventSource")]
public unsafe partial struct ISpEventSource2 : ISpEventSource2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpEventSource2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpEventSource2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpEventSource2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpEventSource2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetNotifySink(ISpNotifySink pNotifySink)
    {
        return ((delegate* unmanaged<ISpEventSource2, ISpNotifySink, int>)((*lpVtbl)[3]))(
            this,
            pNotifySink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetNotifyWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam)
    {
        return (
            (delegate* unmanaged<ISpEventSource2, HWND, uint, WPARAM, LPARAM, int>)((*lpVtbl)[4])
        )(this, hWnd, Msg, wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetNotifyCallbackFunction(
        [NativeTypeName("SPNOTIFYCALLBACK *")]
            delegate* unmanaged<WPARAM, LPARAM, void> pfnCallback,
        WPARAM wParam,
        LPARAM lParam
    )
    {
        return (
            (delegate* unmanaged<
                ISpEventSource2,
                delegate* unmanaged<WPARAM, LPARAM, void>,
                WPARAM,
                LPARAM,
                int>)((*lpVtbl)[5])
        )(this, pfnCallback, wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetNotifyCallbackInterface(
        ISpNotifyCallback* pSpCallback,
        WPARAM wParam,
        LPARAM lParam
    )
    {
        return (
            (delegate* unmanaged<ISpEventSource2, ISpNotifyCallback*, WPARAM, LPARAM, int>)(
                (*lpVtbl)[6]
            )
        )(this, pSpCallback, wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetNotifyWin32Event()
    {
        return ((delegate* unmanaged<ISpEventSource2, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
    {
        return ((delegate* unmanaged<ISpEventSource2, uint, int>)((*lpVtbl)[8]))(
            this,
            dwMilliseconds
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HANDLE GetNotifyEventHandle()
    {
        return ((HANDLE)(((delegate* unmanaged<ISpEventSource2, void*>)((*lpVtbl)[9]))(this)));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetInterest(
        [NativeTypeName("ULONGLONG")] ulong ullEventInterest,
        [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest
    )
    {
        return ((delegate* unmanaged<ISpEventSource2, ulong, ulong, int>)((*lpVtbl)[10]))(
            this,
            ullEventInterest,
            ullQueuedInterest
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetEvents(
        [NativeTypeName("ULONG")] uint ulCount,
        SPEVENT* pEventArray,
        [NativeTypeName("ULONG *")] uint* pulFetched
    )
    {
        return ((delegate* unmanaged<ISpEventSource2, uint, SPEVENT*, uint*, int>)((*lpVtbl)[11]))(
            this,
            ulCount,
            pEventArray,
            pulFetched
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetInfo(SPEVENTSOURCEINFO* pInfo)
    {
        return ((delegate* unmanaged<ISpEventSource2, SPEVENTSOURCEINFO*, int>)((*lpVtbl)[12]))(
            this,
            pInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetEventsEx(
        [NativeTypeName("ULONG")] uint ulCount,
        SPEVENTEX* pEventArray,
        [NativeTypeName("ULONG *")] uint* pulFetched
    )
    {
        return (
            (delegate* unmanaged<ISpEventSource2, uint, SPEVENTEX*, uint*, int>)((*lpVtbl)[13])
        )(this, ulCount, pEventArray, pulFetched);
    }

    public interface Interface : ISpEventSource.Interface
    {
        [VtblIndex(13)]
        HRESULT GetEventsEx(
            [NativeTypeName("ULONG")] uint ulCount,
            SPEVENTEX* pEventArray,
            [NativeTypeName("ULONG *")] uint* pulFetched
        );
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

        [NativeTypeName("HRESULT (ISpNotifySink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpNotifySink, int> SetNotifySink;

        [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, WPARAM, LPARAM, int> SetNotifyWindowMessage;

        [NativeTypeName("HRESULT (SPNOTIFYCALLBACK *, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            delegate* unmanaged<WPARAM, LPARAM, void>,
            WPARAM,
            LPARAM,
            int> SetNotifyCallbackFunction;

        [NativeTypeName("HRESULT (ISpNotifyCallback *, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ISpNotifyCallback*,
            WPARAM,
            LPARAM,
            int> SetNotifyCallbackInterface;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetNotifyWin32Event;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> WaitForNotifyEvent;

        [NativeTypeName("HANDLE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetNotifyEventHandle;

        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong, int> SetInterest;

        [NativeTypeName("HRESULT (ULONG, SPEVENT *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SPEVENT*, uint*, int> GetEvents;

        [NativeTypeName("HRESULT (SPEVENTSOURCEINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPEVENTSOURCEINFO*, int> GetInfo;

        [NativeTypeName("HRESULT (ULONG, SPEVENTEX *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SPEVENTEX*, uint*, int> GetEventsEx;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpEventSource2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpEventSource2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpEventSource"/> to <see cref = "ISpEventSource2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpEventSource"/> instance to be converted </param>
    public static explicit operator ISpEventSource2(Silk.NET.Windows.ISpEventSource value)
    {
        return new ISpEventSource2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpEventSource2"/> to <see cref = "Silk.NET.Windows.ISpEventSource"/>.</summary>
    /// <param name = "value">The <see cref = "ISpEventSource2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpEventSource(ISpEventSource2 value)
    {
        return new Silk.NET.Windows.ISpEventSource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpNotifySource"/> to <see cref = "ISpEventSource2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpNotifySource"/> instance to be converted </param>
    public static explicit operator ISpEventSource2(Silk.NET.Windows.ISpNotifySource value)
    {
        return new ISpEventSource2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpEventSource2"/> to <see cref = "Silk.NET.Windows.ISpNotifySource"/>.</summary>
    /// <param name = "value">The <see cref = "ISpEventSource2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpNotifySource(ISpEventSource2 value)
    {
        return new Silk.NET.Windows.ISpNotifySource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpEventSource2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpEventSource2(Silk.NET.Windows.IUnknown value)
    {
        return new ISpEventSource2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpEventSource2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpEventSource2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpEventSource2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
