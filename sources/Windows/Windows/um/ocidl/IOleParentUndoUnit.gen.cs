// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IOleParentUndoUnit.xml' path='doc/member[@name="IOleParentUndoUnit"]/*' />
[Guid("A1FAF330-EF97-11CE-9BC9-00AA00608E01")]
[NativeTypeName("struct IOleParentUndoUnit : IOleUndoUnit")]
[NativeInheritance("IOleUndoUnit")]
public unsafe partial struct IOleParentUndoUnit : IOleParentUndoUnit.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleParentUndoUnit));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit*, Guid*, void**, int>)(lpVtbl[0]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleParentUndoUnit*, uint>)(lpVtbl[1]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleParentUndoUnit*, uint>)(lpVtbl[2]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IOleUndoUnit.Do" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Do(IOleUndoManager* pUndoManager)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit*, IOleUndoManager*, int>)(lpVtbl[3]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pUndoManager);
    }

    /// <inheritdoc cref="IOleUndoUnit.GetDescription" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pBstr)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit*, ushort**, int>)(lpVtbl[4]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pBstr);
    }

    /// <inheritdoc cref="IOleUndoUnit.GetUnitType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetUnitType([NativeTypeName("CLSID *")] Guid* pClsid, [NativeTypeName("LONG *")] int* plID)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit*, Guid*, int*, int>)(lpVtbl[5]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pClsid, plID);
    }

    /// <inheritdoc cref="IOleUndoUnit.OnNextAdd" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnNextAdd()
    {
        return ((delegate* unmanaged<IOleParentUndoUnit*, int>)(lpVtbl[6]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleParentUndoUnit.xml' path='doc/member[@name="IOleParentUndoUnit.Open"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Open(IOleParentUndoUnit* pPUU)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit*, IOleParentUndoUnit*, int>)(lpVtbl[7]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pPUU);
    }

    /// <include file='IOleParentUndoUnit.xml' path='doc/member[@name="IOleParentUndoUnit.Close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Close(IOleParentUndoUnit* pPUU, BOOL fCommit)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit*, IOleParentUndoUnit*, BOOL, int>)(lpVtbl[8]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pPUU, fCommit);
    }

    /// <include file='IOleParentUndoUnit.xml' path='doc/member[@name="IOleParentUndoUnit.Add"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Add(IOleUndoUnit* pUU)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit*, IOleUndoUnit*, int>)(lpVtbl[9]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pUU);
    }

    /// <include file='IOleParentUndoUnit.xml' path='doc/member[@name="IOleParentUndoUnit.FindUnit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindUnit(IOleUndoUnit* pUU)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit*, IOleUndoUnit*, int>)(lpVtbl[10]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pUU);
    }

    /// <include file='IOleParentUndoUnit.xml' path='doc/member[@name="IOleParentUndoUnit.GetParentState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetParentState([NativeTypeName("DWORD *")] uint* pdwState)
    {
        return ((delegate* unmanaged<IOleParentUndoUnit*, uint*, int>)(lpVtbl[11]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pdwState);
    }

    public interface Interface : IOleUndoUnit.Interface
    {
        [VtblIndex(7)]
        HRESULT Open(IOleParentUndoUnit* pPUU);

        [VtblIndex(8)]
        HRESULT Close(IOleParentUndoUnit* pPUU, BOOL fCommit);

        [VtblIndex(9)]
        HRESULT Add(IOleUndoUnit* pUU);

        [VtblIndex(10)]
        HRESULT FindUnit(IOleUndoUnit* pUU);

        [VtblIndex(11)]
        HRESULT GetParentState([NativeTypeName("DWORD *")] uint* pdwState);
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

        [NativeTypeName("HRESULT (IOleUndoManager *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleUndoManager*, int> Do;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (CLSID *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int*, int> GetUnitType;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnNextAdd;

        [NativeTypeName("HRESULT (IOleParentUndoUnit *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleParentUndoUnit*, int> Open;

        [NativeTypeName("HRESULT (IOleParentUndoUnit *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleParentUndoUnit*, BOOL, int> Close;

        [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleUndoUnit*, int> Add;

        [NativeTypeName("HRESULT (IOleUndoUnit *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleUndoUnit*, int> FindUnit;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetParentState;
    }
}
