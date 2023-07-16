// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IKsPropertySet.xml' path='doc/member[@name="IKsPropertySet"]/*'/>
[Guid("31EFAC30-515C-11D0-A9AA-00AA0061BE93")]
[NativeTypeName("struct IKsPropertySet : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IKsPropertySet : IKsPropertySet.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKsPropertySet));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKsPropertySet*, Guid*, void**, int> )(lpVtbl[0]))((IKsPropertySet*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IKsPropertySet*, uint> )(lpVtbl[1]))((IKsPropertySet*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKsPropertySet*, uint> )(lpVtbl[2]))((IKsPropertySet*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IKsPropertySet.xml' path='doc/member[@name="IKsPropertySet.Set"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Set([NativeTypeName("const GUID &")] Guid* guidPropSet, [NativeTypeName("DWORD")] uint dwPropID, [NativeTypeName("LPVOID")] void* pInstanceData, [NativeTypeName("DWORD")] uint cbInstanceData, [NativeTypeName("LPVOID")] void* pPropData, [NativeTypeName("DWORD")] uint cbPropData)
    {
        return ((delegate* unmanaged<IKsPropertySet*, Guid*, uint, void*, uint, void*, uint, int> )(lpVtbl[3]))((IKsPropertySet*)Unsafe.AsPointer(ref this), guidPropSet, dwPropID, pInstanceData, cbInstanceData, pPropData, cbPropData);
    }

    /// <include file='IKsPropertySet.xml' path='doc/member[@name="IKsPropertySet.Get"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Get([NativeTypeName("const GUID &")] Guid* guidPropSet, [NativeTypeName("DWORD")] uint dwPropID, [NativeTypeName("LPVOID")] void* pInstanceData, [NativeTypeName("DWORD")] uint cbInstanceData, [NativeTypeName("LPVOID")] void* pPropData, [NativeTypeName("DWORD")] uint cbPropData, [NativeTypeName("DWORD *")] uint* pcbReturned)
    {
        return ((delegate* unmanaged<IKsPropertySet*, Guid*, uint, void*, uint, void*, uint, uint*, int> )(lpVtbl[4]))((IKsPropertySet*)Unsafe.AsPointer(ref this), guidPropSet, dwPropID, pInstanceData, cbInstanceData, pPropData, cbPropData, pcbReturned);
    }

    /// <include file='IKsPropertySet.xml' path='doc/member[@name="IKsPropertySet.QuerySupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT QuerySupported([NativeTypeName("const GUID &")] Guid* guidPropSet, [NativeTypeName("DWORD")] uint dwPropID, [NativeTypeName("DWORD *")] uint* pTypeSupport)
    {
        return ((delegate* unmanaged<IKsPropertySet*, Guid*, uint, uint*, int> )(lpVtbl[5]))((IKsPropertySet*)Unsafe.AsPointer(ref this), guidPropSet, dwPropID, pTypeSupport);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Set([NativeTypeName("const GUID &")] Guid* guidPropSet, [NativeTypeName("DWORD")] uint dwPropID, [NativeTypeName("LPVOID")] void* pInstanceData, [NativeTypeName("DWORD")] uint cbInstanceData, [NativeTypeName("LPVOID")] void* pPropData, [NativeTypeName("DWORD")] uint cbPropData);
        [VtblIndex(4)]
        HRESULT Get([NativeTypeName("const GUID &")] Guid* guidPropSet, [NativeTypeName("DWORD")] uint dwPropID, [NativeTypeName("LPVOID")] void* pInstanceData, [NativeTypeName("DWORD")] uint cbInstanceData, [NativeTypeName("LPVOID")] void* pPropData, [NativeTypeName("DWORD")] uint cbPropData, [NativeTypeName("DWORD *")] uint* pcbReturned);
        [VtblIndex(5)]
        HRESULT QuerySupported([NativeTypeName("const GUID &")] Guid* guidPropSet, [NativeTypeName("DWORD")] uint dwPropID, [NativeTypeName("DWORD *")] uint* pTypeSupport);
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
        [NativeTypeName("HRESULT (const GUID &, DWORD, LPVOID, DWORD, LPVOID, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, uint, void*, uint, int> Set;
        [NativeTypeName("HRESULT (const GUID &, DWORD, LPVOID, DWORD, LPVOID, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, uint, void*, uint, uint*, int> Get;
        [NativeTypeName("HRESULT (const GUID &, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, uint*, int> QuerySupported;
    }
}