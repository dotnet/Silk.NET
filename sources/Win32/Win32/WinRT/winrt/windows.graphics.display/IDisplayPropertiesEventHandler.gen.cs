// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("DBDD8B01-F1A1-46D1-9EE3-543BCC995980")]
[NativeTypeName("struct IDisplayPropertiesEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
[Obsolete(
    "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
)]
public unsafe partial struct IDisplayPropertiesEventHandler
    : IDisplayPropertiesEventHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDisplayPropertiesEventHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDisplayPropertiesEventHandler, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDisplayPropertiesEventHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDisplayPropertiesEventHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT Invoke(IInspectable sender)
    {
        return (
            (delegate* unmanaged<IDisplayPropertiesEventHandler, IInspectable, int>)((*lpVtbl)[3])
        )(this, sender);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT Invoke(IInspectable sender);
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

        [NativeTypeName("HRESULT (IInspectable *) __attribute__((stdcall))")]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<TSelf*, IInspectable, int> Invoke;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDisplayPropertiesEventHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDisplayPropertiesEventHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDisplayPropertiesEventHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDisplayPropertiesEventHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IDisplayPropertiesEventHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDisplayPropertiesEventHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDisplayPropertiesEventHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDisplayPropertiesEventHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
