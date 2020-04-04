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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_texture_object")]
    public abstract unsafe partial class ExtTextureObject : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAreTexturesResidentEXT")]
        public abstract unsafe bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAreTexturesResidentEXT")]
        public abstract bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindTextureEXT")]
        public abstract void BindTexture([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteTexturesEXT")]
        public abstract unsafe void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteTexturesEXT")]
        public abstract void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenTexturesEXT")]
        public abstract unsafe void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenTexturesEXT")]
        public abstract void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsTextureEXT")]
        public abstract bool IsTexture([Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT")]
        public abstract unsafe void PrioritizeTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* priorities);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPrioritizeTexturesEXT")]
        public abstract void PrioritizeTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> priorities);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindTextureEXT")]
        public abstract void BindTexture([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteTexture([Count(Parameter = "n"), Flow(FlowDirection.In)] uint textures)
        {
            // ArrayParameterOverloader
            DeleteTextures(1, &textures);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint GenTexture()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTextures(n, &ret);
            return ret;
        }

        public ExtTextureObject(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

