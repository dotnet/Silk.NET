// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_driver_control")]
    public unsafe partial class QComDriverControl : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_driver_control";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="driverControl">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableDriverControlQCOM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableDriverControl([Flow(FlowDirection.In)] uint driverControl)
            => ImplDisableDriverControl(driverControl);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="driverControl">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableDriverControlQCOM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableDriverControl([Flow(FlowDirection.In)] uint driverControl)
            => ImplEnableDriverControl(driverControl);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="num">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="driverControls">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glGetDriverControlsQCOM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetDriverControl([Flow(FlowDirection.Out)] int* num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] uint* driverControls)
            => ImplGetDriverControl(num, size, driverControls);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="num">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="driverControls">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glGetDriverControlsQCOM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetDriverControl([Flow(FlowDirection.Out)] Span<int> num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<uint> driverControls)
            => ImplGetDriverControl(num, size, driverControls);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="driverControl">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="driverControlString">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* driverControlString)
            => ImplGetDriverControlString(driverControl, bufSize, length, driverControlString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="driverControl">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="driverControlString">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> driverControlString)
            => ImplGetDriverControlString(driverControl, bufSize, length, driverControlString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="driverControl">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="driverControlString">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string driverControlString)
            => ImplGetDriverControlString(driverControl, bufSize, length, driverControlString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="driverControl">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="driverControlString">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetDriverControlString([Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string driverControlString)
            => ImplGetDriverControlString(driverControl, bufSize, length, driverControlString);

        public QComDriverControl(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

