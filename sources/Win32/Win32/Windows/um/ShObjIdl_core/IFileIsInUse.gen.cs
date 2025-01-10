// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("64A1CBF0-3A1A-4461-9158-376969693950")]
[NativeTypeName("struct IFileIsInUse : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileIsInUse : IFileIsInUse.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileIsInUse));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileIsInUse, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileIsInUse, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileIsInUse, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAppName([NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<IFileIsInUse, ushort**, int>)((*lpVtbl)[3]))(this, ppszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetUsage(FILE_USAGE_TYPE* pfut)
    {
        return ((delegate* unmanaged<IFileIsInUse, FILE_USAGE_TYPE*, int>)((*lpVtbl)[4]))(
            this,
            pfut
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCapabilities([NativeTypeName("DWORD *")] uint* pdwCapFlags)
    {
        return ((delegate* unmanaged<IFileIsInUse, uint*, int>)((*lpVtbl)[5]))(this, pdwCapFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSwitchToHWND(HWND* phwnd)
    {
        return ((delegate* unmanaged<IFileIsInUse, HWND*, int>)((*lpVtbl)[6]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CloseFile()
    {
        return ((delegate* unmanaged<IFileIsInUse, int>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAppName([NativeTypeName("LPWSTR *")] ushort** ppszName);

        [VtblIndex(4)]
        HRESULT GetUsage(FILE_USAGE_TYPE* pfut);

        [VtblIndex(5)]
        HRESULT GetCapabilities([NativeTypeName("DWORD *")] uint* pdwCapFlags);

        [VtblIndex(6)]
        HRESULT GetSwitchToHWND(HWND* phwnd);

        [VtblIndex(7)]
        HRESULT CloseFile();
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetAppName;

        [NativeTypeName("HRESULT (FILE_USAGE_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FILE_USAGE_TYPE*, int> GetUsage;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCapabilities;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetSwitchToHWND;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CloseFile;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileIsInUse"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileIsInUse(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileIsInUse"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileIsInUse(Silk.NET.Windows.IUnknown value)
    {
        return new IFileIsInUse(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileIsInUse"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileIsInUse"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileIsInUse value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
