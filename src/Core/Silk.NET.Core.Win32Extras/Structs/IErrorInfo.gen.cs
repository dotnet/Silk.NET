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
    [Guid("1cf2b120-547d-101b-8e65-08002b2bd119")]
    [NativeName("Name", "IErrorInfo")]
    public unsafe partial struct IErrorInfo : IComVtbl<IErrorInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("1cf2b120-547d-101b-8e65-08002b2bd119");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IErrorInfo val)
            => Unsafe.As<IErrorInfo, Silk.NET.Core.Native.IUnknown>(ref val);

        public IErrorInfo
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
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGUID(Guid* pGUID)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, Guid*, int>)@this->LpVtbl[3])(@this, pGUID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGUID(ref Guid pGUID)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pGUIDPtr = &pGUID)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, Guid*, int>)@this->LpVtbl[3])(@this, pGUIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSource(char** pBstrSource)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, char**, int>)@this->LpVtbl[4])(@this, pBstrSource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSource(ref char* pBstrSource)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrSourcePtr = &pBstrSource)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, char**, int>)@this->LpVtbl[4])(@this, pBstrSourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDescription(char** pBstrDescription)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, char**, int>)@this->LpVtbl[5])(@this, pBstrDescription);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDescription(ref char* pBstrDescription)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrDescriptionPtr = &pBstrDescription)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, char**, int>)@this->LpVtbl[5])(@this, pBstrDescriptionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHelpFile(char** pBstrHelpFile)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, char**, int>)@this->LpVtbl[6])(@this, pBstrHelpFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHelpFile(ref char* pBstrHelpFile)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, char**, int>)@this->LpVtbl[6])(@this, pBstrHelpFilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHelpContext(uint* pdwHelpContext)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, uint*, int>)@this->LpVtbl[7])(@this, pdwHelpContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetHelpContext(ref uint pdwHelpContext)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, uint*, int>)@this->LpVtbl[7])(@this, pdwHelpContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSource(string[] pBstrSourceSa)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrSource = (char**) SilkMarshal.StringArrayToPtr(pBstrSourceSa);
            var ret = @this->GetSource(pBstrSource);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrSource, pBstrSourceSa);
            SilkMarshal.Free((nint) pBstrSource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDescription(string[] pBstrDescriptionSa)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrDescription = (char**) SilkMarshal.StringArrayToPtr(pBstrDescriptionSa);
            var ret = @this->GetDescription(pBstrDescription);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrDescription, pBstrDescriptionSa);
            SilkMarshal.Free((nint) pBstrDescription);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetHelpFile(string[] pBstrHelpFileSa)
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
            var ret = @this->GetHelpFile(pBstrHelpFile);
            SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
            SilkMarshal.Free((nint) pBstrHelpFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
