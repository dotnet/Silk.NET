// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// Exposes the public API of functions added by OpenAL Soft.
    /// </summary>
    [NativeApi(Prefix = "al")]
    [Extension("AL_SOFT_source_resampler")]
    public partial class SoftSourceResampler : NativeExtension<AL>
    {
        /// <inheritdoc cref="ExtensionBase" />
        public SoftSourceResampler(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        public partial bool GetBoolean(SoftSourceResamplerBoolean param);

        /// <inheritdoc />
        public partial int GetInteger(SoftSourceResamplerInteger param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetStringiSOFT")]
        public partial string GetString(SoftSourceResamplerString param, int index);

        public IEnumerable<string> GetResamplers()
        {
            var numResamplers = GetInteger(SoftSourceResamplerInteger.ResamplerCount);
            for (var i = 0; i < numResamplers; i++)
            {
                yield return GetString(SoftSourceResamplerString.ResamplerName, i);
            }
        }
    }
}
