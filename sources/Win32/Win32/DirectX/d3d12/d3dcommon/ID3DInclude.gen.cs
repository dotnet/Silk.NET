// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Win32;
using System.Runtime.CompilerServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude"]/*'/>
public unsafe partial struct ID3DInclude : ID3DInclude.Native.Interface, INativeInterface
{
    public Native* lpVtbl;
    /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude.Open"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT Open(D3D_INCLUDE_TYPE IncludeType, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("LPCVOID")] void* pParentData, [NativeTypeName("LPCVOID *")] void** ppData, uint* pBytes) => lpVtbl->Open(IncludeType, pFileName, pParentData, ppData, pBytes);
    /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT Close([NativeTypeName("LPCVOID")] void* pData) => lpVtbl->Close(pData);
    /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude"]/*'/>
    public unsafe partial struct Native : ID3DInclude.Native.Interface
    {
        public void** lpVtbl;
        /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude.Open"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT Open(D3D_INCLUDE_TYPE IncludeType, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("LPCVOID")] void* pParentData, [NativeTypeName("LPCVOID *")] void** ppData, uint* pBytes)
        {
            return ((delegate* unmanaged<ID3DInclude.Native*, D3D_INCLUDE_TYPE, sbyte*, void*, void**, uint*, int> )(lpVtbl[0]))((ID3DInclude.Native*)Unsafe.AsPointer(ref this), IncludeType, pFileName, pParentData, ppData, pBytes);
        }

        /// <include file='ID3DInclude.xml' path='doc/member[@name="ID3DInclude.Close"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public HRESULT Close([NativeTypeName("LPCVOID")] void* pData)
        {
            return ((delegate* unmanaged<ID3DInclude.Native*, void*, int> )(lpVtbl[1]))((ID3DInclude.Native*)Unsafe.AsPointer(ref this), pData);
        }

        public interface Interface
        {
            [VtblIndex(0)]
            HRESULT Open(D3D_INCLUDE_TYPE IncludeType, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("LPCVOID")] void* pParentData, [NativeTypeName("LPCVOID *")] void** ppData, uint* pBytes);
            [VtblIndex(1)]
            HRESULT Close([NativeTypeName("LPCVOID")] void* pData);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (D3D_INCLUDE_TYPE, LPCSTR, LPCVOID, LPCVOID *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D_INCLUDE_TYPE, sbyte*, void*, void**, uint*, int> Open;
            [NativeTypeName("HRESULT (LPCVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*, int> Close;
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3DInclude"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3DInclude(Ptr2D* vtbl) => lpVtbl = (ID3DInclude.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3DInclude"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3DInclude(ID3DInclude.Native* vtbl) => lpVtbl = vtbl;
    /// <inheritdoc cref = "INativeInterface.GetAddressOf{TNativeInterface}()"></inheritdoc>
	public readonly TNativeInterface** GetAddressOf<TNativeInterface>()
        where TNativeInterface : unmanaged => (TNativeInterface**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
    /// <inheritdoc cref = "INativeInterface.GetAddressOf()"></inheritdoc>
	public readonly void** GetAddressOf() => (void**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
    /// <summary>casts <see cref = "ID3DInclude.Native"/> to <see cref = "ID3DInclude"/>.</summary>
    /// <param name = "value">The <see cref = "ID3DInclude.Native"/> instance to be converted </param>
    public static implicit operator ID3DInclude(ID3DInclude.Native* value) => new ID3DInclude(value);
    /// <summary>casts <see cref = "ID3DInclude"/> to <see cref = "ID3DInclude.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DInclude"/> instance to be converted </param>
    public static implicit operator ID3DInclude.Native*(ID3DInclude value) => value.lpVtbl;
    /// <summary>casts <see cref = "Ptr2D"/> to <see cref = "ID3DInclude"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr2D"/> instance to be converted </param>
    public static explicit operator ID3DInclude(Ptr2D* value) => new ID3DInclude(value);
    /// <summary>casts <see cref = "ID3DInclude"/> to <see cref = "Ptr2D"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DInclude"/> instance to be converted </param>
    public static implicit operator Ptr2D*(ID3DInclude value) => (Ptr2D*)value.lpVtbl;
    /// <summary>casts void*** pointer to <see cref = "ID3DInclude"/>.</summary>
    /// <param name = "value">The void*** instance to be converted</param>
    public static explicit operator ID3DInclude(void*** value) => new ID3DInclude((Native*)value);
    /// <summary>casts <see cref = "ID3DInclude"/> to void*** pointer</summary>
    /// <param name = "value">The <see cref = "ID3DInclude"/> instance to be converted </param>
    public static implicit operator void***(ID3DInclude value) => (void***)value.lpVtbl;
    /// <summary>casts nuint to <see cref = "ID3DInclude"/>.</summary>
    /// <param name = "value">The nuint instance to be converted</param>
    public static explicit operator ID3DInclude(nuint value) => new ID3DInclude((Native*)value.ToPointer());
    /// <summary>casts <see cref = "ID3DInclude"/> to nuint</summary>
    /// <param name = "value">The <see cref = "ID3DInclude"/> instance to be converted </param>
    public static implicit operator nuint(ID3DInclude value) => (nuint)value.lpVtbl;
}