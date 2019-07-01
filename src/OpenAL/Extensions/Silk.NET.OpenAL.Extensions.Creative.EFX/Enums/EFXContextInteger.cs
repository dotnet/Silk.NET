//
// EFXContextInteger.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// Defines new integer properties on the OpenAL context.
    /// </summary>
    public enum EFXContextInteger
    {
        /// <summary>
        /// This property can be used by the application to retrieve the Major version number of the
        /// Effects Extension supported by this OpenAL implementation. As this is a Context property is should be
        /// retrieved using alcGetIntegerv.
        /// </summary>
        EFXMajorVersion = 0x20001,

        /// <summary>
        /// This property can be used by the application to retrieve the Minor version number of the
        /// Effects Extension supported by this OpenAL implementation. As this is a Context property is should be
        /// retrieved using alcGetIntegerv.
        /// </summary>
        EFXMinorVersion = 0x20002,

        /// <summary>
        /// Default: 2
        ///
        /// This Context property can be passed to OpenAL during Context creation (alcCreateContext) to
        /// request a maximum number of Auxiliary Sends desired on each Source. It is not guaranteed that the desired
        /// number of sends will be available, so an application should query this property after creating the context
        /// using alcGetIntergerv.
        /// </summary>
        MaxAuxiliarySends = 0x20003,
    }
}
