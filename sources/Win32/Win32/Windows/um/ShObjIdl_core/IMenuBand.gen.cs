// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("568804CD-CBD7-11D0-9816-00C04FD91972")]
[NativeTypeName("struct IMenuBand : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMenuBand : IMenuBand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMenuBand));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMenuBand, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMenuBand, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMenuBand, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsMenuMessage(MSG* pmsg)
    {
        return ((delegate* unmanaged<IMenuBand, MSG*, int>)((*lpVtbl)[3]))(this, pmsg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TranslateMenuMessage(MSG* pmsg, LRESULT* plRet)
    {
        return ((delegate* unmanaged<IMenuBand, MSG*, LRESULT*, int>)((*lpVtbl)[4]))(
            this,
            pmsg,
            plRet
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsMenuMessage(MSG* pmsg);

        [VtblIndex(4)]
        HRESULT TranslateMenuMessage(MSG* pmsg, LRESULT* plRet);
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

        [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> IsMenuMessage;

        [NativeTypeName("HRESULT (MSG *, LRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, LRESULT*, int> TranslateMenuMessage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMenuBand"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMenuBand(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMenuBand"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMenuBand(Silk.NET.Windows.IUnknown value)
    {
        return new IMenuBand(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMenuBand"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMenuBand"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMenuBand value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
