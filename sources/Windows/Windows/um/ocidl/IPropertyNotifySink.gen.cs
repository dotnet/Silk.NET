// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPropertyNotifySink.xml' path='doc/member[@name="IPropertyNotifySink"]/*'/>
[Guid("9BFBBC02-EFF1-101A-84ED-00AA00341D07")]
[NativeTypeName("struct IPropertyNotifySink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyNotifySink : IPropertyNotifySink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyNotifySink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyNotifySink*, Guid*, void**, int> )(lpVtbl[0]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyNotifySink*, uint> )(lpVtbl[1]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyNotifySink*, uint> )(lpVtbl[2]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPropertyNotifySink.xml' path='doc/member[@name="IPropertyNotifySink.OnChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnChanged([NativeTypeName("DISPID")] int dispID)
    {
        return ((delegate* unmanaged<IPropertyNotifySink*, int, int> )(lpVtbl[3]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this), dispID);
    }

    /// <include file='IPropertyNotifySink.xml' path='doc/member[@name="IPropertyNotifySink.OnRequestEdit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnRequestEdit([NativeTypeName("DISPID")] int dispID)
    {
        return ((delegate* unmanaged<IPropertyNotifySink*, int, int> )(lpVtbl[4]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this), dispID);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnChanged([NativeTypeName("DISPID")] int dispID);
        [VtblIndex(4)]
        HRESULT OnRequestEdit([NativeTypeName("DISPID")] int dispID);
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
        [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> OnChanged;
        [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> OnRequestEdit;
    }
}