// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDWriteFontCollectionLoader.xml' path='doc/member[@name="IDWriteFontCollectionLoader"]/*'/>
[Guid("CCA920E4-52F0-492B-BFA8-29C72EE0A468")]
[NativeTypeName("struct IDWriteFontCollectionLoader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontCollectionLoader : IDWriteFontCollectionLoader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontCollectionLoader));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontCollectionLoader*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontCollectionLoader*, uint> )(lpVtbl[1]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontCollectionLoader*, uint> )(lpVtbl[2]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontCollectionLoader.xml' path='doc/member[@name="IDWriteFontCollectionLoader.CreateEnumeratorFromKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateEnumeratorFromKey(IDWriteFactory* factory, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator)
    {
        return ((delegate* unmanaged<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int> )(lpVtbl[3]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this), factory, collectionKey, collectionKeySize, fontFileEnumerator);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateEnumeratorFromKey(IDWriteFactory* factory, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator);
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
        [NativeTypeName("HRESULT (IDWriteFactory *, const void *, UINT32, IDWriteFontFileEnumerator **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int> CreateEnumeratorFromKey;
    }
}