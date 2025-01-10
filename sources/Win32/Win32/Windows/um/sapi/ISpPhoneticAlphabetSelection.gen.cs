// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B2745EFD-42CE-48CA-81F1-A96E02538A90")]
[NativeTypeName("struct ISpPhoneticAlphabetSelection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpPhoneticAlphabetSelection
    : ISpPhoneticAlphabetSelection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpPhoneticAlphabetSelection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpPhoneticAlphabetSelection, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpPhoneticAlphabetSelection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpPhoneticAlphabetSelection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsAlphabetUPS(BOOL* pfIsUPS)
    {
        return ((delegate* unmanaged<ISpPhoneticAlphabetSelection, BOOL*, int>)((*lpVtbl)[3]))(
            this,
            pfIsUPS
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetAlphabetToUPS(BOOL fForceUPS)
    {
        return ((delegate* unmanaged<ISpPhoneticAlphabetSelection, BOOL, int>)((*lpVtbl)[4]))(
            this,
            fForceUPS
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsAlphabetUPS(BOOL* pfIsUPS);

        [VtblIndex(4)]
        HRESULT SetAlphabetToUPS(BOOL fForceUPS);
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

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsAlphabetUPS;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetAlphabetToUPS;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpPhoneticAlphabetSelection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpPhoneticAlphabetSelection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpPhoneticAlphabetSelection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpPhoneticAlphabetSelection(Silk.NET.Windows.IUnknown value)
    {
        return new ISpPhoneticAlphabetSelection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpPhoneticAlphabetSelection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpPhoneticAlphabetSelection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpPhoneticAlphabetSelection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
