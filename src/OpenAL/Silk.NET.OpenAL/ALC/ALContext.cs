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

        public partial override bool IsExtensionPresent(string name);

        /// <inheritdoc />
        public partial unsafe Context* CreateContext(Device* device, int* attributeList);

        /// <inheritdoc />
        public partial unsafe bool MakeContextCurrent(Context* context);

        /// <inheritdoc />
        public partial unsafe void ProcessContext(Context* context);

        /// <inheritdoc />
        public partial unsafe void SuspendContext(Context* context);

        /// <inheritdoc />
        public partial unsafe void DestroyContext(Context* context);

        /// <inheritdoc />
        public partial unsafe Context* GetCurrentContext();

        /// <inheritdoc />
        public partial unsafe Device* GetContextsDevice(Context* context);

        /// <inheritdoc />
        public partial unsafe Device* OpenDevice(string deviceName);

        /// <inheritdoc />
        public partial unsafe bool CloseDevice(Device* device);

        /// <inheritdoc />
        public partial unsafe ContextError GetError(Device* device);

        /// <inheritdoc />
        public partial unsafe bool IsExtensionPresent(Device* device, string name);

        /// <inheritdoc />
        public partial unsafe void* GetProcAddress(Device* device, string name);

        /// <inheritdoc />
        public partial unsafe int GetEnumValue(Device* device, string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetString")]
        public partial unsafe string GetContextProperty(Device* device, GetContextString param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetIntegerv")]
        public partial unsafe void GetContextProperty(Device* device, GetContextInteger param, int count, IntPtr data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetIntegerv")]
        public partial unsafe void GetContextProperty(Device* device, GetContextInteger param, int count, int* data);

        /// <summary>
        /// Gets an instance of the API.
        /// </summary>
        /// <returns>The instance.</returns>
        public static ALContext GetApi()
        {
            var loader = new ALLoader();
            var ret = new ALContext(new DefaultNativeContext(new OpenALLibraryNameContainer().GetLibraryName(), loader));
            loader.Alc = ret;
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
            unsafe {
                return MakeContextCurrent((Context*) context);
            }
        }

        /// <inheritdoc cref="GetCurrentContext" />
        public IntPtr GetCurrentContextHandle()
        {
            unsafe {
                return new IntPtr(GetCurrentContext());
            }
        }
    }
}
