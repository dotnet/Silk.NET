// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using Silk.NET.Assimp;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;
using File = System.IO.File;

namespace AssimpOpenGLTest
{
    public static unsafe class SimpleOpenGLSample
    {
        private static Scene* m_model;
        private static Vector3 m_sceneCenter, m_sceneMin, m_sceneMax;
        private static float m_angle;
        private static uint m_displayList;
        private static uint m_texId;
        private static GL GL;
        private static Assimp Assimp;
        private static PropertyStore* _propertyStore;
        private static IWindow _window;

        public static void Init()
        {
            Assimp = Assimp.GetApi();
            _window = Window.Create(WindowOptions.Default);
            _window.Title = "Quack! - AssimpNet Simple OpenGL Sample";

            String fileName = Path.Combine(AppContext.BaseDirectory, "duck.dae");
            _propertyStore = Assimp.CreatePropertyStore();
            Assimp.SetImportPropertyFloat(_propertyStore, Assimp.PropertyPpGsnMaxSmoothingAngle, 66f);
            m_model = Assimp.ImportFile
            (
                fileName, (uint) PostProcessSteps.CalculateTangentSpace |
                          (uint) PostProcessSteps.GenerateSmoothNormals |
                          (uint) PostProcessSteps.JoinIdenticalVertices |
                          (uint) PostProcessSteps.LimitBoneWeights |
                          (uint) PostProcessSteps.RemoveRedundantMaterials |
                          (uint) PostProcessSteps.SplitLargeMeshes |
                          (uint) PostProcessSteps.Triangulate |
                          (uint) PostProcessSteps.GenerateUVCoords |
                          (uint) PostProcessSteps.SortByPrimitiveType |
                          (uint) PostProcessSteps.FindDegenerates |
                          (uint) PostProcessSteps.FindInvalidData |
                          (uint) PostProcessSteps.FindInstances |
                          (uint) PostProcessSteps.ValidateDataStructure |
                          (uint) PostProcessSteps.OptimizeMeshes
            );
            Console.WriteLine(Assimp.GetErrorStringS());
            
            ComputeBoundingBox();
            _window.Render += OnRenderFrame;
            _window.Update += OnUpdateFrame;
            _window.Resize += OnResize;
            _window.Load += OnLoad;
            _window.Closing += OnUnload;
        }

        private static void OnLoad()
        {
            GL = _window.CreateLegacyOpenGL();
        }

        public static void Run() => _window.Run();

        private static void ComputeBoundingBox()
        {
            m_sceneMin = new Vector3(1e10f, 1e10f, 1e10f);
            m_sceneMax = new Vector3(-1e10f, -1e10f, -1e10f);
            Matrix4x4 identity = Matrix4x4.Identity;

            ComputeBoundingBox(m_model->MRootNode, ref m_sceneMin, ref m_sceneMax, ref identity);

            m_sceneCenter.X = (m_sceneMin.X + m_sceneMax.X) / 2.0f;
            m_sceneCenter.Y = (m_sceneMin.Y + m_sceneMax.Y) / 2.0f;
            m_sceneCenter.Z = (m_sceneMin.Z + m_sceneMax.Z) / 2.0f;
        }

        private static void ComputeBoundingBox(Node* node, ref Vector3 min, ref Vector3 max, ref Matrix4x4 trafo)
        {
            Matrix4x4 prev = trafo;
            trafo = Matrix4x4.Multiply(prev, node->MTransformation);

            if(node->MNumMeshes > 0)
            {
                foreach(int index in new ReadOnlySpan<uint>(node->MMeshes, (int) node->MNumMeshes))
                {
                    Mesh*mesh = m_model->MMeshes[index];
                    for(int i = 0; i < mesh->MNumVertices; i++)
                    {
                        Vector3 tmp = mesh->MVertices[i];
                        tmp = Vector3.Transform(tmp, trafo);

                        min.X = Math.Min(min.X, tmp.X);
                        min.Y = Math.Min(min.Y, tmp.Y);
                        min.Z = Math.Min(min.Z, tmp.Z);

                        max.X = Math.Max(max.X, tmp.X);
                        max.Y = Math.Max(max.Y, tmp.Y);
                        max.Z = Math.Max(max.Z, tmp.Z);
                    }
                }
            }

            for(int i = 0; i < node->MNumChildren; i++)
            {
                ComputeBoundingBox(node->MChildren[i], ref min, ref max, ref trafo);
            }
            trafo = prev;
        }

        private static void OnUnload()
        {
            GL.DeleteTexture(m_texId);
        }

