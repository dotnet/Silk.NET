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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_async")]
    public unsafe partial class SgixAsync : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_async";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="marker">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glAsyncMarkerSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void AsyncMarker([Flow(FlowDirection.In)] uint marker)
            => ImplAsyncMarker(marker);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="marker">
        /// To be added.
        /// </param>
        /// <param name="range">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteAsyncMarkersSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteAsyncMarkers([Flow(FlowDirection.In)] uint marker, [Flow(FlowDirection.In)] uint range)
            => ImplDeleteAsyncMarkers(marker, range);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="markerp">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glFinishAsyncSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int FinishAsync([Count(Count = 1), Flow(FlowDirection.Out)] uint* markerp)
            => ImplFinishAsync(markerp);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="markerp">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glFinishAsyncSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int FinishAsync([Count(Count = 1), Flow(FlowDirection.Out)] out uint markerp)
            => ImplFinishAsync(markerp);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="range">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGenAsyncMarkersSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GenAsyncMarkers([Flow(FlowDirection.In)] uint range)
            => ImplGenAsyncMarkers(range);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="marker">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsAsyncMarkerSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsAsyncMarker([Flow(FlowDirection.In)] uint marker)
            => ImplIsAsyncMarker(marker);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="markerp">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPollAsyncSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int PollAsync([Count(Count = 1), Flow(FlowDirection.Out)] uint* markerp)
            => ImplPollAsync(markerp);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="markerp">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPollAsyncSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int PollAsync([Count(Count = 1), Flow(FlowDirection.Out)] out uint markerp)
            => ImplPollAsync(markerp);

        public SgixAsync(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

