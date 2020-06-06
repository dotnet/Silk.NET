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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_primitive_restart")]
    public unsafe partial class NVPrimitiveRestart : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_primitive_restart";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glPrimitiveRestartNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PrimitiveRestart()
            => ImplPrimitiveRestart();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPrimitiveRestartIndexNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PrimitiveRestartIndex([Flow(FlowDirection.In)] uint index)
            => ImplPrimitiveRestartIndex(index);

        public NVPrimitiveRestart(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

