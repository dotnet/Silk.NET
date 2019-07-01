//
// AudioDeviceErrorChecker.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using Silk.NET.Core.Loader;
using Silk.NET.OpenAL.Interfaces;

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Represents an error watchdog that can be used by wrapping calls to OpenAL in it.
    /// </summary>
    public struct AudioDeviceErrorChecker : IDisposable
    {
        private static readonly IContextErrors ErrorAPI = LibraryLoader.Load<ALContext>(new OpenALLibraryNameContainer());
        private readonly unsafe Device* _device;

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDeviceErrorChecker"/> struct.
        /// </summary>
        /// <param name="device">The device to monitor.</param>
        public AudioDeviceErrorChecker(IntPtr device)
        {
            if (device == IntPtr.Zero)
            {
                throw new AudioDeviceException();
            }

            unsafe
            {
                _device = (Device*)device.ToPointer();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDeviceErrorChecker"/> struct.
        /// </summary>
        /// <param name="device">The device to monitor.</param>
        public unsafe AudioDeviceErrorChecker(Device* device)
            : this(new IntPtr(device))
        {
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            unsafe
            {
                var err = ErrorAPI.GetError(_device);

                if (err == ContextError.NoError)
                {
                    return;
                }

                var message = $"Device {new UIntPtr(_device).ToString()} reported {err}.";
                switch (err)
                {
                    case ContextError.OutOfMemory:
                    {
                        throw new OutOfMemoryException(message);
                    }

                    case ContextError.InvalidValue:
                    {
                        throw new AudioValueException(message);
                    }

                    case ContextError.InvalidDevice:
                    {
                        throw new AudioDeviceException(message);
                    }

                    case ContextError.InvalidContext:
                    {
                        throw new AudioContextException(message);
                    }
                }
            }
        }
    }
}
