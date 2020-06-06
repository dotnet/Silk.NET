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
    [Extension("SGIX_instruments")]
    public unsafe partial class SgixInstruments : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_instruments";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetInstrumentsSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetInstruments()
            => ImplGetInstruments();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glInstrumentsBufferSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InstrumentsBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] int* buffer)
            => ImplInstrumentsBuffer(size, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glInstrumentsBufferSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InstrumentsBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> buffer)
            => ImplInstrumentsBuffer(size, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="marker_p">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPollInstrumentsSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int PollInstruments([Count(Count = 1), Flow(FlowDirection.Out)] int* marker_p)
            => ImplPollInstruments(marker_p);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="marker_p">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPollInstrumentsSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int PollInstruments([Count(Count = 1), Flow(FlowDirection.Out)] out int marker_p)
            => ImplPollInstruments(marker_p);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="marker">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReadInstrumentsSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReadInstruments([Flow(FlowDirection.In)] int marker)
            => ImplReadInstruments(marker);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glStartInstrumentsSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StartInstruments()
            => ImplStartInstruments();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="marker">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStopInstrumentsSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StopInstruments([Flow(FlowDirection.In)] int marker)
            => ImplStopInstruments(marker);

        public SgixInstruments(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

