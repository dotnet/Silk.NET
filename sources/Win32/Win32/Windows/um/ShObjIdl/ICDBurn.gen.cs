// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3D73A659-E5D0-4D42-AFC0-5121BA425C8D")]
[NativeTypeName("struct ICDBurn : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICDBurn : ICDBurn.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICDBurn));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICDBurn, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICDBurn, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICDBurn, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRecorderDriveLetter([NativeTypeName("LPWSTR")] ushort* pszDrive, uint cch)
    {
        return ((delegate* unmanaged<ICDBurn, ushort*, uint, int>)((*lpVtbl)[3]))(
            this,
            pszDrive,
            cch
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Burn(HWND hwnd)
    {
        return ((delegate* unmanaged<ICDBurn, HWND, int>)((*lpVtbl)[4]))(this, hwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT HasRecordableDrive(BOOL* pfHasRecorder)
    {
        return ((delegate* unmanaged<ICDBurn, BOOL*, int>)((*lpVtbl)[5]))(this, pfHasRecorder);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRecorderDriveLetter([NativeTypeName("LPWSTR")] ushort* pszDrive, uint cch);

        [VtblIndex(4)]
        HRESULT Burn(HWND hwnd);

        [VtblIndex(5)]
        HRESULT HasRecordableDrive(BOOL* pfHasRecorder);
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

        [NativeTypeName("HRESULT (LPWSTR, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> GetRecorderDriveLetter;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> Burn;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> HasRecordableDrive;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICDBurn"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICDBurn(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICDBurn"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICDBurn(Silk.NET.Windows.IUnknown value)
    {
        return new ICDBurn(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICDBurn"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICDBurn"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICDBurn value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
