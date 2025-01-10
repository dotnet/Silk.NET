// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("04EC2E43-AC77-49F9-9B98-0307EF7A72A2")]
[NativeTypeName("struct ISyncMgrHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrHandler : ISyncMgrHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrHandler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISyncMgrHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<ISyncMgrHandler, ushort**, int>)((*lpVtbl)[3]))(
            this,
            ppszName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHandlerInfo(ISyncMgrHandlerInfo* ppHandlerInfo)
    {
        return ((delegate* unmanaged<ISyncMgrHandler, ISyncMgrHandlerInfo*, int>)((*lpVtbl)[4]))(
            this,
            ppHandlerInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetObjectW(
        [NativeTypeName("const GUID &")] Guid* rguidObjectID,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return ((delegate* unmanaged<ISyncMgrHandler, Guid*, Guid*, void**, int>)((*lpVtbl)[5]))(
            this,
            rguidObjectID,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCapabilities(SYNCMGR_HANDLER_CAPABILITIES* pmCapabilities)
    {
        return (
            (delegate* unmanaged<ISyncMgrHandler, SYNCMGR_HANDLER_CAPABILITIES*, int>)((*lpVtbl)[6])
        )(this, pmCapabilities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPolicies(SYNCMGR_HANDLER_POLICIES* pmPolicies)
    {
        return (
            (delegate* unmanaged<ISyncMgrHandler, SYNCMGR_HANDLER_POLICIES*, int>)((*lpVtbl)[7])
        )(this, pmPolicies);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Activate(BOOL fActivate)
    {
        return ((delegate* unmanaged<ISyncMgrHandler, BOOL, int>)((*lpVtbl)[8]))(this, fActivate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Enable(BOOL fEnable)
    {
        return ((delegate* unmanaged<ISyncMgrHandler, BOOL, int>)((*lpVtbl)[9]))(this, fEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Synchronize(
        [NativeTypeName("LPCWSTR *")] ushort** ppszItemIDs,
        [NativeTypeName("ULONG")] uint cItems,
        HWND hwndOwner,
        ISyncMgrSessionCreator pSessionCreator,
        IUnknown punk
    )
    {
        return (
            (delegate* unmanaged<
                ISyncMgrHandler,
                ushort**,
                uint,
                HWND,
                ISyncMgrSessionCreator,
                IUnknown,
                int>)((*lpVtbl)[10])
        )(this, ppszItemIDs, cItems, hwndOwner, pSessionCreator, punk);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppszName);

        [VtblIndex(4)]
        HRESULT GetHandlerInfo(ISyncMgrHandlerInfo* ppHandlerInfo);

        [VtblIndex(5)]
        HRESULT GetObjectW(
            [NativeTypeName("const GUID &")] Guid* rguidObjectID,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(6)]
        HRESULT GetCapabilities(SYNCMGR_HANDLER_CAPABILITIES* pmCapabilities);

        [VtblIndex(7)]
        HRESULT GetPolicies(SYNCMGR_HANDLER_POLICIES* pmPolicies);

        [VtblIndex(8)]
        HRESULT Activate(BOOL fActivate);

        [VtblIndex(9)]
        HRESULT Enable(BOOL fEnable);

        [VtblIndex(10)]
        HRESULT Synchronize(
            [NativeTypeName("LPCWSTR *")] ushort** ppszItemIDs,
            [NativeTypeName("ULONG")] uint cItems,
            HWND hwndOwner,
            ISyncMgrSessionCreator pSessionCreator,
            IUnknown punk
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;

        [NativeTypeName("HRESULT (ISyncMgrHandlerInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISyncMgrHandlerInfo*, int> GetHandlerInfo;

        [NativeTypeName("HRESULT (const GUID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> GetObjectW;

        [NativeTypeName("HRESULT (SYNCMGR_HANDLER_CAPABILITIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGR_HANDLER_CAPABILITIES*, int> GetCapabilities;

        [NativeTypeName("HRESULT (SYNCMGR_HANDLER_POLICIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGR_HANDLER_POLICIES*, int> GetPolicies;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Activate;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Enable;

        [NativeTypeName(
            "HRESULT (LPCWSTR *, ULONG, HWND, ISyncMgrSessionCreator *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort**,
            uint,
            HWND,
            ISyncMgrSessionCreator,
            IUnknown,
            int> Synchronize;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISyncMgrHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISyncMgrHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISyncMgrHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISyncMgrHandler(Silk.NET.Windows.IUnknown value)
    {
        return new ISyncMgrHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISyncMgrHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
