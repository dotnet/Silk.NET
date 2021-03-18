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

namespace Silk.NET.SDL
{
    public unsafe partial class Sdl : NativeAPI
    {
        /* Function prototypes */
        /**
         *  \brief This function allows access to driver-dependent window information.
         *
         *  \param window The window about which information is being requested
         *  \param info This structure must be initialized with the SDL version, and is
         *              then filled in with information about the given window.
         *
         *  \return SDL_TRUE if the function is implemented and the version member of
         *          the \c info struct is valid, SDL_FALSE otherwise.
         *
         *  You typically use this function like this:
         *  \code
         *  SDL_SysWMinfo info;
         *  SDL_VERSION(&info.version);
         *  if ( SDL_GetWindowWMInfo(window, &info) ) { ... }
         *  \endcode
         */
        [NativeApi(EntryPoint = "SDL_GetWindowWMInfo")]
        public unsafe partial bool GetWindowWMInfo(Window* window, SysWMInfo* info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 188, Column 38 in build/submodules/SDL-mirror/include/SDL_platform.h")]
        [NativeApi(EntryPoint = "SDL_GetPlatform")]
        public unsafe partial byte* GetPlatform();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 188, Column 38 in build/submodules/SDL-mirror/include/SDL_platform.h")]
        [NativeApi(EntryPoint = "SDL_GetPlatform")]
        public partial string GetPlatformS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 361, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_malloc")]
        public unsafe partial void* Malloc(uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 362, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_calloc")]
        public unsafe partial void* Calloc(uint nmemb, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_realloc")]
        public unsafe partial void* Realloc(void* mem, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_realloc")]
        public unsafe partial void* Realloc<T0>(ref T0 mem, uint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 364, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_free")]
        public unsafe partial void Free(void* mem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 364, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_free")]
        public partial void Free<T0>(ref T0 mem) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(PfnMallocFunc* malloc_func, PfnCallocFunc* calloc_func, PfnReallocFunc* realloc_func, PfnFreeFunc* free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(PfnMallocFunc* malloc_func, PfnCallocFunc* calloc_func, PfnReallocFunc* realloc_func, ref PfnFreeFunc free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(PfnMallocFunc* malloc_func, PfnCallocFunc* calloc_func, ref PfnReallocFunc realloc_func, PfnFreeFunc* free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(PfnMallocFunc* malloc_func, PfnCallocFunc* calloc_func, ref PfnReallocFunc realloc_func, ref PfnFreeFunc free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(PfnMallocFunc* malloc_func, ref PfnCallocFunc calloc_func, PfnReallocFunc* realloc_func, PfnFreeFunc* free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(PfnMallocFunc* malloc_func, ref PfnCallocFunc calloc_func, PfnReallocFunc* realloc_func, ref PfnFreeFunc free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(PfnMallocFunc* malloc_func, ref PfnCallocFunc calloc_func, ref PfnReallocFunc realloc_func, PfnFreeFunc* free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(PfnMallocFunc* malloc_func, ref PfnCallocFunc calloc_func, ref PfnReallocFunc realloc_func, ref PfnFreeFunc free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(ref PfnMallocFunc malloc_func, PfnCallocFunc* calloc_func, PfnReallocFunc* realloc_func, PfnFreeFunc* free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(ref PfnMallocFunc malloc_func, PfnCallocFunc* calloc_func, PfnReallocFunc* realloc_func, ref PfnFreeFunc free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(ref PfnMallocFunc malloc_func, PfnCallocFunc* calloc_func, ref PfnReallocFunc realloc_func, PfnFreeFunc* free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(ref PfnMallocFunc malloc_func, PfnCallocFunc* calloc_func, ref PfnReallocFunc realloc_func, ref PfnFreeFunc free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(ref PfnMallocFunc malloc_func, ref PfnCallocFunc calloc_func, PfnReallocFunc* realloc_func, PfnFreeFunc* free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(ref PfnMallocFunc malloc_func, ref PfnCallocFunc calloc_func, PfnReallocFunc* realloc_func, ref PfnFreeFunc free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(ref PfnMallocFunc malloc_func, ref PfnCallocFunc calloc_func, ref PfnReallocFunc realloc_func, PfnFreeFunc* free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public partial void GetMemoryFunctions(ref PfnMallocFunc malloc_func, ref PfnCallocFunc calloc_func, ref PfnReallocFunc realloc_func, ref PfnFreeFunc free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 387, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_SetMemoryFunctions")]
        public partial int SetMemoryFunctions(PfnMallocFunc malloc_func, PfnCallocFunc calloc_func, PfnReallocFunc realloc_func, PfnFreeFunc free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 395, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetNumAllocations")]
        public partial int GetNumAllocations();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_getenv")]
        public unsafe partial byte* Getenv(byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_getenv")]
        public unsafe partial string GetenvS(byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_getenv")]
        public unsafe partial byte* Getenv(ref byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_getenv")]
        public partial string GetenvS(ref byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_getenv")]
        public unsafe partial byte* Getenv(string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_getenv")]
        public partial string GetenvS(string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_setenv")]
        public unsafe partial int Setenv(byte* name, byte* value, int overwrite);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_setenv")]
        public unsafe partial int Setenv(byte* name, ref byte value, int overwrite);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_setenv")]
        public unsafe partial int Setenv(byte* name, string value, int overwrite);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_setenv")]
        public unsafe partial int Setenv(ref byte name, byte* value, int overwrite);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_setenv")]
        public partial int Setenv(ref byte name, ref byte value, int overwrite);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_setenv")]
        public partial int Setenv(ref byte name, string value, int overwrite);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_setenv")]
        public unsafe partial int Setenv(string name, byte* value, int overwrite);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_setenv")]
        public partial int Setenv(string name, ref byte value, int overwrite);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_setenv")]
        public partial int Setenv(string name, string value, int overwrite);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 400, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_qsort")]
        public unsafe partial void Qsort(void* @base, uint nmemb, uint size, PfnVvVvI compare);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 400, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_qsort")]
        public partial void Qsort<T0>(ref T0 @base, uint nmemb, uint size, PfnVvVvI compare) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 402, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_abs")]
        public partial int Abs(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 409, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isdigit")]
        public partial int Isdigit(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 410, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isspace")]
        public partial int Isspace(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 411, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isupper")]
        public partial int Isupper(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_islower")]
        public partial int Islower(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 413, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_toupper")]
        public partial int Toupper(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 414, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_tolower")]
        public partial int Tolower(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 416, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memset")]
        public unsafe partial void* Memset(void* dst, int c, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 416, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memset")]
        public unsafe partial void* Memset<T0>(ref T0 dst, int c, uint len) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcpy")]
        public unsafe partial void* Memcpy(void* dst, void* src, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcpy")]
        public unsafe partial void* Memcpy<T0>(void* dst, ref T0 src, uint len) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcpy")]
        public unsafe partial void* Memcpy<T0>(ref T0 dst, void* src, uint len) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcpy")]
        public unsafe partial void* Memcpy<T0, T1>(ref T0 dst, ref T1 src, uint len) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memmove")]
        public unsafe partial void* Memmove(void* dst, void* src, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memmove")]
        public unsafe partial void* Memmove<T0>(void* dst, ref T0 src, uint len) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memmove")]
        public unsafe partial void* Memmove<T0>(ref T0 dst, void* src, uint len) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memmove")]
        public unsafe partial void* Memmove<T0, T1>(ref T0 dst, ref T1 src, uint len) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 456, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcmp")]
        public unsafe partial int Memcmp(void* s1, void* s2, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 456, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcmp")]
        public unsafe partial int Memcmp<T0>(void* s1, ref T0 s2, uint len) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 456, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcmp")]
        public unsafe partial int Memcmp<T0>(ref T0 s1, void* s2, uint len) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 456, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcmp")]
        public partial int Memcmp<T0, T1>(ref T0 s1, ref T1 s2, uint len) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 458, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslen")]
        public unsafe partial uint Wcslen(char* wstr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 458, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslen")]
        public partial uint Wcslen(ref char wstr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 458, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslen")]
        public partial uint Wcslen(string wstr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcpy")]
        public unsafe partial uint Wcslcpy(char* dst, char* src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcpy")]
        public unsafe partial uint Wcslcpy(char* dst, ref char src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcpy")]
        public unsafe partial uint Wcslcpy(char* dst, string src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcpy")]
        public unsafe partial uint Wcslcpy(ref char dst, char* src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcpy")]
        public partial uint Wcslcpy(ref char dst, ref char src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcpy")]
        public partial uint Wcslcpy(ref char dst, string src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcpy")]
        public unsafe partial uint Wcslcpy(string dst, char* src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcpy")]
        public partial uint Wcslcpy(string dst, ref char src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcpy")]
        public partial uint Wcslcpy(string dst, string src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcat")]
        public unsafe partial uint Wcslcat(char* dst, char* src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcat")]
        public unsafe partial uint Wcslcat(char* dst, ref char src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcat")]
        public unsafe partial uint Wcslcat(char* dst, string src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcat")]
        public unsafe partial uint Wcslcat(ref char dst, char* src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcat")]
        public partial uint Wcslcat(ref char dst, ref char src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcat")]
        public partial uint Wcslcat(ref char dst, string src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcat")]
        public unsafe partial uint Wcslcat(string dst, char* src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcat")]
        public partial uint Wcslcat(string dst, ref char src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcat")]
        public partial uint Wcslcat(string dst, string src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 461, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsdup")]
        public unsafe partial char* Wcsdup(char* wstr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 461, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsdup")]
        public unsafe partial string WcsdupS(char* wstr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 461, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsdup")]
        public unsafe partial char* Wcsdup(ref char wstr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 461, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsdup")]
        public partial string WcsdupS(ref char wstr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 461, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsdup")]
        public unsafe partial char* Wcsdup(string wstr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 461, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsdup")]
        public partial string WcsdupS(string wstr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial char* Wcsstr(char* haystack, char* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial string WcsstrS(char* haystack, char* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial char* Wcsstr(char* haystack, ref char needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial string WcsstrS(char* haystack, ref char needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial char* Wcsstr(char* haystack, string needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial string WcsstrS(char* haystack, string needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial char* Wcsstr(ref char haystack, char* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial string WcsstrS(ref char haystack, char* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial char* Wcsstr(ref char haystack, ref char needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public partial string WcsstrS(ref char haystack, ref char needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial char* Wcsstr(ref char haystack, string needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public partial string WcsstrS(ref char haystack, string needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial char* Wcsstr(string haystack, char* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial string WcsstrS(string haystack, char* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial char* Wcsstr(string haystack, ref char needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public partial string WcsstrS(string haystack, ref char needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial char* Wcsstr(string haystack, string needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public partial string WcsstrS(string haystack, string needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscmp")]
        public unsafe partial int Wcscmp(char* str1, char* str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscmp")]
        public unsafe partial int Wcscmp(char* str1, ref char str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscmp")]
        public unsafe partial int Wcscmp(char* str1, string str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscmp")]
        public unsafe partial int Wcscmp(ref char str1, char* str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscmp")]
        public partial int Wcscmp(ref char str1, ref char str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscmp")]
        public partial int Wcscmp(ref char str1, string str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscmp")]
        public unsafe partial int Wcscmp(string str1, char* str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscmp")]
        public partial int Wcscmp(string str1, ref char str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscmp")]
        public partial int Wcscmp(string str1, string str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncmp")]
        public unsafe partial int Wcsncmp(char* str1, char* str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncmp")]
        public unsafe partial int Wcsncmp(char* str1, ref char str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncmp")]
        public unsafe partial int Wcsncmp(char* str1, string str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncmp")]
        public unsafe partial int Wcsncmp(ref char str1, char* str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncmp")]
        public partial int Wcsncmp(ref char str1, ref char str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncmp")]
        public partial int Wcsncmp(ref char str1, string str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncmp")]
        public unsafe partial int Wcsncmp(string str1, char* str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncmp")]
        public partial int Wcsncmp(string str1, ref char str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncmp")]
        public partial int Wcsncmp(string str1, string str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 467, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlen")]
        public unsafe partial uint Strlen(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 467, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlen")]
        public partial uint Strlen(ref byte str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 467, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlen")]
        public partial uint Strlen(string str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcpy")]
        public unsafe partial uint Strlcpy(byte* dst, byte* src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcpy")]
        public unsafe partial uint Strlcpy(byte* dst, ref byte src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcpy")]
        public unsafe partial uint Strlcpy(byte* dst, string src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcpy")]
        public unsafe partial uint Strlcpy(ref byte dst, byte* src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcpy")]
        public partial uint Strlcpy(ref byte dst, ref byte src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcpy")]
        public partial uint Strlcpy(ref byte dst, string src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcpy")]
        public unsafe partial uint Strlcpy(string dst, byte* src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcpy")]
        public partial uint Strlcpy(string dst, ref byte src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcpy")]
        public partial uint Strlcpy(string dst, string src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlcpy")]
        public unsafe partial uint Utf8strlcpy(byte* dst, byte* src, uint dst_bytes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlcpy")]
        public unsafe partial uint Utf8strlcpy(byte* dst, ref byte src, uint dst_bytes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlcpy")]
        public unsafe partial uint Utf8strlcpy(byte* dst, string src, uint dst_bytes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlcpy")]
        public unsafe partial uint Utf8strlcpy(ref byte dst, byte* src, uint dst_bytes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlcpy")]
        public partial uint Utf8strlcpy(ref byte dst, ref byte src, uint dst_bytes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlcpy")]
        public partial uint Utf8strlcpy(ref byte dst, string src, uint dst_bytes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlcpy")]
        public unsafe partial uint Utf8strlcpy(string dst, byte* src, uint dst_bytes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlcpy")]
        public partial uint Utf8strlcpy(string dst, ref byte src, uint dst_bytes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlcpy")]
        public partial uint Utf8strlcpy(string dst, string src, uint dst_bytes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcat")]
        public unsafe partial uint Strlcat(byte* dst, byte* src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcat")]
        public unsafe partial uint Strlcat(byte* dst, ref byte src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcat")]
        public unsafe partial uint Strlcat(byte* dst, string src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcat")]
        public unsafe partial uint Strlcat(ref byte dst, byte* src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcat")]
        public partial uint Strlcat(ref byte dst, ref byte src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcat")]
        public partial uint Strlcat(ref byte dst, string src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcat")]
        public unsafe partial uint Strlcat(string dst, byte* src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcat")]
        public partial uint Strlcat(string dst, ref byte src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcat")]
        public partial uint Strlcat(string dst, string src, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 471, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strdup")]
        public unsafe partial byte* Strdup(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 471, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strdup")]
        public unsafe partial string StrdupS(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 471, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strdup")]
        public unsafe partial byte* Strdup(ref byte str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 471, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strdup")]
        public partial string StrdupS(ref byte str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 471, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strdup")]
        public unsafe partial byte* Strdup(string str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 471, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strdup")]
        public partial string StrdupS(string str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrev")]
        public unsafe partial byte* Strrev(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrev")]
        public unsafe partial string StrrevS(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrev")]
        public unsafe partial byte* Strrev(ref byte str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrev")]
        public partial string StrrevS(ref byte str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrev")]
        public unsafe partial byte* Strrev(string str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrev")]
        public partial string StrrevS(string str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strupr")]
        public unsafe partial byte* Strupr(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strupr")]
        public unsafe partial string StruprS(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strupr")]
        public unsafe partial byte* Strupr(ref byte str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strupr")]
        public partial string StruprS(ref byte str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strupr")]
        public unsafe partial byte* Strupr(string str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strupr")]
        public partial string StruprS(string str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlwr")]
        public unsafe partial byte* Strlwr(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlwr")]
        public unsafe partial string StrlwrS(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlwr")]
        public unsafe partial byte* Strlwr(ref byte str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlwr")]
        public partial string StrlwrS(ref byte str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlwr")]
        public unsafe partial byte* Strlwr(string str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlwr")]
        public partial string StrlwrS(string str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 475, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strchr")]
        public unsafe partial byte* Strchr(byte* str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 475, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strchr")]
        public unsafe partial string StrchrS(byte* str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 475, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strchr")]
        public unsafe partial byte* Strchr(ref byte str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 475, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strchr")]
        public partial string StrchrS(ref byte str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 475, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strchr")]
        public unsafe partial byte* Strchr(string str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 475, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strchr")]
        public partial string StrchrS(string str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 476, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrchr")]
        public unsafe partial byte* Strrchr(byte* str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 476, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrchr")]
        public unsafe partial string StrrchrS(byte* str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 476, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrchr")]
        public unsafe partial byte* Strrchr(ref byte str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 476, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrchr")]
        public partial string StrrchrS(ref byte str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 476, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrchr")]
        public unsafe partial byte* Strrchr(string str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 476, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrchr")]
        public partial string StrrchrS(string str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial byte* Strstr(byte* haystack, byte* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial string StrstrS(byte* haystack, byte* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial byte* Strstr(byte* haystack, ref byte needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial string StrstrS(byte* haystack, ref byte needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial byte* Strstr(byte* haystack, string needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial string StrstrS(byte* haystack, string needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial byte* Strstr(ref byte haystack, byte* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial string StrstrS(ref byte haystack, byte* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial byte* Strstr(ref byte haystack, ref byte needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public partial string StrstrS(ref byte haystack, ref byte needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial byte* Strstr(ref byte haystack, string needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public partial string StrstrS(ref byte haystack, string needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial byte* Strstr(string haystack, byte* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial string StrstrS(string haystack, byte* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial byte* Strstr(string haystack, ref byte needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public partial string StrstrS(string haystack, ref byte needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial byte* Strstr(string haystack, string needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public partial string StrstrS(string haystack, string needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(byte* s1, byte* s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(byte* s1, byte* s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(byte* s1, byte* s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(byte* s1, byte* s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(byte* s1, ref byte s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(byte* s1, ref byte s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(byte* s1, ref byte s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(byte* s1, ref byte s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(byte* s1, string s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(byte* s1, string s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(byte* s1, string s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(byte* s1, string s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(ref byte s1, byte* s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(ref byte s1, byte* s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(ref byte s1, byte* s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(ref byte s1, byte* s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(ref byte s1, ref byte s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(ref byte s1, ref byte s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(ref byte s1, ref byte s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(ref byte s1, ref byte s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(ref byte s1, string s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(ref byte s1, string s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(ref byte s1, string s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(ref byte s1, string s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(string s1, byte* s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(string s1, byte* s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(string s1, byte* s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(string s1, byte* s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(string s1, ref byte s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(string s1, ref byte s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(string s1, ref byte s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(string s1, ref byte s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(string s1, string s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(string s1, string s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(string s1, string s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial string StrtokrS(string s1, string s2, ref byte* saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlen")]
        public unsafe partial uint Utf8strlen(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlen")]
        public partial uint Utf8strlen(ref byte str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlen")]
        public partial uint Utf8strlen(string str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 481, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_itoa")]
        public unsafe partial byte* Itoa(int value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 481, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_itoa")]
        public unsafe partial string ItoaS(int value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 481, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_itoa")]
        public unsafe partial byte* Itoa(int value, ref byte str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 481, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_itoa")]
        public partial string ItoaS(int value, ref byte str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 481, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_itoa")]
        public unsafe partial byte* Itoa(int value, string str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 481, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_itoa")]
        public partial string ItoaS(int value, string str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 482, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_uitoa")]
        public unsafe partial byte* Uitoa(uint value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 482, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_uitoa")]
        public unsafe partial string UitoaS(uint value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 482, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_uitoa")]
        public unsafe partial byte* Uitoa(uint value, ref byte str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 482, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_uitoa")]
        public partial string UitoaS(uint value, ref byte str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 482, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_uitoa")]
        public unsafe partial byte* Uitoa(uint value, string str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 482, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_uitoa")]
        public partial string UitoaS(uint value, string str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 483, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ltoa")]
        public unsafe partial byte* Ltoa(int value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 483, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ltoa")]
        public unsafe partial string LtoaS(int value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 483, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ltoa")]
        public unsafe partial byte* Ltoa(int value, ref byte str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 483, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ltoa")]
        public partial string LtoaS(int value, ref byte str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 483, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ltoa")]
        public unsafe partial byte* Ltoa(int value, string str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 483, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ltoa")]
        public partial string LtoaS(int value, string str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 484, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ultoa")]
        public unsafe partial byte* Ultoa(uint value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 484, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ultoa")]
        public unsafe partial string UltoaS(uint value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 484, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ultoa")]
        public unsafe partial byte* Ultoa(uint value, ref byte str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 484, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ultoa")]
        public partial string UltoaS(uint value, ref byte str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 484, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ultoa")]
        public unsafe partial byte* Ultoa(uint value, string str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 484, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ultoa")]
        public partial string UltoaS(uint value, string str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 485, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_lltoa")]
        public unsafe partial byte* Lltoa(long value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 485, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_lltoa")]
        public unsafe partial string LltoaS(long value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 485, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_lltoa")]
        public unsafe partial byte* Lltoa(long value, ref byte str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 485, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_lltoa")]
        public partial string LltoaS(long value, ref byte str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 485, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_lltoa")]
        public unsafe partial byte* Lltoa(long value, string str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 485, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_lltoa")]
        public partial string LltoaS(long value, string str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 486, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ulltoa")]
        public unsafe partial byte* Ulltoa(ulong value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 486, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ulltoa")]
        public unsafe partial string UlltoaS(ulong value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 486, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ulltoa")]
        public unsafe partial byte* Ulltoa(ulong value, ref byte str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 486, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ulltoa")]
        public partial string UlltoaS(ulong value, ref byte str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 486, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ulltoa")]
        public unsafe partial byte* Ulltoa(ulong value, string str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 486, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ulltoa")]
        public partial string UlltoaS(ulong value, string str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 488, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atoi")]
        public unsafe partial int Atoi(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 488, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atoi")]
        public partial int Atoi(ref byte str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 488, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atoi")]
        public partial int Atoi(string str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atof")]
        public unsafe partial double Atof(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atof")]
        public partial double Atof(ref byte str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atof")]
        public partial double Atof(string str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtol")]
        public unsafe partial int Strtol(byte* str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtol")]
        public unsafe partial int Strtol(byte* str, ref byte* endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtol")]
        public unsafe partial int Strtol(ref byte str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtol")]
        public unsafe partial int Strtol(ref byte str, ref byte* endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtol")]
        public unsafe partial int Strtol(string str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtol")]
        public unsafe partial int Strtol(string str, ref byte* endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoul")]
        public unsafe partial uint Strtoul(byte* str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoul")]
        public unsafe partial uint Strtoul(byte* str, ref byte* endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoul")]
        public unsafe partial uint Strtoul(ref byte str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoul")]
        public unsafe partial uint Strtoul(ref byte str, ref byte* endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoul")]
        public unsafe partial uint Strtoul(string str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoul")]
        public unsafe partial uint Strtoul(string str, ref byte* endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoll")]
        public unsafe partial long Strtoll(byte* str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoll")]
        public unsafe partial long Strtoll(byte* str, ref byte* endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoll")]
        public unsafe partial long Strtoll(ref byte str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoll")]
        public unsafe partial long Strtoll(ref byte str, ref byte* endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoll")]
        public unsafe partial long Strtoll(string str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoll")]
        public unsafe partial long Strtoll(string str, ref byte* endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoull")]
        public unsafe partial ulong Strtoull(byte* str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoull")]
        public unsafe partial ulong Strtoull(byte* str, ref byte* endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoull")]
        public unsafe partial ulong Strtoull(ref byte str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoull")]
        public unsafe partial ulong Strtoull(ref byte str, ref byte* endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoull")]
        public unsafe partial ulong Strtoull(string str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoull")]
        public unsafe partial ulong Strtoull(string str, ref byte* endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtod")]
        public unsafe partial double Strtod(byte* str, byte** endp);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtod")]
        public unsafe partial double Strtod(byte* str, ref byte* endp);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtod")]
        public unsafe partial double Strtod(ref byte str, byte** endp);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtod")]
        public unsafe partial double Strtod(ref byte str, ref byte* endp);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtod")]
        public unsafe partial double Strtod(string str, byte** endp);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtod")]
        public unsafe partial double Strtod(string str, ref byte* endp);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcmp")]
        public unsafe partial int Strcmp(byte* str1, byte* str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcmp")]
        public unsafe partial int Strcmp(byte* str1, ref byte str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcmp")]
        public unsafe partial int Strcmp(byte* str1, string str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcmp")]
        public unsafe partial int Strcmp(ref byte str1, byte* str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcmp")]
        public partial int Strcmp(ref byte str1, ref byte str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcmp")]
        public partial int Strcmp(ref byte str1, string str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcmp")]
        public unsafe partial int Strcmp(string str1, byte* str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcmp")]
        public partial int Strcmp(string str1, ref byte str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcmp")]
        public partial int Strcmp(string str1, string str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncmp")]
        public unsafe partial int Strncmp(byte* str1, byte* str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncmp")]
        public unsafe partial int Strncmp(byte* str1, ref byte str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncmp")]
        public unsafe partial int Strncmp(byte* str1, string str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncmp")]
        public unsafe partial int Strncmp(ref byte str1, byte* str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncmp")]
        public partial int Strncmp(ref byte str1, ref byte str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncmp")]
        public partial int Strncmp(ref byte str1, string str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncmp")]
        public unsafe partial int Strncmp(string str1, byte* str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncmp")]
        public partial int Strncmp(string str1, ref byte str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncmp")]
        public partial int Strncmp(string str1, string str2, uint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasecmp")]
        public unsafe partial int Strcasecmp(byte* str1, byte* str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasecmp")]
        public unsafe partial int Strcasecmp(byte* str1, ref byte str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasecmp")]
        public unsafe partial int Strcasecmp(byte* str1, string str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasecmp")]
        public unsafe partial int Strcasecmp(ref byte str1, byte* str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasecmp")]
        public partial int Strcasecmp(ref byte str1, ref byte str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasecmp")]
        public partial int Strcasecmp(ref byte str1, string str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasecmp")]
        public unsafe partial int Strcasecmp(string str1, byte* str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasecmp")]
        public partial int Strcasecmp(string str1, ref byte str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasecmp")]
        public partial int Strcasecmp(string str1, string str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncasecmp")]
        public unsafe partial int Strncasecmp(byte* str1, byte* str2, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncasecmp")]
        public unsafe partial int Strncasecmp(byte* str1, ref byte str2, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncasecmp")]
        public unsafe partial int Strncasecmp(byte* str1, string str2, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncasecmp")]
        public unsafe partial int Strncasecmp(ref byte str1, byte* str2, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncasecmp")]
        public partial int Strncasecmp(ref byte str1, ref byte str2, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncasecmp")]
        public partial int Strncasecmp(ref byte str1, string str2, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncasecmp")]
        public unsafe partial int Strncasecmp(string str1, byte* str2, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncasecmp")]
        public partial int Strncasecmp(string str1, ref byte str2, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncasecmp")]
        public partial int Strncasecmp(string str1, string str2, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sscanf")]
        public unsafe partial int Sscanf(byte* text, byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sscanf")]
        public unsafe partial int Sscanf(byte* text, ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sscanf")]
        public unsafe partial int Sscanf(byte* text, string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sscanf")]
        public unsafe partial int Sscanf(ref byte text, byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sscanf")]
        public partial int Sscanf(ref byte text, ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sscanf")]
        public partial int Sscanf(ref byte text, string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sscanf")]
        public unsafe partial int Sscanf(string text, byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sscanf")]
        public partial int Sscanf(string text, ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sscanf")]
        public partial int Sscanf(string text, string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(byte* text, byte* fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(byte* text, byte* fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(byte* text, byte* fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(byte* text, ref byte fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(byte* text, ref byte fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(byte* text, ref byte fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(byte* text, string fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(byte* text, string fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(byte* text, string fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(ref byte text, byte* fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(ref byte text, byte* fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(ref byte text, byte* fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(ref byte text, ref byte fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public partial int Vsscanf(ref byte text, ref byte fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public partial int Vsscanf(ref byte text, ref byte fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(ref byte text, string fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public partial int Vsscanf(ref byte text, string fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public partial int Vsscanf(ref byte text, string fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(string text, byte* fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(string text, byte* fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(string text, byte* fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(string text, ref byte fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public partial int Vsscanf(string text, ref byte fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public partial int Vsscanf(string text, ref byte fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf(string text, string fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public partial int Vsscanf(string text, string fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public partial int Vsscanf(string text, string fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_snprintf")]
        public unsafe partial int Snprintf(byte* text, uint maxlen, byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_snprintf")]
        public unsafe partial int Snprintf(byte* text, uint maxlen, ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_snprintf")]
        public unsafe partial int Snprintf(byte* text, uint maxlen, string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_snprintf")]
        public unsafe partial int Snprintf(ref byte text, uint maxlen, byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_snprintf")]
        public partial int Snprintf(ref byte text, uint maxlen, ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_snprintf")]
        public partial int Snprintf(ref byte text, uint maxlen, string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_snprintf")]
        public unsafe partial int Snprintf(string text, uint maxlen, byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_snprintf")]
        public partial int Snprintf(string text, uint maxlen, ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_snprintf")]
        public partial int Snprintf(string text, uint maxlen, string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(byte* text, uint maxlen, byte* fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(byte* text, uint maxlen, byte* fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(byte* text, uint maxlen, byte* fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(byte* text, uint maxlen, ref byte fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(byte* text, uint maxlen, ref byte fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(byte* text, uint maxlen, ref byte fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(byte* text, uint maxlen, string fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(byte* text, uint maxlen, string fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(byte* text, uint maxlen, string fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(ref byte text, uint maxlen, byte* fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(ref byte text, uint maxlen, byte* fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(ref byte text, uint maxlen, byte* fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(ref byte text, uint maxlen, ref byte fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public partial int Vsnprintf(ref byte text, uint maxlen, ref byte fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public partial int Vsnprintf(ref byte text, uint maxlen, ref byte fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(ref byte text, uint maxlen, string fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public partial int Vsnprintf(ref byte text, uint maxlen, string fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public partial int Vsnprintf(ref byte text, uint maxlen, string fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(string text, uint maxlen, byte* fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(string text, uint maxlen, byte* fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(string text, uint maxlen, byte* fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(string text, uint maxlen, ref byte fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public partial int Vsnprintf(string text, uint maxlen, ref byte fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public partial int Vsnprintf(string text, uint maxlen, ref byte fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(string text, uint maxlen, string fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public partial int Vsnprintf(string text, uint maxlen, string fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public partial int Vsnprintf(string text, uint maxlen, string fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_acos")]
        public partial double Acos(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 513, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_acosf")]
        public partial float Acosf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 514, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_asin")]
        public partial double Asin(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 515, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_asinf")]
        public partial float Asinf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 516, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atan")]
        public partial double Atan(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 517, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atanf")]
        public partial float Atanf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 518, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atan2")]
        public partial double Atan2(double x, double y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atan2f")]
        public partial float Atan2f(float x, float y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 520, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ceil")]
        public partial double Ceil(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ceilf")]
        public partial float Ceilf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 522, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_copysign")]
        public partial double Copysign(double x, double y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 523, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_copysignf")]
        public partial float Copysignf(float x, float y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 524, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_cos")]
        public partial double Cos(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_cosf")]
        public partial float Cosf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 526, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_exp")]
        public partial double Exp(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_expf")]
        public partial float Expf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 528, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_fabs")]
        public partial double Fabs(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 529, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_fabsf")]
        public partial float Fabsf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_floor")]
        public partial double Floor(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 531, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_floorf")]
        public partial float Floorf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_fmod")]
        public partial double Fmod(double x, double y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 533, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_fmodf")]
        public partial float Fmodf(float x, float y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 534, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_log")]
        public partial double Log(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 535, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_logf")]
        public partial float Logf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 536, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_log10")]
        public partial double Log10(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 537, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_log10f")]
        public partial float Log10f(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 538, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_pow")]
        public partial double Pow(double x, double y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 539, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_powf")]
        public partial float Powf(float x, float y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 540, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_scalbn")]
        public partial double Scalbn(double x, int n);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_scalbnf")]
        public partial float Scalbnf(float x, int n);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 542, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sin")]
        public partial double Sin(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 543, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sinf")]
        public partial float Sinf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 544, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sqrt")]
        public partial double Sqrt(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 545, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sqrtf")]
        public partial float Sqrtf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 546, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_tan")]
        public partial double Tan(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 547, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_tanf")]
        public partial float Tanf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_open")]
        public unsafe partial Icon* IconvOpen(byte* tocode, byte* fromcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_open")]
        public unsafe partial Icon* IconvOpen(byte* tocode, ref byte fromcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_open")]
        public unsafe partial Icon* IconvOpen(byte* tocode, string fromcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_open")]
        public unsafe partial Icon* IconvOpen(ref byte tocode, byte* fromcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_open")]
        public unsafe partial Icon* IconvOpen(ref byte tocode, ref byte fromcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_open")]
        public unsafe partial Icon* IconvOpen(ref byte tocode, string fromcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_open")]
        public unsafe partial Icon* IconvOpen(string tocode, byte* fromcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_open")]
        public unsafe partial Icon* IconvOpen(string tocode, ref byte fromcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_open")]
        public unsafe partial Icon* IconvOpen(string tocode, string fromcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 559, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_close")]
        public unsafe partial int IconvClose(Icon* cd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 559, Column 29 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_close")]
        public partial int IconvClose(ref Icon cd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, byte** inbuf, uint* inbytesleft, byte** outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, byte** inbuf, uint* inbytesleft, byte** outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, byte** inbuf, uint* inbytesleft, ref byte* outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, byte** inbuf, uint* inbytesleft, ref byte* outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, byte** inbuf, ref uint inbytesleft, byte** outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, byte** inbuf, ref uint inbytesleft, byte** outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, byte** inbuf, ref uint inbytesleft, ref byte* outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, byte** inbuf, ref uint inbytesleft, ref byte* outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, ref byte* inbuf, uint* inbytesleft, byte** outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, ref byte* inbuf, uint* inbytesleft, byte** outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, ref byte* inbuf, uint* inbytesleft, ref byte* outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, ref byte* inbuf, uint* inbytesleft, ref byte* outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, ref byte* inbuf, ref uint inbytesleft, byte** outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, ref byte* inbuf, ref uint inbytesleft, byte** outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, ref byte* inbuf, ref uint inbytesleft, ref byte* outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(Icon* cd, ref byte* inbuf, ref uint inbytesleft, ref byte* outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, byte** inbuf, uint* inbytesleft, byte** outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, byte** inbuf, uint* inbytesleft, byte** outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, byte** inbuf, uint* inbytesleft, ref byte* outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, byte** inbuf, uint* inbytesleft, ref byte* outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, byte** inbuf, ref uint inbytesleft, byte** outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, byte** inbuf, ref uint inbytesleft, byte** outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, byte** inbuf, ref uint inbytesleft, ref byte* outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, byte** inbuf, ref uint inbytesleft, ref byte* outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, ref byte* inbuf, uint* inbytesleft, byte** outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, ref byte* inbuf, uint* inbytesleft, byte** outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, ref byte* inbuf, uint* inbytesleft, ref byte* outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, ref byte* inbuf, uint* inbytesleft, ref byte* outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, ref byte* inbuf, ref uint inbytesleft, byte** outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, ref byte* inbuf, ref uint inbytesleft, byte** outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, ref byte* inbuf, ref uint inbytesleft, ref byte* outbuf, uint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial uint Iconv(ref Icon cd, ref byte* inbuf, ref uint inbytesleft, ref byte* outbuf, ref uint outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(byte* tocode, byte* fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(byte* tocode, byte* fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(byte* tocode, byte* fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(byte* tocode, byte* fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(byte* tocode, byte* fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(byte* tocode, byte* fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(byte* tocode, ref byte fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(byte* tocode, ref byte fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(byte* tocode, ref byte fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(byte* tocode, ref byte fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(byte* tocode, ref byte fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(byte* tocode, ref byte fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(byte* tocode, string fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(byte* tocode, string fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(byte* tocode, string fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(byte* tocode, string fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(byte* tocode, string fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(byte* tocode, string fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(ref byte tocode, byte* fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(ref byte tocode, byte* fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(ref byte tocode, byte* fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(ref byte tocode, byte* fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(ref byte tocode, byte* fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(ref byte tocode, byte* fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(ref byte tocode, ref byte fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(ref byte tocode, ref byte fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(ref byte tocode, ref byte fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public partial string IconvStringS(ref byte tocode, ref byte fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(ref byte tocode, ref byte fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public partial string IconvStringS(ref byte tocode, ref byte fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(ref byte tocode, string fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(ref byte tocode, string fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(ref byte tocode, string fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public partial string IconvStringS(ref byte tocode, string fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(ref byte tocode, string fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public partial string IconvStringS(ref byte tocode, string fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(string tocode, byte* fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(string tocode, byte* fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(string tocode, byte* fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(string tocode, byte* fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(string tocode, byte* fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(string tocode, byte* fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(string tocode, ref byte fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(string tocode, ref byte fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(string tocode, ref byte fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public partial string IconvStringS(string tocode, ref byte fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(string tocode, ref byte fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public partial string IconvStringS(string tocode, ref byte fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(string tocode, string fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial string IconvStringS(string tocode, string fromcode, byte* inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(string tocode, string fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public partial string IconvStringS(string tocode, string fromcode, ref byte inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString(string tocode, string fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public partial string IconvStringS(string tocode, string fromcode, string inbuf, uint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 344, Column 37 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetPixelFormatName")]
        public unsafe partial byte* GetPixelFormatName(uint format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 344, Column 37 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetPixelFormatName")]
        public partial string GetPixelFormatNameS(uint format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, uint* Rmask, uint* Gmask, uint* Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, uint* Rmask, uint* Gmask, uint* Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, uint* Rmask, uint* Gmask, ref uint Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, uint* Rmask, uint* Gmask, ref uint Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, uint* Rmask, ref uint Gmask, uint* Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, uint* Rmask, ref uint Gmask, uint* Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, uint* Rmask, ref uint Gmask, ref uint Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, uint* Rmask, ref uint Gmask, ref uint Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, ref uint Rmask, uint* Gmask, uint* Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, ref uint Rmask, uint* Gmask, uint* Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, ref uint Rmask, uint* Gmask, ref uint Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, ref uint Rmask, uint* Gmask, ref uint Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, ref uint Rmask, ref uint Gmask, uint* Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, ref uint Rmask, ref uint Gmask, uint* Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, ref uint Rmask, ref uint Gmask, ref uint Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, ref uint Rmask, ref uint Gmask, ref uint Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, uint* Rmask, uint* Gmask, uint* Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, uint* Rmask, uint* Gmask, uint* Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, uint* Rmask, uint* Gmask, ref uint Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, uint* Rmask, uint* Gmask, ref uint Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, uint* Rmask, ref uint Gmask, uint* Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, uint* Rmask, ref uint Gmask, uint* Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, uint* Rmask, ref uint Gmask, ref uint Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, uint* Rmask, ref uint Gmask, ref uint Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, ref uint Rmask, uint* Gmask, uint* Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, ref uint Rmask, uint* Gmask, uint* Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, ref uint Rmask, uint* Gmask, ref uint Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, ref uint Rmask, uint* Gmask, ref uint Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, ref uint Rmask, ref uint Gmask, uint* Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, ref uint Rmask, ref uint Gmask, uint* Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, ref uint Rmask, ref uint Gmask, ref uint Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 34 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public partial SdlBool PixelFormatEnumToMasks(uint format, ref int bpp, ref uint Rmask, ref uint Gmask, ref uint Bmask, ref uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 368, Column 32 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_MasksToPixelFormatEnum")]
        public partial uint MasksToPixelFormatEnum(int bpp, uint Rmask, uint Gmask, uint Bmask, uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 377, Column 43 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_AllocFormat")]
        public unsafe partial PixelFormat* AllocFormat(uint pixel_format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 382, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_FreeFormat")]
        public unsafe partial void FreeFormat(PixelFormat* format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 382, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_FreeFormat")]
        public partial void FreeFormat(ref PixelFormat format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 394, Column 38 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_AllocPalette")]
        public unsafe partial Palette* AllocPalette(int ncolors);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 399, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPixelFormatPalette")]
        public unsafe partial int SetPixelFormatPalette(PixelFormat* format, Palette* palette);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 399, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPixelFormatPalette")]
        public unsafe partial int SetPixelFormatPalette(PixelFormat* format, ref Palette palette);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 399, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPixelFormatPalette")]
        public unsafe partial int SetPixelFormatPalette(ref PixelFormat format, Palette* palette);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 399, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPixelFormatPalette")]
        public partial int SetPixelFormatPalette(ref PixelFormat format, ref Palette palette);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPaletteColors")]
        public unsafe partial int SetPaletteColors(Palette* palette, Color* colors, int firstcolor, int ncolors);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPaletteColors")]
        public unsafe partial int SetPaletteColors(Palette* palette, ref Color colors, int firstcolor, int ncolors);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPaletteColors")]
        public unsafe partial int SetPaletteColors(ref Palette palette, Color* colors, int firstcolor, int ncolors);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 29 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPaletteColors")]
        public partial int SetPaletteColors(ref Palette palette, ref Color colors, int firstcolor, int ncolors);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 421, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_FreePalette")]
        public unsafe partial void FreePalette(Palette* palette);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 421, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_FreePalette")]
        public partial void FreePalette(ref Palette palette);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 428, Column 32 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_MapRGB")]
        public unsafe partial uint MapRGB(PixelFormat* format, byte r, byte g, byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 428, Column 32 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_MapRGB")]
        public partial uint MapRGB(ref PixelFormat format, byte r, byte g, byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 32 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_MapRGBA")]
        public unsafe partial uint MapRGBA(PixelFormat* format, byte r, byte g, byte b, byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 32 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_MapRGBA")]
        public partial uint MapRGBA(ref PixelFormat format, byte r, byte g, byte b, byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, byte* r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, byte* r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, byte* r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, byte* r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, byte* r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, byte* r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, byte* r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, byte* r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, byte* r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, ref byte r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, ref byte r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, ref byte r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, ref byte r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, ref byte r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, ref byte r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, ref byte r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, ref byte r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, ref byte r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, string r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, string r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, string r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, string r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, string r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, string r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, string r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, string r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, PixelFormat* format, string r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, byte* r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, byte* r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, byte* r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, byte* r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, byte* r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, byte* r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, byte* r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, byte* r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, byte* r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, ref byte r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, ref byte r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, ref byte r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, ref byte r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public partial void GetRGB(uint pixel, ref PixelFormat format, ref byte r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public partial void GetRGB(uint pixel, ref PixelFormat format, ref byte r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, ref byte r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public partial void GetRGB(uint pixel, ref PixelFormat format, ref byte r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public partial void GetRGB(uint pixel, ref PixelFormat format, ref byte r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, string r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, string r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, string r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, string r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public partial void GetRGB(uint pixel, ref PixelFormat format, string r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public partial void GetRGB(uint pixel, ref PixelFormat format, string r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, ref PixelFormat format, string r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public partial void GetRGB(uint pixel, ref PixelFormat format, string r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public partial void GetRGB(uint pixel, ref PixelFormat format, string r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, byte* g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, byte* g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, byte* g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, byte* g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, byte* g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, byte* g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, byte* g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, byte* g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, ref byte g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, ref byte g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, ref byte g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, ref byte g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, ref byte g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, ref byte g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, ref byte g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, ref byte g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, ref byte g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, string g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, string g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, string g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, string g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, string g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, string g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, string g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, string g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, byte* r, string g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, byte* g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, byte* g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, byte* g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, byte* g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, byte* g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, byte* g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, byte* g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, byte* g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, ref byte g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, ref byte g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, ref byte g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, ref byte g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, ref byte g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, ref byte g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, ref byte g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, ref byte g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, ref byte g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, string g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, string g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, string g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, string g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, string g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, string g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, string g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, string g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, ref byte r, string g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, byte* g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, byte* g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, byte* g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, byte* g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, byte* g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, byte* g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, byte* g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, byte* g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, ref byte g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, ref byte g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, ref byte g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, ref byte g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, ref byte g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, ref byte g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, ref byte g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, ref byte g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, ref byte g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, string g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, string g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, string g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, string g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, string g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, string g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, string g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, string g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, PixelFormat* format, string r, string g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, byte* g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, byte* g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, byte* g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, byte* g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, byte* g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, byte* g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, byte* g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, byte* g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, ref byte g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, ref byte g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, ref byte g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, ref byte g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, ref byte g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, ref byte g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, ref byte g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, ref byte g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, ref byte g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, string g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, string g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, string g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, string g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, string g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, string g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, string g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, string g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, byte* r, string g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, byte* g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, byte* g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, byte* g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, byte* g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, byte* g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, byte* g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, byte* g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, byte* g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, ref byte g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, ref byte g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, ref byte g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, ref byte g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, ref byte g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, ref byte g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, ref byte g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, ref byte g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, ref byte g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, string g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, string g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, string g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, string g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, string g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, string g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, string g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, string g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, ref byte r, string g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, byte* g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, byte* g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, byte* g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, byte* g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, byte* g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, byte* g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, byte* g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, byte* g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, ref byte g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, ref byte g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, ref byte g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, ref byte g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, string r, ref byte g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, string r, ref byte g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, ref byte g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, string r, ref byte g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, string r, ref byte g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, string g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, string g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, string g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, string g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, string r, string g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, string r, string g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, ref PixelFormat format, string r, string g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, string r, string g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public partial void GetRGBA(uint pixel, ref PixelFormat format, string r, string g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_CalculateGammaRamp")]
        public unsafe partial void CalculateGammaRamp(float gamma, ushort* ramp);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 30 in build/submodules/SDL-mirror/include/SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_CalculateGammaRamp")]
        public partial void CalculateGammaRamp(float gamma, ref ushort ramp);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 41, Column 29 in build/submodules/SDL-mirror/include/SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_SetError")]
        public unsafe partial int SetError(byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 41, Column 29 in build/submodules/SDL-mirror/include/SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_SetError")]
        public partial int SetError(ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 41, Column 29 in build/submodules/SDL-mirror/include/SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_SetError")]
        public partial int SetError(string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 42, Column 37 in build/submodules/SDL-mirror/include/SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_GetError")]
        public unsafe partial byte* GetError();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 42, Column 37 in build/submodules/SDL-mirror/include/SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_GetError")]
        public partial string GetErrorS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 43, Column 30 in build/submodules/SDL-mirror/include/SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_ClearError")]
        public partial void ClearError();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 29 in build/submodules/SDL-mirror/include/SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_Error")]
        public partial int Error(Errorcode code);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_HasIntersection")]
        public unsafe partial SdlBool HasIntersection(Silk.NET.Maths.Rectangle<int>* A, Silk.NET.Maths.Rectangle<int>* B);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_HasIntersection")]
        public unsafe partial SdlBool HasIntersection(Silk.NET.Maths.Rectangle<int>* A, ref Silk.NET.Maths.Rectangle<int> B);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_HasIntersection")]
        public unsafe partial SdlBool HasIntersection(ref Silk.NET.Maths.Rectangle<int> A, Silk.NET.Maths.Rectangle<int>* B);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_HasIntersection")]
        public partial SdlBool HasIntersection(ref Silk.NET.Maths.Rectangle<int> A, ref Silk.NET.Maths.Rectangle<int> B);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRect")]
        public unsafe partial SdlBool IntersectRect(Silk.NET.Maths.Rectangle<int>* A, Silk.NET.Maths.Rectangle<int>* B, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRect")]
        public unsafe partial SdlBool IntersectRect(Silk.NET.Maths.Rectangle<int>* A, Silk.NET.Maths.Rectangle<int>* B, ref Silk.NET.Maths.Rectangle<int> result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRect")]
        public unsafe partial SdlBool IntersectRect(Silk.NET.Maths.Rectangle<int>* A, ref Silk.NET.Maths.Rectangle<int> B, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRect")]
        public unsafe partial SdlBool IntersectRect(Silk.NET.Maths.Rectangle<int>* A, ref Silk.NET.Maths.Rectangle<int> B, ref Silk.NET.Maths.Rectangle<int> result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRect")]
        public unsafe partial SdlBool IntersectRect(ref Silk.NET.Maths.Rectangle<int> A, Silk.NET.Maths.Rectangle<int>* B, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRect")]
        public unsafe partial SdlBool IntersectRect(ref Silk.NET.Maths.Rectangle<int> A, Silk.NET.Maths.Rectangle<int>* B, ref Silk.NET.Maths.Rectangle<int> result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRect")]
        public unsafe partial SdlBool IntersectRect(ref Silk.NET.Maths.Rectangle<int> A, ref Silk.NET.Maths.Rectangle<int> B, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRect")]
        public partial SdlBool IntersectRect(ref Silk.NET.Maths.Rectangle<int> A, ref Silk.NET.Maths.Rectangle<int> B, ref Silk.NET.Maths.Rectangle<int> result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_UnionRect")]
        public unsafe partial void UnionRect(Silk.NET.Maths.Rectangle<int>* A, Silk.NET.Maths.Rectangle<int>* B, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_UnionRect")]
        public unsafe partial void UnionRect(Silk.NET.Maths.Rectangle<int>* A, Silk.NET.Maths.Rectangle<int>* B, ref Silk.NET.Maths.Rectangle<int> result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_UnionRect")]
        public unsafe partial void UnionRect(Silk.NET.Maths.Rectangle<int>* A, ref Silk.NET.Maths.Rectangle<int> B, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_UnionRect")]
        public unsafe partial void UnionRect(Silk.NET.Maths.Rectangle<int>* A, ref Silk.NET.Maths.Rectangle<int> B, ref Silk.NET.Maths.Rectangle<int> result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_UnionRect")]
        public unsafe partial void UnionRect(ref Silk.NET.Maths.Rectangle<int> A, Silk.NET.Maths.Rectangle<int>* B, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_UnionRect")]
        public unsafe partial void UnionRect(ref Silk.NET.Maths.Rectangle<int> A, Silk.NET.Maths.Rectangle<int>* B, ref Silk.NET.Maths.Rectangle<int> result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_UnionRect")]
        public unsafe partial void UnionRect(ref Silk.NET.Maths.Rectangle<int> A, ref Silk.NET.Maths.Rectangle<int> B, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 30 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_UnionRect")]
        public partial void UnionRect(ref Silk.NET.Maths.Rectangle<int> A, ref Silk.NET.Maths.Rectangle<int> B, ref Silk.NET.Maths.Rectangle<int> result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_EnclosePoints")]
        public unsafe partial SdlBool EnclosePoints(Point* points, int count, Silk.NET.Maths.Rectangle<int>* clip, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_EnclosePoints")]
        public unsafe partial SdlBool EnclosePoints(Point* points, int count, Silk.NET.Maths.Rectangle<int>* clip, ref Silk.NET.Maths.Rectangle<int> result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_EnclosePoints")]
        public unsafe partial SdlBool EnclosePoints(Point* points, int count, ref Silk.NET.Maths.Rectangle<int> clip, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_EnclosePoints")]
        public unsafe partial SdlBool EnclosePoints(Point* points, int count, ref Silk.NET.Maths.Rectangle<int> clip, ref Silk.NET.Maths.Rectangle<int> result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_EnclosePoints")]
        public unsafe partial SdlBool EnclosePoints(ref Point points, int count, Silk.NET.Maths.Rectangle<int>* clip, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_EnclosePoints")]
        public unsafe partial SdlBool EnclosePoints(ref Point points, int count, Silk.NET.Maths.Rectangle<int>* clip, ref Silk.NET.Maths.Rectangle<int> result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_EnclosePoints")]
        public unsafe partial SdlBool EnclosePoints(ref Point points, int count, ref Silk.NET.Maths.Rectangle<int> clip, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_EnclosePoints")]
        public partial SdlBool EnclosePoints(ref Point points, int count, ref Silk.NET.Maths.Rectangle<int> clip, ref Silk.NET.Maths.Rectangle<int> result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, int* X1, int* Y1, int* X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, int* X1, int* Y1, int* X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, int* X1, int* Y1, ref int X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, int* X1, int* Y1, ref int X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, int* X1, ref int Y1, int* X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, int* X1, ref int Y1, int* X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, int* X1, ref int Y1, ref int X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, int* X1, ref int Y1, ref int X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, ref int X1, int* Y1, int* X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, ref int X1, int* Y1, int* X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, ref int X1, int* Y1, ref int X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, ref int X1, int* Y1, ref int X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, ref int X1, ref int Y1, int* X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, ref int X1, ref int Y1, int* X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, ref int X1, ref int Y1, ref int X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(Silk.NET.Maths.Rectangle<int>* rect, ref int X1, ref int Y1, ref int X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, int* X1, int* Y1, int* X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, int* X1, int* Y1, int* X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, int* X1, int* Y1, ref int X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, int* X1, int* Y1, ref int X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, int* X1, ref int Y1, int* X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, int* X1, ref int Y1, int* X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, int* X1, ref int Y1, ref int X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, int* X1, ref int Y1, ref int X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, ref int X1, int* Y1, int* X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, ref int X1, int* Y1, int* X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, ref int X1, int* Y1, ref int X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, ref int X1, int* Y1, ref int X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, ref int X1, ref int Y1, int* X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, ref int X1, ref int Y1, int* X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, ref int X1, ref int Y1, ref int X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 34 in build/submodules/SDL-mirror/include/SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public partial SdlBool IntersectRectAndLine(ref Silk.NET.Maths.Rectangle<int> rect, ref int X1, ref int Y1, ref int X2, ref int Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 108, Column 39 in build/submodules/SDL-mirror/include/SDL_blendmode.h")]
        [NativeApi(EntryPoint = "SDL_ComposeCustomBlendMode")]
        public partial BlendMode ComposeCustomBlendMode(BlendFactor srcColorFactor, BlendFactor dstColorFactor, BlendOperation colorOperation, BlendFactor srcAlphaFactor, BlendFactor dstAlphaFactor, BlendOperation alphaOperation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 130, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurface")]
        public unsafe partial Surface* CreateRGBSurface(uint flags, int width, int height, int depth, uint Rmask, uint Gmask, uint Bmask, uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurfaceWithFormat")]
        public unsafe partial Surface* CreateRGBSurfaceWithFormat(uint flags, int width, int height, int depth, uint format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurfaceFrom")]
        public unsafe partial Surface* CreateRGBSurfaceFrom(void* pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurfaceFrom")]
        public unsafe partial Surface* CreateRGBSurfaceFrom<T0>(ref T0 pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurfaceWithFormatFrom")]
        public unsafe partial Surface* CreateRGBSurfaceWithFormatFrom(void* pixels, int width, int height, int depth, int pitch, uint format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurfaceWithFormatFrom")]
        public unsafe partial Surface* CreateRGBSurfaceWithFormatFrom<T0>(ref T0 pixels, int width, int height, int depth, int pitch, uint format) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 149, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FreeSurface")]
        public unsafe partial void FreeSurface(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 149, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FreeSurface")]
        public partial void FreeSurface(ref Surface surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfacePalette")]
        public unsafe partial int SetSurfacePalette(Surface* surface, Palette* palette);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfacePalette")]
        public unsafe partial int SetSurfacePalette(Surface* surface, ref Palette palette);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfacePalette")]
        public unsafe partial int SetSurfacePalette(ref Surface surface, Palette* palette);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfacePalette")]
        public partial int SetSurfacePalette(ref Surface surface, ref Palette palette);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 180, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LockSurface")]
        public unsafe partial int LockSurface(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 180, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LockSurface")]
        public partial int LockSurface(ref Surface surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UnlockSurface")]
        public unsafe partial void UnlockSurface(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UnlockSurface")]
        public partial void UnlockSurface(ref Surface surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 193, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LoadBMP_RW")]
        public unsafe partial Surface* LoadBMPRW(RWops* src, int freesrc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 193, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LoadBMP_RW")]
        public unsafe partial Surface* LoadBMPRW(ref RWops src, int freesrc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SaveBMP_RW")]
        public unsafe partial int SaveBMPRW(Surface* surface, RWops* dst, int freedst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SaveBMP_RW")]
        public unsafe partial int SaveBMPRW(Surface* surface, ref RWops dst, int freedst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SaveBMP_RW")]
        public unsafe partial int SaveBMPRW(ref Surface surface, RWops* dst, int freedst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SaveBMP_RW")]
        public partial int SaveBMPRW(ref Surface surface, ref RWops dst, int freedst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 235, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceRLE")]
        public unsafe partial int SetSurfaceRLE(Surface* surface, int flag);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 235, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceRLE")]
        public partial int SetSurfaceRLE(ref Surface surface, int flag);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 249, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetColorKey")]
        public unsafe partial int SetColorKey(Surface* surface, int flag, uint key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 249, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetColorKey")]
        public partial int SetColorKey(ref Surface surface, int flag, uint key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_HasColorKey")]
        public unsafe partial SdlBool HasColorKey(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_HasColorKey")]
        public partial SdlBool HasColorKey(ref Surface surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 269, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetColorKey")]
        public unsafe partial int GetColorKey(Surface* surface, uint* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 269, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetColorKey")]
        public unsafe partial int GetColorKey(Surface* surface, ref uint key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 269, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetColorKey")]
        public unsafe partial int GetColorKey(ref Surface surface, uint* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 269, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetColorKey")]
        public partial int GetColorKey(ref Surface surface, ref uint key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 284, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceColorMod")]
        public unsafe partial int SetSurfaceColorMod(Surface* surface, byte r, byte g, byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 284, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceColorMod")]
        public partial int SetSurfaceColorMod(ref Surface surface, byte r, byte g, byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, byte* r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, byte* r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, byte* r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, byte* r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, byte* r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, byte* r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, byte* r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, byte* r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, byte* r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, ref byte r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, ref byte r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, ref byte r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, ref byte r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, ref byte r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, ref byte r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, ref byte r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, ref byte r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, ref byte r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, string r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, string r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, string r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, string r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, string r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, string r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, string r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, string r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, string r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, byte* r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, byte* r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, byte* r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, byte* r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, byte* r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, byte* r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, byte* r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, byte* r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, byte* r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, ref byte r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, ref byte r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, ref byte r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, ref byte r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public partial int GetSurfaceColorMod(ref Surface surface, ref byte r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public partial int GetSurfaceColorMod(ref Surface surface, ref byte r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, ref byte r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public partial int GetSurfaceColorMod(ref Surface surface, ref byte r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public partial int GetSurfaceColorMod(ref Surface surface, ref byte r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, string r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, string r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, string r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, string r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public partial int GetSurfaceColorMod(ref Surface surface, string r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public partial int GetSurfaceColorMod(ref Surface surface, string r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(ref Surface surface, string r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public partial int GetSurfaceColorMod(ref Surface surface, string r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public partial int GetSurfaceColorMod(ref Surface surface, string r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 314, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceAlphaMod")]
        public unsafe partial int SetSurfaceAlphaMod(Surface* surface, byte alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 314, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceAlphaMod")]
        public partial int SetSurfaceAlphaMod(ref Surface surface, byte alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceAlphaMod")]
        public unsafe partial int GetSurfaceAlphaMod(Surface* surface, byte* alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceAlphaMod")]
        public unsafe partial int GetSurfaceAlphaMod(Surface* surface, ref byte alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceAlphaMod")]
        public unsafe partial int GetSurfaceAlphaMod(Surface* surface, string alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceAlphaMod")]
        public unsafe partial int GetSurfaceAlphaMod(ref Surface surface, byte* alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceAlphaMod")]
        public partial int GetSurfaceAlphaMod(ref Surface surface, ref byte alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceAlphaMod")]
        public partial int GetSurfaceAlphaMod(ref Surface surface, string alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceBlendMode")]
        public unsafe partial int SetSurfaceBlendMode(Surface* surface, BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceBlendMode")]
        public partial int SetSurfaceBlendMode(ref Surface surface, BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceBlendMode")]
        public unsafe partial int GetSurfaceBlendMode(Surface* surface, BlendMode* blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceBlendMode")]
        public unsafe partial int GetSurfaceBlendMode(Surface* surface, ref BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceBlendMode")]
        public unsafe partial int GetSurfaceBlendMode(ref Surface surface, BlendMode* blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceBlendMode")]
        public partial int GetSurfaceBlendMode(ref Surface surface, ref BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetClipRect")]
        public unsafe partial SdlBool SetClipRect(Surface* surface, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetClipRect")]
        public unsafe partial SdlBool SetClipRect(Surface* surface, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetClipRect")]
        public unsafe partial SdlBool SetClipRect(ref Surface surface, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 34 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetClipRect")]
        public partial SdlBool SetClipRect(ref Surface surface, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 378, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetClipRect")]
        public unsafe partial void GetClipRect(Surface* surface, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 378, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetClipRect")]
        public unsafe partial void GetClipRect(Surface* surface, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 378, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetClipRect")]
        public unsafe partial void GetClipRect(ref Surface surface, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 378, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetClipRect")]
        public partial void GetClipRect(ref Surface surface, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 384, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_DuplicateSurface")]
        public unsafe partial Surface* DuplicateSurface(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 384, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_DuplicateSurface")]
        public unsafe partial Surface* DuplicateSurface(ref Surface surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertSurface")]
        public unsafe partial Surface* ConvertSurface(Surface* src, PixelFormat* fmt, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertSurface")]
        public unsafe partial Surface* ConvertSurface(Surface* src, ref PixelFormat fmt, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertSurface")]
        public unsafe partial Surface* ConvertSurface(ref Surface src, PixelFormat* fmt, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertSurface")]
        public unsafe partial Surface* ConvertSurface(ref Surface src, ref PixelFormat fmt, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertSurfaceFormat")]
        public unsafe partial Surface* ConvertSurfaceFormat(Surface* src, uint pixel_format, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 38 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertSurfaceFormat")]
        public unsafe partial Surface* ConvertSurfaceFormat(ref Surface src, uint pixel_format, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 406, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertPixels")]
        public unsafe partial int ConvertPixels(int width, int height, uint src_format, void* src, int src_pitch, uint dst_format, void* dst, int dst_pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 406, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertPixels")]
        public unsafe partial int ConvertPixels<T0>(int width, int height, uint src_format, void* src, int src_pitch, uint dst_format, ref T0 dst, int dst_pitch) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 406, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertPixels")]
        public unsafe partial int ConvertPixels<T0>(int width, int height, uint src_format, ref T0 src, int src_pitch, uint dst_format, void* dst, int dst_pitch) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 406, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertPixels")]
        public partial int ConvertPixels<T0, T1>(int width, int height, uint src_format, ref T0 src, int src_pitch, uint dst_format, ref T1 dst, int dst_pitch) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRect")]
        public unsafe partial int FillRect(Surface* dst, Silk.NET.Maths.Rectangle<int>* rect, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRect")]
        public unsafe partial int FillRect(Surface* dst, ref Silk.NET.Maths.Rectangle<int> rect, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRect")]
        public unsafe partial int FillRect(ref Surface dst, Silk.NET.Maths.Rectangle<int>* rect, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRect")]
        public partial int FillRect(ref Surface dst, ref Silk.NET.Maths.Rectangle<int> rect, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRects")]
        public unsafe partial int FillRects(Surface* dst, Silk.NET.Maths.Rectangle<int>* rects, int count, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRects")]
        public unsafe partial int FillRects(Surface* dst, ref Silk.NET.Maths.Rectangle<int> rects, int count, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRects")]
        public unsafe partial int FillRects(ref Surface dst, Silk.NET.Maths.Rectangle<int>* rects, int count, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRects")]
        public partial int FillRects(ref Surface dst, ref Silk.NET.Maths.Rectangle<int> rects, int count, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public partial int UpperBlit(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public partial int LowerBlit(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public partial int SoftStretch(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public partial int UpperBlitScaled(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(Surface* src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(ref Surface src, Silk.NET.Maths.Rectangle<int>* srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, Surface* dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public partial int LowerBlitScaled(ref Surface src, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Surface dst, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 534, Column 30 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetYUVConversionMode")]
        public partial void SetYUVConversionMode(YUVCONVERSIONMODE mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 539, Column 49 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetYUVConversionMode")]
        public partial YUVCONVERSIONMODE GetYUVConversionMode();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 544, Column 49 in build/submodules/SDL-mirror/include/SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetYUVConversionModeForResolution")]
        public partial YUVCONVERSIONMODE GetYUVConversionModeForResolution(int width, int height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 262, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetNumVideoDrivers")]
        public partial int GetNumVideoDrivers();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetVideoDriver")]
        public unsafe partial byte* GetVideoDriver(int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetVideoDriver")]
        public partial string GetVideoDriverS(int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_VideoInit")]
        public unsafe partial int VideoInit(byte* driver_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_VideoInit")]
        public partial int VideoInit(ref byte driver_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_VideoInit")]
        public partial int VideoInit(string driver_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 297, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_VideoQuit")]
        public partial void VideoQuit();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 308, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentVideoDriver")]
        public unsafe partial byte* GetCurrentVideoDriver();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 308, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentVideoDriver")]
        public partial string GetCurrentVideoDriverS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetNumVideoDisplays")]
        public partial int GetNumVideoDisplays();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 324, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayName")]
        public unsafe partial byte* GetDisplayName(int displayIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 324, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayName")]
        public partial string GetDisplayNameS(int displayIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayBounds")]
        public unsafe partial int GetDisplayBounds(int displayIndex, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayBounds")]
        public partial int GetDisplayBounds(int displayIndex, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayUsableBounds")]
        public unsafe partial int GetDisplayUsableBounds(int displayIndex, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayUsableBounds")]
        public partial int GetDisplayUsableBounds(int displayIndex, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayDPI")]
        public unsafe partial int GetDisplayDPI(int displayIndex, float* ddpi, float* hdpi, float* vdpi);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayDPI")]
        public unsafe partial int GetDisplayDPI(int displayIndex, float* ddpi, float* hdpi, ref float vdpi);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayDPI")]
        public unsafe partial int GetDisplayDPI(int displayIndex, float* ddpi, ref float hdpi, float* vdpi);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayDPI")]
        public unsafe partial int GetDisplayDPI(int displayIndex, float* ddpi, ref float hdpi, ref float vdpi);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayDPI")]
        public unsafe partial int GetDisplayDPI(int displayIndex, ref float ddpi, float* hdpi, float* vdpi);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayDPI")]
        public unsafe partial int GetDisplayDPI(int displayIndex, ref float ddpi, float* hdpi, ref float vdpi);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayDPI")]
        public unsafe partial int GetDisplayDPI(int displayIndex, ref float ddpi, ref float hdpi, float* vdpi);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayDPI")]
        public partial int GetDisplayDPI(int displayIndex, ref float ddpi, ref float hdpi, ref float vdpi);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 48 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayOrientation")]
        public partial DisplayOrientation GetDisplayOrientation(int displayIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 381, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetNumDisplayModes")]
        public partial int GetNumDisplayModes(int displayIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 394, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayMode")]
        public unsafe partial int GetDisplayMode(int displayIndex, int modeIndex, DisplayMode* mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 394, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayMode")]
        public partial int GetDisplayMode(int displayIndex, int modeIndex, ref DisplayMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 400, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDesktopDisplayMode")]
        public unsafe partial int GetDesktopDisplayMode(int displayIndex, DisplayMode* mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 400, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDesktopDisplayMode")]
        public partial int GetDesktopDisplayMode(int displayIndex, ref DisplayMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentDisplayMode")]
        public unsafe partial int GetCurrentDisplayMode(int displayIndex, DisplayMode* mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentDisplayMode")]
        public partial int GetCurrentDisplayMode(int displayIndex, ref DisplayMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 429, Column 43 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetClosestDisplayMode")]
        public unsafe partial DisplayMode* GetClosestDisplayMode(int displayIndex, DisplayMode* mode, DisplayMode* closest);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 429, Column 43 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetClosestDisplayMode")]
        public unsafe partial DisplayMode* GetClosestDisplayMode(int displayIndex, DisplayMode* mode, ref DisplayMode closest);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 429, Column 43 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetClosestDisplayMode")]
        public unsafe partial DisplayMode* GetClosestDisplayMode(int displayIndex, ref DisplayMode mode, DisplayMode* closest);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 429, Column 43 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetClosestDisplayMode")]
        public unsafe partial DisplayMode* GetClosestDisplayMode(int displayIndex, ref DisplayMode mode, ref DisplayMode closest);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 437, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowDisplayIndex")]
        public unsafe partial int GetWindowDisplayIndex(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 437, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowDisplayIndex")]
        public partial int GetWindowDisplayIndex(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowDisplayMode")]
        public unsafe partial int SetWindowDisplayMode(Window* window, DisplayMode* mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowDisplayMode")]
        public unsafe partial int SetWindowDisplayMode(Window* window, ref DisplayMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowDisplayMode")]
        public unsafe partial int SetWindowDisplayMode(ref Window window, DisplayMode* mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowDisplayMode")]
        public partial int SetWindowDisplayMode(ref Window window, ref DisplayMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowDisplayMode")]
        public unsafe partial int GetWindowDisplayMode(Window* window, DisplayMode* mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowDisplayMode")]
        public unsafe partial int GetWindowDisplayMode(Window* window, ref DisplayMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowDisplayMode")]
        public unsafe partial int GetWindowDisplayMode(ref Window window, DisplayMode* mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowDisplayMode")]
        public partial int GetWindowDisplayMode(ref Window window, ref DisplayMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPixelFormat")]
        public unsafe partial uint GetWindowPixelFormat(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 470, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPixelFormat")]
        public partial uint GetWindowPixelFormat(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 514, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindow")]
        public unsafe partial Window* CreateWindow(byte* title, int x, int y, int w, int h, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 514, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindow")]
        public unsafe partial Window* CreateWindow(ref byte title, int x, int y, int w, int h, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 514, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindow")]
        public unsafe partial Window* CreateWindow(string title, int x, int y, int w, int h, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindowFrom")]
        public unsafe partial Window* CreateWindowFrom(void* data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindowFrom")]
        public unsafe partial Window* CreateWindowFrom<T0>(ref T0 data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowID")]
        public unsafe partial uint GetWindowID(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowID")]
        public partial uint GetWindowID(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 537, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowFromID")]
        public unsafe partial Window* GetWindowFromID(uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 542, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowFlags")]
        public unsafe partial uint GetWindowFlags(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 542, Column 32 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowFlags")]
        public partial uint GetWindowFlags(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowTitle")]
        public unsafe partial void SetWindowTitle(Window* window, byte* title);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowTitle")]
        public unsafe partial void SetWindowTitle(Window* window, ref byte title);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowTitle")]
        public unsafe partial void SetWindowTitle(Window* window, string title);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowTitle")]
        public unsafe partial void SetWindowTitle(ref Window window, byte* title);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowTitle")]
        public partial void SetWindowTitle(ref Window window, ref byte title);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowTitle")]
        public partial void SetWindowTitle(ref Window window, string title);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowTitle")]
        public unsafe partial byte* GetWindowTitle(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowTitle")]
        public unsafe partial string GetWindowTitleS(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowTitle")]
        public unsafe partial byte* GetWindowTitle(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowTitle")]
        public partial string GetWindowTitleS(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowIcon")]
        public unsafe partial void SetWindowIcon(Window* window, Surface* icon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowIcon")]
        public unsafe partial void SetWindowIcon(Window* window, ref Surface icon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowIcon")]
        public unsafe partial void SetWindowIcon(ref Window window, Surface* icon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowIcon")]
        public partial void SetWindowIcon(ref Window window, ref Surface icon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public unsafe partial void* SetWindowData(Window* window, byte* name, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public unsafe partial void* SetWindowData<T0>(Window* window, byte* name, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public unsafe partial void* SetWindowData(Window* window, ref byte name, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public unsafe partial void* SetWindowData<T0>(Window* window, ref byte name, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public unsafe partial void* SetWindowData(Window* window, string name, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public unsafe partial void* SetWindowData<T0>(Window* window, string name, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public unsafe partial void* SetWindowData(ref Window window, byte* name, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public unsafe partial void* SetWindowData<T0>(ref Window window, byte* name, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public unsafe partial void* SetWindowData(ref Window window, ref byte name, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public unsafe partial void* SetWindowData<T0>(ref Window window, ref byte name, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public unsafe partial void* SetWindowData(ref Window window, string name, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public unsafe partial void* SetWindowData<T0>(ref Window window, string name, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowData")]
        public unsafe partial void* GetWindowData(Window* window, byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowData")]
        public unsafe partial void* GetWindowData(Window* window, ref byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowData")]
        public unsafe partial void* GetWindowData(Window* window, string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowData")]
        public unsafe partial void* GetWindowData(ref Window window, byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowData")]
        public unsafe partial void* GetWindowData(ref Window window, ref byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 595, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowData")]
        public unsafe partial void* GetWindowData(ref Window window, string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowPosition")]
        public unsafe partial void SetWindowPosition(Window* window, int x, int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowPosition")]
        public partial void SetWindowPosition(ref Window window, int x, int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPosition")]
        public unsafe partial void GetWindowPosition(Window* window, int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPosition")]
        public unsafe partial void GetWindowPosition(Window* window, int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPosition")]
        public unsafe partial void GetWindowPosition(Window* window, ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPosition")]
        public unsafe partial void GetWindowPosition(Window* window, ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPosition")]
        public unsafe partial void GetWindowPosition(ref Window window, int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPosition")]
        public unsafe partial void GetWindowPosition(ref Window window, int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPosition")]
        public unsafe partial void GetWindowPosition(ref Window window, ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPosition")]
        public partial void GetWindowPosition(ref Window window, ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 646, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowSize")]
        public unsafe partial void SetWindowSize(Window* window, int w, int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 646, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowSize")]
        public partial void SetWindowSize(ref Window window, int w, int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSize")]
        public unsafe partial void GetWindowSize(Window* window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSize")]
        public unsafe partial void GetWindowSize(Window* window, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSize")]
        public unsafe partial void GetWindowSize(Window* window, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSize")]
        public unsafe partial void GetWindowSize(Window* window, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSize")]
        public unsafe partial void GetWindowSize(ref Window window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSize")]
        public unsafe partial void GetWindowSize(ref Window window, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSize")]
        public unsafe partial void GetWindowSize(ref Window window, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSize")]
        public partial void GetWindowSize(ref Window window, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, int* top, int* left, int* bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, int* top, int* left, int* bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, int* top, int* left, ref int bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, int* top, int* left, ref int bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, int* top, ref int left, int* bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, int* top, ref int left, int* bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, int* top, ref int left, ref int bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, int* top, ref int left, ref int bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, ref int top, int* left, int* bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, ref int top, int* left, int* bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, ref int top, int* left, ref int bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, ref int top, int* left, ref int bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, ref int top, ref int left, int* bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, ref int top, ref int left, int* bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, ref int top, ref int left, ref int bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, ref int top, ref int left, ref int bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, int* top, int* left, int* bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, int* top, int* left, int* bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, int* top, int* left, ref int bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, int* top, int* left, ref int bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, int* top, ref int left, int* bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, int* top, ref int left, int* bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, int* top, ref int left, ref int bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, int* top, ref int left, ref int bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, ref int top, int* left, int* bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, ref int top, int* left, int* bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, ref int top, int* left, ref int bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, ref int top, int* left, ref int bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, ref int top, ref int left, int* bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, ref int top, ref int left, int* bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(ref Window window, ref int top, ref int left, ref int bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public partial int GetWindowBordersSize(ref Window window, ref int top, ref int left, ref int bottom, ref int right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowMinimumSize")]
        public unsafe partial void SetWindowMinimumSize(Window* window, int min_w, int min_h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowMinimumSize")]
        public partial void SetWindowMinimumSize(ref Window window, int min_w, int min_h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMinimumSize")]
        public unsafe partial void GetWindowMinimumSize(Window* window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMinimumSize")]
        public unsafe partial void GetWindowMinimumSize(Window* window, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMinimumSize")]
        public unsafe partial void GetWindowMinimumSize(Window* window, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMinimumSize")]
        public unsafe partial void GetWindowMinimumSize(Window* window, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMinimumSize")]
        public unsafe partial void GetWindowMinimumSize(ref Window window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMinimumSize")]
        public unsafe partial void GetWindowMinimumSize(ref Window window, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMinimumSize")]
        public unsafe partial void GetWindowMinimumSize(ref Window window, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMinimumSize")]
        public partial void GetWindowMinimumSize(ref Window window, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 729, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowMaximumSize")]
        public unsafe partial void SetWindowMaximumSize(Window* window, int max_w, int max_h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 729, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowMaximumSize")]
        public partial void SetWindowMaximumSize(ref Window window, int max_w, int max_h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMaximumSize")]
        public unsafe partial void GetWindowMaximumSize(Window* window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMaximumSize")]
        public unsafe partial void GetWindowMaximumSize(Window* window, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMaximumSize")]
        public unsafe partial void GetWindowMaximumSize(Window* window, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMaximumSize")]
        public unsafe partial void GetWindowMaximumSize(Window* window, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMaximumSize")]
        public unsafe partial void GetWindowMaximumSize(ref Window window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMaximumSize")]
        public unsafe partial void GetWindowMaximumSize(ref Window window, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMaximumSize")]
        public unsafe partial void GetWindowMaximumSize(ref Window window, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMaximumSize")]
        public partial void GetWindowMaximumSize(ref Window window, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 759, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowBordered")]
        public unsafe partial void SetWindowBordered(Window* window, SdlBool bordered);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 759, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowBordered")]
        public partial void SetWindowBordered(ref Window window, SdlBool bordered);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 776, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowResizable")]
        public unsafe partial void SetWindowResizable(Window* window, SdlBool resizable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 776, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowResizable")]
        public partial void SetWindowResizable(ref Window window, SdlBool resizable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 784, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_ShowWindow")]
        public unsafe partial void ShowWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 784, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_ShowWindow")]
        public partial void ShowWindow(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 791, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_HideWindow")]
        public unsafe partial void HideWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 791, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_HideWindow")]
        public partial void HideWindow(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 796, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_RaiseWindow")]
        public unsafe partial void RaiseWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 796, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_RaiseWindow")]
        public partial void RaiseWindow(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 803, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_MaximizeWindow")]
        public unsafe partial void MaximizeWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 803, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_MaximizeWindow")]
        public partial void MaximizeWindow(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 810, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_MinimizeWindow")]
        public unsafe partial void MinimizeWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 810, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_MinimizeWindow")]
        public partial void MinimizeWindow(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 818, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_RestoreWindow")]
        public unsafe partial void RestoreWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 818, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_RestoreWindow")]
        public partial void RestoreWindow(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 828, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowFullscreen")]
        public unsafe partial int SetWindowFullscreen(Window* window, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 828, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowFullscreen")]
        public partial int SetWindowFullscreen(ref Window window, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 39 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSurface")]
        public unsafe partial Surface* GetWindowSurface(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 39 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSurface")]
        public unsafe partial Surface* GetWindowSurface(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_UpdateWindowSurface")]
        public unsafe partial int UpdateWindowSurface(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_UpdateWindowSurface")]
        public partial int UpdateWindowSurface(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        public unsafe partial int UpdateWindowSurfaceRects(Window* window, Silk.NET.Maths.Rectangle<int>* rects, int numrects);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        public unsafe partial int UpdateWindowSurfaceRects(Window* window, ref Silk.NET.Maths.Rectangle<int> rects, int numrects);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        public unsafe partial int UpdateWindowSurfaceRects(ref Window window, Silk.NET.Maths.Rectangle<int>* rects, int numrects);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        public partial int UpdateWindowSurfaceRects(ref Window window, ref Silk.NET.Maths.Rectangle<int> rects, int numrects);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 879, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGrab")]
        public unsafe partial void SetWindowGrab(Window* window, SdlBool grabbed);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 879, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGrab")]
        public partial void SetWindowGrab(ref Window window, SdlBool grabbed);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 889, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGrab")]
        public unsafe partial SdlBool GetWindowGrab(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 889, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGrab")]
        public partial SdlBool GetWindowGrab(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 898, Column 38 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetGrabbedWindow")]
        public unsafe partial Window* GetGrabbedWindow();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowBrightness")]
        public unsafe partial int SetWindowBrightness(Window* window, float brightness);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowBrightness")]
        public partial int SetWindowBrightness(ref Window window, float brightness);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 917, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBrightness")]
        public unsafe partial float GetWindowBrightness(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 917, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBrightness")]
        public partial float GetWindowBrightness(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowOpacity")]
        public unsafe partial int SetWindowOpacity(Window* window, float opacity);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowOpacity")]
        public partial int SetWindowOpacity(ref Window window, float opacity);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowOpacity")]
        public unsafe partial int GetWindowOpacity(Window* window, float* out_opacity);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowOpacity")]
        public unsafe partial int GetWindowOpacity(Window* window, ref float out_opacity);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowOpacity")]
        public unsafe partial int GetWindowOpacity(ref Window window, float* out_opacity);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowOpacity")]
        public partial int GetWindowOpacity(ref Window window, ref float out_opacity);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 955, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowModalFor")]
        public unsafe partial int SetWindowModalFor(Window* modal_window, Window* parent_window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 955, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowModalFor")]
        public unsafe partial int SetWindowModalFor(Window* modal_window, ref Window parent_window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 955, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowModalFor")]
        public unsafe partial int SetWindowModalFor(ref Window modal_window, Window* parent_window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 955, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowModalFor")]
        public partial int SetWindowModalFor(ref Window modal_window, ref Window parent_window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 969, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowInputFocus")]
        public unsafe partial int SetWindowInputFocus(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 969, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowInputFocus")]
        public partial int SetWindowInputFocus(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(Window* window, ushort* red, ushort* green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(Window* window, ushort* red, ushort* green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(Window* window, ushort* red, ref ushort green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(Window* window, ushort* red, ref ushort green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(Window* window, ref ushort red, ushort* green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(Window* window, ref ushort red, ushort* green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(Window* window, ref ushort red, ref ushort green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(Window* window, ref ushort red, ref ushort green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(ref Window window, ushort* red, ushort* green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(ref Window window, ushort* red, ushort* green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(ref Window window, ushort* red, ref ushort green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(ref Window window, ushort* red, ref ushort green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(ref Window window, ref ushort red, ushort* green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(ref Window window, ref ushort red, ushort* green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(ref Window window, ref ushort red, ref ushort green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 989, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public partial int SetWindowGammaRamp(ref Window window, ref ushort red, ref ushort green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(Window* window, ushort* red, ushort* green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(Window* window, ushort* red, ushort* green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(Window* window, ushort* red, ref ushort green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(Window* window, ushort* red, ref ushort green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(Window* window, ref ushort red, ushort* green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(Window* window, ref ushort red, ushort* green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(Window* window, ref ushort red, ref ushort green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(Window* window, ref ushort red, ref ushort green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(ref Window window, ushort* red, ushort* green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(ref Window window, ushort* red, ushort* green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(ref Window window, ushort* red, ref ushort green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(ref Window window, ushort* red, ref ushort green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(ref Window window, ref ushort red, ushort* green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(ref Window window, ref ushort red, ushort* green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(ref Window window, ref ushort red, ref ushort green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public partial int GetWindowGammaRamp(ref Window window, ref ushort red, ref ushort green, ref ushort blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1079, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowHitTest")]
        public unsafe partial int SetWindowHitTest(Window* window, PfnHitTest callback, void* callback_data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1079, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowHitTest")]
        public unsafe partial int SetWindowHitTest<T0>(Window* window, PfnHitTest callback, ref T0 callback_data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1079, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowHitTest")]
        public unsafe partial int SetWindowHitTest(ref Window window, PfnHitTest callback, void* callback_data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1079, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowHitTest")]
        public partial int SetWindowHitTest<T0>(ref Window window, PfnHitTest callback, ref T0 callback_data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1086, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_DestroyWindow")]
        public unsafe partial void DestroyWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1086, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_DestroyWindow")]
        public partial void DestroyWindow(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_IsScreenSaverEnabled")]
        public partial SdlBool IsScreenSaverEnabled();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1103, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_EnableScreenSaver")]
        public partial void EnableScreenSaver();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1111, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_DisableScreenSaver")]
        public partial void DisableScreenSaver();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1137, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_LoadLibrary")]
        public unsafe partial int GLLoadLibrary(byte* path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1137, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_LoadLibrary")]
        public partial int GLLoadLibrary(ref byte path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1137, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_LoadLibrary")]
        public partial int GLLoadLibrary(string path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1142, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetProcAddress")]
        public unsafe partial void* GLGetProcAddress(byte* proc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1142, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetProcAddress")]
        public unsafe partial void* GLGetProcAddress(ref byte proc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1142, Column 31 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetProcAddress")]
        public unsafe partial void* GLGetProcAddress(string proc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1149, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_UnloadLibrary")]
        public partial void GLUnloadLibrary();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1155, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_ExtensionSupported")]
        public unsafe partial SdlBool GLExtensionSupported(byte* extension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1155, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_ExtensionSupported")]
        public partial SdlBool GLExtensionSupported(ref byte extension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1155, Column 34 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_ExtensionSupported")]
        public partial SdlBool GLExtensionSupported(string extension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_ResetAttributes")]
        public partial void GLResetAttributes();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1168, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_SetAttribute")]
        public partial int GLSetAttribute(GLattr attr, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1176, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetAttribute")]
        public unsafe partial int GLGetAttribute(GLattr attr, int* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1176, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetAttribute")]
        public partial int GLGetAttribute(GLattr attr, ref int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1184, Column 39 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_CreateContext")]
        public unsafe partial void* GLCreateContext(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1184, Column 39 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_CreateContext")]
        public unsafe partial void* GLCreateContext(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1192, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_MakeCurrent")]
        public unsafe partial int GLMakeCurrent(Window* window, void* context);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1192, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_MakeCurrent")]
        public unsafe partial int GLMakeCurrent<T0>(Window* window, ref T0 context) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1192, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_MakeCurrent")]
        public unsafe partial int GLMakeCurrent(ref Window window, void* context);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1192, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_MakeCurrent")]
        public partial int GLMakeCurrent<T0>(ref Window window, ref T0 context) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1198, Column 37 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetCurrentWindow")]
        public unsafe partial Window* GLGetCurrentWindow();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1203, Column 39 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetCurrentContext")]
        public unsafe partial void* GLGetCurrentContext();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetDrawableSize")]
        public unsafe partial void GLGetDrawableSize(Window* window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetDrawableSize")]
        public unsafe partial void GLGetDrawableSize(Window* window, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetDrawableSize")]
        public unsafe partial void GLGetDrawableSize(Window* window, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetDrawableSize")]
        public unsafe partial void GLGetDrawableSize(Window* window, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetDrawableSize")]
        public unsafe partial void GLGetDrawableSize(ref Window window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetDrawableSize")]
        public unsafe partial void GLGetDrawableSize(ref Window window, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetDrawableSize")]
        public unsafe partial void GLGetDrawableSize(ref Window window, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetDrawableSize")]
        public partial void GLGetDrawableSize(ref Window window, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1236, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_SetSwapInterval")]
        public partial int GLSetSwapInterval(int interval);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 29 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetSwapInterval")]
        public partial int GLGetSwapInterval();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1255, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_SwapWindow")]
        public unsafe partial void GLSwapWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1255, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_SwapWindow")]
        public partial void GLSwapWindow(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1262, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_DeleteContext")]
        public unsafe partial void GLDeleteContext(void* context);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1262, Column 30 in build/submodules/SDL-mirror/include\\SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_DeleteContext")]
        public partial void GLDeleteContext<T0>(ref T0 context) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 116, Column 29 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_LoadLibrary")]
        public unsafe partial int VulkanLoadLibrary(byte* path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 116, Column 29 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_LoadLibrary")]
        public partial int VulkanLoadLibrary(ref byte path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 116, Column 29 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_LoadLibrary")]
        public partial int VulkanLoadLibrary(string path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 124, Column 31 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetVkGetInstanceProcAddr")]
        public unsafe partial void* VulkanGetVkGetInstanceProcAddr();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 132, Column 30 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_UnloadLibrary")]
        public partial void VulkanUnloadLibrary();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        public unsafe partial SdlBool VulkanGetInstanceExtensions(Window* window, uint* pCount, byte** pNames);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        public unsafe partial SdlBool VulkanGetInstanceExtensions(Window* window, uint* pCount, ref byte* pNames);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        public unsafe partial SdlBool VulkanGetInstanceExtensions(Window* window, ref uint pCount, byte** pNames);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        public unsafe partial SdlBool VulkanGetInstanceExtensions(Window* window, ref uint pCount, ref byte* pNames);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        public unsafe partial SdlBool VulkanGetInstanceExtensions(ref Window window, uint* pCount, byte** pNames);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        public unsafe partial SdlBool VulkanGetInstanceExtensions(ref Window window, uint* pCount, ref byte* pNames);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        public unsafe partial SdlBool VulkanGetInstanceExtensions(ref Window window, ref uint pCount, byte** pNames);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        public unsafe partial SdlBool VulkanGetInstanceExtensions(ref Window window, ref uint pCount, ref byte* pNames);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_CreateSurface")]
        public unsafe partial SdlBool VulkanCreateSurface(Window* window, Silk.NET.Core.Native.VkHandle instance, Silk.NET.Core.Native.VkNonDispatchableHandle* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_CreateSurface")]
        public unsafe partial SdlBool VulkanCreateSurface(Window* window, Silk.NET.Core.Native.VkHandle instance, ref Silk.NET.Core.Native.VkNonDispatchableHandle surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_CreateSurface")]
        public unsafe partial SdlBool VulkanCreateSurface(ref Window window, Silk.NET.Core.Native.VkHandle instance, Silk.NET.Core.Native.VkNonDispatchableHandle* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_CreateSurface")]
        public partial SdlBool VulkanCreateSurface(ref Window window, Silk.NET.Core.Native.VkHandle instance, ref Silk.NET.Core.Native.VkNonDispatchableHandle surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetDrawableSize")]
        public unsafe partial void VulkanGetDrawableSize(Window* window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetDrawableSize")]
        public unsafe partial void VulkanGetDrawableSize(Window* window, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetDrawableSize")]
        public unsafe partial void VulkanGetDrawableSize(Window* window, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetDrawableSize")]
        public unsafe partial void VulkanGetDrawableSize(Window* window, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetDrawableSize")]
        public unsafe partial void VulkanGetDrawableSize(ref Window window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetDrawableSize")]
        public unsafe partial void VulkanGetDrawableSize(ref Window window, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetDrawableSize")]
        public unsafe partial void VulkanGetDrawableSize(ref Window window, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 30 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetDrawableSize")]
        public partial void VulkanGetDrawableSize(ref Window window, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 30 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [NativeApi(EntryPoint = "SDL_SetMainReady")]
        public partial void SetMainReady();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_RegisterApp")]
        public unsafe partial int RegisterApp(byte* name, uint style, void* hInst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_RegisterApp")]
        public unsafe partial int RegisterApp<T0>(byte* name, uint style, ref T0 hInst) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_RegisterApp")]
        public unsafe partial int RegisterApp(ref byte name, uint style, void* hInst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_RegisterApp")]
        public partial int RegisterApp<T0>(ref byte name, uint style, ref T0 hInst) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_RegisterApp")]
        public unsafe partial int RegisterApp(string name, uint style, void* hInst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_RegisterApp")]
        public partial int RegisterApp<T0>(string name, uint style, ref T0 hInst) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 30 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_UnregisterApp")]
        public partial void UnregisterApp();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 154, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_WinRTRunApp")]
        public unsafe partial int WinRTRunApp(PfnMainFunc mainFunction, void* reserved);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 154, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_WinRTRunApp")]
        public partial int WinRTRunApp<T0>(PfnMainFunc mainFunction, ref T0 reserved) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [NativeApi(EntryPoint = "SDL_UIKitRunApp")]
        public unsafe partial int UIKitRunApp(int argc, byte** argv, PfnMainFunc mainFunction);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        [NativeApi(EntryPoint = "SDL_UIKitRunApp")]
        public unsafe partial int UIKitRunApp(int argc, ref byte* argv, PfnMainFunc mainFunction);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 52, Column 25 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "__debugbreak")]
        public partial void Debugbreak();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(AssertData* arg0, byte* arg1, byte* arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(AssertData* arg0, byte* arg1, ref byte arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(AssertData* arg0, byte* arg1, string arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(AssertData* arg0, ref byte arg1, byte* arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(AssertData* arg0, ref byte arg1, ref byte arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(AssertData* arg0, ref byte arg1, string arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(AssertData* arg0, string arg1, byte* arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(AssertData* arg0, string arg1, ref byte arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(AssertData* arg0, string arg1, string arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(ref AssertData arg0, byte* arg1, byte* arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(ref AssertData arg0, byte* arg1, ref byte arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(ref AssertData arg0, byte* arg1, string arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(ref AssertData arg0, ref byte arg1, byte* arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public partial AssertState ReportAssertion(ref AssertData arg0, ref byte arg1, ref byte arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public partial AssertState ReportAssertion(ref AssertData arg0, ref byte arg1, string arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(ref AssertData arg0, string arg1, byte* arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public partial AssertState ReportAssertion(ref AssertData arg0, string arg1, ref byte arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 125, Column 41 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public partial AssertState ReportAssertion(ref AssertData arg0, string arg1, string arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 30 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_SetAssertionHandler")]
        public unsafe partial void SetAssertionHandler(PfnAssertionHandler handler, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 30 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_SetAssertionHandler")]
        public partial void SetAssertionHandler<T0>(PfnAssertionHandler handler, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 46 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_GetDefaultAssertionHandler")]
        public partial PfnAssertionHandler GetDefaultAssertionHandler();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 242, Column 46 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_GetAssertionHandler")]
        public unsafe partial PfnAssertionHandler GetAssertionHandler(void** puserdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 242, Column 46 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_GetAssertionHandler")]
        public unsafe partial PfnAssertionHandler GetAssertionHandler(ref void* puserdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 266, Column 48 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_GetAssertionReport")]
        public unsafe partial AssertData* GetAssertionReport();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 275, Column 30 in build/submodules/SDL-mirror/include\\SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ResetAssertionReport")]
        public partial void ResetAssertionReport();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicTryLock")]
        public unsafe partial SdlBool AtomicTryLock(int* @lock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicTryLock")]
        public partial SdlBool AtomicTryLock(ref int @lock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 105, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicLock")]
        public unsafe partial void AtomicLock(int* @lock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 105, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicLock")]
        public partial void AtomicLock(ref int @lock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicUnlock")]
        public unsafe partial void AtomicUnlock(int* @lock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicUnlock")]
        public partial void AtomicUnlock(ref int @lock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 155, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_MemoryBarrierReleaseFunction")]
        public partial void MemoryBarrierReleaseFunction();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 156, Column 30 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_MemoryBarrierAcquireFunction")]
        public partial void MemoryBarrierAcquireFunction();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCAS")]
        public unsafe partial SdlBool AtomicCAS(AtomicT* a, int oldval, int newval);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCAS")]
        public partial SdlBool AtomicCAS(ref AtomicT a, int oldval, int newval);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicSet")]
        public unsafe partial int AtomicSet(AtomicT* a, int v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicSet")]
        public partial int AtomicSet(ref AtomicT a, int v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicGet")]
        public unsafe partial int AtomicGet(AtomicT* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicGet")]
        public partial int AtomicGet(ref AtomicT a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicAdd")]
        public unsafe partial int AtomicAdd(AtomicT* a, int v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 29 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicAdd")]
        public partial int AtomicAdd(ref AtomicT a, int v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCASPtr")]
        public unsafe partial SdlBool AtomicCASPtr(void** a, void* oldval, void* newval);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCASPtr")]
        public unsafe partial SdlBool AtomicCASPtr<T0>(void** a, void* oldval, ref T0 newval) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCASPtr")]
        public unsafe partial SdlBool AtomicCASPtr<T0>(void** a, ref T0 oldval, void* newval) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCASPtr")]
        public unsafe partial SdlBool AtomicCASPtr<T0, T1>(void** a, ref T0 oldval, ref T1 newval) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCASPtr")]
        public unsafe partial SdlBool AtomicCASPtr(ref void* a, void* oldval, void* newval);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCASPtr")]
        public unsafe partial SdlBool AtomicCASPtr<T0>(ref void* a, void* oldval, ref T0 newval) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCASPtr")]
        public unsafe partial SdlBool AtomicCASPtr<T0>(ref void* a, ref T0 oldval, void* newval) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCASPtr")]
        public unsafe partial SdlBool AtomicCASPtr<T0, T1>(ref void* a, ref T0 oldval, ref T1 newval) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 279, Column 31 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicSetPtr")]
        public unsafe partial void* AtomicSetPtr(void** a, void* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 279, Column 31 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicSetPtr")]
        public unsafe partial void* AtomicSetPtr<T0>(void** a, ref T0 v) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 279, Column 31 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicSetPtr")]
        public unsafe partial void* AtomicSetPtr(ref void* a, void* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 279, Column 31 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicSetPtr")]
        public unsafe partial void* AtomicSetPtr<T0>(ref void* a, ref T0 v) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 284, Column 31 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicGetPtr")]
        public unsafe partial void* AtomicGetPtr(void** a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 284, Column 31 in build/submodules/SDL-mirror/include/SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicGetPtr")]
        public unsafe partial void* AtomicGetPtr(ref void* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 36 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CreateMutex")]
        public unsafe partial Mutex* CreateMutex();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 72, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_LockMutex")]
        public unsafe partial int LockMutex(Mutex* mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 72, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_LockMutex")]
        public partial int LockMutex(ref Mutex mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_TryLockMutex")]
        public unsafe partial int TryLockMutex(Mutex* mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_TryLockMutex")]
        public partial int TryLockMutex(ref Mutex mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 90, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_UnlockMutex")]
        public unsafe partial int UnlockMutex(Mutex* mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 90, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_UnlockMutex")]
        public partial int UnlockMutex(ref Mutex mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroyMutex")]
        public unsafe partial void DestroyMutex(Mutex* mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroyMutex")]
        public partial void DestroyMutex(ref Mutex mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 34 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CreateSemaphore")]
        public unsafe partial Semaphore* CreateSemaphore(uint initial_value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroySemaphore")]
        public unsafe partial void DestroySemaphore(Semaphore* sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroySemaphore")]
        public partial void DestroySemaphore(ref Semaphore sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 124, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemWait")]
        public unsafe partial int SemWait(Semaphore* sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 124, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemWait")]
        public partial int SemWait(ref Semaphore sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 132, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemTryWait")]
        public unsafe partial int SemTryWait(Semaphore* sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 132, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemTryWait")]
        public partial int SemTryWait(ref Semaphore sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 143, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemWaitTimeout")]
        public unsafe partial int SemWaitTimeout(Semaphore* sem, uint ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 143, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemWaitTimeout")]
        public partial int SemWaitTimeout(ref Semaphore sem, uint ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 150, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemPost")]
        public unsafe partial int SemPost(Semaphore* sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 150, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemPost")]
        public partial int SemPost(ref Semaphore sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 155, Column 32 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemValue")]
        public unsafe partial uint SemValue(Semaphore* sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 155, Column 32 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemValue")]
        public partial uint SemValue(ref Semaphore sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 35 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CreateCond")]
        public unsafe partial Cond* CreateCond();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroyCond")]
        public unsafe partial void DestroyCond(Cond* cond);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 30 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroyCond")]
        public partial void DestroyCond(ref Cond cond);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 209, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondSignal")]
        public unsafe partial int CondSignal(Cond* cond);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 209, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondSignal")]
        public partial int CondSignal(ref Cond cond);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondBroadcast")]
        public unsafe partial int CondBroadcast(Cond* cond);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondBroadcast")]
        public partial int CondBroadcast(ref Cond cond);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWait")]
        public unsafe partial int CondWait(Cond* cond, Mutex* mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWait")]
        public unsafe partial int CondWait(Cond* cond, ref Mutex mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWait")]
        public unsafe partial int CondWait(ref Cond cond, Mutex* mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWait")]
        public partial int CondWait(ref Cond cond, ref Mutex mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWaitTimeout")]
        public unsafe partial int CondWaitTimeout(Cond* cond, Mutex* mutex, uint ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWaitTimeout")]
        public unsafe partial int CondWaitTimeout(Cond* cond, ref Mutex mutex, uint ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWaitTimeout")]
        public unsafe partial int CondWaitTimeout(ref Cond cond, Mutex* mutex, uint ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWaitTimeout")]
        public partial int CondWaitTimeout(ref Cond cond, ref Mutex mutex, uint ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThread")]
        public unsafe partial Thread* CreateThread(PfnThreadFunction fn, byte* name, void* data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThread")]
        public unsafe partial Thread* CreateThread<T0>(PfnThreadFunction fn, byte* name, ref T0 data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThread")]
        public unsafe partial Thread* CreateThread(PfnThreadFunction fn, ref byte name, void* data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThread")]
        public unsafe partial Thread* CreateThread<T0>(PfnThreadFunction fn, ref byte name, ref T0 data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThread")]
        public unsafe partial Thread* CreateThread(PfnThreadFunction fn, string name, void* data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThread")]
        public unsafe partial Thread* CreateThread<T0>(PfnThreadFunction fn, string name, ref T0 data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThreadWithStackSize")]
        public unsafe partial Thread* CreateThreadWithStackSize(PfnThreadFunction fn, byte* name, uint stacksize, void* data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThreadWithStackSize")]
        public unsafe partial Thread* CreateThreadWithStackSize<T0>(PfnThreadFunction fn, byte* name, uint stacksize, ref T0 data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThreadWithStackSize")]
        public unsafe partial Thread* CreateThreadWithStackSize(PfnThreadFunction fn, ref byte name, uint stacksize, void* data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThreadWithStackSize")]
        public unsafe partial Thread* CreateThreadWithStackSize<T0>(PfnThreadFunction fn, ref byte name, uint stacksize, ref T0 data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThreadWithStackSize")]
        public unsafe partial Thread* CreateThreadWithStackSize(PfnThreadFunction fn, string name, uint stacksize, void* data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThreadWithStackSize")]
        public unsafe partial Thread* CreateThreadWithStackSize<T0>(PfnThreadFunction fn, string name, uint stacksize, ref T0 data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 37 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadName")]
        public unsafe partial byte* GetThreadName(Thread* thread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 37 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadName")]
        public unsafe partial string GetThreadNameS(Thread* thread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 37 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadName")]
        public unsafe partial byte* GetThreadName(ref Thread thread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 37 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadName")]
        public partial string GetThreadNameS(ref Thread thread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 38 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_ThreadID")]
        public partial uint ThreadID();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 38 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadID")]
        public unsafe partial uint GetThreadID(Thread* thread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 38 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadID")]
        public partial uint GetThreadID(ref Thread thread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 244, Column 29 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_SetThreadPriority")]
        public partial int SetThreadPriority(ThreadPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_WaitThread")]
        public unsafe partial void WaitThread(Thread* thread, int* status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_WaitThread")]
        public unsafe partial void WaitThread(Thread* thread, ref int status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_WaitThread")]
        public unsafe partial void WaitThread(ref Thread thread, int* status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_WaitThread")]
        public partial void WaitThread(ref Thread thread, ref int status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_DetachThread")]
        public unsafe partial void DetachThread(Thread* thread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 30 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_DetachThread")]
        public partial void DetachThread(ref Thread thread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 324, Column 35 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_TLSCreate")]
        public partial uint TLSCreate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 336, Column 32 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_TLSGet")]
        public unsafe partial void* TLSGet(uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 350, Column 29 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_TLSSet")]
        public unsafe partial int TLSSet(uint id, void* value, PfnFreeFunc destructor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 350, Column 29 in build/submodules/SDL-mirror/include\\SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_TLSSet")]
        public partial int TLSSet<T0>(uint id, ref T0 value, PfnFreeFunc destructor) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 251, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetNumAudioDrivers")]
        public partial int GetNumAudioDrivers();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 252, Column 37 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDriver")]
        public unsafe partial byte* GetAudioDriver(int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 252, Column 37 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDriver")]
        public partial string GetAudioDriverS(int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioInit")]
        public unsafe partial int AudioInit(byte* driver_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioInit")]
        public partial int AudioInit(ref byte driver_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioInit")]
        public partial int AudioInit(string driver_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioQuit")]
        public partial void AudioQuit();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 271, Column 37 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentAudioDriver")]
        public unsafe partial byte* GetCurrentAudioDriver();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 271, Column 37 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentAudioDriver")]
        public partial string GetCurrentAudioDriverS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudio")]
        public unsafe partial int OpenAudio(AudioSpec* desired, AudioSpec* obtained);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudio")]
        public unsafe partial int OpenAudio(AudioSpec* desired, ref AudioSpec obtained);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudio")]
        public unsafe partial int OpenAudio(ref AudioSpec desired, AudioSpec* obtained);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudio")]
        public partial int OpenAudio(ref AudioSpec desired, ref AudioSpec obtained);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 344, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetNumAudioDevices")]
        public partial int GetNumAudioDevices(int iscapture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 359, Column 37 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDeviceName")]
        public unsafe partial byte* GetAudioDeviceName(int index, int iscapture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 359, Column 37 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDeviceName")]
        public partial string GetAudioDeviceNameS(int index, int iscapture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public unsafe partial uint OpenAudioDevice(byte* device, int iscapture, AudioSpec* desired, AudioSpec* obtained, int allowed_changes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public unsafe partial uint OpenAudioDevice(byte* device, int iscapture, AudioSpec* desired, ref AudioSpec obtained, int allowed_changes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public unsafe partial uint OpenAudioDevice(byte* device, int iscapture, ref AudioSpec desired, AudioSpec* obtained, int allowed_changes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public unsafe partial uint OpenAudioDevice(byte* device, int iscapture, ref AudioSpec desired, ref AudioSpec obtained, int allowed_changes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public unsafe partial uint OpenAudioDevice(ref byte device, int iscapture, AudioSpec* desired, AudioSpec* obtained, int allowed_changes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public unsafe partial uint OpenAudioDevice(ref byte device, int iscapture, AudioSpec* desired, ref AudioSpec obtained, int allowed_changes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public unsafe partial uint OpenAudioDevice(ref byte device, int iscapture, ref AudioSpec desired, AudioSpec* obtained, int allowed_changes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public partial uint OpenAudioDevice(ref byte device, int iscapture, ref AudioSpec desired, ref AudioSpec obtained, int allowed_changes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public unsafe partial uint OpenAudioDevice(string device, int iscapture, AudioSpec* desired, AudioSpec* obtained, int allowed_changes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public unsafe partial uint OpenAudioDevice(string device, int iscapture, AudioSpec* desired, ref AudioSpec obtained, int allowed_changes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public unsafe partial uint OpenAudioDevice(string device, int iscapture, ref AudioSpec desired, AudioSpec* obtained, int allowed_changes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public partial uint OpenAudioDevice(string device, int iscapture, ref AudioSpec desired, ref AudioSpec obtained, int allowed_changes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 401, Column 41 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioStatus")]
        public partial AudioStatus GetAudioStatus();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 1 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDeviceStatus")]
        public partial AudioStatus GetAudioDeviceStatus(uint dev);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 417, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_PauseAudio")]
        public partial void PauseAudio(int pause_on);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_PauseAudioDevice")]
        public partial void PauseAudioDevice(uint dev, int pause_on);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(RWops* src, int freesrc, AudioSpec* spec, byte** audio_buf, uint* audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(RWops* src, int freesrc, AudioSpec* spec, byte** audio_buf, ref uint audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(RWops* src, int freesrc, AudioSpec* spec, ref byte* audio_buf, uint* audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(RWops* src, int freesrc, AudioSpec* spec, ref byte* audio_buf, ref uint audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(RWops* src, int freesrc, ref AudioSpec spec, byte** audio_buf, uint* audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(RWops* src, int freesrc, ref AudioSpec spec, byte** audio_buf, ref uint audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(RWops* src, int freesrc, ref AudioSpec spec, ref byte* audio_buf, uint* audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(RWops* src, int freesrc, ref AudioSpec spec, ref byte* audio_buf, ref uint audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(ref RWops src, int freesrc, AudioSpec* spec, byte** audio_buf, uint* audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(ref RWops src, int freesrc, AudioSpec* spec, byte** audio_buf, ref uint audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(ref RWops src, int freesrc, AudioSpec* spec, ref byte* audio_buf, uint* audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(ref RWops src, int freesrc, AudioSpec* spec, ref byte* audio_buf, ref uint audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(ref RWops src, int freesrc, ref AudioSpec spec, byte** audio_buf, uint* audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(ref RWops src, int freesrc, ref AudioSpec spec, byte** audio_buf, ref uint audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(ref RWops src, int freesrc, ref AudioSpec spec, ref byte* audio_buf, uint* audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(ref RWops src, int freesrc, ref AudioSpec spec, ref byte* audio_buf, ref uint audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_FreeWAV")]
        public unsafe partial void FreeWAV(byte* audio_buf);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_FreeWAV")]
        public partial void FreeWAV(ref byte audio_buf);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_FreeWAV")]
        public partial void FreeWAV(string audio_buf);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_BuildAudioCVT")]
        public unsafe partial int BuildAudioCVT(AudioCVT* cvt, ushort src_format, byte src_channels, int src_rate, ushort dst_format, byte dst_channels, int dst_rate);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_BuildAudioCVT")]
        public partial int BuildAudioCVT(ref AudioCVT cvt, ushort src_format, byte src_channels, int src_rate, ushort dst_format, byte dst_channels, int dst_rate);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_ConvertAudio")]
        public unsafe partial int ConvertAudio(AudioCVT* cvt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_ConvertAudio")]
        public partial int ConvertAudio(ref AudioCVT cvt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 552, Column 43 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_NewAudioStream")]
        public unsafe partial AudioStream* NewAudioStream(ushort src_format, byte src_channels, int src_rate, ushort dst_format, byte dst_channels, int dst_rate);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 574, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamPut")]
        public unsafe partial int AudioStreamPut(AudioStream* stream, void* buf, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 574, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamPut")]
        public unsafe partial int AudioStreamPut<T0>(AudioStream* stream, ref T0 buf, int len) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 574, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamPut")]
        public unsafe partial int AudioStreamPut(ref AudioStream stream, void* buf, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 574, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamPut")]
        public partial int AudioStreamPut<T0>(ref AudioStream stream, ref T0 buf, int len) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamGet")]
        public unsafe partial int AudioStreamGet(AudioStream* stream, void* buf, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamGet")]
        public unsafe partial int AudioStreamGet<T0>(AudioStream* stream, ref T0 buf, int len) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamGet")]
        public unsafe partial int AudioStreamGet(ref AudioStream stream, void* buf, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamGet")]
        public partial int AudioStreamGet<T0>(ref AudioStream stream, ref T0 buf, int len) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamAvailable")]
        public unsafe partial int AudioStreamAvailable(AudioStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamAvailable")]
        public partial int AudioStreamAvailable(ref AudioStream stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 623, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamFlush")]
        public unsafe partial int AudioStreamFlush(AudioStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 623, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamFlush")]
        public partial int AudioStreamFlush(ref AudioStream stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 635, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamClear")]
        public unsafe partial void AudioStreamClear(AudioStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 635, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamClear")]
        public partial void AudioStreamClear(ref AudioStream stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 647, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_FreeAudioStream")]
        public unsafe partial void FreeAudioStream(AudioStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 647, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_FreeAudioStream")]
        public partial void FreeAudioStream(ref AudioStream stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudio")]
        public unsafe partial void MixAudio(byte* dst, byte* src, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudio")]
        public unsafe partial void MixAudio(byte* dst, ref byte src, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudio")]
        public unsafe partial void MixAudio(byte* dst, string src, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudio")]
        public unsafe partial void MixAudio(ref byte dst, byte* src, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudio")]
        public partial void MixAudio(ref byte dst, ref byte src, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudio")]
        public partial void MixAudio(ref byte dst, string src, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudio")]
        public unsafe partial void MixAudio(string dst, byte* src, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudio")]
        public partial void MixAudio(string dst, ref byte src, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudio")]
        public partial void MixAudio(string dst, string src, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudioFormat")]
        public unsafe partial void MixAudioFormat(byte* dst, byte* src, ushort format, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudioFormat")]
        public unsafe partial void MixAudioFormat(byte* dst, ref byte src, ushort format, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudioFormat")]
        public unsafe partial void MixAudioFormat(byte* dst, string src, ushort format, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudioFormat")]
        public unsafe partial void MixAudioFormat(ref byte dst, byte* src, ushort format, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudioFormat")]
        public partial void MixAudioFormat(ref byte dst, ref byte src, ushort format, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudioFormat")]
        public partial void MixAudioFormat(ref byte dst, string src, ushort format, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudioFormat")]
        public unsafe partial void MixAudioFormat(string dst, byte* src, ushort format, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudioFormat")]
        public partial void MixAudioFormat(string dst, ref byte src, ushort format, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudioFormat")]
        public partial void MixAudioFormat(string dst, string src, ushort format, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 709, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_QueueAudio")]
        public unsafe partial int QueueAudio(uint dev, void* data, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 709, Column 29 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_QueueAudio")]
        public partial int QueueAudio<T0>(uint dev, ref T0 data, uint len) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 32 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_DequeueAudio")]
        public unsafe partial uint DequeueAudio(uint dev, void* data, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 32 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_DequeueAudio")]
        public partial uint DequeueAudio<T0>(uint dev, ref T0 data, uint len) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 791, Column 32 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetQueuedAudioSize")]
        public partial uint GetQueuedAudioSize(uint dev);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 827, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_ClearQueuedAudio")]
        public partial void ClearQueuedAudio(uint dev);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 839, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LockAudio")]
        public partial void LockAudio();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 840, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LockAudioDevice")]
        public partial void LockAudioDevice(uint dev);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 841, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_UnlockAudio")]
        public partial void UnlockAudio();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 842, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_UnlockAudioDevice")]
        public partial void UnlockAudioDevice(uint dev);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 848, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_CloseAudio")]
        public partial void CloseAudio();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 849, Column 30 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_CloseAudioDevice")]
        public partial void CloseAudioDevice(uint dev);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 29 in build/submodules/SDL-mirror/include\\SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_SetClipboardText")]
        public unsafe partial int SetClipboardText(byte* text);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 29 in build/submodules/SDL-mirror/include\\SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_SetClipboardText")]
        public partial int SetClipboardText(ref byte text);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 29 in build/submodules/SDL-mirror/include\\SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_SetClipboardText")]
        public partial int SetClipboardText(string text);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 53, Column 32 in build/submodules/SDL-mirror/include\\SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_GetClipboardText")]
        public unsafe partial byte* GetClipboardText();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 53, Column 32 in build/submodules/SDL-mirror/include\\SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_GetClipboardText")]
        public partial string GetClipboardTextS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 60, Column 34 in build/submodules/SDL-mirror/include\\SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_HasClipboardText")]
        public partial SdlBool HasClipboardText();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 119, Column 29 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_GetCPUCount")]
        public partial int GetCPUCount();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 29 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_GetCPUCacheLineSize")]
        public partial int GetCPUCacheLineSize();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 132, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasRDTSC")]
        public partial SdlBool HasRDTSC();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 137, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasAltiVec")]
        public partial SdlBool HasAltiVec();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasMMX")]
        public partial SdlBool HasMMX();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_Has3DNow")]
        public partial SdlBool Has3DNow();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 152, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE")]
        public partial SdlBool HasSSE();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE2")]
        public partial SdlBool HasSSE2();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 162, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE3")]
        public partial SdlBool HasSSE3();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 167, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE41")]
        public partial SdlBool HasSSE41();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 172, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE42")]
        public partial SdlBool HasSSE42();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 177, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasAVX")]
        public partial SdlBool HasAVX();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasAVX2")]
        public partial SdlBool HasAVX2();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 187, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasAVX512F")]
        public partial SdlBool HasAVX512F();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 192, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasARMSIMD")]
        public partial SdlBool HasARMSIMD();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 34 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasNEON")]
        public partial SdlBool HasNEON();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 29 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_GetSystemRAM")]
        public partial int GetSystemRAM();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 32 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_SIMDGetAlignment")]
        public partial uint SIMDGetAlignment();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 251, Column 32 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_SIMDAlloc")]
        public unsafe partial void* SIMDAlloc(uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_SIMDFree")]
        public unsafe partial void SIMDFree(void* ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 30 in build/submodules/SDL-mirror/include\\SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_SIMDFree")]
        public partial void SIMDFree<T0>(ref T0 ptr) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 60, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyboardFocus")]
        public unsafe partial Window* GetKeyboardFocus();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyboardState")]
        public unsafe partial byte* GetKeyboardState(int* numkeys);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyboardState")]
        public unsafe partial string GetKeyboardStateS(int* numkeys);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyboardState")]
        public unsafe partial byte* GetKeyboardState(ref int numkeys);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyboardState")]
        public partial string GetKeyboardStateS(ref int numkeys);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 82, Column 36 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetModState")]
        public partial Keymod GetModState();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 30 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_SetModState")]
        public partial void SetModState(Keymod modstate);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 99, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyFromScancode")]
        public partial int GetKeyFromScancode(Scancode scancode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 109, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeFromKey")]
        public partial Scancode GetScancodeFromKey(int key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeName")]
        public unsafe partial byte* GetScancodeName(Scancode scancode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeName")]
        public partial string GetScancodeNameS(Scancode scancode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 129, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeFromName")]
        public unsafe partial Scancode GetScancodeFromName(byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 129, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeFromName")]
        public partial Scancode GetScancodeFromName(ref byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 129, Column 38 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeFromName")]
        public partial Scancode GetScancodeFromName(string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 141, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyName")]
        public unsafe partial byte* GetKeyName(int key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 141, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyName")]
        public partial string GetKeyNameS(int key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 150, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyFromName")]
        public unsafe partial int GetKeyFromName(byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 150, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyFromName")]
        public partial int GetKeyFromName(ref byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 150, Column 37 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyFromName")]
        public partial int GetKeyFromName(string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 30 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_StartTextInput")]
        public partial void StartTextInput();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 34 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_IsTextInputActive")]
        public partial SdlBool IsTextInputActive();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 177, Column 30 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_StopTextInput")]
        public partial void StopTextInput();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 185, Column 30 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_SetTextInputRect")]
        public unsafe partial void SetTextInputRect(Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 185, Column 30 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_SetTextInputRect")]
        public partial void SetTextInputRect(ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 196, Column 34 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_HasScreenKeyboardSupport")]
        public partial SdlBool HasScreenKeyboardSupport();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_IsScreenKeyboardShown")]
        public unsafe partial SdlBool IsScreenKeyboardShown(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in build/submodules/SDL-mirror/include/SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_IsScreenKeyboardShown")]
        public partial SdlBool IsScreenKeyboardShown(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 38 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetMouseFocus")]
        public unsafe partial Window* GetMouseFocus();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetMouseState")]
        public unsafe partial uint GetMouseState(int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetMouseState")]
        public unsafe partial uint GetMouseState(int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetMouseState")]
        public unsafe partial uint GetMouseState(ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetMouseState")]
        public partial uint GetMouseState(ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetGlobalMouseState")]
        public unsafe partial uint GetGlobalMouseState(int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetGlobalMouseState")]
        public unsafe partial uint GetGlobalMouseState(int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetGlobalMouseState")]
        public unsafe partial uint GetGlobalMouseState(ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetGlobalMouseState")]
        public partial uint GetGlobalMouseState(ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetRelativeMouseState")]
        public unsafe partial uint GetRelativeMouseState(int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetRelativeMouseState")]
        public unsafe partial uint GetRelativeMouseState(int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetRelativeMouseState")]
        public unsafe partial uint GetRelativeMouseState(ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 32 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetRelativeMouseState")]
        public partial uint GetRelativeMouseState(ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 132, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_WarpMouseInWindow")]
        public unsafe partial void WarpMouseInWindow(Window* window, int x, int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 132, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_WarpMouseInWindow")]
        public partial void WarpMouseInWindow(ref Window window, int x, int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 29 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_WarpMouseGlobal")]
        public partial int WarpMouseGlobal(int x, int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 162, Column 29 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_SetRelativeMouseMode")]
        public partial int SetRelativeMouseMode(SdlBool enabled);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 193, Column 29 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CaptureMouse")]
        public partial int CaptureMouse(SdlBool enabled);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 34 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetRelativeMouseMode")]
        public partial SdlBool GetRelativeMouseMode();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateCursor")]
        public unsafe partial Cursor* CreateCursor(byte* data, byte* mask, int w, int h, int hot_x, int hot_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateCursor")]
        public unsafe partial Cursor* CreateCursor(byte* data, ref byte mask, int w, int h, int hot_x, int hot_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateCursor")]
        public unsafe partial Cursor* CreateCursor(byte* data, string mask, int w, int h, int hot_x, int hot_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateCursor")]
        public unsafe partial Cursor* CreateCursor(ref byte data, byte* mask, int w, int h, int hot_x, int hot_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateCursor")]
        public unsafe partial Cursor* CreateCursor(ref byte data, ref byte mask, int w, int h, int hot_x, int hot_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateCursor")]
        public unsafe partial Cursor* CreateCursor(ref byte data, string mask, int w, int h, int hot_x, int hot_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateCursor")]
        public unsafe partial Cursor* CreateCursor(string data, byte* mask, int w, int h, int hot_x, int hot_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateCursor")]
        public unsafe partial Cursor* CreateCursor(string data, ref byte mask, int w, int h, int hot_x, int hot_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateCursor")]
        public unsafe partial Cursor* CreateCursor(string data, string mask, int w, int h, int hot_x, int hot_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateColorCursor")]
        public unsafe partial Cursor* CreateColorCursor(Surface* surface, int hot_x, int hot_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateColorCursor")]
        public unsafe partial Cursor* CreateColorCursor(ref Surface surface, int hot_x, int hot_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateSystemCursor")]
        public unsafe partial Cursor* CreateSystemCursor(SystemCursor id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 244, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_SetCursor")]
        public unsafe partial void SetCursor(Cursor* cursor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 244, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_SetCursor")]
        public partial void SetCursor(ref Cursor cursor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 249, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetCursor")]
        public unsafe partial Cursor* GetCursor();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 37 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetDefaultCursor")]
        public unsafe partial Cursor* GetDefaultCursor();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_FreeCursor")]
        public unsafe partial void FreeCursor(Cursor* cursor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 30 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_FreeCursor")]
        public partial void FreeCursor(ref Cursor cursor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 273, Column 29 in build/submodules/SDL-mirror/include/SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_ShowCursor")]
        public partial int ShowCursor(int toggle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_LockJoysticks")]
        public partial void LockJoysticks();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_UnlockJoysticks")]
        public partial void UnlockJoysticks();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_NumJoysticks")]
        public partial int NumJoysticks();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 133, Column 37 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNameForIndex")]
        public unsafe partial byte* JoystickNameForIndex(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 133, Column 37 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNameForIndex")]
        public partial string JoystickNameForIndexS(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDevicePlayerIndex")]
        public partial int JoystickGetDevicePlayerIndex(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceGUID")]
        public partial JoystickGUID JoystickGetDeviceGUID(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 152, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceVendor")]
        public partial ushort JoystickGetDeviceVendor(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 159, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceProduct")]
        public partial ushort JoystickGetDeviceProduct(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 166, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceProductVersion")]
        public partial ushort JoystickGetDeviceProductVersion(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 172, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceType")]
        public partial JoystickType JoystickGetDeviceType(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 179, Column 40 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceInstanceID")]
        public partial int JoystickGetDeviceInstanceID(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 39 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickOpen")]
        public unsafe partial Joystick* JoystickOpen(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 195, Column 39 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickFromInstanceID")]
        public unsafe partial Joystick* JoystickFromInstanceID(int instance_id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 39 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickFromPlayerIndex")]
        public unsafe partial Joystick* JoystickFromPlayerIndex(int player_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 37 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickName")]
        public unsafe partial byte* JoystickName(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 37 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickName")]
        public unsafe partial string JoystickNameS(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 37 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickName")]
        public unsafe partial byte* JoystickName(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 37 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickName")]
        public partial string JoystickNameS(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 213, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetPlayerIndex")]
        public unsafe partial int JoystickGetPlayerIndex(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 213, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetPlayerIndex")]
        public partial int JoystickGetPlayerIndex(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickSetPlayerIndex")]
        public unsafe partial void JoystickSetPlayerIndex(Joystick* joystick, int player_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickSetPlayerIndex")]
        public partial void JoystickSetPlayerIndex(ref Joystick joystick, int player_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 223, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUID")]
        public unsafe partial JoystickGUID JoystickGetGUID(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 223, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUID")]
        public partial JoystickGUID JoystickGetGUID(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 229, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetVendor")]
        public unsafe partial ushort JoystickGetVendor(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 229, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetVendor")]
        public partial ushort JoystickGetVendor(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 235, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetProduct")]
        public unsafe partial ushort JoystickGetProduct(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 235, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetProduct")]
        public partial ushort JoystickGetProduct(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetProductVersion")]
        public unsafe partial ushort JoystickGetProductVersion(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetProductVersion")]
        public partial ushort JoystickGetProductVersion(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetType")]
        public unsafe partial JoystickType JoystickGetType(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetType")]
        public partial JoystickType JoystickGetType(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 252, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDString")]
        public unsafe partial void JoystickGetGUIDString(JoystickGUID guid, byte* pszGUID, int cbGUID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 252, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDString")]
        public partial void JoystickGetGUIDString(JoystickGUID guid, ref byte pszGUID, int cbGUID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 252, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDString")]
        public partial void JoystickGetGUIDString(JoystickGUID guid, string pszGUID, int cbGUID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDFromString")]
        public unsafe partial JoystickGUID JoystickGetGUIDFromString(byte* pchGUID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDFromString")]
        public partial JoystickGUID JoystickGetGUIDFromString(ref byte pchGUID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 42 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDFromString")]
        public partial JoystickGUID JoystickGetGUIDFromString(string pchGUID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 262, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAttached")]
        public unsafe partial SdlBool JoystickGetAttached(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 262, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAttached")]
        public partial SdlBool JoystickGetAttached(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 40 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickInstanceID")]
        public unsafe partial int JoystickInstanceID(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 40 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickInstanceID")]
        public partial int JoystickInstanceID(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumAxes")]
        public unsafe partial int JoystickNumAxes(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumAxes")]
        public partial int JoystickNumAxes(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 280, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumBalls")]
        public unsafe partial int JoystickNumBalls(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 280, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumBalls")]
        public partial int JoystickNumBalls(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumHats")]
        public unsafe partial int JoystickNumHats(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumHats")]
        public partial int JoystickNumHats(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumButtons")]
        public unsafe partial int JoystickNumButtons(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumButtons")]
        public partial int JoystickNumButtons(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 298, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickUpdate")]
        public partial void JoystickUpdate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 309, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickEventState")]
        public partial int JoystickEventState(int state);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 320, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAxis")]
        public unsafe partial short JoystickGetAxis(Joystick* joystick, int axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 320, Column 32 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAxis")]
        public partial short JoystickGetAxis(ref Joystick joystick, int axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAxisInitialState")]
        public unsafe partial SdlBool JoystickGetAxisInitialState(Joystick* joystick, int axis, short* state);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAxisInitialState")]
        public unsafe partial SdlBool JoystickGetAxisInitialState(Joystick* joystick, int axis, ref short state);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAxisInitialState")]
        public unsafe partial SdlBool JoystickGetAxisInitialState(ref Joystick joystick, int axis, short* state);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 34 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAxisInitialState")]
        public partial SdlBool JoystickGetAxisInitialState(ref Joystick joystick, int axis, ref short state);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 366, Column 31 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetHat")]
        public unsafe partial byte JoystickGetHat(Joystick* joystick, int hat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 366, Column 31 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetHat")]
        public partial byte JoystickGetHat(ref Joystick joystick, int hat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetBall")]
        public unsafe partial int JoystickGetBall(Joystick* joystick, int ball, int* dx, int* dy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetBall")]
        public unsafe partial int JoystickGetBall(Joystick* joystick, int ball, int* dx, ref int dy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetBall")]
        public unsafe partial int JoystickGetBall(Joystick* joystick, int ball, ref int dx, int* dy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetBall")]
        public unsafe partial int JoystickGetBall(Joystick* joystick, int ball, ref int dx, ref int dy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetBall")]
        public unsafe partial int JoystickGetBall(ref Joystick joystick, int ball, int* dx, int* dy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetBall")]
        public unsafe partial int JoystickGetBall(ref Joystick joystick, int ball, int* dx, ref int dy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetBall")]
        public unsafe partial int JoystickGetBall(ref Joystick joystick, int ball, ref int dx, int* dy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetBall")]
        public partial int JoystickGetBall(ref Joystick joystick, int ball, ref int dx, ref int dy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 384, Column 31 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetButton")]
        public unsafe partial byte JoystickGetButton(Joystick* joystick, int button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 384, Column 31 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetButton")]
        public partial byte JoystickGetButton(ref Joystick joystick, int button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickRumble")]
        public unsafe partial int JoystickRumble(Joystick* joystick, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickRumble")]
        public partial int JoystickRumble(ref Joystick joystick, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 403, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickClose")]
        public unsafe partial void JoystickClose(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 403, Column 30 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickClose")]
        public partial void JoystickClose(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 408, Column 48 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickCurrentPowerLevel")]
        public unsafe partial JoystickPowerLevel JoystickCurrentPowerLevel(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 408, Column 48 in build/submodules/SDL-mirror/include\\SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickCurrentPowerLevel")]
        public partial JoystickPowerLevel JoystickCurrentPowerLevel(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerAddMappingsFromRW")]
        public unsafe partial int GameControllerAddMappingsFromRW(RWops* rw, int freerw);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerAddMappingsFromRW")]
        public partial int GameControllerAddMappingsFromRW(ref RWops rw, int freerw);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerAddMapping")]
        public unsafe partial int GameControllerAddMapping(byte* mappingString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerAddMapping")]
        public partial int GameControllerAddMapping(ref byte mappingString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerAddMapping")]
        public partial int GameControllerAddMapping(string mappingString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 152, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerNumMappings")]
        public partial int GameControllerNumMappings();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 159, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForIndex")]
        public unsafe partial byte* GameControllerMappingForIndex(int mapping_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 159, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForIndex")]
        public partial string GameControllerMappingForIndexS(int mapping_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 166, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForGUID")]
        public unsafe partial byte* GameControllerMappingForGUID(JoystickGUID guid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 166, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForGUID")]
        public partial string GameControllerMappingForGUIDS(JoystickGUID guid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 173, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMapping")]
        public unsafe partial byte* GameControllerMapping(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 173, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMapping")]
        public unsafe partial string GameControllerMappingS(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 173, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMapping")]
        public unsafe partial byte* GameControllerMapping(ref GameController gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 173, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMapping")]
        public partial string GameControllerMappingS(ref GameController gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 178, Column 34 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_IsGameController")]
        public partial SdlBool IsGameController(int joystick_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 185, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerNameForIndex")]
        public unsafe partial byte* GameControllerNameForIndex(int joystick_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 185, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerNameForIndex")]
        public partial string GameControllerNameForIndexS(int joystick_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 191, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerTypeForIndex")]
        public partial GameControllerType GameControllerTypeForIndex(int joystick_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 31 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForDeviceIndex")]
        public unsafe partial byte* GameControllerMappingForDeviceIndex(int joystick_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 31 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForDeviceIndex")]
        public partial string GameControllerMappingForDeviceIndexS(int joystick_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 45 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerOpen")]
        public unsafe partial GameController* GameControllerOpen(int joystick_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 215, Column 45 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerFromInstanceID")]
        public unsafe partial GameController* GameControllerFromInstanceID(int joyid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 45 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerFromPlayerIndex")]
        public unsafe partial GameController* GameControllerFromPlayerIndex(int player_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerName")]
        public unsafe partial byte* GameControllerName(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerName")]
        public unsafe partial string GameControllerNameS(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerName")]
        public unsafe partial byte* GameControllerName(ref GameController gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerName")]
        public partial string GameControllerNameS(ref GameController gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetType")]
        public unsafe partial GameControllerType GameControllerGetType(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetType")]
        public partial GameControllerType GameControllerGetType(ref GameController gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetPlayerIndex")]
        public unsafe partial int GameControllerGetPlayerIndex(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetPlayerIndex")]
        public partial int GameControllerGetPlayerIndex(ref GameController gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 242, Column 30 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerSetPlayerIndex")]
        public unsafe partial void GameControllerSetPlayerIndex(GameController* gamecontroller, int player_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 242, Column 30 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerSetPlayerIndex")]
        public partial void GameControllerSetPlayerIndex(ref GameController gamecontroller, int player_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 248, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetVendor")]
        public unsafe partial ushort GameControllerGetVendor(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 248, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetVendor")]
        public partial ushort GameControllerGetVendor(ref GameController gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetProduct")]
        public unsafe partial ushort GameControllerGetProduct(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetProduct")]
        public partial ushort GameControllerGetProduct(ref GameController gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetProductVersion")]
        public unsafe partial ushort GameControllerGetProductVersion(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 32 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetProductVersion")]
        public partial ushort GameControllerGetProductVersion(ref GameController gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 266, Column 34 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAttached")]
        public unsafe partial SdlBool GameControllerGetAttached(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 266, Column 34 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAttached")]
        public partial SdlBool GameControllerGetAttached(ref GameController gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 271, Column 39 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetJoystick")]
        public unsafe partial Joystick* GameControllerGetJoystick(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 271, Column 39 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetJoystick")]
        public unsafe partial Joystick* GameControllerGetJoystick(ref GameController gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerEventState")]
        public partial int GameControllerEventState(int state);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 30 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerUpdate")]
        public partial void GameControllerUpdate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAxisFromString")]
        public unsafe partial GameControllerAxis GameControllerGetAxisFromString(byte* pchString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAxisFromString")]
        public partial GameControllerAxis GameControllerGetAxisFromString(ref byte pchString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 48 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAxisFromString")]
        public partial GameControllerAxis GameControllerGetAxisFromString(string pchString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 322, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetStringForAxis")]
        public unsafe partial byte* GameControllerGetStringForAxis(GameControllerAxis axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 322, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetStringForAxis")]
        public partial string GameControllerGetStringForAxisS(GameControllerAxis axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 328, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetBindForAxis")]
        public unsafe partial GameControllerButtonBind GameControllerGetBindForAxis(GameController* gamecontroller, GameControllerAxis axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 328, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetBindForAxis")]
        public partial GameControllerButtonBind GameControllerGetBindForAxis(ref GameController gamecontroller, GameControllerAxis axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAxis")]
        public unsafe partial short GameControllerGetAxis(GameController* gamecontroller, GameControllerAxis axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAxis")]
        public partial short GameControllerGetAxis(ref GameController gamecontroller, GameControllerAxis axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 370, Column 50 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetButtonFromString")]
        public unsafe partial GameControllerButton GameControllerGetButtonFromString(byte* pchString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 370, Column 50 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetButtonFromString")]
        public partial GameControllerButton GameControllerGetButtonFromString(ref byte pchString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 370, Column 50 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetButtonFromString")]
        public partial GameControllerButton GameControllerGetButtonFromString(string pchString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 375, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetStringForButton")]
        public unsafe partial byte* GameControllerGetStringForButton(GameControllerButton button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 375, Column 37 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetStringForButton")]
        public partial string GameControllerGetStringForButtonS(GameControllerButton button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 381, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetBindForButton")]
        public unsafe partial GameControllerButtonBind GameControllerGetBindForButton(GameController* gamecontroller, GameControllerButton button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 381, Column 1 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetBindForButton")]
        public partial GameControllerButtonBind GameControllerGetBindForButton(ref GameController gamecontroller, GameControllerButton button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 390, Column 31 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetButton")]
        public unsafe partial byte GameControllerGetButton(GameController* gamecontroller, GameControllerButton button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 390, Column 31 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetButton")]
        public partial byte GameControllerGetButton(ref GameController gamecontroller, GameControllerButton button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerRumble")]
        public unsafe partial int GameControllerRumble(GameController* gamecontroller, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 29 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerRumble")]
        public partial int GameControllerRumble(ref GameController gamecontroller, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 409, Column 30 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerClose")]
        public unsafe partial void GameControllerClose(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 409, Column 30 in build/submodules/SDL-mirror/include\\SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerClose")]
        public partial void GameControllerClose(ref GameController gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 72, Column 29 in build/submodules/SDL-mirror/include/SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetNumTouchDevices")]
        public partial int GetNumTouchDevices();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 37 in build/submodules/SDL-mirror/include/SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetTouchDevice")]
        public partial long GetTouchDevice(int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 82, Column 45 in build/submodules/SDL-mirror/include/SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetTouchDeviceType")]
        public partial TouchDeviceType GetTouchDeviceType(long touchID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 29 in build/submodules/SDL-mirror/include/SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetNumTouchFingers")]
        public partial int GetNumTouchFingers(long touchID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 38 in build/submodules/SDL-mirror/include/SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetTouchFinger")]
        public unsafe partial Finger* GetTouchFinger(long touchID, int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 53, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_RecordGesture")]
        public partial int RecordGesture(long touchId);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_SaveAllDollarTemplates")]
        public unsafe partial int SaveAllDollarTemplates(RWops* dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_SaveAllDollarTemplates")]
        public partial int SaveAllDollarTemplates(ref RWops dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 68, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_SaveDollarTemplate")]
        public unsafe partial int SaveDollarTemplate(long gestureId, RWops* dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 68, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_SaveDollarTemplate")]
        public partial int SaveDollarTemplate(long gestureId, ref RWops dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_LoadDollarTemplates")]
        public unsafe partial int LoadDollarTemplates(long touchId, RWops* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 29 in build/submodules/SDL-mirror/include/SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_LoadDollarTemplates")]
        public partial int LoadDollarTemplates(long touchId, ref RWops src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PumpEvents")]
        public partial void PumpEvents();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PeepEvents")]
        public unsafe partial int PeepEvents(Event* events, int numevents, Eventaction action, uint minType, uint maxType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PeepEvents")]
        public partial int PeepEvents(ref Event events, int numevents, Eventaction action, uint minType, uint maxType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 647, Column 34 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_HasEvent")]
        public partial SdlBool HasEvent(uint type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 648, Column 34 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_HasEvents")]
        public partial SdlBool HasEvents(uint minType, uint maxType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 656, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_FlushEvent")]
        public partial void FlushEvent(uint type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_FlushEvents")]
        public partial void FlushEvents(uint minType, uint maxType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PollEvent")]
        public unsafe partial int PollEvent(Event* @event);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PollEvent")]
        public partial int PollEvent(ref Event @event);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 677, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_WaitEvent")]
        public unsafe partial int WaitEvent(Event* @event);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 677, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_WaitEvent")]
        public partial int WaitEvent(ref Event @event);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 689, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_WaitEventTimeout")]
        public unsafe partial int WaitEventTimeout(Event* @event, int timeout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 689, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_WaitEventTimeout")]
        public partial int WaitEventTimeout(ref Event @event, int timeout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PushEvent")]
        public unsafe partial int PushEvent(Event* @event);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PushEvent")]
        public partial int PushEvent(ref Event @event);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_SetEventFilter")]
        public unsafe partial void SetEventFilter(PfnEventFilter filter, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_SetEventFilter")]
        public partial void SetEventFilter<T0>(PfnEventFilter filter, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 734, Column 34 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_GetEventFilter")]
        public unsafe partial SdlBool GetEventFilter(PfnEventFilter* filter, void** userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 734, Column 34 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_GetEventFilter")]
        public unsafe partial SdlBool GetEventFilter(PfnEventFilter* filter, ref void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 734, Column 34 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_GetEventFilter")]
        public unsafe partial SdlBool GetEventFilter(ref PfnEventFilter filter, void** userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 734, Column 34 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_GetEventFilter")]
        public unsafe partial SdlBool GetEventFilter(ref PfnEventFilter filter, ref void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 740, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_AddEventWatch")]
        public unsafe partial void AddEventWatch(PfnEventFilter filter, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 740, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_AddEventWatch")]
        public partial void AddEventWatch<T0>(PfnEventFilter filter, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 746, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_DelEventWatch")]
        public unsafe partial void DelEventWatch(PfnEventFilter filter, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 746, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_DelEventWatch")]
        public partial void DelEventWatch<T0>(PfnEventFilter filter, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_FilterEvents")]
        public unsafe partial void FilterEvents(PfnEventFilter filter, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 30 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_FilterEvents")]
        public partial void FilterEvents<T0>(PfnEventFilter filter, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 771, Column 31 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_EventState")]
        public partial byte EventState(uint type, int state);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 782, Column 32 in build/submodules/SDL-mirror/include\\SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_RegisterEvents")]
        public partial uint RegisterEvents(int numevents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetBasePath")]
        public unsafe partial byte* GetBasePath();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetBasePath")]
        public partial string GetBasePathS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial byte* GetPrefPath(byte* org, byte* app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial string GetPrefPathS(byte* org, byte* app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial byte* GetPrefPath(byte* org, ref byte app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial string GetPrefPathS(byte* org, ref byte app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial byte* GetPrefPath(byte* org, string app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial string GetPrefPathS(byte* org, string app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial byte* GetPrefPath(ref byte org, byte* app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial string GetPrefPathS(ref byte org, byte* app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial byte* GetPrefPath(ref byte org, ref byte app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public partial string GetPrefPathS(ref byte org, ref byte app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial byte* GetPrefPath(ref byte org, string app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public partial string GetPrefPathS(ref byte org, string app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial byte* GetPrefPath(string org, byte* app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial string GetPrefPathS(string org, byte* app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial byte* GetPrefPath(string org, ref byte app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public partial string GetPrefPathS(string org, ref byte app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial byte* GetPrefPath(string org, string app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 31 in build/submodules/SDL-mirror/include\\SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public partial string GetPrefPathS(string org, string app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 819, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_NumHaptics")]
        public partial int NumHaptics();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 832, Column 37 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticName")]
        public unsafe partial byte* HapticName(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 832, Column 37 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticName")]
        public partial string HapticNameS(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 37 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpen")]
        public unsafe partial Haptic* HapticOpen(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 867, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpened")]
        public partial int HapticOpened(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 878, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticIndex")]
        public unsafe partial int HapticIndex(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 878, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticIndex")]
        public partial int HapticIndex(ref Haptic haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 887, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_MouseIsHaptic")]
        public partial int MouseIsHaptic();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 897, Column 37 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpenFromMouse")]
        public unsafe partial Haptic* HapticOpenFromMouse();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_JoystickIsHaptic")]
        public unsafe partial int JoystickIsHaptic(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_JoystickIsHaptic")]
        public partial int JoystickIsHaptic(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 927, Column 37 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpenFromJoystick")]
        public unsafe partial Haptic* HapticOpenFromJoystick(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 927, Column 37 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpenFromJoystick")]
        public unsafe partial Haptic* HapticOpenFromJoystick(ref Joystick joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 935, Column 30 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticClose")]
        public unsafe partial void HapticClose(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 935, Column 30 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticClose")]
        public partial void HapticClose(ref Haptic haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumEffects")]
        public unsafe partial int HapticNumEffects(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumEffects")]
        public partial int HapticNumEffects(ref Haptic haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 967, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumEffectsPlaying")]
        public unsafe partial int HapticNumEffectsPlaying(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 967, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumEffectsPlaying")]
        public partial int HapticNumEffectsPlaying(ref Haptic haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 985, Column 38 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticQuery")]
        public unsafe partial uint HapticQuery(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 985, Column 38 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticQuery")]
        public partial uint HapticQuery(ref Haptic haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 993, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumAxes")]
        public unsafe partial int HapticNumAxes(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 993, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumAxes")]
        public partial int HapticNumAxes(ref Haptic haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticEffectSupported")]
        public unsafe partial int HapticEffectSupported(Haptic* haptic, HapticEffect* effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticEffectSupported")]
        public unsafe partial int HapticEffectSupported(Haptic* haptic, ref HapticEffect effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticEffectSupported")]
        public unsafe partial int HapticEffectSupported(ref Haptic haptic, HapticEffect* effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticEffectSupported")]
        public partial int HapticEffectSupported(ref Haptic haptic, ref HapticEffect effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNewEffect")]
        public unsafe partial int HapticNewEffect(Haptic* haptic, HapticEffect* effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNewEffect")]
        public unsafe partial int HapticNewEffect(Haptic* haptic, ref HapticEffect effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNewEffect")]
        public unsafe partial int HapticNewEffect(ref Haptic haptic, HapticEffect* effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNewEffect")]
        public partial int HapticNewEffect(ref Haptic haptic, ref HapticEffect effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticUpdateEffect")]
        public unsafe partial int HapticUpdateEffect(Haptic* haptic, int effect, HapticEffect* data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticUpdateEffect")]
        public unsafe partial int HapticUpdateEffect(Haptic* haptic, int effect, ref HapticEffect data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticUpdateEffect")]
        public unsafe partial int HapticUpdateEffect(ref Haptic haptic, int effect, HapticEffect* data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticUpdateEffect")]
        public partial int HapticUpdateEffect(ref Haptic haptic, int effect, ref HapticEffect data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1062, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRunEffect")]
        public unsafe partial int HapticRunEffect(Haptic* haptic, int effect, uint iterations);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1062, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRunEffect")]
        public partial int HapticRunEffect(ref Haptic haptic, int effect, uint iterations);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1076, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticStopEffect")]
        public unsafe partial int HapticStopEffect(Haptic* haptic, int effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1076, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticStopEffect")]
        public partial int HapticStopEffect(ref Haptic haptic, int effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1090, Column 30 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticDestroyEffect")]
        public unsafe partial void HapticDestroyEffect(Haptic* haptic, int effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1090, Column 30 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticDestroyEffect")]
        public partial void HapticDestroyEffect(ref Haptic haptic, int effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticGetEffectStatus")]
        public unsafe partial int HapticGetEffectStatus(Haptic* haptic, int effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticGetEffectStatus")]
        public partial int HapticGetEffectStatus(ref Haptic haptic, int effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1124, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticSetGain")]
        public unsafe partial int HapticSetGain(Haptic* haptic, int gain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1124, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticSetGain")]
        public partial int HapticSetGain(ref Haptic haptic, int gain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1140, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticSetAutocenter")]
        public unsafe partial int HapticSetAutocenter(Haptic* haptic, int autocenter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1140, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticSetAutocenter")]
        public partial int HapticSetAutocenter(ref Haptic haptic, int autocenter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1157, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticPause")]
        public unsafe partial int HapticPause(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1157, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticPause")]
        public partial int HapticPause(ref Haptic haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1169, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticUnpause")]
        public unsafe partial int HapticUnpause(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1169, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticUnpause")]
        public partial int HapticUnpause(ref Haptic haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticStopAll")]
        public unsafe partial int HapticStopAll(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticStopAll")]
        public partial int HapticStopAll(ref Haptic haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1189, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleSupported")]
        public unsafe partial int HapticRumbleSupported(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1189, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleSupported")]
        public partial int HapticRumbleSupported(ref Haptic haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1202, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleInit")]
        public unsafe partial int HapticRumbleInit(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1202, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleInit")]
        public partial int HapticRumbleInit(ref Haptic haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1216, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumblePlay")]
        public unsafe partial int HapticRumblePlay(Haptic* haptic, float strength, uint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1216, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumblePlay")]
        public partial int HapticRumblePlay(ref Haptic haptic, float strength, uint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1228, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleStop")]
        public unsafe partial int HapticRumbleStop(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1228, Column 29 in build/submodules/SDL-mirror/include\\SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleStop")]
        public partial int HapticRumbleStop(ref Haptic haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHintWithPriority")]
        public unsafe partial SdlBool SetHintWithPriority(byte* name, byte* value, HintPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHintWithPriority")]
        public unsafe partial SdlBool SetHintWithPriority(byte* name, ref byte value, HintPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHintWithPriority")]
        public unsafe partial SdlBool SetHintWithPriority(byte* name, string value, HintPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHintWithPriority")]
        public unsafe partial SdlBool SetHintWithPriority(ref byte name, byte* value, HintPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHintWithPriority")]
        public partial SdlBool SetHintWithPriority(ref byte name, ref byte value, HintPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHintWithPriority")]
        public partial SdlBool SetHintWithPriority(ref byte name, string value, HintPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHintWithPriority")]
        public unsafe partial SdlBool SetHintWithPriority(string name, byte* value, HintPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHintWithPriority")]
        public partial SdlBool SetHintWithPriority(string name, ref byte value, HintPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1295, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHintWithPriority")]
        public partial SdlBool SetHintWithPriority(string name, string value, HintPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHint")]
        public unsafe partial SdlBool SetHint(byte* name, byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHint")]
        public unsafe partial SdlBool SetHint(byte* name, ref byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHint")]
        public unsafe partial SdlBool SetHint(byte* name, string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHint")]
        public unsafe partial SdlBool SetHint(ref byte name, byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHint")]
        public partial SdlBool SetHint(ref byte name, ref byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHint")]
        public partial SdlBool SetHint(ref byte name, string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHint")]
        public unsafe partial SdlBool SetHint(string name, byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHint")]
        public partial SdlBool SetHint(string name, ref byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHint")]
        public partial SdlBool SetHint(string name, string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1312, Column 38 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHint")]
        public unsafe partial byte* GetHint(byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1312, Column 38 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHint")]
        public unsafe partial string GetHintS(byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1312, Column 38 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHint")]
        public unsafe partial byte* GetHint(ref byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1312, Column 38 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHint")]
        public partial string GetHintS(ref byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1312, Column 38 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHint")]
        public unsafe partial byte* GetHint(string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1312, Column 38 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHint")]
        public partial string GetHintS(string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1319, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHintBoolean")]
        public unsafe partial SdlBool GetHintBoolean(byte* name, SdlBool default_value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1319, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHintBoolean")]
        public partial SdlBool GetHintBoolean(ref byte name, SdlBool default_value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1319, Column 34 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHintBoolean")]
        public partial SdlBool GetHintBoolean(string name, SdlBool default_value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_AddHintCallback")]
        public unsafe partial void AddHintCallback(byte* name, PfnHintCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_AddHintCallback")]
        public unsafe partial void AddHintCallback<T0>(byte* name, PfnHintCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_AddHintCallback")]
        public unsafe partial void AddHintCallback(ref byte name, PfnHintCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_AddHintCallback")]
        public partial void AddHintCallback<T0>(ref byte name, PfnHintCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_AddHintCallback")]
        public unsafe partial void AddHintCallback(string name, PfnHintCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1333, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_AddHintCallback")]
        public partial void AddHintCallback<T0>(string name, PfnHintCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_DelHintCallback")]
        public unsafe partial void DelHintCallback(byte* name, PfnHintCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_DelHintCallback")]
        public unsafe partial void DelHintCallback<T0>(byte* name, PfnHintCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_DelHintCallback")]
        public unsafe partial void DelHintCallback(ref byte name, PfnHintCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_DelHintCallback")]
        public partial void DelHintCallback<T0>(ref byte name, PfnHintCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_DelHintCallback")]
        public unsafe partial void DelHintCallback(string name, PfnHintCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1344, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_DelHintCallback")]
        public partial void DelHintCallback<T0>(string name, PfnHintCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1353, Column 30 in build/submodules/SDL-mirror/include\\SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_ClearHints")]
        public partial void ClearHints();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 58, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadObject")]
        public unsafe partial void* LoadObject(byte* sofile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 58, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadObject")]
        public unsafe partial void* LoadObject(ref byte sofile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 58, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadObject")]
        public unsafe partial void* LoadObject(string sofile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadFunction")]
        public unsafe partial void* LoadFunction(void* handle, byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadFunction")]
        public unsafe partial void* LoadFunction(void* handle, ref byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadFunction")]
        public unsafe partial void* LoadFunction(void* handle, string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadFunction")]
        public unsafe partial void* LoadFunction<T0>(ref T0 handle, byte* name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadFunction")]
        public unsafe partial void* LoadFunction<T0>(ref T0 handle, ref byte name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 31 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadFunction")]
        public unsafe partial void* LoadFunction<T0>(ref T0 handle, string name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 30 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_UnloadObject")]
        public unsafe partial void UnloadObject(void* handle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 30 in build/submodules/SDL-mirror/include\\SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_UnloadObject")]
        public partial void UnloadObject<T0>(ref T0 handle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogSetAllPriority")]
        public partial void LogSetAllPriority(LogPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 122, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogSetPriority")]
        public partial void LogSetPriority(int category, LogPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 41 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogGetPriority")]
        public partial LogPriority LogGetPriority(int category);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogResetPriorities")]
        public partial void LogResetPriorities();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 140, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_Log")]
        public unsafe partial void Log(byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 140, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_Log")]
        public partial void Log(ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 140, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_Log")]
        public partial void Log(string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogVerbose")]
        public unsafe partial void LogVerbose(int category, byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogVerbose")]
        public partial void LogVerbose(int category, ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogVerbose")]
        public partial void LogVerbose(int category, string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 150, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogDebug")]
        public unsafe partial void LogDebug(int category, byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 150, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogDebug")]
        public partial void LogDebug(int category, ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 150, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogDebug")]
        public partial void LogDebug(int category, string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 155, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogInfo")]
        public unsafe partial void LogInfo(int category, byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 155, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogInfo")]
        public partial void LogInfo(int category, ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 155, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogInfo")]
        public partial void LogInfo(int category, string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogWarn")]
        public unsafe partial void LogWarn(int category, byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogWarn")]
        public partial void LogWarn(int category, ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogWarn")]
        public partial void LogWarn(int category, string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogError")]
        public unsafe partial void LogError(int category, byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogError")]
        public partial void LogError(int category, ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogError")]
        public partial void LogError(int category, string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogCritical")]
        public unsafe partial void LogCritical(int category, byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogCritical")]
        public partial void LogCritical(int category, ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogCritical")]
        public partial void LogCritical(int category, string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 175, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessage")]
        public unsafe partial void LogMessage(int category, LogPriority priority, byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 175, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessage")]
        public partial void LogMessage(int category, LogPriority priority, ref byte fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 175, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessage")]
        public partial void LogMessage(int category, LogPriority priority, string fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessageV")]
        public unsafe partial void LogMessageV(int category, LogPriority priority, byte* fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessageV")]
        public unsafe partial void LogMessageV(int category, LogPriority priority, byte* fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessageV")]
        public unsafe partial void LogMessageV(int category, LogPriority priority, byte* fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessageV")]
        public unsafe partial void LogMessageV(int category, LogPriority priority, ref byte fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessageV")]
        public partial void LogMessageV(int category, LogPriority priority, ref byte fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessageV")]
        public partial void LogMessageV(int category, LogPriority priority, ref byte fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessageV")]
        public unsafe partial void LogMessageV(int category, LogPriority priority, string fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessageV")]
        public partial void LogMessageV(int category, LogPriority priority, string fmt, ref byte ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessageV")]
        public partial void LogMessageV(int category, LogPriority priority, string fmt, string ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogGetOutputFunction")]
        public unsafe partial void LogGetOutputFunction(PfnLogOutputFunction* callback, void** userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogGetOutputFunction")]
        public unsafe partial void LogGetOutputFunction(PfnLogOutputFunction* callback, ref void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogGetOutputFunction")]
        public unsafe partial void LogGetOutputFunction(ref PfnLogOutputFunction callback, void** userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogGetOutputFunction")]
        public unsafe partial void LogGetOutputFunction(ref PfnLogOutputFunction callback, ref void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogSetOutputFunction")]
        public unsafe partial void LogSetOutputFunction(PfnLogOutputFunction callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 30 in build/submodules/SDL-mirror/include\\SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogSetOutputFunction")]
        public partial void LogSetOutputFunction<T0>(PfnLogOutputFunction callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowMessageBox")]
        public unsafe partial int ShowMessageBox(MessageBoxData* messageboxdata, int* buttonid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowMessageBox")]
        public unsafe partial int ShowMessageBox(MessageBoxData* messageboxdata, ref int buttonid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowMessageBox")]
        public unsafe partial int ShowMessageBox(ref MessageBoxData messageboxdata, int* buttonid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowMessageBox")]
        public partial int ShowMessageBox(ref MessageBoxData messageboxdata, ref int buttonid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, byte* title, byte* message, Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, byte* title, byte* message, ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, byte* title, ref byte message, Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, byte* title, ref byte message, ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, byte* title, string message, Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, byte* title, string message, ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, ref byte title, byte* message, Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, ref byte title, byte* message, ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, ref byte title, ref byte message, Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public partial int ShowSimpleMessageBox(uint flags, ref byte title, ref byte message, ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, ref byte title, string message, Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public partial int ShowSimpleMessageBox(uint flags, ref byte title, string message, ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, string title, byte* message, Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, string title, byte* message, ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, string title, ref byte message, Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public partial int ShowSimpleMessageBox(uint flags, string title, ref byte message, ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, string title, string message, Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 29 in build/submodules/SDL-mirror/include\\SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public partial int ShowSimpleMessageBox(uint flags, string title, string message, ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 39 in build/submodules/SDL-mirror/include\\SDL_metal.h")]
        [NativeApi(EntryPoint = "SDL_Metal_CreateView")]
        public unsafe partial void* MetalCreateView(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 39 in build/submodules/SDL-mirror/include\\SDL_metal.h")]
        [NativeApi(EntryPoint = "SDL_Metal_CreateView")]
        public unsafe partial void* MetalCreateView(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 81, Column 30 in build/submodules/SDL-mirror/include\\SDL_metal.h")]
        [NativeApi(EntryPoint = "SDL_Metal_DestroyView")]
        public unsafe partial void MetalDestroyView(void* view);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 81, Column 30 in build/submodules/SDL-mirror/include\\SDL_metal.h")]
        [NativeApi(EntryPoint = "SDL_Metal_DestroyView")]
        public partial void MetalDestroyView<T0>(ref T0 view) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 40 in build/submodules/SDL-mirror/include\\SDL_power.h")]
        [NativeApi(EntryPoint = "SDL_GetPowerInfo")]
        public unsafe partial PowerState GetPowerInfo(int* secs, int* pct);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 40 in build/submodules/SDL-mirror/include\\SDL_power.h")]
        [NativeApi(EntryPoint = "SDL_GetPowerInfo")]
        public unsafe partial PowerState GetPowerInfo(int* secs, ref int pct);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 40 in build/submodules/SDL-mirror/include\\SDL_power.h")]
        [NativeApi(EntryPoint = "SDL_GetPowerInfo")]
        public unsafe partial PowerState GetPowerInfo(ref int secs, int* pct);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 40 in build/submodules/SDL-mirror/include\\SDL_power.h")]
        [NativeApi(EntryPoint = "SDL_GetPowerInfo")]
        public partial PowerState GetPowerInfo(ref int secs, ref int pct);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 154, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetNumRenderDrivers")]
        public partial int GetNumRenderDrivers();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDriverInfo")]
        public unsafe partial int GetRenderDriverInfo(int index, RendererInfo* info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDriverInfo")]
        public partial int GetRenderDriverInfo(int index, ref RendererInfo info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindowAndRenderer")]
        public unsafe partial int CreateWindowAndRenderer(int width, int height, uint window_flags, Window** window, Renderer** renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindowAndRenderer")]
        public unsafe partial int CreateWindowAndRenderer(int width, int height, uint window_flags, Window** window, ref Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindowAndRenderer")]
        public unsafe partial int CreateWindowAndRenderer(int width, int height, uint window_flags, ref Window* window, Renderer** renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindowAndRenderer")]
        public unsafe partial int CreateWindowAndRenderer(int width, int height, uint window_flags, ref Window* window, ref Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 201, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateRenderer")]
        public unsafe partial Renderer* CreateRenderer(Window* window, int index, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 201, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateRenderer")]
        public unsafe partial Renderer* CreateRenderer(ref Window window, int index, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 214, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateSoftwareRenderer")]
        public unsafe partial Renderer* CreateSoftwareRenderer(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 214, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateSoftwareRenderer")]
        public unsafe partial Renderer* CreateSoftwareRenderer(ref Surface surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 219, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderer")]
        public unsafe partial Renderer* GetRenderer(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 219, Column 40 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderer")]
        public unsafe partial Renderer* GetRenderer(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererInfo")]
        public unsafe partial int GetRendererInfo(Renderer* renderer, RendererInfo* info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererInfo")]
        public unsafe partial int GetRendererInfo(Renderer* renderer, ref RendererInfo info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererInfo")]
        public unsafe partial int GetRendererInfo(ref Renderer renderer, RendererInfo* info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererInfo")]
        public partial int GetRendererInfo(ref Renderer renderer, ref RendererInfo info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererOutputSize")]
        public unsafe partial int GetRendererOutputSize(Renderer* renderer, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererOutputSize")]
        public unsafe partial int GetRendererOutputSize(Renderer* renderer, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererOutputSize")]
        public unsafe partial int GetRendererOutputSize(Renderer* renderer, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererOutputSize")]
        public unsafe partial int GetRendererOutputSize(Renderer* renderer, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererOutputSize")]
        public unsafe partial int GetRendererOutputSize(ref Renderer renderer, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererOutputSize")]
        public unsafe partial int GetRendererOutputSize(ref Renderer renderer, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererOutputSize")]
        public unsafe partial int GetRendererOutputSize(ref Renderer renderer, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererOutputSize")]
        public partial int GetRendererOutputSize(ref Renderer renderer, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 252, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateTexture")]
        public unsafe partial Texture* CreateTexture(Renderer* renderer, uint format, int access, int w, int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 252, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateTexture")]
        public unsafe partial Texture* CreateTexture(ref Renderer renderer, uint format, int access, int w, int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateTextureFromSurface")]
        public unsafe partial Texture* CreateTextureFromSurface(Renderer* renderer, Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateTextureFromSurface")]
        public unsafe partial Texture* CreateTextureFromSurface(Renderer* renderer, ref Surface surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateTextureFromSurface")]
        public unsafe partial Texture* CreateTextureFromSurface(ref Renderer renderer, Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateTextureFromSurface")]
        public unsafe partial Texture* CreateTextureFromSurface(ref Renderer renderer, ref Surface surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, uint* format, int* access, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, uint* format, int* access, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, uint* format, int* access, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, uint* format, int* access, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, uint* format, ref int access, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, uint* format, ref int access, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, uint* format, ref int access, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, uint* format, ref int access, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, ref uint format, int* access, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, ref uint format, int* access, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, ref uint format, int* access, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, ref uint format, int* access, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, ref uint format, ref int access, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, ref uint format, ref int access, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, ref uint format, ref int access, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, ref uint format, ref int access, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, uint* format, int* access, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, uint* format, int* access, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, uint* format, int* access, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, uint* format, int* access, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, uint* format, ref int access, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, uint* format, ref int access, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, uint* format, ref int access, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, uint* format, ref int access, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, ref uint format, int* access, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, ref uint format, int* access, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, ref uint format, int* access, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, ref uint format, int* access, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, ref uint format, ref int access, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, ref uint format, ref int access, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(ref Texture texture, ref uint format, ref int access, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public partial int QueryTexture(ref Texture texture, ref uint format, ref int access, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 302, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureColorMod")]
        public unsafe partial int SetTextureColorMod(Texture* texture, byte r, byte g, byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 302, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureColorMod")]
        public partial int SetTextureColorMod(ref Texture texture, byte r, byte g, byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, byte* r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, byte* r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, byte* r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, byte* r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, byte* r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, byte* r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, byte* r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, byte* r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, byte* r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, ref byte r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, ref byte r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, ref byte r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, ref byte r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, ref byte r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, ref byte r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, ref byte r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, ref byte r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, ref byte r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, string r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, string r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, string r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, string r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, string r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, string r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, string r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, string r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, string r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, byte* r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, byte* r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, byte* r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, byte* r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, byte* r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, byte* r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, byte* r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, byte* r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, byte* r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, ref byte r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, ref byte r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, ref byte r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, ref byte r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public partial int GetTextureColorMod(ref Texture texture, ref byte r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public partial int GetTextureColorMod(ref Texture texture, ref byte r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, ref byte r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public partial int GetTextureColorMod(ref Texture texture, ref byte r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public partial int GetTextureColorMod(ref Texture texture, ref byte r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, string r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, string r, byte* g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, string r, byte* g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, string r, ref byte g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public partial int GetTextureColorMod(ref Texture texture, string r, ref byte g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public partial int GetTextureColorMod(ref Texture texture, string r, ref byte g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(ref Texture texture, string r, string g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public partial int GetTextureColorMod(ref Texture texture, string r, string g, ref byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public partial int GetTextureColorMod(ref Texture texture, string r, string g, string b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 333, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureAlphaMod")]
        public unsafe partial int SetTextureAlphaMod(Texture* texture, byte alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 333, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureAlphaMod")]
        public partial int SetTextureAlphaMod(ref Texture texture, byte alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureAlphaMod")]
        public unsafe partial int GetTextureAlphaMod(Texture* texture, byte* alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureAlphaMod")]
        public unsafe partial int GetTextureAlphaMod(Texture* texture, ref byte alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureAlphaMod")]
        public unsafe partial int GetTextureAlphaMod(Texture* texture, string alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureAlphaMod")]
        public unsafe partial int GetTextureAlphaMod(ref Texture texture, byte* alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureAlphaMod")]
        public partial int GetTextureAlphaMod(ref Texture texture, ref byte alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 346, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureAlphaMod")]
        public partial int GetTextureAlphaMod(ref Texture texture, string alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureBlendMode")]
        public unsafe partial int SetTextureBlendMode(Texture* texture, BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureBlendMode")]
        public partial int SetTextureBlendMode(ref Texture texture, BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureBlendMode")]
        public unsafe partial int GetTextureBlendMode(Texture* texture, BlendMode* blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureBlendMode")]
        public unsafe partial int GetTextureBlendMode(Texture* texture, ref BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureBlendMode")]
        public unsafe partial int GetTextureBlendMode(ref Texture texture, BlendMode* blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureBlendMode")]
        public partial int GetTextureBlendMode(ref Texture texture, ref BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 392, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureScaleMode")]
        public unsafe partial int SetTextureScaleMode(Texture* texture, ScaleMode scaleMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 392, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureScaleMode")]
        public partial int SetTextureScaleMode(ref Texture texture, ScaleMode scaleMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureScaleMode")]
        public unsafe partial int GetTextureScaleMode(Texture* texture, ScaleMode* scaleMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureScaleMode")]
        public unsafe partial int GetTextureScaleMode(Texture* texture, ref ScaleMode scaleMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureScaleMode")]
        public unsafe partial int GetTextureScaleMode(ref Texture texture, ScaleMode* scaleMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 405, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureScaleMode")]
        public partial int GetTextureScaleMode(ref Texture texture, ref ScaleMode scaleMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateTexture")]
        public unsafe partial int UpdateTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, void* pixels, int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateTexture")]
        public unsafe partial int UpdateTexture<T0>(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref T0 pixels, int pitch) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateTexture")]
        public unsafe partial int UpdateTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, void* pixels, int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateTexture")]
        public unsafe partial int UpdateTexture<T0>(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, ref T0 pixels, int pitch) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateTexture")]
        public unsafe partial int UpdateTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, void* pixels, int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateTexture")]
        public unsafe partial int UpdateTexture<T0>(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, ref T0 pixels, int pitch) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateTexture")]
        public unsafe partial int UpdateTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, void* pixels, int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateTexture")]
        public partial int UpdateTexture<T0>(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, ref T0 pixels, int pitch) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, ref byte Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, ref byte Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, ref byte Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, byte* Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, ref byte Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, ref byte Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, ref byte Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, string Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, ref byte Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, ref byte Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, ref byte Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, string Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, ref byte Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, ref byte Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, ref byte Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, byte* Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, ref byte Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, ref byte Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, ref byte Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, string Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, ref byte Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, ref byte Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, ref byte Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, string Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, ref byte Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, ref byte Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, ref byte Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, byte* Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, ref byte Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, ref byte Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, ref byte Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, string Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, ref byte Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, ref byte Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, ref byte Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, ref byte Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, string Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, string Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, ref byte Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, ref byte Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, ref byte Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, byte* Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, byte* Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, ref byte Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, ref byte Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, ref byte Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, string Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, ref byte Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, byte* Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, ref byte Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, ref byte Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, ref byte Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, string Uplane, int Upitch, byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, string Uplane, int Upitch, ref byte Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public partial int UpdateYUVTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, string Yplane, int Ypitch, string Uplane, int Upitch, string Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, void** pixels, int* pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, void** pixels, ref int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref void* pixels, int* pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref void* pixels, ref int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, void** pixels, int* pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, void** pixels, ref int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, ref void* pixels, int* pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, ref void* pixels, ref int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, void** pixels, int* pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, void** pixels, ref int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, ref void* pixels, int* pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, ref void* pixels, ref int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, void** pixels, int* pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, void** pixels, ref int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, ref void* pixels, int* pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, ref void* pixels, ref int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTextureToSurface")]
        public unsafe partial int LockTextureToSurface(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, Surface** surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTextureToSurface")]
        public unsafe partial int LockTextureToSurface(Texture* texture, Silk.NET.Maths.Rectangle<int>* rect, ref Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTextureToSurface")]
        public unsafe partial int LockTextureToSurface(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, Surface** surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTextureToSurface")]
        public unsafe partial int LockTextureToSurface(Texture* texture, ref Silk.NET.Maths.Rectangle<int> rect, ref Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTextureToSurface")]
        public unsafe partial int LockTextureToSurface(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, Surface** surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTextureToSurface")]
        public unsafe partial int LockTextureToSurface(ref Texture texture, Silk.NET.Maths.Rectangle<int>* rect, ref Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTextureToSurface")]
        public unsafe partial int LockTextureToSurface(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, Surface** surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTextureToSurface")]
        public unsafe partial int LockTextureToSurface(ref Texture texture, ref Silk.NET.Maths.Rectangle<int> rect, ref Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UnlockTexture")]
        public unsafe partial void UnlockTexture(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UnlockTexture")]
        public partial void UnlockTexture(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 507, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderTargetSupported")]
        public unsafe partial SdlBool RenderTargetSupported(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 507, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderTargetSupported")]
        public partial SdlBool RenderTargetSupported(ref Renderer renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderTarget")]
        public unsafe partial int SetRenderTarget(Renderer* renderer, Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderTarget")]
        public unsafe partial int SetRenderTarget(Renderer* renderer, ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderTarget")]
        public unsafe partial int SetRenderTarget(ref Renderer renderer, Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderTarget")]
        public partial int SetRenderTarget(ref Renderer renderer, ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 529, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderTarget")]
        public unsafe partial Texture* GetRenderTarget(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 529, Column 39 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderTarget")]
        public unsafe partial Texture* GetRenderTarget(ref Renderer renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 554, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetLogicalSize")]
        public unsafe partial int RenderSetLogicalSize(Renderer* renderer, int w, int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 554, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetLogicalSize")]
        public partial int RenderSetLogicalSize(ref Renderer renderer, int w, int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetLogicalSize")]
        public unsafe partial void RenderGetLogicalSize(Renderer* renderer, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetLogicalSize")]
        public unsafe partial void RenderGetLogicalSize(Renderer* renderer, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetLogicalSize")]
        public unsafe partial void RenderGetLogicalSize(Renderer* renderer, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetLogicalSize")]
        public unsafe partial void RenderGetLogicalSize(Renderer* renderer, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetLogicalSize")]
        public unsafe partial void RenderGetLogicalSize(ref Renderer renderer, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetLogicalSize")]
        public unsafe partial void RenderGetLogicalSize(ref Renderer renderer, int* w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetLogicalSize")]
        public unsafe partial void RenderGetLogicalSize(ref Renderer renderer, ref int w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetLogicalSize")]
        public partial void RenderGetLogicalSize(ref Renderer renderer, ref int w, ref int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 579, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetIntegerScale")]
        public unsafe partial int RenderSetIntegerScale(Renderer* renderer, SdlBool enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 579, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetIntegerScale")]
        public partial int RenderSetIntegerScale(ref Renderer renderer, SdlBool enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 589, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetIntegerScale")]
        public unsafe partial SdlBool RenderGetIntegerScale(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 589, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetIntegerScale")]
        public partial SdlBool RenderGetIntegerScale(ref Renderer renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetViewport")]
        public unsafe partial int RenderSetViewport(Renderer* renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetViewport")]
        public unsafe partial int RenderSetViewport(Renderer* renderer, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetViewport")]
        public unsafe partial int RenderSetViewport(ref Renderer renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetViewport")]
        public partial int RenderSetViewport(ref Renderer renderer, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetViewport")]
        public unsafe partial void RenderGetViewport(Renderer* renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetViewport")]
        public unsafe partial void RenderGetViewport(Renderer* renderer, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetViewport")]
        public unsafe partial void RenderGetViewport(ref Renderer renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetViewport")]
        public partial void RenderGetViewport(ref Renderer renderer, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetClipRect")]
        public unsafe partial int RenderSetClipRect(Renderer* renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetClipRect")]
        public unsafe partial int RenderSetClipRect(Renderer* renderer, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetClipRect")]
        public unsafe partial int RenderSetClipRect(ref Renderer renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetClipRect")]
        public partial int RenderSetClipRect(ref Renderer renderer, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 640, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetClipRect")]
        public unsafe partial void RenderGetClipRect(Renderer* renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 640, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetClipRect")]
        public unsafe partial void RenderGetClipRect(Renderer* renderer, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 640, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetClipRect")]
        public unsafe partial void RenderGetClipRect(ref Renderer renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 640, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetClipRect")]
        public partial void RenderGetClipRect(ref Renderer renderer, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 650, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderIsClipEnabled")]
        public unsafe partial SdlBool RenderIsClipEnabled(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 650, Column 34 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderIsClipEnabled")]
        public partial SdlBool RenderIsClipEnabled(ref Renderer renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 671, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetScale")]
        public unsafe partial int RenderSetScale(Renderer* renderer, float scaleX, float scaleY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 671, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetScale")]
        public partial int RenderSetScale(ref Renderer renderer, float scaleX, float scaleY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetScale")]
        public unsafe partial void RenderGetScale(Renderer* renderer, float* scaleX, float* scaleY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetScale")]
        public unsafe partial void RenderGetScale(Renderer* renderer, float* scaleX, ref float scaleY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetScale")]
        public unsafe partial void RenderGetScale(Renderer* renderer, ref float scaleX, float* scaleY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetScale")]
        public unsafe partial void RenderGetScale(Renderer* renderer, ref float scaleX, ref float scaleY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetScale")]
        public unsafe partial void RenderGetScale(ref Renderer renderer, float* scaleX, float* scaleY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetScale")]
        public unsafe partial void RenderGetScale(ref Renderer renderer, float* scaleX, ref float scaleY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetScale")]
        public unsafe partial void RenderGetScale(ref Renderer renderer, ref float scaleX, float* scaleY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetScale")]
        public partial void RenderGetScale(ref Renderer renderer, ref float scaleX, ref float scaleY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderDrawColor")]
        public unsafe partial int SetRenderDrawColor(Renderer* renderer, byte r, byte g, byte b, byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderDrawColor")]
        public partial int SetRenderDrawColor(ref Renderer renderer, byte r, byte g, byte b, byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, byte* g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, byte* g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, byte* g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, byte* g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, byte* g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, byte* g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, byte* g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, byte* g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, ref byte g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, ref byte g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, ref byte g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, ref byte g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, ref byte g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, ref byte g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, ref byte g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, ref byte g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, ref byte g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, string g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, string g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, string g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, string g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, string g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, string g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, string g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, string g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, string g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, byte* g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, byte* g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, byte* g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, byte* g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, byte* g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, byte* g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, byte* g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, byte* g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, ref byte g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, ref byte g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, ref byte g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, ref byte g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, ref byte g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, ref byte g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, ref byte g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, ref byte g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, ref byte g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, string g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, string g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, string g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, string g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, string g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, string g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, string g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, string g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, ref byte r, string g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, byte* g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, byte* g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, byte* g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, byte* g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, byte* g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, byte* g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, byte* g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, byte* g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, ref byte g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, ref byte g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, ref byte g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, ref byte g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, ref byte g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, ref byte g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, ref byte g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, ref byte g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, ref byte g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, string g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, string g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, string g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, string g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, string g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, string g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, string g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, string g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, string r, string g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, byte* g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, byte* g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, byte* g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, byte* g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, byte* g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, byte* g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, byte* g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, byte* g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, ref byte g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, ref byte g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, ref byte g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, ref byte g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, ref byte g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, ref byte g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, ref byte g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, ref byte g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, ref byte g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, string g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, string g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, string g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, string g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, string g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, string g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, string g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, string g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, byte* r, string g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, byte* g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, byte* g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, byte* g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, byte* g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, byte* g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, byte* g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, byte* g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, byte* g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, ref byte g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, ref byte g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, ref byte g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, ref byte g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, ref byte g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, ref byte g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, ref byte g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, ref byte g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, ref byte g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, string g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, string g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, string g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, string g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, string g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, string g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, string g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, string g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, ref byte r, string g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, byte* g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, byte* g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, byte* g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, byte* g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, byte* g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, byte* g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, byte* g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, byte* g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, ref byte g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, ref byte g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, ref byte g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, ref byte g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, string r, ref byte g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, string r, ref byte g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, ref byte g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, string r, ref byte g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, string r, ref byte g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, string g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, string g, byte* b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, string g, byte* b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, string g, ref byte b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, string r, string g, ref byte b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, string r, string g, ref byte b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(ref Renderer renderer, string r, string g, string b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, string r, string g, string b, ref byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 714, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public partial int GetRenderDrawColor(ref Renderer renderer, string r, string g, string b, string a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderDrawBlendMode")]
        public unsafe partial int SetRenderDrawBlendMode(Renderer* renderer, BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderDrawBlendMode")]
        public partial int SetRenderDrawBlendMode(ref Renderer renderer, BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 744, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawBlendMode")]
        public unsafe partial int GetRenderDrawBlendMode(Renderer* renderer, BlendMode* blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 744, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawBlendMode")]
        public unsafe partial int GetRenderDrawBlendMode(Renderer* renderer, ref BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 744, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawBlendMode")]
        public unsafe partial int GetRenderDrawBlendMode(ref Renderer renderer, BlendMode* blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 744, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawBlendMode")]
        public partial int GetRenderDrawBlendMode(ref Renderer renderer, ref BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderClear")]
        public unsafe partial int RenderClear(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderClear")]
        public partial int RenderClear(ref Renderer renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 766, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPoint")]
        public unsafe partial int RenderDrawPoint(Renderer* renderer, int x, int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 766, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPoint")]
        public partial int RenderDrawPoint(ref Renderer renderer, int x, int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 778, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPoints")]
        public unsafe partial int RenderDrawPoints(Renderer* renderer, Point* points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 778, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPoints")]
        public unsafe partial int RenderDrawPoints(Renderer* renderer, ref Point points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 778, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPoints")]
        public unsafe partial int RenderDrawPoints(ref Renderer renderer, Point* points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 778, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPoints")]
        public partial int RenderDrawPoints(ref Renderer renderer, ref Point points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 793, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLine")]
        public unsafe partial int RenderDrawLine(Renderer* renderer, int x1, int y1, int x2, int y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 793, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLine")]
        public partial int RenderDrawLine(ref Renderer renderer, int x1, int y1, int x2, int y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 805, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLines")]
        public unsafe partial int RenderDrawLines(Renderer* renderer, Point* points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 805, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLines")]
        public unsafe partial int RenderDrawLines(Renderer* renderer, ref Point points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 805, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLines")]
        public unsafe partial int RenderDrawLines(ref Renderer renderer, Point* points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 805, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLines")]
        public partial int RenderDrawLines(ref Renderer renderer, ref Point points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 817, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRect")]
        public unsafe partial int RenderDrawRect(Renderer* renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 817, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRect")]
        public unsafe partial int RenderDrawRect(Renderer* renderer, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 817, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRect")]
        public unsafe partial int RenderDrawRect(ref Renderer renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 817, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRect")]
        public partial int RenderDrawRect(ref Renderer renderer, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 829, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRects")]
        public unsafe partial int RenderDrawRects(Renderer* renderer, Silk.NET.Maths.Rectangle<int>* rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 829, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRects")]
        public unsafe partial int RenderDrawRects(Renderer* renderer, ref Silk.NET.Maths.Rectangle<int> rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 829, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRects")]
        public unsafe partial int RenderDrawRects(ref Renderer renderer, Silk.NET.Maths.Rectangle<int>* rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 829, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRects")]
        public partial int RenderDrawRects(ref Renderer renderer, ref Silk.NET.Maths.Rectangle<int> rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 842, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRect")]
        public unsafe partial int RenderFillRect(Renderer* renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 842, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRect")]
        public unsafe partial int RenderFillRect(Renderer* renderer, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 842, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRect")]
        public unsafe partial int RenderFillRect(ref Renderer renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 842, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRect")]
        public partial int RenderFillRect(ref Renderer renderer, ref Silk.NET.Maths.Rectangle<int> rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRects")]
        public unsafe partial int RenderFillRects(Renderer* renderer, Silk.NET.Maths.Rectangle<int>* rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRects")]
        public unsafe partial int RenderFillRects(Renderer* renderer, ref Silk.NET.Maths.Rectangle<int> rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRects")]
        public unsafe partial int RenderFillRects(ref Renderer renderer, Silk.NET.Maths.Rectangle<int>* rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 854, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRects")]
        public partial int RenderFillRects(ref Renderer renderer, ref Silk.NET.Maths.Rectangle<int> rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(Renderer* renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(Renderer* renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(Renderer* renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(Renderer* renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(Renderer* renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(Renderer* renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(ref Renderer renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(ref Renderer renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(ref Renderer renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(ref Renderer renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(ref Renderer renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(ref Renderer renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(ref Renderer renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public partial int RenderCopy(ref Renderer renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, Silk.NET.Maths.Rectangle<int>* dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(ref Renderer renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public partial int RenderCopyEx(ref Renderer renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref Silk.NET.Maths.Rectangle<int> dstrect, double angle, ref Point center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPointF")]
        public unsafe partial int RenderDrawPointF(Renderer* renderer, float x, float y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 908, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPointF")]
        public partial int RenderDrawPointF(ref Renderer renderer, float x, float y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPointsF")]
        public unsafe partial int RenderDrawPointsF(Renderer* renderer, FPoint* points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPointsF")]
        public unsafe partial int RenderDrawPointsF(Renderer* renderer, ref FPoint points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPointsF")]
        public unsafe partial int RenderDrawPointsF(ref Renderer renderer, FPoint* points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPointsF")]
        public partial int RenderDrawPointsF(ref Renderer renderer, ref FPoint points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 935, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLineF")]
        public unsafe partial int RenderDrawLineF(Renderer* renderer, float x1, float y1, float x2, float y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 935, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLineF")]
        public partial int RenderDrawLineF(ref Renderer renderer, float x1, float y1, float x2, float y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLinesF")]
        public unsafe partial int RenderDrawLinesF(Renderer* renderer, FPoint* points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLinesF")]
        public unsafe partial int RenderDrawLinesF(Renderer* renderer, ref FPoint points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLinesF")]
        public unsafe partial int RenderDrawLinesF(ref Renderer renderer, FPoint* points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLinesF")]
        public partial int RenderDrawLinesF(ref Renderer renderer, ref FPoint points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectF")]
        public unsafe partial int RenderDrawRectF(Renderer* renderer, FRect* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectF")]
        public unsafe partial int RenderDrawRectF(Renderer* renderer, ref FRect rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectF")]
        public unsafe partial int RenderDrawRectF(ref Renderer renderer, FRect* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectF")]
        public partial int RenderDrawRectF(ref Renderer renderer, ref FRect rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectsF")]
        public unsafe partial int RenderDrawRectsF(Renderer* renderer, FRect* rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectsF")]
        public unsafe partial int RenderDrawRectsF(Renderer* renderer, ref FRect rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectsF")]
        public unsafe partial int RenderDrawRectsF(ref Renderer renderer, FRect* rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectsF")]
        public partial int RenderDrawRectsF(ref Renderer renderer, ref FRect rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 984, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectF")]
        public unsafe partial int RenderFillRectF(Renderer* renderer, FRect* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 984, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectF")]
        public unsafe partial int RenderFillRectF(Renderer* renderer, ref FRect rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 984, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectF")]
        public unsafe partial int RenderFillRectF(ref Renderer renderer, FRect* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 984, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectF")]
        public partial int RenderFillRectF(ref Renderer renderer, ref FRect rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectsF")]
        public unsafe partial int RenderFillRectsF(Renderer* renderer, FRect* rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectsF")]
        public unsafe partial int RenderFillRectsF(Renderer* renderer, ref FRect rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectsF")]
        public unsafe partial int RenderFillRectsF(ref Renderer renderer, FRect* rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectsF")]
        public partial int RenderFillRectsF(ref Renderer renderer, ref FRect rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref FRect dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(Renderer* renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, FRect* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(Renderer* renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref FRect dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(Renderer* renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(Renderer* renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref FRect dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(Renderer* renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, FRect* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(Renderer* renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref FRect dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(ref Renderer renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(ref Renderer renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref FRect dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(ref Renderer renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, FRect* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(ref Renderer renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref FRect dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(ref Renderer renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(ref Renderer renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref FRect dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(ref Renderer renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, FRect* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public partial int RenderCopyF(ref Renderer renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref FRect dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref FRect dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref FRect dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, FRect* dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref FRect dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref FRect dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref FRect dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref FRect dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, FRect* dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref FRect dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref FRect dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref FRect dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, Texture* texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref FRect dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, FRect* dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref FRect dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, Texture* texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref FRect dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, FRect* dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref FRect dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, ref Texture texture, Silk.NET.Maths.Rectangle<int>* srcrect, ref FRect dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, FRect* dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, FRect* dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(ref Renderer renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref FRect dstrect, double angle, FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public partial int RenderCopyExF(ref Renderer renderer, ref Texture texture, ref Silk.NET.Maths.Rectangle<int> srcrect, ref FRect dstrect, double angle, ref FPoint center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderReadPixels")]
        public unsafe partial int RenderReadPixels(Renderer* renderer, Silk.NET.Maths.Rectangle<int>* rect, uint format, void* pixels, int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderReadPixels")]
        public unsafe partial int RenderReadPixels<T0>(Renderer* renderer, Silk.NET.Maths.Rectangle<int>* rect, uint format, ref T0 pixels, int pitch) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderReadPixels")]
        public unsafe partial int RenderReadPixels(Renderer* renderer, ref Silk.NET.Maths.Rectangle<int> rect, uint format, void* pixels, int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderReadPixels")]
        public unsafe partial int RenderReadPixels<T0>(Renderer* renderer, ref Silk.NET.Maths.Rectangle<int> rect, uint format, ref T0 pixels, int pitch) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderReadPixels")]
        public unsafe partial int RenderReadPixels(ref Renderer renderer, Silk.NET.Maths.Rectangle<int>* rect, uint format, void* pixels, int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderReadPixels")]
        public unsafe partial int RenderReadPixels<T0>(ref Renderer renderer, Silk.NET.Maths.Rectangle<int>* rect, uint format, ref T0 pixels, int pitch) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderReadPixels")]
        public unsafe partial int RenderReadPixels(ref Renderer renderer, ref Silk.NET.Maths.Rectangle<int> rect, uint format, void* pixels, int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderReadPixels")]
        public partial int RenderReadPixels<T0>(ref Renderer renderer, ref Silk.NET.Maths.Rectangle<int> rect, uint format, ref T0 pixels, int pitch) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderPresent")]
        public unsafe partial void RenderPresent(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderPresent")]
        public partial void RenderPresent(ref Renderer renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1071, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_DestroyTexture")]
        public unsafe partial void DestroyTexture(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1071, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_DestroyTexture")]
        public partial void DestroyTexture(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1079, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_DestroyRenderer")]
        public unsafe partial void DestroyRenderer(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1079, Column 30 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_DestroyRenderer")]
        public partial void DestroyRenderer(ref Renderer renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFlush")]
        public unsafe partial int RenderFlush(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFlush")]
        public partial int RenderFlush(ref Renderer renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_BindTexture")]
        public unsafe partial int GLBindTexture(Texture* texture, float* texw, float* texh);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_BindTexture")]
        public unsafe partial int GLBindTexture(Texture* texture, float* texw, ref float texh);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_BindTexture")]
        public unsafe partial int GLBindTexture(Texture* texture, ref float texw, float* texh);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_BindTexture")]
        public unsafe partial int GLBindTexture(Texture* texture, ref float texw, ref float texh);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_BindTexture")]
        public unsafe partial int GLBindTexture(ref Texture texture, float* texw, float* texh);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_BindTexture")]
        public unsafe partial int GLBindTexture(ref Texture texture, float* texw, ref float texh);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_BindTexture")]
        public unsafe partial int GLBindTexture(ref Texture texture, ref float texw, float* texh);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_BindTexture")]
        public partial int GLBindTexture(ref Texture texture, ref float texw, ref float texh);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1126, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_UnbindTexture")]
        public unsafe partial int GLUnbindTexture(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1126, Column 29 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_UnbindTexture")]
        public partial int GLUnbindTexture(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1137, Column 31 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetMetalLayer")]
        public unsafe partial void* RenderGetMetalLayer(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1137, Column 31 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetMetalLayer")]
        public unsafe partial void* RenderGetMetalLayer(ref Renderer renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1148, Column 31 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetMetalCommandEncoder")]
        public unsafe partial void* RenderGetMetalCommandEncoder(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1148, Column 31 in build/submodules/SDL-mirror/include/SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetMetalCommandEncoder")]
        public unsafe partial void* RenderGetMetalCommandEncoder(ref Renderer renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_NumSensors")]
        public partial int NumSensors();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 136, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceName")]
        public unsafe partial byte* SensorGetDeviceName(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 136, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceName")]
        public partial string SensorGetDeviceNameS(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 40 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceType")]
        public partial SensorType SensorGetDeviceType(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 154, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceNonPortableType")]
        public partial int SensorGetDeviceNonPortableType(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 38 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceInstanceID")]
        public partial int SensorGetDeviceInstanceID(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 172, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorOpen")]
        public unsafe partial Sensor* SensorOpen(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 177, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorFromInstanceID")]
        public unsafe partial Sensor* SensorFromInstanceID(int instance_id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetName")]
        public unsafe partial byte* SensorGetName(Sensor* sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetName")]
        public unsafe partial string SensorGetNameS(Sensor* sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetName")]
        public unsafe partial byte* SensorGetName(ref Sensor sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 37 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetName")]
        public partial string SensorGetNameS(ref Sensor sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 193, Column 40 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetType")]
        public unsafe partial SensorType SensorGetType(Sensor* sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 193, Column 40 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetType")]
        public partial SensorType SensorGetType(ref Sensor sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetNonPortableType")]
        public unsafe partial int SensorGetNonPortableType(Sensor* sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetNonPortableType")]
        public partial int SensorGetNonPortableType(ref Sensor sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 38 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetInstanceID")]
        public unsafe partial int SensorGetInstanceID(Sensor* sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 38 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetInstanceID")]
        public partial int SensorGetInstanceID(ref Sensor sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetData")]
        public unsafe partial int SensorGetData(Sensor* sensor, float* data, int num_values);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetData")]
        public unsafe partial int SensorGetData(Sensor* sensor, ref float data, int num_values);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetData")]
        public unsafe partial int SensorGetData(ref Sensor sensor, float* data, int num_values);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 29 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetData")]
        public partial int SensorGetData(ref Sensor sensor, ref float data, int num_values);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 229, Column 30 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorClose")]
        public unsafe partial void SensorClose(Sensor* sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 229, Column 30 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorClose")]
        public partial void SensorClose(ref Sensor sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 238, Column 30 in build/submodules/SDL-mirror/include\\SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorUpdate")]
        public partial void SensorUpdate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 38 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_CreateShapedWindow")]
        public unsafe partial Window* CreateShapedWindow(byte* title, uint x, uint y, uint w, uint h, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 38 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_CreateShapedWindow")]
        public unsafe partial Window* CreateShapedWindow(ref byte title, uint x, uint y, uint w, uint h, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 38 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_CreateShapedWindow")]
        public unsafe partial Window* CreateShapedWindow(string title, uint x, uint y, uint w, uint h, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 34 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_IsShapedWindow")]
        public unsafe partial SdlBool IsShapedWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 34 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_IsShapedWindow")]
        public partial SdlBool IsShapedWindow(ref Window window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowShape")]
        public unsafe partial int SetWindowShape(Window* window, Surface* shape, WindowShapeModeVal* shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowShape")]
        public unsafe partial int SetWindowShape(Window* window, Surface* shape, ref WindowShapeModeVal shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowShape")]
        public unsafe partial int SetWindowShape(Window* window, ref Surface shape, WindowShapeModeVal* shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowShape")]
        public unsafe partial int SetWindowShape(Window* window, ref Surface shape, ref WindowShapeModeVal shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowShape")]
        public unsafe partial int SetWindowShape(ref Window window, Surface* shape, WindowShapeModeVal* shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowShape")]
        public unsafe partial int SetWindowShape(ref Window window, Surface* shape, ref WindowShapeModeVal shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowShape")]
        public unsafe partial int SetWindowShape(ref Window window, ref Surface shape, WindowShapeModeVal* shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowShape")]
        public partial int SetWindowShape(ref Window window, ref Surface shape, ref WindowShapeModeVal shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 136, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_GetShapedWindowMode")]
        public unsafe partial int GetShapedWindowMode(Window* window, WindowShapeModeVal* shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 136, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_GetShapedWindowMode")]
        public unsafe partial int GetShapedWindowMode(Window* window, ref WindowShapeModeVal shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 136, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_GetShapedWindowMode")]
        public unsafe partial int GetShapedWindowMode(ref Window window, WindowShapeModeVal* shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 136, Column 29 in build/submodules/SDL-mirror/include\\SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_GetShapedWindowMode")]
        public partial int GetShapedWindowMode(ref Window window, ref WindowShapeModeVal shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_SetWindowsMessageHook")]
        public unsafe partial void SetWindowsMessageHook(PfnWindowsMessageHook callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_SetWindowsMessageHook")]
        public partial void SetWindowsMessageHook<T0>(PfnWindowsMessageHook callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 58, Column 29 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_Direct3D9GetAdapterIndex")]
        public partial int Direct3D9GetAdapterIndex(int displayIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 43 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_RenderGetD3D9Device")]
        public unsafe partial IDirect3DDevice9* RenderGetD3D9Device(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 43 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_RenderGetD3D9Device")]
        public unsafe partial IDirect3DDevice9* RenderGetD3D9Device(ref Renderer renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_DXGIGetOutputInfo")]
        public unsafe partial SdlBool DXGIGetOutputInfo(int displayIndex, int* adapterIndex, int* outputIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_DXGIGetOutputInfo")]
        public unsafe partial SdlBool DXGIGetOutputInfo(int displayIndex, int* adapterIndex, ref int outputIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_DXGIGetOutputInfo")]
        public unsafe partial SdlBool DXGIGetOutputInfo(int displayIndex, ref int adapterIndex, int* outputIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_DXGIGetOutputInfo")]
        public partial SdlBool DXGIGetOutputInfo(int displayIndex, ref int adapterIndex, ref int outputIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 29 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_iPhoneSetAnimationCallback")]
        public unsafe partial int IPhoneSetAnimationCallback(Window* window, int interval, PfnFreeFunc callback, void* callbackParam);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 29 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_iPhoneSetAnimationCallback")]
        public unsafe partial int IPhoneSetAnimationCallback<T0>(Window* window, int interval, PfnFreeFunc callback, ref T0 callbackParam) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 29 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_iPhoneSetAnimationCallback")]
        public unsafe partial int IPhoneSetAnimationCallback(ref Window window, int interval, PfnFreeFunc callback, void* callbackParam);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 29 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_iPhoneSetAnimationCallback")]
        public partial int IPhoneSetAnimationCallback<T0>(ref Window window, int interval, PfnFreeFunc callback, ref T0 callbackParam) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_iPhoneSetEventPump")]
        public partial void IPhoneSetEventPump(SdlBool enabled);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 111, Column 32 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidGetJNIEnv")]
        public unsafe partial void* AndroidGetJNIEnv();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 32 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidGetActivity")]
        public unsafe partial void* AndroidGetActivity();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 29 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_GetAndroidSDKVersion")]
        public partial int GetAndroidSDKVersion();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 152, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_IsAndroidTV")]
        public partial SdlBool IsAndroidTV();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_IsChromebook")]
        public partial SdlBool IsChromebook();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 162, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_IsDeXMode")]
        public partial SdlBool IsDeXMode();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 167, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidBackButton")]
        public partial void AndroidBackButton();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 38 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidGetInternalStoragePath")]
        public unsafe partial byte* AndroidGetInternalStoragePath();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 38 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidGetInternalStoragePath")]
        public partial string AndroidGetInternalStoragePathS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 191, Column 29 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidGetExternalStorageState")]
        public partial int AndroidGetExternalStorageState();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 38 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidGetExternalStoragePath")]
        public unsafe partial byte* AndroidGetExternalStoragePath();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 38 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidGetExternalStoragePath")]
        public partial string AndroidGetExternalStoragePathS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 41 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_WinRTGetFSPathUNICODE")]
        public unsafe partial char* WinRTGetFSPathUNICODE(WinRTPath pathType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 41 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_WinRTGetFSPathUNICODE")]
        public partial string WinRTGetFSPathUNICODES(WinRTPath pathType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 281, Column 38 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_WinRTGetFSPathUTF8")]
        public unsafe partial byte* WinRTGetFSPathUTF8(WinRTPath pathType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 281, Column 38 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_WinRTGetFSPathUTF8")]
        public partial string WinRTGetFSPathUTF8S(WinRTPath pathType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 48 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_WinRTGetDeviceFamily")]
        public partial WinRTDeviceFamily WinRTGetDeviceFamily();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 295, Column 34 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_IsTablet")]
        public partial SdlBool IsTablet();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 298, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationWillTerminate")]
        public partial void OnApplicationWillTerminate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 299, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning")]
        public partial void OnApplicationDidReceiveMemoryWarning();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationWillResignActive")]
        public partial void OnApplicationWillResignActive();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 301, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationDidEnterBackground")]
        public partial void OnApplicationDidEnterBackground();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 302, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationWillEnterForeground")]
        public partial void OnApplicationWillEnterForeground();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationDidBecomeActive")]
        public partial void OnApplicationDidBecomeActive();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 305, Column 30 in build/submodules/SDL-mirror/include\\SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationDidChangeStatusBarOrientation")]
        public partial void OnApplicationDidChangeStatusBarOrientation();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 45, Column 32 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_GetTicks")]
        public partial uint GetTicks();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 32 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_GetPerformanceCounter")]
        public partial ulong GetPerformanceCounter();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 32 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_GetPerformanceFrequency")]
        public partial ulong GetPerformanceFrequency();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 30 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_Delay")]
        public partial void Delay(uint ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 93, Column 37 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_AddTimer")]
        public unsafe partial int AddTimer(uint interval, PfnTimerCallback callback, void* param);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 93, Column 37 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_AddTimer")]
        public partial int AddTimer<T0>(uint interval, PfnTimerCallback callback, ref T0 param) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 104, Column 34 in build/submodules/SDL-mirror/include\\SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_RemoveTimer")]
        public partial SdlBool RemoveTimer(int id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 133, Column 30 in build/submodules/SDL-mirror/include\\SDL_version.h")]
        [NativeApi(EntryPoint = "SDL_GetVersion")]
        public unsafe partial void GetVersion(Version* ver);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 133, Column 30 in build/submodules/SDL-mirror/include\\SDL_version.h")]
        [NativeApi(EntryPoint = "SDL_GetVersion")]
        public partial void GetVersion(ref Version ver);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 37 in build/submodules/SDL-mirror/include\\SDL_version.h")]
        [NativeApi(EntryPoint = "SDL_GetRevision")]
        public unsafe partial byte* GetRevision();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 37 in build/submodules/SDL-mirror/include\\SDL_version.h")]
        [NativeApi(EntryPoint = "SDL_GetRevision")]
        public partial string GetRevisionS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 29 in build/submodules/SDL-mirror/include\\SDL_version.h")]
        [NativeApi(EntryPoint = "SDL_GetRevisionNumber")]
        public partial int GetRevisionNumber();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 96, Column 29 in SDL.h")]
        [NativeApi(EntryPoint = "SDL_Init")]
        public partial int Init(uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 107, Column 29 in SDL.h")]
        [NativeApi(EntryPoint = "SDL_InitSubSystem")]
        public partial int InitSubSystem(uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 30 in SDL.h")]
        [NativeApi(EntryPoint = "SDL_QuitSubSystem")]
        public partial void QuitSubSystem(uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 32 in SDL.h")]
        [NativeApi(EntryPoint = "SDL_WasInit")]
        public partial uint WasInit(uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 30 in SDL.h")]
        [NativeApi(EntryPoint = "SDL_Quit")]
        public partial void Quit();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe byte* Strtokr(byte* s1, byte* s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = Strtokr(s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe string StrtokrS(byte* s1, byte* s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = StrtokrS(s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe byte* Strtokr(byte* s1, ref byte s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = Strtokr(s1, ref s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe string StrtokrS(byte* s1, ref byte s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = StrtokrS(s1, ref s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe byte* Strtokr(byte* s1, string s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = Strtokr(s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe string StrtokrS(byte* s1, string s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = StrtokrS(s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe byte* Strtokr(ref byte s1, byte* s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = Strtokr(ref s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe string StrtokrS(ref byte s1, byte* s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = StrtokrS(ref s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe byte* Strtokr(ref byte s1, ref byte s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = Strtokr(ref s1, ref s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe string StrtokrS(ref byte s1, ref byte s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = StrtokrS(ref s1, ref s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe byte* Strtokr(ref byte s1, string s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = Strtokr(ref s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe string StrtokrS(ref byte s1, string s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = StrtokrS(ref s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe byte* Strtokr(string s1, byte* s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = Strtokr(s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe string StrtokrS(string s1, byte* s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = StrtokrS(s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe byte* Strtokr(string s1, ref byte s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = Strtokr(s1, ref s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe string StrtokrS(string s1, ref byte s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = StrtokrS(s1, ref s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe byte* Strtokr(string s1, string s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = Strtokr(s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 31 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe string StrtokrS(string s1, string s2, string[] saveptrSa)
        {
            // StringArrayOverloader
            var saveptr = (byte**) SilkMarshal.StringArrayToPtr(saveptrSa);
            var ret = StrtokrS(s1, s2, saveptr);
            SilkMarshal.CopyPtrToStringArray((nint) saveptr, saveptrSa);
            SilkMarshal.Free((nint) saveptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe int Strtol(byte* str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtol(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe int Strtol(ref byte str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtol(ref str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 30 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe int Strtol(string str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtol(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Strtoul(byte* str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtoul(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Strtoul(ref byte str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtoul(ref str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 491, Column 39 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Strtoul(string str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtoul(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe long Strtoll(byte* str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtoll(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe long Strtoll(ref byte str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtoll(ref str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe long Strtoll(string str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtoll(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe ulong Strtoull(byte* str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtoull(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe ulong Strtoull(ref byte str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtoull(ref str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 493, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe ulong Strtoull(string str, string[] endpSa, int @base)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtoull(str, endp, @base);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe double Strtod(byte* str, string[] endpSa)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtod(str, endp);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe double Strtod(ref byte str, string[] endpSa)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtod(ref str, endp);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe double Strtod(string str, string[] endpSa)
        {
            // StringArrayOverloader
            var endp = (byte**) SilkMarshal.StringArrayToPtr(endpSa);
            var ret = Strtod(str, endp);
            SilkMarshal.CopyPtrToStringArray((nint) endp, endpSa);
            SilkMarshal.Free((nint) endp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(Icon* cd, string[] inbufSa, uint* inbytesleft, string[] outbufSa, uint* outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(cd, inbuf, inbytesleft, outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(Icon* cd, string[] inbufSa, uint* inbytesleft, string[] outbufSa, ref uint outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(cd, inbuf, inbytesleft, outbuf, ref outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(Icon* cd, string[] inbufSa, uint* inbytesleft, ref byte* outbuf, uint* outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var ret = Iconv(cd, inbuf, inbytesleft, ref outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(Icon* cd, string[] inbufSa, uint* inbytesleft, ref byte* outbuf, ref uint outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var ret = Iconv(cd, inbuf, inbytesleft, ref outbuf, ref outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(Icon* cd, string[] inbufSa, ref uint inbytesleft, string[] outbufSa, uint* outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(cd, inbuf, ref inbytesleft, outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(Icon* cd, string[] inbufSa, ref uint inbytesleft, string[] outbufSa, ref uint outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(cd, inbuf, ref inbytesleft, outbuf, ref outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(Icon* cd, string[] inbufSa, ref uint inbytesleft, ref byte* outbuf, uint* outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var ret = Iconv(cd, inbuf, ref inbytesleft, ref outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(Icon* cd, string[] inbufSa, ref uint inbytesleft, ref byte* outbuf, ref uint outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var ret = Iconv(cd, inbuf, ref inbytesleft, ref outbuf, ref outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(Icon* cd, ref byte* inbuf, uint* inbytesleft, string[] outbufSa, uint* outbytesleft)
        {
            // StringArrayOverloader
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(cd, ref inbuf, inbytesleft, outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(Icon* cd, ref byte* inbuf, uint* inbytesleft, string[] outbufSa, ref uint outbytesleft)
        {
            // StringArrayOverloader
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(cd, ref inbuf, inbytesleft, outbuf, ref outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(Icon* cd, ref byte* inbuf, ref uint inbytesleft, string[] outbufSa, uint* outbytesleft)
        {
            // StringArrayOverloader
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(cd, ref inbuf, ref inbytesleft, outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(Icon* cd, ref byte* inbuf, ref uint inbytesleft, string[] outbufSa, ref uint outbytesleft)
        {
            // StringArrayOverloader
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(cd, ref inbuf, ref inbytesleft, outbuf, ref outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(ref Icon cd, string[] inbufSa, uint* inbytesleft, string[] outbufSa, uint* outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(ref cd, inbuf, inbytesleft, outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(ref Icon cd, string[] inbufSa, uint* inbytesleft, string[] outbufSa, ref uint outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(ref cd, inbuf, inbytesleft, outbuf, ref outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(ref Icon cd, string[] inbufSa, uint* inbytesleft, ref byte* outbuf, uint* outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var ret = Iconv(ref cd, inbuf, inbytesleft, ref outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(ref Icon cd, string[] inbufSa, uint* inbytesleft, ref byte* outbuf, ref uint outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var ret = Iconv(ref cd, inbuf, inbytesleft, ref outbuf, ref outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(ref Icon cd, string[] inbufSa, ref uint inbytesleft, string[] outbufSa, uint* outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(ref cd, inbuf, ref inbytesleft, outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(ref Icon cd, string[] inbufSa, ref uint inbytesleft, string[] outbufSa, ref uint outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(ref cd, inbuf, ref inbytesleft, outbuf, ref outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(ref Icon cd, string[] inbufSa, ref uint inbytesleft, ref byte* outbuf, uint* outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var ret = Iconv(ref cd, inbuf, ref inbytesleft, ref outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(ref Icon cd, string[] inbufSa, ref uint inbytesleft, ref byte* outbuf, ref uint outbytesleft)
        {
            // StringArrayOverloader
            var inbuf = (byte**) SilkMarshal.StringArrayToPtr(inbufSa);
            var ret = Iconv(ref cd, inbuf, ref inbytesleft, ref outbuf, ref outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) inbuf, inbufSa);
            SilkMarshal.Free((nint) inbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(ref Icon cd, ref byte* inbuf, uint* inbytesleft, string[] outbufSa, uint* outbytesleft)
        {
            // StringArrayOverloader
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(ref cd, ref inbuf, inbytesleft, outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(ref Icon cd, ref byte* inbuf, uint* inbytesleft, string[] outbufSa, ref uint outbytesleft)
        {
            // StringArrayOverloader
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(ref cd, ref inbuf, inbytesleft, outbuf, ref outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(ref Icon cd, ref byte* inbuf, ref uint inbytesleft, string[] outbufSa, uint* outbytesleft)
        {
            // StringArrayOverloader
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(ref cd, ref inbuf, ref inbytesleft, outbuf, outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in build/submodules/SDL-mirror/include/SDL_stdinc.h")]
        public unsafe uint Iconv(ref Icon cd, ref byte* inbuf, ref uint inbytesleft, string[] outbufSa, ref uint outbytesleft)
        {
            // StringArrayOverloader
            var outbuf = (byte**) SilkMarshal.StringArrayToPtr(outbufSa);
            var ret = Iconv(ref cd, ref inbuf, ref inbytesleft, outbuf, ref outbytesleft);
            SilkMarshal.CopyPtrToStringArray((nint) outbuf, outbufSa);
            SilkMarshal.Free((nint) outbuf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        public unsafe SdlBool VulkanGetInstanceExtensions(Window* window, uint* pCount, string[] pNamesSa)
        {
            // StringArrayOverloader
            var pNames = (byte**) SilkMarshal.StringArrayToPtr(pNamesSa);
            var ret = VulkanGetInstanceExtensions(window, pCount, pNames);
            SilkMarshal.CopyPtrToStringArray((nint) pNames, pNamesSa);
            SilkMarshal.Free((nint) pNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        public unsafe SdlBool VulkanGetInstanceExtensions(Window* window, ref uint pCount, string[] pNamesSa)
        {
            // StringArrayOverloader
            var pNames = (byte**) SilkMarshal.StringArrayToPtr(pNamesSa);
            var ret = VulkanGetInstanceExtensions(window, ref pCount, pNames);
            SilkMarshal.CopyPtrToStringArray((nint) pNames, pNamesSa);
            SilkMarshal.Free((nint) pNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        public unsafe SdlBool VulkanGetInstanceExtensions(ref Window window, uint* pCount, string[] pNamesSa)
        {
            // StringArrayOverloader
            var pNames = (byte**) SilkMarshal.StringArrayToPtr(pNamesSa);
            var ret = VulkanGetInstanceExtensions(ref window, pCount, pNames);
            SilkMarshal.CopyPtrToStringArray((nint) pNames, pNamesSa);
            SilkMarshal.Free((nint) pNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 34 in SDL_vulkan.h")]
        public unsafe SdlBool VulkanGetInstanceExtensions(ref Window window, ref uint pCount, string[] pNamesSa)
        {
            // StringArrayOverloader
            var pNames = (byte**) SilkMarshal.StringArrayToPtr(pNamesSa);
            var ret = VulkanGetInstanceExtensions(ref window, ref pCount, pNames);
            SilkMarshal.CopyPtrToStringArray((nint) pNames, pNamesSa);
            SilkMarshal.Free((nint) pNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 29 in build/submodules/SDL-mirror/include\\SDL_main.h")]
        public unsafe int UIKitRunApp(int argc, string[] argvSa, PfnMainFunc mainFunction)
        {
            // StringArrayOverloader
            var argv = (byte**) SilkMarshal.StringArrayToPtr(argvSa);
            var ret = UIKitRunApp(argc, argv, mainFunction);
            SilkMarshal.CopyPtrToStringArray((nint) argv, argvSa);
            SilkMarshal.Free((nint) argv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public unsafe AudioSpec* LoadWAVRW(RWops* src, int freesrc, AudioSpec* spec, string[] audio_bufSa, uint* audio_len)
        {
            // StringArrayOverloader
            var audio_buf = (byte**) SilkMarshal.StringArrayToPtr(audio_bufSa);
            var ret = LoadWAVRW(src, freesrc, spec, audio_buf, audio_len);
            SilkMarshal.CopyPtrToStringArray((nint) audio_buf, audio_bufSa);
            SilkMarshal.Free((nint) audio_buf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public unsafe AudioSpec* LoadWAVRW(RWops* src, int freesrc, AudioSpec* spec, string[] audio_bufSa, ref uint audio_len)
        {
            // StringArrayOverloader
            var audio_buf = (byte**) SilkMarshal.StringArrayToPtr(audio_bufSa);
            var ret = LoadWAVRW(src, freesrc, spec, audio_buf, ref audio_len);
            SilkMarshal.CopyPtrToStringArray((nint) audio_buf, audio_bufSa);
            SilkMarshal.Free((nint) audio_buf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public unsafe AudioSpec* LoadWAVRW(RWops* src, int freesrc, ref AudioSpec spec, string[] audio_bufSa, uint* audio_len)
        {
            // StringArrayOverloader
            var audio_buf = (byte**) SilkMarshal.StringArrayToPtr(audio_bufSa);
            var ret = LoadWAVRW(src, freesrc, ref spec, audio_buf, audio_len);
            SilkMarshal.CopyPtrToStringArray((nint) audio_buf, audio_bufSa);
            SilkMarshal.Free((nint) audio_buf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public unsafe AudioSpec* LoadWAVRW(RWops* src, int freesrc, ref AudioSpec spec, string[] audio_bufSa, ref uint audio_len)
        {
            // StringArrayOverloader
            var audio_buf = (byte**) SilkMarshal.StringArrayToPtr(audio_bufSa);
            var ret = LoadWAVRW(src, freesrc, ref spec, audio_buf, ref audio_len);
            SilkMarshal.CopyPtrToStringArray((nint) audio_buf, audio_bufSa);
            SilkMarshal.Free((nint) audio_buf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public unsafe AudioSpec* LoadWAVRW(ref RWops src, int freesrc, AudioSpec* spec, string[] audio_bufSa, uint* audio_len)
        {
            // StringArrayOverloader
            var audio_buf = (byte**) SilkMarshal.StringArrayToPtr(audio_bufSa);
            var ret = LoadWAVRW(ref src, freesrc, spec, audio_buf, audio_len);
            SilkMarshal.CopyPtrToStringArray((nint) audio_buf, audio_bufSa);
            SilkMarshal.Free((nint) audio_buf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public unsafe AudioSpec* LoadWAVRW(ref RWops src, int freesrc, AudioSpec* spec, string[] audio_bufSa, ref uint audio_len)
        {
            // StringArrayOverloader
            var audio_buf = (byte**) SilkMarshal.StringArrayToPtr(audio_bufSa);
            var ret = LoadWAVRW(ref src, freesrc, spec, audio_buf, ref audio_len);
            SilkMarshal.CopyPtrToStringArray((nint) audio_buf, audio_bufSa);
            SilkMarshal.Free((nint) audio_buf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public unsafe AudioSpec* LoadWAVRW(ref RWops src, int freesrc, ref AudioSpec spec, string[] audio_bufSa, uint* audio_len)
        {
            // StringArrayOverloader
            var audio_buf = (byte**) SilkMarshal.StringArrayToPtr(audio_bufSa);
            var ret = LoadWAVRW(ref src, freesrc, ref spec, audio_buf, audio_len);
            SilkMarshal.CopyPtrToStringArray((nint) audio_buf, audio_bufSa);
            SilkMarshal.Free((nint) audio_buf);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 40 in build/submodules/SDL-mirror/include\\SDL_audio.h")]
        public unsafe AudioSpec* LoadWAVRW(ref RWops src, int freesrc, ref AudioSpec spec, string[] audio_bufSa, ref uint audio_len)
        {
            // StringArrayOverloader
            var audio_buf = (byte**) SilkMarshal.StringArrayToPtr(audio_bufSa);
            var ret = LoadWAVRW(ref src, freesrc, ref spec, audio_buf, ref audio_len);
            SilkMarshal.CopyPtrToStringArray((nint) audio_buf, audio_bufSa);
            SilkMarshal.Free((nint) audio_buf);
            return ret;
        }


        public Sdl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

