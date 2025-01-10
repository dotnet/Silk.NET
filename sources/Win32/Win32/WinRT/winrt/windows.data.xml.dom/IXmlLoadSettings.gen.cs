// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("58AA07A8-FED6-46F7-B4C5-FB1BA72108D6")]
[NativeTypeName("struct IXmlLoadSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlLoadSettings : IXmlLoadSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlLoadSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXmlLoadSettings, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXmlLoadSettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXmlLoadSettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IXmlLoadSettings, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IXmlLoadSettings, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IXmlLoadSettings, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MaxElementDepth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IXmlLoadSettings, uint*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_MaxElementDepth([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IXmlLoadSettings, uint, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ProhibitDtd([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IXmlLoadSettings, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ProhibitDtd([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IXmlLoadSettings, byte, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ResolveExternals([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IXmlLoadSettings, byte*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ResolveExternals([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IXmlLoadSettings, byte, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ValidateOnParse([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IXmlLoadSettings, byte*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ValidateOnParse([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IXmlLoadSettings, byte, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ElementContentWhiteSpace([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IXmlLoadSettings, byte*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_ElementContentWhiteSpace([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IXmlLoadSettings, byte, int>)((*lpVtbl)[15]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MaxElementDepth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT put_MaxElementDepth([NativeTypeName("UINT32")] uint value);

        [VtblIndex(8)]
        HRESULT get_ProhibitDtd([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_ProhibitDtd([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_ResolveExternals([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_ResolveExternals([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_ValidateOnParse([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_ValidateOnParse([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_ElementContentWhiteSpace([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_ElementContentWhiteSpace([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_MaxElementDepth;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_MaxElementDepth;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_ProhibitDtd;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_ProhibitDtd;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_ResolveExternals;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_ResolveExternals;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_ValidateOnParse;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_ValidateOnParse;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_ElementContentWhiteSpace;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_ElementContentWhiteSpace;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXmlLoadSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXmlLoadSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IXmlLoadSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IXmlLoadSettings(Silk.NET.WinRT.IInspectable value)
    {
        return new IXmlLoadSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlLoadSettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlLoadSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IXmlLoadSettings value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXmlLoadSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXmlLoadSettings(Silk.NET.Windows.IUnknown value)
    {
        return new IXmlLoadSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlLoadSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlLoadSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXmlLoadSettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
