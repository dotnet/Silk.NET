// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISyncMgrEvent.xml' path='doc/member[@name="ISyncMgrEvent"]/*'/>
[Guid("FEE0EF8B-46BD-4DB4-B7E6-FF2C687313BC")]
[NativeTypeName("struct ISyncMgrEvent : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrEvent : ISyncMgrEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrEvent));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, Guid*, void**, int> )(lpVtbl[0]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, uint> )(lpVtbl[1]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, uint> )(lpVtbl[2]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrEvent.xml' path='doc/member[@name="ISyncMgrEvent.GetEventID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEventID(Guid* pguidEventID)
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, Guid*, int> )(lpVtbl[3]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), pguidEventID);
    }

    /// <include file='ISyncMgrEvent.xml' path='doc/member[@name="ISyncMgrEvent.GetHandlerID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHandlerID([NativeTypeName("LPWSTR *")] ushort** ppszHandlerID)
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int> )(lpVtbl[4]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszHandlerID);
    }

    /// <include file='ISyncMgrEvent.xml' path='doc/member[@name="ISyncMgrEvent.GetItemID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetItemID([NativeTypeName("LPWSTR *")] ushort** ppszItemID)
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int> )(lpVtbl[5]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszItemID);
    }

    /// <include file='ISyncMgrEvent.xml' path='doc/member[@name="ISyncMgrEvent.GetLevel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetLevel(SYNCMGR_EVENT_LEVEL* pnLevel)
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, SYNCMGR_EVENT_LEVEL*, int> )(lpVtbl[6]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), pnLevel);
    }

    /// <include file='ISyncMgrEvent.xml' path='doc/member[@name="ISyncMgrEvent.GetFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFlags(SYNCMGR_EVENT_FLAGS* pnFlags)
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, SYNCMGR_EVENT_FLAGS*, int> )(lpVtbl[7]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), pnFlags);
    }

    /// <include file='ISyncMgrEvent.xml' path='doc/member[@name="ISyncMgrEvent.GetTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTime(FILETIME* pfCreationTime)
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, FILETIME*, int> )(lpVtbl[8]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), pfCreationTime);
    }

    /// <include file='ISyncMgrEvent.xml' path='doc/member[@name="ISyncMgrEvent.GetName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int> )(lpVtbl[9]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszName);
    }

    /// <include file='ISyncMgrEvent.xml' path='doc/member[@name="ISyncMgrEvent.GetDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDescription([NativeTypeName("LPWSTR *")] ushort** ppszDescription)
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int> )(lpVtbl[10]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszDescription);
    }

    /// <include file='ISyncMgrEvent.xml' path='doc/member[@name="ISyncMgrEvent.GetLinkText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetLinkText([NativeTypeName("LPWSTR *")] ushort** ppszLinkText)
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int> )(lpVtbl[11]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszLinkText);
    }

    /// <include file='ISyncMgrEvent.xml' path='doc/member[@name="ISyncMgrEvent.GetLinkReference"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetLinkReference([NativeTypeName("LPWSTR *")] ushort** ppszLinkReference)
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int> )(lpVtbl[12]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszLinkReference);
    }

    /// <include file='ISyncMgrEvent.xml' path='doc/member[@name="ISyncMgrEvent.GetContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetContext([NativeTypeName("LPWSTR *")] ushort** ppszContext)
    {
        return ((delegate* unmanaged<ISyncMgrEvent*, ushort**, int> )(lpVtbl[13]))((ISyncMgrEvent*)Unsafe.AsPointer(ref this), ppszContext);
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
}