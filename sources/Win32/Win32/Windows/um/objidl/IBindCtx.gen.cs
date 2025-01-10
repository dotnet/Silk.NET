// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000000E-0000-0000-C000-000000000046")]
[NativeTypeName("struct IBindCtx : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBindCtx : IBindCtx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindCtx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBindCtx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBindCtx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBindCtx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterObjectBound(IUnknown punk)
    {
        return ((delegate* unmanaged<IBindCtx, IUnknown, int>)((*lpVtbl)[3]))(this, punk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RevokeObjectBound(IUnknown punk)
    {
        return ((delegate* unmanaged<IBindCtx, IUnknown, int>)((*lpVtbl)[4]))(this, punk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReleaseBoundObjects()
    {
        return ((delegate* unmanaged<IBindCtx, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetBindOptions(BIND_OPTS* pbindopts)
    {
        return ((delegate* unmanaged<IBindCtx, BIND_OPTS*, int>)((*lpVtbl)[6]))(this, pbindopts);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetBindOptions(BIND_OPTS* pbindopts)
    {
        return ((delegate* unmanaged<IBindCtx, BIND_OPTS*, int>)((*lpVtbl)[7]))(this, pbindopts);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetRunningObjectTable(IRunningObjectTable* pprot)
    {
        return ((delegate* unmanaged<IBindCtx, IRunningObjectTable*, int>)((*lpVtbl)[8]))(
            this,
            pprot
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RegisterObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, IUnknown punk)
    {
        return ((delegate* unmanaged<IBindCtx, ushort*, IUnknown, int>)((*lpVtbl)[9]))(
            this,
            pszKey,
            punk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, IUnknown* ppunk)
    {
        return ((delegate* unmanaged<IBindCtx, ushort*, IUnknown*, int>)((*lpVtbl)[10]))(
            this,
            pszKey,
            ppunk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EnumObjectParam(IEnumString* ppenum)
    {
        return ((delegate* unmanaged<IBindCtx, IEnumString*, int>)((*lpVtbl)[11]))(this, ppenum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RevokeObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey)
    {
        return ((delegate* unmanaged<IBindCtx, ushort*, int>)((*lpVtbl)[12]))(this, pszKey);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterObjectBound(IUnknown punk);

        [VtblIndex(4)]
        HRESULT RevokeObjectBound(IUnknown punk);

        [VtblIndex(5)]
        HRESULT ReleaseBoundObjects();

        [VtblIndex(6)]
        HRESULT SetBindOptions(BIND_OPTS* pbindopts);

        [VtblIndex(7)]
        HRESULT GetBindOptions(BIND_OPTS* pbindopts);

        [VtblIndex(8)]
        HRESULT GetRunningObjectTable(IRunningObjectTable* pprot);

        [VtblIndex(9)]
        HRESULT RegisterObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, IUnknown punk);

        [VtblIndex(10)]
        HRESULT GetObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, IUnknown* ppunk);

        [VtblIndex(11)]
        HRESULT EnumObjectParam(IEnumString* ppenum);

        [VtblIndex(12)]
        HRESULT RevokeObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey);
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> RegisterObjectBound;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> RevokeObjectBound;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReleaseBoundObjects;

        [NativeTypeName("HRESULT (BIND_OPTS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BIND_OPTS*, int> SetBindOptions;

        [NativeTypeName("HRESULT (BIND_OPTS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BIND_OPTS*, int> GetBindOptions;

        [NativeTypeName("HRESULT (IRunningObjectTable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IRunningObjectTable*, int> GetRunningObjectTable;

        [NativeTypeName("HRESULT (LPOLESTR, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IUnknown, int> RegisterObjectParam;

        [NativeTypeName("HRESULT (LPOLESTR, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IUnknown*, int> GetObjectParam;

        [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumString*, int> EnumObjectParam;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> RevokeObjectParam;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBindCtx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBindCtx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBindCtx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBindCtx(Silk.NET.Windows.IUnknown value)
    {
        return new IBindCtx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBindCtx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBindCtx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBindCtx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
