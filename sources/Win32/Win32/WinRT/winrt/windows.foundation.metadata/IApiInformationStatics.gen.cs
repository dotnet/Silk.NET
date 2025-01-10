// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.metadata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("997439FE-F681-4A11-B416-C13A47E8BA36")]
[NativeTypeName("struct IApiInformationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApiInformationStatics : IApiInformationStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApiInformationStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApiInformationStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IApiInformationStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApiInformationStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IApiInformationStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IApiInformationStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IApiInformationStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsTypePresent(HSTRING typeName, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IApiInformationStatics, HSTRING, byte*, int>)((*lpVtbl)[6]))(
            this,
            typeName,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsMethodPresent(
        HSTRING typeName,
        HSTRING methodName,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IApiInformationStatics, HSTRING, HSTRING, byte*, int>)(
                (*lpVtbl)[7]
            )
        )(this, typeName, methodName, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsMethodPresentWithArity(
        HSTRING typeName,
        HSTRING methodName,
        [NativeTypeName("UINT32")] uint inputParameterCount,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IApiInformationStatics, HSTRING, HSTRING, uint, byte*, int>)(
                (*lpVtbl)[8]
            )
        )(this, typeName, methodName, inputParameterCount, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsEventPresent(
        HSTRING typeName,
        HSTRING eventName,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IApiInformationStatics, HSTRING, HSTRING, byte*, int>)(
                (*lpVtbl)[9]
            )
        )(this, typeName, eventName, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsPropertyPresent(
        HSTRING typeName,
        HSTRING propertyName,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IApiInformationStatics, HSTRING, HSTRING, byte*, int>)(
                (*lpVtbl)[10]
            )
        )(this, typeName, propertyName, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsReadOnlyPropertyPresent(
        HSTRING typeName,
        HSTRING propertyName,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IApiInformationStatics, HSTRING, HSTRING, byte*, int>)(
                (*lpVtbl)[11]
            )
        )(this, typeName, propertyName, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsWriteablePropertyPresent(
        HSTRING typeName,
        HSTRING propertyName,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IApiInformationStatics, HSTRING, HSTRING, byte*, int>)(
                (*lpVtbl)[12]
            )
        )(this, typeName, propertyName, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsEnumNamedValuePresent(
        HSTRING enumTypeName,
        HSTRING valueName,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IApiInformationStatics, HSTRING, HSTRING, byte*, int>)(
                (*lpVtbl)[13]
            )
        )(this, enumTypeName, valueName, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT IsApiContractPresentByMajor(
        HSTRING contractName,
        [NativeTypeName("UINT16")] ushort majorVersion,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IApiInformationStatics, HSTRING, ushort, byte*, int>)(
                (*lpVtbl)[14]
            )
        )(this, contractName, majorVersion, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsApiContractPresentByMajorAndMinor(
        HSTRING contractName,
        [NativeTypeName("UINT16")] ushort majorVersion,
        [NativeTypeName("UINT16")] ushort minorVersion,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IApiInformationStatics, HSTRING, ushort, ushort, byte*, int>)(
                (*lpVtbl)[15]
            )
        )(this, contractName, majorVersion, minorVersion, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsTypePresent(HSTRING typeName, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT IsMethodPresent(
            HSTRING typeName,
            HSTRING methodName,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(8)]
        HRESULT IsMethodPresentWithArity(
            HSTRING typeName,
            HSTRING methodName,
            [NativeTypeName("UINT32")] uint inputParameterCount,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(9)]
        HRESULT IsEventPresent(
            HSTRING typeName,
            HSTRING eventName,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(10)]
        HRESULT IsPropertyPresent(
            HSTRING typeName,
            HSTRING propertyName,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(11)]
        HRESULT IsReadOnlyPropertyPresent(
            HSTRING typeName,
            HSTRING propertyName,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(12)]
        HRESULT IsWriteablePropertyPresent(
            HSTRING typeName,
            HSTRING propertyName,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(13)]
        HRESULT IsEnumNamedValuePresent(
            HSTRING enumTypeName,
            HSTRING valueName,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(14)]
        HRESULT IsApiContractPresentByMajor(
            HSTRING contractName,
            [NativeTypeName("UINT16")] ushort majorVersion,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(15)]
        HRESULT IsApiContractPresentByMajorAndMinor(
            HSTRING contractName,
            [NativeTypeName("UINT16")] ushort majorVersion,
            [NativeTypeName("UINT16")] ushort minorVersion,
            [NativeTypeName("boolean *")] byte* result
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> IsTypePresent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> IsMethodPresent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            uint,
            byte*,
            int> IsMethodPresentWithArity;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> IsEventPresent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> IsPropertyPresent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> IsReadOnlyPropertyPresent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> IsWriteablePropertyPresent;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> IsEnumNamedValuePresent;

        [NativeTypeName("HRESULT (HSTRING, UINT16, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, ushort, byte*, int> IsApiContractPresentByMajor;

        [NativeTypeName("HRESULT (HSTRING, UINT16, UINT16, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ushort,
            ushort,
            byte*,
            int> IsApiContractPresentByMajorAndMinor;
    }

    /// <summary>Initializes a new instance of the <see cref = "IApiInformationStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IApiInformationStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IApiInformationStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IApiInformationStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IApiInformationStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApiInformationStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IApiInformationStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IApiInformationStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IApiInformationStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IApiInformationStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IApiInformationStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApiInformationStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IApiInformationStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IApiInformationStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
