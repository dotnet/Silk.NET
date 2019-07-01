//
// EFXSourceBoolean.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// A list of valid <see cref="bool"/> Source/GetSource parameters.
    /// </summary>
    public enum EFXSourceBoolean
    {
        /// <summary>
        /// Default: True
        ///
        /// If this Source property is set to True, this Source’s direct-path is automatically filtered
        /// according to the orientation of the source relative to the listener and the setting of the Source property
        /// Sourcef.ConeOuterGainHF.
        /// </summary>
        DirectFilterGainHighFrequencyAuto = 0x2000A,

        /// <summary>
        /// Default: True
        ///
        /// If this Source property is set to True, the intensity of this Source’s reflected sound is
        /// automatically attenuated according to source-listener distance and source directivity (as determined by the cone
        /// parameters). If it is False, the reflected sound is not attenuated according to distance and directivity.
        /// </summary>
        AuxiliarySendFilterGainAuto = 0x2000B,

        /// <summary>
        /// Default: True
        ///
        /// If this Source property is AL_TRUE (its default value), the intensity of this Source’s
        /// reflected sound at high frequencies will be automatically attenuated according to the high-frequency source
        /// directivity as set by the Sourcef.ConeOuterGainHF property. If this property is AL_FALSE, the Source’s reflected
        /// sound is not filtered at all according to the Source’s directivity.
        /// </summary>
        AuxiliarySendFilterGainHighFrequencyAuto = 0x2000C,
    }
}
