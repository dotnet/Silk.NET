// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("52B18B5C-555D-46B2-B00A-FA680144FBDB")]
[NativeTypeName("struct ITfToolTipUIElement : ITfUIElement")]
[NativeInheritance("ITfUIElement")]
public unsafe partial struct ITfToolTipUIElement : ITfToolTipUIElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfToolTipUIElement));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfToolTipUIElement, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfToolTipUIElement, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfToolTipUIElement, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
    {
        return ((delegate* unmanaged<ITfToolTipUIElement, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrDescription
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfToolTipUIElement, Guid*, int>)((*lpVtbl)[4]))(this, pguid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Show(BOOL bShow)
    {
        return ((delegate* unmanaged<ITfToolTipUIElement, BOOL, int>)((*lpVtbl)[5]))(this, bShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsShown(BOOL* pbShow)
    {
        return ((delegate* unmanaged<ITfToolTipUIElement, BOOL*, int>)((*lpVtbl)[6]))(this, pbShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetString([NativeTypeName("BSTR *")] ushort** pstr)
    {
        return ((delegate* unmanaged<ITfToolTipUIElement, ushort**, int>)((*lpVtbl)[7]))(
            this,
            pstr
        );
    }

    public interface Interface : ITfUIElement.Interface
    {
        [VtblIndex(7)]
        HRESULT GetString([NativeTypeName("BSTR *")] ushort** pstr);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGUID;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Show;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsShown;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetString;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfToolTipUIElement"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfToolTipUIElement(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfUIElement"/> to <see cref = "ITfToolTipUIElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfUIElement"/> instance to be converted </param>
    public static explicit operator ITfToolTipUIElement(Silk.NET.Windows.ITfUIElement value)
    {
        return new ITfToolTipUIElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfToolTipUIElement"/> to <see cref = "Silk.NET.Windows.ITfUIElement"/>.</summary>
    /// <param name = "value">The <see cref = "ITfToolTipUIElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfUIElement(ITfToolTipUIElement value)
    {
        return new Silk.NET.Windows.ITfUIElement(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfToolTipUIElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfToolTipUIElement(Silk.NET.Windows.IUnknown value)
    {
        return new ITfToolTipUIElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfToolTipUIElement"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfToolTipUIElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfToolTipUIElement value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
