// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Guid("a721791a-0def-4d06-bd91-2118bf1db10b")]
    [NativeName("Name", "IWICMetadataQueryWriter")]
    public unsafe partial struct IWICMetadataQueryWriter : IComVtbl<IWICMetadataQueryWriter>, IComVtbl<IWICMetadataQueryReader>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a721791a-0def-4d06-bd91-2118bf1db10b");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICMetadataQueryReader(IWICMetadataQueryWriter val)
            => Unsafe.As<IWICMetadataQueryWriter, IWICMetadataQueryReader>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICMetadataQueryWriter val)
            => Unsafe.As<IWICMetadataQueryWriter, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICMetadataQueryWriter
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainerFormat(Guid* pguidContainerFormat)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, Guid*, int>)@this->LpVtbl[3])(@this, pguidContainerFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContainerFormat(ref Guid pguidContainerFormat)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidContainerFormatPtr = &pguidContainerFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, Guid*, int>)@this->LpVtbl[3])(@this, pguidContainerFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocation(uint cchMaxLength, char* wzNamespace, uint* pcchActualLength)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, uint, char*, uint*, int>)@this->LpVtbl[4])(@this, cchMaxLength, wzNamespace, pcchActualLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocation(uint cchMaxLength, char* wzNamespace, ref uint pcchActualLength)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualLengthPtr = &pcchActualLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, uint, char*, uint*, int>)@this->LpVtbl[4])(@this, cchMaxLength, wzNamespace, pcchActualLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocation(uint cchMaxLength, ref char wzNamespace, uint* pcchActualLength)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzNamespacePtr = &wzNamespace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, uint, char*, uint*, int>)@this->LpVtbl[4])(@this, cchMaxLength, wzNamespacePtr, pcchActualLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLocation(uint cchMaxLength, ref char wzNamespace, ref uint pcchActualLength)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzNamespacePtr = &wzNamespace)
            {
                fixed (uint* pcchActualLengthPtr = &pcchActualLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, uint, char*, uint*, int>)@this->LpVtbl[4])(@this, cchMaxLength, wzNamespacePtr, pcchActualLengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocation(uint cchMaxLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzNamespace, uint* pcchActualLength)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzNamespacePtr = (byte*) SilkMarshal.StringToPtr(wzNamespace, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, cchMaxLength, wzNamespacePtr, pcchActualLength);
            SilkMarshal.Free((nint)wzNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLocation(uint cchMaxLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzNamespace, ref uint pcchActualLength)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzNamespacePtr = (byte*) SilkMarshal.StringToPtr(wzNamespace, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualLengthPtr = &pcchActualLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, cchMaxLength, wzNamespacePtr, pcchActualLengthPtr);
            }
            SilkMarshal.Free((nint)wzNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzName, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, char*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[5])(@this, wzName, pvarValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzName, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, char*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[5])(@this, wzName, pvarValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char wzName, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzNamePtr = &wzName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, char*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[5])(@this, wzNamePtr, pvarValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char wzName, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzNamePtr = &wzName)
            {
                fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, char*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[5])(@this, wzNamePtr, pvarValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzName, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzNamePtr = (byte*) SilkMarshal.StringToPtr(wzName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, byte*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[5])(@this, wzNamePtr, pvarValue);
            SilkMarshal.Free((nint)wzNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzName, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzNamePtr = (byte*) SilkMarshal.StringToPtr(wzName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, byte*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[5])(@this, wzNamePtr, pvarValuePtr);
            }
            SilkMarshal.Free((nint)wzNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEnumerator(Silk.NET.Core.Win32Extras.IEnumString** ppIEnumString)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, Silk.NET.Core.Win32Extras.IEnumString**, int>)@this->LpVtbl[6])(@this, ppIEnumString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEnumerator(ref Silk.NET.Core.Win32Extras.IEnumString* ppIEnumString)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IEnumString** ppIEnumStringPtr = &ppIEnumString)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, Silk.NET.Core.Win32Extras.IEnumString**, int>)@this->LpVtbl[6])(@this, ppIEnumStringPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, char*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, wzName, pvarValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.PropVariant pvarValue)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, char*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, wzName, pvarValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char wzName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzNamePtr = &wzName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, char*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, wzNamePtr, pvarValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char wzName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.PropVariant pvarValue)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzNamePtr = &wzName)
            {
                fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, char*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, wzNamePtr, pvarValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzNamePtr = (byte*) SilkMarshal.StringToPtr(wzName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, byte*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, wzNamePtr, pvarValue);
            SilkMarshal.Free((nint)wzNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.PropVariant pvarValue)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzNamePtr = (byte*) SilkMarshal.StringToPtr(wzName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, byte*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, wzNamePtr, pvarValuePtr);
            }
            SilkMarshal.Free((nint)wzNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzName)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, char*, int>)@this->LpVtbl[8])(@this, wzName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char wzName)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzNamePtr = &wzName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, char*, int>)@this->LpVtbl[8])(@this, wzNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveMetadataByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzName)
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzNamePtr = (byte*) SilkMarshal.StringToPtr(wzName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryWriter*, byte*, int>)@this->LpVtbl[8])(@this, wzNamePtr);
            SilkMarshal.Free((nint)wzNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICMetadataQueryWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
