//
// ContextError.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Defines OpenAL context errors.
    /// </summary>
    public enum ContextError
    {
        /// <summary>
        /// There is no current error.
        /// </summary>
        NoError = 0,

        /// <summary>
        /// No Device. The device handle or specifier names an inaccessible driver/server.
        /// </summary>
        InvalidDevice = 0xA001,

        /// <summary>
        /// Invalid context ID. The Context argument does not name a valid context.
        /// </summary>
        InvalidContext = 0xA002,

        /// <summary>
        /// Bad enum. A token used is not valid, or not applicable.
        /// </summary>
        InvalidEnum = 0xA003,

        /// <summary>
        /// Bad value. A value (e.g. Attribute) is not valid, or not applicable.
        /// </summary>
        InvalidValue = 0xA004,

        /// <summary>
        /// Out of memory. Unable to allocate memory.
        /// </summary>
        OutOfMemory = 0xA005,
    }
}
