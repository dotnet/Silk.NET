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
    [Guid("228b4687-5a6a-4730-900c-9702b2203f54")]
    [NativeName("Name", "IDxcCompiler3")]
    public unsafe partial struct IDxcCompiler3 : IComVtbl<IDxcCompiler3>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("228b4687-5a6a-4730-900c-9702b2203f54");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcCompiler3 val)
            => Unsafe.As<IDxcCompiler3, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcCompiler3
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
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riid, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riid, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riidPtr, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandler, riidPtr, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riid, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
            {
                fixed (void** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (void** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSource, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riid, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (void** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riid, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riidPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandler, riidPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riid, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArguments, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riid, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandler, riidPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (void** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riid, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, char**, uint, IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pArgumentsPtr, argCount, pIncludeHandlerPtr, riidPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pObject, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pObject, riid, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pObject, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pObject, riid, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pObject, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pObject, riidPtr, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pObject, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pObject, riidPtr, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pObject, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pObjectPtr = &pObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pObjectPtr, riid, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pObject, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pObjectPtr = &pObject)
            {
                fixed (void** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pObjectPtr, riid, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pObject, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pObjectPtr = &pObject)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pObjectPtr, riidPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pObject, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pObjectPtr = &pObject)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, Buffer*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pObjectPtr, riidPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pArguments, argCount, pIncludeHandler, riid, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, out ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResult = default;
            return @this->Compile(pSource, pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pArguments, argCount, pIncludeHandler, riid, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, Guid* riid, ref void* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(pSource, pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, riid, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pArguments, argCount, pIncludeHandler, ref riid, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, ref Guid riid, void** ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(pSource, pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref riid, ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pArguments, argCount, pIncludeHandler, ref riid, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, ref Guid riid, ref void* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(pSource, pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref riid, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pArguments, argCount, ref pIncludeHandler, riid, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, out ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResult = default;
            return @this->Compile(pSource, pArguments, argCount, ref pIncludeHandler, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pArguments, argCount, ref pIncludeHandler, riid, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pArguments, argCount, ref pIncludeHandler, ref riid, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pArguments, argCount, ref pIncludeHandler, ref riid, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, out ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResult = default;
            return @this->Compile(pSource, in pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, Guid* riid, ref void* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(pSource, in pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, riid, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, ref Guid riid, void** ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(pSource, in pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref riid, ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, ref Guid riid, ref void* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(pSource, in pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref riid, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, out ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResult = default;
            return @this->Compile(pSource, in pArguments, argCount, ref pIncludeHandler, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(in pSource, pArguments, argCount, pIncludeHandler, riid, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, out ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResult = default;
            return @this->Compile(in pSource, pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(in pSource, pArguments, argCount, pIncludeHandler, riid, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, Guid* riid, ref void* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(in pSource, pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, riid, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(in pSource, pArguments, argCount, pIncludeHandler, ref riid, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, ref Guid riid, void** ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(in pSource, pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref riid, ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, IDxcIncludeHandler* pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(in pSource, pArguments, argCount, pIncludeHandler, ref riid, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, ref Guid riid, ref void* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(in pSource, pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref riid, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(in pSource, pArguments, argCount, ref pIncludeHandler, riid, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, out ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResult = default;
            return @this->Compile(in pSource, pArguments, argCount, ref pIncludeHandler, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcIncludeHandler pIncludeHandler, Guid* riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(in pSource, pArguments, argCount, ref pIncludeHandler, riid, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, void** ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(in pSource, pArguments, argCount, ref pIncludeHandler, ref riid, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] pArgumentsSa, uint argCount, ref IDxcIncludeHandler pIncludeHandler, ref Guid riid, ref void* ppResult)
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(in pSource, pArguments, argCount, ref pIncludeHandler, ref riid, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, out ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResult = default;
            return @this->Compile(in pSource, in pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, Guid* riid, ref void* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(in pSource, in pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, riid, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, ref Guid riid, void** ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(in pSource, in pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref riid, ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ComPtr<TI0> pIncludeHandler, ref Guid riid, ref void* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(in pSource, in pArguments, argCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref riid, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler, out ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResult = default;
            return @this->Compile(in pSource, in pArguments, argCount, ref pIncludeHandler, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pObject, out ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResult = default;
            return @this->Disassemble(pObject, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Disassemble<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pObject, out ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResult = default;
            return @this->Disassemble(in pObject, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> Compile<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ComPtr<TI0> pIncludeHandler) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->Compile(pSource, pArguments, argCount, pIncludeHandler, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->Compile(pSource, pArguments, argCount, ref pIncludeHandler, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> Compile<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ComPtr<TI0> pIncludeHandler) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->Compile(pSource, in pArguments, argCount, pIncludeHandler, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->Compile(pSource, in pArguments, argCount, ref pIncludeHandler, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> Compile<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ComPtr<TI0> pIncludeHandler) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->Compile(in pSource, pArguments, argCount, pIncludeHandler, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->Compile(in pSource, pArguments, argCount, ref pIncludeHandler, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> Compile<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ComPtr<TI0> pIncludeHandler) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->Compile(in pSource, in pArguments, argCount, pIncludeHandler, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> Compile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* pArguments, uint argCount, ref IDxcIncludeHandler pIncludeHandler) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->Compile(in pSource, in pArguments, argCount, ref pIncludeHandler, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> Disassemble<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->Disassemble(pObject, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> Disassemble<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer pObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->Disassemble(in pObject, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
