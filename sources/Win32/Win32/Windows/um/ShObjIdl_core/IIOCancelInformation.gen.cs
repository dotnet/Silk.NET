// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F5B0BF81-8CB5-4B1B-9449-1A159E0C733C")]
[NativeTypeName("struct IIOCancelInformation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IIOCancelInformation : IIOCancelInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIOCancelInformation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIOCancelInformation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IIOCancelInformation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIOCancelInformation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetCancelInformation([NativeTypeName("DWORD")] uint dwThreadID, uint uMsgCancel)
    {
        return ((delegate* unmanaged<IIOCancelInformation, uint, uint, int>)((*lpVtbl)[3]))(
            this,
            dwThreadID,
            uMsgCancel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCancelInformation(
        [NativeTypeName("DWORD *")] uint* pdwThreadID,
        uint* puMsgCancel
    )
    {
        return ((delegate* unmanaged<IIOCancelInformation, uint*, uint*, int>)((*lpVtbl)[4]))(
            this,
            pdwThreadID,
            puMsgCancel
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetCancelInformation([NativeTypeName("DWORD")] uint dwThreadID, uint uMsgCancel);

        [VtblIndex(4)]
        HRESULT GetCancelInformation(
            [NativeTypeName("DWORD *")] uint* pdwThreadID,
            uint* puMsgCancel
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

        [NativeTypeName("HRESULT (DWORD, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetCancelInformation;

        [NativeTypeName("HRESULT (DWORD *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetCancelInformation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IIOCancelInformation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IIOCancelInformation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IIOCancelInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IIOCancelInformation(Silk.NET.Windows.IUnknown value)
    {
        return new IIOCancelInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIOCancelInformation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IIOCancelInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IIOCancelInformation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
