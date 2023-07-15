// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfCompartmentEventSink.xml' path='doc/member[@name="ITfCompartmentEventSink"]/*'/>
[Guid("743ABD5F-F26D-48DF-8CC5-238492419B64")]
[NativeTypeName("struct ITfCompartmentEventSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfCompartmentEventSink : ITfCompartmentEventSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCompartmentEventSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCompartmentEventSink*, Guid*, void**, int> )(lpVtbl[0]))((ITfCompartmentEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfCompartmentEventSink*, uint> )(lpVtbl[1]))((ITfCompartmentEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCompartmentEventSink*, uint> )(lpVtbl[2]))((ITfCompartmentEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfCompartmentEventSink.xml' path='doc/member[@name="ITfCompartmentEventSink.OnChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnChange([NativeTypeName("const GUID &")] Guid* rguid)
    {
        return ((delegate* unmanaged<ITfCompartmentEventSink*, Guid*, int> )(lpVtbl[3]))((ITfCompartmentEventSink*)Unsafe.AsPointer(ref this), rguid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnChange([NativeTypeName("const GUID &")] Guid* rguid);
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
        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> OnChange;
    }
}