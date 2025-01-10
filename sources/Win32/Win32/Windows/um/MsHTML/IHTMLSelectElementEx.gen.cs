// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F2D1-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLSelectElementEx : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHTMLSelectElementEx : IHTMLSelectElementEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLSelectElementEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLSelectElementEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLSelectElementEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLSelectElementEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShowDropdown(BOOL fShow)
    {
        return ((delegate* unmanaged<IHTMLSelectElementEx, BOOL, int>)((*lpVtbl)[3]))(this, fShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSelectExFlags([NativeTypeName("DWORD")] uint lFlags)
    {
        return ((delegate* unmanaged<IHTMLSelectElementEx, uint, int>)((*lpVtbl)[4]))(this, lFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSelectExFlags([NativeTypeName("DWORD *")] uint* pFlags)
    {
        return ((delegate* unmanaged<IHTMLSelectElementEx, uint*, int>)((*lpVtbl)[5]))(
            this,
            pFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDropdownOpen(BOOL* pfOpen)
    {
        return ((delegate* unmanaged<IHTMLSelectElementEx, BOOL*, int>)((*lpVtbl)[6]))(
            this,
            pfOpen
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ShowDropdown(BOOL fShow);

        [VtblIndex(4)]
        HRESULT SetSelectExFlags([NativeTypeName("DWORD")] uint lFlags);

        [VtblIndex(5)]
        HRESULT GetSelectExFlags([NativeTypeName("DWORD *")] uint* pFlags);

        [VtblIndex(6)]
        HRESULT GetDropdownOpen(BOOL* pfOpen);
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

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ShowDropdown;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetSelectExFlags;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSelectExFlags;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetDropdownOpen;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLSelectElementEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLSelectElementEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLSelectElementEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLSelectElementEx(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLSelectElementEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLSelectElementEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLSelectElementEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLSelectElementEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
