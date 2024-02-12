// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// Exposes the public API of the OpenAL Soft Reopen Device extension.
    /// </summary>
    [NativeApi(Prefix = "alc")]
    [Extension("ALC_SOFT_reopen_device")]
    public partial class ReopenDevices : ContextExtensionBase
    {
        /// <inheritdoc cref="ContextExtensionBase" />
        public ReopenDevices(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        [NativeApi(EntryPoint = "ReopenDeviceSOFT")]
        public unsafe partial bool ReopenDevice(Device* device, string deviceName, int* attributeList);
    }
}
