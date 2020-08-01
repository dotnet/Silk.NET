// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    public unsafe partial class Assimp : NativeAPI
    {

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetExportFormatCount")]
        public partial uint GetExportFormatCount();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetExportFormatDescription")]
        public partial unsafe ExportFormatDesc* GetExportFormatDescription(uint pIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleaseExportFormatDescription")]
        public partial unsafe void ReleaseExportFormatDescription(ExportFormatDesc* desc);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleaseExportFormatDescription")]
        public partial void ReleaseExportFormatDescription(Span<ExportFormatDesc> desc);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiCopyScene")]
        public partial unsafe void CopyScene(Scene* pIn, Scene** pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiCopyScene")]
        public partial unsafe void CopyScene(Span<Scene> pIn, Scene** pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiFreeScene")]
        public partial unsafe void FreeScene(Scene* pIn);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiFreeScene")]
        public partial void FreeScene(Span<Scene> pIn);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportScene")]
        public partial unsafe Return ExportScene(Scene* pScene, byte* pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportScene")]
        public partial Return ExportScene(Span<Scene> pScene, Span<byte> pFormatId, Span<byte> pFileName, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public partial unsafe Return ExportSceneEx(Scene* pScene, byte* pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public partial Return ExportSceneEx(Span<Scene> pScene, Span<byte> pFormatId, Span<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public partial unsafe ExportDataBlob* ExportSceneToBlob(Scene* pScene, byte* pFormatId, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public partial unsafe ExportDataBlob* ExportSceneToBlob(Span<Scene> pScene, Span<byte> pFormatId, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleaseExportBlob")]
        public partial unsafe void ReleaseExportBlob(ExportDataBlob* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleaseExportBlob")]
        public partial void ReleaseExportBlob(Span<ExportDataBlob> pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetImporterDesc")]
        public partial unsafe ImporterDesc* GetImporterDesc(byte* extension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetImporterDesc")]
        public partial unsafe ImporterDesc* GetImporterDesc(Span<byte> extension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFile")]
        public partial unsafe Scene* ImportFile(byte* pFile, uint pFlags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFile")]
        public partial unsafe Scene* ImportFile(Span<byte> pFile, uint pFlags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public partial unsafe Scene* ImportFileEx(byte* pFile, uint pFlags, FileIO* pFS);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public partial unsafe Scene* ImportFileEx(Span<byte> pFile, uint pFlags, Span<FileIO> pFS);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public partial unsafe Scene* ImportFileExWithProperties(byte* pFile, uint pFlags, FileIO* pFS, PropertyStore* pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public partial unsafe Scene* ImportFileExWithProperties(Span<byte> pFile, uint pFlags, Span<FileIO> pFS, Span<PropertyStore> pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public partial unsafe Scene* ImportFileFromMemory(byte* pBuffer, uint pLength, uint pFlags, byte* pHint);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public partial unsafe Scene* ImportFileFromMemory(Span<byte> pBuffer, uint pLength, uint pFlags, Span<byte> pHint);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public partial unsafe Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, byte* pHint, PropertyStore* pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public partial unsafe Scene* ImportFileFromMemoryWithProperties(Span<byte> pBuffer, uint pLength, uint pFlags, Span<byte> pHint, Span<PropertyStore> pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiApplyPostProcessing")]
        public partial unsafe Scene* ApplyPostProcessing(Scene* pScene, uint pFlags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiApplyPostProcessing")]
        public partial unsafe Scene* ApplyPostProcessing(Span<Scene> pScene, uint pFlags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream")]
        public partial unsafe LogStream GetPredefinedLogStream(DefaultLogStream pStreams, byte* file);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream")]
        public partial LogStream GetPredefinedLogStream(DefaultLogStream pStreams, Span<byte> file);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiAttachLogStream")]
        public partial unsafe void AttachLogStream(LogStream* stream);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiAttachLogStream")]
        public partial void AttachLogStream(Span<LogStream> stream);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiEnableVerboseLogging")]
        public partial void EnableVerboseLogging(int d);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiDetachLogStream")]
        public partial unsafe Return DetachLogStream(LogStream* stream);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiDetachLogStream")]
        public partial Return DetachLogStream(Span<LogStream> stream);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiDetachAllLogStreams")]
        public partial void DetachAllLogStreams();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleaseImport")]
        public partial unsafe void ReleaseImport(Scene* pScene);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleaseImport")]
        public partial void ReleaseImport(Span<Scene> pScene);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetErrorString")]
        public partial unsafe byte* GetErrorString();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIsExtensionSupported")]
        public partial unsafe int IsExtensionSupported(byte* szExtension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIsExtensionSupported")]
        public partial int IsExtensionSupported(Span<byte> szExtension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetExtensionList")]
        public partial unsafe void GetExtensionList(AssimpString* szOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetExtensionList")]
        public partial void GetExtensionList(Span<AssimpString> szOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMemoryRequirements")]
        public partial unsafe void GetMemoryRequirements(Scene* pIn, MemoryInfo* @in);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMemoryRequirements")]
        public partial void GetMemoryRequirements(Span<Scene> pIn, Span<MemoryInfo> @in);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiCreatePropertyStore")]
        public partial unsafe PropertyStore* CreatePropertyStore();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleasePropertyStore")]
        public partial unsafe void ReleasePropertyStore(PropertyStore* p);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleasePropertyStore")]
        public partial void ReleasePropertyStore(Span<PropertyStore> p);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public partial unsafe void SetImportPropertyInteger(PropertyStore* store, byte* szName, int value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public partial void SetImportPropertyInteger(Span<PropertyStore> store, Span<byte> szName, int value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public partial unsafe void SetImportPropertyFloat(PropertyStore* store, byte* szName, float value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public partial void SetImportPropertyFloat(Span<PropertyStore> store, Span<byte> szName, float value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public partial unsafe void SetImportPropertyString(PropertyStore* store, byte* szName, AssimpString* st);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public partial void SetImportPropertyString(Span<PropertyStore> store, Span<byte> szName, Span<AssimpString> st);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public partial unsafe void SetImportPropertyMatrix(PropertyStore* store, byte* szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public partial void SetImportPropertyMatrix(Span<PropertyStore> store, Span<byte> szName, Span<System.Numerics.Matrix4x4> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix")]
        public partial unsafe void CreateQuaternionFromMatrix(System.Numerics.Quaternion* quat, AssimpMatrix3x3* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix")]
        public partial void CreateQuaternionFromMatrix(Span<System.Numerics.Quaternion> quat, Span<AssimpMatrix3x3> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public partial unsafe void DecomposeMatrix(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Quaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public partial void DecomposeMatrix(Span<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Quaternion> rotation, Span<System.Numerics.Vector3> position);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransposeMatrix4")]
        public partial unsafe void TransposeMatrix4(System.Numerics.Matrix4x4* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransposeMatrix4")]
        public partial void TransposeMatrix4(Span<System.Numerics.Matrix4x4> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransposeMatrix3")]
        public partial unsafe void TransposeMatrix3(AssimpMatrix3x3* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransposeMatrix3")]
        public partial void TransposeMatrix3(Span<AssimpMatrix3x3> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3")]
        public partial unsafe void TransformVecByMatrix3(System.Numerics.Vector3* vec, AssimpMatrix3x3* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3")]
        public partial void TransformVecByMatrix3(Span<System.Numerics.Vector3> vec, Span<AssimpMatrix3x3> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4")]
        public partial unsafe void TransformVecByMatrix4(System.Numerics.Vector3* vec, System.Numerics.Matrix4x4* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4")]
        public partial void TransformVecByMatrix4(Span<System.Numerics.Vector3> vec, Span<System.Numerics.Matrix4x4> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiMultiplyMatrix4")]
        public partial unsafe void MultiplyMatrix4(System.Numerics.Matrix4x4* dst, System.Numerics.Matrix4x4* src);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiMultiplyMatrix4")]
        public partial void MultiplyMatrix4(Span<System.Numerics.Matrix4x4> dst, Span<System.Numerics.Matrix4x4> src);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiMultiplyMatrix3")]
        public partial unsafe void MultiplyMatrix3(AssimpMatrix3x3* dst, AssimpMatrix3x3* src);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiMultiplyMatrix3")]
        public partial void MultiplyMatrix3(Span<AssimpMatrix3x3> dst, Span<AssimpMatrix3x3> src);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIdentityMatrix3")]
        public partial unsafe void IdentityMatrix3(AssimpMatrix3x3* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIdentityMatrix3")]
        public partial void IdentityMatrix3(Span<AssimpMatrix3x3> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIdentityMatrix4")]
        public partial unsafe void IdentityMatrix4(System.Numerics.Matrix4x4* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIdentityMatrix4")]
        public partial void IdentityMatrix4(Span<System.Numerics.Matrix4x4> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetImportFormatCount")]
        public partial uint GetImportFormatCount();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetImportFormatDescription")]
        public partial unsafe ImporterDesc* GetImportFormatDescription(uint pIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public partial unsafe Return GetMaterialProperty(Material* pMat, byte* pKey, uint type, uint index, MaterialProperty** pPropOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public partial unsafe Return GetMaterialProperty(Span<Material> pMat, Span<byte> pKey, uint type, uint index, MaterialProperty** pPropOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public partial unsafe Return GetMaterialFloatArray(Material* pMat, byte* pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public partial Return GetMaterialFloatArray(Span<Material> pMat, Span<byte> pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public partial unsafe Return GetMaterialIntegerArray(Material* pMat, byte* pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public partial Return GetMaterialIntegerArray(Span<Material> pMat, Span<byte> pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public partial unsafe Return GetMaterialColor(Material* pMat, byte* pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public partial Return GetMaterialColor(Span<Material> pMat, Span<byte> pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public partial unsafe Return GetMaterialUVTransform(Material* pMat, byte* pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public partial Return GetMaterialUVTransform(Span<Material> pMat, Span<byte> pKey, uint type, uint index, Span<UVTransform> pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public partial unsafe Return GetMaterialString(Material* pMat, byte* pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public partial Return GetMaterialString(Span<Material> pMat, Span<byte> pKey, uint type, uint index, Span<AssimpString> pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialTextureCount")]
        public partial unsafe uint GetMaterialTextureCount(Material* pMat, TextureType type);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialTextureCount")]
        public partial uint GetMaterialTextureCount(Span<Material> pMat, TextureType type);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public partial unsafe Return GetMaterialTexture(Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public partial Return GetMaterialTexture(Span<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetLegalString")]
        public partial unsafe byte* GetLegalString();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetVersionMinor")]
        public partial uint GetVersionMinor();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetVersionMajor")]
        public partial uint GetVersionMajor();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetVersionRevision")]
        public partial uint GetVersionRevision();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetBranchName")]
        public partial unsafe byte* GetBranchName();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetCompileFlags")]
        public partial uint GetCompileFlags();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportScene")]
        public partial unsafe Return ExportScene(Scene* pScene, string pFormatId, string pFileName, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportScene")]
        public partial Return ExportScene(Span<Scene> pScene, string pFormatId, string pFileName, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public partial unsafe Return ExportSceneEx(Scene* pScene, string pFormatId, string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public partial Return ExportSceneEx(Span<Scene> pScene, string pFormatId, string pFileName, Span<FileIO> pIO, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public partial unsafe ExportDataBlob* ExportSceneToBlob(Scene* pScene, string pFormatId, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public partial unsafe ExportDataBlob* ExportSceneToBlob(Span<Scene> pScene, string pFormatId, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetImporterDesc")]
        public partial unsafe ImporterDesc* GetImporterDesc(string extension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFile")]
        public partial unsafe Scene* ImportFile(string pFile, uint pFlags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public partial unsafe Scene* ImportFileEx(string pFile, uint pFlags, FileIO* pFS);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public partial unsafe Scene* ImportFileEx(string pFile, uint pFlags, Span<FileIO> pFS);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public partial unsafe Scene* ImportFileExWithProperties(string pFile, uint pFlags, FileIO* pFS, PropertyStore* pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public partial unsafe Scene* ImportFileExWithProperties(string pFile, uint pFlags, Span<FileIO> pFS, Span<PropertyStore> pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public partial unsafe Scene* ImportFileFromMemory(string pBuffer, uint pLength, uint pFlags, string pHint);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public partial unsafe Scene* ImportFileFromMemoryWithProperties(string pBuffer, uint pLength, uint pFlags, string pHint, PropertyStore* pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public partial unsafe Scene* ImportFileFromMemoryWithProperties(string pBuffer, uint pLength, uint pFlags, string pHint, Span<PropertyStore> pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream")]
        public partial LogStream GetPredefinedLogStream(DefaultLogStream pStreams, string file);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetErrorString")]
        public partial string GetErrorStringS();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIsExtensionSupported")]
        public partial int IsExtensionSupported(string szExtension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public partial unsafe void SetImportPropertyInteger(PropertyStore* store, string szName, int value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public partial void SetImportPropertyInteger(Span<PropertyStore> store, string szName, int value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public partial unsafe void SetImportPropertyFloat(PropertyStore* store, string szName, float value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public partial void SetImportPropertyFloat(Span<PropertyStore> store, string szName, float value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public partial unsafe void SetImportPropertyString(PropertyStore* store, string szName, AssimpString* st);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public partial void SetImportPropertyString(Span<PropertyStore> store, string szName, Span<AssimpString> st);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public partial unsafe void SetImportPropertyMatrix(PropertyStore* store, string szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public partial void SetImportPropertyMatrix(Span<PropertyStore> store, string szName, Span<System.Numerics.Matrix4x4> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public partial unsafe Return GetMaterialProperty(Material* pMat, string pKey, uint type, uint index, MaterialProperty** pPropOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public partial unsafe Return GetMaterialProperty(Span<Material> pMat, string pKey, uint type, uint index, MaterialProperty** pPropOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public partial unsafe Return GetMaterialFloatArray(Material* pMat, string pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public partial Return GetMaterialFloatArray(Span<Material> pMat, string pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public partial unsafe Return GetMaterialIntegerArray(Material* pMat, string pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public partial Return GetMaterialIntegerArray(Span<Material> pMat, string pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public partial unsafe Return GetMaterialColor(Material* pMat, string pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public partial Return GetMaterialColor(Span<Material> pMat, string pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public partial unsafe Return GetMaterialUVTransform(Material* pMat, string pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public partial Return GetMaterialUVTransform(Span<Material> pMat, string pKey, uint type, uint index, Span<UVTransform> pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public partial unsafe Return GetMaterialString(Material* pMat, string pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public partial Return GetMaterialString(Span<Material> pMat, string pKey, uint type, uint index, Span<AssimpString> pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetLegalString")]
        public partial string GetLegalStringS();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetBranchName")]
        public partial string GetBranchNameS();


        public Assimp(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

