// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A65C9109-42AB-4B94-A7B1-DD2E4E68515E")]
[NativeTypeName("struct IUnbufferedFileHandleProvider : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IUnbufferedFileHandleProvider
    : IUnbufferedFileHandleProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUnbufferedFileHandleProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IUnbufferedFileHandleProvider, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUnbufferedFileHandleProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUnbufferedFileHandleProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OpenUnbufferedFileHandle(
        IUnbufferedFileHandleOplockCallback oplockBreakCallback,
        [NativeTypeName("DWORD_PTR *")] nuint* fileHandle
    )
    {
        return (
            (delegate* unmanaged<
                IUnbufferedFileHandleProvider,
                IUnbufferedFileHandleOplockCallback,
                nuint*,
                int>)((*lpVtbl)[3])
        )(this, oplockBreakCallback, fileHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CloseUnbufferedFileHandle()
    {
        return ((delegate* unmanaged<IUnbufferedFileHandleProvider, int>)((*lpVtbl)[4]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OpenUnbufferedFileHandle(
            IUnbufferedFileHandleOplockCallback oplockBreakCallback,
            [NativeTypeName("DWORD_PTR *")] nuint* fileHandle
        );

        [VtblIndex(4)]
        HRESULT CloseUnbufferedFileHandle();
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

        [NativeTypeName(
            "HRESULT (IUnbufferedFileHandleOplockCallback *, DWORD_PTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnbufferedFileHandleOplockCallback,
            nuint*,
            int> OpenUnbufferedFileHandle;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CloseUnbufferedFileHandle;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUnbufferedFileHandleProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUnbufferedFileHandleProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUnbufferedFileHandleProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUnbufferedFileHandleProvider(Silk.NET.Windows.IUnknown value)
    {
        return new IUnbufferedFileHandleProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUnbufferedFileHandleProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUnbufferedFileHandleProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUnbufferedFileHandleProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
