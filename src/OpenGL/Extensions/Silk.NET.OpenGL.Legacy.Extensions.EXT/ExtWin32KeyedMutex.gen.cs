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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_win32_keyed_mutex")]
    public unsafe partial class ExtWin32KeyedMutex : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_win32_keyed_mutex";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="key">
        /// To be added.
        /// </param>
        /// <param name="timeout">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glAcquireKeyedMutexWin32EXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool AcquireKeyedMutexWin32([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong key, [Flow(FlowDirection.In)] uint timeout)
            => ImplAcquireKeyedMutexWin32(memory, key, timeout);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="key">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glReleaseKeyedMutexWin32EXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool ReleaseKeyedMutexWin32([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong key)
            => ImplReleaseKeyedMutexWin32(memory, key);

        public ExtWin32KeyedMutex(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

