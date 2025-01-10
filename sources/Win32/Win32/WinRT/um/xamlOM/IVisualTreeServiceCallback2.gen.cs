// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("BAD9EB88-AE77-4397-B948-5FA2DB0A19EA")]
[NativeTypeName("struct IVisualTreeServiceCallback2 : IVisualTreeServiceCallback")]
[NativeInheritance("IVisualTreeServiceCallback")]
[SupportedOSPlatform("windows10.0.14393.0")]
public unsafe partial struct IVisualTreeServiceCallback2
    : IVisualTreeServiceCallback2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVisualTreeServiceCallback2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IVisualTreeServiceCallback2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVisualTreeServiceCallback2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVisualTreeServiceCallback2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnVisualTreeChange(
        ParentChildRelation relation,
        VisualElement element,
        VisualMutationType mutationType
    )
    {
        return (
            (delegate* unmanaged<
                IVisualTreeServiceCallback2,
                ParentChildRelation,
                VisualElement,
                VisualMutationType,
                int>)((*lpVtbl)[3])
        )(this, relation, element, mutationType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnElementStateChanged(
        InstanceHandle element,
        VisualElementState elementState,
        [NativeTypeName("LPCWSTR")] ushort* context
    )
    {
        return (
            (delegate* unmanaged<
                IVisualTreeServiceCallback2,
                InstanceHandle,
                VisualElementState,
                ushort*,
                int>)((*lpVtbl)[4])
        )(this, element, elementState, context);
    }

    public interface Interface : IVisualTreeServiceCallback.Interface
    {
        [VtblIndex(4)]
        HRESULT OnElementStateChanged(
            InstanceHandle element,
            VisualElementState elementState,
            [NativeTypeName("LPCWSTR")] ushort* context
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

        [NativeTypeName(
            "HRESULT (ParentChildRelation, VisualElement, VisualMutationType) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ParentChildRelation,
            VisualElement,
            VisualMutationType,
            int> OnVisualTreeChange;

        [NativeTypeName(
            "HRESULT (InstanceHandle, VisualElementState, LPCWSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            InstanceHandle,
            VisualElementState,
            ushort*,
            int> OnElementStateChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVisualTreeServiceCallback2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVisualTreeServiceCallback2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IVisualTreeServiceCallback"/> to <see cref = "IVisualTreeServiceCallback2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IVisualTreeServiceCallback"/> instance to be converted </param>
    public static explicit operator IVisualTreeServiceCallback2(
        Silk.NET.WinRT.IVisualTreeServiceCallback value
    )
    {
        return new IVisualTreeServiceCallback2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVisualTreeServiceCallback2"/> to <see cref = "Silk.NET.WinRT.IVisualTreeServiceCallback"/>.</summary>
    /// <param name = "value">The <see cref = "IVisualTreeServiceCallback2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IVisualTreeServiceCallback(
        IVisualTreeServiceCallback2 value
    )
    {
        return new Silk.NET.WinRT.IVisualTreeServiceCallback(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVisualTreeServiceCallback2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVisualTreeServiceCallback2(Silk.NET.Windows.IUnknown value)
    {
        return new IVisualTreeServiceCallback2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVisualTreeServiceCallback2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVisualTreeServiceCallback2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVisualTreeServiceCallback2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
