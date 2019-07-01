//
// XRam.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Buffers;
using System.ComponentModel;
using AdvancedDLSupport;
using OpenToolkit.Core.Extensions;
using OpenToolkit.Core.Loader;

// ReSharper disable VirtualMemberCallInConstructor
namespace OpenToolkit.OpenAL.Extensions.Creative.XRam
{
    /// <summary>
    /// Exposes the X-RAM extension by Creative Labs.
    /// </summary>
    [Extension("EAX-RAM")]
    public abstract class XRam : ExtensionBase, IXRam
    {
        private readonly int _bufferStorageModeAutomatic;
        private readonly int _bufferStorageModeHardware;
        private readonly int _bufferStorageModeAccessible;

        private readonly int _ramSize;
        private readonly int _ramFree;

        /// <inheritdoc cref="NativeLibraryBase"/>
        protected XRam(string path, ImplementationOptions options)
            : base(path, options)
        {
            _bufferStorageModeAutomatic = GetEnumValue("AL_STORAGE_AUTOMATIC");
            _bufferStorageModeHardware = GetEnumValue("AL_STORAGE_HARDWARE");
            _bufferStorageModeAccessible = GetEnumValue("AL_STORAGE_ACCESSIBLE");

            _ramSize = GetEnumValue("AL_EAX_RAM_SIZE");
            _ramFree = GetEnumValue("AL_EAX_RAM_FREE");
        }

        /// <inheritdoc cref="GetInteger(int)"/>
        public int GetInteger(XRamGetInteger param) => GetInteger(GetValueForEnum(param));

        /// <summary>
        /// Sets the storage mode of an array of OpenAL buffers.
        /// </summary>
        /// <param name="count">The number of buffers pointed to by <paramref name="buffers"/>.</param>
        /// <param name="buffers">An array of OpenAL buffer handles.</param>
        /// <param name="mode">The storage mode that should be used for all the given buffers.</param>
        /// <returns>
        /// true if all buffers were successfully set to the requested storage mode; otherwise, false.
        /// </returns>
        /// <seealso cref="GetBufferMode(uint)"/>
        public bool SetBufferMode(int count, in uint[] buffers, BufferStorageMode mode)
        {
            return SetBufferMode(count, in buffers, GetValueForEnum(mode));
        }

        /// <summary>
        /// Sets the storage mode of an OpenAL buffer.
        /// </summary>
        /// <param name="buffer">The buffer handle.</param>
        /// <param name="mode">The storage mode that should be used for the buffer.</param>
        /// <returns>
        /// true if the buffer was successfully set to the requested storage mode; otherwise, false.
        /// </returns>
        /// <seealso cref="GetBufferMode(uint)"/>
        public bool SetBufferMode(uint buffer, BufferStorageMode mode)
        {
            var pool = ArrayPool<uint>.Shared;
            var buffers = pool.Rent(1);
            buffers[0] = buffer;

            try
            {
                return SetBufferMode(1, in buffers, mode);
            }
            finally
            {
                pool.Return(buffers, true);
            }
        }

        /// <summary>
        /// Sets the storage mode of a set of OpenAL buffers.
        /// </summary>
        /// <param name="mode">The storage mode that should be used for all the given buffers.</param>
        /// <param name="buffers">An array of OpenAL buffer handles.</param>
        /// <returns>
        /// true if all buffers were successfully set to the requested storage mode; otherwise, false.
        /// </returns>
        /// <seealso cref="GetBufferMode(uint)"/>
        public bool SetBufferMode(BufferStorageMode mode, params uint[] buffers)
        {
            return SetBufferMode(buffers.Length, in buffers, mode);
        }

        /// <inheritdoc cref="GetBufferMode(uint, IntPtr)"/>
        public BufferStorageMode GetBufferMode(uint buffer) => GetEnumForValue(GetBufferMode(buffer, IntPtr.Zero));

        /// <inheritdoc />
        public abstract int GetInteger(int param);

        /// <inheritdoc />
        public abstract bool SetBufferMode(int count, in uint[] buffers, int mode);

        /// <inheritdoc />
        public abstract int GetBufferMode(uint buffer, IntPtr reserved);

        /// <summary>
        /// Gets the actual value as defined in OpenAL for the given enum member.
        /// </summary>
        /// <param name="param">The enum.</param>
        /// <returns>The value.</returns>
        /// <exception cref="InvalidEnumArgumentException">Thrown if the enum is not valid.</exception>
        private int GetValueForEnum(XRamGetInteger param)
        {
            switch (param)
            {
                case XRamGetInteger.RamSize:
                {
                    return _ramSize;
                }

                case XRamGetInteger.FreeRam:
                {
                    return _ramFree;
                }

                default:
                {
                    throw new InvalidEnumArgumentException(nameof(param), (int)param, typeof(XRamGetInteger));
                }
            }
        }

        /// <summary>
        /// Gets the actual value as defined in OpenAL for the given enum member.
        /// </summary>
        /// <param name="mode">The enum.</param>
        /// <returns>The value.</returns>
        /// <exception cref="InvalidEnumArgumentException">Thrown if the enum is not valid.</exception>
        private int GetValueForEnum(BufferStorageMode mode)
        {
            switch (mode)
            {
                case BufferStorageMode.Automatic:
                {
                    return _bufferStorageModeAutomatic;
                }

                case BufferStorageMode.Hardware:
                {
                    return _bufferStorageModeHardware;
                }

                case BufferStorageMode.Accessible:
                {
                    return _bufferStorageModeAccessible;
                }

                default:
                {
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, typeof(BufferStorageMode));
                }
            }
        }

        /// <summary>
        /// Gets the abstracted enum value for the given OpenAL value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The enum.</returns>
        /// <exception cref="InvalidEnumArgumentException">Thrown if the value is not valid.</exception>
        private BufferStorageMode GetEnumForValue(int value)
        {
            if (value == _bufferStorageModeAutomatic)
            {
                return BufferStorageMode.Automatic;
            }

            if (value == _bufferStorageModeHardware)
            {
                return BufferStorageMode.Hardware;
            }

            if (value == _bufferStorageModeAccessible)
            {
                return BufferStorageMode.Accessible;
            }

            throw new InvalidEnumArgumentException(nameof(value), value, typeof(BufferStorageMode));
        }
    }
}
