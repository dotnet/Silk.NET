// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFMuxStreamAttributesManager.xml' path='doc/member[@name="IMFMuxStreamAttributesManager"]/*'/>
[Guid("CE8BD576-E440-43B3-BE34-1E53F565F7E8")]
[NativeTypeName("struct IMFMuxStreamAttributesManager : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFMuxStreamAttributesManager : IMFMuxStreamAttributesManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMuxStreamAttributesManager));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMuxStreamAttributesManager*, Guid*, void**, int> )(lpVtbl[0]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMuxStreamAttributesManager*, uint> )(lpVtbl[1]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMuxStreamAttributesManager*, uint> )(lpVtbl[2]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMuxStreamAttributesManager.xml' path='doc/member[@name="IMFMuxStreamAttributesManager.GetStreamCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount)
    {
        return ((delegate* unmanaged<IMFMuxStreamAttributesManager*, uint*, int> )(lpVtbl[3]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this), pdwMuxStreamCount);
    }

    /// <include file='IMFMuxStreamAttributesManager.xml' path='doc/member[@name="IMFMuxStreamAttributesManager.GetAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAttributes([NativeTypeName("DWORD")] uint dwMuxStreamIndex, IMFAttributes** ppStreamAttributes)
    {
        return ((delegate* unmanaged<IMFMuxStreamAttributesManager*, uint, IMFAttributes**, int> )(lpVtbl[4]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this), dwMuxStreamIndex, ppStreamAttributes);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount);
        [VtblIndex(4)]
        HRESULT GetAttributes([NativeTypeName("DWORD")] uint dwMuxStreamIndex, IMFAttributes** ppStreamAttributes);
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
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetStreamCount;
        [NativeTypeName("HRESULT (DWORD, IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFAttributes**, int> GetAttributes;
    }
}