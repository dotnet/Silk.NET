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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_command_list")]
    public unsafe partial class NVCommandList : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_command_list";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCallCommandListNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CallCommandList([Flow(FlowDirection.In)] uint list)
            => ImplCallCommandList(list);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="segments">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCommandListSegmentsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CommandListSegments([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segments)
            => ImplCommandListSegments(list, segments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompileCommandListNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompileCommandList([Flow(FlowDirection.In)] uint list)
            => ImplCompileCommandList(list);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="lists">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateCommandListsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* lists)
            => ImplCreateCommandLists(n, lists);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="lists">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateCommandListsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> lists)
            => ImplCreateCommandLists(n, lists);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="states">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateStatesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* states)
            => ImplCreateStates(n, states);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="states">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCreateStatesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> states)
            => ImplCreateStates(n, states);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="lists">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteCommandListsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* lists)
            => ImplDeleteCommandLists(n, lists);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="lists">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteCommandListsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> lists)
            => ImplDeleteCommandLists(n, lists);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="states">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteStatesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* states)
            => ImplDeleteStates(n, states);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="states">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteStatesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> states)
            => ImplDeleteStates(n, states);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="primitiveMode">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="indirects">
        /// To be added.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count)
            => ImplDrawCommands(primitiveMode, buffer, indirects, sizes, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="primitiveMode">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="indirects">
        /// To be added.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] Span<IntPtr> indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] uint count)
            => ImplDrawCommands(primitiveMode, buffer, indirects, sizes, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="primitiveMode">
        /// To be added.
        /// </param>
        /// <param name="indirects">
        /// To be added.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawCommandsAddressNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count)
            => ImplDrawCommandsAddress(primitiveMode, indirects, sizes, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="primitiveMode">
        /// To be added.
        /// </param>
        /// <param name="indirects">
        /// To be added.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawCommandsAddressNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] Span<ulong> indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] uint count)
            => ImplDrawCommandsAddress(primitiveMode, indirects, sizes, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="indirects">
        /// To be added.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// </param>
        /// <param name="states">
        /// To be added.
        /// </param>
        /// <param name="fbos">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
            => ImplDrawCommandsStates(buffer, indirects, sizes, states, fbos, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="indirects">
        /// To be added.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// </param>
        /// <param name="states">
        /// To be added.
        /// </param>
        /// <param name="fbos">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] Span<IntPtr> indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] Span<uint> states, [Flow(FlowDirection.In)] Span<uint> fbos, [Flow(FlowDirection.In)] uint count)
            => ImplDrawCommandsStates(buffer, indirects, sizes, states, fbos, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="indirects">
        /// To be added.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// </param>
        /// <param name="states">
        /// To be added.
        /// </param>
        /// <param name="fbos">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
            => ImplDrawCommandsStatesAddress(indirects, sizes, states, fbos, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="indirects">
        /// To be added.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// </param>
        /// <param name="states">
        /// To be added.
        /// </param>
        /// <param name="fbos">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawCommandsStatesAddress([Flow(FlowDirection.In)] Span<ulong> indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] Span<uint> states, [Flow(FlowDirection.In)] Span<uint> fbos, [Flow(FlowDirection.In)] uint count)
            => ImplDrawCommandsStatesAddress(indirects, sizes, states, fbos, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tokenID">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetCommandHeaderNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetCommandHeader([Flow(FlowDirection.In)] NV tokenID, [Flow(FlowDirection.In)] uint size)
            => ImplGetCommandHeader(tokenID, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetStageIndexNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ushort GetStageIndex([Flow(FlowDirection.In)] NV shadertype)
            => ImplGetStageIndex(shadertype);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsCommandListNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsCommandList([Flow(FlowDirection.In)] uint list)
            => ImplIsCommandList(list);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="state">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsStateNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsState([Flow(FlowDirection.In)] uint state)
            => ImplIsState(state);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="segment">
        /// To be added.
        /// </param>
        /// <param name="indirects">
        /// To be added.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// </param>
        /// <param name="states">
        /// To be added.
        /// </param>
        /// <param name="fbos">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Flow(FlowDirection.In)] void** indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
            => ImplListDrawCommandsStatesClient(list, segment, indirects, sizes, states, fbos, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <param name="segment">
        /// To be added.
        /// </param>
        /// <param name="indirects">
        /// To be added.
        /// </param>
        /// <param name="sizes">
        /// To be added.
        /// </param>
        /// <param name="states">
        /// To be added.
        /// </param>
        /// <param name="fbos">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ListDrawCommandsStatesClient<T0>([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Flow(FlowDirection.In)] void** indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] Span<uint> states, [Flow(FlowDirection.In)] Span<uint> fbos, [Flow(FlowDirection.In)] uint count) where T0 : unmanaged
            => ImplListDrawCommandsStatesClient<T0>(list, segment, indirects, sizes, states, fbos, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="state">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStateCaptureNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StateCapture([Flow(FlowDirection.In)] uint state, [Flow(FlowDirection.In)] NV mode)
            => ImplStateCapture(state, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetStageIndexNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ushort GetStageIndex([Flow(FlowDirection.In)] ShaderType shadertype)
            => ImplGetStageIndex(shadertype);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="lists">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateCommandList()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateCommandLists(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="states">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateState()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateStates(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="lists">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteCommandList([Count(Parameter = "n"), Flow(FlowDirection.In)] uint lists)
        {
            // ArrayParameterOverloader
            DeleteCommandLists(1, &lists);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="states">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteState([Count(Parameter = "n"), Flow(FlowDirection.In)] uint states)
        {
            // ArrayParameterOverloader
            DeleteStates(1, &states);
        }

        public NVCommandList(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

