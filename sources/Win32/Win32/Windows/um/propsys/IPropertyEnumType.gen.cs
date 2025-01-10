// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("11E1FBF9-2D56-4A6B-8DB3-7CD193A471F2")]
[NativeTypeName("struct IPropertyEnumType : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyEnumType : IPropertyEnumType.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyEnumType));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyEnumType, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPropertyEnumType, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyEnumType, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEnumType(PROPENUMTYPE* penumtype)
    {
        return ((delegate* unmanaged<IPropertyEnumType, PROPENUMTYPE*, int>)((*lpVtbl)[3]))(
            this,
            penumtype
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetValue(PROPVARIANT* ppropvar)
    {
        return ((delegate* unmanaged<IPropertyEnumType, PROPVARIANT*, int>)((*lpVtbl)[4]))(
            this,
            ppropvar
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetRangeMinValue(PROPVARIANT* ppropvarMin)
    {
        return ((delegate* unmanaged<IPropertyEnumType, PROPVARIANT*, int>)((*lpVtbl)[5]))(
            this,
            ppropvarMin
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetRangeSetValue(PROPVARIANT* ppropvarSet)
    {
        return ((delegate* unmanaged<IPropertyEnumType, PROPVARIANT*, int>)((*lpVtbl)[6]))(
            this,
            ppropvarSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDisplayText([NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
    {
        return ((delegate* unmanaged<IPropertyEnumType, ushort**, int>)((*lpVtbl)[7]))(
            this,
            ppszDisplay
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetEnumType(PROPENUMTYPE* penumtype);

        [VtblIndex(4)]
        HRESULT GetValue(PROPVARIANT* ppropvar);

        [VtblIndex(5)]
        HRESULT GetRangeMinValue(PROPVARIANT* ppropvarMin);

        [VtblIndex(6)]
        HRESULT GetRangeSetValue(PROPVARIANT* ppropvarSet);

        [VtblIndex(7)]
        HRESULT GetDisplayText([NativeTypeName("LPWSTR *")] ushort** ppszDisplay);
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

        [NativeTypeName("HRESULT (PROPENUMTYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPENUMTYPE*, int> GetEnumType;

        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> GetValue;

        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> GetRangeMinValue;

        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> GetRangeSetValue;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayText;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertyEnumType"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertyEnumType(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertyEnumType"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertyEnumType(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertyEnumType(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyEnumType"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyEnumType"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertyEnumType value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
