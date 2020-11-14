// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.OpenAL.Extensions;

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Provides access to the OpenAL 1.1 context API.
    /// </summary>
    [NativeApi(Prefix = "alc")]
    public partial class ALContext : NativeAPI
    {
        /// <inheritdoc cref="NativeLibraryBase" />
        protected ALContext(INativeContext ctx)
            : base(ctx)
        {
        }

        public SearchPathContainer SearchPaths { get; } = new OpenALLibraryNameContainer();

        public partial bool IsExtensionPresent(Device* device, string name);

        public override unsafe bool IsExtensionPresent(string name)
            => IsExtensionPresent(GetContextsDevice(GetCurrentContext()), name);

        /// <inheritdoc />
        public unsafe partial Context* CreateContext(Device* device, int* attributeList);

        /// <inheritdoc />
        public unsafe partial bool MakeContextCurrent(Context* context);

        /// <inheritdoc />
        public unsafe partial void ProcessContext(Context* context);

        /// <inheritdoc />
        public unsafe partial void SuspendContext(Context* context);

        /// <inheritdoc />
        public unsafe partial void DestroyContext(Context* context);

        /// <inheritdoc />
        public unsafe partial Context* GetCurrentContext();

        /// <inheritdoc />
        public unsafe partial Device* GetContextsDevice(Context* context);

        /// <inheritdoc />
        public unsafe partial Device* OpenDevice(string deviceName);

        /// <inheritdoc />
        public unsafe partial bool CloseDevice(Device* device);

        /// <inheritdoc />
        public unsafe partial ContextError GetError(Device* device);

        /// <inheritdoc />
        public unsafe partial bool IsExtensionPresent(Device* device, string name);

        /// <inheritdoc />
        public unsafe partial void* GetProcAddress(Device* device, string name);

        /// <inheritdoc />
        public unsafe partial int GetEnumValue(Device* device, string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetString")]
        public unsafe partial string GetContextProperty(Device* device, GetContextString param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetIntegerv")]
        public unsafe partial void GetContextProperty(Device* device, GetContextInteger param, int count, IntPtr data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetIntegerv")]
        public unsafe partial void GetContextProperty(Device* device, GetContextInteger param, int count, int* data);

        /// <summary>
        /// Gets an instance of the API.
        /// </summary>
        /// <returns>The instance.</returns>
        public static unsafe ALContext GetApi()
        {
            var ctx = new MultiNativeContext
                (CreateDefaultContext(new OpenALLibraryNameContainer().GetLibraryName()), null);
            var ret = new ALContext(ctx);
            ctx.Contexts[1] = new LamdaNativeContext(
                x =>
                {
                    if (x.EndsWith("GetProcAddress") ||
                        x.EndsWith("GetContextsDevice") ||
                        x.EndsWith("GetCurrentContext"))
                    {
                        return default;
                    }

                    return (IntPtr) ret.GetProcAddress(ret.GetContextsDevice(ret.GetCurrentContext()), x);
                });
            return ret;
        }

        /// <summary>
        /// Gets an instance of the API of an extension to the API.
        /// </summary>
        /// <typeparam name="TContextExtension">The extension type.</typeparam>
        /// <param name="device">The device the context is on.</param>
        /// <returns>The extension.</returns>
        public unsafe TContextExtension GetExtension<TContextExtension>(Device* device)
            where TContextExtension : ContextExtensionBase
        {
            return ALExtensionLoader.LoadContextExtension<TContextExtension>(this);
        }

        /// <inheritdoc cref="CreateContext" />
        public unsafe IntPtr CreateContextHandle(Device* device, int* attributeList)
        {
            return new IntPtr(CreateContext(device, attributeList));
        }

        /// <inheritdoc cref="MakeContextCurrent(Context*)" />
        public bool MakeContextCurrent(IntPtr context)
        {
            unsafe
            {
                return MakeContextCurrent((Context*) context);
            }
        }

        /// <inheritdoc cref="GetCurrentContext" />
        public IntPtr GetCurrentContextHandle()
        {
            unsafe
            {
                return new IntPtr(GetCurrentContext());
            }
        }
    }
}
