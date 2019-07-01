//
// FormantFilterSettings.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// Vocal morpher effect parameters. If both parameters are set to the same phoneme, that determines the filtering
    /// effect that will be heard. If these two parameters are set to different phonemes, the filtering effect will morph
    /// between the two settings at a rate specified by EfxEffectf.VocalMorpherRate.
    /// </summary>
    public enum FormantFilterSettings
    {
        /// <summary>
        /// The A phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeA = 0,

        /// <summary>
        /// The E phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeE = 1,

        /// <summary>
        /// The I phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeI = 2,

        /// <summary>
        /// The O phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeO = 3,

        /// <summary>
        /// The U phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeU = 4,

        /// <summary>
        /// The AA phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeAA = 5,

        /// <summary>
        /// The AE phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeAE = 6,

        /// <summary>
        /// The AH phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeAH = 7,

        /// <summary>
        /// The AO phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeAO = 8,

        /// <summary>
        /// The EH phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeEH = 9,

        /// <summary>
        /// The ER phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeER = 10,

        /// <summary>
        /// The IH phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeIH = 11,

        /// <summary>
        /// The IY phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeIY = 12,

        /// <summary>
        /// The UH phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeUH = 13,

        /// <summary>
        /// The UW phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeUW = 14,

        /// <summary>
        /// The B phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeB = 15,

        /// <summary>
        /// The D phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeD = 16,

        /// <summary>
        /// The F phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeF = 17,

        /// <summary>
        /// The G phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeG = 18,

        /// <summary>
        /// The J phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeJ = 19,

        /// <summary>
        /// The K phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeK = 20,

        /// <summary>
        /// The L phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeL = 21,

        /// <summary>
        /// The M phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeM = 22,

        /// <summary>
        /// The N phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeN = 23,

        /// <summary>
        /// The P phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeP = 24,

        /// <summary>
        /// The R phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeR = 25,

        /// <summary>
        /// The S phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeS = 26,

        /// <summary>
        /// The T phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeT = 27,

        /// <summary>
        /// The V phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeV = 28,

        /// <summary>
        /// The Z phoneme of the vocal morpher.
        /// </summary>
        VocalMorpherPhonemeZ = 29,
    }
}
