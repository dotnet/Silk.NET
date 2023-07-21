// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IElementNamespaceFactoryCallback.xml' path='doc/member[@name="IElementNamespaceFactoryCallback"]/*' />
[Guid("3050F7FD-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementNamespaceFactoryCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementNamespaceFactoryCallback : IElementNamespaceFactoryCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementNamespaceFactoryCallback));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementNamespaceFactoryCallback*, Guid*, void**, int>)(lpVtbl[0]))((IElementNamespaceFactoryCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementNamespaceFactoryCallback*, uint>)(lpVtbl[1]))((IElementNamespaceFactoryCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementNamespaceFactoryCallback*, uint>)(lpVtbl[2]))((IElementNamespaceFactoryCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementNamespaceFactoryCallback.xml' path='doc/member[@name="IElementNamespaceFactoryCallback.Resolve"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Resolve([NativeTypeName("BSTR")] ushort* bstrNamespace, [NativeTypeName("BSTR")] ushort* bstrTagName, [NativeTypeName("BSTR")] ushort* bstrAttrs, IElementNamespace* pNamespace)
    {
        return ((delegate* unmanaged<IElementNamespaceFactoryCallback*, ushort*, ushort*, ushort*, IElementNamespace*, int>)(lpVtbl[3]))((IElementNamespaceFactoryCallback*)Unsafe.AsPointer(ref this), bstrNamespace, bstrTagName, bstrAttrs, pNamespace);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Resolve([NativeTypeName("BSTR")] ushort* bstrNamespace, [NativeTypeName("BSTR")] ushort* bstrTagName, [NativeTypeName("BSTR")] ushort* bstrAttrs, IElementNamespace* pNamespace);
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

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR, IElementNamespace *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, IElementNamespace*, int> Resolve;
    }
}
