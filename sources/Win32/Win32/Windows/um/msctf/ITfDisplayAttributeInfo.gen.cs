// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("70528852-2F26-4AEA-8C96-215150578932")]
[NativeTypeName("struct ITfDisplayAttributeInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfDisplayAttributeInfo
    : ITfDisplayAttributeInfo.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfDisplayAttributeInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfDisplayAttributeInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfDisplayAttributeInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfDisplayAttributeInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetGUID(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfDisplayAttributeInfo, Guid*, int>)((*lpVtbl)[3]))(
            this,
            pguid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDesc)
    {
        return ((delegate* unmanaged<ITfDisplayAttributeInfo, ushort**, int>)((*lpVtbl)[4]))(
            this,
            pbstrDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAttributeInfo(TF_DISPLAYATTRIBUTE* pda)
    {
        return (
            (delegate* unmanaged<ITfDisplayAttributeInfo, TF_DISPLAYATTRIBUTE*, int>)((*lpVtbl)[5])
        )(this, pda);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAttributeInfo(
        [NativeTypeName("const TF_DISPLAYATTRIBUTE *")] TF_DISPLAYATTRIBUTE* pda
    )
    {
        return (
            (delegate* unmanaged<ITfDisplayAttributeInfo, TF_DISPLAYATTRIBUTE*, int>)((*lpVtbl)[6])
        )(this, pda);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<ITfDisplayAttributeInfo, int>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetGUID(Guid* pguid);

        [VtblIndex(4)]
        HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDesc);

        [VtblIndex(5)]
        HRESULT GetAttributeInfo(TF_DISPLAYATTRIBUTE* pda);

        [VtblIndex(6)]
        HRESULT SetAttributeInfo(
            [NativeTypeName("const TF_DISPLAYATTRIBUTE *")] TF_DISPLAYATTRIBUTE* pda
        );

        [VtblIndex(7)]
        HRESULT Reset();
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGUID;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (TF_DISPLAYATTRIBUTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TF_DISPLAYATTRIBUTE*, int> GetAttributeInfo;

        [NativeTypeName("HRESULT (const TF_DISPLAYATTRIBUTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TF_DISPLAYATTRIBUTE*, int> SetAttributeInfo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfDisplayAttributeInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfDisplayAttributeInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfDisplayAttributeInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfDisplayAttributeInfo(Silk.NET.Windows.IUnknown value)
    {
        return new ITfDisplayAttributeInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfDisplayAttributeInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfDisplayAttributeInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfDisplayAttributeInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
