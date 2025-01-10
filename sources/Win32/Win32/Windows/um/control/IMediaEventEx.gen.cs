// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A868C0-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IMediaEventEx : IMediaEvent")]
[NativeInheritance("IMediaEvent")]
public unsafe partial struct IMediaEventEx : IMediaEventEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEventEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaEventEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaEventEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaEventEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IMediaEventEx, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IMediaEventEx, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<IMediaEventEx, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IMediaEventEx,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEventHandle([NativeTypeName("OAEVENT *")] nint* hEvent)
    {
        return ((delegate* unmanaged<IMediaEventEx, nint*, int>)((*lpVtbl)[7]))(this, hEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetEvent(
        [NativeTypeName("long *")] int* lEventCode,
        [NativeTypeName("LONG_PTR *")] nint* lParam1,
        [NativeTypeName("LONG_PTR *")] nint* lParam2,
        [NativeTypeName("long")] int msTimeout
    )
    {
        return ((delegate* unmanaged<IMediaEventEx, int*, nint*, nint*, int, int>)((*lpVtbl)[8]))(
            this,
            lEventCode,
            lParam1,
            lParam2,
            msTimeout
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WaitForCompletion(
        [NativeTypeName("long")] int msTimeout,
        [NativeTypeName("long *")] int* pEvCode
    )
    {
        return ((delegate* unmanaged<IMediaEventEx, int, int*, int>)((*lpVtbl)[9]))(
            this,
            msTimeout,
            pEvCode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CancelDefaultHandling([NativeTypeName("long")] int lEvCode)
    {
        return ((delegate* unmanaged<IMediaEventEx, int, int>)((*lpVtbl)[10]))(this, lEvCode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RestoreDefaultHandling([NativeTypeName("long")] int lEvCode)
    {
        return ((delegate* unmanaged<IMediaEventEx, int, int>)((*lpVtbl)[11]))(this, lEvCode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT FreeEventParams(
        [NativeTypeName("long")] int lEvCode,
        [NativeTypeName("LONG_PTR")] nint lParam1,
        [NativeTypeName("LONG_PTR")] nint lParam2
    )
    {
        return ((delegate* unmanaged<IMediaEventEx, int, nint, nint, int>)((*lpVtbl)[12]))(
            this,
            lEvCode,
            lParam1,
            lParam2
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetNotifyWindow(
        OAHWND hwnd,
        [NativeTypeName("long")] int lMsg,
        [NativeTypeName("LONG_PTR")] nint lInstanceData
    )
    {
        return ((delegate* unmanaged<IMediaEventEx, OAHWND, int, nint, int>)((*lpVtbl)[13]))(
            this,
            hwnd,
            lMsg,
            lInstanceData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetNotifyFlags([NativeTypeName("long")] int lNoNotifyFlags)
    {
        return ((delegate* unmanaged<IMediaEventEx, int, int>)((*lpVtbl)[14]))(
            this,
            lNoNotifyFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetNotifyFlags([NativeTypeName("long *")] int* lplNoNotifyFlags)
    {
        return ((delegate* unmanaged<IMediaEventEx, int*, int>)((*lpVtbl)[15]))(
            this,
            lplNoNotifyFlags
        );
    }

    public interface Interface : IMediaEvent.Interface
    {
        [VtblIndex(13)]
        HRESULT SetNotifyWindow(
            OAHWND hwnd,
            [NativeTypeName("long")] int lMsg,
            [NativeTypeName("LONG_PTR")] nint lInstanceData
        );

        [VtblIndex(14)]
        HRESULT SetNotifyFlags([NativeTypeName("long")] int lNoNotifyFlags);

        [VtblIndex(15)]
        HRESULT GetNotifyFlags([NativeTypeName("long *")] int* lplNoNotifyFlags);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (OAEVENT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nint*, int> GetEventHandle;

        [NativeTypeName("HRESULT (long *, LONG_PTR *, LONG_PTR *, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, nint*, nint*, int, int> GetEvent;

        [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> WaitForCompletion;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> CancelDefaultHandling;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> RestoreDefaultHandling;

        [NativeTypeName("HRESULT (long, LONG_PTR, LONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, nint, nint, int> FreeEventParams;

        [NativeTypeName("HRESULT (OAHWND, long, LONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, OAHWND, int, nint, int> SetNotifyWindow;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetNotifyFlags;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetNotifyFlags;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaEventEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaEventEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMediaEvent"/> to <see cref = "IMediaEventEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMediaEvent"/> instance to be converted </param>
    public static explicit operator IMediaEventEx(Silk.NET.Windows.IMediaEvent value)
    {
        return new IMediaEventEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaEventEx"/> to <see cref = "Silk.NET.Windows.IMediaEvent"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaEventEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMediaEvent(IMediaEventEx value)
    {
        return new Silk.NET.Windows.IMediaEvent(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IMediaEventEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IMediaEventEx(Silk.NET.Windows.IDispatch value)
    {
        return new IMediaEventEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaEventEx"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaEventEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IMediaEventEx value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaEventEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaEventEx(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaEventEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaEventEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaEventEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaEventEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
