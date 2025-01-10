// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InputScope.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FDE1EAEE-6924-4CDF-91E7-DA38CFF5559D")]
[NativeTypeName("struct ITfInputScope : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfInputScope : ITfInputScope.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfInputScope));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfInputScope, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfInputScope, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfInputScope, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetInputScopes(InputScope** pprgInputScopes, uint* pcCount)
    {
        return ((delegate* unmanaged<ITfInputScope, InputScope**, uint*, int>)((*lpVtbl)[3]))(
            this,
            pprgInputScopes,
            pcCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPhrase([NativeTypeName("BSTR **")] ushort*** ppbstrPhrases, uint* pcCount)
    {
        return ((delegate* unmanaged<ITfInputScope, ushort***, uint*, int>)((*lpVtbl)[4]))(
            this,
            ppbstrPhrases,
            pcCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetRegularExpression([NativeTypeName("BSTR *")] ushort** pbstrRegExp)
    {
        return ((delegate* unmanaged<ITfInputScope, ushort**, int>)((*lpVtbl)[5]))(
            this,
            pbstrRegExp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSRGS([NativeTypeName("BSTR *")] ushort** pbstrSRGS)
    {
        return ((delegate* unmanaged<ITfInputScope, ushort**, int>)((*lpVtbl)[6]))(this, pbstrSRGS);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetXML([NativeTypeName("BSTR *")] ushort** pbstrXML)
    {
        return ((delegate* unmanaged<ITfInputScope, ushort**, int>)((*lpVtbl)[7]))(this, pbstrXML);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetInputScopes(InputScope** pprgInputScopes, uint* pcCount);

        [VtblIndex(4)]
        HRESULT GetPhrase([NativeTypeName("BSTR **")] ushort*** ppbstrPhrases, uint* pcCount);

        [VtblIndex(5)]
        HRESULT GetRegularExpression([NativeTypeName("BSTR *")] ushort** pbstrRegExp);

        [VtblIndex(6)]
        HRESULT GetSRGS([NativeTypeName("BSTR *")] ushort** pbstrSRGS);

        [VtblIndex(7)]
        HRESULT GetXML([NativeTypeName("BSTR *")] ushort** pbstrXML);
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

        [NativeTypeName("HRESULT (InputScope **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InputScope**, uint*, int> GetInputScopes;

        [NativeTypeName("HRESULT (BSTR **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort***, uint*, int> GetPhrase;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetRegularExpression;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSRGS;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetXML;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfInputScope"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfInputScope(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfInputScope"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfInputScope(Silk.NET.Windows.IUnknown value)
    {
        return new ITfInputScope(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfInputScope"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfInputScope"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfInputScope value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
