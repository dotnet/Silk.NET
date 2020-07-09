// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    public abstract unsafe partial class Assimp : NativeAPI
    {

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetExportFormatCount")]
        public abstract uint GetExportFormatCount();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetExportFormatDescription")]
        public abstract unsafe ExportFormatDesc* GetExportFormatDescription(uint pIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleaseExportFormatDescription")]
        public abstract unsafe void ReleaseExportFormatDescription(ExportFormatDesc* desc);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleaseExportFormatDescription")]
        public abstract void ReleaseExportFormatDescription(Span<ExportFormatDesc> desc);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiCopyScene")]
        public abstract unsafe void CopyScene(Scene* pIn, Scene** pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiCopyScene")]
        public abstract unsafe void CopyScene(Span<Scene> pIn, Scene** pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiFreeScene")]
        public abstract unsafe void FreeScene(Scene* pIn);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiFreeScene")]
        public abstract void FreeScene(Span<Scene> pIn);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportScene")]
        public abstract unsafe Return ExportScene(Scene* pScene, byte* pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportScene")]
        public abstract Return ExportScene(Span<Scene> pScene, Span<byte> pFormatId, Span<byte> pFileName, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public abstract unsafe Return ExportSceneEx(Scene* pScene, byte* pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public abstract Return ExportSceneEx(Span<Scene> pScene, Span<byte> pFormatId, Span<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public abstract unsafe ExportDataBlob* ExportSceneToBlob(Scene* pScene, byte* pFormatId, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public abstract unsafe ExportDataBlob* ExportSceneToBlob(Span<Scene> pScene, Span<byte> pFormatId, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleaseExportBlob")]
        public abstract unsafe void ReleaseExportBlob(ExportDataBlob* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleaseExportBlob")]
        public abstract void ReleaseExportBlob(Span<ExportDataBlob> pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetImporterDesc")]
        public abstract unsafe ImporterDesc* GetImporterDesc(byte* extension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetImporterDesc")]
        public abstract unsafe ImporterDesc* GetImporterDesc(Span<byte> extension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFile")]
        public abstract unsafe Scene* ImportFile(byte* pFile, uint pFlags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFile")]
        public abstract unsafe Scene* ImportFile(Span<byte> pFile, uint pFlags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public abstract unsafe Scene* ImportFileEx(byte* pFile, uint pFlags, FileIO* pFS);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public abstract unsafe Scene* ImportFileEx(Span<byte> pFile, uint pFlags, Span<FileIO> pFS);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public abstract unsafe Scene* ImportFileExWithProperties(byte* pFile, uint pFlags, FileIO* pFS, PropertyStore* pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public abstract unsafe Scene* ImportFileExWithProperties(Span<byte> pFile, uint pFlags, Span<FileIO> pFS, Span<PropertyStore> pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public abstract unsafe Scene* ImportFileFromMemory(byte* pBuffer, uint pLength, uint pFlags, byte* pHint);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public abstract unsafe Scene* ImportFileFromMemory(Span<byte> pBuffer, uint pLength, uint pFlags, Span<byte> pHint);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public abstract unsafe Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, byte* pHint, PropertyStore* pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public abstract unsafe Scene* ImportFileFromMemoryWithProperties(Span<byte> pBuffer, uint pLength, uint pFlags, Span<byte> pHint, Span<PropertyStore> pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiApplyPostProcessing")]
        public abstract unsafe Scene* ApplyPostProcessing(Scene* pScene, uint pFlags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiApplyPostProcessing")]
        public abstract unsafe Scene* ApplyPostProcessing(Span<Scene> pScene, uint pFlags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream")]
        public abstract unsafe LogStream GetPredefinedLogStream(DefaultLogStream pStreams, byte* file);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream")]
        public abstract LogStream GetPredefinedLogStream(DefaultLogStream pStreams, Span<byte> file);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiAttachLogStream")]
        public abstract unsafe void AttachLogStream(LogStream* stream);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiAttachLogStream")]
        public abstract void AttachLogStream(Span<LogStream> stream);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiEnableVerboseLogging")]
        public abstract void EnableVerboseLogging(int d);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiDetachLogStream")]
        public abstract unsafe Return DetachLogStream(LogStream* stream);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiDetachLogStream")]
        public abstract Return DetachLogStream(Span<LogStream> stream);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiDetachAllLogStreams")]
        public abstract void DetachAllLogStreams();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleaseImport")]
        public abstract unsafe void ReleaseImport(Scene* pScene);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleaseImport")]
        public abstract void ReleaseImport(Span<Scene> pScene);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetErrorString")]
        public abstract unsafe byte* GetErrorString();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIsExtensionSupported")]
        public abstract unsafe int IsExtensionSupported(byte* szExtension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIsExtensionSupported")]
        public abstract int IsExtensionSupported(Span<byte> szExtension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetExtensionList")]
        public abstract unsafe void GetExtensionList(AssimpString* szOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetExtensionList")]
        public abstract void GetExtensionList(Span<AssimpString> szOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMemoryRequirements")]
        public abstract unsafe void GetMemoryRequirements(Scene* pIn, MemoryInfo* @in);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMemoryRequirements")]
        public abstract void GetMemoryRequirements(Span<Scene> pIn, Span<MemoryInfo> @in);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiCreatePropertyStore")]
        public abstract unsafe PropertyStore* CreatePropertyStore();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleasePropertyStore")]
        public abstract unsafe void ReleasePropertyStore(PropertyStore* p);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiReleasePropertyStore")]
        public abstract void ReleasePropertyStore(Span<PropertyStore> p);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public abstract unsafe void SetImportPropertyInteger(PropertyStore* store, byte* szName, int value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public abstract void SetImportPropertyInteger(Span<PropertyStore> store, Span<byte> szName, int value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public abstract unsafe void SetImportPropertyFloat(PropertyStore* store, byte* szName, double value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public abstract void SetImportPropertyFloat(Span<PropertyStore> store, Span<byte> szName, double value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public abstract unsafe void SetImportPropertyString(PropertyStore* store, byte* szName, AssimpString* st);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public abstract void SetImportPropertyString(Span<PropertyStore> store, Span<byte> szName, Span<AssimpString> st);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public abstract unsafe void SetImportPropertyMatrix(PropertyStore* store, byte* szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public abstract void SetImportPropertyMatrix(Span<PropertyStore> store, Span<byte> szName, Span<System.Numerics.Matrix4x4> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix")]
        public abstract unsafe void CreateQuaternionFromMatrix(System.Numerics.Quaternion* quat, AssimpMatrix3x3* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix")]
        public abstract void CreateQuaternionFromMatrix(Span<System.Numerics.Quaternion> quat, Span<AssimpMatrix3x3> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public abstract unsafe void DecomposeMatrix(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Quaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiDecomposeMatrix")]
        public abstract void DecomposeMatrix(Span<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Quaternion> rotation, Span<System.Numerics.Vector3> position);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransposeMatrix4")]
        public abstract unsafe void TransposeMatrix4(System.Numerics.Matrix4x4* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransposeMatrix4")]
        public abstract void TransposeMatrix4(Span<System.Numerics.Matrix4x4> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransposeMatrix3")]
        public abstract unsafe void TransposeMatrix3(AssimpMatrix3x3* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransposeMatrix3")]
        public abstract void TransposeMatrix3(Span<AssimpMatrix3x3> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3")]
        public abstract unsafe void TransformVecByMatrix3(System.Numerics.Vector3* vec, AssimpMatrix3x3* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3")]
        public abstract void TransformVecByMatrix3(Span<System.Numerics.Vector3> vec, Span<AssimpMatrix3x3> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4")]
        public abstract unsafe void TransformVecByMatrix4(System.Numerics.Vector3* vec, System.Numerics.Matrix4x4* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4")]
        public abstract void TransformVecByMatrix4(Span<System.Numerics.Vector3> vec, Span<System.Numerics.Matrix4x4> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiMultiplyMatrix4")]
        public abstract unsafe void MultiplyMatrix4(System.Numerics.Matrix4x4* dst, System.Numerics.Matrix4x4* src);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiMultiplyMatrix4")]
        public abstract void MultiplyMatrix4(Span<System.Numerics.Matrix4x4> dst, Span<System.Numerics.Matrix4x4> src);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiMultiplyMatrix3")]
        public abstract unsafe void MultiplyMatrix3(AssimpMatrix3x3* dst, AssimpMatrix3x3* src);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiMultiplyMatrix3")]
        public abstract void MultiplyMatrix3(Span<AssimpMatrix3x3> dst, Span<AssimpMatrix3x3> src);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIdentityMatrix3")]
        public abstract unsafe void IdentityMatrix3(AssimpMatrix3x3* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIdentityMatrix3")]
        public abstract void IdentityMatrix3(Span<AssimpMatrix3x3> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIdentityMatrix4")]
        public abstract unsafe void IdentityMatrix4(System.Numerics.Matrix4x4* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIdentityMatrix4")]
        public abstract void IdentityMatrix4(Span<System.Numerics.Matrix4x4> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetImportFormatCount")]
        public abstract uint GetImportFormatCount();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetImportFormatDescription")]
        public abstract unsafe ImporterDesc* GetImportFormatDescription(uint pIndex);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public abstract unsafe Return GetMaterialProperty(Material* pMat, byte* pKey, uint type, uint index, MaterialProperty** pPropOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public abstract unsafe Return GetMaterialProperty(Span<Material> pMat, Span<byte> pKey, uint type, uint index, MaterialProperty** pPropOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public abstract unsafe Return GetMaterialFloatArray(Material* pMat, byte* pKey, uint type, uint index, double* pOut, uint* pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public abstract Return GetMaterialFloatArray(Span<Material> pMat, Span<byte> pKey, uint type, uint index, Span<double> pOut, Span<uint> pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public abstract unsafe Return GetMaterialIntegerArray(Material* pMat, byte* pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public abstract Return GetMaterialIntegerArray(Span<Material> pMat, Span<byte> pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public abstract unsafe Return GetMaterialColor(Material* pMat, byte* pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public abstract Return GetMaterialColor(Span<Material> pMat, Span<byte> pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public abstract unsafe Return GetMaterialUVTransform(Material* pMat, byte* pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public abstract Return GetMaterialUVTransform(Span<Material> pMat, Span<byte> pKey, uint type, uint index, Span<UVTransform> pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public abstract unsafe Return GetMaterialString(Material* pMat, byte* pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public abstract Return GetMaterialString(Span<Material> pMat, Span<byte> pKey, uint type, uint index, Span<AssimpString> pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialTextureCount")]
        public abstract unsafe uint GetMaterialTextureCount(Material* pMat, TextureType type);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialTextureCount")]
        public abstract uint GetMaterialTextureCount(Span<Material> pMat, TextureType type);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public abstract unsafe Return GetMaterialTexture(Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, double* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialTexture")]
        public abstract Return GetMaterialTexture(Span<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<double> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetLegalString")]
        public abstract unsafe byte* GetLegalString();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetVersionMinor")]
        public abstract uint GetVersionMinor();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetVersionMajor")]
        public abstract uint GetVersionMajor();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetVersionRevision")]
        public abstract uint GetVersionRevision();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetBranchName")]
        public abstract unsafe byte* GetBranchName();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetCompileFlags")]
        public abstract uint GetCompileFlags();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportScene")]
        public abstract unsafe Return ExportScene(Scene* pScene, string pFormatId, string pFileName, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportScene")]
        public abstract Return ExportScene(Span<Scene> pScene, string pFormatId, string pFileName, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public abstract unsafe Return ExportSceneEx(Scene* pScene, string pFormatId, string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneEx")]
        public abstract Return ExportSceneEx(Span<Scene> pScene, string pFormatId, string pFileName, Span<FileIO> pIO, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public abstract unsafe ExportDataBlob* ExportSceneToBlob(Scene* pScene, string pFormatId, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiExportSceneToBlob")]
        public abstract unsafe ExportDataBlob* ExportSceneToBlob(Span<Scene> pScene, string pFormatId, uint pPreprocessing);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetImporterDesc")]
        public abstract unsafe ImporterDesc* GetImporterDesc(string extension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFile")]
        public abstract unsafe Scene* ImportFile(string pFile, uint pFlags);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public abstract unsafe Scene* ImportFileEx(string pFile, uint pFlags, FileIO* pFS);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileEx")]
        public abstract unsafe Scene* ImportFileEx(string pFile, uint pFlags, Span<FileIO> pFS);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public abstract unsafe Scene* ImportFileExWithProperties(string pFile, uint pFlags, FileIO* pFS, PropertyStore* pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileExWithProperties")]
        public abstract unsafe Scene* ImportFileExWithProperties(string pFile, uint pFlags, Span<FileIO> pFS, Span<PropertyStore> pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemory")]
        public abstract unsafe Scene* ImportFileFromMemory(string pBuffer, uint pLength, uint pFlags, string pHint);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public abstract unsafe Scene* ImportFileFromMemoryWithProperties(string pBuffer, uint pLength, uint pFlags, string pHint, PropertyStore* pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties")]
        public abstract unsafe Scene* ImportFileFromMemoryWithProperties(string pBuffer, uint pLength, uint pFlags, string pHint, Span<PropertyStore> pProps);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream")]
        public abstract LogStream GetPredefinedLogStream(DefaultLogStream pStreams, string file);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetErrorString")]
        public abstract string GetErrorStringS();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiIsExtensionSupported")]
        public abstract int IsExtensionSupported(string szExtension);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public abstract unsafe void SetImportPropertyInteger(PropertyStore* store, string szName, int value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger")]
        public abstract void SetImportPropertyInteger(Span<PropertyStore> store, string szName, int value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public abstract unsafe void SetImportPropertyFloat(PropertyStore* store, string szName, double value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat")]
        public abstract void SetImportPropertyFloat(Span<PropertyStore> store, string szName, double value);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public abstract unsafe void SetImportPropertyString(PropertyStore* store, string szName, AssimpString* st);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyString")]
        public abstract void SetImportPropertyString(Span<PropertyStore> store, string szName, Span<AssimpString> st);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public abstract unsafe void SetImportPropertyMatrix(PropertyStore* store, string szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix")]
        public abstract void SetImportPropertyMatrix(Span<PropertyStore> store, string szName, Span<System.Numerics.Matrix4x4> mat);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public abstract unsafe Return GetMaterialProperty(Material* pMat, string pKey, uint type, uint index, MaterialProperty** pPropOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialProperty")]
        public abstract unsafe Return GetMaterialProperty(Span<Material> pMat, string pKey, uint type, uint index, MaterialProperty** pPropOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public abstract unsafe Return GetMaterialFloatArray(Material* pMat, string pKey, uint type, uint index, double* pOut, uint* pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray")]
        public abstract Return GetMaterialFloatArray(Span<Material> pMat, string pKey, uint type, uint index, Span<double> pOut, Span<uint> pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public abstract unsafe Return GetMaterialIntegerArray(Material* pMat, string pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray")]
        public abstract Return GetMaterialIntegerArray(Span<Material> pMat, string pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public abstract unsafe Return GetMaterialColor(Material* pMat, string pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialColor")]
        public abstract Return GetMaterialColor(Span<Material> pMat, string pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public abstract unsafe Return GetMaterialUVTransform(Material* pMat, string pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform")]
        public abstract Return GetMaterialUVTransform(Span<Material> pMat, string pKey, uint type, uint index, Span<UVTransform> pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public abstract unsafe Return GetMaterialString(Material* pMat, string pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetMaterialString")]
        public abstract Return GetMaterialString(Span<Material> pMat, string pKey, uint type, uint index, Span<AssimpString> pOut);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetLegalString")]
        public abstract string GetLegalStringS();

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "aiGetBranchName")]
        public abstract string GetBranchNameS();

        private SearchPathContainer _searchPaths;
        public override SearchPathContainer SearchPaths => _searchPaths ??= new AssimpLibraryNameContainer();

        public Assimp(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

