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
    public unsafe partial struct IDxcLinker : IComVtbl<IDxcLinker>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("f1b5be2a-62dd-4327-a1c2-42ac1e1e78e6");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterLibrary([Flow(FlowDirection.In)] nint* pLibName, IDxcBlob* pLib)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Thiscall]<IDxcLinker*, nint*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pLibName, pLib);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterLibrary([Flow(FlowDirection.In)] nint* pLibName, ref IDxcBlob pLib)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pLibPtr = &pLib)
            {
                ret = ((delegate* unmanaged[Thiscall]<IDxcLinker*, nint*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pLibName, pLibPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterLibrary([Flow(FlowDirection.In)] in nint pLibName, IDxcBlob* pLib)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pLibNamePtr = &pLibName)
            {
                ret = ((delegate* unmanaged[Thiscall]<IDxcLinker*, nint*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pLibNamePtr, pLib);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterLibrary([Flow(FlowDirection.In)] in nint pLibName, ref IDxcBlob pLib)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pLibNamePtr = &pLibName)
            {
                fixed (IDxcBlob* pLibPtr = &pLib)
                {
                    ret = ((delegate* unmanaged[Thiscall]<IDxcLinker*, nint*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pLibNamePtr, pLibPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryNamePtr = &pEntryName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pLibNamesPtr = &pLibNames)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, nint*, nint*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterLibrary<TI0>([Flow(FlowDirection.In)] nint* pLibName, ComPtr<TI0> pLib) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterLibrary(pLibName, (IDxcBlob*) pLib.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterLibrary<TI0>([Flow(FlowDirection.In)] in nint pLibName, ComPtr<TI0> pLib) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterLibrary(in pLibName, (IDxcBlob*) pLib.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, in pArguments, argCount, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, in pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, in pArguments, argCount, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(pEntryName, pTargetProfile, in pLibNames, libCount, pArguments, argCount, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(pEntryName, pTargetProfile, in pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(pEntryName, pTargetProfile, in pLibNames, libCount, pArguments, argCount, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(pEntryName, pTargetProfile, in pLibNames, libCount, in pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(pEntryName, in pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(pEntryName, in pTargetProfile, pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(pEntryName, in pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var ret = @this->Link(pEntryName, in pTargetProfile, pLibNames, libCount, in pArguments, argCount, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(pEntryName, in pTargetProfile, pLibNames, libCount, in pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var ret = @this->Link(pEntryName, in pTargetProfile, pLibNames, libCount, in pArguments, argCount, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(pEntryName, in pTargetProfile, in pLibNames, libCount, pArguments, argCount, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(pEntryName, in pTargetProfile, in pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(pEntryName, in pTargetProfile, in pLibNames, libCount, pArguments, argCount, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] nint* pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(pEntryName, in pTargetProfile, in pLibNames, libCount, in pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(in pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(in pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(in pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var ret = @this->Link(in pEntryName, pTargetProfile, pLibNames, libCount, in pArguments, argCount, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(in pEntryName, pTargetProfile, pLibNames, libCount, in pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var ret = @this->Link(in pEntryName, pTargetProfile, pLibNames, libCount, in pArguments, argCount, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(in pEntryName, pTargetProfile, in pLibNames, libCount, pArguments, argCount, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(in pEntryName, pTargetProfile, in pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(in pEntryName, pTargetProfile, in pLibNames, libCount, pArguments, argCount, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(in pEntryName, pTargetProfile, in pLibNames, libCount, in pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(in pEntryName, in pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(in pEntryName, in pTargetProfile, pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(in pEntryName, in pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var ret = @this->Link(in pEntryName, in pTargetProfile, pLibNames, libCount, in pArguments, argCount, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(in pEntryName, in pTargetProfile, pLibNames, libCount, in pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pLibNamesSa, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
            var ret = @this->Link(in pEntryName, in pTargetProfile, pLibNames, libCount, in pArguments, argCount, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
            SilkMarshal.Free((nint) pLibNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(in pEntryName, in pTargetProfile, in pLibNames, libCount, pArguments, argCount, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(in pEntryName, in pTargetProfile, in pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Link(in pEntryName, in pTargetProfile, in pLibNames, libCount, pArguments, argCount, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>([Flow(FlowDirection.In)] in nint pEntryName, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pLibNames, uint libCount, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(in pEntryName, in pTargetProfile, in pLibNames, libCount, in pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
