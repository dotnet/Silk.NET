// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C5C04795-321C-4014-8FD6-D44658799393")]
[NativeTypeName("struct IAppHostSectionDefinition : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostSectionDefinition
    : IAppHostSectionDefinition.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostSectionDefinition));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostSectionDefinition, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostSectionDefinition, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostSectionDefinition, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IAppHostSectionDefinition, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Type([NativeTypeName("BSTR *")] ushort** pbstrType)
    {
        return ((delegate* unmanaged<IAppHostSectionDefinition, ushort**, int>)((*lpVtbl)[4]))(
            this,
            pbstrType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT put_Type([NativeTypeName("BSTR")] ushort* bstrType)
    {
        return ((delegate* unmanaged<IAppHostSectionDefinition, ushort*, int>)((*lpVtbl)[5]))(
            this,
            bstrType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OverrideModeDefault(
        [NativeTypeName("BSTR *")] ushort** pbstrOverrideModeDefault
    )
    {
        return ((delegate* unmanaged<IAppHostSectionDefinition, ushort**, int>)((*lpVtbl)[6]))(
            this,
            pbstrOverrideModeDefault
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_OverrideModeDefault([NativeTypeName("BSTR")] ushort* bstrOverrideModeDefault)
    {
        return ((delegate* unmanaged<IAppHostSectionDefinition, ushort*, int>)((*lpVtbl)[7]))(
            this,
            bstrOverrideModeDefault
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AllowDefinition([NativeTypeName("BSTR *")] ushort** pbstrAllowDefinition)
    {
        return ((delegate* unmanaged<IAppHostSectionDefinition, ushort**, int>)((*lpVtbl)[8]))(
            this,
            pbstrAllowDefinition
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AllowDefinition([NativeTypeName("BSTR")] ushort* bstrAllowDefinition)
    {
        return ((delegate* unmanaged<IAppHostSectionDefinition, ushort*, int>)((*lpVtbl)[9]))(
            this,
            bstrAllowDefinition
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AllowLocation([NativeTypeName("BSTR *")] ushort** pbstrAllowLocation)
    {
        return ((delegate* unmanaged<IAppHostSectionDefinition, ushort**, int>)((*lpVtbl)[10]))(
            this,
            pbstrAllowLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_AllowLocation([NativeTypeName("BSTR")] ushort* bstrAllowLocation)
    {
        return ((delegate* unmanaged<IAppHostSectionDefinition, ushort*, int>)((*lpVtbl)[11]))(
            this,
            bstrAllowLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RequirePermission(
        [NativeTypeName("VARIANT_BOOL *")] short* pfRequirePermission
    )
    {
        return ((delegate* unmanaged<IAppHostSectionDefinition, short*, int>)((*lpVtbl)[12]))(
            this,
            pfRequirePermission
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_RequirePermission([NativeTypeName("VARIANT_BOOL")] short pfRequirePermission)
    {
        return ((delegate* unmanaged<IAppHostSectionDefinition, short, int>)((*lpVtbl)[13]))(
            this,
            pfRequirePermission
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName);

        [VtblIndex(4)]
        HRESULT get_Type([NativeTypeName("BSTR *")] ushort** pbstrType);

        [VtblIndex(5)]
        HRESULT put_Type([NativeTypeName("BSTR")] ushort* bstrType);

        [VtblIndex(6)]
        HRESULT get_OverrideModeDefault(
            [NativeTypeName("BSTR *")] ushort** pbstrOverrideModeDefault
        );

        [VtblIndex(7)]
        HRESULT put_OverrideModeDefault([NativeTypeName("BSTR")] ushort* bstrOverrideModeDefault);

        [VtblIndex(8)]
        HRESULT get_AllowDefinition([NativeTypeName("BSTR *")] ushort** pbstrAllowDefinition);

        [VtblIndex(9)]
        HRESULT put_AllowDefinition([NativeTypeName("BSTR")] ushort* bstrAllowDefinition);

        [VtblIndex(10)]
        HRESULT get_AllowLocation([NativeTypeName("BSTR *")] ushort** pbstrAllowLocation);

        [VtblIndex(11)]
        HRESULT put_AllowLocation([NativeTypeName("BSTR")] ushort* bstrAllowLocation);

        [VtblIndex(12)]
        HRESULT get_RequirePermission(
            [NativeTypeName("VARIANT_BOOL *")] short* pfRequirePermission
        );

        [VtblIndex(13)]
        HRESULT put_RequirePermission([NativeTypeName("VARIANT_BOOL")] short pfRequirePermission);
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
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Type;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Type;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_OverrideModeDefault;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_OverrideModeDefault;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_AllowDefinition;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_AllowDefinition;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_AllowLocation;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_AllowLocation;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_RequirePermission;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_RequirePermission;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostSectionDefinition"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostSectionDefinition(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostSectionDefinition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostSectionDefinition(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostSectionDefinition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostSectionDefinition"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostSectionDefinition"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostSectionDefinition value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
