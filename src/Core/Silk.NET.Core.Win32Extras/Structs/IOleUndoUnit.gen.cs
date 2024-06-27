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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("894ad3b0-ef97-11ce-9bc9-00aa00608e01")]
    [NativeName("Name", "IOleUndoUnit")]
    public unsafe partial struct IOleUndoUnit : IComVtbl<IOleUndoUnit>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("894ad3b0-ef97-11ce-9bc9-00aa00608e01");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IOleUndoUnit val)
            => Unsafe.As<IOleUndoUnit, Silk.NET.Core.Native.IUnknown>(ref val);

        public IOleUndoUnit
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
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Do(IOleUndoManager* pUndoManager)
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, IOleUndoManager*, int>)@this->LpVtbl[3])(@this, pUndoManager);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Do(ref IOleUndoManager pUndoManager)
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IOleUndoManager* pUndoManagerPtr = &pUndoManager)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, IOleUndoManager*, int>)@this->LpVtbl[3])(@this, pUndoManagerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDescription(char** pBstr)
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, char**, int>)@this->LpVtbl[4])(@this, pBstr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDescription(ref char* pBstr)
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrPtr = &pBstr)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, char**, int>)@this->LpVtbl[4])(@this, pBstrPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnitType(Guid* pClsid, int* plID)
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, int*, int>)@this->LpVtbl[5])(@this, pClsid, plID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnitType(Guid* pClsid, ref int plID)
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* plIDPtr = &plID)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, int*, int>)@this->LpVtbl[5])(@this, pClsid, plIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnitType(ref Guid pClsid, int* plID)
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pClsidPtr = &pClsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, int*, int>)@this->LpVtbl[5])(@this, pClsidPtr, plID);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetUnitType(ref Guid pClsid, ref int plID)
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pClsidPtr = &pClsid)
            {
                fixed (int* plIDPtr = &plID)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, int*, int>)@this->LpVtbl[5])(@this, pClsidPtr, plIDPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int OnNextAdd()
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, int>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Do<TI0>(ComPtr<TI0> pUndoManager) where TI0 : unmanaged, IComVtbl<IOleUndoManager>, IComVtbl<TI0>
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Do((IOleUndoManager*) pUndoManager.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDescription(string[] pBstrSa)
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstr = (char**) SilkMarshal.StringArrayToPtr(pBstrSa);
            var ret = @this->GetDescription(pBstr);
            SilkMarshal.CopyPtrToStringArray((nint) pBstr, pBstrSa);
            SilkMarshal.Free((nint) pBstr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOleUndoUnit*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
