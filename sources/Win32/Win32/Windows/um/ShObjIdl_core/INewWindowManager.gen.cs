// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D2BC4C84-3F72-4A52-A604-7BCBF3982CBB")]
[NativeTypeName("struct INewWindowManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INewWindowManager : INewWindowManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INewWindowManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INewWindowManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<INewWindowManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INewWindowManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EvaluateNewWindow(
        [NativeTypeName("LPCWSTR")] ushort* pszUrl,
        [NativeTypeName("LPCWSTR")] ushort* pszName,
        [NativeTypeName("LPCWSTR")] ushort* pszUrlContext,
        [NativeTypeName("LPCWSTR")] ushort* pszFeatures,
        BOOL fReplace,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwUserActionTime
    )
    {
        return (
            (delegate* unmanaged<
                INewWindowManager,
                ushort*,
                ushort*,
                ushort*,
                ushort*,
                BOOL,
                uint,
                uint,
                int>)((*lpVtbl)[3])
        )(this, pszUrl, pszName, pszUrlContext, pszFeatures, fReplace, dwFlags, dwUserActionTime);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EvaluateNewWindow(
            [NativeTypeName("LPCWSTR")] ushort* pszUrl,
            [NativeTypeName("LPCWSTR")] ushort* pszName,
            [NativeTypeName("LPCWSTR")] ushort* pszUrlContext,
            [NativeTypeName("LPCWSTR")] ushort* pszFeatures,
            BOOL fReplace,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("DWORD")] uint dwUserActionTime
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

        [NativeTypeName(
            "HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, BOOL, DWORD, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort*,
            ushort*,
            BOOL,
            uint,
            uint,
            int> EvaluateNewWindow;
    }

    /// <summary>Initializes a new instance of the <see cref = "INewWindowManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INewWindowManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INewWindowManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INewWindowManager(Silk.NET.Windows.IUnknown value)
    {
        return new INewWindowManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INewWindowManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INewWindowManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INewWindowManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
