// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FEE0EF8B-46BD-4DB4-B7E6-FF2C687313BC")]
[NativeTypeName("struct ISyncMgrEvent : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrEvent : ISyncMgrEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrEvent));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrEvent, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISyncMgrEvent, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrEvent, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEventID(Guid* pguidEventID)
    {
        return ((delegate* unmanaged<ISyncMgrEvent, Guid*, int>)((*lpVtbl)[3]))(this, pguidEventID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHandlerID([NativeTypeName("LPWSTR *")] ushort** ppszHandlerID)
    {
        return ((delegate* unmanaged<ISyncMgrEvent, ushort**, int>)((*lpVtbl)[4]))(
            this,
            ppszHandlerID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetItemID([NativeTypeName("LPWSTR *")] ushort** ppszItemID)
    {
        return ((delegate* unmanaged<ISyncMgrEvent, ushort**, int>)((*lpVtbl)[5]))(
            this,
            ppszItemID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetLevel(SYNCMGR_EVENT_LEVEL* pnLevel)
    {
        return ((delegate* unmanaged<ISyncMgrEvent, SYNCMGR_EVENT_LEVEL*, int>)((*lpVtbl)[6]))(
            this,
            pnLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFlags(SYNCMGR_EVENT_FLAGS* pnFlags)
    {
        return ((delegate* unmanaged<ISyncMgrEvent, SYNCMGR_EVENT_FLAGS*, int>)((*lpVtbl)[7]))(
            this,
            pnFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTime(FILETIME* pfCreationTime)
    {
        return ((delegate* unmanaged<ISyncMgrEvent, FILETIME*, int>)((*lpVtbl)[8]))(
            this,
            pfCreationTime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<ISyncMgrEvent, ushort**, int>)((*lpVtbl)[9]))(this, ppszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDescription([NativeTypeName("LPWSTR *")] ushort** ppszDescription)
    {
        return ((delegate* unmanaged<ISyncMgrEvent, ushort**, int>)((*lpVtbl)[10]))(
            this,
            ppszDescription
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetLinkText([NativeTypeName("LPWSTR *")] ushort** ppszLinkText)
    {
        return ((delegate* unmanaged<ISyncMgrEvent, ushort**, int>)((*lpVtbl)[11]))(
            this,
            ppszLinkText
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetLinkReference([NativeTypeName("LPWSTR *")] ushort** ppszLinkReference)
    {
        return ((delegate* unmanaged<ISyncMgrEvent, ushort**, int>)((*lpVtbl)[12]))(
            this,
            ppszLinkReference
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetContext([NativeTypeName("LPWSTR *")] ushort** ppszContext)
    {
        return ((delegate* unmanaged<ISyncMgrEvent, ushort**, int>)((*lpVtbl)[13]))(
            this,
            ppszContext
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetEventID(Guid* pguidEventID);

        [VtblIndex(4)]
        HRESULT GetHandlerID([NativeTypeName("LPWSTR *")] ushort** ppszHandlerID);

        [VtblIndex(5)]
        HRESULT GetItemID([NativeTypeName("LPWSTR *")] ushort** ppszItemID);

        [VtblIndex(6)]
        HRESULT GetLevel(SYNCMGR_EVENT_LEVEL* pnLevel);

        [VtblIndex(7)]
        HRESULT GetFlags(SYNCMGR_EVENT_FLAGS* pnFlags);

        [VtblIndex(8)]
        HRESULT GetTime(FILETIME* pfCreationTime);

        [VtblIndex(9)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppszName);

        [VtblIndex(10)]
        HRESULT GetDescription([NativeTypeName("LPWSTR *")] ushort** ppszDescription);

        [VtblIndex(11)]
        HRESULT GetLinkText([NativeTypeName("LPWSTR *")] ushort** ppszLinkText);

        [VtblIndex(12)]
        HRESULT GetLinkReference([NativeTypeName("LPWSTR *")] ushort** ppszLinkReference);

        [VtblIndex(13)]
        HRESULT GetContext([NativeTypeName("LPWSTR *")] ushort** ppszContext);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetEventID;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetHandlerID;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetItemID;

        [NativeTypeName("HRESULT (SYNCMGR_EVENT_LEVEL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGR_EVENT_LEVEL*, int> GetLevel;

        [NativeTypeName("HRESULT (SYNCMGR_EVENT_FLAGS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGR_EVENT_FLAGS*, int> GetFlags;

        [NativeTypeName("HRESULT (FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FILETIME*, int> GetTime;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetLinkText;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetLinkReference;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetContext;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISyncMgrEvent"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISyncMgrEvent(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISyncMgrEvent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISyncMgrEvent(Silk.NET.Windows.IUnknown value)
    {
        return new ISyncMgrEvent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrEvent"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrEvent"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISyncMgrEvent value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
