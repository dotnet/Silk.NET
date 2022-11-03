// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.EXT
{
    /// <summary>
    /// Exposes the API in the Disconnect extension.
    /// </summary>
    [Extension("ALC_EXT_disconnect")]
    [NativeApi(Prefix = "alc")]
    public partial class Disconnect : ContextExtensionBase
    {
        /// <inheritdoc cref="ContextExtensionBase" />
        public Disconnect(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetIntegerv")]
        public unsafe partial void GetContextProperty(Device* device, DisconnectContextInteger param, int count, void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetIntegerv")]
        public unsafe partial void GetContextProperty(Device* device, DisconnectContextInteger param, int count, int* data);
    }
}
