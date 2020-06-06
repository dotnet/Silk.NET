// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_sync")]
    public unsafe partial class ArbSync : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sync";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <param name="timeout">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glClientWaitSync")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ARB ClientWaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
            => ImplClientWaitSync(sync, flags, timeout);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteSync")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteSync([Flow(FlowDirection.In)] IntPtr sync)
            => ImplDeleteSync(sync);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="condition">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glFenceSync")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr FenceSync([Flow(FlowDirection.In)] ARB condition, [Flow(FlowDirection.In)] uint flags)
            => ImplFenceSync(condition, flags);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetInteger64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInteger64([Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data)
            => ImplGetInteger64(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetInteger64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInteger64([Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data)
            => ImplGetInteger64(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetSynciv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
            => ImplGetSync(sync, pname, count, length, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetSynciv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
            => ImplGetSync(sync, pname, count, length, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsSync")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsSync([Flow(FlowDirection.In)] IntPtr sync)
            => ImplIsSync(sync);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <param name="timeout">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWaitSync")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
            => ImplWaitSync(sync, flags, timeout);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="condition">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glFenceSync")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr FenceSync([Flow(FlowDirection.In)] SyncCondition condition, [Flow(FlowDirection.In)] uint flags)
            => ImplFenceSync(condition, flags);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetInteger64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data)
            => ImplGetInteger64(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetInteger64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data)
            => ImplGetInteger64(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetSynciv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
            => ImplGetSync(sync, pname, count, length, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetSynciv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
            => ImplGetSync(sync, pname, count, length, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <param name="timeout">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe ARB ClientWaitSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
        {
            // IntPtrOverloader
            return ClientWaitSync(new IntPtr(sync), flags, timeout);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteSync([Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            DeleteSync(new IntPtr(sync));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe long GetInteger64([Flow(FlowDirection.In)] ARB pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, length, values);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, out length, values);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe bool IsSync([Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            return IsSync(new IntPtr(sync));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <param name="timeout">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WaitSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
        {
            // IntPtrOverloader
            WaitSync(new IntPtr(sync), flags, timeout);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe long GetInteger64([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, length, values);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, out length, values);
        }

        public ArbSync(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

