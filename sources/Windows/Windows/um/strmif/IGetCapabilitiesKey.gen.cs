// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IGetCapabilitiesKey.xml' path='doc/member[@name="IGetCapabilitiesKey"]/*'/>
[Guid("A8809222-07BB-48EA-951C-33158100625B")]
[NativeTypeName("struct IGetCapabilitiesKey : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGetCapabilitiesKey : IGetCapabilitiesKey.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGetCapabilitiesKey));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGetCapabilitiesKey*, Guid*, void**, int> )(lpVtbl[0]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGetCapabilitiesKey*, uint> )(lpVtbl[1]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGetCapabilitiesKey*, uint> )(lpVtbl[2]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGetCapabilitiesKey.xml' path='doc/member[@name="IGetCapabilitiesKey.GetCapabilitiesKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCapabilitiesKey(HKEY* pHKey)
    {
        return ((delegate* unmanaged<IGetCapabilitiesKey*, HKEY*, int> )(lpVtbl[3]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this), pHKey);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCapabilitiesKey(HKEY* pHKey);
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
        [NativeTypeName("HRESULT (HKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKEY*, int> GetCapabilitiesKey;
    }
}