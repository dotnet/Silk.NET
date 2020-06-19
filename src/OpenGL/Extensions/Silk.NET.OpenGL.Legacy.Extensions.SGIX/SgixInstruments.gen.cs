// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_instruments")]
    public abstract unsafe partial class SgixInstruments : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_instruments";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetInstrumentsSGIX")]
        public abstract int GetInstruments();

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
        public abstract unsafe void InstrumentsBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] int* buffer);

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
        public abstract void InstrumentsBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="marker_p">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPollInstrumentsSGIX")]
        public abstract unsafe int PollInstruments([Count(Count = 1), Flow(FlowDirection.Out)] int* marker_p);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="marker_p">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPollInstrumentsSGIX")]
        public abstract int PollInstruments([Count(Count = 1), Flow(FlowDirection.Out)] out int marker_p);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="marker">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReadInstrumentsSGIX")]
        public abstract void ReadInstruments([Flow(FlowDirection.In)] int marker);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glStartInstrumentsSGIX")]
        public abstract void StartInstruments();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="marker">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStopInstrumentsSGIX")]
        public abstract void StopInstruments([Flow(FlowDirection.In)] int marker);

        public SgixInstruments(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

