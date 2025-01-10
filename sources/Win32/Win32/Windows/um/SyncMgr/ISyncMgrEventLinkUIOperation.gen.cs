// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("64522E52-848B-4015-89CE-5A36F00B94FF")]
[NativeTypeName("struct ISyncMgrEventLinkUIOperation : ISyncMgrUIOperation")]
[NativeInheritance("ISyncMgrUIOperation")]
public unsafe partial struct ISyncMgrEventLinkUIOperation
    : ISyncMgrEventLinkUIOperation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrEventLinkUIOperation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISyncMgrEventLinkUIOperation, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Run(HWND hwndOwner)
    {
        return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation, HWND, int>)((*lpVtbl)[3]))(
            this,
            hwndOwner
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Init([NativeTypeName("const GUID &")] Guid* rguidEventID, ISyncMgrEvent pEvent)
    {
        return (
            (delegate* unmanaged<ISyncMgrEventLinkUIOperation, Guid*, ISyncMgrEvent, int>)(
                (*lpVtbl)[4]
            )
        )(this, rguidEventID, pEvent);
    }

    public interface Interface : ISyncMgrUIOperation.Interface
    {
        [VtblIndex(4)]
        HRESULT Init([NativeTypeName("const GUID &")] Guid* rguidEventID, ISyncMgrEvent pEvent);
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

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> Run;

        [NativeTypeName("HRESULT (const GUID &, ISyncMgrEvent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ISyncMgrEvent, int> Init;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISyncMgrEventLinkUIOperation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISyncMgrEventLinkUIOperation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISyncMgrUIOperation"/> to <see cref = "ISyncMgrEventLinkUIOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISyncMgrUIOperation"/> instance to be converted </param>
    public static explicit operator ISyncMgrEventLinkUIOperation(
        Silk.NET.Windows.ISyncMgrUIOperation value
    )
    {
        return new ISyncMgrEventLinkUIOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrEventLinkUIOperation"/> to <see cref = "Silk.NET.Windows.ISyncMgrUIOperation"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrEventLinkUIOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISyncMgrUIOperation(
        ISyncMgrEventLinkUIOperation value
    )
    {
        return new Silk.NET.Windows.ISyncMgrUIOperation(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISyncMgrEventLinkUIOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISyncMgrEventLinkUIOperation(Silk.NET.Windows.IUnknown value)
    {
        return new ISyncMgrEventLinkUIOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrEventLinkUIOperation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrEventLinkUIOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISyncMgrEventLinkUIOperation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
