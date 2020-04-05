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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_instruments")]
    public abstract unsafe partial class SgixInstruments : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInstrumentsSGIX")]
        public abstract int GetInstruments();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInstrumentsBufferSGIX")]
        public abstract unsafe void InstrumentsBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] int* buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInstrumentsBufferSGIX")]
        public abstract void InstrumentsBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPollInstrumentsSGIX")]
        public abstract unsafe int PollInstruments([Count(Count = 1), Flow(FlowDirection.Out)] int* marker_p);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPollInstrumentsSGIX")]
        public abstract int PollInstruments([Count(Count = 1), Flow(FlowDirection.Out)] out int marker_p);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReadInstrumentsSGIX")]
        public abstract void ReadInstruments([Flow(FlowDirection.In)] int marker);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glStartInstrumentsSGIX")]
        public abstract void StartInstruments();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glStopInstrumentsSGIX")]
        public abstract void StopInstruments([Flow(FlowDirection.In)] int marker);

        public SgixInstruments(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

