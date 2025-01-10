// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9E184D15-CDB7-4F86-B49E-566689F4A601")]
[NativeTypeName("struct IMFMediaEngineEMENotify : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaEngineEMENotify
    : IMFMediaEngineEMENotify.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineEMENotify));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineEMENotify, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaEngineEMENotify, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineEMENotify, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void Encrypted(
        [NativeTypeName("const BYTE *")] byte* pbInitData,
        [NativeTypeName("DWORD")] uint cb,
        [NativeTypeName("BSTR")] ushort* bstrInitDataType
    )
    {
        ((delegate* unmanaged<IMFMediaEngineEMENotify, byte*, uint, ushort*, void>)((*lpVtbl)[3]))(
            this,
            pbInitData,
            cb,
            bstrInitDataType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void WaitingForKey()
    {
        ((delegate* unmanaged<IMFMediaEngineEMENotify, void>)((*lpVtbl)[4]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void Encrypted(
            [NativeTypeName("const BYTE *")] byte* pbInitData,
            [NativeTypeName("DWORD")] uint cb,
            [NativeTypeName("BSTR")] ushort* bstrInitDataType
        );

        [VtblIndex(4)]
        void WaitingForKey();
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

        [NativeTypeName("void (const BYTE *, DWORD, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, ushort*, void> Encrypted;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> WaitingForKey;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaEngineEMENotify"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaEngineEMENotify(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaEngineEMENotify"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaEngineEMENotify(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaEngineEMENotify(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaEngineEMENotify"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaEngineEMENotify"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaEngineEMENotify value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
