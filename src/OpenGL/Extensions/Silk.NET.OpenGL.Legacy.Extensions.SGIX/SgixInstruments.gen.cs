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
        [NativeApi(EntryPoint = "glGetInstrumentsSGIX")]
        public abstract int GetInstruments();

        [NativeApi(EntryPoint = "glInstrumentsBufferSGIX")]
        public abstract unsafe void InstrumentsBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] int* buffer);

        [NativeApi(EntryPoint = "glInstrumentsBufferSGIX")]
        public abstract void InstrumentsBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> buffer);

        [NativeApi(EntryPoint = "glPollInstrumentsSGIX")]
        public abstract unsafe int PollInstruments([Count(Count = 1), Flow(FlowDirection.Out)] int* marker_p);

        [NativeApi(EntryPoint = "glPollInstrumentsSGIX")]
        public abstract int PollInstruments([Count(Count = 1), Flow(FlowDirection.Out)] out int marker_p);

        [NativeApi(EntryPoint = "glReadInstrumentsSGIX")]
        public abstract void ReadInstruments([Flow(FlowDirection.In)] int marker);

        [NativeApi(EntryPoint = "glStartInstrumentsSGIX")]
        public abstract void StartInstruments();

        [NativeApi(EntryPoint = "glStopInstrumentsSGIX")]
        public abstract void StopInstruments([Flow(FlowDirection.In)] int marker);

        public SgixInstruments(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

