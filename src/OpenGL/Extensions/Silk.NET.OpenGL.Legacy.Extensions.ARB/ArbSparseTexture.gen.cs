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
    [Extension("ARB_sparse_texture")]
    public unsafe partial class ArbSparseTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sparse_texture";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="commit">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexPageCommitmentARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexPageCommitment([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool commit)
            => ImplTexPageCommitment(target, level, xoffset, yoffset, zoffset, width, height, depth, commit);

        public ArbSparseTexture(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

