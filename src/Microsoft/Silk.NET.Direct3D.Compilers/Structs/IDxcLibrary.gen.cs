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
    [Guid("e5204dc7-d18c-4c3c-bdfb-851673980fe7")]
    [NativeName("Name", "IDxcLibrary")]
    public unsafe partial struct IDxcLibrary
    {
        public static readonly Guid Guid = new("e5204dc7-d18c-4c3c-bdfb-851673980fe7");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcLibrary val)
            => Unsafe.As<IDxcLibrary, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcLibrary
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
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetMalloc(IMalloc* pMalloc)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcLibrary*, IMalloc*, int>)LpVtbl[3])(@this, pMalloc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IMalloc*, int>)LpVtbl[3])(@this, pMalloc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IMalloc*, int>)LpVtbl[3])(@this, pMalloc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMalloc(ref IMalloc pMalloc)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMalloc* pMallocPtr = &pMalloc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, IMalloc*, int>)LpVtbl[3])(@this, pMallocPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IMalloc*, int>)LpVtbl[3])(@this, pMallocPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IMalloc*, int>)LpVtbl[3])(@this, pMallocPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromBlob(IDxcBlob* pBlob, uint offset, uint length, IDxcBlob** ppResult)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlob, offset, length, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlob, offset, length, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlob, offset, length, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromBlob(IDxcBlob* pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlob, offset, length, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlob, offset, length, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlob, offset, length, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromBlob(ref IDxcBlob pBlob, uint offset, uint length, IDxcBlob** ppResult)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlobPtr, offset, length, ppResult);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlobPtr, offset, length, ppResult);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlobPtr, offset, length, ppResult);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromBlob(ref IDxcBlob pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlob** ppResultPtr = &ppResult)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlobPtr, offset, length, ppResultPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlobPtr, offset, length, ppResultPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlobPtr, offset, length, ppResultPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromFile(char* pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePage, pBlobEncoding);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePage, pBlobEncoding);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePage, pBlobEncoding);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromFile(char* pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePage, pBlobEncodingPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePage, pBlobEncodingPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePage, pBlobEncodingPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromFile(char* pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* codePagePtr = &codePage)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncoding);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncoding);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncoding);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromFile(char* pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* codePagePtr = &codePage)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncodingPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncodingPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncodingPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromFile(ref char pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFileNamePtr = &pFileName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromFile(ref char pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFileNamePtr = &pFileName)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromFile(ref char pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFileNamePtr = &pFileName)
            {
                fixed (uint* codePagePtr = &codePage)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromFile(ref char pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFileNamePtr = &pFileName)
            {
                fixed (uint* codePagePtr = &codePage)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
            }
            #endif
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
            fixed (uint* codePagePtr = &codePage)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
                }
            #endif
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
            fixed (uint* codePagePtr = &codePage)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
                    }
            #endif
                }
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingFromPinned(void* pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pText, size, codePage, pBlobEncoding);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pText, size, codePage, pBlobEncoding);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pText, size, codePage, pBlobEncoding);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingFromPinned(void* pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pText, size, codePage, pBlobEncodingPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pText, size, codePage, pBlobEncodingPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pText, size, codePage, pBlobEncodingPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingFromPinned<T0>(ref T0 pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pTextPtr = &pText)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncoding);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncoding);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncoding);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingFromPinned<T0>(ref T0 pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pTextPtr = &pText)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnHeapCopy(void* pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pText, size, codePage, pBlobEncoding);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pText, size, codePage, pBlobEncoding);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pText, size, codePage, pBlobEncoding);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnHeapCopy(void* pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pText, size, codePage, pBlobEncodingPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pText, size, codePage, pBlobEncodingPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pText, size, codePage, pBlobEncodingPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnHeapCopy<T0>(ref T0 pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pTextPtr = &pText)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncoding);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncoding);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncoding);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnHeapCopy<T0>(ref T0 pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pTextPtr = &pText)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc(void* pText, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncoding);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncoding);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncoding);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc(void* pText, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncodingPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncodingPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncodingPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc(void* pText, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncoding);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncoding);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncoding);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc(void* pText, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncodingPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncodingPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncodingPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc<T0>(ref T0 pText, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pTextPtr = &pText)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncoding);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncoding);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncoding);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc<T0>(ref T0 pText, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pTextPtr = &pText)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncodingPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncodingPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncodingPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc<T0>(ref T0 pText, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pTextPtr = &pText)
            {
                fixed (IMalloc* pIMallocPtr = &pIMalloc)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncoding);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncoding);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncoding);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc<T0>(ref T0 pText, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pTextPtr = &pText)
            {
                fixed (IMalloc* pIMallocPtr = &pIMalloc)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncodingPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncodingPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncodingPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateIncludeHandler(IDxcIncludeHandler** ppResult)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcLibrary*, IDxcIncludeHandler**, int>)LpVtbl[9])(@this, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcIncludeHandler**, int>)LpVtbl[9])(@this, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcIncludeHandler**, int>)LpVtbl[9])(@this, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateIncludeHandler(ref IDxcIncludeHandler* ppResult)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, IDxcIncludeHandler**, int>)LpVtbl[9])(@this, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcIncludeHandler**, int>)LpVtbl[9])(@this, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcIncludeHandler**, int>)LpVtbl[9])(@this, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromBlobReadOnly(IDxcBlob* pBlob, void** ppStream)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlob, ppStream);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlob, ppStream);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlob, ppStream);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromBlobReadOnly(IDxcBlob* pBlob, ref void* ppStream)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppStreamPtr = &ppStream)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlob, ppStreamPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlob, ppStreamPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlob, ppStreamPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromBlobReadOnly(ref IDxcBlob pBlob, void** ppStream)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlobPtr, ppStream);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlobPtr, ppStream);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlobPtr, ppStream);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromBlobReadOnly(ref IDxcBlob pBlob, ref void* ppStream)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (void** ppStreamPtr = &ppStream)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlobPtr, ppStreamPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlobPtr, ppStreamPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlobPtr, ppStreamPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf8(IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlob, pBlobEncoding);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlob, pBlobEncoding);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlob, pBlobEncoding);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf8(IDxcBlob* pBlob, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlob, pBlobEncodingPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlob, pBlobEncodingPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlob, pBlobEncodingPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf8(ref IDxcBlob pBlob, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlobPtr, pBlobEncoding);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlobPtr, pBlobEncoding);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlobPtr, pBlobEncoding);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf8(ref IDxcBlob pBlob, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlobPtr, pBlobEncodingPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlobPtr, pBlobEncodingPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlobPtr, pBlobEncodingPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf16(IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlob, pBlobEncoding);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlob, pBlobEncoding);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlob, pBlobEncoding);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf16(IDxcBlob* pBlob, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlob, pBlobEncodingPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlob, pBlobEncodingPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlob, pBlobEncodingPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf16(ref IDxcBlob pBlob, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlobPtr, pBlobEncoding);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlobPtr, pBlobEncoding);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlobPtr, pBlobEncoding);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf16(ref IDxcBlob pBlob, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlobPtr, pBlobEncodingPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlobPtr, pBlobEncodingPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlobPtr, pBlobEncodingPtr);
                    }
            #endif
                }
            }
            return ret;
        }

    }
}