        private static void OnUpdateFrame(double delta)
        {
            m_angle += 25f * (float) delta;
            if(m_angle > 360)
            {
                m_angle = 0.0f;
            }
        }

        private static void OnResize(Size sz)
        {
            var w = (uint)sz.Width;
            var h = (uint)sz.Height;
            GL.Viewport(0, 0, w, h);

            float aspectRatio = w / (float) h;
            Matrix4x4 perspective = Matrix4x4.CreatePerspectiveFieldOfView(MathF.PI / 4, aspectRatio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix((float*)&perspective);
        }

        private static void OnRenderFrame(double delta)
        {
            GL.ClearColor(Color.CornflowerBlue);
            GL.Clear((uint) (ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit));

            GL.Enable(EnableCap.Texture2D);
            GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest);
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.Normalize);
            GL.FrontFace(FrontFaceDirection.Ccw);

            GL.MatrixMode(MatrixMode.Modelview);
            Matrix4x4 lookat = Matrix4x4.CreateLookAt(new Vector3(0, 5, 5), new Vector3(0, 0, 0), new Vector3(0, 1, 0));
            GL.LoadMatrix((float*)&lookat);

            GL.Rotate(m_angle, 0.0f, 1.0f, 0.0f);

            float tmp = m_sceneMax.X - m_sceneMin.X;
            tmp = Math.Max(m_sceneMax.Y - m_sceneMin.Y, tmp);
            tmp = Math.Max(m_sceneMax.Z - m_sceneMin.Z, tmp);
            tmp = 1.0f / tmp;
            GL.Scale(tmp * 2, tmp * 2, tmp * 2);

            var nSceneCenter = -m_sceneCenter;
            GL.Translate(nSceneCenter.X, nSceneCenter.Y, nSceneCenter.Z);

            if(m_displayList == 0)
            {
                m_displayList = GL.GenLists(1);
                GL.NewList(m_displayList, ListMode.Compile);
                RecursiveRender(m_model, m_model->MRootNode);
                GL.EndList();
            }

            GL.CallList(m_displayList);
        }

        private static void RecursiveRender(Scene* scene, Node* node)
        {
            Matrix4x4 m = node->MTransformation;
            m = Matrix4x4.Transpose(m);
            GL.PushMatrix();
            GL.MultMatrix((float*)&m);

            if(node->MNumMeshes > 0)
            {
                foreach(uint index in new ReadOnlySpan<uint>(node->MMeshes, (int) node->MNumMeshes))
                {
                    Mesh* mesh = scene->MMeshes[index];
                    ApplyMaterial(scene->MMaterials[mesh->MMaterialIndex], scene);

                    if(mesh->MNormals != null)
                    {
                        GL.Enable(EnableCap.Lighting);
                    }
                    else
                    {
                        GL.Disable(EnableCap.Lighting);
                    }

                    var hasColors = mesh->MColors_0 != null;
                    if(hasColors)
                    {
                        GL.Enable(EnableCap.ColorMaterial);
                    }
                    else
                    {
                        GL.Disable(EnableCap.ColorMaterial);
                    }

                    bool hasTexCoords = mesh->MTextureCoords_0 != null;

                    foreach(Face face in new ReadOnlySpan<Face>(mesh->MFaces, (int) mesh->MNumFaces))
                    {
                        GLEnum faceMode;
                        switch(face.MNumIndices)
                        {
                            case 1:
                                faceMode = GLEnum.Points;
                                break;
                            case 2:
                                faceMode = GLEnum.Lines;
                                break;
                            case 3:
                                faceMode = GLEnum.Triangles;
                                break;
                            default:
                                faceMode = GLEnum.Polygon;
                                break;
                        }

                        GL.Begin(faceMode);
                        for(int i = 0; i < face.MNumIndices; i++)
                        {
                            uint indice = face.MIndices[i];
                            if(hasColors)
                            {
                                Vector4 vertColor = mesh->MColors_0[indice];
                            }
                            if(mesh->MNormals != null)
                            {
                                Vector3 normal = mesh->MNormals[indice];
                                GL.Normal3((float*)&normal);
                            }
                            if(hasTexCoords)
                            {
                                Vector3 uvw = mesh->MTextureCoords_0[indice];
                                GL.TexCoord2(uvw.X, 1 - uvw.Y);
                            }
                            Vector3 pos = mesh->MVertices[indice];
                            GL.Vertex3((float*)&pos);
                        }
                        GL.End();
                    }
                }
            }

            for(int i = 0; i < node->MNumChildren; i++)
            {
                RecursiveRender(m_model, node->MChildren[i]);
            }
        }

