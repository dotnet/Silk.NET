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
    /// <summary>
    /// Post processing flag options, specifying a number of steps
    /// that can be run on the data to either generate additional vertex
    /// data or optimize the imported data.
    /// </summary>
    [Flags]
    public enum PostProcessSteps : uint
    {
        /// <summary>
        /// No flags enabled.
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Calculates the tangents and binormals (bitangents)
        /// for the imported meshes.
        /// <para>
        /// This does nothing if a mesh does not have normals. You might
        /// want this post processing step to be executed if you plan
        /// to use tangent space calculations such as normal mapping. There is a
        /// config setting AI_CONFIG_PP_CT_MAX_SMOOTHING_ANGLE which
        /// allows you to specify a maximimum smoothing angle for the algorithm.
        /// However, usually you'll want to leave it at the default value.
        /// </para>
        /// </summary>
        CalculateTangentSpace = 0x1,

        /// <summary>
        /// Identifies and joins identical vertex data sets within all
        /// imported meshes.
        /// <para>
        /// After this step is run each mesh does contain only unique vertices
        /// anymore, so a vertex is possibly used by multiple faces. You usually
        /// want to use this post processing step. If your application deals with
        /// indexed geometry, this step is compulsory or you'll just waste rendering
        /// time.</para>
        /// <para>If this flag is not specified, no vertices are referenced by more than one
        /// face and no index buffer is required for rendering.</para>
        /// </summary>
        JoinIdenticalVertices = 0x2,

        /// <summary>
        /// Converts all imported data to a left handed coordinate space.
        /// 
        /// <para>By default the data is returned in a right-handed coordinate space,
        /// where +X points to the right, +Z towards the viewer, and +Y upwards.</para>
        /// </summary>
        MakeLeftHanded = 0x4,

        /// <summary>
        /// Triangulates all faces of all meshes.
        /// <para>
        /// By default the imported mesh data might contain faces with more than 
        /// three indices. For rendering you'll usually want all faces to
        /// be triangles. This post processing step splits up all
        /// higher faces to triangles. Line and point primitives are *not*
        /// modified. If you want 'triangles only' with no other kinds of primitives,
        /// try the following:
        /// </para>
        /// <list type="number">
        /// <item>
        /// <description>Specify both <see cref="PostProcessSteps.Triangulate"/> and <see cref="PostProcessSteps.SortByPrimitiveType"/>.</description>
        /// </item>
        /// <item>
        /// <description>Ignore all point and line meshes when you process Assimp's output</description>
        /// </item>
        /// </list>
        /// </summary>
        Triangulate = 0x8,

        /// <summary>
        /// Removes some parts of the data structure (animations, materials,
        /// light sources, cameras, textures, vertex components).
        /// <para>
        /// The components to be removed are specified in a separate configuration
        /// option, AI_CONFIG_PP_RVC_FLAGS. This is quite useful if you don't
        /// need all parts of the output structure. Especially vertex colors are rarely used today...calling this step to remove
        /// unrequired stuff from the pipeline as early as possible results in an increased
        /// performance and a better optimized output data structure.
        /// </para>
        /// <para>
        /// This step is also useful if you want to force Assimp to recompute normals
        /// or tangents. the corresponding steps don't recompute them if they're already
        /// there (loaded from the source asset). By using this step you can make sure
        /// they are NOT there.</para>
        /// </summary>
        RemoveComponent = 0x10,

        /// <summary>
        /// Generates normals for all faces of all meshes. It may not be
        /// specified together with <see cref="PostProcessSteps.GenerateSmoothNormals"/>.
        /// <para>
        /// This is ignored if normals are already there at the time where this
        /// flag is evaluated. Model importers try to load them from the source file,
        /// so they're usually already there. Face normals are shared between all
        /// points of a single face, so a single point can have multiple normals,
        /// which in other words, forces the library to duplicate vertices in
        /// some cases. This makes <see cref="PostProcessSteps.JoinIdenticalVertices"/> senseless then.
        /// </para>
        /// </summary>
        GenerateNormals = 0x20,

        /// <summary>
        /// Generates smooth normals for all vertices of all meshes. It
        /// may not be specified together with <see cref="PostProcessSteps.GenerateNormals"/>.
        /// <para>
        /// This is ignored if normals are already there at the time where
        /// this flag is evaluated. Model importers try to load them from the
        /// source file, so they're usually already there.
        /// </para>
        /// <para>The configuration option AI_CONFIG_PP_GSN_MAX_SMOOTHING_ANGLE
        /// allows you to specify an angle maximum for the normal smoothing algorithm.
        /// Normals exceeding this limit are not smoothed, resulting in a 'hard' seam
        /// between two faces. using a decent angle here (e.g. 80 degrees) results in a very good visual
        /// appearance.</para>
        /// </summary>
        GenerateSmoothNormals = 0x40,

        /// <summary>
        /// Splits large meshes into smaller submeshes.
        /// <para>
        /// This is useful for realtime rendering where the number
        /// of triangles which can be maximally processed in a single draw call is
        /// usually limited by the video driver/hardware. The maximum vertex buffer
        /// is usually limited, too. Both requirements can be met with this step:
        /// you may specify both a triangle and a vertex limit for a single mesh.
        /// </para>
        /// <para>The split limits can be set through the AI_CONFIG_PP_SLM_VERTEX_LIMIT
        /// and AI_CONFIG_PP_SLM_TRIANGLE_LIMIT config settings. The default
        /// values are 1,000,000.</para>
        /// 
        /// <para>Warning: This can be a time consuming task.</para>
        /// </summary>
        SplitLargeMeshes = 0x80,

        /// <summary>
        /// Removes the node graph and "bakes" (pre-transforms) all
        /// vertices with the local transformation matrices of their nodes.
        /// The output scene does still contain nodes, however, there is only
        /// a root node with children, each one referencing only one mesh. 
        /// Each mesh referencing one material. For rendering, you can simply render
        /// all meshes in order, you don't need to pay attention to local transformations
        /// and the node hierarchy.
        /// 
        /// <para>Warning: Animations are removed during this step.</para>
        /// </summary>
        PreTransformVertices = 0x100,

        /// <summary>
        /// Limits the number of bones simultaneously affecting a single
        /// vertex to a maximum value.
        /// <para>
        /// If any vertex is affected by more than that number of bones,
        /// the least important vertex weights are removed and the remaining vertex
        /// weights are re-normalized so that the weights still sum up to 1.
        /// </para>
        /// <para>The default bone weight limit is 4 and uses the
        /// AI_LMW_MAX_WEIGHTS config. If you intend to perform the skinning in hardware, this post processing
        /// step might be of interest for you.</para>
        /// </summary>
        LimitBoneWeights = 0x200,

        /// <summary>
        /// Validates the imported scene data structure.
        /// <para>
        /// This makes sure that all indices are valid, all animations
        /// and bones are linked correctly, all material references are
        /// correct, etc.
        /// </para>
        /// It is recommended to capture Assimp's log output if you use this flag,
        /// so you can easily find out what's actually wrong if a file fails the
        /// validation. The validator is quite rude and will find *all* inconsistencies
        /// in the data structure. There are two types of failures:
        /// <list type="bullet">
        /// <item>
        /// <description>Error: There's something wrong with the imported data. Further
        /// postprocessing is not possible and the data is not usable at all. The import
        /// fails.</description>
        /// </item>
        /// <item>
        /// <description>Warning: There are some minor issues (e.g. 1000000 animation keyframes
        /// with the same time), but further postprocessing and use of the data structure is still
        /// safe. Warning details are written to the log file.</description>
        /// </item>
        /// </list>
        /// </summary>
        ValidateDataStructure = 0x400,

        /// <summary>
        /// Re-orders triangles for better vertex cache locality.
        /// 
        /// <para>This step tries to improve the ACMR (average post-transform vertex cache
        /// miss ratio) for all meshes. The implementation runs in O(n) time 
        /// and is roughly based on the <a href="http://www.cs.princeton.edu/gfx/pubs/Sander_2007_%3ETR/tipsy.pdf">'tipsify' algorithm</a>.</para>
        /// 
        /// <para>If you intend to render huge models in hardware, this step might be of interest for you.
        /// The AI_CONFIG_PP_ICL_PTCACHE_SIZE config setting can be used to fine tune
        /// the cache optimization.</para>
        /// </summary>
        ImproveCacheLocality = 0x800,

        /// <summary>
        /// Searches for redundant/unreferenced materials and removes them.
        /// <para>
        /// This is especially useful in combination with the  PreTransformVertices
        /// and OptimizeMeshes flags. Both join small meshes with equal characteristics, but
        /// they can't do their work if two meshes have different materials. Because several
        /// material settings are always lost during Assimp's import filders and because many
        /// exporters don't check for redundant materials, huge models often have materials which
        /// are defined several times with exactly the same settings.
        /// </para>
        /// <para>Several material settings not contributing to the final appearance of a surface
        /// are ignored in all comparisons ... the material name is one of them. So, if you're passing
        /// additional information through the content pipeline (probably using *magic* material names),
        /// don't specify this flag. Alternatively, take a look at the AI_CONFIG_PP_RRM_EXCLUDE_LIST
        /// setting.</para>
        /// </summary>
        RemoveRedundantMaterials = 0x1000,

        /// <summary>
        /// This step tries to determine which meshes have normal vectors
        /// that are facing inwards. 
        /// <para>
        /// The algorithm is simple but effective:
        /// </para>
        /// <para>The bounding box of all vertices and their normals are compared
        /// against the volume of the bounding box of all vertices without their normals.
        /// This works well for most objects, problems might occur with planar surfaces. However,
        /// the step tries to filter such cases. The step inverts all in-facing normals.
        /// Generally, it is recommended to enable this step, although the result is not
        /// always correct.</para>
        /// </summary>
        FixInFacingNormals = 0x2000,

        /// <summary>
        /// This step splits meshes with more than one primitive type in homogeneous submeshes.
        /// <para>
        /// This step is executed after triangulation and after it returns, just one
        /// bit is set in aiMesh:mPrimitiveTypes. This is especially useful for real-time
        /// rendering where point and line primitives are often ignored or rendered separately.
        /// </para>
        /// <para>
        /// You can use AI_CONFIG_PP_SBP_REMOVE option to specify which primitive types you need.
        /// This can be used to easily exclude lines and points, which are rarely used,
        /// from the import.
        /// </para>
        /// </summary>
        SortByPrimitiveType = 0x8000,

        /// <summary>
        /// This step searches all meshes for degenerated primitives and
        /// converts them to proper lines or points. A face is 'degenerated' if one or more of its points are identical.
        /// <para>
        /// To have degenerated primitives removed, specify the <see cref="PostProcessSteps.FindDegenerates"/> flag
        /// try one of the following procedures:
        /// </para>
        /// <list type="numbers">
        /// <item>
        /// <description>To support lines and points: Set the
        /// AI_CONFIG_PP_FD_REMOVE option to one. This will cause the step to remove degenerated triangles as
        /// soon as they are detected. They won't pass any further pipeline steps.</description>
        /// </item>
        /// <item>
        /// <description>If you don't support lines and points: Specify <see cref="PostProcessSteps.SortByPrimitiveType"/> flag, which
        /// will move line and point primitives to separate meshes.  Then set the AI_CONFIG_PP_SBP_REMOVE
        /// option to <see cref="Point"/> and <see cref="PrimitiveType.Line"/> to cause <see cref="PostProcessSteps.SortByPrimitiveType"/> step
        /// to reject point and line meshes from the scene.</description>
        /// </item>
        /// </list>
        /// <para>
        /// Degenerated polygons are not necessarily evil and that's why they are not removed by default. There are several
        /// file formats which do not support lines or points where exporters bypass the format specification and write
        /// them as degenerated triangles instead.
        /// </para>
        /// </summary>
        FindDegenerates = 0x10000,

        /// <summary>
        /// This step searches all meshes for invalid data, such as zeroed
        /// normal vectors or invalid UV coordinates and removes or fixes them.
        /// This is intended to get rid of some common exporter rrors.
        /// <para>
        /// This is especially useful for normals. If they are invalid,
        /// and the step recognizes this, they will be removed and can later
        /// be recomputed, e.g. by the GenerateSmoothNormals flag. The step
        /// will also remove meshes that are infinitely small and reduce animation
        /// tracks consisting of hundreds of redundant keys to a single key. The
        /// AI_CONFIG_PP_FID_ANIM_ACCURACY config property decides the accuracy of the check
        /// for duplicate animation tracks.</para>
        /// </summary>
        FindInvalidData = 0x20000,

        /// <summary>
        /// This step converts non-UV mappings (such as spherical or
        /// cylindrical mapping) to proper texture coordinate channels.
        /// 
        /// <para>Most applications will support UV mapping only, so you will
        /// probably want to specify this step in every case. Note that Assimp
        /// is not always able to match the original mapping implementation of the 3D
        /// app which produced a model perfectly. It's always better
        /// to let the father app compute the UV channels, at least 3DS max, maya, blender,
        /// lightwave, modo, .... are able to achieve this.</para>
        /// 
        /// <para>If this step is not requested, you'll need to process the MATKEY_MAPPING
        /// material property in order to display all assets properly.</para>
        /// </summary>
        GenerateUVCoords = 0x40000,

        /// <summary>
        /// Applies per-texture UV transformations and bakes them to stand-alone vtexture
        /// coordinate channels.
        /// 
        /// <para>UV Transformations are specified per-texture - see the MATKEY_UVTRANSFORM material
        /// key for more information. This step processes all textures with transformed input UV coordinates
        /// and generates new (pretransformed) UV channel transformations, so you will probably
        /// want to specify this step.</para>
        /// 
        /// <para>UV transformations are usually implemented in realtime apps by
        /// transforming texture coordinates in a vertex shader stage with a 3x3 (homogenous)
        /// transformation matrix.</para>
        /// </summary>
        TransformUVCoords = 0x80000,

        /// <summary>
        /// Searches for duplicated meshes and replaces them with a reference
        /// to the first mesh.
        /// <para>
        /// This is time consuming, so don't use it if you have no time. Its
        /// main purpose is to work around the limitation with some
        /// file formats that don't support instanced meshes, so exporters
        /// duplicate meshes.
        /// </para>
        /// </summary>
        FindInstances = 0x100000,

        /// <summary>
        /// Attempts to reduce the number of meshes (and draw calls). 
        /// <para>
        /// This is recommended to be used together with <see cref="PostProcessSteps.OptimizeGraph"/>
        /// and is fully compatible with both <see cref="PostProcessSteps.SplitLargeMeshes"/> and <see cref="PostProcessSteps.SortByPrimitiveType"/>.
        /// </para>
        /// </summary>
        OptimizeMeshes = 0x200000,

        /// <summary>
        /// Optimizes scene hierarchy. Nodes with no animations, bones,
        /// lights, or cameras assigned are collapsed and joined.
        /// 
        /// <para>Node names can be lost during this step, you can specify
        /// names of nodes that should'nt be touched or modified
        /// with AI_CONFIG_PP_OG_EXCLUDE_LIST.</para>
        /// 
        /// <para>Use this flag with caution. Most simple files will be collapsed to a 
        /// single node, complex hierarchies are usually completely lost. That's not
        /// the right choice for editor environments, but probably a very effective
        /// optimization if you just want to get the model data, convert it to your
        /// own format and render it as fast as possible. </para>
        /// 
        /// <para>This flag is designed to be used with <see cref="PostProcessSteps.OptimizeMeshes"/> for best
        /// results.</para>
        /// 
        /// <para>Scenes with thousands of extremely small meshes packed
        /// in deeply nested nodes exist for almost all file formats.
        /// Usage of this and <see cref="PostProcessSteps.OptimizeMeshes"/> usually fixes them all and
        /// makes them renderable.</para>
        /// </summary>
        OptimizeGraph = 0x400000,

        /// <summary>
        /// Flips all UV coordinates along the y-axis
        /// and adjusts material settings/bitangents accordingly.
        /// </summary>
        FlipUVs = 0x800000,

        /// <summary>
        /// Flips face winding order from CCW (default) to CW.
        /// </summary>
        FlipWindingOrder = 0x1000000,

        /// <summary>
        /// Splits meshes with many bones into submeshes so that each submesh has fewer or as many bones as a given limit.
        /// </summary>
        SplitByBoneCount = 0x2000000,

        /// <summary>
        /// <para>Removes bones losslessly or according to some threshold. In some cases (e.g. formats that require it) exporters
        /// are faced to assign dummy bone weights to otherwise static meshes assigned to animated meshes. Full, weight-based skinning is expensive while
        /// animating nodes is extremely cheap, so this step is offered to clean up the data in that regard. 
        /// </para>
        /// <para>Usage of the configuration AI_CONFIG_PP_DB_THRESHOLD to control the threshold and AI_CONFIG_PP_DB_ALL_OR_NONE if you want bones
        /// removed if and only if all bones within the scene qualify for removal.</para>
        /// </summary>
        Debone = 0x4000000,

        /// <summary>
        /// Calculates mesh axis aligned bounding boxes <see cref="Mesh.MAABB"/>
        /// </summary>
        GenerateBoundingBoxes = 0x80000000,
    }
}
