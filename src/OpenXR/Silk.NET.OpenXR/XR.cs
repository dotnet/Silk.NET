using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using ExtensionAttribute = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public partial class XR
    {
        private Instance? _currentInstance;
        private ConcurrentDictionary<Instance, IVTable> _vTables = new();
        public Instance? CurrentInstance
        {
            get => _currentInstance;
            set => SwapVTable(_vTables.GetOrAdd((_currentInstance = value).GetValueOrDefault(), _ => CreateVTable()));
        }
        public static XR GetApi()
        {
            return new XR(CreateDefaultContext(new OpenXRLibraryNameContainer().GetLibraryNames()));
        }

        [Obsolete("Use IsInstanceExtensionPresent instead.", true)]
        public override bool IsExtensionPresent(string extension) => IsInstanceExtensionPresent(null, extension);
        private readonly HashSet<string> _cachedInstanceExtensions = new HashSet<string>();
        private readonly ReaderWriterLockSlim _cachedInstanceExtensionsLock = new ReaderWriterLockSlim();

        /// <summary>
        /// Attempts to load the given instance extension.
        /// </summary>
        /// <param name="layer">The layer name.</param>
        /// <param name="instance">The instance to load the extension from.</param>
        /// <param name="ext">The loaded instance extension, or null if load failed.</param>
        /// <typeparam name="T">The instance extension to load.</typeparam>
        /// <remarks>
        /// This function doesn't check that the extension is enabled - you will get an error later on if you attempt
        /// to call an extension function from an extension that isn't loaded.
        /// </remarks>
        /// <returns>Whether the extension is available and loaded.</returns>
#if NET5_0_OR_GREATER

        public bool TryGetInstanceExtension<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>(string? layer, Instance instance, out T ext) where T : NativeExtension<XR> =>
#else
        public bool TryGetInstanceExtension<T>(string? layer, Instance instance, out T ext) where T : NativeExtension<XR> =>
#endif
            !((ext = IsInstanceExtensionPresent(layer, ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? (T) Activator.CreateInstance
                    (typeof(T), new LamdaNativeContext(
                    x =>
                    {
                        PfnVoidFunction ptr = default;
                        var result = GetInstanceProcAddr(instance, x, ref ptr);
                        if (result != Result.Success)
                        {
                            throw new InvalidOperationException($"Symbol loading failed with XrResult {result}");
                        }

                        return ptr;
                    }))
                : null) is null);

        /// <summary>
        /// Checks whether the given instance extension is available.
        /// </summary>
        /// <param name="layer">The layer name.</param>
        /// <param name="extension">The instance extension name.</param>
        /// <returns>Whether the instance extension is available.</returns>
        public unsafe bool IsInstanceExtensionPresent(string? layer, string extension)
        {
            // For a detailed explanation of the logic see Silk.Net.Vulkan.Vk.IsDeviceExtensionPresent
            var layerSep = layer + '\0';
            var fullKey = layerSep + extension;
            var result = false;

            _cachedInstanceExtensionsLock.EnterUpgradeableReadLock();
            if (_cachedInstanceExtensions.Contains(fullKey))
            {
                // We found the extension
                result = true;
            }
            else if (!_cachedInstanceExtensions.Contains(layer))
            {
                // The lack of the device handle indicates we've not been previously initialised.  We now need a write lock.
                _cachedInstanceExtensionsLock.EnterWriteLock();
                GlobalMemory mem = null;
                var layerName = (byte*) SilkMarshal.StringToPtr(layer);
                try
                {
                    var extensionCount = 0u;
                    EnumerateInstanceExtensionProperties(layerName, extensionCount, &extensionCount, null);

                    mem = GlobalMemory.Allocate((int) extensionCount * sizeof(ExtensionProperties));
                    var exts = mem.AsPtr<ExtensionProperties>();

                    for (var i = 0; i < extensionCount; i++)
                    {
                        exts[i] = new(StructureType.TypeExtensionProperties);
                    }

                    EnumerateInstanceExtensionProperties(layerName, extensionCount, &extensionCount, exts);
                    for (var i = 0; i < extensionCount; i++)
                    {
                        var newKey = layerSep + Marshal.PtrToStringAnsi((nint) exts[i].ExtensionName);
                        _cachedInstanceExtensions.Add(newKey);
                        if (!result && string.Equals(newKey, fullKey))
                        {
                            result = true;
                        }
                    }
                }
                finally
                {
                    _cachedInstanceExtensionsLock.ExitWriteLock();
                    if (layerName != null)
                    {
                        SilkMarshal.Free((nint) layerName);
                    }

                    mem?.Dispose();
                }
            }

            _cachedInstanceExtensionsLock.ExitUpgradeableReadLock();
            return result;
        }

        protected override void PostInit() => _vTables.TryAdd(default, CurrentVTable);
    }
}

