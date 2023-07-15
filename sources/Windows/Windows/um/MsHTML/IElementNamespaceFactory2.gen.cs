// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IElementNamespaceFactory2.xml' path='doc/member[@name="IElementNamespaceFactory2"]/*'/>
[Guid("3050F805-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementNamespaceFactory2 : IElementNamespaceFactory")]
[NativeInheritance("IElementNamespaceFactory")]
public unsafe partial struct IElementNamespaceFactory2 : IElementNamespaceFactory2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementNamespaceFactory2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementNamespaceFactory2*, Guid*, void**, int> )(lpVtbl[0]))((IElementNamespaceFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementNamespaceFactory2*, uint> )(lpVtbl[1]))((IElementNamespaceFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementNamespaceFactory2*, uint> )(lpVtbl[2]))((IElementNamespaceFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IElementNamespaceFactory.Create"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Create(IElementNamespace* pNamespace)
    {
        return ((delegate* unmanaged<IElementNamespaceFactory2*, IElementNamespace*, int> )(lpVtbl[3]))((IElementNamespaceFactory2*)Unsafe.AsPointer(ref this), pNamespace);
    }

    /// <include file='IElementNamespaceFactory2.xml' path='doc/member[@name="IElementNamespaceFactory2.CreateWithImplementation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateWithImplementation(IElementNamespace* pNamespace, [NativeTypeName("BSTR")] ushort* bstrImplementation)
    {
        return ((delegate* unmanaged<IElementNamespaceFactory2*, IElementNamespace*, ushort*, int> )(lpVtbl[4]))((IElementNamespaceFactory2*)Unsafe.AsPointer(ref this), pNamespace, bstrImplementation);
    }

    public interface Interface : IElementNamespaceFactory.Interface
    {
        [VtblIndex(4)]
        HRESULT CreateWithImplementation(IElementNamespace* pNamespace, [NativeTypeName("BSTR")] ushort* bstrImplementation);
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
        [NativeTypeName("HRESULT (IElementNamespace *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IElementNamespace*, int> Create;
        [NativeTypeName("HRESULT (IElementNamespace *, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IElementNamespace*, ushort*, int> CreateWithImplementation;
    }
}