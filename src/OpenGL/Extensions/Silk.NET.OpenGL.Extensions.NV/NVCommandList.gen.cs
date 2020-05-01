// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_command_list")]
    public abstract unsafe partial class NVCommandList : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_command_list";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCallCommandListNV")]
        public abstract void CallCommandList([Flow(FlowDirection.In)] uint list);

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
        public abstract void CommandListSegments([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompileCommandListNV")]
        public abstract void CompileCommandList([Flow(FlowDirection.In)] uint list);

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
        public abstract unsafe void CreateCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* lists);

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
        public abstract void CreateCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> lists);

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
        public abstract unsafe void CreateStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* states);

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
        public abstract void CreateStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> states);

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
        public abstract unsafe void DeleteCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* lists);

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
        public abstract void DeleteCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> lists);

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
        public abstract unsafe void DeleteStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* states);

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
        public abstract void DeleteStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> states);

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
        public abstract unsafe void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count);

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
        public abstract void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] Span<IntPtr> indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] uint count);

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
        public abstract unsafe void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count);

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
        public abstract void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] Span<ulong> indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] uint count);

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
        public abstract unsafe void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

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
        public abstract void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] Span<IntPtr> indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] Span<uint> states, [Flow(FlowDirection.In)] Span<uint> fbos, [Flow(FlowDirection.In)] uint count);

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
        public abstract unsafe void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

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
        public abstract void DrawCommandsStatesAddress([Flow(FlowDirection.In)] Span<ulong> indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] Span<uint> states, [Flow(FlowDirection.In)] Span<uint> fbos, [Flow(FlowDirection.In)] uint count);

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
        public abstract uint GetCommandHeader([Flow(FlowDirection.In)] NV tokenID, [Flow(FlowDirection.In)] uint size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetStageIndexNV")]
        public abstract ushort GetStageIndex([Flow(FlowDirection.In)] NV shadertype);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="list">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsCommandListNV")]
        public abstract bool IsCommandList([Flow(FlowDirection.In)] uint list);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="state">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsStateNV")]
        public abstract bool IsState([Flow(FlowDirection.In)] uint state);

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
        public abstract unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Flow(FlowDirection.In)] void** indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

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
        public abstract unsafe void ListDrawCommandsStatesClient<T0>([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Flow(FlowDirection.In)] void** indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] Span<uint> states, [Flow(FlowDirection.In)] Span<uint> fbos, [Flow(FlowDirection.In)] uint count) where T0 : unmanaged;

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
        public abstract void StateCapture([Flow(FlowDirection.In)] uint state, [Flow(FlowDirection.In)] NV mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetStageIndexNV")]
        public abstract ushort GetStageIndex([Flow(FlowDirection.In)] ShaderType shadertype);

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
        public unsafe void DeleteState([Count(Parameter = "n"), Flow(FlowDirection.In)] uint states)
        {
            // ArrayParameterOverloader
            DeleteStates(1, &states);
        }

        public NVCommandList(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

