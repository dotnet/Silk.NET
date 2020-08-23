// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_instruments")]
    public unsafe partial class SgixInstruments : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_instruments";
        [NativeApi(EntryPoint = "glGetInstrumentsSGIX")]
        public partial int GetInstruments();

        [NativeApi(EntryPoint = "glInstrumentsBufferSGIX")]
        public unsafe partial void InstrumentsBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] int* buffer);

        [NativeApi(EntryPoint = "glInstrumentsBufferSGIX")]
        public partial void InstrumentsBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] out int buffer);

        [NativeApi(EntryPoint = "glPollInstrumentsSGIX")]
        public unsafe partial int PollInstruments([Count(Count = 1), Flow(FlowDirection.Out)] int* marker_p);

        [NativeApi(EntryPoint = "glPollInstrumentsSGIX")]
        public partial int PollInstruments([Count(Count = 1), Flow(FlowDirection.Out)] out int marker_p);

        [NativeApi(EntryPoint = "glReadInstrumentsSGIX")]
        public partial void ReadInstruments([Flow(FlowDirection.In)] int marker);

        [NativeApi(EntryPoint = "glStartInstrumentsSGIX")]
        public partial void StartInstruments();

        [NativeApi(EntryPoint = "glStopInstrumentsSGIX")]
        public partial void StopInstruments([Flow(FlowDirection.In)] int marker);

        public SgixInstruments(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

