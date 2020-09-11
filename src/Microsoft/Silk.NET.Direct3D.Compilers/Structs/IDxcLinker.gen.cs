// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    [NativeName("Name", "IDxcLinker")]
    public unsafe partial struct IDxcLinker
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcLinker val)
            => Unsafe.As<IDxcLinker, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDxcLinker* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDxcLinker
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLinker*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDxcLinker* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcLinker*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDxcLinker* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcLinker*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterLibrary(char* pLibName, IDxcBlob* pLib)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLinker*, char*, IDxcBlob*, int>)LpVtbl[3])(@this, pLibName, pLib);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterLibrary(char* pLibName, ref IDxcBlob pLib)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pLibPtr = &pLib)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, char*, IDxcBlob*, int>)LpVtbl[3])(@this, pLibName, pLibPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterLibrary(ref char pLibName, IDxcBlob* pLib)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pLibNamePtr = &pLibName)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, char*, IDxcBlob*, int>)LpVtbl[3])(@this, pLibNamePtr, pLib);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int RegisterLibrary(ref char pLibName, ref IDxcBlob pLib)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pLibNamePtr = &pLibName)
                {
                    fixed (IDxcBlob* pLibPtr = &pLib)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, IDxcBlob*, int>)LpVtbl[3])(@this, pLibNamePtr, pLibPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterLibrary(string pLibName, IDxcBlob* pLib)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pLibNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pLibName);
                ret = ((delegate* cdecl<IDxcLinker*, byte*, IDxcBlob*, int>)LpVtbl[3])(@this, pLibNamePtr, pLib);
            Marshal.FreeHGlobal((IntPtr)pLibNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int RegisterLibrary(string pLibName, ref IDxcBlob pLib)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pLibNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pLibName);
                fixed (IDxcBlob* pLibPtr = &pLib)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, byte*, IDxcBlob*, int>)LpVtbl[3])(@this, pLibNamePtr, pLibPtr);
                }
            Marshal.FreeHGlobal((IntPtr)pLibNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(char* pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pLibNamesPtr = &pLibNames)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pLibNamesPtr = &pLibNames)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pLibNamesPtr = &pLibNames)
                        {
                            fixed (char** pArgumentsPtr = &pArguments)
                            {
                                ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
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
                                    ret = ((delegate* cdecl<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                    ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                        }
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
                fixed (char* pEntryNamePtr = &pEntryName)
                {
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                        }
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref char pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
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
                                ret = ((delegate* cdecl<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                            }
                        }
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                        }
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                        }
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
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
                                ret = ((delegate* cdecl<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                            }
                        }
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                ret = ((delegate* cdecl<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    ret = ((delegate* cdecl<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* cdecl<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(string pEntryName, string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            fixed (IDxcLinker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetProfilePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetProfile);
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* cdecl<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pTargetProfilePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

    }
}
