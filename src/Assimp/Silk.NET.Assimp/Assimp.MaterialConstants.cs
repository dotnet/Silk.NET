// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
/*
* Copyright (c) 2012-2014 AssimpNet - Nicholas Woodfield
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

using System;

namespace Silk.NET.Assimp
{
    public partial class Assimp
    {
        /// <summary>
        /// Material name (String)
        /// </summary>
        public const string MaterialNameBase = "?mat.name";

        /// <summary>
        /// Material name (String)
        /// </summary>
        public const string MaterialName = "?mat.name,0,0";

        /// <summary>
        /// Two sided property (boolean)
        /// </summary>
        public const string MaterialTwosidedBase = "$mat.twosided";

        /// <summary>
        /// Two sided property (boolean)
        /// </summary>
        public const string MaterialTwosided = "$mat.twosided,0,0";

        /// <summary>
        /// Shading mode property (ShadingMode)
        /// </summary>
        public const string MaterialShadingModelBase = "$mat.shadingm";

        /// <summary>
        /// Shading mode property (ShadingMode)
        /// </summary>
        public const string MaterialShadingModel = "$mat.shadingm,0,0";

        /// <summary>
        /// Enable wireframe property (boolean)
        /// </summary>
        public const string MaterialEnableWireframeBase = "$mat.wireframe";

        /// <summary>
        /// Enable wireframe property (boolean)
        /// </summary>
        public const string MaterialEnableWireframe = "$mat.wireframe,0,0";

        /// <summary>
        /// Blending function (BlendMode)
        /// </summary>
        public const string MaterialBlendFuncBase = "$mat.blend";

        /// <summary>
        /// Blending function (BlendMode)
        /// </summary>
        public const string MaterialBlendFunc = "$mat.blend,0,0";

        /// <summary>
        /// Opacity (float)
        /// </summary>
        public const string MaterialOpacityBase = "$mat.opacity";

        /// <summary>
        /// Opacity (float)
        /// </summary>
        public const string MaterialOpacity = "$mat.opacity,0,0";

        /// <summary>
        /// Bumpscaling (float)
        /// </summary>
        public const string MaterialBumpscalingBase = "$mat.bumpscaling";

        /// <summary>
        /// Bumpscaling (float)
        /// </summary>
        public const string MaterialBumpscaling = "$mat.bumpscaling,0,0";

        /// <summary>
        /// Shininess (float)
        /// </summary>
        public const string MaterialShininessBase = "$mat.shininess";

        /// <summary>
        /// Shininess (float)
        /// </summary>
        public const string MaterialShininess = "$mat.shininess,0,0";

        /// <summary>
        /// Reflectivity (float)
        /// </summary>
        public const string MaterialReflectivityBase = "$mat.reflectivity";

        /// <summary>
        /// Reflectivity (float)
        /// </summary>
        public const string MaterialReflectivity = "$mat.reflectivity,0,0";

        /// <summary>
        /// Shininess strength (float)
        /// </summary>
        public const string MaterialShininessStrengthBase = "$mat.shinpercent";

        /// <summary>
        /// Shininess strength (float)
        /// </summary>
        public const string MaterialShininessStrength = "$mat.shinpercent,0,0";

        /// <summary>
        /// Refracti (float)
        /// </summary>
        public const string MaterialRefractiBase = "$mat.refracti";

        /// <summary>
        /// Refracti (float)
        /// </summary>
        public const string MaterialRefracti = "$mat.refracti,0,0";

        /// <summary>
        /// Diffuse color (Color4D)
        /// </summary>
        public const string MaterialColorDiffuseBase = "$clr.diffuse";

        /// <summary>
        /// Diffuse color (Color4D)
        /// </summary>
        public const string MaterialColorDiffuse = "$clr.diffuse,0,0";

        /// <summary>
        /// Ambient color (Color4D)
        /// </summary>
        public const string MaterialColorAmbientBase = "$clr.ambient";

        /// <summary>
        /// Ambient color (Color4D)
        /// </summary>
        public const string MaterialColorAmbient = "$clr.ambient,0,0";

        /// <summary>
        /// Specular color (Color4D)
        /// </summary>
        public const string MaterialColorSpecularBase = "$clr.specular";

        /// <summary>
        /// Specular color (Color4D)
        /// </summary>
        public const string MaterialColorSpecular = "$clr.specular,0,0";

        /// <summary>
        /// Emissive color (Color4D)
        /// </summary>
        public const string MaterialColorEmissiveBase = "$clr.emissive";

        /// <summary>
        /// Emissive color (Color4D)
        /// </summary>
        public const string MaterialColorEmissive = "$clr.emissive,0,0";

        /// <summary>
        /// Transparent color (Color4D)
        /// </summary>
        public const string MaterialColorTransparentBase = "$clr.transparent";

        /// <summary>
        /// Transparent color (Color4D)
        /// </summary>
        public const string MaterialColorTransparent = "$clr.transparent,0,0";

        /// <summary>
        /// Reflective color (Color4D)
        /// </summary>
        public const string MaterialColorReflectiveBase = "$clr.reflective";

        /// <summary>
        /// Reflective color (Color4D)
        /// </summary>
        public const string MaterialColorReflective = "$clr.reflective,0,0";

        /// <summary>
        /// Background image (String)
        /// </summary>
        public const string MaterialGlobalBackgroundImageBase = "?bg.global";

        /// <summary>
        /// Background image (String)
        /// </summary>
        public const string MaterialGlobalBackgroundImage = "?bg.global,0,0";

        /// <summary>
        /// Texture base name
        /// </summary>
        public const string MaterialTextureBase = "$tex.file";

        /// <summary>
        /// UVWSRC base name
        /// </summary>
        public const string MaterialUvwsrcBase = "$tex.uvwsrc";

        /// <summary>
        /// Texture op base name
        /// </summary>
        public const string MaterialTexopBase = "$tex.op";

        /// <summary>
        /// Mapping base name
        /// </summary>
        public const string MaterialMappingBase = "$tex.mapping";

        /// <summary>
        /// Texture blend base name.
        /// </summary>
        public const string MaterialTexblendBase = "$tex.blend";

        /// <summary>
        /// Mapping mode U base name
        /// </summary>
        public const string MaterialMappingmodeUBase = "$tex.mapmodeu";

        /// <summary>
        /// Mapping mode V base name
        /// </summary>
        public const string MaterialMappingmodeVBase = "$tex.mapmodev";

        /// <summary>
        /// Texture map axis base name
        /// </summary>
        public const string MaterialTexmapAxisBase = "$tex.mapaxis";

        /// <summary>
        /// UV transform base name
        /// </summary>
        public const string MaterialUvtransformBase = "$tex.uvtrafo";

        /// <summary>
        /// Texture flags base name
        /// </summary>
        public const string MaterialTexflagsBase = "$tex.flags";

        /// <summary>
        /// Helper function to get the fully qualified name of a texture property type name. Takes
        /// in a base name constant, a texture type, and a texture index and outputs the name in the format:
        /// <para>"baseName,TextureType,texIndex"</para>
        /// </summary>
        /// <param name="baseName">Base name</param>
        /// <param name="texType">Texture type</param>
        /// <param name="texIndex">Texture index</param>
        /// <returns>Fully qualified texture name</returns>
        public static string GetFullMaterialPropertyName(string baseName, TextureType texType, int texIndex)
        {
            return string.Format("{0},{1},{2}", baseName, (int) texType, texIndex);
        }

        /// <summary>
        /// Helper function to get the base name from a fully qualified name of a material property type name. The format
        /// of such a string is:
        /// <para>"baseName,TextureType,texIndex"</para>
        /// </summary>
        /// <param name="fullyQualifiedName">Fully qualified material property name.</param>
        /// <returns>Base name of the property type.</returns>
        public static string GetBaseName(string fullyQualifiedName)
        {
            if(string.IsNullOrEmpty(fullyQualifiedName))
                return string.Empty;

            string[] substrings = fullyQualifiedName.Split(',');
            if(substrings.Length == 3)
                return substrings[0];

            return fullyQualifiedName;
        }
    }
}
