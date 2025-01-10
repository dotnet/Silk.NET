// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F7FD-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementNamespaceFactoryCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementNamespaceFactoryCallback
    : IElementNamespaceFactoryCallback.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementNamespaceFactoryCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IElementNamespaceFactoryCallback, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementNamespaceFactoryCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementNamespaceFactoryCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Resolve(
        [NativeTypeName("BSTR")] ushort* bstrNamespace,
        [NativeTypeName("BSTR")] ushort* bstrTagName,
        [NativeTypeName("BSTR")] ushort* bstrAttrs,
        IElementNamespace pNamespace
    )
    {
        return (
            (delegate* unmanaged<
                IElementNamespaceFactoryCallback,
                ushort*,
                ushort*,
                ushort*,
                IElementNamespace,
                int>)((*lpVtbl)[3])
        )(this, bstrNamespace, bstrTagName, bstrAttrs, pNamespace);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Resolve(
            [NativeTypeName("BSTR")] ushort* bstrNamespace,
            [NativeTypeName("BSTR")] ushort* bstrTagName,
            [NativeTypeName("BSTR")] ushort* bstrAttrs,
            IElementNamespace pNamespace
        );
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
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort*,
            IElementNamespace,
            int> Resolve;
    }

    /// <summary>Initializes a new instance of the <see cref = "IElementNamespaceFactoryCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IElementNamespaceFactoryCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IElementNamespaceFactoryCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IElementNamespaceFactoryCallback(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IElementNamespaceFactoryCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IElementNamespaceFactoryCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IElementNamespaceFactoryCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IElementNamespaceFactoryCallback value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
