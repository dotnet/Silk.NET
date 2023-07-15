// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1ImageSource.xml' path='doc/member[@name="ID2D1ImageSource"]/*'/>
[Guid("C9B664E5-74A1-4378-9AC2-EEFC37A3F4D8")]
[NativeTypeName("struct ID2D1ImageSource : ID2D1Image")]
[NativeInheritance("ID2D1Image")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct ID2D1ImageSource : ID2D1ImageSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ImageSource));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1ImageSource*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1ImageSource*, uint> )(lpVtbl[1]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1ImageSource*, uint> )(lpVtbl[2]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Resource.GetFactory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1ImageSource*, ID2D1Factory**, void> )(lpVtbl[3]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this), factory);
    }

    /// <include file='ID2D1ImageSource.xml' path='doc/member[@name="ID2D1ImageSource.OfferResources"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OfferResources()
    {
        return ((delegate* unmanaged<ID2D1ImageSource*, int> )(lpVtbl[4]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1ImageSource.xml' path='doc/member[@name="ID2D1ImageSource.TryReclaimResources"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TryReclaimResources(BOOL* resourcesDiscarded)
    {
        return ((delegate* unmanaged<ID2D1ImageSource*, BOOL*, int> )(lpVtbl[5]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this), resourcesDiscarded);
    }

    public interface Interface : ID2D1Image.Interface
    {
        [VtblIndex(4)]
        HRESULT OfferResources();
        [VtblIndex(5)]
        HRESULT TryReclaimResources(BOOL* resourcesDiscarded);
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
        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Factory**, void> GetFactory;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OfferResources;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> TryReclaimResources;
    }
}