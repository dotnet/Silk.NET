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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_map_object_buffer")]
    public unsafe partial class AtiMapObjectBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_map_object_buffer";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapObjectBufferATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapObjectBuffer([Flow(FlowDirection.In)] uint buffer)
            => ImplMapObjectBuffer(buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUnmapObjectBufferATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UnmapObjectBuffer([Flow(FlowDirection.In)] uint buffer)
            => ImplUnmapObjectBuffer(buffer);

        public AtiMapObjectBuffer(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

