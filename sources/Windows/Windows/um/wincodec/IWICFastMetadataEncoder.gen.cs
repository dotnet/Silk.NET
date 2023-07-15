// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IWICFastMetadataEncoder.xml' path='doc/member[@name="IWICFastMetadataEncoder"]/*'/>
[Guid("B84E2C09-78C9-4AC4-8BD3-524AE1663A2F")]
[NativeTypeName("struct IWICFastMetadataEncoder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICFastMetadataEncoder : IWICFastMetadataEncoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICFastMetadataEncoder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICFastMetadataEncoder*, Guid*, void**, int> )(lpVtbl[0]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICFastMetadataEncoder*, uint> )(lpVtbl[1]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICFastMetadataEncoder*, uint> )(lpVtbl[2]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICFastMetadataEncoder.xml' path='doc/member[@name="IWICFastMetadataEncoder.Commit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<IWICFastMetadataEncoder*, int> )(lpVtbl[3]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICFastMetadataEncoder.xml' path='doc/member[@name="IWICFastMetadataEncoder.GetMetadataQueryWriter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter)
    {
        return ((delegate* unmanaged<IWICFastMetadataEncoder*, IWICMetadataQueryWriter**, int> )(lpVtbl[4]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Commit();
        [VtblIndex(4)]
        HRESULT GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter);
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Commit;
        [NativeTypeName("HRESULT (IWICMetadataQueryWriter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICMetadataQueryWriter**, int> GetMetadataQueryWriter;
    }
}