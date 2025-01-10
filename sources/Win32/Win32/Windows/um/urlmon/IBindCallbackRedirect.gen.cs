// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("11C81BC2-121E-4ED5-B9C4-B430BD54F2C0")]
[NativeTypeName("struct IBindCallbackRedirect : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBindCallbackRedirect : IBindCallbackRedirect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindCallbackRedirect));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBindCallbackRedirect, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBindCallbackRedirect, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBindCallbackRedirect, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Redirect(
        [NativeTypeName("LPCWSTR")] ushort* lpcUrl,
        [NativeTypeName("VARIANT_BOOL *")] short* vbCancel
    )
    {
        return ((delegate* unmanaged<IBindCallbackRedirect, ushort*, short*, int>)((*lpVtbl)[3]))(
            this,
            lpcUrl,
            vbCancel
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Redirect(
            [NativeTypeName("LPCWSTR")] ushort* lpcUrl,
            [NativeTypeName("VARIANT_BOOL *")] short* vbCancel
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

        [NativeTypeName("HRESULT (LPCWSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> Redirect;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBindCallbackRedirect"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBindCallbackRedirect(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBindCallbackRedirect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBindCallbackRedirect(Silk.NET.Windows.IUnknown value)
    {
        return new IBindCallbackRedirect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBindCallbackRedirect"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBindCallbackRedirect"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBindCallbackRedirect value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
