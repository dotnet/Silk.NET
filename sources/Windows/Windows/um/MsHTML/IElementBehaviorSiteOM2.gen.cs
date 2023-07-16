// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IElementBehaviorSiteOM2.xml' path='doc/member[@name="IElementBehaviorSiteOM2"]/*'/>
[Guid("3050F659-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehaviorSiteOM2 : IElementBehaviorSiteOM")]
[NativeInheritance("IElementBehaviorSiteOM")]
public unsafe partial struct IElementBehaviorSiteOM2 : IElementBehaviorSiteOM2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementBehaviorSiteOM2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM2*, Guid*, void**, int> )(lpVtbl[0]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM2*, uint> )(lpVtbl[1]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM2*, uint> )(lpVtbl[2]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IElementBehaviorSiteOM.RegisterEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterEvent([NativeTypeName("LPOLESTR")] ushort* pchEvent, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG *")] int* plCookie)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int, int*, int> )(lpVtbl[3]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), pchEvent, lFlags, plCookie);
    }

    /// <inheritdoc cref = "IElementBehaviorSiteOM.GetEventCookie"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEventCookie([NativeTypeName("LPOLESTR")] ushort* pchEvent, [NativeTypeName("LONG *")] int* plCookie)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int*, int> )(lpVtbl[4]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), pchEvent, plCookie);
    }

    /// <inheritdoc cref = "IElementBehaviorSiteOM.FireEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FireEvent([NativeTypeName("LONG")] int lCookie, IHTMLEventObj* pEventObject)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM2*, int, IHTMLEventObj*, int> )(lpVtbl[5]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), lCookie, pEventObject);
    }

    /// <inheritdoc cref = "IElementBehaviorSiteOM.CreateEventObject"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateEventObject(IHTMLEventObj** ppEventObject)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM2*, IHTMLEventObj**, int> )(lpVtbl[6]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), ppEventObject);
    }

    /// <inheritdoc cref = "IElementBehaviorSiteOM.RegisterName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RegisterName([NativeTypeName("LPOLESTR")] ushort* pchName)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int> )(lpVtbl[7]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), pchName);
    }

    /// <inheritdoc cref = "IElementBehaviorSiteOM.RegisterUrn"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RegisterUrn([NativeTypeName("LPOLESTR")] ushort* pchUrn)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM2*, ushort*, int> )(lpVtbl[8]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), pchUrn);
    }

    /// <include file='IElementBehaviorSiteOM2.xml' path='doc/member[@name="IElementBehaviorSiteOM2.GetDefaults"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDefaults(IHTMLElementDefaults** ppDefaults)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM2*, IHTMLElementDefaults**, int> )(lpVtbl[9]))((IElementBehaviorSiteOM2*)Unsafe.AsPointer(ref this), ppDefaults);
    }

    public interface Interface : IElementBehaviorSiteOM.Interface
    {
        [VtblIndex(9)]
        HRESULT GetDefaults(IHTMLElementDefaults** ppDefaults);
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
        [NativeTypeName("HRESULT (LPOLESTR, LONG, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int*, int> RegisterEvent;
        [NativeTypeName("HRESULT (LPOLESTR, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int*, int> GetEventCookie;
        [NativeTypeName("HRESULT (LONG, IHTMLEventObj *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IHTMLEventObj*, int> FireEvent;
        [NativeTypeName("HRESULT (IHTMLEventObj **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLEventObj**, int> CreateEventObject;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> RegisterName;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> RegisterUrn;
        [NativeTypeName("HRESULT (IHTMLElementDefaults **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementDefaults**, int> GetDefaults;
    }
}