/* <Core> */

#ifdef _ALLEGRO_GL_VERSION_1_2
AGL_API(void, BlendColor, (GLclampf, GLclampf, GLclampf, GLclampf))
AGL_API(void, BlendEquation, (GLenum))
AGL_API(void, DrawRangeElements, (GLenum, GLuint, GLuint, GLsizei, GLenum, const GLvoid *))
AGL_API(void, ColorTable, (GLenum, GLenum, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, ColorTableParameterfv, (GLenum, GLenum, const GLfloat *))
AGL_API(void, ColorTableParameteriv, (GLenum, GLenum, const GLint *))
AGL_API(void, CopyColorTable, (GLenum, GLenum, GLint, GLint, GLsizei))
AGL_API(void, GetColorTable, (GLenum, GLenum, GLenum, GLvoid *))
AGL_API(void, GetColorTableParameterfv, (GLenum, GLenum, GLfloat *))
AGL_API(void, GetColorTableParameteriv, (GLenum, GLenum, GLint *))
AGL_API(void, ColorSubTable, (GLenum, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, CopyColorSubTable, (GLenum, GLsizei, GLint, GLint, GLsizei))
AGL_API(void, TexImage3D, (GLenum, GLint, GLint, GLsizei, GLsizei, GLsizei, GLint, GLenum, GLenum, const GLvoid *))
AGL_API(void, TexSubImage3D, (GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, CopyTexSubImage3D, (GLenum, GLint, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei))
#endif

#if defined _ALLEGRO_GL_ARB_imaging
AGL_API(void, ConvolutionFilter1D, (GLenum, GLenum, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, ConvolutionFilter2D, (GLenum, GLenum, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, ConvolutionParameterf, (GLenum, GLenum, GLfloat))
AGL_API(void, ConvolutionParameterfv, (GLenum, GLenum, const GLfloat *))
AGL_API(void, ConvolutionParameteri, (GLenum, GLenum, GLint))
AGL_API(void, ConvolutionParameteriv, (GLenum, GLenum, const GLint *))
AGL_API(void, CopyConvolutionFilter1D, (GLenum, GLenum, GLint, GLint, GLsizei))
AGL_API(void, CopyConvolutionFilter2D, (GLenum, GLenum, GLint, GLint, GLsizei, GLsizei))
AGL_API(void, GetConvolutionFilter, (GLenum, GLenum, GLenum, GLvoid *))
AGL_API(void, GetConvolutionParameterfv, (GLenum, GLenum, GLfloat *))
AGL_API(void, GetConvolutionParameteriv, (GLenum, GLenum, GLint *))
AGL_API(void, GetSeparableFilter, (GLenum, GLenum, GLenum, GLvoid *, GLvoid *, GLvoid *))
AGL_API(void, SeparableFilter2D, (GLenum, GLenum, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *, const GLvoid *))
AGL_API(void, GetHistogram, (GLenum, GLboolean, GLenum, GLenum, GLvoid *))
AGL_API(void, GetHistogramParameterfv, (GLenum, GLenum, GLfloat *))
AGL_API(void, GetHistogramParameteriv, (GLenum, GLenum, GLint *))
AGL_API(void, GetMinmax, (GLenum, GLboolean, GLenum, GLenum, GLvoid *))
AGL_API(void, GetMinmaxParameterfv, (GLenum, GLenum, GLfloat *))
AGL_API(void, GetMinmaxParameteriv, (GLenum, GLenum, GLint *))
AGL_API(void, Histogram, (GLenum, GLsizei, GLenum, GLboolean))
AGL_API(void, Minmax, (GLenum, GLenum, GLboolean))
AGL_API(void, ResetHistogram, (GLenum))
AGL_API(void, ResetMinmax, (GLenum))
#endif

#if defined _ALLEGRO_GL_VERSION_1_3
AGL_API(void, ActiveTexture, (GLenum))
AGL_API(void, ClientActiveTexture, (GLenum))
AGL_API(void, MultiTexCoord1d, (GLenum, GLdouble))
AGL_API(void, MultiTexCoord1dv, (GLenum, const GLdouble *))
AGL_API(void, MultiTexCoord1f, (GLenum, GLfloat))
AGL_API(void, MultiTexCoord1fv, (GLenum, const GLfloat *))
AGL_API(void, MultiTexCoord1i, (GLenum, GLint))
AGL_API(void, MultiTexCoord1iv, (GLenum, const GLint *))
AGL_API(void, MultiTexCoord1s, (GLenum, GLshort))
AGL_API(void, MultiTexCoord1sv, (GLenum, const GLshort *))
AGL_API(void, MultiTexCoord2d, (GLenum, GLdouble, GLdouble))
AGL_API(void, MultiTexCoord2dv, (GLenum, const GLdouble *))
AGL_API(void, MultiTexCoord2f, (GLenum, GLfloat, GLfloat))
AGL_API(void, MultiTexCoord2fv, (GLenum, const GLfloat *))
AGL_API(void, MultiTexCoord2i, (GLenum, GLint, GLint))
AGL_API(void, MultiTexCoord2iv, (GLenum, const GLint *))
AGL_API(void, MultiTexCoord2s, (GLenum, GLshort, GLshort))
AGL_API(void, MultiTexCoord2sv, (GLenum, const GLshort *))
AGL_API(void, MultiTexCoord3d, (GLenum, GLdouble, GLdouble, GLdouble))
AGL_API(void, MultiTexCoord3dv, (GLenum, const GLdouble *))
AGL_API(void, MultiTexCoord3f, (GLenum, GLfloat, GLfloat, GLfloat))
AGL_API(void, MultiTexCoord3fv, (GLenum, const GLfloat *))
AGL_API(void, MultiTexCoord3i, (GLenum, GLint, GLint, GLint))
AGL_API(void, MultiTexCoord3iv, (GLenum, const GLint *))
AGL_API(void, MultiTexCoord3s, (GLenum, GLshort, GLshort, GLshort))
AGL_API(void, MultiTexCoord3sv, (GLenum, const GLshort *))
AGL_API(void, MultiTexCoord4d, (GLenum, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, MultiTexCoord4dv, (GLenum, const GLdouble *))
AGL_API(void, MultiTexCoord4f, (GLenum, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, MultiTexCoord4fv, (GLenum, const GLfloat *))
AGL_API(void, MultiTexCoord4i, (GLenum, GLint, GLint, GLint, GLint))
AGL_API(void, MultiTexCoord4iv, (GLenum, const GLint *))
AGL_API(void, MultiTexCoord4s, (GLenum, GLshort, GLshort, GLshort, GLshort))
AGL_API(void, MultiTexCoord4sv, (GLenum, const GLshort *))
AGL_API(void, LoadTransposeMatrixf, (const GLfloat *))
AGL_API(void, LoadTransposeMatrixd, (const GLdouble *))
AGL_API(void, MultTransposeMatrixf, (const GLfloat *))
AGL_API(void, MultTransposeMatrixd, (const GLdouble *))
AGL_API(void, SampleCoverage, (GLclampf, GLboolean))
AGL_API(void, CompressedTexImage3D, (GLenum, GLint, GLenum, GLsizei, GLsizei, GLsizei, GLint, GLsizei, const GLvoid *))
AGL_API(void, CompressedTexImage2D, (GLenum, GLint, GLenum, GLsizei, GLsizei, GLint, GLsizei, const GLvoid *))
AGL_API(void, CompressedTexImage1D, (GLenum, GLint, GLenum, GLsizei, GLint, GLsizei, const GLvoid *))
AGL_API(void, CompressedTexSubImage3D, (GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLenum, GLsizei, const GLvoid *))
AGL_API(void, CompressedTexSubImage2D, (GLenum, GLint, GLint, GLint, GLsizei, GLsizei, GLenum, GLsizei, const GLvoid *))
AGL_API(void, CompressedTexSubImage1D, (GLenum, GLint, GLint, GLsizei, GLenum, GLsizei, const GLvoid *))
AGL_API(void, GetCompressedTexImage, (GLenum, GLint, GLvoid *))
#endif

#if defined _ALLEGRO_GL_VERSION_1_4
AGL_API(void, BlendFuncSeparate, (GLenum, GLenum, GLenum, GLenum))
AGL_API(void, FogCoordf, (GLfloat))
AGL_API(void, FogCoordfv, (const GLfloat *))
AGL_API(void, FogCoordd, (GLdouble))
AGL_API(void, FogCoorddv, (const GLdouble *))
AGL_API(void, FogCoordPointer, (GLenum, GLsizei, const GLvoid *))
AGL_API(void, MultiDrawArrays, (GLenum, GLint *, GLsizei *, GLsizei))
AGL_API(void, MultiDrawElements, (GLenum, const GLsizei *, GLenum, const GLvoid* *, GLsizei))
AGL_API(void, PointParameterf, (GLenum, GLfloat))
AGL_API(void, PointParameterfv, (GLenum, const GLfloat *))
AGL_API(void, PointParameteri, (GLenum, GLint))
AGL_API(void, PointParameteriv, (GLenum, const GLint *))
AGL_API(void, SecondaryColor3b, (GLbyte, GLbyte, GLbyte))
AGL_API(void, SecondaryColor3bv, (const GLbyte *))
AGL_API(void, SecondaryColor3d, (GLdouble, GLdouble, GLdouble))
AGL_API(void, SecondaryColor3dv, (const GLdouble *))
AGL_API(void, SecondaryColor3f, (GLfloat, GLfloat, GLfloat))
AGL_API(void, SecondaryColor3fv, (const GLfloat *))
AGL_API(void, SecondaryColor3i, (GLint, GLint, GLint))
AGL_API(void, SecondaryColor3iv, (const GLint *))
AGL_API(void, SecondaryColor3s, (GLshort, GLshort, GLshort))
AGL_API(void, SecondaryColor3sv, (const GLshort *))
AGL_API(void, SecondaryColor3ub, (GLubyte, GLubyte, GLubyte))
AGL_API(void, SecondaryColor3ubv, (const GLubyte *))
AGL_API(void, SecondaryColor3ui, (GLuint, GLuint, GLuint))
AGL_API(void, SecondaryColor3uiv, (const GLuint *))
AGL_API(void, SecondaryColor3us, (GLushort, GLushort, GLushort))
AGL_API(void, SecondaryColor3usv, (const GLushort *))
AGL_API(void, SecondaryColorPointer, (GLint, GLenum, GLsizei, const GLvoid *))
AGL_API(void, WindowPos2d, (GLdouble, GLdouble))
AGL_API(void, WindowPos2dv, (const GLdouble *))
AGL_API(void, WindowPos2f, (GLfloat, GLfloat))
AGL_API(void, WindowPos2fv, (const GLfloat *))
AGL_API(void, WindowPos2i, (GLint, GLint))
AGL_API(void, WindowPos2iv, (const GLint *))
AGL_API(void, WindowPos2s, (GLshort, GLshort))
AGL_API(void, WindowPos2sv, (const GLshort *))
AGL_API(void, WindowPos3d, (GLdouble, GLdouble, GLdouble))
AGL_API(void, WindowPos3dv, (const GLdouble *))
AGL_API(void, WindowPos3f, (GLfloat, GLfloat, GLfloat))
AGL_API(void, WindowPos3fv, (const GLfloat *))
AGL_API(void, WindowPos3i, (GLint, GLint, GLint))
AGL_API(void, WindowPos3iv, (const GLint *))
AGL_API(void, WindowPos3s, (GLshort, GLshort, GLshort))
AGL_API(void, WindowPos3sv, (const GLshort *))
#endif

	
#if defined _ALLEGRO_GL_VERSION_1_5
AGL_API(void, BindBuffer, (GLenum, GLuint))
AGL_API(void, DeleteBuffers, (GLsizei, const GLuint *))
AGL_API(void, GenBuffers, (GLsizei, GLuint *))
AGL_API(GLboolean, IsBuffer, (GLuint))
AGL_API(void, BufferData, (GLenum, GLsizeiptr, const GLvoid *, GLenum))
AGL_API(void, BufferSubData, (GLenum, GLintptr, GLsizeiptr, const GLvoid *))
AGL_API(void, GetBufferSubData, (GLenum, GLintptr, GLsizeiptr, GLvoid *))
AGL_API(GLvoid*, MapBuffer, (GLenum, GLenum))
AGL_API(GLboolean, UnmapBuffer, (GLenum))
AGL_API(void, GetBufferParameteriv, (GLenum, GLenum, GLint *))
AGL_API(void, GetBufferPointerv, (GLenum, GLenum, GLvoid* *))
AGL_API(void, GenQueries, (GLsizei, GLuint *))
AGL_API(void, DeleteQueries, (GLsizei, const GLuint *))
AGL_API(GLboolean, IsQuery, (GLuint))
AGL_API(void, BeginQuery, (GLenum, GLuint))
AGL_API(void, EndQuery, (GLenum))
AGL_API(void, GetQueryiv, (GLenum, GLenum, GLint *))
AGL_API(void, GetQueryObjectiv, (GLuint, GLenum, GLint *))
AGL_API(void, GetQueryObjectuiv, (GLuint, GLenum, GLuint *))
#endif


#if defined _ALLEGRO_GL_VERSION_2_0
AGL_API(void, BlendEquationSeparate, (GLenum, GLenum))
AGL_API(GLuint, CreateProgram, (void))
AGL_API(GLuint, CreateShader, (GLenum))
AGL_API(void,   DeleteProgram, (GLuint))
AGL_API(void,   DeleteShader, (GLuint))
AGL_API(void,   AttachShader, (GLuint, GLuint))
AGL_API(void,   DetachShader, (GLuint, GLuint))
AGL_API(void,   ShaderSource, (GLuint, GLsizei, const GLchar **, const GLint *))
AGL_API(void,   CompileShader, (GLuint))
AGL_API(GLboolean, IsProgram, (GLuint))
AGL_API(GLboolean, IsShader,  (GLuint))
AGL_API(void,   LinkProgram, (GLuint))
AGL_API(void,   UseProgram, (GLuint))
AGL_API(void,   ValidateProgram, (GLuint))
AGL_API(void, Uniform1f, (GLint, GLfloat))
AGL_API(void, Uniform2f, (GLint, GLfloat, GLfloat))
AGL_API(void, Uniform3f, (GLint, GLfloat, GLfloat, GLfloat))
AGL_API(void, Uniform4f, (GLint, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, Uniform1i, (GLint, GLint))
AGL_API(void, Uniform2i, (GLint, GLint, GLint))
AGL_API(void, Uniform3i, (GLint, GLint, GLint, GLint))
AGL_API(void, Uniform4i, (GLint, GLint, GLint, GLint, GLint))
AGL_API(void, Uniform1fv, (GLint, GLsizei, const GLfloat *))
AGL_API(void, Uniform2fv, (GLint, GLsizei, const GLfloat *))
AGL_API(void, Uniform3fv, (GLint, GLsizei, const GLfloat *))
AGL_API(void, Uniform4fv, (GLint, GLsizei, const GLfloat *))
AGL_API(void, Uniform1iv, (GLint, GLsizei, const GLint *))
AGL_API(void, Uniform2iv, (GLint, GLsizei, const GLint *))
AGL_API(void, Uniform3iv, (GLint, GLsizei, const GLint *))
AGL_API(void, Uniform4iv, (GLint, GLsizei, const GLint *))
AGL_API(void, UniformMatrix2fv, (GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, UniformMatrix3fv, (GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, UniformMatrix4fv, (GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, GetShaderfv,  (GLuint, GLenum, GLfloat *))
AGL_API(void, GetShaderiv,  (GLuint, GLenum, GLint *))
AGL_API(void, GetProgramfv, (GLuint, GLenum, GLfloat *))
AGL_API(void, GetProgramiv, (GLuint, GLenum, GLint *))
AGL_API(void, GetShaderInfoLog,  (GLuint, GLsizei, GLsizei *, GLchar *))
AGL_API(void, GetProgramInfoLog, (GLuint, GLsizei, GLsizei *, GLchar *))
AGL_API(void, GetAttachedShaders,  (GLuint, GLsizei, GLsizei *, GLuint *))
AGL_API(GLint, GetUniformLocation, (GLuint, const GLchar *))
AGL_API(void,  GetActiveUniform, (GLuint, GLuint, GLsizei, GLsizei *, GLint *, GLenum *, GLchar *))
AGL_API(void,  GetUniformfv, (GLuint, GLint, GLfloat *))
AGL_API(void,  GetUniformiv, (GLuint, GLint, GLint *))
AGL_API(void,  GetShaderSource, (GLuint, GLsizei, GLsizei *, GLchar *))
AGL_API(void, VertexAttrib1f,    (GLuint, GLfloat))
AGL_API(void, VertexAttrib1s,    (GLuint, GLshort))
AGL_API(void, VertexAttrib1d,    (GLuint, GLdouble))
AGL_API(void, VertexAttrib2f,    (GLuint, GLfloat, GLfloat))
AGL_API(void, VertexAttrib2s,    (GLuint, GLshort, GLshort))
AGL_API(void, VertexAttrib2d,    (GLuint, GLdouble, GLdouble))
AGL_API(void, VertexAttrib3f,    (GLuint, GLfloat, GLfloat, GLfloat))
AGL_API(void, VertexAttrib3s,    (GLuint, GLshort, GLshort, GLshort))
AGL_API(void, VertexAttrib3d,    (GLuint, GLdouble, GLdouble, GLdouble))
AGL_API(void, VertexAttrib4f,    (GLuint, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, VertexAttrib4s,    (GLuint, GLshort, GLshort, GLshort, GLshort))
AGL_API(void, VertexAttrib4d,    (GLuint, GLdouble,GLdouble,GLdouble,GLdouble))
AGL_API(void, VertexAttrib4Nub,  (GLuint, GLubyte, GLubyte, GLubyte, GLubyte))
AGL_API(void, VertexAttrib1fv,   (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib1sv,   (GLuint, const GLshort *))
AGL_API(void, VertexAttrib1dv,   (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib2fv,   (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib2sv,   (GLuint, const GLshort *))
AGL_API(void, VertexAttrib2dv,   (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib3fv,   (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib3sv,   (GLuint, const GLshort *))
AGL_API(void, VertexAttrib3dv,   (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib4fv,   (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib4sv,   (GLuint, const GLshort *))
AGL_API(void, VertexAttrib4dv,   (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib4iv,   (GLuint, const GLint *))
AGL_API(void, VertexAttrib4bv,   (GLuint, const GLbyte *))
AGL_API(void, VertexAttrib4ubv,  (GLuint, const GLubyte *))
AGL_API(void, VertexAttrib4usv,  (GLuint, const GLushort *))
AGL_API(void, VertexAttrib4uiv,  (GLuint, const GLuint *))
AGL_API(void, VertexAttrib4Nbv,  (GLuint, const GLbyte *))
AGL_API(void, VertexAttrib4Nsv,  (GLuint, const GLshort *))
AGL_API(void, VertexAttrib4Niv,  (GLuint, const GLint *))
AGL_API(void, VertexAttrib4Nubv, (GLuint, const GLubyte *))
AGL_API(void, VertexAttrib4Nusv, (GLuint, const GLushort *))
AGL_API(void, VertexAttrib4Nuiv, (GLuint, const GLuint *))
AGL_API(void, VertexAttribPointer,(GLuint, GLint, GLenum, GLboolean, GLsizei, const GLvoid *))
AGL_API(void, EnableVertexAttribArray, (GLuint))
AGL_API(void, DisableVertexAttribArray, (GLuint))

AGL_API(void, BindAttribLocation, (GLuint, GLuint, const GLchar *))
AGL_API(void, GetActiveAttrib,    (GLuint, GLuint, GLsizei, GLsizei *, GLint *, GLenum *, GLchar *))
AGL_API(GLint, GetAttribLocation, (GLuint, const GLchar *))
AGL_API(void, GetVertexAttribdv, (GLuint, GLenum, GLdouble *))
AGL_API(void, GetVertexAttribfv, (GLuint, GLenum, GLfloat *))
AGL_API(void, GetVertexAttribiv, (GLuint, GLenum, GLint *))
AGL_API(void, GetVertexAttribPointerv, (GLuint, GLenum, GLvoid **))

AGL_API(void, DrawBuffers, (GLsizei n, const GLenum *))

AGL_API(void, StencilOpSeparate,   (GLenum, GLenum, GLenum, GLenum))
AGL_API(void, StencilFuncSeparate, (GLenum, GLenum, GLint,  GLuint))
AGL_API(void, StencilMaskSeparate, (GLenum, GLuint))

#endif


#if defined _ALLEGRO_GL_VERSION_2_1
AGL_API(void, UniformMatrix2x3fv, (GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, UniformMatrix3x2fv, (GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, UniformMatrix2x4fv, (GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, UniformMatrix4x2fv, (GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, UniformMatrix3x4fv, (GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, UniformMatrix4x3fv, (GLint, GLsizei, GLboolean, const GLfloat *))
#endif

#if defined _ALLEGRO_GL_VERSION_3_0
/* OpenGL 3.0 also reuses entry points from these extensions: */
/* ARB_framebuffer_object */
/* ARB_map_buffer_range */
/* ARB_vertex_array_object */
AGL_API(void, ColorMaski, (GLuint, GLboolean, GLboolean, GLboolean, GLboolean))
AGL_API(void, GetBooleani_v, (GLenum, GLuint, GLboolean *))
AGL_API(void, GetIntegeri_v, (GLenum, GLuint, GLint *))
AGL_API(void, Enablei, (GLenum, GLuint))
AGL_API(void, Disablei, (GLenum, GLuint))
AGL_API(GLboolean, IsEnabledi, (GLenum, GLuint))
AGL_API(void, BeginTransformFeedback, (GLenum))
AGL_API(void, EndTransformFeedback, (void))
AGL_API(void, BindBufferRange, (GLenum, GLuint, GLuint, GLintptr, GLsizeiptr))
AGL_API(void, BindBufferBase, (GLenum, GLuint, GLuint))
AGL_API(void, TransformFeedbackVaryings, (GLuint, GLsizei, const GLint *, GLenum))
AGL_API(void, GetTransformFeedbackVarying, (GLuint, GLuint, GLint *))
AGL_API(void, ClampColor, (GLenum, GLenum))
AGL_API(void, BeginConditionalRender, (GLuint, GLenum))
AGL_API(void, EndConditionalRender, (void))
AGL_API(void, VertexAttribI1i, (GLuint, GLint))
AGL_API(void, VertexAttribI2i, (GLuint, GLint, GLint))
AGL_API(void, VertexAttribI3i, (GLuint, GLint, GLint, GLint))
AGL_API(void, VertexAttribI4i, (GLuint, GLint, GLint, GLint, GLint))
AGL_API(void, VertexAttribI1ui, (GLuint, GLuint))
AGL_API(void, VertexAttribI2ui, (GLuint, GLuint, GLuint))
AGL_API(void, VertexAttribI3ui, (GLuint, GLuint, GLuint, GLuint))
AGL_API(void, VertexAttribI4ui, (GLuint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, VertexAttribI1iv, (GLuint, const GLint *))
AGL_API(void, VertexAttribI2iv, (GLuint, const GLint *))
AGL_API(void, VertexAttribI3iv, (GLuint, const GLint *))
AGL_API(void, VertexAttribI4iv, (GLuint, const GLint *))
AGL_API(void, VertexAttribI1uiv, (GLuint, const GLuint *))
AGL_API(void, VertexAttribI2uiv, (GLuint, const GLuint *))
AGL_API(void, VertexAttribI3uiv, (GLuint, const GLuint *))
AGL_API(void, VertexAttribI4uiv, (GLuint, const GLuint *))
AGL_API(void, VertexAttribI4bv, (GLuint, const GLbyte *))
AGL_API(void, VertexAttribI4sv, (GLuint, const GLshort *))
AGL_API(void, VertexAttribI4ubv, (GLuint, const GLubyte *))
AGL_API(void, VertexAttribI4usv, (GLuint, const GLushort *))
AGL_API(void, VertexAttribIPointer, (GLuint, GLint, GLenum, GLsizei, const GLvoid *))
AGL_API(void, GetVertexAttribIiv, (GLuint, GLenum, GLint *))
AGL_API(void, GetVertexAttribIuiv, (GLuint, GLenum, GLuint *))
AGL_API(void, GetUniformuiv, (GLuint, GLint, GLuint *))
AGL_API(void, BindFragDataLocation, (GLuint, GLuint, const GLchar *))
AGL_API(GLint, GetFragDataLocation, (GLuint, const GLchar *))
AGL_API(void, Uniform1ui, (GLint, GLuint))
AGL_API(void, Uniform2ui, (GLint, GLuint, GLuint))
AGL_API(void, Uniform3ui, (GLint, GLuint, GLuint, GLuint))
AGL_API(void, Uniform4ui, (GLint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, Uniform1uiv, (GLint, GLsizei, const GLuint *))
AGL_API(void, Uniform2uiv, (GLint, GLsizei, const GLuint *))
AGL_API(void, Uniform3uiv, (GLint, GLsizei, const GLuint *))
AGL_API(void, Uniform4uiv, (GLint, GLsizei, const GLuint *))
AGL_API(void, TexParameterIiv, (GLenum, GLenum, const GLint *))
AGL_API(void, TexParameterIuiv, (GLenum, GLenum, const GLuint *))
AGL_API(void, GetTexParameterIiv, (GLenum, GLenum, GLint *))
AGL_API(void, GetTexParameterIuiv, (GLenum, GLenum, GLuint *))
AGL_API(void, ClearBufferiv, (GLenum, GLint, const GLint *))
AGL_API(void, ClearBufferuiv, (GLenum, GLint, const GLuint *))
AGL_API(void, ClearBufferfv, (GLenum, GLint, const GLfloat *))
AGL_API(void, ClearBufferfi, (GLenum, GLint, GLfloat, GLint))
AGL_API(const GLubyte *, GetStringi, (GLenum, GLuint))
#endif


#if defined _ALLEGRO_GL_VERSION_3_1
/* OpenGL 3.1 also reuses entry points from these extensions: */
/* ARB_copy_buffer */
/* ARB_uniform_buffer_object */
AGL_API(void, DrawArraysInstanced, (GLenum, GLint, GLsizei, GLsizei))
AGL_API(void, DrawElementsInstanced, (GLenum, GLsizei, GLenum, const GLvoid *, GLsizei))
AGL_API(void, TexBuffer, (GLenum, GLenum, GLuint))
AGL_API(void, PrimitiveRestartIndex, (GLuint))
#endif

#if defined _ALLEGRO_GL_VERSION_3_2
/* OpenGL 3.2 also reuses entry points from these extensions: */
/* ARB_draw_elements_base_vertex */
/* ARB_provoking_vertex */
/* ARB_sync */
/* ARB_texture_multisample */
AGL_API(void, GetInteger64i_v, (GLenum target, GLuint index, GLint64 *data))
AGL_API(void, GetBufferParameteri64v, (GLenum target, GLenum pname, GLint64 *params))
AGL_API(void, ProgramParameteri, (GLuint program, GLenum pname, GLint value))
AGL_API(void, FramebufferTexture, (GLenum target, GLenum attachment, GLuint texture, GLint level))
#endif

#if defined _ALLEGRO_GL_VERSION_3_3
/* OpenGL 3.3 also reuses entry points from these extensions: */
/* ARB_blend_func_extended */
/* ARB_sampler_objects */
/* ARB_explicit_attrib_location, but it has none */
/* ARB_occlusion_query2 (no entry points) */
/* ARB_shader_bit_encoding (no entry points) */
/* ARB_texture_rgb10_a2ui (no entry points) */
/* ARB_texture_swizzle (no entry points) */
/* ARB_timer_query */
/* ARB_vertex_type_2_10_10_10_rev */
#endif

#if defined _ALLEGRO_GL_VERSION_4_3
AGL_API(void, ClearBufferData, (GLenum target, GLenum internalformat, GLenum format, GLenum type, const void *data))
AGL_API(void, ClearBufferSubData, (GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, const void *data))
AGL_API(void, DispatchCompute, (GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z))
AGL_API(void, DispatchComputeIndirect, (GLintptr indirect))
AGL_API(void, CopyImageSubData, (GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth))
AGL_API(void, FramebufferParameteri, (GLenum target, GLenum pname, GLint param))
AGL_API(void, GetFramebufferParameteriv, (GLenum target, GLenum pname, GLint *params))
AGL_API(void, GetInternalformati64v, (GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint64 *params))
AGL_API(void, InvalidateTexSubImage, (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth))
AGL_API(void, InvalidateTexImage, (GLuint texture, GLint level))
AGL_API(void, InvalidateBufferSubData, (GLuint buffer, GLintptr offset, GLsizeiptr length))
AGL_API(void, InvalidateBufferData, (GLuint buffer))
AGL_API(void, InvalidateFramebuffer, (GLenum target, GLsizei numAttachments, const GLenum *attachments))
AGL_API(void, InvalidateSubFramebuffer, (GLenum target, GLsizei numAttachments, const GLenum *attachments, GLint x, GLint y, GLsizei width, GLsizei height))
AGL_API(void, MultiDrawArraysIndirect, (GLenum mode, const void *indirect, GLsizei drawcount, GLsizei stride))
AGL_API(void, MultiDrawElementsIndirect, (GLenum mode, GLenum type, const void *indirect, GLsizei drawcount, GLsizei stride))
AGL_API(void, GetProgramInterfaceiv, (GLuint program, GLenum programInterface, GLenum pname, GLint *params))
AGL_API(GLuint, GetProgramResourceIndex, (GLuint program, GLenum programInterface, const GLchar *name))
AGL_API(void, GetProgramResourceName, (GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei *length, GLchar *name))
AGL_API(void, GetProgramResourceiv, (GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, const GLenum *props, GLsizei bufSize, GLsizei *length, GLint *params))
AGL_API(GLint, GetProgramResourceLocation, (GLuint program, GLenum programInterface, const GLchar *name))
AGL_API(GLint, GetProgramResourceLocationIndex, (GLuint program, GLenum programInterface, const GLchar *name))
AGL_API(void, ShaderStorageBlockBinding, (GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding))
AGL_API(void, TexBufferRange, (GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size))
AGL_API(void, TexStorage2DMultisample, (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations))
AGL_API(void, TexStorage3DMultisample, (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations))
AGL_API(void, TextureView, (GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers))
AGL_API(void, BindVertexBuffer, (GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride))
AGL_API(void, VertexAttribFormat, (GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset))
AGL_API(void, VertexAttribIFormat, (GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset))
AGL_API(void, VertexAttribLFormat, (GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset))
AGL_API(void, VertexAttribBinding, (GLuint attribindex, GLuint bindingindex))
AGL_API(void, VertexBindingDivisor, (GLuint bindingindex, GLuint divisor))
AGL_API(void, DebugMessageControl, (GLenum source, GLenum type, GLenum severity, GLsizei count, const GLuint *ids, GLboolean enabled))
AGL_API(void, DebugMessageInsert, (GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, const GLchar *buf))
AGL_API(void, DebugMessageCallback, (GLDEBUGPROC callback, const void *userParam))
AGL_API(GLuint, GetDebugMessageLog, (GLuint count, GLsizei bufSize, GLenum *sources, GLenum *types, GLuint *ids, GLenum *severities, GLsizei *lengths, GLchar *messageLog))
AGL_API(void, PushDebugGroup, (GLenum source, GLuint id, GLsizei length, const GLchar *message))
AGL_API(void, PopDebugGroup, (void))
AGL_API(void, ObjectLabel, (GLenum identifier, GLuint name, GLsizei length, const GLchar *label))
AGL_API(void, GetObjectLabel, (GLenum identifier, GLuint name, GLsizei bufSize, GLsizei *length, GLchar *label))
AGL_API(void, ObjectPtrLabel, (const void *ptr, GLsizei length, const GLchar *label))
AGL_API(void, GetObjectPtrLabel, (const void *ptr, GLsizei bufSize, GLsizei *length, GLchar *label))
#endif /* GL_VERSION_4_3 */


/* </Core> */
/* <ARB> */

#ifdef _ALLEGRO_GL_ARB_multitexture
AGL_API(void, ActiveTextureARB, (GLenum))
AGL_API(void, ClientActiveTextureARB, (GLenum))
AGL_API(void, MultiTexCoord1dARB, (GLenum, GLdouble))
AGL_API(void, MultiTexCoord1dvARB, (GLenum, const GLdouble *))
AGL_API(void, MultiTexCoord1fARB, (GLenum, GLfloat))
AGL_API(void, MultiTexCoord1fvARB, (GLenum, const GLfloat *))
AGL_API(void, MultiTexCoord1iARB, (GLenum, GLint))
AGL_API(void, MultiTexCoord1ivARB, (GLenum, const GLint *))
AGL_API(void, MultiTexCoord1sARB, (GLenum, GLshort))
AGL_API(void, MultiTexCoord1svARB, (GLenum, const GLshort *))
AGL_API(void, MultiTexCoord2dARB, (GLenum, GLdouble, GLdouble))
AGL_API(void, MultiTexCoord2dvARB, (GLenum, const GLdouble *))
AGL_API(void, MultiTexCoord2fARB, (GLenum, GLfloat, GLfloat))
AGL_API(void, MultiTexCoord2fvARB, (GLenum, const GLfloat *))
AGL_API(void, MultiTexCoord2iARB, (GLenum, GLint, GLint))
AGL_API(void, MultiTexCoord2ivARB, (GLenum, const GLint *))
AGL_API(void, MultiTexCoord2sARB, (GLenum, GLshort, GLshort))
AGL_API(void, MultiTexCoord2svARB, (GLenum, const GLshort *))
AGL_API(void, MultiTexCoord3dARB, (GLenum, GLdouble, GLdouble, GLdouble))
AGL_API(void, MultiTexCoord3dvARB, (GLenum, const GLdouble *))
AGL_API(void, MultiTexCoord3fARB, (GLenum, GLfloat, GLfloat, GLfloat))
AGL_API(void, MultiTexCoord3fvARB, (GLenum, const GLfloat *))
AGL_API(void, MultiTexCoord3iARB, (GLenum, GLint, GLint, GLint))
AGL_API(void, MultiTexCoord3ivARB, (GLenum, const GLint *))
AGL_API(void, MultiTexCoord3sARB, (GLenum, GLshort, GLshort, GLshort))
AGL_API(void, MultiTexCoord3svARB, (GLenum, const GLshort *))
AGL_API(void, MultiTexCoord4dARB, (GLenum, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, MultiTexCoord4dvARB, (GLenum, const GLdouble *))
AGL_API(void, MultiTexCoord4fARB, (GLenum, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, MultiTexCoord4fvARB, (GLenum, const GLfloat *))
AGL_API(void, MultiTexCoord4iARB, (GLenum, GLint, GLint, GLint, GLint))
AGL_API(void, MultiTexCoord4ivARB, (GLenum, const GLint *))
AGL_API(void, MultiTexCoord4sARB, (GLenum, GLshort, GLshort, GLshort, GLshort))
AGL_API(void, MultiTexCoord4svARB, (GLenum, const GLshort *))
#endif

#if defined _ALLEGRO_GL_ARB_transpose_matrix
AGL_API(void, LoadTransposeMatrixfARB, (const GLfloat *))
AGL_API(void, LoadTransposeMatrixdARB, (const GLdouble *))
AGL_API(void, MultTransposeMatrixfARB, (const GLfloat *))
AGL_API(void, MultTransposeMatrixdARB, (const GLdouble *))
#endif

#if defined _ALLEGRO_GL_ARB_multisample
AGL_API(void, SampleCoverageARB, (GLclampf, GLboolean))
#endif

#if defined _ALLEGRO_GL_ARB_texture_compression
AGL_API(void, CompressedTexImage3DARB, (GLenum, GLint, GLenum, GLsizei, GLsizei, GLsizei, GLint, GLsizei, const GLvoid *))
AGL_API(void, CompressedTexImage2DARB, (GLenum, GLint, GLenum, GLsizei, GLsizei, GLint, GLsizei, const GLvoid *))
AGL_API(void, CompressedTexImage1DARB, (GLenum, GLint, GLenum, GLsizei, GLint, GLsizei, const GLvoid *))
AGL_API(void, CompressedTexSubImage3DARB, (GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLenum, GLsizei, const GLvoid *))
AGL_API(void, CompressedTexSubImage2DARB, (GLenum, GLint, GLint, GLint, GLsizei, GLsizei, GLenum, GLsizei, const GLvoid *))
AGL_API(void, CompressedTexSubImage1DARB, (GLenum, GLint, GLint, GLsizei, GLenum, GLsizei, const GLvoid *))
AGL_API(void, GetCompressedTexImageARB, (GLenum, GLint, GLvoid *))
#endif

#if defined _ALLEGRO_GL_ARB_point_parameters
AGL_API(void, PointParameterfARB, (GLenum, GLfloat))
AGL_API(void, PointParameterfvARB, (GLenum, const GLfloat *))
#endif

#if defined _ALLEGRO_GL_ARB_vertex_blend
AGL_API(void, WeightbvARB, (GLint, const GLbyte *))
AGL_API(void, WeightsvARB, (GLint, const GLshort *))
AGL_API(void, WeightivARB, (GLint, const GLint *))
AGL_API(void, WeightfvARB, (GLint, const GLfloat *))
AGL_API(void, WeightdvARB, (GLint, const GLdouble *))
AGL_API(void, WeightubvARB, (GLint, const GLubyte *))
AGL_API(void, WeightusvARB, (GLint, const GLushort *))
AGL_API(void, WeightuivARB, (GLint, const GLuint *))
AGL_API(void, WeightPointerARB, (GLint, GLenum, GLsizei, const GLvoid *))
AGL_API(void, VertexBlendARB, (GLint))
#endif

#if defined _ALLEGRO_GL_ARB_matrix_palette
AGL_API(void, CurrentPaletteMatrixARB, (GLint))
AGL_API(void, MatrixIndexubvARB, (GLint, const GLubyte *))
AGL_API(void, MatrixIndexusvARB, (GLint, const GLushort *))
AGL_API(void, MatrixIndexuivARB, (GLint, const GLuint *))
AGL_API(void, MatrixIndexPointerARB, (GLint, GLenum, GLsizei, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_ARB_window_pos
AGL_API(void, WindowPos2dARB, (GLdouble, GLdouble))
AGL_API(void, WindowPos2dvARB, (const GLdouble *))
AGL_API(void, WindowPos2fARB, (GLfloat, GLfloat))
AGL_API(void, WindowPos2fvARB, (const GLfloat *))
AGL_API(void, WindowPos2iARB, (GLint, GLint))
AGL_API(void, WindowPos2ivARB, (const GLint *))
AGL_API(void, WindowPos2sARB, (GLshort, GLshort))
AGL_API(void, WindowPos2svARB, (const GLshort *))
AGL_API(void, WindowPos3dARB, (GLdouble, GLdouble, GLdouble))
AGL_API(void, WindowPos3dvARB, (const GLdouble *))
AGL_API(void, WindowPos3fARB, (GLfloat, GLfloat, GLfloat))
AGL_API(void, WindowPos3fvARB, (const GLfloat *))
AGL_API(void, WindowPos3iARB, (GLint, GLint, GLint))
AGL_API(void, WindowPos3ivARB, (const GLint *))
AGL_API(void, WindowPos3sARB, (GLshort, GLshort, GLshort))
AGL_API(void, WindowPos3svARB, (const GLshort *))
#endif

#if defined _ALLEGRO_GL_ARB_vertex_program
AGL_API(void, VertexAttrib1dARB, (GLuint, GLdouble))
AGL_API(void, VertexAttrib1dvARB, (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib1fARB, (GLuint, GLfloat))
AGL_API(void, VertexAttrib1fvARB, (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib1sARB, (GLuint, GLshort))
AGL_API(void, VertexAttrib1svARB, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib2dARB, (GLuint, GLdouble, GLdouble))
AGL_API(void, VertexAttrib2dvARB, (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib2fARB, (GLuint, GLfloat, GLfloat))
AGL_API(void, VertexAttrib2fvARB, (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib2sARB, (GLuint, GLshort, GLshort))
AGL_API(void, VertexAttrib2svARB, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib3dARB, (GLuint, GLdouble, GLdouble, GLdouble))
AGL_API(void, VertexAttrib3dvARB, (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib3fARB, (GLuint, GLfloat, GLfloat, GLfloat))
AGL_API(void, VertexAttrib3fvARB, (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib3sARB, (GLuint, GLshort, GLshort, GLshort))
AGL_API(void, VertexAttrib3svARB, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib4NbvARB, (GLuint, const GLbyte *))
AGL_API(void, VertexAttrib4NivARB, (GLuint, const GLint *))
AGL_API(void, VertexAttrib4NsvARB, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib4NubARB, (GLuint, GLubyte, GLubyte, GLubyte, GLubyte))
AGL_API(void, VertexAttrib4NubvARB, (GLuint, const GLubyte *))
AGL_API(void, VertexAttrib4NuivARB, (GLuint, const GLuint *))
AGL_API(void, VertexAttrib4NusvARB, (GLuint, const GLushort *))
AGL_API(void, VertexAttrib4bvARB, (GLuint, const GLbyte *))
AGL_API(void, VertexAttrib4dARB, (GLuint, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, VertexAttrib4dvARB, (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib4fARB, (GLuint, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, VertexAttrib4fvARB, (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib4ivARB, (GLuint, const GLint *))
AGL_API(void, VertexAttrib4sARB, (GLuint, GLshort, GLshort, GLshort, GLshort))
AGL_API(void, VertexAttrib4svARB, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib4ubvARB, (GLuint, const GLubyte *))
AGL_API(void, VertexAttrib4uivARB, (GLuint, const GLuint *))
AGL_API(void, VertexAttrib4usvARB, (GLuint, const GLushort *))
AGL_API(void, VertexAttribPointerARB, (GLuint, GLint, GLenum, GLboolean, GLsizei, const GLvoid *))
AGL_API(void, EnableVertexAttribArrayARB, (GLuint))
AGL_API(void, DisableVertexAttribArrayARB, (GLuint))
AGL_API(void, ProgramStringARB, (GLenum, GLenum, GLsizei, const GLvoid *))
AGL_API(void, BindProgramARB, (GLenum, GLuint))
AGL_API(void, DeleteProgramsARB, (GLsizei, const GLuint *))
AGL_API(void, GenProgramsARB, (GLsizei, GLuint *))
AGL_API(void, ProgramEnvParameter4dARB, (GLenum, GLuint, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, ProgramEnvParameter4dvARB, (GLenum, GLuint, const GLdouble *))
AGL_API(void, ProgramEnvParameter4fARB, (GLenum, GLuint, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, ProgramEnvParameter4fvARB, (GLenum, GLuint, const GLfloat *))
AGL_API(void, ProgramLocalParameter4dARB, (GLenum, GLuint, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, ProgramLocalParameter4dvARB, (GLenum, GLuint, const GLdouble *))
AGL_API(void, ProgramLocalParameter4fARB, (GLenum, GLuint, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, ProgramLocalParameter4fvARB, (GLenum, GLuint, const GLfloat *))
AGL_API(void, GetProgramEnvParameterdvARB, (GLenum, GLuint, GLdouble *))
AGL_API(void, GetProgramEnvParameterfvARB, (GLenum, GLuint, GLfloat *))
AGL_API(void, GetProgramLocalParameterdvARB, (GLenum, GLuint, GLdouble *))
AGL_API(void, GetProgramLocalParameterfvARB, (GLenum, GLuint, GLfloat *))
AGL_API(void, GetProgramivARB, (GLenum, GLenum, GLint *))
AGL_API(void, GetProgramStringARB, (GLenum, GLenum, GLvoid *))
AGL_API(void, GetVertexAttribdvARB, (GLuint, GLenum, GLdouble *))
AGL_API(void, GetVertexAttribfvARB, (GLuint, GLenum, GLfloat *))
AGL_API(void, GetVertexAttribivARB, (GLuint, GLenum, GLint *))
AGL_API(void, GetVertexAttribPointervARB, (GLuint, GLenum, GLvoid* *))
AGL_API(GLboolean, IsProgramARB, (GLuint))
#endif

#if defined _ALLEGRO_GL_ARB_vertex_buffer_object
AGL_API(void, BindBufferARB, (GLenum, GLuint))
AGL_API(void, DeleteBuffersARB, (GLsizei, const GLuint *))
AGL_API(void, GenBuffersARB, (GLsizei, GLuint *))
AGL_API(GLboolean, IsBufferARB, (GLuint))
AGL_API(void, BufferDataARB, (GLenum, GLsizeiptrARB, const GLvoid *, GLenum))
AGL_API(void, BufferSubDataARB, (GLenum, GLintptrARB, GLsizeiptrARB, const GLvoid *))
AGL_API(void, GetBufferSubDataARB, (GLenum, GLintptrARB, GLsizeiptrARB, GLvoid *))
AGL_API(GLvoid*, MapBufferARB, (GLenum, GLenum))
AGL_API(GLboolean, UnmapBufferARB, (GLenum))
AGL_API(void, GetBufferParameterivARB, (GLenum, GLenum, GLint *))
AGL_API(void, GetBufferPointervARB, (GLenum, GLenum, GLvoid* *))
#endif

#if defined _ALLEGRO_GL_ARB_occlusion_query
AGL_API(void, GenQueriesARB, (GLsizei, GLuint *))
AGL_API(void, DeleteQueriesARB, (GLsizei, const GLuint *))
AGL_API(GLboolean, IsQueryARB, (GLuint))
AGL_API(void, BeginQueryARB, (GLenum, GLuint))
AGL_API(void, EndQueryARB, (GLenum))
AGL_API(void, GetQueryivARB, (GLenum, GLenum, GLint *))
AGL_API(void, GetQueryObjectivARB, (GLuint, GLenum, GLint *))
AGL_API(void, GetQueryObjectuivARB, (GLuint, GLenum, GLuint *))
#endif

#if defined _ALLEGRO_GL_ARB_shader_objects
AGL_API(void, DeleteObjectARB, (GLhandleARB))
AGL_API(GLhandleARB, GetHandleARB, (GLenum))
AGL_API(void, DetachObjectARB, (GLhandleARB, GLhandleARB))
AGL_API(GLhandleARB, CreateShaderObjectARB, (GLenum))
AGL_API(void, ShaderSourceARB, (GLhandleARB, GLsizei, const GLcharARB **, const GLint *))
AGL_API(void, CompileShaderARB, (GLhandleARB))
AGL_API(GLhandleARB, CreateProgramObjectARB, (void))
AGL_API(void, AttachObjectARB, (GLhandleARB, GLhandleARB))
AGL_API(void, LinkProgramARB, (GLhandleARB))
AGL_API(void, UseProgramObjectARB, (GLhandleARB))
AGL_API(void, ValidateProgramARB, (GLhandleARB))
AGL_API(void, Uniform1fARB, (GLint, GLfloat))
AGL_API(void, Uniform2fARB, (GLint, GLfloat, GLfloat))
AGL_API(void, Uniform3fARB, (GLint, GLfloat, GLfloat, GLfloat))
AGL_API(void, Uniform4fARB, (GLint, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, Uniform1iARB, (GLint, GLint))
AGL_API(void, Uniform2iARB, (GLint, GLint, GLint))
AGL_API(void, Uniform3iARB, (GLint, GLint, GLint, GLint))
AGL_API(void, Uniform4iARB, (GLint, GLint, GLint, GLint, GLint))
AGL_API(void, Uniform1fvARB, (GLint, GLsizei, GLfloat *))
AGL_API(void, Uniform2fvARB, (GLint, GLsizei, GLfloat *))
AGL_API(void, Uniform3fvARB, (GLint, GLsizei, GLfloat *))
AGL_API(void, Uniform4fvARB, (GLint, GLsizei, GLfloat *))
AGL_API(void, Uniform1ivARB, (GLint, GLsizei, GLint *))
AGL_API(void, Uniform2ivARB, (GLint, GLsizei, GLint *))
AGL_API(void, Uniform3ivARB, (GLint, GLsizei, GLint *))
AGL_API(void, Uniform4ivARB, (GLint, GLsizei, GLint *))
AGL_API(void, UniformMatrix2fvARB, (GLint, GLsizei, GLboolean, GLfloat *))
AGL_API(void, UniformMatrix3fvARB, (GLint, GLsizei, GLboolean, GLfloat *))
AGL_API(void, UniformMatrix4fvARB, (GLint, GLsizei, GLboolean, GLfloat *))
AGL_API(void, GetObjectParameterfvARB, (GLhandleARB, GLenum, GLfloat *))
AGL_API(void, GetObjectParameterivARB, (GLhandleARB, GLenum, GLint *))
AGL_API(void, GetInfoLogARB, (GLhandleARB, GLsizei, GLsizei *, GLcharARB *))
AGL_API(void, GetAttachedObjectsARB, (GLhandleARB, GLsizei, GLsizei *, GLhandleARB *))
AGL_API(GLint, GetUniformLocationARB, (GLhandleARB, const GLcharARB *))
AGL_API(void, GetActiveUniformARB, (GLhandleARB, GLuint, GLsizei, GLsizei *, GLint *, GLenum *, GLcharARB *))
AGL_API(void, GetUniformfvARB, (GLhandleARB, GLint, GLfloat *))
AGL_API(void, GetUniformivARB, (GLhandleARB, GLint, GLint *))
AGL_API(void, GetShaderSourceARB, (GLhandleARB, GLsizei, GLsizei *, GLcharARB *))
#endif

#ifdef _ALLEGRO_GL_ARB_vertex_shader
#ifndef GL_ARB_vertex_program
AGL_API(void, VertexAttrib1fARB, (GLuint, GLfloat))
AGL_API(void, VertexAttrib1sARB, (GLuint, GLshort))
AGL_API(void, VertexAttrib1dARB, (GLuint, GLdouble))
AGL_API(void, VertexAttrib2fARB, (GLuint, GLfloat, GLfloat))
AGL_API(void, VertexAttrib2sARB, (GLuint, GLshort, GLshort))
AGL_API(void, VertexAttrib2dARB, (GLuint, GLdouble, GLdouble))
AGL_API(void, VertexAttrib3fARB, (GLuint, GLfloat, GLfloat, GLfloat))
AGL_API(void, VertexAttrib3sARB, (GLuint, GLshort, GLshort, GLshort))
AGL_API(void, VertexAttrib3dARB, (GLuint, GLdouble, GLdouble, GLdouble))
AGL_API(void, VertexAttrib4fARB, (GLuint, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, VertexAttrib4sARB, (GLuint, GLshort, GLshort, GLshort, GLshort))
AGL_API(void, VertexAttrib4dARB, (GLuint, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, VertexAttrib4NubARB, (GLuint, GLubyte, GLubyte, GLubyte, GLubyte))
AGL_API(void, VertexAttrib1fvARB, (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib1svARB, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib1dvARB, (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib2fvARB, (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib2svARB, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib2dvARB, (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib3fvARB, (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib3svARB, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib3dvARB, (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib4fvARB, (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib4svARB, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib4dvARB, (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib4ivARB, (GLuint, const GLint *))
AGL_API(void, VertexAttrib4bvARB, (GLuint, const GLbyte *))
AGL_API(void, VertexAttrib4ubvARB, (GLuint, const GLubyte *))
AGL_API(void, VertexAttrib4usvARB, (GLuint, const GLushort *))
AGL_API(void, VertexAttrib4uivARB, (GLuint, const GLuint *))
AGL_API(void, VertexAttrib4NbvARB, (GLuint, const GLbyte *))
AGL_API(void, VertexAttrib4NsvARB, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib4NivARB, (GLuint, const GLint *))
AGL_API(void, VertexAttrib4NubvARB, (GLuint, const GLubyte *))
AGL_API(void, VertexAttrib4NusvARB, (GLuint, const GLushort *))
AGL_API(void, VertexAttrib4NuivARB, (GLuint, const GLuint *))
AGL_API(void, VertexAttribPointerARB, (GLuint, GLint, GLenum, GLboolean, GLsizei, const GLvoid *))
AGL_API(void, EnableVertexAttribArrayARB, (GLuint))
AGL_API(void, DisableVertexAttribArrayARB, (GLuint))
#endif
AGL_API(void, BindAttribLocationARB, (GLhandleARB, GLuint, const GLcharARB *))
AGL_API(void, GetActiveAttribARB, (GLhandleARB, GLuint, GLsizei, GLsizei *, GLint *, GLenum *, GLcharARB *))
AGL_API(GLint, GetAttribLocationARB, (GLhandleARB, const GLcharARB *))
#ifndef GL_ARB_vertex_program
AGL_API(void, GetVertexAttribdvARB, (GLuint, GLenum, GLdouble *))
AGL_API(void, GetVertexAttribfvARB, (GLuint, GLenum, GLfloat *))
AGL_API(void, GetVertexAttribivARB, (GLuint, GLenum, GLint *))
AGL_API(void, GetVertexAttribPointervARB, (GLuint, GLenum, GLvoid **))
#endif
#endif

#if defined _ALLEGRO_GL_ARB_draw_buffers
AGL_API(void, DrawBuffersARB, (GLsizei n, const GLenum *bufs))
#endif

#if defined _ALLEGRO_GL_ARB_color_buffer_float
AGL_API(void, ClampColorARB, (GLenum, GLenum clamp))
#endif

#if defined _ALLEGRO_GL_ARB_draw_instanced
AGL_API(void, DrawArraysInstancedARB, (GLenum, GLint, GLsizei, GLsizei))
AGL_API(void, DrawElementsInstancedARB, (GLenum, GLsizei, GLenum, const GLvoid *, GLsizei))
#endif

#if defined _ALLEGRO_GL_ARB_framebuffer_object
AGL_API(GLboolean, IsRenderbuffer, (GLuint))
AGL_API(void, BindRenderbuffer, (GLenum, GLuint))
AGL_API(void, DeleteRenderbuffers, (GLsizei, const GLuint *))
AGL_API(void, GenRenderbuffers, (GLsizei, GLuint *))
AGL_API(void, RenderbufferStorage, (GLenum, GLenum, GLsizei, GLsizei))
AGL_API(void, GetRenderbufferParameteriv, (GLenum, GLenum, GLint *))
AGL_API(GLboolean, IsFramebuffer, (GLuint))
AGL_API(void, BindFramebuffer, (GLenum, GLuint))
AGL_API(void, DeleteFramebuffers, (GLsizei, const GLuint *))
AGL_API(void, GenFramebuffers, (GLsizei, GLuint *))
AGL_API(GLenum, CheckFramebufferStatus, (GLenum))
AGL_API(void, FramebufferTexture1D, (GLenum, GLenum, GLenum, GLuint, GLint))
AGL_API(void, FramebufferTexture2D, (GLenum, GLenum, GLenum, GLuint, GLint))
AGL_API(void, FramebufferTexture3D, (GLenum, GLenum, GLenum, GLuint, GLint, GLint))
AGL_API(void, FramebufferRenderbuffer, (GLenum, GLenum, GLenum, GLuint))
AGL_API(void, GetFramebufferAttachmentParameteriv, (GLenum, GLenum, GLenum, GLint *))
AGL_API(void, GenerateMipmap, (GLenum))
AGL_API(void, BlitFramebuffer, (GLint, GLint, GLint, GLint, GLint, GLint, GLint, GLint, GLbitfield, GLenum))
AGL_API(void, RenderbufferStorageMultisample, (GLenum, GLsizei, GLenum, GLsizei, GLsizei))
AGL_API(void, FramebufferTextureLayer, (GLenum, GLenum, GLuint, GLint, GLint))
#endif

#if defined _ALLEGRO_GL_ARB_geometry_shader4
AGL_API(void, ProgramParameteriARB, (GLuint, GLenum, GLint))
AGL_API(void, FramebufferTextureARB, (GLenum, GLenum, GLuint, GLint))
AGL_API(void, FramebufferTextureLayerARB, (GLenum, GLenum, GLuint, GLint, GLint))
AGL_API(void, FramebufferTextureFaceARB, (GLenum, GLenum, GLuint, GLint, GLenum))
#endif

#if defined _ALLEGRO_GL_ARB_instanced_arrays
AGL_API(void, VertexAttribDivisor, (GLuint, GLuint))
#endif

#if defined _ALLEGRO_GL_ARB_map_buffer_range
AGL_API(void, MapBufferRange, (GLenum, GLintptr, GLsizeiptr, GLbitfield))
AGL_API(void, FlushMappedBufferRange, (GLenum, GLintptr, GLsizeiptr))
#endif

#if defined _ALLEGRO_GL_ARB_texture_buffer_object
AGL_API(void, TexBufferARB, (GLenum, GLenum, GLuint))
#endif

#if defined _ALLEGRO_GL_ARB_vertex_array_object
AGL_API(void, BindVertexArray, (GLuint))
AGL_API(void, DeleteVertexArrays, (GLsizei, const GLuint *))
AGL_API(void, GenVertexArrays, (GLsizei, GLuint *))
AGL_API(GLboolean, IsVertexArray, (GLuint))
#endif

#if defined _ALLEGRO_GL_ARB_uniform_buffer_object
AGL_API(void, GetUniformIndices, (GLuint, GLsizei, const GLchar* *, GLuint *))
AGL_API(void, GetActiveUniformsiv, (GLuint, GLsizei, const GLuint *, GLenum, GLint *))
AGL_API(void, GetActiveUniformName, (GLuint, GLuint, GLsizei, GLsizei *, GLchar *))
AGL_API(GLuint, GetUniformBlockIndex, (GLuint, const GLchar *))
AGL_API(void, GetActiveUniformBlockiv, (GLuint, GLuint, GLenum, GLint *))
AGL_API(void, GetActiveUniformBlockName, (GLuint, GLuint, GLsizei, GLsizei *, GLchar *))
AGL_API(void, UniformBlockBinding, (GLuint, GLuint, GLuint))
#endif

#if defined _ALLEGRO_GL_ARB_copy_buffer
AGL_API(void, CopyBufferSubData, (GLenum, GLenum, GLintptr, GLintptr, GLsizeiptr))
#endif


#if defined _ALLEGRO_GL_ARB_draw_elements_base_vertex
AGL_API(void, DrawElementsBaseVertex, (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLint basevertex))
AGL_API(void, DrawRangeElementsBaseVertex, (GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, const GLvoid *indices, GLint basevertex))
AGL_API(void, DrawElementsInstancedBaseVertex, (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLsizei primcount, GLint basevertex))
AGL_API(void, MultiDrawElementsBaseVertex, (GLenum mode, const GLsizei *count, GLenum type, const GLvoid* *indices, GLsizei primcount, const GLint *basevertex))
#endif

#if defined _ALLEGRO_GL_ARB_provoking_vertex
AGL_API(void, ProvokingVertex, (GLenum mode))
#endif

#if defined _ALLEGRO_GL_ARB_sync
AGL_API(GLsync, FenceSync, (GLenum condition, GLbitfield flags))
AGL_API(GLboolean, IsSync, (GLsync sync))
AGL_API(void, DeleteSync, (GLsync sync))
AGL_API(GLenum, ClientWaitSync, (GLsync sync, GLbitfield flags, GLuint64 timeout))
AGL_API(void, WaitSync, (GLsync sync, GLbitfield flags, GLuint64 timeout))
AGL_API(void, GetInteger64v, (GLenum pname, GLint64 *params))
AGL_API(void, GetSynciv, (GLsync sync, GLenum pname, GLsizei bufSize, GLsizei *length, GLint *values))
#endif

#if defined _ALLEGRO_GL_ARB_texture_multisample
AGL_API(void, TexImage2DMultisample, (GLenum target, GLsizei samples, GLint internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations))
AGL_API(void, TexImage3DMultisample, (GLenum target, GLsizei samples, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations))
AGL_API(void, GetMultisamplefv, (GLenum pname, GLuint index, GLfloat *val))
AGL_API(void, SampleMaski, (GLuint index, GLbitfield mask))
#endif

#if defined _ALLEGRO_GL_ARB_draw_buffers_blend
AGL_API(void, BlendEquationi, (GLuint buf, GLenum mode))
AGL_API(void, BlendEquationSeparatei, (GLuint buf, GLenum modeRGB, GLenum modeAlpha))
AGL_API(void, BlendFunci, (GLuint buf, GLenum src, GLenum dst))
AGL_API(void, BlendFuncSeparatei, (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha))
#endif

#if defined _ALLEGRO_GL_ARB_sample_shading
AGL_API(void, MinSampleShading, (GLclampf value))
#endif

#if defined _ALLEGRO_GL_ARB_shading_language_include
AGL_API(void, NamedStringARB, (GLenum type, GLint namelen, const GLchar *name, GLint stringlen, const GLchar *string))
AGL_API(void, DeleteNamedStringARB, (GLint namelen, const GLchar *name))
AGL_API(void, CompileShaderIncludeARB, (GLuint shader, GLsizei count, const GLchar* *path, const GLint *length))
AGL_API(GLboolean, IsNamedStringARB, (GLint namelen, const GLchar *name))
AGL_API(void, GetNamedStringARB, (GLint namelen, const GLchar *name, GLsizei bufSize, GLint *stringlen, GLchar *string))
AGL_API(void, GetNamedStringivARB, (GLint namelen, const GLchar *name, GLenum pname, GLint *params))
#endif

#if defined _ALLEGRO_GL_ARB_blend_func_extended
AGL_API(void, BindFragDataLocationIndexed, (GLuint program, GLuint colorNumber, GLuint index, const GLchar *name))
AGL_API(GLint, GetFragDataIndex, (GLuint program, const GLchar *name))
#endif

#if defined _ALLEGRO_GL_ARB_sampler_objects
AGL_API(void, GenSamplers, (GLsizei count, GLuint *samplers))
AGL_API(void, DeleteSamplers, (GLsizei count, const GLuint *samplers))
AGL_API(GLboolean, IsSampler, (GLuint sampler))
AGL_API(void, BindSampler, (GLenum unit, GLuint sampler))
AGL_API(void, SamplerParameteri, (GLuint sampler, GLenum pname, GLint param))
AGL_API(void, SamplerParameteriv, (GLuint sampler, GLenum pname, const GLint *param))
AGL_API(void, SamplerParameterf, (GLuint sampler, GLenum pname, GLfloat param))
AGL_API(void, SamplerParameterfv, (GLuint sampler, GLenum pname, const GLfloat *param))
AGL_API(void, SamplerParameterIiv, (GLuint sampler, GLenum pname, const GLint *param))
AGL_API(void, SamplerParameterIuiv, (GLuint sampler, GLenum pname, const GLuint *param))
AGL_API(void, GetSamplerParameteriv, (GLuint sampler, GLenum pname, GLint *params))
AGL_API(void, GetSamplerParameterIiv, (GLuint sampler, GLenum pname, GLint *params))
AGL_API(void, GetSamplerParameterfv, (GLuint sampler, GLenum pname, GLfloat *params))
AGL_API(void, GetSamplerParameterIfv, (GLuint sampler, GLenum pname, GLfloat *params))
#endif

#if defined _ALLEGRO_GL_ARB_timer_query
AGL_API(void, QueryCounter, (GLuint id, GLenum target))
AGL_API(void, GetQueryObjecti64v, (GLuint id, GLenum pname, GLint64 *params))
AGL_API(void, GetQueryObjectui64v, (GLuint id, GLenum pname, GLuint64 *params))
#endif

#if defined _ALLEGRO_GL_ARB_vertex_type_2_10_10_10_rev
AGL_API(void, VertexP2ui, (GLenum type, GLuint value))
AGL_API(void, VertexP2uiv, (GLenum type, const GLuint *value))
AGL_API(void, VertexP3ui, (GLenum type, GLuint value))
AGL_API(void, VertexP3uiv, (GLenum type, const GLuint *value))
AGL_API(void, VertexP4ui, (GLenum type, GLuint value))
AGL_API(void, VertexP4uiv, (GLenum type, const GLuint *value))
AGL_API(void, TexCoordP1ui, (GLenum type, GLuint coords))
AGL_API(void, TexCoordP1uiv, (GLenum type, const GLuint *coords))
AGL_API(void, TexCoordP2ui, (GLenum type, GLuint coords))
AGL_API(void, TexCoordP2uiv, (GLenum type, const GLuint *coords))
AGL_API(void, TexCoordP3ui, (GLenum type, GLuint coords))
AGL_API(void, TexCoordP3uiv, (GLenum type, const GLuint *coords))
AGL_API(void, TexCoordP4ui, (GLenum type, GLuint coords))
AGL_API(void, TexCoordP4uiv, (GLenum type, const GLuint *coords))
AGL_API(void, MultiTexCoordP1ui, (GLenum texture, GLenum type, GLuint coords))
AGL_API(void, MultiTexCoordP1uiv, (GLenum texture, GLenum type, const GLuint *coords))
AGL_API(void, MultiTexCoordP2ui, (GLenum texture, GLenum type, GLuint coords))
AGL_API(void, MultiTexCoordP2uiv, (GLenum texture, GLenum type, const GLuint *coords))
AGL_API(void, MultiTexCoordP3ui, (GLenum texture, GLenum type, GLuint coords))
AGL_API(void, MultiTexCoordP3uiv, (GLenum texture, GLenum type, const GLuint *coords))
AGL_API(void, MultiTexCoordP4ui, (GLenum texture, GLenum type, GLuint coords))
AGL_API(void, MultiTexCoordP4uiv, (GLenum texture, GLenum type, const GLuint *coords))
AGL_API(void, NormalP3ui, (GLenum type, GLuint coords))
AGL_API(void, NormalP3uiv, (GLenum type, const GLuint *coords))
AGL_API(void, ColorP3ui, (GLenum type, GLuint color))
AGL_API(void, ColorP3uiv, (GLenum type, const GLuint *color))
AGL_API(void, ColorP4ui, (GLenum type, GLuint color))
AGL_API(void, ColorP4uiv, (GLenum type, const GLuint *color))
AGL_API(void, SecondaryColorP3ui, (GLenum type, GLuint color))
AGL_API(void, SecondaryColorP3uiv, (GLenum type, const GLuint *color))
AGL_API(void, VertexAttribP1ui, (GLuint index, GLenum type, GLboolean normalized, GLuint value))
AGL_API(void, VertexAttribP1uiv, (GLuint index, GLenum type, GLboolean normalized, const GLuint *value))
AGL_API(void, VertexAttribP2ui, (GLuint index, GLenum type, GLboolean normalized, GLuint value))
AGL_API(void, VertexAttribP2uiv, (GLuint index, GLenum type, GLboolean normalized, const GLuint *value))
AGL_API(void, VertexAttribP3ui, (GLuint index, GLenum type, GLboolean normalized, GLuint value))
AGL_API(void, VertexAttribP3uiv, (GLuint index, GLenum type, GLboolean normalized, const GLuint *value))
AGL_API(void, VertexAttribP4ui, (GLuint index, GLenum type, GLboolean normalized, GLuint value))
AGL_API(void, VertexAttribP4uiv, (GLuint index, GLenum type, GLboolean normalized, const GLuint *value))
#endif

#if defined _ALLEGRO_GL_ARB_draw_indirect
AGL_API(void, DrawArraysIndirect, (GLenum mode, const GLvoid *indirect))
AGL_API(void, DrawElementsIndirect, (GLenum mode, GLenum type, const GLvoid *indirect))
#endif

#if defined _ALLEGRO_GL_ARB_gpu_shader_fp64
AGL_API(void, Uniform1d, (GLint location, GLdouble x))
AGL_API(void, Uniform2d, (GLint location, GLdouble x, GLdouble y))
AGL_API(void, Uniform3d, (GLint location, GLdouble x, GLdouble y, GLdouble z))
AGL_API(void, Uniform4d, (GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w))
AGL_API(void, Uniform1dv, (GLint location, GLsizei count, const GLdouble *value))
AGL_API(void, Uniform2dv, (GLint location, GLsizei count, const GLdouble *value))
AGL_API(void, Uniform3dv, (GLint location, GLsizei count, const GLdouble *value))
AGL_API(void, Uniform4dv, (GLint location, GLsizei count, const GLdouble *value))
AGL_API(void, UniformMatrix2dv, (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, UniformMatrix3dv, (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, UniformMatrix4dv, (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, UniformMatrix2x3dv, (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, UniformMatrix2x4dv, (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, UniformMatrix3x2dv, (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, UniformMatrix3x4dv, (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, UniformMatrix4x2dv, (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, UniformMatrix4x3dv, (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, GetUniformdv, (GLuint program, GLint location, GLdouble *params))
AGL_API(void, ProgramUniform1dEXT, (GLuint program, GLint location, GLdouble x))
AGL_API(void, ProgramUniform2dEXT, (GLuint program, GLint location, GLdouble x, GLdouble y))
AGL_API(void, ProgramUniform3dEXT, (GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z))
AGL_API(void, ProgramUniform4dEXT, (GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w))
AGL_API(void, ProgramUniform1dvEXT, (GLuint program, GLint location, GLsizei count, const GLdouble *value))
AGL_API(void, ProgramUniform2dvEXT, (GLuint program, GLint location, GLsizei count, const GLdouble *value))
AGL_API(void, ProgramUniform3dvEXT, (GLuint program, GLint location, GLsizei count, const GLdouble *value))
AGL_API(void, ProgramUniform4dvEXT, (GLuint program, GLint location, GLsizei count, const GLdouble *value))
AGL_API(void, ProgramUniformMatrix2dvEXT, (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, ProgramUniformMatrix3dvEXT, (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, ProgramUniformMatrix4dvEXT, (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, ProgramUniformMatrix2x3dvEXT, (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, ProgramUniformMatrix2x4dvEXT, (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, ProgramUniformMatrix3x2dvEXT, (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, ProgramUniformMatrix3x4dvEXT, (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, ProgramUniformMatrix4x2dvEXT, (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
AGL_API(void, ProgramUniformMatrix4x3dvEXT, (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value))
#endif

#if defined _ALLEGRO_GL_ARB_shader_subroutine
AGL_API(GLint, GetSubroutineUniformLocation, (GLuint program, GLenum shadertype, const GLchar *name))
AGL_API(GLuint, GetSubroutineIndex, (GLuint program, GLenum shadertype, const GLchar *name))
AGL_API(void, GetActiveSubroutineUniformiv, (GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint *values))
AGL_API(void, GetActiveSubroutineUniformName, (GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei *length, GLchar *name))
AGL_API(void, GetActiveSubroutineName, (GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei *length, GLchar *name))
AGL_API(void, UniformSubroutinesuiv, (GLenum shadertype, GLsizei count, const GLuint *indices))
AGL_API(void, GetUniformSubroutineuiv, (GLenum shadertype, GLint location, GLuint *params))
AGL_API(void, GetProgramStageiv, (GLuint program, GLenum shadertype, GLenum pname, GLint *values))
#endif

#if defined _ALLEGRO_GL_ARB_tessellation_shader
AGL_API(void, PatchParameteri, (GLenum pname, GLint value))
AGL_API(void, PatchParameterfv, (GLenum pname, const GLfloat *values))
#endif

#if defined _ALLEGRO_GL_ARB_transform_feedback2
AGL_API(void, BindTransformFeedback, (GLenum target, GLuint id))
AGL_API(void, DeleteTransformFeedbacks, (GLsizei n, const GLuint *ids))
AGL_API(void, GenTransformFeedbacks, (GLsizei n, GLuint *ids))
AGL_API(GLboolean, IsTransformFeedback, (GLuint id))
AGL_API(void, PauseTransformFeedback, (void))
AGL_API(void, ResumeTransformFeedback, (void))
AGL_API(void, DrawTransformFeedback, (GLenum mode, GLuint id))
#endif

#if defined _ALLEGRO_GL_ARB_transform_feedback3
AGL_API(void, DrawTransformFeedbackStream, (GLenum mode, GLuint id, GLuint stream))
AGL_API(void, BeginQueryIndexed, (GLenum target, GLuint index, GLuint id))
AGL_API(void, EndQueryIndexed, (GLenum target, GLuint index))
AGL_API(void, GetQueryIndexediv, (GLenum target, GLuint index, GLenum pname, GLint *params))
#endif


/* </ARB> */


#if defined _ALLEGRO_GL_EXT_blend_color
AGL_API(void, BlendColorEXT, (GLclampf, GLclampf, GLclampf, GLclampf))
#endif

#if defined _ALLEGRO_GL_EXT_polygon_offset
AGL_API(void, PolygonOffsetEXT, (GLfloat, GLfloat))
#endif

#if defined _ALLEGRO_GL_EXT_texture3D
AGL_API(void, TexImage3DEXT, (GLenum, GLint, GLenum, GLsizei, GLsizei, GLsizei, GLint, GLenum, GLenum, const GLvoid *))
AGL_API(void, TexSubImage3DEXT, (GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_SGIS_texture_filter4
AGL_API(void, GetTexFilterFuncSGIS, (GLenum, GLenum, GLfloat *))
AGL_API(void, TexFilterFuncSGIS, (GLenum, GLenum, GLsizei, const GLfloat *))
#endif

#if defined _ALLEGRO_GL_EXT_subtexture
AGL_API(void, TexSubImage1DEXT, (GLenum, GLint, GLint, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, TexSubImage2DEXT, (GLenum, GLint, GLint, GLint, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_EXT_copy_texture
AGL_API(void, CopyTexImage1DEXT, (GLenum, GLint, GLenum, GLint, GLint, GLsizei, GLint))
AGL_API(void, CopyTexImage2DEXT, (GLenum, GLint, GLenum, GLint, GLint, GLsizei, GLsizei, GLint))
AGL_API(void, CopyTexSubImage1DEXT, (GLenum, GLint, GLint, GLint, GLint, GLsizei))
AGL_API(void, CopyTexSubImage2DEXT, (GLenum, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei))
AGL_API(void, CopyTexSubImage3DEXT, (GLenum, GLint, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei))
#endif

#if defined _ALLEGRO_GL_EXT_histogram
AGL_API(void, GetHistogramEXT, (GLenum, GLboolean, GLenum, GLenum, GLvoid *))
AGL_API(void, GetHistogramParameterfvEXT, (GLenum, GLenum, GLfloat *))
AGL_API(void, GetHistogramParameterivEXT, (GLenum, GLenum, GLint *))
AGL_API(void, GetMinmaxEXT, (GLenum, GLboolean, GLenum, GLenum, GLvoid *))
AGL_API(void, GetMinmaxParameterfvEXT, (GLenum, GLenum, GLfloat *))
AGL_API(void, GetMinmaxParameterivEXT, (GLenum, GLenum, GLint *))
AGL_API(void, HistogramEXT, (GLenum, GLsizei, GLenum, GLboolean))
AGL_API(void, MinmaxEXT, (GLenum, GLenum, GLboolean))
AGL_API(void, ResetHistogramEXT, (GLenum))
AGL_API(void, ResetMinmaxEXT, (GLenum))
#endif

#if defined _ALLEGRO_GL_EXT_convolution
AGL_API(void, ConvolutionFilter1DEXT, (GLenum, GLenum, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, ConvolutionFilter2DEXT, (GLenum, GLenum, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, ConvolutionParameterfEXT, (GLenum, GLenum, GLfloat))
AGL_API(void, ConvolutionParameterfvEXT, (GLenum, GLenum, const GLfloat *))
AGL_API(void, ConvolutionParameteriEXT, (GLenum, GLenum, GLint))
AGL_API(void, ConvolutionParameterivEXT, (GLenum, GLenum, const GLint *))
AGL_API(void, CopyConvolutionFilter1DEXT, (GLenum, GLenum, GLint, GLint, GLsizei))
AGL_API(void, CopyConvolutionFilter2DEXT, (GLenum, GLenum, GLint, GLint, GLsizei, GLsizei))
AGL_API(void, GetConvolutionFilterEXT, (GLenum, GLenum, GLenum, GLvoid *))
AGL_API(void, GetConvolutionParameterfvEXT, (GLenum, GLenum, GLfloat *))
AGL_API(void, GetConvolutionParameterivEXT, (GLenum, GLenum, GLint *))
AGL_API(void, GetSeparableFilterEXT, (GLenum, GLenum, GLenum, GLvoid *, GLvoid *, GLvoid *))
AGL_API(void, SeparableFilter2DEXT, (GLenum, GLenum, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_SGI_color_table
AGL_API(void, ColorTableSGI, (GLenum, GLenum, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, ColorTableParameterfvSGI, (GLenum, GLenum, const GLfloat *))
AGL_API(void, ColorTableParameterivSGI, (GLenum, GLenum, const GLint *))
AGL_API(void, CopyColorTableSGI, (GLenum, GLenum, GLint, GLint, GLsizei))
AGL_API(void, GetColorTableSGI, (GLenum, GLenum, GLenum, GLvoid *))
AGL_API(void, GetColorTableParameterfvSGI, (GLenum, GLenum, GLfloat *))
AGL_API(void, GetColorTableParameterivSGI, (GLenum, GLenum, GLint *))
#endif

#if defined _ALLEGRO_GL_SGIX_pixel_texture
AGL_API(void, PixelTexGenSGIX, (GLenum))
#endif

#if defined _ALLEGRO_GL_SGIS_pixel_texture
AGL_API(void, PixelTexGenParameteriSGIS, (GLenum, GLint))
AGL_API(void, PixelTexGenParameterivSGIS, (GLenum, const GLint *))
AGL_API(void, PixelTexGenParameterfSGIS, (GLenum, GLfloat))
AGL_API(void, PixelTexGenParameterfvSGIS, (GLenum, const GLfloat *))
AGL_API(void, GetPixelTexGenParameterivSGIS, (GLenum, GLint *))
AGL_API(void, GetPixelTexGenParameterfvSGIS, (GLenum, GLfloat *))
#endif

#if defined _ALLEGRO_GL_SGIS_texture4D
AGL_API(void, TexImage4DSGIS, (GLenum, GLint, GLenum, GLsizei, GLsizei, GLsizei, GLsizei, GLint, GLenum, GLenum, const GLvoid *))
AGL_API(void, TexSubImage4DSGIS, (GLenum, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_EXT_texture_object
AGL_API(GLboolean, AreTexturesResidentEXT, (GLsizei, const GLuint *, GLboolean *))
AGL_API(void, BindTextureEXT, (GLenum, GLuint))
AGL_API(void, DeleteTexturesEXT, (GLsizei, const GLuint *))
AGL_API(void, GenTexturesEXT, (GLsizei, GLuint *))
AGL_API(GLboolean, IsTextureEXT, (GLuint))
AGL_API(void, PrioritizeTexturesEXT, (GLsizei, const GLuint *, const GLclampf *))
#endif

#if defined _ALLEGRO_GL_SGIS_detail_texture
AGL_API(void, DetailTexFuncSGIS, (GLenum, GLsizei, const GLfloat *))
AGL_API(void, GetDetailTexFuncSGIS, (GLenum, GLfloat *))
#endif

#if defined _ALLEGRO_GL_SGIS_sharpen_texture
AGL_API(void, SharpenTexFuncSGIS, (GLenum, GLsizei, const GLfloat *))
AGL_API(void, GetSharpenTexFuncSGIS, (GLenum, GLfloat *))
#endif

#if defined _ALLEGRO_GL_SGIS_multisample
AGL_API(void, SampleMaskSGIS, (GLclampf, GLboolean))
AGL_API(void, SamplePatternSGIS, (GLenum))
#endif

#if defined _ALLEGRO_GL_EXT_vertex_array
AGL_API(void, ArrayElementEXT, (GLint))
AGL_API(void, ColorPointerEXT, (GLint, GLenum, GLsizei, GLsizei, const GLvoid *))
AGL_API(void, DrawArraysEXT, (GLenum, GLint, GLsizei))
AGL_API(void, EdgeFlagPointerEXT, (GLsizei, GLsizei, const GLboolean *))
AGL_API(void, GetPointervEXT, (GLenum, GLvoid* *))
AGL_API(void, IndexPointerEXT, (GLenum, GLsizei, GLsizei, const GLvoid *))
AGL_API(void, NormalPointerEXT, (GLenum, GLsizei, GLsizei, const GLvoid *))
AGL_API(void, TexCoordPointerEXT, (GLint, GLenum, GLsizei, GLsizei, const GLvoid *))
AGL_API(void, VertexPointerEXT, (GLint, GLenum, GLsizei, GLsizei, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_EXT_blend_minmax
AGL_API(void, BlendEquationEXT, (GLenum))
#endif

#if defined _ALLEGRO_GL_SGIX_sprite
AGL_API(void, SpriteParameterfSGIX, (GLenum, GLfloat))
AGL_API(void, SpriteParameterfvSGIX, (GLenum, const GLfloat *))
AGL_API(void, SpriteParameteriSGIX, (GLenum, GLint))
AGL_API(void, SpriteParameterivSGIX, (GLenum, const GLint *))
#endif

#if defined _ALLEGRO_GL_EXT_point_parameters
AGL_API(void, PointParameterfEXT, (GLenum, GLfloat))
AGL_API(void, PointParameterfvEXT, (GLenum, const GLfloat *))
#endif

#if defined _ALLEGRO_GL_SGIS_point_parameters
AGL_API(void, PointParameterfSGIS, (GLenum, GLfloat))
AGL_API(void, PointParameterfvSGIS, (GLenum, const GLfloat *))
#endif

#if defined _ALLEGRO_GL_SGIX_instruments
AGL_API(GLint, GetInstrumentsSGIX, (void))
AGL_API(void, InstrumentsBufferSGIX, (GLsizei, GLint *))
AGL_API(GLint, PollInstrumentsSGIX, (GLint *))
AGL_API(void, ReadInstrumentsSGIX, (GLint))
AGL_API(void, StartInstrumentsSGIX, (void))
AGL_API(void, StopInstrumentsSGIX, (GLint))
#endif

#if defined _ALLEGRO_GL_SGIX_framezoom
AGL_API(void, FrameZoomSGIX, (GLint))
#endif

#if defined _ALLEGRO_GL_SGIX_tag_sample_buffer
AGL_API(void, TagSampleBufferSGIX, (void))
#endif

#if defined _ALLEGRO_GL_SGIX_polynomial_ffd
AGL_API(void, DeformationMap3dSGIX, (GLenum, GLdouble, GLdouble, GLint, GLint, GLdouble, GLdouble, GLint, GLint, GLdouble, GLdouble, GLint, GLint, const GLdouble *))
AGL_API(void, DeformationMap3fSGIX, (GLenum, GLfloat, GLfloat, GLint, GLint, GLfloat, GLfloat, GLint, GLint, GLfloat, GLfloat, GLint, GLint, const GLfloat *))
AGL_API(void, DeformSGIX, (GLbitfield))
AGL_API(void, LoadIdentityDeformationMapSGIX, (GLbitfield))
#endif

#if defined _ALLEGRO_GL_SGIX_reference_plane
AGL_API(void, ReferencePlaneSGIX, (const GLdouble *))
#endif

#if defined _ALLEGRO_GL_SGIX_flush_raster
AGL_API(void, FlushRasterSGIX, (void))
#endif

#if defined _ALLEGRO_GL_SGIS_fog_function
AGL_API(void, FogFuncSGIS, (GLsizei, const GLfloat *))
AGL_API(void, GetFogFuncSGIS, (GLfloat *))
#endif

#if defined _ALLEGRO_GL_HP_image_transform
AGL_API(void, ImageTransformParameteriHP, (GLenum, GLenum, GLint))
AGL_API(void, ImageTransformParameterfHP, (GLenum, GLenum, GLfloat))
AGL_API(void, ImageTransformParameterivHP, (GLenum, GLenum, const GLint *))
AGL_API(void, ImageTransformParameterfvHP, (GLenum, GLenum, const GLfloat *))
AGL_API(void, GetImageTransformParameterivHP, (GLenum, GLenum, GLint *))
AGL_API(void, GetImageTransformParameterfvHP, (GLenum, GLenum, GLfloat *))
#endif

#if defined _ALLEGRO_GL_EXT_color_subtable
#ifndef GL_EXT_paletted_texture
AGL_API(void, ColorSubTableEXT, (GLenum, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *))
#endif
AGL_API(void, CopyColorSubTableEXT, (GLenum, GLsizei, GLint, GLint, GLsizei))
#endif

#if defined _ALLEGRO_GL_PGI_misc_hints
AGL_API(void, HintPGI, (GLenum, GLint))
#endif

#if defined _ALLEGRO_GL_EXT_paletted_texture
AGL_API(void, ColorTableEXT, (GLenum, GLenum, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, GetColorTableEXT, (GLenum, GLenum, GLenum, GLvoid *))
AGL_API(void, GetColorTableParameterivEXT, (GLenum, GLenum, GLint *))
AGL_API(void, GetColorTableParameterfvEXT, (GLenum, GLenum, GLfloat *))
#endif

#if defined _ALLEGRO_GL_SGIX_list_priority
AGL_API(void, GetListParameterfvSGIX, (GLuint, GLenum, GLfloat *))
AGL_API(void, GetListParameterivSGIX, (GLuint, GLenum, GLint *))
AGL_API(void, ListParameterfSGIX, (GLuint, GLenum, GLfloat))
AGL_API(void, ListParameterfvSGIX, (GLuint, GLenum, const GLfloat *))
AGL_API(void, ListParameteriSGIX, (GLuint, GLenum, GLint))
AGL_API(void, ListParameterivSGIX, (GLuint, GLenum, const GLint *))
#endif

#if defined _ALLEGRO_GL_EXT_index_material
AGL_API(void, IndexMaterialEXT, (GLenum, GLenum))
#endif

#if defined _ALLEGRO_GL_EXT_index_func
AGL_API(void, IndexFuncEXT, (GLenum, GLclampf))
#endif

#if defined _ALLEGRO_GL_EXT_compiled_vertex_array
AGL_API(void, LockArraysEXT, (GLint, GLsizei))
AGL_API(void, UnlockArraysEXT, (void))
#endif

#if defined _ALLEGRO_GL_EXT_cull_vertex
AGL_API(void, CullParameterdvEXT, (GLenum, GLdouble *))
AGL_API(void, CullParameterfvEXT, (GLenum, GLfloat *))
#endif

#if defined _ALLEGRO_GL_SGIX_fragment_lighting
AGL_API(void, FragmentColorMaterialSGIX, (GLenum, GLenum))
AGL_API(void, FragmentLightfSGIX, (GLenum, GLenum, GLfloat))
AGL_API(void, FragmentLightfvSGIX, (GLenum, GLenum, const GLfloat *))
AGL_API(void, FragmentLightiSGIX, (GLenum, GLenum, GLint))
AGL_API(void, FragmentLightivSGIX, (GLenum, GLenum, const GLint *))
AGL_API(void, FragmentLightModelfSGIX, (GLenum, GLfloat))
AGL_API(void, FragmentLightModelfvSGIX, (GLenum, const GLfloat *))
AGL_API(void, FragmentLightModeliSGIX, (GLenum, GLint))
AGL_API(void, FragmentLightModelivSGIX, (GLenum, const GLint *))
AGL_API(void, FragmentMaterialfSGIX, (GLenum, GLenum, GLfloat))
AGL_API(void, FragmentMaterialfvSGIX, (GLenum, GLenum, const GLfloat *))
AGL_API(void, FragmentMaterialiSGIX, (GLenum, GLenum, GLint))
AGL_API(void, FragmentMaterialivSGIX, (GLenum, GLenum, const GLint *))
AGL_API(void, GetFragmentLightfvSGIX, (GLenum, GLenum, GLfloat *))
AGL_API(void, GetFragmentLightivSGIX, (GLenum, GLenum, GLint *))
AGL_API(void, GetFragmentMaterialfvSGIX, (GLenum, GLenum, GLfloat *))
AGL_API(void, GetFragmentMaterialivSGIX, (GLenum, GLenum, GLint *))
AGL_API(void, LightEnviSGIX, (GLenum, GLint))
#endif

#if defined _ALLEGRO_GL_EXT_draw_range_elements
AGL_API(void, DrawRangeElementsEXT, (GLenum, GLuint, GLuint, GLsizei, GLenum, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_EXT_light_texture
AGL_API(void, ApplyTextureEXT, (GLenum))
AGL_API(void, TextureLightEXT, (GLenum))
AGL_API(void, TextureMaterialEXT, (GLenum, GLenum))
#endif

#if defined _ALLEGRO_GL_SGIX_async
AGL_API(void, AsyncMarkerSGIX, (GLuint))
AGL_API(GLint, FinishAsyncSGIX, (GLuint *))
AGL_API(GLint, PollAsyncSGIX, (GLuint *))
AGL_API(GLuint, GenAsyncMarkersSGIX, (GLsizei))
AGL_API(void, DeleteAsyncMarkersSGIX, (GLuint, GLsizei))
AGL_API(GLboolean, IsAsyncMarkerSGIX, (GLuint))
#endif

#if defined _ALLEGRO_GL_INTEL_parallel_arrays
AGL_API(void, VertexPointervINTEL, (GLint, GLenum, const GLvoid* *))
AGL_API(void, NormalPointervINTEL, (GLenum, const GLvoid* *))
AGL_API(void, ColorPointervINTEL, (GLint, GLenum, const GLvoid* *))
AGL_API(void, TexCoordPointervINTEL, (GLint, GLenum, const GLvoid* *))
#endif

#if defined _ALLEGRO_GL_EXT_pixel_transform
AGL_API(void, PixelTransformParameteriEXT, (GLenum, GLenum, GLint))
AGL_API(void, PixelTransformParameterfEXT, (GLenum, GLenum, GLfloat))
AGL_API(void, PixelTransformParameterivEXT, (GLenum, GLenum, const GLint *))
AGL_API(void, PixelTransformParameterfvEXT, (GLenum, GLenum, const GLfloat *))
#endif

#if defined _ALLEGRO_GL_EXT_secondary_color
AGL_API(void, SecondaryColor3bEXT, (GLbyte, GLbyte, GLbyte))
AGL_API(void, SecondaryColor3bvEXT, (const GLbyte *))
AGL_API(void, SecondaryColor3dEXT, (GLdouble, GLdouble, GLdouble))
AGL_API(void, SecondaryColor3dvEXT, (const GLdouble *))
AGL_API(void, SecondaryColor3fEXT, (GLfloat, GLfloat, GLfloat))
AGL_API(void, SecondaryColor3fvEXT, (const GLfloat *))
AGL_API(void, SecondaryColor3iEXT, (GLint, GLint, GLint))
AGL_API(void, SecondaryColor3ivEXT, (const GLint *))
AGL_API(void, SecondaryColor3sEXT, (GLshort, GLshort, GLshort))
AGL_API(void, SecondaryColor3svEXT, (const GLshort *))
AGL_API(void, SecondaryColor3ubEXT, (GLubyte, GLubyte, GLubyte))
AGL_API(void, SecondaryColor3ubvEXT, (const GLubyte *))
AGL_API(void, SecondaryColor3uiEXT, (GLuint, GLuint, GLuint))
AGL_API(void, SecondaryColor3uivEXT, (const GLuint *))
AGL_API(void, SecondaryColor3usEXT, (GLushort, GLushort, GLushort))
AGL_API(void, SecondaryColor3usvEXT, (const GLushort *))
AGL_API(void, SecondaryColorPointerEXT, (GLint, GLenum, GLsizei, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_EXT_texture_perturb_normal
AGL_API(void, TextureNormalEXT, (GLenum))
#endif

#if defined _ALLEGRO_GL_EXT_multi_draw_arrays
AGL_API(void, MultiDrawArraysEXT, (GLenum, GLint *, GLsizei *, GLsizei))
AGL_API(void, MultiDrawElementsEXT, (GLenum, const GLsizei *, GLenum, const GLvoid* *, GLsizei))
#endif

#if defined _ALLEGRO_GL_EXT_fog_coord
AGL_API(void, FogCoordfEXT, (GLfloat))
AGL_API(void, FogCoordfvEXT, (const GLfloat *))
AGL_API(void, FogCoorddEXT, (GLdouble))
AGL_API(void, FogCoorddvEXT, (const GLdouble *))
AGL_API(void, FogCoordPointerEXT, (GLenum, GLsizei, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_EXT_coordinate_frame
AGL_API(void, Tangent3bEXT, (GLbyte, GLbyte, GLbyte))
AGL_API(void, Tangent3bvEXT, (const GLbyte *))
AGL_API(void, Tangent3dEXT, (GLdouble, GLdouble, GLdouble))
AGL_API(void, Tangent3dvEXT, (const GLdouble *))
AGL_API(void, Tangent3fEXT, (GLfloat, GLfloat, GLfloat))
AGL_API(void, Tangent3fvEXT, (const GLfloat *))
AGL_API(void, Tangent3iEXT, (GLint, GLint, GLint))
AGL_API(void, Tangent3ivEXT, (const GLint *))
AGL_API(void, Tangent3sEXT, (GLshort, GLshort, GLshort))
AGL_API(void, Tangent3svEXT, (const GLshort *))
AGL_API(void, Binormal3bEXT, (GLbyte, GLbyte, GLbyte))
AGL_API(void, Binormal3bvEXT, (const GLbyte *))
AGL_API(void, Binormal3dEXT, (GLdouble, GLdouble, GLdouble))
AGL_API(void, Binormal3dvEXT, (const GLdouble *))
AGL_API(void, Binormal3fEXT, (GLfloat, GLfloat, GLfloat))
AGL_API(void, Binormal3fvEXT, (const GLfloat *))
AGL_API(void, Binormal3iEXT, (GLint, GLint, GLint))
AGL_API(void, Binormal3ivEXT, (const GLint *))
AGL_API(void, Binormal3sEXT, (GLshort, GLshort, GLshort))
AGL_API(void, Binormal3svEXT, (const GLshort *))
AGL_API(void, TangentPointerEXT, (GLenum, GLsizei, const GLvoid *))
AGL_API(void, BinormalPointerEXT, (GLenum, GLsizei, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_SUNX_constant_data
AGL_API(void, FinishTextureSUNX, (void))
#endif

#if defined _ALLEGRO_GL_SUN_global_alpha
AGL_API(void, GlobalAlphaFactorbSUN, (GLbyte))
AGL_API(void, GlobalAlphaFactorsSUN, (GLshort))
AGL_API(void, GlobalAlphaFactoriSUN, (GLint))
AGL_API(void, GlobalAlphaFactorfSUN, (GLfloat))
AGL_API(void, GlobalAlphaFactordSUN, (GLdouble))
AGL_API(void, GlobalAlphaFactorubSUN, (GLubyte))
AGL_API(void, GlobalAlphaFactorusSUN, (GLushort))
AGL_API(void, GlobalAlphaFactoruiSUN, (GLuint))
#endif

#if defined _ALLEGRO_GL_SUN_triangle_list
AGL_API(void, ReplacementCodeuiSUN, (GLuint))
AGL_API(void, ReplacementCodeusSUN, (GLushort))
AGL_API(void, ReplacementCodeubSUN, (GLubyte))
AGL_API(void, ReplacementCodeuivSUN, (const GLuint *))
AGL_API(void, ReplacementCodeusvSUN, (const GLushort *))
AGL_API(void, ReplacementCodeubvSUN, (const GLubyte *))
AGL_API(void, ReplacementCodePointerSUN, (GLenum, GLsizei, const GLvoid* *))
#endif

#if defined _ALLEGRO_GL_SUN_vertex
AGL_API(void, Color4ubVertex2fSUN, (GLubyte, GLubyte, GLubyte, GLubyte, GLfloat, GLfloat))
AGL_API(void, Color4ubVertex2fvSUN, (const GLubyte *, const GLfloat *))
AGL_API(void, Color4ubVertex3fSUN, (GLubyte, GLubyte, GLubyte, GLubyte, GLfloat, GLfloat, GLfloat))
AGL_API(void, Color4ubVertex3fvSUN, (const GLubyte *, const GLfloat *))
AGL_API(void, Color3fVertex3fSUN, (GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, Color3fVertex3fvSUN, (const GLfloat *, const GLfloat *))
AGL_API(void, Normal3fVertex3fSUN, (GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, Normal3fVertex3fvSUN, (const GLfloat *, const GLfloat *))
AGL_API(void, Color4fNormal3fVertex3fSUN, (GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, Color4fNormal3fVertex3fvSUN, (const GLfloat *, const GLfloat *, const GLfloat *))
AGL_API(void, TexCoord2fVertex3fSUN, (GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, TexCoord2fVertex3fvSUN, (const GLfloat *, const GLfloat *))
AGL_API(void, TexCoord4fVertex4fSUN, (GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, TexCoord4fVertex4fvSUN, (const GLfloat *, const GLfloat *))
AGL_API(void, TexCoord2fColor4ubVertex3fSUN, (GLfloat, GLfloat, GLubyte, GLubyte, GLubyte, GLubyte, GLfloat, GLfloat, GLfloat))
AGL_API(void, TexCoord2fColor4ubVertex3fvSUN, (const GLfloat *, const GLubyte *, const GLfloat *))
AGL_API(void, TexCoord2fColor3fVertex3fSUN, (GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, TexCoord2fColor3fVertex3fvSUN, (const GLfloat *, const GLfloat *, const GLfloat *))
AGL_API(void, TexCoord2fNormal3fVertex3fSUN, (GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, TexCoord2fNormal3fVertex3fvSUN, (const GLfloat *, const GLfloat *, const GLfloat *))
AGL_API(void, TexCoord2fColor4fNormal3fVertex3fSUN, (GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, TexCoord2fColor4fNormal3fVertex3fvSUN, (const GLfloat *, const GLfloat *, const GLfloat *, const GLfloat *))
AGL_API(void, TexCoord4fColor4fNormal3fVertex4fSUN, (GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, TexCoord4fColor4fNormal3fVertex4fvSUN, (const GLfloat *, const GLfloat *, const GLfloat *, const GLfloat *))
AGL_API(void, ReplacementCodeuiVertex3fSUN, (GLuint, GLfloat, GLfloat, GLfloat))
AGL_API(void, ReplacementCodeuiVertex3fvSUN, (const GLuint *, const GLfloat *))
AGL_API(void, ReplacementCodeuiColor4ubVertex3fSUN, (GLuint, GLubyte, GLubyte, GLubyte, GLubyte, GLfloat, GLfloat, GLfloat))
AGL_API(void, ReplacementCodeuiColor4ubVertex3fvSUN, (const GLuint *, const GLubyte *, const GLfloat *))
AGL_API(void, ReplacementCodeuiColor3fVertex3fSUN, (GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, ReplacementCodeuiColor3fVertex3fvSUN, (const GLuint *, const GLfloat *, const GLfloat *))
AGL_API(void, ReplacementCodeuiNormal3fVertex3fSUN, (GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, ReplacementCodeuiNormal3fVertex3fvSUN, (const GLuint *, const GLfloat *, const GLfloat *))
AGL_API(void, ReplacementCodeuiColor4fNormal3fVertex3fSUN, (GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, ReplacementCodeuiColor4fNormal3fVertex3fvSUN, (const GLuint *, const GLfloat *, const GLfloat *, const GLfloat *))
AGL_API(void, ReplacementCodeuiTexCoord2fVertex3fSUN, (GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, ReplacementCodeuiTexCoord2fVertex3fvSUN, (const GLuint *, const GLfloat *, const GLfloat *))
AGL_API(void, ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN, (GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN, (const GLuint *, const GLfloat *, const GLfloat *, const GLfloat *))
AGL_API(void, ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN, (GLuint, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN, (const GLuint *, const GLfloat *, const GLfloat *, const GLfloat *, const GLfloat *))
#endif
	
#if defined _ALLEGRO_GL_EXT_blend_func_separate
AGL_API(void, BlendFuncSeparateEXT, (GLenum, GLenum, GLenum, GLenum))
#endif

#if defined _ALLEGRO_GL_INGR_blend_func_separate
AGL_API(void, BlendFuncSeparateINGR, (GLenum, GLenum, GLenum, GLenum))
#endif

#if defined _ALLEGRO_GL_EXT_vertex_weighting
AGL_API(void, VertexWeightfEXT, (GLfloat))
AGL_API(void, VertexWeightfvEXT, (const GLfloat *))
AGL_API(void, VertexWeightPointerEXT, (GLsizei, GLenum, GLsizei, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_NV_vertex_array_range
AGL_API(void, FlushVertexArrayRangeNV, (void))
AGL_API(void, VertexArrayRangeNV, (GLsizei, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_NV_register_combiners
AGL_API(void, CombinerParameterfvNV, (GLenum, const GLfloat *))
AGL_API(void, CombinerParameterfNV, (GLenum, GLfloat))
AGL_API(void, CombinerParameterivNV, (GLenum, const GLint *))
AGL_API(void, CombinerParameteriNV, (GLenum, GLint))
AGL_API(void, CombinerInputNV, (GLenum, GLenum, GLenum, GLenum, GLenum, GLenum))
AGL_API(void, CombinerOutputNV, (GLenum, GLenum, GLenum, GLenum, GLenum, GLenum, GLenum, GLboolean, GLboolean, GLboolean))
AGL_API(void, FinalCombinerInputNV, (GLenum, GLenum, GLenum, GLenum))
AGL_API(void, GetCombinerInputParameterfvNV, (GLenum, GLenum, GLenum, GLenum, GLfloat *))
AGL_API(void, GetCombinerInputParameterivNV, (GLenum, GLenum, GLenum, GLenum, GLint *))
AGL_API(void, GetCombinerOutputParameterfvNV, (GLenum, GLenum, GLenum, GLfloat *))
AGL_API(void, GetCombinerOutputParameterivNV, (GLenum, GLenum, GLenum, GLint *))
AGL_API(void, GetFinalCombinerInputParameterfvNV, (GLenum, GLenum, GLfloat *))
AGL_API(void, GetFinalCombinerInputParameterivNV, (GLenum, GLenum, GLint *))
#endif

#if defined _ALLEGRO_GL_MESA_resize_buffers
AGL_API(void, ResizeBuffersMESA, (void))
#endif

#if defined _ALLEGRO_GL_MESA_window_pos
AGL_API(void, WindowPos2dMESA, (GLdouble, GLdouble))
AGL_API(void, WindowPos2dvMESA, (const GLdouble *))
AGL_API(void, WindowPos2fMESA, (GLfloat, GLfloat))
AGL_API(void, WindowPos2fvMESA, (const GLfloat *))
AGL_API(void, WindowPos2iMESA, (GLint, GLint))
AGL_API(void, WindowPos2ivMESA, (const GLint *))
AGL_API(void, WindowPos2sMESA, (GLshort, GLshort))
AGL_API(void, WindowPos2svMESA, (const GLshort *))
AGL_API(void, WindowPos3dMESA, (GLdouble, GLdouble, GLdouble))
AGL_API(void, WindowPos3dvMESA, (const GLdouble *))
AGL_API(void, WindowPos3fMESA, (GLfloat, GLfloat, GLfloat))
AGL_API(void, WindowPos3fvMESA, (const GLfloat *))
AGL_API(void, WindowPos3iMESA, (GLint, GLint, GLint))
AGL_API(void, WindowPos3ivMESA, (const GLint *))
AGL_API(void, WindowPos3sMESA, (GLshort, GLshort, GLshort))
AGL_API(void, WindowPos3svMESA, (const GLshort *))
AGL_API(void, WindowPos4dMESA, (GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, WindowPos4dvMESA, (const GLdouble *))
AGL_API(void, WindowPos4fMESA, (GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, WindowPos4fvMESA, (const GLfloat *))
AGL_API(void, WindowPos4iMESA, (GLint, GLint, GLint, GLint))
AGL_API(void, WindowPos4ivMESA, (const GLint *))
AGL_API(void, WindowPos4sMESA, (GLshort, GLshort, GLshort, GLshort))
AGL_API(void, WindowPos4svMESA, (const GLshort *))
#endif

#if defined _ALLEGRO_GL_IBM_multimode_draw_arrays
AGL_API(void, MultiModeDrawArraysIBM, (GLenum, const GLint *, const GLsizei *, GLsizei, GLint))
AGL_API(void, MultiModeDrawElementsIBM, (const GLenum *, const GLsizei *, GLenum, const GLvoid* *, GLsizei, GLint))
#endif

#ifdef AGK_IBM_vertex_array_lists
AGL_API(void, ColorPointerListIBM, (GLint, GLenum, GLint, const GLvoid* *, GLint))
AGL_API(void, SecondaryColorPointerListIBM, (GLint, GLenum, GLint, const GLvoid* *, GLint))
AGL_API(void, EdgeFlagPointerListIBM, (GLint, const GLboolean* *, GLint))
AGL_API(void, FogCoordPointerListIBM, (GLenum, GLint, const GLvoid* *, GLint))
AGL_API(void, IndexPointerListIBM, (GLenum, GLint, const GLvoid* *, GLint))
AGL_API(void, NormalPointerListIBM, (GLenum, GLint, const GLvoid* *, GLint))
AGL_API(void, TexCoordPointerListIBM, (GLint, GLenum, GLint, const GLvoid* *, GLint))
AGL_API(void, VertexPointerListIBM, (GLint, GLenum, GLint, const GLvoid* *, GLint))
#endif

#if defined _ALLEGRO_GL_3DFX_tbuffer
AGL_API(void, TbufferMask3DFX, (GLuint))
#endif

#if defined _ALLEGRO_GL_EXT_multisample
AGL_API(void, SampleMaskEXT, (GLclampf, GLboolean))
AGL_API(void, SamplePatternEXT, (GLenum))
#endif

#if defined _ALLEGRO_GL_SGIS_texture_color_mask
AGL_API(void, TextureColorMaskSGIS, (GLboolean, GLboolean, GLboolean, GLboolean))
#endif

#if defined _ALLEGRO_GL_SGIX_igloo_interface
AGL_API(void, IglooInterfaceSGIX, (GLenum, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_NV_fence
AGL_API(void, DeleteFencesNV, (GLsizei, const GLuint *))
AGL_API(void, GenFencesNV, (GLsizei, GLuint *))
AGL_API(GLboolean, IsFenceNV, (GLuint))
AGL_API(GLboolean, TestFenceNV, (GLuint))
AGL_API(void, GetFenceivNV, (GLuint, GLenum, GLint *))
AGL_API(void, FinishFenceNV, (GLuint))
AGL_API(void, SetFenceNV, (GLuint, GLenum))
#endif

#if defined _ALLEGRO_GL_NV_evaluators
AGL_API(void, MapControlPointsNV, (GLenum, GLuint, GLenum, GLsizei, GLsizei, GLint, GLint, GLboolean, const GLvoid *))
AGL_API(void, MapParameterivNV, (GLenum, GLenum, const GLint *))
AGL_API(void, MapParameterfvNV, (GLenum, GLenum, const GLfloat *))
AGL_API(void, GetMapControlPointsNV, (GLenum, GLuint, GLenum, GLsizei, GLsizei, GLboolean, GLvoid *))
AGL_API(void, GetMapParameterivNV, (GLenum, GLenum, GLint *))
AGL_API(void, GetMapParameterfvNV, (GLenum, GLenum, GLfloat *))
AGL_API(void, GetMapAttribParameterivNV, (GLenum, GLuint, GLenum, GLint *))
AGL_API(void, GetMapAttribParameterfvNV, (GLenum, GLuint, GLenum, GLfloat *))
AGL_API(void, EvalMapsNV, (GLenum, GLenum))
#endif

#if defined _ALLEGRO_GL_NV_register_combiners2
AGL_API(void, CombinerStageParameterfvNV, (GLenum, GLenum, const GLfloat *))
AGL_API(void, GetCombinerStageParameterfvNV, (GLenum, GLenum, GLfloat *))
#endif

#if defined _ALLEGRO_GL_NV_vertex_program
AGL_API(GLboolean, AreProgramsResidentNV, (GLsizei, const GLuint *, GLboolean *))
AGL_API(void, BindProgramNV, (GLenum, GLuint))
AGL_API(void, DeleteProgramsNV, (GLsizei, const GLuint *))
AGL_API(void, ExecuteProgramNV, (GLenum, GLuint, const GLfloat *))
AGL_API(void, GenProgramsNV, (GLsizei, GLuint *))
AGL_API(void, GetProgramParameterdvNV, (GLenum, GLuint, GLenum, GLdouble *))
AGL_API(void, GetProgramParameterfvNV, (GLenum, GLuint, GLenum, GLfloat *))
AGL_API(void, GetProgramivNV, (GLuint, GLenum, GLint *))
AGL_API(void, GetProgramStringNV, (GLuint, GLenum, GLubyte *))
AGL_API(void, GetTrackMatrixivNV, (GLenum, GLuint, GLenum, GLint *))
AGL_API(void, GetVertexAttribdvNV, (GLuint, GLenum, GLdouble *))
AGL_API(void, GetVertexAttribfvNV, (GLuint, GLenum, GLfloat *))
AGL_API(void, GetVertexAttribivNV, (GLuint, GLenum, GLint *))
AGL_API(void, GetVertexAttribPointervNV, (GLuint, GLenum, GLvoid* *))
AGL_API(GLboolean, IsProgramNV, (GLuint))
AGL_API(void, LoadProgramNV, (GLenum, GLuint, GLsizei, const GLubyte *))
AGL_API(void, ProgramParameter4dNV, (GLenum, GLuint, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, ProgramParameter4dvNV, (GLenum, GLuint, const GLdouble *))
AGL_API(void, ProgramParameter4fNV, (GLenum, GLuint, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, ProgramParameter4fvNV, (GLenum, GLuint, const GLfloat *))
AGL_API(void, ProgramParameters4dvNV, (GLenum, GLuint, GLuint, const GLdouble *))
AGL_API(void, ProgramParameters4fvNV, (GLenum, GLuint, GLuint, const GLfloat *))
AGL_API(void, RequestResidentProgramsNV, (GLsizei, const GLuint *))
AGL_API(void, TrackMatrixNV, (GLenum, GLuint, GLenum, GLenum))
AGL_API(void, VertexAttribPointerNV, (GLuint, GLint, GLenum, GLsizei, const GLvoid *))
AGL_API(void, VertexAttrib1dNV, (GLuint, GLdouble))
AGL_API(void, VertexAttrib1dvNV, (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib1fNV, (GLuint, GLfloat))
AGL_API(void, VertexAttrib1fvNV, (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib1sNV, (GLuint, GLshort))
AGL_API(void, VertexAttrib1svNV, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib2dNV, (GLuint, GLdouble, GLdouble))
AGL_API(void, VertexAttrib2dvNV, (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib2fNV, (GLuint, GLfloat, GLfloat))
AGL_API(void, VertexAttrib2fvNV, (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib2sNV, (GLuint, GLshort, GLshort))
AGL_API(void, VertexAttrib2svNV, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib3dNV, (GLuint, GLdouble, GLdouble, GLdouble))
AGL_API(void, VertexAttrib3dvNV, (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib3fNV, (GLuint, GLfloat, GLfloat, GLfloat))
AGL_API(void, VertexAttrib3fvNV, (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib3sNV, (GLuint, GLshort, GLshort, GLshort))
AGL_API(void, VertexAttrib3svNV, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib4dNV, (GLuint, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, VertexAttrib4dvNV, (GLuint, const GLdouble *))
AGL_API(void, VertexAttrib4fNV, (GLuint, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, VertexAttrib4fvNV, (GLuint, const GLfloat *))
AGL_API(void, VertexAttrib4sNV, (GLuint, GLshort, GLshort, GLshort, GLshort))
AGL_API(void, VertexAttrib4svNV, (GLuint, const GLshort *))
AGL_API(void, VertexAttrib4ubNV, (GLuint, GLubyte, GLubyte, GLubyte, GLubyte))
AGL_API(void, VertexAttrib4ubvNV, (GLuint, const GLubyte *))
AGL_API(void, VertexAttribs1dvNV, (GLuint, GLsizei, const GLdouble *))
AGL_API(void, VertexAttribs1fvNV, (GLuint, GLsizei, const GLfloat *))
AGL_API(void, VertexAttribs1svNV, (GLuint, GLsizei, const GLshort *))
AGL_API(void, VertexAttribs2dvNV, (GLuint, GLsizei, const GLdouble *))
AGL_API(void, VertexAttribs2fvNV, (GLuint, GLsizei, const GLfloat *))
AGL_API(void, VertexAttribs2svNV, (GLuint, GLsizei, const GLshort *))
AGL_API(void, VertexAttribs3dvNV, (GLuint, GLsizei, const GLdouble *))
AGL_API(void, VertexAttribs3fvNV, (GLuint, GLsizei, const GLfloat *))
AGL_API(void, VertexAttribs3svNV, (GLuint, GLsizei, const GLshort *))
AGL_API(void, VertexAttribs4dvNV, (GLuint, GLsizei, const GLdouble *))
AGL_API(void, VertexAttribs4fvNV, (GLuint, GLsizei, const GLfloat *))
AGL_API(void, VertexAttribs4svNV, (GLuint, GLsizei, const GLshort *))
AGL_API(void, VertexAttribs4ubvNV, (GLuint, GLsizei, const GLubyte *))
#endif

#if defined _ALLEGRO_GL_ATI_envmap_bumpmap
AGL_API(void, TexBumpParameterivATI, (GLenum, const GLint *))
AGL_API(void, TexBumpParameterfvATI, (GLenum, const GLfloat *))
AGL_API(void, GetTexBumpParameterivATI, (GLenum, GLint *))
AGL_API(void, GetTexBumpParameterfvATI, (GLenum, GLfloat *))
#endif

#if defined _ALLEGRO_GL_ATI_fragment_shader
AGL_API(GLuint, GenFragmentShadersATI, (GLuint))
AGL_API(void, BindFragmentShaderATI, (GLuint))
AGL_API(void, DeleteFragmentShaderATI, (GLuint))
AGL_API(void, BeginFragmentShaderATI, (void))
AGL_API(void, EndFragmentShaderATI, (void))
AGL_API(void, PassTexCoordATI, (GLuint, GLuint, GLenum))
AGL_API(void, SampleMapATI, (GLuint, GLuint, GLenum))
AGL_API(void, ColorFragmentOp1ATI, (GLenum, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, ColorFragmentOp2ATI, (GLenum, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, ColorFragmentOp3ATI, (GLenum, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, AlphaFragmentOp1ATI, (GLenum, GLuint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, AlphaFragmentOp2ATI, (GLenum, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, AlphaFragmentOp3ATI, (GLenum, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, SetFragmentShaderConstantATI, (GLuint, const GLfloat *))
#endif

#if defined _ALLEGRO_GL_ATI_pn_triangles
AGL_API(void, PNTrianglesiATI, (GLenum, GLint))
AGL_API(void, PNTrianglesfATI, (GLenum, GLfloat))
#endif

#if defined _ALLEGRO_GL_ATI_vertex_array_object
AGL_API(GLuint, NewObjectBufferATI, (GLsizei, const GLvoid *, GLenum))
AGL_API(GLboolean, IsObjectBufferATI, (GLuint))
AGL_API(void, UpdateObjectBufferATI, (GLuint, GLuint, GLsizei, const GLvoid *, GLenum))
AGL_API(void, GetObjectBufferfvATI, (GLuint, GLenum, GLfloat *))
AGL_API(void, GetObjectBufferivATI, (GLuint, GLenum, GLint *))
AGL_API(void, FreeObjectBufferATI, (GLuint))
AGL_API(void, ArrayObjectATI, (GLenum, GLint, GLenum, GLsizei, GLuint, GLuint))
AGL_API(void, GetArrayObjectfvATI, (GLenum, GLenum, GLfloat *))
AGL_API(void, GetArrayObjectivATI, (GLenum, GLenum, GLint *))
AGL_API(void, VariantArrayObjectATI, (GLuint, GLenum, GLsizei, GLuint, GLuint))
AGL_API(void, GetVariantArrayObjectfvATI, (GLuint, GLenum, GLfloat *))
AGL_API(void, GetVariantArrayObjectivATI, (GLuint, GLenum, GLint *))
#endif

#if defined _ALLEGRO_GL_EXT_vertex_shader
AGL_API(void, BeginVertexShaderEXT, (void))
AGL_API(void, EndVertexShaderEXT, (void))
AGL_API(void, BindVertexShaderEXT, (GLuint))
AGL_API(GLuint, GenVertexShadersEXT, (GLuint))
AGL_API(void, DeleteVertexShaderEXT, (GLuint))
AGL_API(void, ShaderOp1EXT, (GLenum, GLuint, GLuint))
AGL_API(void, ShaderOp2EXT, (GLenum, GLuint, GLuint, GLuint))
AGL_API(void, ShaderOp3EXT, (GLenum, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, SwizzleEXT, (GLuint, GLuint, GLenum, GLenum, GLenum, GLenum))
AGL_API(void, WriteMaskEXT, (GLuint, GLuint, GLenum, GLenum, GLenum, GLenum))
AGL_API(void, InsertComponentEXT, (GLuint, GLuint, GLuint))
AGL_API(void, ExtractComponentEXT, (GLuint, GLuint, GLuint))
AGL_API(GLuint, GenSymbolsEXT, (GLenum, GLenum, GLenum, GLuint))
AGL_API(void, SetInvariantEXT, (GLuint, GLenum, const GLvoid *))
AGL_API(void, SetLocalConstantEXT, (GLuint, GLenum, const GLvoid *))
AGL_API(void, VariantbvEXT, (GLuint, const GLbyte *))
AGL_API(void, VariantsvEXT, (GLuint, const GLshort *))
AGL_API(void, VariantivEXT, (GLuint, const GLint *))
AGL_API(void, VariantfvEXT, (GLuint, const GLfloat *))
AGL_API(void, VariantdvEXT, (GLuint, const GLdouble *))
AGL_API(void, VariantubvEXT, (GLuint, const GLubyte *))
AGL_API(void, VariantusvEXT, (GLuint, const GLushort *))
AGL_API(void, VariantuivEXT, (GLuint, const GLuint *))
AGL_API(void, VariantPointerEXT, (GLuint, GLenum, GLuint, const GLvoid *))
AGL_API(void, EnableVariantClientStateEXT, (GLuint))
AGL_API(void, DisableVariantClientStateEXT, (GLuint))
AGL_API(GLuint, BindLightParameterEXT, (GLenum, GLenum))
AGL_API(GLuint, BindMaterialParameterEXT, (GLenum, GLenum))
AGL_API(GLuint, BindTexGenParameterEXT, (GLenum, GLenum, GLenum))
AGL_API(GLuint, BindTextureUnitParameterEXT, (GLenum, GLenum))
AGL_API(GLuint, BindParameterEXT, (GLenum))
AGL_API(GLboolean, IsVariantEnabledEXT, (GLuint, GLenum))
AGL_API(void, GetVariantBooleanvEXT, (GLuint, GLenum, GLboolean *))
AGL_API(void, GetVariantIntegervEXT, (GLuint, GLenum, GLint *))
AGL_API(void, GetVariantFloatvEXT, (GLuint, GLenum, GLfloat *))
AGL_API(void, GetVariantPointervEXT, (GLuint, GLenum, GLvoid* *))
AGL_API(void, GetInvariantBooleanvEXT, (GLuint, GLenum, GLboolean *))
AGL_API(void, GetInvariantIntegervEXT, (GLuint, GLenum, GLint *))
AGL_API(void, GetInvariantFloatvEXT, (GLuint, GLenum, GLfloat *))
AGL_API(void, GetLocalConstantBooleanvEXT, (GLuint, GLenum, GLboolean *))
AGL_API(void, GetLocalConstantIntegervEXT, (GLuint, GLenum, GLint *))
AGL_API(void, GetLocalConstantFloatvEXT, (GLuint, GLenum, GLfloat *))
#endif

#if defined _ALLEGRO_GL_ATI_vertex_streams
AGL_API(void, VertexStream1sATI, (GLenum, GLshort))
AGL_API(void, VertexStream1svATI, (GLenum, const GLshort *))
AGL_API(void, VertexStream1iATI, (GLenum, GLint))
AGL_API(void, VertexStream1ivATI, (GLenum, const GLint *))
AGL_API(void, VertexStream1fATI, (GLenum, GLfloat))
AGL_API(void, VertexStream1fvATI, (GLenum, const GLfloat *))
AGL_API(void, VertexStream1dATI, (GLenum, GLdouble))
AGL_API(void, VertexStream1dvATI, (GLenum, const GLdouble *))
AGL_API(void, VertexStream2sATI, (GLenum, GLshort, GLshort))
AGL_API(void, VertexStream2svATI, (GLenum, const GLshort *))
AGL_API(void, VertexStream2iATI, (GLenum, GLint, GLint))
AGL_API(void, VertexStream2ivATI, (GLenum, const GLint *))
AGL_API(void, VertexStream2fATI, (GLenum, GLfloat, GLfloat))
AGL_API(void, VertexStream2fvATI, (GLenum, const GLfloat *))
AGL_API(void, VertexStream2dATI, (GLenum, GLdouble, GLdouble))
AGL_API(void, VertexStream2dvATI, (GLenum, const GLdouble *))
AGL_API(void, VertexStream3sATI, (GLenum, GLshort, GLshort, GLshort))
AGL_API(void, VertexStream3svATI, (GLenum, const GLshort *))
AGL_API(void, VertexStream3iATI, (GLenum, GLint, GLint, GLint))
AGL_API(void, VertexStream3ivATI, (GLenum, const GLint *))
AGL_API(void, VertexStream3fATI, (GLenum, GLfloat, GLfloat, GLfloat))
AGL_API(void, VertexStream3fvATI, (GLenum, const GLfloat *))
AGL_API(void, VertexStream3dATI, (GLenum, GLdouble, GLdouble, GLdouble))
AGL_API(void, VertexStream3dvATI, (GLenum, const GLdouble *))
AGL_API(void, VertexStream4sATI, (GLenum, GLshort, GLshort, GLshort, GLshort))
AGL_API(void, VertexStream4svATI, (GLenum, const GLshort *))
AGL_API(void, VertexStream4iATI, (GLenum, GLint, GLint, GLint, GLint))
AGL_API(void, VertexStream4ivATI, (GLenum, const GLint *))
AGL_API(void, VertexStream4fATI, (GLenum, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, VertexStream4fvATI, (GLenum, const GLfloat *))
AGL_API(void, VertexStream4dATI, (GLenum, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, VertexStream4dvATI, (GLenum, const GLdouble *))
AGL_API(void, NormalStream3bATI, (GLenum, GLbyte, GLbyte, GLbyte))
AGL_API(void, NormalStream3bvATI, (GLenum, const GLbyte *))
AGL_API(void, NormalStream3sATI, (GLenum, GLshort, GLshort, GLshort))
AGL_API(void, NormalStream3svATI, (GLenum, const GLshort *))
AGL_API(void, NormalStream3iATI, (GLenum, GLint, GLint, GLint))
AGL_API(void, NormalStream3ivATI, (GLenum, const GLint *))
AGL_API(void, NormalStream3fATI, (GLenum, GLfloat, GLfloat, GLfloat))
AGL_API(void, NormalStream3fvATI, (GLenum, const GLfloat *))
AGL_API(void, NormalStream3dATI, (GLenum, GLdouble, GLdouble, GLdouble))
AGL_API(void, NormalStream3dvATI, (GLenum, const GLdouble *))
AGL_API(void, ClientActiveVertexStreamATI, (GLenum))
AGL_API(void, VertexBlendEnviATI, (GLenum, GLint))
AGL_API(void, VertexBlendEnvfATI, (GLenum, GLfloat))
#endif

#if defined _ALLEGRO_GL_ATI_element_array
AGL_API(void, ElementPointerATI, (GLenum, const GLvoid *))
AGL_API(void, DrawElementArrayATI, (GLenum, GLsizei))
AGL_API(void, DrawRangeElementArrayATI, (GLenum, GLuint, GLuint, GLsizei))
#endif

#if defined _ALLEGRO_GL_SUN_mesh_array
AGL_API(void, DrawMeshArraysSUN, (GLenum, GLint, GLsizei, GLsizei))
#endif

#if defined _ALLEGRO_GL_NV_occlusion_query
AGL_API(void, GenOcclusionQueriesNV, (GLsizei, GLuint *))
AGL_API(void, DeleteOcclusionQueriesNV, (GLsizei, const GLuint *))
AGL_API(GLboolean, IsOcclusionQueryNV, (GLuint))
AGL_API(void, BeginOcclusionQueryNV, (GLuint))
AGL_API(void, EndOcclusionQueryNV, (void))
AGL_API(void, GetOcclusionQueryivNV, (GLuint, GLenum, GLint *))
AGL_API(void, GetOcclusionQueryuivNV, (GLuint, GLenum, GLuint *))
#endif

#if defined _ALLEGRO_GL_NV_point_sprite
AGL_API(void, PointParameteriNV, (GLenum, GLint))
AGL_API(void, PointParameterivNV, (GLenum, const GLint *))
#endif

#if defined _ALLEGRO_GL_EXT_stencil_two_side
AGL_API(void, ActiveStencilFaceEXT, (GLenum))
#endif

#if defined _ALLEGRO_GL_APPLE_element_array
AGL_API(void, ElementPointerAPPLE, (GLenum, const GLvoid *))
AGL_API(void, DrawElementArrayAPPLE, (GLenum, GLint, GLsizei))
AGL_API(void, DrawRangeElementArrayAPPLE, (GLenum, GLuint, GLuint, GLint, GLsizei))
AGL_API(void, MultiDrawElementArrayAPPLE, (GLenum, const GLint *, const GLsizei *, GLsizei))
AGL_API(void, MultiDrawRangeElementArrayAPPLE, (GLenum, GLuint, GLuint, const GLint *, const GLsizei *, GLsizei))
#endif

#if defined _ALLEGRO_GL_APPLE_fence
AGL_API(void, GenFencesAPPLE, (GLsizei, GLuint *))
AGL_API(void, DeleteFencesAPPLE, (GLsizei, const GLuint *))
AGL_API(void, SetFenceAPPLE, (GLuint))
AGL_API(GLboolean, IsFenceAPPLE, (GLuint))
AGL_API(GLboolean, TestFenceAPPLE, (GLuint))
AGL_API(void, FinishFenceAPPLE, (GLuint))
AGL_API(GLboolean, TestObjectAPPLE, (GLenum, GLuint))
AGL_API(void, FinishObjectAPPLE, (GLenum, GLint))
#endif

#if defined _ALLEGRO_GL_APPLE_vertex_array_object
AGL_API(void, BindVertexArrayAPPLE, (GLuint))
AGL_API(void, DeleteVertexArraysAPPLE, (GLsizei, const GLuint *))
AGL_API(void, GenVertexArraysAPPLE, (GLsizei, const GLuint *))
AGL_API(GLboolean, IsVertexArrayAPPLE, (GLuint))
#endif

#if defined _ALLEGRO_GL_APPLE_vertex_array_range
AGL_API(void, VertexArrayRangeAPPLE, (GLsizei, GLvoid *))
AGL_API(void, FlushVertexArrayRangeAPPLE, (GLsizei, GLvoid *))
AGL_API(void, VertexArrayParameteriAPPLE, (GLenum, GLint))
#endif

#if defined _ALLEGRO_GL_ATI_draw_buffers
AGL_API(void, DrawBuffersATI, (GLsizei, const GLenum *))
#endif

#if defined _ALLEGRO_GL_NV_fragment_program
AGL_API(void, ProgramNamedParameter4fNV, (GLuint, GLsizei, const GLubyte *, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, ProgramNamedParameter4dNV, (GLuint, GLsizei, const GLubyte *, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, ProgramNamedParameter4fvNV, (GLuint, GLsizei, const GLubyte *, const GLfloat *))
AGL_API(void, ProgramNamedParameter4dvNV, (GLuint, GLsizei, const GLubyte *, const GLdouble *))
AGL_API(void, GetProgramNamedParameterfvNV, (GLuint, GLsizei, const GLubyte *, GLfloat *))
AGL_API(void, GetProgramNamedParameterdvNV, (GLuint, GLsizei, const GLubyte *, GLdouble *))
#endif

#if defined _ALLEGRO_GL_NV_half_float
AGL_API(void, Vertex2hNV, (GLhalfNV, GLhalfNV))
AGL_API(void, Vertex2hvNV, (const GLhalfNV *))
AGL_API(void, Vertex3hNV, (GLhalfNV, GLhalfNV, GLhalfNV))
AGL_API(void, Vertex3hvNV, (const GLhalfNV *))
AGL_API(void, Vertex4hNV, (GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV))
AGL_API(void, Vertex4hvNV, (const GLhalfNV *))
AGL_API(void, Normal3hNV, (GLhalfNV, GLhalfNV, GLhalfNV))
AGL_API(void, Normal3hvNV, (const GLhalfNV *))
AGL_API(void, Color3hNV, (GLhalfNV, GLhalfNV, GLhalfNV))
AGL_API(void, Color3hvNV, (const GLhalfNV *))
AGL_API(void, Color4hNV, (GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV))
AGL_API(void, Color4hvNV, (const GLhalfNV *))
AGL_API(void, TexCoord1hNV, (GLhalfNV))
AGL_API(void, TexCoord1hvNV, (const GLhalfNV *))
AGL_API(void, TexCoord2hNV, (GLhalfNV, GLhalfNV))
AGL_API(void, TexCoord2hvNV, (const GLhalfNV *))
AGL_API(void, TexCoord3hNV, (GLhalfNV, GLhalfNV, GLhalfNV))
AGL_API(void, TexCoord3hvNV, (const GLhalfNV *))
AGL_API(void, TexCoord4hNV, (GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV))
AGL_API(void, TexCoord4hvNV, (const GLhalfNV *))
AGL_API(void, MultiTexCoord1hNV, (GLenum, GLhalfNV))
AGL_API(void, MultiTexCoord1hvNV, (GLenum, const GLhalfNV *))
AGL_API(void, MultiTexCoord2hNV, (GLenum, GLhalfNV, GLhalfNV))
AGL_API(void, MultiTexCoord2hvNV, (GLenum, const GLhalfNV *))
AGL_API(void, MultiTexCoord3hNV, (GLenum, GLhalfNV, GLhalfNV, GLhalfNV))
AGL_API(void, MultiTexCoord3hvNV, (GLenum, const GLhalfNV *))
AGL_API(void, MultiTexCoord4hNV, (GLenum, GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV))
AGL_API(void, MultiTexCoord4hvNV, (GLenum, const GLhalfNV *))
AGL_API(void, FogCoordhNV, (GLhalfNV))
AGL_API(void, FogCoordhvNV, (const GLhalfNV *))
AGL_API(void, SecondaryColor3hNV, (GLhalfNV, GLhalfNV, GLhalfNV))
AGL_API(void, SecondaryColor3hvNV, (const GLhalfNV *))
AGL_API(void, VertexWeighthNV, (GLhalfNV))
AGL_API(void, VertexWeighthvNV, (const GLhalfNV *))
AGL_API(void, VertexAttrib1hNV, (GLuint, GLhalfNV))
AGL_API(void, VertexAttrib1hvNV, (GLuint, const GLhalfNV *))
AGL_API(void, VertexAttrib2hNV, (GLuint, GLhalfNV, GLhalfNV))
AGL_API(void, VertexAttrib2hvNV, (GLuint, const GLhalfNV *))
AGL_API(void, VertexAttrib3hNV, (GLuint, GLhalfNV, GLhalfNV, GLhalfNV))
AGL_API(void, VertexAttrib3hvNV, (GLuint, const GLhalfNV *))
AGL_API(void, VertexAttrib4hNV, (GLuint, GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV))
AGL_API(void, VertexAttrib4hvNV, (GLuint, const GLhalfNV *))
AGL_API(void, VertexAttribs1hvNV, (GLuint, GLsizei, const GLhalfNV *))
AGL_API(void, VertexAttribs2hvNV, (GLuint, GLsizei, const GLhalfNV *))
AGL_API(void, VertexAttribs3hvNV, (GLuint, GLsizei, const GLhalfNV *))
AGL_API(void, VertexAttribs4hvNV, (GLuint, GLsizei, const GLhalfNV *))
#endif

#if defined _ALLEGRO_GL_NV_pixel_data_range
AGL_API(void, PixelDataRangeNV, (GLenum, GLsizei, GLvoid *))
AGL_API(void, FlushPixelDataRangeNV, (GLenum))
#endif

#if defined _ALLEGRO_GL_NV_primitive_restart
AGL_API(void, PrimitiveRestartNV, (void))
AGL_API(void, PrimitiveRestartIndexNV, (GLuint))
#endif

#if defined _ALLEGRO_GL_ATI_map_object_buffer
AGL_API(GLvoid*, MapObjectBufferATI, (GLuint))
AGL_API(void, UnmapObjectBufferATI, (GLuint))
#endif

#if defined _ALLEGRO_GL_ATI_separate_stencil
AGL_API(void, StencilOpSeparateATI, (GLenum, GLenum, GLenum, GLenum))
AGL_API(void, StencilFuncSeparateATI, (GLenum, GLenum, GLint, GLuint))
#endif

#if defined _ALLEGRO_GL_ATI_vertex_attrib_array_object
AGL_API(void, VertexAttribArrayObjectATI, (GLuint, GLint, GLenum, GLboolean, GLsizei, GLuint, GLuint))
AGL_API(void, GetVertexAttribArrayObjectfvATI, (GLuint, GLenum, GLfloat *))
AGL_API(void, GetVertexAttribArrayObjectivATI, (GLuint, GLenum, GLint *))
#endif

#if defined _ALLEGRO_GL_OES_byte_coordinates
AGL_API(void, Vertex2bOES, ( GLbyte, GLbyte ))
AGL_API(void, Vertex3bOES, ( GLbyte, GLbyte, GLbyte ))
AGL_API(void, Vertex4bOES, ( GLbyte, GLbyte, GLbyte, GLbyte ))
AGL_API(void, Vertex2bvOES, ( const GLbyte * ))
AGL_API(void, Vertex3bvOES, ( const GLbyte * ))
AGL_API(void, Vertex4bvOES, ( const GLbyte * ))
AGL_API(void, TexCoord1bOES, ( GLbyte ))
AGL_API(void, TexCoord2bOES, ( GLbyte, GLbyte ))
AGL_API(void, TexCoord3bOES, ( GLbyte, GLbyte, GLbyte ))
AGL_API(void, TexCoord4bOES, ( GLbyte, GLbyte, GLbyte, GLbyte ))
AGL_API(void, TexCoord1bvOES, ( const GLbyte * ))
AGL_API(void, TexCoord2bvOES, ( const GLbyte * ))
AGL_API(void, TexCoord3bvOES, ( const GLbyte * ))
AGL_API(void, TexCoord4bvOES, ( const GLbyte * ))
AGL_API(void, MultiTexCoord1bOES, ( GLenum, GLbyte ))
AGL_API(void, MultiTexCoord2bOES, ( GLenum, GLbyte, GLbyte ))
AGL_API(void, MultiTexCoord3bOES, ( GLenum, GLbyte, GLbyte, GLbyte ))
AGL_API(void, MultiTexCoord4bOES, ( GLenum, GLbyte, GLbyte, GLbyte, GLbyte ))
AGL_API(void, MultiTexCoord1bvOES, ( GLenum texture, const GLbyte * ))
AGL_API(void, MultiTexCoord2bvOES, ( GLenum texture, const GLbyte * ))
AGL_API(void, MultiTexCoord3bvOES, ( GLenum texture, const GLbyte * ))
AGL_API(void, MultiTexCoord4bvOES, ( GLenum texture, const GLbyte * ))
#endif

#if defined _ALLEGRO_GL_OES_fixed_point
AGL_API(void, Vertex2xOES, (GLfixed, GLfixed))
AGL_API(void, Vertex3xOES, (GLfixed, GLfixed, GLfixed))
AGL_API(void, Vertex4xOES, (GLfixed, GLfixed, GLfixed, GLfixed))
AGL_API(void, Vertex2xvOES, (const GLfixed *))
AGL_API(void, Vertex3xvOES, (const GLfixed *))
AGL_API(void, Vertex4xvOES, (const GLfixed *))
AGL_API(void, Normal3xOES, (GLfixed, GLfixed, GLfixed))
AGL_API(void, Normal3xvOES, (const GLfixed *))
AGL_API(void, TexCoord1xOES, (GLfixed))
AGL_API(void, TexCoord2xOES, (GLfixed, GLfixed))
AGL_API(void, TexCoord3xOES, (GLfixed, GLfixed, GLfixed))
AGL_API(void, TexCoord4xOES, (GLfixed, GLfixed, GLfixed, GLfixed))
AGL_API(void, TexCoord1xvOES, (const GLfixed *))
AGL_API(void, TexCoord2xvOES, (const GLfixed *))
AGL_API(void, TexCoord3xvOES, (const GLfixed *))
AGL_API(void, TexCoord4xvOES, (const GLfixed *))
AGL_API(void, MultiTexCoord1xOES, (GLenum, GLfixed))
AGL_API(void, MultiTexCoord2xOES, (GLenum, GLfixed, GLfixed))
AGL_API(void, MultiTexCoord3xOES, (GLenum, GLfixed, GLfixed, GLfixed))
AGL_API(void, MultiTexCoord4xOES, (GLenum, GLfixed, GLfixed, GLfixed, GLfixed))
AGL_API(void, MultiTexCoord1xvOES, (GLenum, const GLfixed *))
AGL_API(void, MultiTexCoord2xvOES, (GLenum, const GLfixed *))
AGL_API(void, MultiTexCoord3xvOES, (GLenum, const GLfixed *))
AGL_API(void, MultiTexCoord4xvOES, (GLenum, const GLfixed *))
AGL_API(void, Color3xOES, (GLfixed, GLfixed, GLfixed))
AGL_API(void, Color4xOES, (GLfixed, GLfixed, GLfixed, GLfixed))
AGL_API(void, Color3xvOES, (const GLfixed *))
AGL_API(void, Color4xvOES, (const GLfixed *))
AGL_API(void, IndexxOES, (GLfixed))
AGL_API(void, IndexxvOES, (const GLfixed *))
AGL_API(void, RectxOES, (GLfixed, GLfixed, GLfixed, GLfixed))
AGL_API(void, RectxvOES, (const GLfixed [2], const GLfixed [2]))
AGL_API(void, DepthRangexOES, (GLclampx, GLclampx))
AGL_API(void, LoadMatrixxOES, (const GLfixed [16]))
AGL_API(void, MultMatrixxOES, (const GLfixed [16]))
AGL_API(void, LoadTransposeMatrixxOES, (const GLfixed [16]))
AGL_API(void, MultTransposeMatrixxOES, (const GLfixed [16]))
AGL_API(void, RotatexOES, (GLfixed, GLfixed, GLfixed, GLfixed))
AGL_API(void, ScalexOES, (GLfixed, GLfixed, GLfixed))
AGL_API(void, TranslatexOES, (GLfixed, GLfixed, GLfixed))
AGL_API(void, FrustumxOES, (GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, GLfixed))
AGL_API(void, OrthoxOES, (GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, GLfixed))
AGL_API(void, TexGenxOES, (GLenum, GLenum, GLfixed))
AGL_API(void, TexGenxvOES, (GLenum, GLenum, const GLfixed *))
AGL_API(void, GetTexGenxvOES, (GLenum, GLenum, GLfixed *))
AGL_API(void, ClipPlanexOES, (GLenum, const GLfixed *))
AGL_API(void, GetClipPlanexOES, (GLenum, GLfixed *))
AGL_API(void, RasterPos2xOES, (GLfixed, GLfixed))
AGL_API(void, RasterPos3xOES, (GLfixed, GLfixed, GLfixed))
AGL_API(void, RasterPos4xOES, (GLfixed, GLfixed, GLfixed, GLfixed))
AGL_API(void, RasterPos2xvOES, (const GLfixed *))
AGL_API(void, RasterPos3xvOES, (const GLfixed *))
AGL_API(void, RasterPos4xvOES, (const GLfixed *))
AGL_API(void, MaterialxOES, (GLenum, GLenum, GLfixed))
AGL_API(void, MaterialxvOES, (GLenum, GLenum, const GLfixed *))
AGL_API(void, GetMaterialxOES, (GLenum, GLenum, GLfixed *))
AGL_API(void, LightxOES, (GLenum, GLenum, GLfixed))
AGL_API(void, LightxvOES, (GLenum, GLenum, const GLfixed *))
AGL_API(void, GetLightxOES, (GLenum, GLenum, const GLfixed *))
AGL_API(void, LightModelxOES, (GLenum, GLfixed))
AGL_API(void, LightModelxvOES, (GLenum, const GLfixed *))
AGL_API(void, PointSizexOES, (GLfixed size))
AGL_API(void, LineWidthxOES, (GLfixed width))
AGL_API(void, PolygonOffsetxOES, (GLfixed factor, GLfixed units))
AGL_API(void, PixelStorex, (GLenum pname, GLfixed param))
AGL_API(void, PixelTransferxOES, (GLenum pname, GLfixed param))
AGL_API(void, PixelMapx, (GLenum, GLint, const GLfixed *))
AGL_API(void, GetPixelMapxv, (GLenum, GLint, GLfixed *))
AGL_API(void, ConvolutionParameterxOES, (GLenum, GLenum, GLfixed))
AGL_API(void, ConvolutionParameterxvOES, (GLenum, GLenum, const GLfixed *))
AGL_API(void, GetConvolutionParameterxvOES, (GLenum, GLenum, GLfixed *))
AGL_API(void, GetHistogramParameterxvOES, (GLenum, GLenum, GLfixed *))
AGL_API(void, PixelZoomxOES, (GLfixed, GLfixed))
AGL_API(void, BitmapxOES, (GLsizei, GLsizei, GLfixed, GLfixed, GLfixed, GLfixed, const GLubyte *))
AGL_API(void, TexParameterxOES, (GLenum, GLenum, GLfixed))
AGL_API(void, TexParameterxvOES, (GLenum, GLenum, const GLfixed *))
AGL_API(void, GetTexParameterxvOES, (GLenum, GLenum, GLfixed *))
AGL_API(void, GetTexLevelParameterxvOES, (GLenum, GLint, GLenum, GLfixed *))
AGL_API(void, PrioritizeTexturesxOES, (GLsizei, GLuint *, GLclampx *))
AGL_API(void, TexEnvxOES, (GLenum, GLenum, GLfixed))
AGL_API(void, TexEnvxvOES, (GLenum, GLenum, const GLfixed *))
AGL_API(void, GetTexEnvxvOES, (GLenum, GLenum, GLfixed *))
AGL_API(void, FogxOES, (GLenum, GLfixed))
AGL_API(void, FogxvOES, (GLenum, const GLfixed *))
AGL_API(void, SampleCoverageOES, (GLclampx, GLboolean))
AGL_API(void, AlphaFuncxOES, (GLenum, GLclampx))
AGL_API(void, BlendColorxOES, (GLclampx, GLclampx, GLclampx, GLclampx))
AGL_API(void, ClearColorxOES, (GLclampx, GLclampx, GLclampx, GLclampx))
AGL_API(void, ClearDepthxOES, (GLclampx))
AGL_API(void, ClearAccumxOES, (GLclampx, GLclampx, GLclampx, GLclampx))
AGL_API(void, AccumxOES, (GLenum, GLfixed))
AGL_API(void, Map1xOES, (GLenum, GLfixed, GLfixed, GLint, GLint, const GLfixed *))
AGL_API(void, Map2xOES, (GLenum, GLfixed, GLfixed, GLint, GLint, GLfixed, GLfixed, GLint, GLint, const GLfixed *))
AGL_API(void, MapGrid1xOES, (GLint, GLfixed, GLfixed))
AGL_API(void, MapGrid2xOES, (GLint, GLfixed, GLfixed, GLfixed, GLfixed))
AGL_API(void, GetMapxvOES, (GLenum, GLenum, GLfixed *))
AGL_API(void, EvalCoord1xOES, (GLfixed))
AGL_API(void, EvalCoord2xOES, (GLfixed, GLfixed))
AGL_API(void, EvalCoord1xvOES, (const GLfixed *))
AGL_API(void, EvalCoord2xvOES, (const GLfixed *))
AGL_API(void, FeedbackBufferxOES, (GLsizei, GLenum, GLfixed *))
AGL_API(void, PassThroughxOES, (GLfixed))
AGL_API(void, GetFixedvOES, (GLenum, GLfixed *))
#endif

#if defined _ALLEGRO_GL_OES_single_precision
AGL_API(void, DepthRangefOES, (GLclampf, GLclampf))
AGL_API(void, FrustumfOES, (GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, OrthofOES, (GLfloat, GLfloat, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, ClipPlanefOES, (GLenum, const GLfloat*))
AGL_API(void, GetClipPlanefOES, (GLenum, GLfloat*))
AGL_API(void, ClearDepthfOES, (GLclampd))
#endif

#if defined _ALLEGRO_GL_OES_query_matrix
AGL_API(GLbitfield, QueryMatrixxOES, (GLfixed [16], GLint [16] ))
#endif

#if defined _ALLEGRO_GL_EXT_depth_bounds_test
AGL_API(void, DepthBoundsEXT, (GLclampd, GLclampd))
#endif


#if defined _ALLEGRO_GL_EXT_blend_equation_separate
AGL_API(void, BlendEquationSeparateEXT, (GLenum, GLenum))
#endif


#if defined _ALLEGRO_GL_EXT_framebuffer_object
AGL_API(GLboolean, IsRenderbufferEXT, (GLuint))
AGL_API(void, BindRenderbufferEXT, (GLenum, GLuint))
AGL_API(void, DeleteRenderbuffersEXT, (GLsizei, const GLuint *))
AGL_API(void, GenRenderbuffersEXT, (GLsizei, GLuint *))
AGL_API(void, RenderbufferStorageEXT, (GLenum, GLenum, GLsizei, GLsizei))
AGL_API(void, GetRenderbufferParameterivEXT, (GLenum, GLenum, GLint*))
AGL_API(GLboolean, IsFramebufferEXT, (GLuint))
AGL_API(void, BindFramebufferEXT, (GLenum, GLuint))
AGL_API(void, DeleteFramebuffersEXT, (GLsizei, const GLuint *))
AGL_API(void, GenFramebuffersEXT, (GLsizei, GLuint *))
AGL_API(GLenum, CheckFramebufferStatusEXT, (GLenum))
AGL_API(void, FramebufferTexture1DEXT, (GLenum, GLenum, GLenum, GLuint, GLint))
AGL_API(void, FramebufferTexture2DEXT, (GLenum, GLenum, GLenum, GLuint, GLint))
AGL_API(void, FramebufferTexture3DEXT, (GLenum, GLenum, GLenum, GLuint, GLint, GLint))
AGL_API(void, FramebufferRenderbufferEXT, (GLenum, GLenum, GLenum, GLuint))
AGL_API(void, GetFramebufferAttachmentParameterivEXT, (GLenum, GLenum, GLenum, GLint *))
AGL_API(void, GenerateMipmapEXT, (GLenum))
#endif

#if defined _ALLEGRO_GL_GREMEDY_string_marker
AGL_API(void, StringMarkerGREMEDY, (GLsizei, const GLvoid *))
#endif

#if defined _ALLEGRO_GL_EXT_stencil_clear_tag
AGL_API(void, StencilClearTagEXT, (GLsizei, GLuint))
#endif

#if defined _ALLEGRO_GL_EXT_framebuffer_blit
AGL_API(void, BlitFramebufferEXT, (GLint, GLint, GLint, GLint, GLint, GLint, GLint, GLint, GLbitfield, GLenum))
#endif

#if defined _ALLEGRO_GL_EXT_framebuffer_multisample
AGL_API(void, RenderbufferStorageMultisampleEXT, (GLenum, GLsizei, GLenum, GLsizei, GLsizei))
#endif

#if defined _ALLEGRO_GL_EXT_timer_query
AGL_API(void, GetQueryObjecti64vEXT, (GLuint, GLenum, GLint64EXT *))
AGL_API(void, GetQueryObjectui64vEXT, (GLuint, GLenum, GLuint64EXT *))
#endif

#if defined _ALLEGRO_GL_EXT_gpu_program_parameters
AGL_API(void, ProgramEnvParameters4fvEXT, (GLenum, GLuint, GLsizei, const GLfloat *))
AGL_API(void, ProgramLocalParameters4fvEXT, (GLenum, GLuint, GLsizei, const GLfloat *))
#endif

#if defined _ALLEGRO_GL_APPLE_flush_buffer_range
AGL_API(void, BufferParameteriAPPLE, (GLenum, GLenum, GLint))
AGL_API(void, FlushMappedBufferRangeAPPLE, (GLenum, GLintptr, GLsizeiptr))
#endif

#if defined _ALLEGRO_GL_EXT_bindable_uniform
AGL_API(void,     UniformBufferEXT, (GLuint, GLint, GLuint))
AGL_API(GLint,    GetUniformBufferSizeEXT, (GLuint, GLint))
AGL_API(GLintptr, GetUniformOffsetEXT, (GLuint program, GLint))
#endif

#if defined _ALLEGRO_GL_EXT_draw_buffers2
AGL_API(void, ColorMaskIndexedEXT, (GLuint, GLboolean, GLboolean, GLboolean, GLboolean))
AGL_API(void, GetBooleanIndexedvEXT, (GLenum, GLuint, GLboolean *))
AGL_API(void, GetIntegerIndexedvEXT, (GLenum, GLuint, GLint *))
AGL_API(void, EnableIndexedEXT, (GLenum, GLuint))
AGL_API(void, DisableIndexedEXT, (GLenum, GLuint))
AGL_API(GLboolean, IsEnabledIndexedEXT, (GLenum, GLuint))
#endif

#if defined _ALLEGRO_GL_EXT_draw_instanced
AGL_API(void, DrawArraysInstancedEXT, (GLenum, GLint, GLsizei, GLsizei))
AGL_API(void, DrawElementsInstancedEXT, (GLenum, GLsizei, GLenum, const GLvoid *, GLsizei))
#endif

#if defined _ALLEGRO_GL_EXT_geometry_shader4
AGL_API(void, ProgramParameteriEXT, (GLuint, GLenum, GLint))
AGL_API(void, FramebufferTextureEXT, (GLenum, GLenum, GLuint, GLint))
#if !defined _ALLEGRO_GL_EXT_texture_array
AGL_API(void, FramebufferTextureLayerEXT, (GLenum, GLenum, GLuint, GLint, GLint))
#endif
AGL_API(void, FramebufferTextureFaceEXT, (GLenum, GLenum, GLuint, GLint, GLenum))
#endif

#if defined _ALLEGRO_GL_EXT_gpu_shader4
AGL_API(void, VertexAttribI1iEXT, (GLuint, GLint))
AGL_API(void, VertexAttribI2iEXT, (GLuint, GLint, GLint))
AGL_API(void, VertexAttribI3iEXT, (GLuint, GLint, GLint, GLint))
AGL_API(void, VertexAttribI4iEXT, (GLuint, GLint, GLint, GLint, GLint))
AGL_API(void, VertexAttribI1uiEXT, (GLuint, GLuint))
AGL_API(void, VertexAttribI2uiEXT, (GLuint, GLuint, GLuint))
AGL_API(void, VertexAttribI3uiEXT, (GLuint, GLuint, GLuint, GLuint))
AGL_API(void, VertexAttribI4uiEXT, (GLuint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, VertexAttribI1ivEXT, (GLuint, const GLint *))
AGL_API(void, VertexAttribI2ivEXT, (GLuint, const GLint *))
AGL_API(void, VertexAttribI3ivEXT, (GLuint, const GLint *))
AGL_API(void, VertexAttribI4ivEXT, (GLuint, const GLint *))
AGL_API(void, VertexAttribI1uivEXT, (GLuint, const GLuint *))
AGL_API(void, VertexAttribI2uivEXT, (GLuint, const GLuint *))
AGL_API(void, VertexAttribI3uivEXT, (GLuint, const GLuint *))
AGL_API(void, VertexAttribI4uivEXT, (GLuint, const GLuint *))
AGL_API(void, VertexAttribI4bvEXT, (GLuint, const GLbyte *))
AGL_API(void, VertexAttribI4svEXT, (GLuint, const GLshort *))
AGL_API(void, VertexAttribI4ubvEXT, (GLuint, const GLubyte *))
AGL_API(void, VertexAttribI4usvEXT, (GLuint, const GLushort *))
AGL_API(void, VertexAttribIPointerEXT, (GLuint, GLint, GLenum, GLsizei, const GLvoid *))
AGL_API(void, GetVertexAttribIivEXT, (GLuint, GLenum, GLint *))
AGL_API(void, GetVertexAttribIuivEXT, (GLuint, GLenum, GLint *))
AGL_API(void, Uniform1uiEXT, (GLint, GLuint))
AGL_API(void, Uniform2uiEXT, (GLint, GLuint, GLuint))
AGL_API(void, Uniform3uiEXT, (GLint, GLuint, GLuint, GLuint))
AGL_API(void, Uniform4uiEXT, (GLint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, Uniform1uivEXT, (GLint, GLsizei, const GLuint *))
AGL_API(void, Uniform2uivEXT, (GLint, GLsizei, const GLuint *))
AGL_API(void, Uniform3uivEXT, (GLint, GLsizei, const GLuint *))
AGL_API(void, Uniform4uivEXT, (GLint, GLsizei, const GLuint *))
AGL_API(void, GetUniformuivEXT, (GLuint, GLint location, GLint *))
AGL_API(void, BindFragDataLocationEXT, (GLuint, GLuint, const GLchar *))
AGL_API(GLint, GetFragDataLocationEXT, (GLuint, const GLchar *))
#endif

#if defined _ALLEGRO_GL_EXT_texture_array
AGL_API(void, FramebufferTextureLayerEXT, (GLenum, GLenum, GLuint, GLint, GLint))
#endif

#if defined _ALLEGRO_GL_EXT_texture_buffer_object
AGL_API(void, TexBufferEXT, (GLenum, GLenum, GLuint))
#endif

#if defined _ALLEGRO_GL_texture_integer
AGL_API(void, ClearColorIiEXT,        (GLint,  GLint,  GLint,  GLint))
AGL_API(void, ClearColorIuiEXT,       (GLuint, GLuint, GLuint, GLuint))
AGL_API(void, TexParameterIivEXT,     (GLenum, GLenum, GLint *))
AGL_API(void, TexParameterIuivEXT,    (GLenum, GLenum, GLuint *))
AGL_API(void, GetTexParameterIivEXT,  (GLenum, GLenum, GLint *))
AGL_API(void, GetTexParameterIiuvEXT, (GLenum, GLenum, GLuint *))
#endif

#if defined _ALLEGRO_GL_NV_depth_buffer_float
AGL_API(void, DepthRangedNV,  (GLdouble, GLdouble))
AGL_API(void, ClearDepthdNV,  (GLdouble))
AGL_API(void, DepthBoundsdNV, (GLdouble, GLdouble))
#endif

#if defined _ALLEGRO_GL_NV_framebuffer_multisample_coverage
AGL_API(void, RenderbufferStorageMultsampleCoverageNV, (GLenum, GLsizei, GLsizei, GLenum, GLsizei, GLsizei))
#endif

#if defined _ALLEGRO_GL_NV_geometry_program4
AGL_API(void, ProgramVertexLimitNV, (GLenum, GLint))
#if !defined _ALLEGRO_GL_EXT_geometry_shader4
AGL_API(void, FramebufferTextureEXT,      (GLenum, GLenum, GLuint, GLint))
#if !defined _ALLEGRO_GL_EXT_texture_array
AGL_API(void, FramebufferTextureLayerEXT, (GLenum, GLenum, GLuint, GLint, GLint))
#endif
#endif
#endif

#if defined _ALLEGRO_GL_NV_gpu_program4
AGL_API(void, ProgramLocalParameterI4iNV,    (GLenum, GLuint, GLint, GLint, GLint, GLint))
AGL_API(void, ProgramLocalParameterI4ivNV,   (GLenum, GLuint, const GLint *))
AGL_API(void, ProgramLocalParametersI4ivNV,  (GLenum, GLuint, GLsizei, const GLint *))
AGL_API(void, ProgramLocalParameterI4uiNV,   (GLenum, GLuint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, ProgramLocalParameterI4uivNV,  (GLenum, GLuint, const GLuint *))
AGL_API(void, ProgramLocalParametersI4uivNV, (GLenum, GLuint, GLsizei, const GLuint *))
AGL_API(void, ProgramEnvParameterI4iNV,      (GLenum, GLuint, GLint, GLint, GLint, GLint))
AGL_API(void, ProgramEnvParameterI4ivNV,     (GLenum, GLuint, const GLint *))
AGL_API(void, ProgramEnvParametersI4ivNV,    (GLenum, GLuint, GLsizei, const GLint *))
AGL_API(void, ProgramEnvParameterI4uiNV,     (GLenum, GLuint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, ProgramEnvParameterI4uivNV,    (GLenum, GLuint, const GLuint *))
AGL_API(void, ProgramEnvParametersI4uivNV,   (GLenum, GLuint, GLsizei, const GLuint *))
AGL_API(void, GetProgramLocalParameterIivNV, (GLenum, GLuint, GLint *))
AGL_API(void, GetProgramLocalParameterIuivNV,(GLenum, GLuint, GLuint *))
AGL_API(void, GetProgramEnvParameterIivNV,   (GLenum, GLuint, GLint *))
AGL_API(void, GetProgramEnvParameterIuivNV,  (GLenum, GLuint, GLuint *))
#endif

#if defined _ALLEGRO_GL_NV_parameter_buffer_object
#if !defined _ALLEGRO_GL_NV_transform_feedback
AGL_API(void, BindBufferRangeNV, (GLenum, GLuint, GLuint, GLintptr, GLsizeiptr))
AGL_API(void, BindBufferOffsetNV,(GLenum, GLuint, GLuint, GLintptr))
AGL_API(void, BindBufferBaseNV,  (GLenum, GLuint, GLuint))
#endif
AGL_API(void, ProgramBufferParametersfvNV,  (GLenum, GLuint, GLuint, GLsizei, const GLfloat *))
AGL_API(void, ProgramBufferParametersIivNV, (GLenum, GLuint, GLuint, GLsizei, const GLint *))
AGL_API(void, ProgramBufferParametersIuivNV,(GLenum, GLuint, GLuint, GLuint, const GLuint *))
#if !defined _ALLEGRO_GL_EXT_draw_buffers2
AGL_API(void, GetIntegerIndexedvEXT, (GLenum, GLuint, GLboolean *))
#endif
#endif

#if defined _ALLEGRO_GL_NV_transform_feedback
AGL_API(void, BindBufferRangeNV, (GLenum, GLuint, GLuint, GLintptr, GLsizeiptr))
AGL_API(void, BindBufferOffsetNV,(GLenum, GLuint, GLuint, GLintptr))
AGL_API(void, BindBufferBaseNV,  (GLenum, GLuint, GLuint))
AGL_API(void, TransformFeedbackAttribsNV, (GLsizei, const GLint *, GLenum))
AGL_API(void, TransformFeedbackVaryingsNV,(GLuint, GLsizei, const GLint *, GLenum))
AGL_API(void, BeginTransformFeedbackNV,   (GLenum))
AGL_API(void, EndTransformFeedbackNV,     (void))
AGL_API(GLint, GetVaryingLocationNV, (GLuint, const GLchar *))
AGL_API(void, GetActiveVaryingNV,    (GLuint, GLuint, GLsizei, GLsizei *, GLsizei *, GLenum *, GLchar *))
AGL_API(void, ActiveVaryingNV,       (GLuint, const GLchar *))
AGL_API(void, GetTransformFeedbackVaryingNV, (GLuint, GLuint, GLint *))
#if !defined _ALLEGRO_GL_EXT_draw_buffers2
AGL_API(void, GetBooleanIndexedvEXT, (GLenum, GLuint, GLboolean *))
/*AGL_API(void, GetIntegerIndexedvEXT, (GLenum, GLuint, GLint *))*/
#endif
#endif

#if defined _ALLEGRO_GL_NV_vertex_program4
#ifndef _ALLEGRO_GL_EXT_gpu_shader4
AGL_API(void, VertexAttribI1iEXT, (GLuint, GLint))
AGL_API(void, VertexAttribI2iEXT, (GLuint, GLint, GLint))
AGL_API(void, VertexAttribI3iEXT, (GLuint, GLint, GLint, GLint))
AGL_API(void, VertexAttribI4iEXT, (GLuint, GLint, GLint, GLint, GLint))
AGL_API(void, VertexAttribI1uiEXT, (GLuint, GLuint))
AGL_API(void, VertexAttribI2uiEXT, (GLuint, GLuint, GLuint))
AGL_API(void, VertexAttribI3uiEXT, (GLuint, GLuint, GLuint, GLuint))
AGL_API(void, VertexAttribI4uiEXT, (GLuint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, VertexAttribI1ivEXT, (GLuint, const GLint *))
AGL_API(void, VertexAttribI2ivEXT, (GLuint, const GLint *))
AGL_API(void, VertexAttribI3ivEXT, (GLuint, const GLint *))
AGL_API(void, VertexAttribI4ivEXT, (GLuint, const GLint *))
AGL_API(void, VertexAttribI1uivEXT, (GLuint, const GLuint *))
AGL_API(void, VertexAttribI2uivEXT, (GLuint, const GLuint *))
AGL_API(void, VertexAttribI3uivEXT, (GLuint, const GLuint *))
AGL_API(void, VertexAttribI4uivEXT, (GLuint, const GLuint *))
AGL_API(void, VertexAttribI4bvEXT, (GLuint, const GLbyte *))
AGL_API(void, VertexAttribI4svEXT, (GLuint, const GLshort *))
AGL_API(void, VertexAttribI4ubvEXT, (GLuint, const GLubyte *))
AGL_API(void, VertexAttribI4usvEXT, (GLuint, const GLushort *))
AGL_API(void, VertexAttribIPointerEXT, (GLuint, GLint, GLenum, GLsizei, const GLvoid *))
AGL_API(void, GetVertexAttribIivEXT, (GLuint, GLenum, GLint *))
AGL_API(void, GetVertexAttribIuivEXT, (GLuint, GLenum, GLint *))
#endif
#endif

#if defined _ALLEGRO_GL_GREMEDY_frame_terminator
AGL_API(void, FrameTerminatorGREMEDY, (void))
#endif

#if defined _ALLEGRO_GL_NV_conditional_render
AGL_API(void, BeginConditionalRenderNV, (GLuint, GLenum))
AGL_API(void, EndConditionalRenderNV, (void))
#endif

#if defined _ALLEGRO_GL_EXT_transform_feedback
AGL_API(void, BeginTransformFeedbackEXT, (GLenum))
AGL_API(void, EndTransformFeedbackEXT, (void))
AGL_API(void, BindBufferRangeEXT, (GLenum, GLuint, GLuint, GLintptr, GLsizeiptr))
AGL_API(void, BindBufferOffsetEXT, (GLenum, GLuint, GLuint, GLintptr))
AGL_API(void, BindBufferBaseEXT, (GLenum, GLuint, GLuint))
AGL_API(void, TransformFeedbackVaryingsEXT, (GLuint, GLsizei, const GLint *, GLenum))
AGL_API(void, GetTransformFeedbackVaryingEXT, (GLuint, GLuint, GLint *))
#endif

#if defined _ALLEGRO_GL_EXT_direct_state_access
AGL_API(void, ClientAttribDefaultEXT, (GLbitfield))
AGL_API(void, PushClientAttribDefaultEXT, (GLbitfield))
AGL_API(void, MatrixLoadfEXT, (GLenum, const GLfloat *))
AGL_API(void, MatrixLoaddEXT, (GLenum, const GLdouble *))
AGL_API(void, MatrixMultfEXT, (GLenum, const GLfloat *))
AGL_API(void, MatrixMultdEXT, (GLenum, const GLdouble *))
AGL_API(void, MatrixLoadIdentityEXT, (GLenum))
AGL_API(void, MatrixRotatefEXT, (GLenum, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, MatrixRotatedEXT, (GLenum, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, MatrixScalefEXT, (GLenum, GLfloat, GLfloat, GLfloat))
AGL_API(void, MatrixScaledEXT, (GLenum, GLdouble, GLdouble, GLdouble))
AGL_API(void, MatrixTranslatefEXT, (GLenum, GLfloat, GLfloat, GLfloat))
AGL_API(void, MatrixTranslatedEXT, (GLenum, GLdouble, GLdouble, GLdouble))
AGL_API(void, MatrixFrustumEXT, (GLenum, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, MatrixOrthoEXT, (GLenum, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, MatrixPopEXT, (GLenum))
AGL_API(void, MatrixPushEXT, (GLenum))
AGL_API(void, MatrixLoadTransposefEXT, (GLenum, const GLfloat *))
AGL_API(void, MatrixLoadTransposedEXT, (GLenum, const GLdouble *))
AGL_API(void, MatrixMultTransposefEXT, (GLenum, const GLfloat *))
AGL_API(void, MatrixMultTransposedEXT, (GLenum, const GLdouble *))
AGL_API(void, TextureParameterfEXT, (GLuint, GLenum, GLenum, GLfloat))
AGL_API(void, TextureParameterfvEXT, (GLuint, GLenum, GLenum, const GLfloat *))
AGL_API(void, TextureParameteriEXT, (GLuint, GLenum, GLenum, GLint))
AGL_API(void, TextureParameterivEXT, (GLuint, GLenum, GLenum, const GLint *))
AGL_API(void, TextureImage1DEXT, (GLuint, GLenum, GLint, GLenum, GLsizei, GLint, GLenum, GLenum, const GLvoid *))
AGL_API(void, TextureImage2DEXT, (GLuint, GLenum, GLint, GLenum, GLsizei, GLsizei, GLint, GLenum, GLenum, const GLvoid *))
AGL_API(void, TextureSubImage1DEXT, (GLuint, GLenum, GLint, GLint, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, TextureSubImage2DEXT, (GLuint, GLenum, GLint, GLint, GLint, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, CopyTextureImage1DEXT, (GLuint, GLenum, GLint, GLenum, GLint, GLint, GLsizei, GLint))
AGL_API(void, CopyTextureImage2DEXT, (GLuint, GLenum, GLint, GLenum, GLint, GLint, GLsizei, GLsizei, GLint))
AGL_API(void, CopyTextureSubImage1DEXT, (GLuint, GLenum, GLint, GLint, GLint, GLint, GLsizei))
AGL_API(void, CopyTextureSubImage2DEXT, (GLuint, GLenum, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei))
AGL_API(void, GetTextureImageEXT, (GLuint, GLenum, GLint, GLenum, GLenum, GLvoid *))
AGL_API(void, GetTextureParameterfvEXT, (GLuint, GLenum, GLenum, GLfloat *))
AGL_API(void, GetTextureParameterivEXT, (GLuint, GLenum, GLenum, GLint *))
AGL_API(void, GetTextureLevelParameterfvEXT, (GLuint, GLenum, GLint, GLenum, GLfloat *))
AGL_API(void, GetTextureLevelParameterivEXT, (GLuint, GLenum, GLint, GLenum, GLint *))
AGL_API(void, TextureImage3DEXT, (GLuint, GLenum, GLint, GLenum, GLsizei, GLsizei, GLsizei, GLint, GLenum, GLenum, const GLvoid *))
AGL_API(void, TextureSubImage3DEXT, (GLuint, GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, CopyTextureSubImage3DEXT, (GLuint, GLenum, GLint, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei))
AGL_API(void, MultiTexParameterfEXT, (GLenum, GLenum, GLenum, GLfloat))
AGL_API(void, MultiTexParameterfvEXT, (GLenum, GLenum, GLenum, const GLfloat *))
AGL_API(void, MultiTexParameteriEXT, (GLenum, GLenum, GLenum, GLint))
AGL_API(void, MultiTexParameterivEXT, (GLenum, GLenum, GLenum, const GLint *))
AGL_API(void, MultiTexImage1DEXT, (GLenum, GLenum, GLint, GLenum, GLsizei, GLint, GLenum, GLenum, const GLvoid *))
AGL_API(void, MultiTexImage2DEXT, (GLenum, GLenum, GLint, GLenum, GLsizei, GLsizei, GLint, GLenum, GLenum, const GLvoid *))
AGL_API(void, MultiTexSubImage1DEXT, (GLenum, GLenum, GLint, GLint, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, MultiTexSubImage2DEXT, (GLenum, GLenum, GLint, GLint, GLint, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, CopyMultiTexImage1DEXT, (GLenum, GLenum, GLint, GLenum, GLint, GLint, GLsizei, GLint))
AGL_API(void, CopyMultiTexImage2DEXT, (GLenum, GLenum, GLint, GLenum, GLint, GLint, GLsizei, GLsizei, GLint))
AGL_API(void, CopyMultiTexSubImage1DEXT, (GLenum, GLenum, GLint, GLint, GLint, GLint, GLsizei))
AGL_API(void, CopyMultiTexSubImage2DEXT, (GLenum, GLenum, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei))
AGL_API(void, GetMultiTexImageEXT, (GLenum, GLenum, GLint, GLenum, GLenum, GLvoid *))
AGL_API(void, GetMultiTexParameterfvEXT, (GLenum, GLenum, GLenum, GLfloat *))
AGL_API(void, GetMultiTexParameterivEXT, (GLenum, GLenum, GLenum, GLint *))
AGL_API(void, GetMultiTexLevelParameterfvEXT, (GLenum, GLenum, GLint, GLenum, GLfloat *))
AGL_API(void, GetMultiTexLevelParameterivEXT, (GLenum, GLenum, GLint, GLenum, GLint *))
AGL_API(void, MultiTexImage3DEXT, (GLenum, GLenum, GLint, GLenum, GLsizei, GLsizei, GLsizei, GLint, GLenum, GLenum, const GLvoid *))
AGL_API(void, MultiTexSubImage3DEXT, (GLenum, GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLenum, GLenum, const GLvoid *))
AGL_API(void, CopyMultiTexSubImage3DEXT, (GLenum, GLenum, GLint, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei))
AGL_API(void, BindMultiTextureEXT, (GLenum, GLenum, GLuint))
AGL_API(void, EnableClientStateIndexedEXT, (GLenum, GLuint))
AGL_API(void, DisableClientStateIndexedEXT, (GLenum, GLuint))
AGL_API(void, MultiTexCoordPointerEXT, (GLenum, GLint, GLenum, GLsizei, const GLvoid *))
AGL_API(void, MultiTexEnvfEXT, (GLenum, GLenum, GLenum, GLfloat))
AGL_API(void, MultiTexEnvfvEXT, (GLenum, GLenum, GLenum, const GLfloat *))
AGL_API(void, MultiTexEnviEXT, (GLenum, GLenum, GLenum, GLint))
AGL_API(void, MultiTexEnvivEXT, (GLenum, GLenum, GLenum, const GLint *))
AGL_API(void, MultiTexGendEXT, (GLenum, GLenum, GLenum, GLdouble))
AGL_API(void, MultiTexGendvEXT, (GLenum, GLenum, GLenum, const GLdouble *))
AGL_API(void, MultiTexGenfEXT, (GLenum, GLenum, GLenum, GLfloat))
AGL_API(void, MultiTexGenfvEXT, (GLenum, GLenum, GLenum, const GLfloat *))
AGL_API(void, MultiTexGeniEXT, (GLenum, GLenum, GLenum, GLint))
AGL_API(void, MultiTexGenivEXT, (GLenum, GLenum, GLenum, const GLint *))
AGL_API(void, GetMultiTexEnvfvEXT, (GLenum, GLenum, GLenum, GLfloat *))
AGL_API(void, GetMultiTexEnvivEXT, (GLenum, GLenum, GLenum, GLint *))
AGL_API(void, GetMultiTexGendvEXT, (GLenum, GLenum, GLenum, GLdouble *))
AGL_API(void, GetMultiTexGenfvEXT, (GLenum, GLenum, GLenum, GLfloat *))
AGL_API(void, GetMultiTexGenivEXT, (GLenum, GLenum, GLenum, GLint *))
AGL_API(void, GetFloatIndexedvEXT, (GLenum, GLuint, GLfloat *))
AGL_API(void, GetDoubleIndexedvEXT, (GLenum, GLuint, GLdouble *))
AGL_API(void, GetPointerIndexedvEXT, (GLenum, GLuint, GLvoid* *))
AGL_API(void, CompressedTextureImage3DEXT, (GLuint, GLenum, GLint, GLenum, GLsizei, GLsizei, GLsizei, GLint, GLsizei, const GLvoid *))
AGL_API(void, CompressedTextureImage2DEXT, (GLuint, GLenum, GLint, GLenum, GLsizei, GLsizei, GLint, GLsizei, const GLvoid *))
AGL_API(void, CompressedTextureImage1DEXT, (GLuint, GLenum, GLint, GLenum, GLsizei, GLint, GLsizei, const GLvoid *))
AGL_API(void, CompressedTextureSubImage3DEXT, (GLuint, GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLenum, GLsizei, const GLvoid *))
AGL_API(void, CompressedTextureSubImage2DEXT, (GLuint, GLenum, GLint, GLint, GLint, GLsizei, GLsizei, GLenum, GLsizei, const GLvoid *))
AGL_API(void, CompressedTextureSubImage1DEXT, (GLuint, GLenum, GLint, GLint, GLsizei, GLenum, GLsizei, const GLvoid *))
AGL_API(void, GetCompressedTextureImageEXT, (GLuint, GLenum, GLint, GLvoid *))
AGL_API(void, CompressedMultiTexImage3DEXT, (GLenum, GLenum, GLint, GLenum, GLsizei, GLsizei, GLsizei, GLint, GLsizei, const GLvoid *))
AGL_API(void, CompressedMultiTexImage2DEXT, (GLenum, GLenum, GLint, GLenum, GLsizei, GLsizei, GLint, GLsizei, const GLvoid *))
AGL_API(void, CompressedMultiTexImage1DEXT, (GLenum, GLenum, GLint, GLenum, GLsizei, GLint, GLsizei, const GLvoid *))
AGL_API(void, CompressedMultiTexSubImage3DEXT, (GLenum, GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLenum, GLsizei, const GLvoid *))
AGL_API(void, CompressedMultiTexSubImage2DEXT, (GLenum, GLenum, GLint, GLint, GLint, GLsizei, GLsizei, GLenum, GLsizei, const GLvoid *))
AGL_API(void, CompressedMultiTexSubImage1DEXT, (GLenum, GLenum, GLint, GLint, GLsizei, GLenum, GLsizei, const GLvoid *))
AGL_API(void, GetCompressedMultiTexImageEXT, (GLenum, GLenum, GLint, GLvoid *))
AGL_API(void, NamedProgramStringEXT, (GLuint, GLenum, GLenum, GLsizei, const GLvoid *))
AGL_API(void, NamedProgramLocalParameter4dEXT, (GLuint, GLenum, GLuint, GLdouble, GLdouble, GLdouble, GLdouble))
AGL_API(void, NamedProgramLocalParameter4dvEXT, (GLuint, GLenum, GLuint, const GLdouble *))
AGL_API(void, NamedProgramLocalParameter4fEXT, (GLuint, GLenum, GLuint, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, NamedProgramLocalParameter4fvEXT, (GLuint, GLenum, GLuint, const GLfloat *))
AGL_API(void, GetNamedProgramLocalParameterdvEXT, (GLuint, GLenum, GLuint, GLdouble *))
AGL_API(void, GetNamedProgramLocalParameterfvEXT, (GLuint, GLenum, GLuint, GLfloat *))
AGL_API(void, GetNamedProgramivEXT, (GLuint, GLenum, GLenum, GLint *))
AGL_API(void, GetNamedProgramStringEXT, (GLuint, GLenum, GLenum, GLvoid *))
AGL_API(void, NamedProgramLocalParameters4fvEXT, (GLuint, GLenum, GLuint, GLsizei, const GLfloat *))
AGL_API(void, NamedProgramLocalParameterI4iEXT, (GLuint, GLenum, GLuint, GLint, GLint, GLint, GLint))
AGL_API(void, NamedProgramLocalParameterI4ivEXT, (GLuint, GLenum, GLuint, const GLint *))
AGL_API(void, NamedProgramLocalParametersI4ivEXT, (GLuint, GLenum, GLuint, GLsizei, const GLint *))
AGL_API(void, NamedProgramLocalParameterI4uiEXT, (GLuint, GLenum, GLuint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, NamedProgramLocalParameterI4uivEXT, (GLuint, GLenum, GLuint, const GLuint *))
AGL_API(void, NamedProgramLocalParametersI4uivEXT, (GLuint, GLenum, GLuint, GLsizei, const GLuint *))
AGL_API(void, GetNamedProgramLocalParameterIivEXT, (GLuint, GLenum, GLuint, GLint *))
AGL_API(void, GetNamedProgramLocalParameterIuivEXT, (GLuint, GLenum, GLuint, GLuint *))
AGL_API(void, TextureParameterIivEXT, (GLuint, GLenum, GLenum, const GLint *))
AGL_API(void, TextureParameterIuivEXT, (GLuint, GLenum, GLenum, const GLuint *))
AGL_API(void, GetTextureParameterIivEXT, (GLuint, GLenum, GLenum, GLint *))
AGL_API(void, GetTextureParameterIuivEXT, (GLuint, GLenum, GLenum, GLuint *))
AGL_API(void, MultiTexParameterIivEXT, (GLenum, GLenum, GLenum, const GLint *))
AGL_API(void, MultiTexParameterIuivEXT, (GLenum, GLenum, GLenum, const GLuint *))
AGL_API(void, GetMultiTexParameterIivEXT, (GLenum, GLenum, GLenum, GLint *))
AGL_API(void, GetMultiTexParameterIuivEXT, (GLenum, GLenum, GLenum, GLuint *))
AGL_API(void, ProgramUniform1fEXT, (GLuint, GLint, GLfloat))
AGL_API(void, ProgramUniform2fEXT, (GLuint, GLint, GLfloat, GLfloat))
AGL_API(void, ProgramUniform3fEXT, (GLuint, GLint, GLfloat, GLfloat, GLfloat))
AGL_API(void, ProgramUniform4fEXT, (GLuint, GLint, GLfloat, GLfloat, GLfloat, GLfloat))
AGL_API(void, ProgramUniform1iEXT, (GLuint, GLint, GLint))
AGL_API(void, ProgramUniform2iEXT, (GLuint, GLint, GLint, GLint))
AGL_API(void, ProgramUniform3iEXT, (GLuint, GLint, GLint, GLint, GLint))
AGL_API(void, ProgramUniform4iEXT, (GLuint, GLint, GLint, GLint, GLint, GLint))
AGL_API(void, ProgramUniform1fvEXT, (GLuint, GLint, GLsizei, const GLfloat *))
AGL_API(void, ProgramUniform2fvEXT, (GLuint, GLint, GLsizei, const GLfloat *))
AGL_API(void, ProgramUniform3fvEXT, (GLuint, GLint, GLsizei, const GLfloat *))
AGL_API(void, ProgramUniform4fvEXT, (GLuint, GLint, GLsizei, const GLfloat *))
AGL_API(void, ProgramUniform1ivEXT, (GLuint, GLint, GLsizei, const GLint *))
AGL_API(void, ProgramUniform2ivEXT, (GLuint, GLint, GLsizei, const GLint *))
AGL_API(void, ProgramUniform3ivEXT, (GLuint, GLint, GLsizei, const GLint *))
AGL_API(void, ProgramUniform4ivEXT, (GLuint, GLint, GLsizei, const GLint *))
AGL_API(void, ProgramUniformMatrix2fvEXT, (GLuint, GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, ProgramUniformMatrix3fvEXT, (GLuint, GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, ProgramUniformMatrix4fvEXT, (GLuint, GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, ProgramUniformMatrix2x3fvEXT, (GLuint, GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, ProgramUniformMatrix3x2fvEXT, (GLuint, GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, ProgramUniformMatrix2x4fvEXT, (GLuint, GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, ProgramUniformMatrix4x2fvEXT, (GLuint, GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, ProgramUniformMatrix3x4fvEXT, (GLuint, GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, ProgramUniformMatrix4x3fvEXT, (GLuint, GLint, GLsizei, GLboolean, const GLfloat *))
AGL_API(void, ProgramUniform1uiEXT, (GLuint, GLint, GLuint))
AGL_API(void, ProgramUniform2uiEXT, (GLuint, GLint, GLuint, GLuint))
AGL_API(void, ProgramUniform3uiEXT, (GLuint, GLint, GLuint, GLuint, GLuint))
AGL_API(void, ProgramUniform4uiEXT, (GLuint, GLint, GLuint, GLuint, GLuint, GLuint))
AGL_API(void, ProgramUniform1uivEXT, (GLuint, GLint, GLsizei, const GLuint *))
AGL_API(void, ProgramUniform2uivEXT, (GLuint, GLint, GLsizei, const GLuint *))
AGL_API(void, ProgramUniform3uivEXT, (GLuint, GLint, GLsizei, const GLuint *))
AGL_API(void, ProgramUniform4uivEXT, (GLuint, GLint, GLsizei, const GLuint *))
AGL_API(void, NamedBufferDataEXT, (GLuint, GLsizeiptr, const GLvoid *, GLenum))
AGL_API(void, NamedBufferSubDataEXT, (GLuint, GLintptr, GLsizeiptr, const GLvoid *))
AGL_API(GLvoid*, MapNamedBufferEXT, (GLuint, GLenum))
AGL_API(GLboolean, UnmapNamedBufferEXT, (GLuint))
AGL_API(void, GetNamedBufferParameterivEXT, (GLuint, GLenum, GLint *))
AGL_API(void, GetNamedBufferPointervEXT, (GLuint, GLenum, GLvoid* *))
AGL_API(void, GetNamedBufferSubDataEXT, (GLuint, GLintptr, GLsizeiptr, GLvoid *))
AGL_API(void, TextureBufferEXT, (GLuint, GLenum, GLenum, GLuint))
AGL_API(void, MultiTexBufferEXT, (GLenum, GLenum, GLenum, GLuint))
AGL_API(void, NamedRenderbufferStorageEXT, (GLuint, GLenum, GLsizei, GLsizei))
AGL_API(void, GetNamedRenderbufferParameterivEXT, (GLuint, GLenum, GLint *))
AGL_API(GLenum, CheckNamedFramebufferStatusEXT, (GLuint, GLenum))
AGL_API(void, NamedFramebufferTexture1DEXT, (GLuint, GLenum, GLenum, GLuint, GLint))
AGL_API(void, NamedFramebufferTexture2DEXT, (GLuint, GLenum, GLenum, GLuint, GLint))
AGL_API(void, NamedFramebufferTexture3DEXT, (GLuint, GLenum, GLenum, GLuint, GLint, GLint))
AGL_API(void, NamedFramebufferRenderbufferEXT, (GLuint, GLenum, GLenum, GLuint))
AGL_API(void, GetNamedFramebufferAttachmentParameterivEXT, (GLuint, GLenum, GLenum, GLint *))
AGL_API(void, GenerateTextureMipmapEXT, (GLuint, GLenum))
AGL_API(void, GenerateMultiTexMipmapEXT, (GLenum, GLenum))
AGL_API(void, FramebufferDrawBufferEXT, (GLuint, GLenum))
AGL_API(void, FramebufferDrawBuffersEXT, (GLuint, GLsizei, const GLenum *))
AGL_API(void, FramebufferReadBufferEXT, (GLuint, GLenum))
AGL_API(void, GetFramebufferParameterivEXT, (GLuint, GLenum, GLint *))
AGL_API(void, NamedRenderbufferStorageMultisampleEXT, (GLuint, GLsizei, GLenum, GLsizei, GLsizei))
AGL_API(void, NamedRenderbufferStorageMultisampleCoverageEXT, (GLuint, GLsizei, GLsizei, GLenum, GLsizei, GLsizei))
AGL_API(void, NamedFramebufferTextureEXT, (GLuint, GLenum, GLuint, GLint))
AGL_API(void, NamedFramebufferTextureLayerEXT, (GLuint, GLenum, GLuint, GLint, GLint))
AGL_API(void, NamedFramebufferTextureFaceEXT, (GLuint, GLenum, GLuint, GLint, GLenum))
AGL_API(void, TextureRenderbufferEXT, (GLuint, GLenum, GLuint))
AGL_API(void, MultiTexRenderbufferEXT, (GLenum, GLenum, GLuint))
#endif

#if defined _ALLEGRO_GL_NV_explicit_multisample
AGL_API(void, GetMultisamplefvNV, (GLenum, GLuint, GLfloat *))
AGL_API(void, SampleMaskIndexedNV, (GLuint, GLbitfield))
AGL_API(void, TexRenderbufferNV, (GLenum, GLuint))
#endif

#if defined _ALLEGRO_GL_NV_transform_feedback2
AGL_API(void, BindTransformFeedbackNV, (GLenum, GLuint))
AGL_API(void, DeleteTransformFeedbacksNV, (GLsizei, const GLuint *))
AGL_API(void, GenTransformFeedbacksNV, (GLsizei, GLuint *))
AGL_API(GLboolean, IsTransformFeedbackNV, (GLuint))
AGL_API(void, PauseTransformFeedbackNV, (void))
AGL_API(void, ResumeTransformFeedbackNV, (void))
AGL_API(void, DrawTransformFeedbackNV, (GLenum, GLuint))
#endif

#if defined _ALLEGRO_GL_AMD_performance_monitor
AGL_API(void, GetPerfMonitorGroupsAMD, (GLint *, GLsizei, GLuint *))
AGL_API(void, GetPerfMonitorCountersAMD, (GLuint, GLint *, GLint *, GLsizei, GLuint *))
AGL_API(void, GetPerfMonitorGroupStringAMD, (GLuint, GLsizei, GLsizei *, GLchar *))
AGL_API(void, GetPerfMonitorCounterStringAMD, (GLuint, GLuint, GLsizei, GLsizei *, GLchar *))
AGL_API(void, GetPerfMonitorCounterInfoAMD, (GLuint, GLuint, GLenum, void *))
AGL_API(void, GenPerfMonitorsAMD, (GLsizei, GLuint *))
AGL_API(void, DeletePerfMonitorsAMD, (GLsizei, GLuint *))
AGL_API(void, SelectPerfMonitorCountersAMD, (GLuint, GLboolean, GLuint, GLint, GLuint *))
AGL_API(void, BeginPerfMonitorAMD, (GLuint))
AGL_API(void, EndPerfMonitorAMD, (GLuint))
AGL_API(void, GetPerfMonitorCounterDataAMD, (GLuint, GLenum, GLsizei, GLuint *, GLint *))
#endif

#if defined _ALLEGRO_GL_AMD_vertex_shader_tesselator
AGL_API(void, TessellationFactorAMD, (GLfloat))
AGL_API(void, TessellationModeAMD, (GLenum))
#endif

#if defined _ALLEGRO_GL_EXT_provoking_vertex
AGL_API(void, ProvokingVertexEXT, (GLenum))
#endif

#if defined _ALLEGRO_GL_AMD_draw_buffers_blend
AGL_API(void, BlendFuncIndexedAMD, (GLuint buf, GLenum src, GLenum dst))
AGL_API(void, BlendFuncSeparateIndexedAMD, (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha))
AGL_API(void, BlendEquationIndexedAMD, (GLuint buf, GLenum mode))
AGL_API(void, BlendEquationSeparateIndexedAMD, (GLuint buf, GLenum modeRGB, GLenum modeAlpha))
#endif

#if defined _ALLEGRO_GL_APPLE_texture_range
AGL_API(void, TextureRangeAPPLE, (GLenum target, GLsizei length, const GLvoid *pointer))
AGL_API(void, GetTexParameterPointervAPPLE, (GLenum target, GLenum pname, GLvoid* *params))
#endif

#if defined _ALLEGRO_GL_APPLE_vertex_program_evaluators
AGL_API(void, EnableVertexAttribAPPLE, (GLuint index, GLenum pname))
AGL_API(void, DisableVertexAttribAPPLE, (GLuint index, GLenum pname))
AGL_API(GLboolean, IsVertexAttribEnabledAPPLE, (GLuint index, GLenum pname))
AGL_API(void, MapVertexAttrib1dAPPLE, (GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint stride, GLint order, const GLdouble *points))
AGL_API(void, MapVertexAttrib1fAPPLE, (GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint stride, GLint order, const GLfloat *points))
AGL_API(void, MapVertexAttrib2dAPPLE, (GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, const GLdouble *points))
AGL_API(void, MapVertexAttrib2fAPPLE, (GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, const GLfloat *points))
#endif

#if defined _ALLEGRO_GL_APPLE_object_purgeable
AGL_API(GLenum, ObjectPurgeableAPPLE, (GLenum objectType, GLuint name, GLenum option))
AGL_API(GLenum, ObjectUnpurgeableAPPLE, (GLenum objectType, GLuint name, GLenum option))
AGL_API(void, GetObjectParameterivAPPLE, (GLenum objectType, GLuint name, GLenum pname, GLint *params))
#endif

#if defined _ALLEGRO_GL_NV_video_capture
AGL_API(void, BeginVideoCaptureNV, (GLuint video_capture_slot))
AGL_API(void, BindVideoCaptureStreamBufferNV, (GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLintptrARB offset))
AGL_API(void, BindVideoCaptureStreamTextureNV, (GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLenum target, GLuint texture))
AGL_API(void, EndVideoCaptureNV, (GLuint video_capture_slot))
AGL_API(void, GetVideoCaptureivNV, (GLuint video_capture_slot, GLenum pname, GLint *params))
AGL_API(void, GetVideoCaptureStreamivNV, (GLuint video_capture_slot, GLuint stream, GLenum pname, GLint *params))
AGL_API(void, GetVideoCaptureStreamfvNV, (GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat *params))
AGL_API(void, GetVideoCaptureStreamdvNV, (GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble *params))
AGL_API(GLenum, VideoCaptureNV, (GLuint video_capture_slot, GLuint *sequence_num, GLuint64EXT *capture_time))
AGL_API(void, VideoCaptureStreamParameterivNV, (GLuint video_capture_slot, GLuint stream, GLenum pname, const GLint *params))
AGL_API(void, VideoCaptureStreamParameterfvNV, (GLuint video_capture_slot, GLuint stream, GLenum pname, const GLfloat *params))
AGL_API(void, VideoCaptureStreamParameterdvNV, (GLuint video_capture_slot, GLuint stream, GLenum pname, const GLdouble *params))
#endif

#if defined _ALLEGRO_GL_EXT_separate_shader_objects
AGL_API(void, UseShaderProgramEXT, (GLenum type, GLuint program))
AGL_API(void, ActiveProgramEXT, (GLuint program))
AGL_API(GLuint, CreateShaderProgramEXT, (GLenum type, const GLchar *string))
#endif

#if defined _ALLEGRO_GL_NV_shader_buffer_load
AGL_API(void, MakeBufferResidentNV, (GLenum target, GLenum access))
AGL_API(void, MakeBufferNonResidentNV, (GLenum target))
AGL_API(GLboolean, IsBufferResidentNV, (GLenum target))
AGL_API(void, MakeNamedBufferResidentNV, (GLuint buffer, GLenum access))
AGL_API(void, MakeNamedBufferNonResidentNV, (GLuint buffer))
AGL_API(GLboolean, IsNamedBufferResidentNV, (GLuint buffer))
AGL_API(void, GetBufferParameterui64vNV, (GLenum target, GLenum pname, GLuint64EXT *params))
AGL_API(void, GetNamedBufferParameterui64vNV, (GLuint buffer, GLenum pname, GLuint64EXT *params))
AGL_API(void, GetIntegerui64vNV, (GLenum value, GLuint64EXT *result))
AGL_API(void, Uniformui64NV, (GLint location, GLuint64EXT value))
AGL_API(void, Uniformui64vNV, (GLint location, GLsizei count, const GLuint64EXT *value))
AGL_API(void, GetUniformui64vNV, (GLuint program, GLint location, GLuint64EXT *params))
AGL_API(void, ProgramUniformui64NV, (GLuint program, GLint location, GLuint64EXT value))
AGL_API(void, ProgramUniformui64vNV, (GLuint program, GLint location, GLsizei count, const GLuint64EXT *value))
#endif

#if defined _ALLEGRO_GL_NV_vertex_buffer_unified_memory
AGL_API(void, BufferAddressRangeNV, (GLenum pname, GLuint index, GLuint64EXT address, GLsizeiptr length))
AGL_API(void, VertexFormatNV, (GLint size, GLenum type, GLsizei stride))
AGL_API(void, NormalFormatNV, (GLenum type, GLsizei stride))
AGL_API(void, ColorFormatNV, (GLint size, GLenum type, GLsizei stride))
AGL_API(void, IndexFormatNV, (GLenum type, GLsizei stride))
AGL_API(void, TexCoordFormatNV, (GLint size, GLenum type, GLsizei stride))
AGL_API(void, EdgeFlagFormatNV, (GLsizei stride))
AGL_API(void, SecondaryColorFormatNV, (GLint size, GLenum type, GLsizei stride))
AGL_API(void, FogCoordFormatNV, (GLenum type, GLsizei stride))
AGL_API(void, VertexAttribFormatNV, (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride))
AGL_API(void, VertexAttribIFormatNV, (GLuint index, GLint size, GLenum type, GLsizei stride))
AGL_API(void, GetIntegerui64i_vNV, (GLenum value, GLuint index, GLuint64EXT *result))
#endif

#if defined _ALLEGRO_GL_NV_texture_barrier
AGL_API(void, TextureBarrierNV, (void))
#endif
