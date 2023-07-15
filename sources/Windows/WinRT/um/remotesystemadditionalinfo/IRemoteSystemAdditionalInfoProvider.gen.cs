// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/remotesystemadditionalinfo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IRemoteSystemAdditionalInfoProvider.xml' path='doc/member[@name="IRemoteSystemAdditionalInfoProvider"]/*'/>
[Guid("EEAA3D5F-EC63-4D27-AF38-E86B1D7292CB")]
[NativeTypeName("struct IRemoteSystemAdditionalInfoProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRemoteSystemAdditionalInfoProvider : IRemoteSystemAdditionalInfoProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemAdditionalInfoProvider));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRemoteSystemAdditionalInfoProvider*, Guid*, void**, int> )(lpVtbl[0]))((IRemoteSystemAdditionalInfoProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRemoteSystemAdditionalInfoProvider*, uint> )(lpVtbl[1]))((IRemoteSystemAdditionalInfoProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRemoteSystemAdditionalInfoProvider*, uint> )(lpVtbl[2]))((IRemoteSystemAdditionalInfoProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRemoteSystemAdditionalInfoProvider.xml' path='doc/member[@name="IRemoteSystemAdditionalInfoProvider.GetAdditionalInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAdditionalInfo(HSTRING* deduplicationId, [NativeTypeName("const IID &")] Guid* riid, void** mapView)
    {
        return ((delegate* unmanaged<IRemoteSystemAdditionalInfoProvider*, HSTRING*, Guid*, void**, int> )(lpVtbl[3]))((IRemoteSystemAdditionalInfoProvider*)Unsafe.AsPointer(ref this), deduplicationId, riid, mapView);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAdditionalInfo(HSTRING* deduplicationId, [NativeTypeName("const IID &")] Guid* riid, void** mapView);
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
        [NativeTypeName("HRESULT (HSTRING *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, Guid*, void**, int> GetAdditionalInfo;
    }
}