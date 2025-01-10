// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D4236675-A5BF-4570-9D42-5D6D7B02D59B")]
[NativeTypeName("struct ITfLMLattice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfLMLattice : ITfLMLattice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfLMLattice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfLMLattice, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfLMLattice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfLMLattice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryType([NativeTypeName("const GUID &")] Guid* rguidType, BOOL* pfSupported)
    {
        return ((delegate* unmanaged<ITfLMLattice, Guid*, BOOL*, int>)((*lpVtbl)[3]))(
            this,
            rguidType,
            pfSupported
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumLatticeElements(
        [NativeTypeName("DWORD")] uint dwFrameStart,
        [NativeTypeName("const GUID &")] Guid* rguidType,
        IEnumTfLatticeElements* ppEnum
    )
    {
        return (
            (delegate* unmanaged<ITfLMLattice, uint, Guid*, IEnumTfLatticeElements*, int>)(
                (*lpVtbl)[4]
            )
        )(this, dwFrameStart, rguidType, ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryType([NativeTypeName("const GUID &")] Guid* rguidType, BOOL* pfSupported);

        [VtblIndex(4)]
        HRESULT EnumLatticeElements(
            [NativeTypeName("DWORD")] uint dwFrameStart,
            [NativeTypeName("const GUID &")] Guid* rguidType,
            IEnumTfLatticeElements* ppEnum
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

        [NativeTypeName("HRESULT (const GUID &, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, BOOL*, int> QueryType;

        [NativeTypeName(
            "HRESULT (DWORD, const GUID &, IEnumTfLatticeElements **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            Guid*,
            IEnumTfLatticeElements*,
            int> EnumLatticeElements;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfLMLattice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfLMLattice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfLMLattice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfLMLattice(Silk.NET.Windows.IUnknown value)
    {
        return new ITfLMLattice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfLMLattice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfLMLattice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfLMLattice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