        private static void LoadTexture(String fileName)
        {
            fileName = Path.Combine(AppContext.BaseDirectory, fileName);
            if(!File.Exists(fileName))
            {
                throw new FileNotFoundException();
            }
            Bitmap textureBitmap = new Bitmap(fileName);
            BitmapData TextureData =
                    textureBitmap.LockBits(
                    new System.Drawing.Rectangle(0, 0, textureBitmap.Width, textureBitmap.Height),
                    System.Drawing.Imaging.ImageLockMode.ReadOnly,
                    System.Drawing.Imaging.PixelFormat.Format24bppRgb
                );
            m_texId = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, m_texId);

            GL.TexImage2D(GLEnum.Texture2D, 0, (int)GLEnum.Rgb, (uint)textureBitmap.Width, (uint)textureBitmap.Height, 0,
                GLEnum.Bgr, GLEnum.UnsignedByte, (void*)TextureData.Scan0);
            textureBitmap.UnlockBits(TextureData);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int) TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int) TextureMagFilter.Linear);
        }

        private static void ApplyMaterial(Material* mat, Scene* scene)
        {
            //if(mat.GetMaterialTextureCount(TextureType.Diffuse) > 0)
            //{
            //    TextureSlot tex;
            //    if(mat.GetMaterialTexture(TextureType.Diffuse, 0, out tex))
            //        LoadTexture(tex.FilePath);
            //}
//
            //Color4 color = new Color4(.8f, .8f, .8f, 1.0f);
            //if(mat.HasColorDiffuse)
            //{
            //    // color = FromColor(mat.ColorDiffuse);
            //}
//
            //color = new Color4(0, 0, 0, 1.0f);
            //if(mat.HasColorSpecular)
            //{
            //    color = FromColor(mat.ColorSpecular);
            //}
            //GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Specular, color);
//
            //color = new Color4(.2f, .2f, .2f, 1.0f);
            //if(mat.HasColorAmbient)
            //{
            //    color = FromColor(mat.ColorAmbient);
            //}
            //GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Ambient, color);
//
            //color = new Color4(0, 0, 0, 1.0f);
            //if(mat.HasColorEmissive)
            //{
            //    color = FromColor(mat.ColorEmissive);
            //}
            //GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Emission, color);
//
            //if(mat.HasShininess)
            //{
            //    shininess = mat.Shininess;
            //}
            //if(mat.HasShininessStrength)
            //{
            //    strength = mat.ShininessStrength;
            //}
//
            //GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Shininess, shininess * strength);
            var diffuseSet = false;
            var specularSet = false;
            var ambientSet = false;
            var emissionSet = false;
            var shininessSet = false;
            float? shininess = null;
            float? shininessStrength = null;
            foreach (var propertyPtr in new ReadOnlySpan<IntPtr>(mat->MProperties, (int) mat->MNumProperties))
            {
                var property = (MaterialProperty*) propertyPtr;
                if (property->MKey == Assimp.MaterialShininess)
                {
                    shininess = (float)AnyToDouble(property);
                }
                else if (property->MKey == Assimp.MaterialShininessStrength)
                {
                    shininessStrength = (float) AnyToDouble(property);
                }
                else if (property->MKey == Assimp.MaterialColorDiffuse)
                {
                    GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Diffuse, (float*)property->MData);
                    diffuseSet = true;
                }
                else if (property->MKey == Assimp.MaterialColorSpecular)
                {
                    GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Specular, (float*)property->MData);
                    specularSet = true;
                }
                else if (property->MKey == Assimp.MaterialColorAmbient)
                {
                    GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Ambient, (float*)property->MData);
                    ambientSet = true;
                }
                else if (property->MKey == Assimp.MaterialColorEmissive)
                {
                    GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Emission, (float*)property->MData);
                    emissionSet = true;
                }
                else if (property->MKey == Assimp.MaterialTextureBase)
                {
                    if (property->MSemantic == (int)TextureType.TextureTypeDiffuse)
                    {
                        LoadTexture((*(AssimpString*)property->MData));
                    }
                }
            }

            if (shininessStrength.HasValue || shininess.HasValue)
            {
                GL.Material
                (
                    MaterialFace.FrontAndBack, MaterialParameter.Shininess, (shininess ?? 1) * (shininessStrength ?? 1)
                );
            }

            double AnyToDouble(MaterialProperty* property)
            {
                return property->MType switch
                {
                    PropertyTypeInfo.PtiFloat => *(float*)property->MData,
                    PropertyTypeInfo.PtiDouble => *(double*)property->MData,
                    PropertyTypeInfo.PtiInteger => *(int*)property->MData,
                    _ => double.NaN
                };
            }
        }
    }
}
