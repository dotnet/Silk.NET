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
    [Guid("f1b5be2a-62dd-4327-a1c2-42ac1e1e78e6")]
    [NativeName("Name", "IDxcLinker")]
    public unsafe partial struct IDxcLinker
    {
        public static readonly Guid Guid = new("f1b5be2a-62dd-4327-a1c2-42ac1e1e78e6");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcLinker val)
            => Unsafe.As<IDxcLinker, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcLinker
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
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterLibrary(char* pLibName, IDxcBlob* pLib)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, IDxcBlob*, int>)LpVtbl[3])(@this, pLibName, pLib);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterLibrary(char* pLibName, ref IDxcBlob pLib)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pLibPtr = &pLib)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, IDxcBlob*, int>)LpVtbl[3])(@this, pLibName, pLibPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterLibrary(ref char pLibName, IDxcBlob* pLib)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pLibNamePtr = &pLibName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, IDxcBlob*, int>)LpVtbl[3])(@this, pLibNamePtr, pLib);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterLibrary(ref char pLibName, ref IDxcBlob pLib)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pLibNamePtr = &pLibName)
            {
                fixed (IDxcBlob* pLibPtr = &pLib)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, IDxcBlob*, int>)LpVtbl[3])(@this, pLibNamePtr, pLibPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterLibrary(string pLibName, IDxcBlob* pLib)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pLibNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pLibName);
            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, IDxcBlob*, int>)LpVtbl[3])(@this, pLibNamePtr, pLib);
            Marshal.FreeHGlobal((nint)pLibNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterLibrary(string pLibName, ref IDxcBlob pLib)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pLibNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pLibName);
            fixed (IDxcBlob* pLibPtr = &pLib)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, IDxcBlob*, int>)LpVtbl[3])(@this, pLibNamePtr, pLibPtr);
            }
            Marshal.FreeHGlobal((nint)pLibNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                }
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                }
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(char* pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref char pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryNamePtr = &pEntryName)
            {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResultPtr);
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                }
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                }
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(string pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
            Marshal.FreeHGlobal((nint)pTargetProfilePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

    }
}
