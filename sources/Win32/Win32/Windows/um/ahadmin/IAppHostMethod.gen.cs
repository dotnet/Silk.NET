// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7883CA1C-1112-4447-84C3-52FBEB38069D")]
[NativeTypeName("struct IAppHostMethod : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostMethod : IAppHostMethod.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostMethod));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostMethod, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostMethod, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostMethod, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IAppHostMethod, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Schema(IAppHostMethodSchema* ppMethodSchema)
    {
        return ((delegate* unmanaged<IAppHostMethod, IAppHostMethodSchema*, int>)((*lpVtbl)[4]))(
            this,
            ppMethodSchema
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateInstance(IAppHostMethodInstance* ppMethodInstance)
    {
        return ((delegate* unmanaged<IAppHostMethod, IAppHostMethodInstance*, int>)((*lpVtbl)[5]))(
            this,
            ppMethodInstance
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName);

        [VtblIndex(4)]
        HRESULT get_Schema(IAppHostMethodSchema* ppMethodSchema);

        [VtblIndex(5)]
        HRESULT CreateInstance(IAppHostMethodInstance* ppMethodInstance);
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

        [NativeTypeName("HRESULT (IAppHostMethodSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostMethodSchema*, int> get_Schema;

        [NativeTypeName("HRESULT (IAppHostMethodInstance **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostMethodInstance*, int> CreateInstance;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostMethod"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostMethod(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostMethod"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostMethod(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostMethod(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostMethod"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostMethod"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostMethod value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
