// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFMetadataProvider.xml' path='doc/member[@name="IMFMetadataProvider"]/*'/>
[Guid("56181D2D-E221-4ADB-B1C8-3CEE6A53F76F")]
[NativeTypeName("struct IMFMetadataProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMetadataProvider : IMFMetadataProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMetadataProvider));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMetadataProvider*, Guid*, void**, int> )(lpVtbl[0]))((IMFMetadataProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMetadataProvider*, uint> )(lpVtbl[1]))((IMFMetadataProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMetadataProvider*, uint> )(lpVtbl[2]))((IMFMetadataProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMetadataProvider.xml' path='doc/member[@name="IMFMetadataProvider.GetMFMetadata"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetMFMetadata(IMFPresentationDescriptor* pPresentationDescriptor, [NativeTypeName("DWORD")] uint dwStreamIdentifier, [NativeTypeName("DWORD")] uint dwFlags, IMFMetadata** ppMFMetadata)
    {
        return ((delegate* unmanaged<IMFMetadataProvider*, IMFPresentationDescriptor*, uint, uint, IMFMetadata**, int> )(lpVtbl[3]))((IMFMetadataProvider*)Unsafe.AsPointer(ref this), pPresentationDescriptor, dwStreamIdentifier, dwFlags, ppMFMetadata);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetMFMetadata(IMFPresentationDescriptor* pPresentationDescriptor, [NativeTypeName("DWORD")] uint dwStreamIdentifier, [NativeTypeName("DWORD")] uint dwFlags, IMFMetadata** ppMFMetadata);
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
        [NativeTypeName("HRESULT (IMFPresentationDescriptor *, DWORD, DWORD, IMFMetadata **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationDescriptor*, uint, uint, IMFMetadata**, int> GetMFMetadata;
    }
}