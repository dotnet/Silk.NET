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

namespace Silk.NET.OpenGL.Extensions.EXT
{
    [Extension("EXT_debug_marker")]
    public unsafe partial class ExtDebugMarker : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_debug_marker";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="marker">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInsertEventMarkerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InsertEventMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] char* marker)
            => ImplInsertEventMarker(length, marker);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="marker">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInsertEventMarkerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InsertEventMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] Span<char> marker)
            => ImplInsertEventMarker(length, marker);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glPopGroupMarkerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PopGroupMarker()
            => ImplPopGroupMarker();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="marker">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPushGroupMarkerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PushGroupMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] char* marker)
            => ImplPushGroupMarker(length, marker);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="marker">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPushGroupMarkerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PushGroupMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] Span<char> marker)
            => ImplPushGroupMarker(length, marker);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="marker">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInsertEventMarkerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InsertEventMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string marker)
            => ImplInsertEventMarker(length, marker);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="marker">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPushGroupMarkerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PushGroupMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string marker)
            => ImplPushGroupMarker(length, marker);

        public ExtDebugMarker(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

