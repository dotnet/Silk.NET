// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IOleUndoManager.xml' path='doc/member[@name="IOleUndoManager"]/*' />
[Guid("D001F200-EF97-11CE-9BC9-00AA00608E01")]
[NativeTypeName("struct IOleUndoManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleUndoManager : IOleUndoManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleUndoManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleUndoManager*, Guid*, void**, int>)(lpVtbl[0]))((IOleUndoManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleUndoManager*, uint>)(lpVtbl[1]))((IOleUndoManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleUndoManager*, uint>)(lpVtbl[2]))((IOleUndoManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleUndoManager.xml' path='doc/member[@name="IOleUndoManager.Open"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Open(IOleParentUndoUnit* pPUU)
    {
        return ((delegate* unmanaged<IOleUndoManager*, IOleParentUndoUnit*, int>)(lpVtbl[3]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pPUU);
    }

    /// <include file='IOleUndoManager.xml' path='doc/member[@name="IOleUndoManager.Close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Close(IOleParentUndoUnit* pPUU, BOOL fCommit)
    {
        return ((delegate* unmanaged<IOleUndoManager*, IOleParentUndoUnit*, BOOL, int>)(lpVtbl[4]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pPUU, fCommit);
    }

    /// <include file='IOleUndoManager.xml' path='doc/member[@name="IOleUndoManager.Add"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Add(IOleUndoUnit* pUU)
    {
        return ((delegate* unmanaged<IOleUndoManager*, IOleUndoUnit*, int>)(lpVtbl[5]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
    }

    /// <include file='IOleUndoManager.xml' path='doc/member[@name="IOleUndoManager.GetOpenParentState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetOpenParentState([NativeTypeName("DWORD *")] uint* pdwState)
    {
        return ((delegate* unmanaged<IOleUndoManager*, uint*, int>)(lpVtbl[6]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pdwState);
    }

    /// <include file='IOleUndoManager.xml' path='doc/member[@name="IOleUndoManager.DiscardFrom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DiscardFrom(IOleUndoUnit* pUU)
    {
        return ((delegate* unmanaged<IOleUndoManager*, IOleUndoUnit*, int>)(lpVtbl[7]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
    }

    /// <include file='IOleUndoManager.xml' path='doc/member[@name="IOleUndoManager.UndoTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UndoTo(IOleUndoUnit* pUU)
    {
        return ((delegate* unmanaged<IOleUndoManager*, IOleUndoUnit*, int>)(lpVtbl[8]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
    }

    /// <include file='IOleUndoManager.xml' path='doc/member[@name="IOleUndoManager.RedoTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RedoTo(IOleUndoUnit* pUU)
    {
        return ((delegate* unmanaged<IOleUndoManager*, IOleUndoUnit*, int>)(lpVtbl[9]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
    }

    /// <include file='IOleUndoManager.xml' path='doc/member[@name="IOleUndoManager.EnumUndoable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EnumUndoable(IEnumOleUndoUnits** ppEnum)
    {
        return ((delegate* unmanaged<IOleUndoManager*, IEnumOleUndoUnits**, int>)(lpVtbl[10]))((IOleUndoManager*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IOleUndoManager.xml' path='doc/member[@name="IOleUndoManager.EnumRedoable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EnumRedoable(IEnumOleUndoUnits** ppEnum)
    {
        return ((delegate* unmanaged<IOleUndoManager*, IEnumOleUndoUnits**, int>)(lpVtbl[11]))((IOleUndoManager*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IOleUndoManager.xml' path='doc/member[@name="IOleUndoManager.GetLastUndoDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetLastUndoDescription([NativeTypeName("BSTR *")] ushort** pBstr)
    {
        return ((delegate* unmanaged<IOleUndoManager*, ushort**, int>)(lpVtbl[12]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pBstr);
    }

    /// <include file='IOleUndoManager.xml' path='doc/member[@name="IOleUndoManager.GetLastRedoDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetLastRedoDescription([NativeTypeName("BSTR *")] ushort** pBstr)
    {
        return ((delegate* unmanaged<IOleUndoManager*, ushort**, int>)(lpVtbl[13]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pBstr);
    }

    /// <include file='IOleUndoManager.xml' path='doc/member[@name="IOleUndoManager.Enable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Enable(BOOL fEnable)
    {
        return ((delegate* unmanaged<IOleUndoManager*, BOOL, int>)(lpVtbl[14]))((IOleUndoManager*)Unsafe.AsPointer(ref this), fEnable);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Open(IOleParentUndoUnit* pPUU);

        [VtblIndex(4)]
        HRESULT Close(IOleParentUndoUnit* pPUU, BOOL fCommit);

        [VtblIndex(5)]
        HRESULT Add(IOleUndoUnit* pUU);

        [VtblIndex(6)]
        HRESULT GetOpenParentState([NativeTypeName("DWORD *")] uint* pdwState);

        [VtblIndex(7)]
        HRESULT DiscardFrom(IOleUndoUnit* pUU);

        [VtblIndex(8)]
        HRESULT UndoTo(IOleUndoUnit* pUU);

        [VtblIndex(9)]
        HRESULT RedoTo(IOleUndoUnit* pUU);

        [VtblIndex(10)]
        HRESULT EnumUndoable(IEnumOleUndoUnits** ppEnum);

        [VtblIndex(11)]
        HRESULT EnumRedoable(IEnumOleUndoUnits** ppEnum);

        [VtblIndex(12)]
        HRESULT GetLastUndoDescription([NativeTypeName("BSTR *")] ushort** pBstr);

        [VtblIndex(13)]
        HRESULT GetLastRedoDescription([NativeTypeName("BSTR *")] ushort** pBstr);

        [VtblIndex(14)]
        HRESULT Enable(BOOL fEnable);
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

        [NativeTypeName("HRESULT (IOleParentUndoUnit *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleParentUndoUnit*, int> Open;

        [NativeTypeName("HRESULT (IOleParentUndoUnit *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleParentUndoUnit*, BOOL, int> Close;

        [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleUndoUnit*, int> Add;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOpenParentState;

        [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleUndoUnit*, int> DiscardFrom;

        [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleUndoUnit*, int> UndoTo;

        [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleUndoUnit*, int> RedoTo;

        [NativeTypeName("HRESULT (IEnumOleUndoUnits **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumOleUndoUnits**, int> EnumUndoable;

        [NativeTypeName("HRESULT (IEnumOleUndoUnits **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumOleUndoUnits**, int> EnumRedoable;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetLastUndoDescription;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetLastRedoDescription;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Enable;
    }
}
