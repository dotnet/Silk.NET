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

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("ae2cd79f-cc22-453f-9b6b-b124e7a5204c")]
    [NativeName("Name", "IDxcOptimizerPass")]
    public unsafe partial struct IDxcOptimizerPass : IComVtbl<IDxcOptimizerPass>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("ae2cd79f-cc22-453f-9b6b-b124e7a5204c");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcOptimizerPass val)
            => Unsafe.As<IDxcOptimizerPass, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcOptimizerPass
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
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionName(char** ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)@this->LpVtbl[3])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionName(ref char* ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)@this->LpVtbl[3])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDescription(char** ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)@this->LpVtbl[4])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDescription(ref char* ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)@this->LpVtbl[4])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionArgCount(uint* pCount)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint*, int>)@this->LpVtbl[5])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetOptionArgCount(ref uint pCount)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint*, int>)@this->LpVtbl[5])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionArgName(uint argIndex, char** ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)@this->LpVtbl[6])(@this, argIndex, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionArgName(uint argIndex, ref char* ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)@this->LpVtbl[6])(@this, argIndex, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionArgDescription(uint argIndex, char** ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)@this->LpVtbl[7])(@this, argIndex, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionArgDescription(uint argIndex, ref char* ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)@this->LpVtbl[7])(@this, argIndex, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetOptionName(string[] ppResultSa)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var ppResult = (char**) SilkMarshal.StringArrayToPtr(ppResultSa);
            var ret = @this->GetOptionName(ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) ppResult, ppResultSa);
            SilkMarshal.Free((nint) ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDescription(string[] ppResultSa)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var ppResult = (char**) SilkMarshal.StringArrayToPtr(ppResultSa);
            var ret = @this->GetDescription(ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) ppResult, ppResultSa);
            SilkMarshal.Free((nint) ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetOptionArgName(uint argIndex, string[] ppResultSa)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var ppResult = (char**) SilkMarshal.StringArrayToPtr(ppResultSa);
            var ret = @this->GetOptionArgName(argIndex, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) ppResult, ppResultSa);
            SilkMarshal.Free((nint) ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetOptionArgDescription(uint argIndex, string[] ppResultSa)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var ppResult = (char**) SilkMarshal.StringArrayToPtr(ppResultSa);
            var ret = @this->GetOptionArgDescription(argIndex, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) ppResult, ppResultSa);
            SilkMarshal.Free((nint) ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
