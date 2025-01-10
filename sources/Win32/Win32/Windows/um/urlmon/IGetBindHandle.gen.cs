// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AF0FF408-129D-4B20-91F0-02BD23D88352")]
[NativeTypeName("struct IGetBindHandle : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGetBindHandle : IGetBindHandle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGetBindHandle));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGetBindHandle, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGetBindHandle, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGetBindHandle, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBindHandle(BINDHANDLETYPES enumRequestedHandle, HANDLE* pRetHandle)
    {
        return ((delegate* unmanaged<IGetBindHandle, BINDHANDLETYPES, HANDLE*, int>)((*lpVtbl)[3]))(
            this,
            enumRequestedHandle,
            pRetHandle
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetBindHandle(BINDHANDLETYPES enumRequestedHandle, HANDLE* pRetHandle);
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

        [NativeTypeName("HRESULT (BINDHANDLETYPES, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BINDHANDLETYPES, HANDLE*, int> GetBindHandle;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGetBindHandle"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGetBindHandle(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGetBindHandle"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGetBindHandle(Silk.NET.Windows.IUnknown value)
    {
        return new IGetBindHandle(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGetBindHandle"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGetBindHandle"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGetBindHandle value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
