// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E3F6778B-6660-4CC8-A291-ECC4192D9967")]
[NativeTypeName("struct IKsJackDescription3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IKsJackDescription3 : IKsJackDescription3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKsJackDescription3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKsJackDescription3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IKsJackDescription3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKsJackDescription3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetJackCount(uint* pcJacks)
    {
        return ((delegate* unmanaged<IKsJackDescription3, uint*, int>)((*lpVtbl)[3]))(
            this,
            pcJacks
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetJackDescription3(uint nJack, KSJACK_DESCRIPTION3* pDescription3)
    {
        return (
            (delegate* unmanaged<IKsJackDescription3, uint, KSJACK_DESCRIPTION3*, int>)(
                (*lpVtbl)[4]
            )
        )(this, nJack, pDescription3);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetJackCount(uint* pcJacks);

        [VtblIndex(4)]
        HRESULT GetJackDescription3(uint nJack, KSJACK_DESCRIPTION3* pDescription3);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetJackCount;

        [NativeTypeName("HRESULT (UINT, KSJACK_DESCRIPTION3 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, KSJACK_DESCRIPTION3*, int> GetJackDescription3;
    }

    /// <summary>Initializes a new instance of the <see cref = "IKsJackDescription3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IKsJackDescription3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IKsJackDescription3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IKsJackDescription3(Silk.NET.Windows.IUnknown value)
    {
        return new IKsJackDescription3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKsJackDescription3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IKsJackDescription3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IKsJackDescription3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
