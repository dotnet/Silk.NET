// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IResourceConsumer.xml' path='doc/member[@name="IResourceConsumer"]/*'/>
[Guid("56A868AD-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IResourceConsumer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IResourceConsumer : IResourceConsumer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IResourceConsumer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IResourceConsumer*, Guid*, void**, int> )(lpVtbl[0]))((IResourceConsumer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IResourceConsumer*, uint> )(lpVtbl[1]))((IResourceConsumer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IResourceConsumer*, uint> )(lpVtbl[2]))((IResourceConsumer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IResourceConsumer.xml' path='doc/member[@name="IResourceConsumer.AcquireResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AcquireResource([NativeTypeName("LONG")] int idResource)
    {
        return ((delegate* unmanaged<IResourceConsumer*, int, int> )(lpVtbl[3]))((IResourceConsumer*)Unsafe.AsPointer(ref this), idResource);
    }

    /// <include file='IResourceConsumer.xml' path='doc/member[@name="IResourceConsumer.ReleaseResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReleaseResource([NativeTypeName("LONG")] int idResource)
    {
        return ((delegate* unmanaged<IResourceConsumer*, int, int> )(lpVtbl[4]))((IResourceConsumer*)Unsafe.AsPointer(ref this), idResource);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AcquireResource([NativeTypeName("LONG")] int idResource);
        [VtblIndex(4)]
        HRESULT ReleaseResource([NativeTypeName("LONG")] int idResource);
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
        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> AcquireResource;
        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> ReleaseResource;
    }
}