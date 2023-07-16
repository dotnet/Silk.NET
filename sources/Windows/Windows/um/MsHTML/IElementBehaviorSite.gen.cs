// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IElementBehaviorSite.xml' path='doc/member[@name="IElementBehaviorSite"]/*'/>
[Guid("3050F427-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehaviorSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementBehaviorSite : IElementBehaviorSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementBehaviorSite));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementBehaviorSite*, Guid*, void**, int> )(lpVtbl[0]))((IElementBehaviorSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementBehaviorSite*, uint> )(lpVtbl[1]))((IElementBehaviorSite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementBehaviorSite*, uint> )(lpVtbl[2]))((IElementBehaviorSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementBehaviorSite.xml' path='doc/member[@name="IElementBehaviorSite.GetElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetElement(IHTMLElement** ppElement)
    {
        return ((delegate* unmanaged<IElementBehaviorSite*, IHTMLElement**, int> )(lpVtbl[3]))((IElementBehaviorSite*)Unsafe.AsPointer(ref this), ppElement);
    }

    /// <include file='IElementBehaviorSite.xml' path='doc/member[@name="IElementBehaviorSite.RegisterNotification"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RegisterNotification([NativeTypeName("LONG")] int lEvent)
    {
        return ((delegate* unmanaged<IElementBehaviorSite*, int, int> )(lpVtbl[4]))((IElementBehaviorSite*)Unsafe.AsPointer(ref this), lEvent);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetElement(IHTMLElement** ppElement);
        [VtblIndex(4)]
        HRESULT RegisterNotification([NativeTypeName("LONG")] int lEvent);
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
        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> GetElement;
        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> RegisterNotification;
    }
}