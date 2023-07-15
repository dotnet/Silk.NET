// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMediaEventEx.xml' path='doc/member[@name="IMediaEventEx"]/*'/>
[Guid("56A868C0-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IMediaEventEx : IMediaEvent")]
[NativeInheritance("IMediaEvent")]
public unsafe partial struct IMediaEventEx : IMediaEventEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEventEx));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaEventEx*, Guid*, void**, int> )(lpVtbl[0]))((IMediaEventEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaEventEx*, uint> )(lpVtbl[1]))((IMediaEventEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaEventEx*, uint> )(lpVtbl[2]))((IMediaEventEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IMediaEventEx*, uint*, int> )(lpVtbl[3]))((IMediaEventEx*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IMediaEventEx*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IMediaEventEx*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IMediaEventEx*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IMediaEventEx*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IMediaEventEx*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IMediaEventEx*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "IMediaEvent.GetEventHandle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEventHandle([NativeTypeName("OAEVENT *")] nint* hEvent)
    {
        return ((delegate* unmanaged<IMediaEventEx*, nint*, int> )(lpVtbl[7]))((IMediaEventEx*)Unsafe.AsPointer(ref this), hEvent);
    }

    /// <inheritdoc cref = "IMediaEvent.GetEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetEvent([NativeTypeName("long *")] int* lEventCode, [NativeTypeName("LONG_PTR *")] nint* lParam1, [NativeTypeName("LONG_PTR *")] nint* lParam2, [NativeTypeName("long")] int msTimeout)
    {
        return ((delegate* unmanaged<IMediaEventEx*, int*, nint*, nint*, int, int> )(lpVtbl[8]))((IMediaEventEx*)Unsafe.AsPointer(ref this), lEventCode, lParam1, lParam2, msTimeout);
    }

    /// <inheritdoc cref = "IMediaEvent.WaitForCompletion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WaitForCompletion([NativeTypeName("long")] int msTimeout, [NativeTypeName("long *")] int* pEvCode)
    {
        return ((delegate* unmanaged<IMediaEventEx*, int, int*, int> )(lpVtbl[9]))((IMediaEventEx*)Unsafe.AsPointer(ref this), msTimeout, pEvCode);
    }

    /// <inheritdoc cref = "IMediaEvent.CancelDefaultHandling"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CancelDefaultHandling([NativeTypeName("long")] int lEvCode)
    {
        return ((delegate* unmanaged<IMediaEventEx*, int, int> )(lpVtbl[10]))((IMediaEventEx*)Unsafe.AsPointer(ref this), lEvCode);
    }

    /// <inheritdoc cref = "IMediaEvent.RestoreDefaultHandling"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RestoreDefaultHandling([NativeTypeName("long")] int lEvCode)
    {
        return ((delegate* unmanaged<IMediaEventEx*, int, int> )(lpVtbl[11]))((IMediaEventEx*)Unsafe.AsPointer(ref this), lEvCode);
    }

    /// <inheritdoc cref = "IMediaEvent.FreeEventParams"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT FreeEventParams([NativeTypeName("long")] int lEvCode, [NativeTypeName("LONG_PTR")] nint lParam1, [NativeTypeName("LONG_PTR")] nint lParam2)
    {
        return ((delegate* unmanaged<IMediaEventEx*, int, nint, nint, int> )(lpVtbl[12]))((IMediaEventEx*)Unsafe.AsPointer(ref this), lEvCode, lParam1, lParam2);
    }

    /// <include file='IMediaEventEx.xml' path='doc/member[@name="IMediaEventEx.SetNotifyWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetNotifyWindow(OAHWND hwnd, [NativeTypeName("long")] int lMsg, [NativeTypeName("LONG_PTR")] nint lInstanceData)
    {
        return ((delegate* unmanaged<IMediaEventEx*, OAHWND, int, nint, int> )(lpVtbl[13]))((IMediaEventEx*)Unsafe.AsPointer(ref this), hwnd, lMsg, lInstanceData);
    }

    /// <include file='IMediaEventEx.xml' path='doc/member[@name="IMediaEventEx.SetNotifyFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetNotifyFlags([NativeTypeName("long")] int lNoNotifyFlags)
    {
        return ((delegate* unmanaged<IMediaEventEx*, int, int> )(lpVtbl[14]))((IMediaEventEx*)Unsafe.AsPointer(ref this), lNoNotifyFlags);
    }

    /// <include file='IMediaEventEx.xml' path='doc/member[@name="IMediaEventEx.GetNotifyFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetNotifyFlags([NativeTypeName("long *")] int* lplNoNotifyFlags)
    {
        return ((delegate* unmanaged<IMediaEventEx*, int*, int> )(lpVtbl[15]))((IMediaEventEx*)Unsafe.AsPointer(ref this), lplNoNotifyFlags);
    }

    public interface Interface : IMediaEvent.Interface
    {
        [VtblIndex(13)]
        HRESULT SetNotifyWindow(OAHWND hwnd, [NativeTypeName("long")] int lMsg, [NativeTypeName("LONG_PTR")] nint lInstanceData);
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
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
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
}