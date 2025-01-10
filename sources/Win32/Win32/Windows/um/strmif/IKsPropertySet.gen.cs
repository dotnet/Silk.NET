// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("31EFAC30-515C-11D0-A9AA-00AA0061BE93")]
[NativeTypeName("struct IKsPropertySet : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IKsPropertySet : IKsPropertySet.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKsPropertySet));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKsPropertySet, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IKsPropertySet, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKsPropertySet, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Set(
        [NativeTypeName("const GUID &")] Guid* guidPropSet,
        [NativeTypeName("DWORD")] uint dwPropID,
        [NativeTypeName("LPVOID")] void* pInstanceData,
        [NativeTypeName("DWORD")] uint cbInstanceData,
        [NativeTypeName("LPVOID")] void* pPropData,
        [NativeTypeName("DWORD")] uint cbPropData
    )
    {
        return (
            (delegate* unmanaged<IKsPropertySet, Guid*, uint, void*, uint, void*, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, guidPropSet, dwPropID, pInstanceData, cbInstanceData, pPropData, cbPropData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Get(
        [NativeTypeName("const GUID &")] Guid* guidPropSet,
        [NativeTypeName("DWORD")] uint dwPropID,
        [NativeTypeName("LPVOID")] void* pInstanceData,
        [NativeTypeName("DWORD")] uint cbInstanceData,
        [NativeTypeName("LPVOID")] void* pPropData,
        [NativeTypeName("DWORD")] uint cbPropData,
        [NativeTypeName("DWORD *")] uint* pcbReturned
    )
    {
        return (
            (delegate* unmanaged<
                IKsPropertySet,
                Guid*,
                uint,
                void*,
                uint,
                void*,
                uint,
                uint*,
                int>)((*lpVtbl)[4])
        )(
            this,
            guidPropSet,
            dwPropID,
            pInstanceData,
            cbInstanceData,
            pPropData,
            cbPropData,
            pcbReturned
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT QuerySupported(
        [NativeTypeName("const GUID &")] Guid* guidPropSet,
        [NativeTypeName("DWORD")] uint dwPropID,
        [NativeTypeName("DWORD *")] uint* pTypeSupport
    )
    {
        return ((delegate* unmanaged<IKsPropertySet, Guid*, uint, uint*, int>)((*lpVtbl)[5]))(
            this,
            guidPropSet,
            dwPropID,
            pTypeSupport
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Set(
            [NativeTypeName("const GUID &")] Guid* guidPropSet,
            [NativeTypeName("DWORD")] uint dwPropID,
            [NativeTypeName("LPVOID")] void* pInstanceData,
            [NativeTypeName("DWORD")] uint cbInstanceData,
            [NativeTypeName("LPVOID")] void* pPropData,
            [NativeTypeName("DWORD")] uint cbPropData
        );

        [VtblIndex(4)]
        HRESULT Get(
            [NativeTypeName("const GUID &")] Guid* guidPropSet,
            [NativeTypeName("DWORD")] uint dwPropID,
            [NativeTypeName("LPVOID")] void* pInstanceData,
            [NativeTypeName("DWORD")] uint cbInstanceData,
            [NativeTypeName("LPVOID")] void* pPropData,
            [NativeTypeName("DWORD")] uint cbPropData,
            [NativeTypeName("DWORD *")] uint* pcbReturned
        );

        [VtblIndex(5)]
        HRESULT QuerySupported(
            [NativeTypeName("const GUID &")] Guid* guidPropSet,
            [NativeTypeName("DWORD")] uint dwPropID,
            [NativeTypeName("DWORD *")] uint* pTypeSupport
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

        [NativeTypeName(
            "HRESULT (const GUID &, DWORD, LPVOID, DWORD, LPVOID, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, uint, void*, uint, int> Set;

        [NativeTypeName(
            "HRESULT (const GUID &, DWORD, LPVOID, DWORD, LPVOID, DWORD, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, uint, void*, uint, uint*, int> Get;

        [NativeTypeName("HRESULT (const GUID &, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, uint*, int> QuerySupported;
    }

    /// <summary>Initializes a new instance of the <see cref = "IKsPropertySet"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IKsPropertySet(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IKsPropertySet"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IKsPropertySet(Silk.NET.Windows.IUnknown value)
    {
        return new IKsPropertySet(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKsPropertySet"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IKsPropertySet"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IKsPropertySet value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
