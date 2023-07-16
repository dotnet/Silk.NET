// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IKsControl.xml' path='doc/member[@name="IKsControl"]/*'/>
[Guid("28F54685-06FD-11D2-B27A-00A0C9223196")]
[NativeTypeName("struct IKsControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IKsControl : IKsControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKsControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKsControl*, Guid*, void**, int> )(lpVtbl[0]))((IKsControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IKsControl*, uint> )(lpVtbl[1]))((IKsControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKsControl*, uint> )(lpVtbl[2]))((IKsControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IKsControl.xml' path='doc/member[@name="IKsControl.KsProperty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT KsProperty([NativeTypeName("PKSPROPERTY")] KSIDENTIFIER* Property, [NativeTypeName("ULONG")] uint PropertyLength, void* PropertyData, [NativeTypeName("ULONG")] uint DataLength, [NativeTypeName("ULONG *")] uint* BytesReturned)
    {
        return ((delegate* unmanaged<IKsControl*, KSIDENTIFIER*, uint, void*, uint, uint*, int> )(lpVtbl[3]))((IKsControl*)Unsafe.AsPointer(ref this), Property, PropertyLength, PropertyData, DataLength, BytesReturned);
    }

    /// <include file='IKsControl.xml' path='doc/member[@name="IKsControl.KsMethod"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT KsMethod([NativeTypeName("PKSMETHOD")] KSIDENTIFIER* Method, [NativeTypeName("ULONG")] uint MethodLength, void* MethodData, [NativeTypeName("ULONG")] uint DataLength, [NativeTypeName("ULONG *")] uint* BytesReturned)
    {
        return ((delegate* unmanaged<IKsControl*, KSIDENTIFIER*, uint, void*, uint, uint*, int> )(lpVtbl[4]))((IKsControl*)Unsafe.AsPointer(ref this), Method, MethodLength, MethodData, DataLength, BytesReturned);
    }

    /// <include file='IKsControl.xml' path='doc/member[@name="IKsControl.KsEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT KsEvent([NativeTypeName("PKSEVENT")] KSIDENTIFIER* Event, [NativeTypeName("ULONG")] uint EventLength, void* EventData, [NativeTypeName("ULONG")] uint DataLength, [NativeTypeName("ULONG *")] uint* BytesReturned)
    {
        return ((delegate* unmanaged<IKsControl*, KSIDENTIFIER*, uint, void*, uint, uint*, int> )(lpVtbl[5]))((IKsControl*)Unsafe.AsPointer(ref this), Event, EventLength, EventData, DataLength, BytesReturned);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT KsProperty([NativeTypeName("PKSPROPERTY")] KSIDENTIFIER* Property, [NativeTypeName("ULONG")] uint PropertyLength, void* PropertyData, [NativeTypeName("ULONG")] uint DataLength, [NativeTypeName("ULONG *")] uint* BytesReturned);
        [VtblIndex(4)]
        HRESULT KsMethod([NativeTypeName("PKSMETHOD")] KSIDENTIFIER* Method, [NativeTypeName("ULONG")] uint MethodLength, void* MethodData, [NativeTypeName("ULONG")] uint DataLength, [NativeTypeName("ULONG *")] uint* BytesReturned);
        [VtblIndex(5)]
        HRESULT KsEvent([NativeTypeName("PKSEVENT")] KSIDENTIFIER* Event, [NativeTypeName("ULONG")] uint EventLength, void* EventData, [NativeTypeName("ULONG")] uint DataLength, [NativeTypeName("ULONG *")] uint* BytesReturned);
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
        [NativeTypeName("HRESULT (PKSPROPERTY, ULONG, void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, KSIDENTIFIER*, uint, void*, uint, uint*, int> KsProperty;
        [NativeTypeName("HRESULT (PKSMETHOD, ULONG, void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, KSIDENTIFIER*, uint, void*, uint, uint*, int> KsMethod;
        [NativeTypeName("HRESULT (PKSEVENT, ULONG, void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, KSIDENTIFIER*, uint, void*, uint, uint*, int> KsEvent;
    }
}