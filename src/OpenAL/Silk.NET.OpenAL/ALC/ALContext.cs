// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics.CodeAnalysis;
using Silk.NET.Core.Attributes;
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
        private bool _soft;
        private SearchPathContainer? _searchPaths;

        /// <inheritdoc cref="NativeLibraryBase" />
        public ALContext(INativeContext ctx)
            : base(ctx)
        {
        }

        public SearchPathContainer SearchPaths => _searchPaths ??= new OpenALLibraryNameContainer(_soft);

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
        public unsafe partial void GetContextProperty(Device* device, GetContextInteger param, int count, nint data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetIntegerv")]
        public unsafe partial void GetContextProperty(Device* device, GetContextInteger param, int count, int* data);

        /// <summary>
        /// Gets an instance of the API.
        /// </summary>
        /// <param name="soft">Prefer OpenAL Soft libraries.</param>
        /// <returns>The instance.</returns>
        public static unsafe ALContext GetApi(bool soft = false)
        {
            SearchPathContainer searchPaths = new OpenALLibraryNameContainer(soft);
            var ctx = new MultiNativeContext
                (CreateDefaultContext(searchPaths.GetLibraryNames()), null);
            var ret = new ALContext(ctx);
            ret._soft = soft;
            ret._searchPaths = searchPaths;

            ctx.Contexts[1] = new LamdaNativeContext(
                x =>
                {
                    if (x.EndsWith("GetProcAddress") ||
                        x.EndsWith("GetContextsDevice") ||
                        x.EndsWith("GetCurrentContext"))
                    {
                        return default;
                    }

                    return (nint) ret.GetProcAddress(ret.GetContextsDevice(ret.GetCurrentContext()), x);
                });
            return ret;
        }

        /// <summary>
        /// Attempts to load the given extension.
        /// </summary>
        /// <typeparam name="T">The extension type.</typeparam>
        /// <param name="device">The device the context is on.</param>
        /// <param name="ext">The extension to check for.</param>
        /// <returns>Whether the extension is available.</returns>
#if NET5_0_OR_GREATER
        public unsafe bool TryGetExtension<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>(Device* device, out T ext) where T : NativeExtension<ALContext>
#else
        public unsafe bool TryGetExtension<T>(Device* device, out T ext) where T : NativeExtension<ALContext>
#endif
            => !((ext = IsExtensionPresent(device, ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? (T) Activator.CreateInstance(typeof(T), Context)
                : null) is null);

        /// <summary>
        /// Gets an instance of the API of an extension to the API.
        /// </summary>
        /// <typeparam name="TContextExtension">The extension type.</typeparam>
        /// <param name="device">The device the context is on.</param>
        /// <returns>The extension.</returns>
        [Obsolete
        (
            "This method has been deprecated and will be removed in Silk.NET 3.0. " +
            "Please use TryGetExtension instead."
        )]
        public unsafe TContextExtension GetExtension<TContextExtension>(Device* device)
            where TContextExtension : ContextExtensionBase
        {
            return ALExtensionLoader.LoadContextExtension<TContextExtension>(this);
        }

        /// <inheritdoc cref="CreateContext" />
        public unsafe nint CreateContextHandle(Device* device, int* attributeList)
        {
            return (nint)CreateContext(device, attributeList);
        }

        /// <inheritdoc cref="MakeContextCurrent(Context*)" />
        public bool MakeContextCurrent(nint context)
        {
            unsafe
            {
                return MakeContextCurrent((Context*) context);
            }
        }

        /// <inheritdoc cref="GetCurrentContext" />
        public nint GetCurrentContextHandle()
        {
            unsafe
            {
                return (nint)GetCurrentContext();
            }
        }
    }
}
