// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// Strings for the AL_SOFT_callback_buffer extension.
    /// </summary>
    public enum SoftBufferCallback
    {
        /// <summary>
        /// Query only. The function address for the callback currently
        /// set on the buffer, from the last call to alBufferCallbackSOFT. A call to
        /// alBufferData will reset this to NULL.
        /// </summary>
        Function  = 0x19A0,
        /// <summary>
        /// Query only. The user data pointer that will be passed to the
        /// callback, from the last call to alBufferCallbackSOFT. A call to
        /// alBufferData will reset this to NULL.
        /// </summary>
        UserParam = 0x19A1
    }
}
