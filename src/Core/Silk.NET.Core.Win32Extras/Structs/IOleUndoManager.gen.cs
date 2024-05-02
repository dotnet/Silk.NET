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
    [Guid("d001f200-ef97-11ce-9bc9-00aa00608e01")]
    [NativeName("Name", "IOleUndoManager")]
    public unsafe partial struct IOleUndoManager : IComVtbl<IOleUndoManager>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d001f200-ef97-11ce-9bc9-00aa00608e01");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IOleUndoManager val)
            => Unsafe.As<IOleUndoManager, Silk.NET.Core.Native.IUnknown>(ref val);

        public IOleUndoManager
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
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(IOleParentUndoUnit* pPUU)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleParentUndoUnit*, int>)@this->LpVtbl[3])(@this, pPUU);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Open(ref IOleParentUndoUnit pPUU)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IOleParentUndoUnit* pPUUPtr = &pPUU)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleParentUndoUnit*, int>)@this->LpVtbl[3])(@this, pPUUPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Close(IOleParentUndoUnit* pPUU, Silk.NET.Core.Bool32 fCommit)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleParentUndoUnit*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[4])(@this, pPUU, fCommit);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Close(ref IOleParentUndoUnit pPUU, Silk.NET.Core.Bool32 fCommit)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IOleParentUndoUnit* pPUUPtr = &pPUU)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleParentUndoUnit*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[4])(@this, pPUUPtr, fCommit);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Add(IOleUndoUnit* pUU)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[5])(@this, pUU);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Add(ref IOleUndoUnit pUU)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IOleUndoUnit* pUUPtr = &pUU)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[5])(@this, pUUPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOpenParentState(uint* pdwState)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, uint*, int>)@this->LpVtbl[6])(@this, pdwState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetOpenParentState(ref uint pdwState)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwStatePtr = &pdwState)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, uint*, int>)@this->LpVtbl[6])(@this, pdwStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DiscardFrom(IOleUndoUnit* pUU)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[7])(@this, pUU);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DiscardFrom(ref IOleUndoUnit pUU)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IOleUndoUnit* pUUPtr = &pUU)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[7])(@this, pUUPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UndoTo(IOleUndoUnit* pUU)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[8])(@this, pUU);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UndoTo(ref IOleUndoUnit pUU)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IOleUndoUnit* pUUPtr = &pUU)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[8])(@this, pUUPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RedoTo(IOleUndoUnit* pUU)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[9])(@this, pUU);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RedoTo(ref IOleUndoUnit pUU)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IOleUndoUnit* pUUPtr = &pUU)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[9])(@this, pUUPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumUndoable(IEnumOleUndoUnits** ppEnum)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IEnumOleUndoUnits**, int>)@this->LpVtbl[10])(@this, ppEnum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumUndoable(ref IEnumOleUndoUnits* ppEnum)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumOleUndoUnits** ppEnumPtr = &ppEnum)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IEnumOleUndoUnits**, int>)@this->LpVtbl[10])(@this, ppEnumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumRedoable(IEnumOleUndoUnits** ppEnum)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IEnumOleUndoUnits**, int>)@this->LpVtbl[11])(@this, ppEnum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumRedoable(ref IEnumOleUndoUnits* ppEnum)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumOleUndoUnits** ppEnumPtr = &ppEnum)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IEnumOleUndoUnits**, int>)@this->LpVtbl[11])(@this, ppEnumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastUndoDescription(char** pBstr)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, char**, int>)@this->LpVtbl[12])(@this, pBstr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastUndoDescription(ref char* pBstr)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrPtr = &pBstr)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, char**, int>)@this->LpVtbl[12])(@this, pBstrPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastRedoDescription(char** pBstr)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, char**, int>)@this->LpVtbl[13])(@this, pBstr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastRedoDescription(ref char* pBstr)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrPtr = &pBstr)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, char**, int>)@this->LpVtbl[13])(@this, pBstrPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Enable(Silk.NET.Core.Bool32 fEnable)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[14])(@this, fEnable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Open<TI0>(ComPtr<TI0> pPUU) where TI0 : unmanaged, IComVtbl<IOleParentUndoUnit>, IComVtbl<TI0>
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Open((IOleParentUndoUnit*) pPUU.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Close<TI0>(ComPtr<TI0> pPUU, Silk.NET.Core.Bool32 fCommit) where TI0 : unmanaged, IComVtbl<IOleParentUndoUnit>, IComVtbl<TI0>
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Close((IOleParentUndoUnit*) pPUU.Handle, fCommit);
        }

        /// <summary>To be documented.</summary>
        public readonly int Add<TI0>(ComPtr<TI0> pUU) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Add((IOleUndoUnit*) pUU.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DiscardFrom<TI0>(ComPtr<TI0> pUU) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DiscardFrom((IOleUndoUnit*) pUU.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int UndoTo<TI0>(ComPtr<TI0> pUU) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UndoTo((IOleUndoUnit*) pUU.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int RedoTo<TI0>(ComPtr<TI0> pUU) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RedoTo((IOleUndoUnit*) pUU.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumUndoable<TI0>(ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<IEnumOleUndoUnits>, IComVtbl<TI0>
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnumUndoable((IEnumOleUndoUnits**) ppEnum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumRedoable<TI0>(ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<IEnumOleUndoUnits>, IComVtbl<TI0>
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnumRedoable((IEnumOleUndoUnits**) ppEnum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLastUndoDescription(string[] pBstrSa)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstr = (char**) SilkMarshal.StringArrayToPtr(pBstrSa);
            var ret = @this->GetLastUndoDescription(pBstr);
            SilkMarshal.CopyPtrToStringArray((nint) pBstr, pBstrSa);
            SilkMarshal.Free((nint) pBstr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLastRedoDescription(string[] pBstrSa)
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstr = (char**) SilkMarshal.StringArrayToPtr(pBstrSa);
            var ret = @this->GetLastRedoDescription(pBstr);
            SilkMarshal.CopyPtrToStringArray((nint) pBstr, pBstrSa);
            SilkMarshal.Free((nint) pBstr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IOleUndoManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
