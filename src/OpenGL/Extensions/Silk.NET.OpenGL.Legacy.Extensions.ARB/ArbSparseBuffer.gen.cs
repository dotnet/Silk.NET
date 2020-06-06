// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_sparse_buffer")]
    public unsafe partial class ArbSparseBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sparse_buffer";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="commit">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferPageCommitmentARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferPageCommitment([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] bool commit)
            => ImplBufferPageCommitment(target, offset, size, commit);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="commit">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferPageCommitmentEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedBufferPageCommitment([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] bool commit)
            => ImplNamedBufferPageCommitment(buffer, offset, size, commit);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="commit">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferPageCommitment([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] bool commit)
        {
            // IntPtrOverloader
            BufferPageCommitment(target, new IntPtr(offset), new UIntPtr(size), commit);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="commit">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferPageCommitment([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] bool commit)
        {
            // IntPtrOverloader
            NamedBufferPageCommitment(buffer, new IntPtr(offset), new UIntPtr(size), commit);
        }

        public ArbSparseBuffer(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

