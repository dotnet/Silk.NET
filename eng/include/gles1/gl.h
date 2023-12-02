#ifndef __gles1_gl_h_
#define __gles1_gl_h_ 1

#ifdef __cplusplus
extern "C" {
#endif

/*
** Copyright 2013-2020 The Khronos Group Inc.
** SPDX-License-Identifier: MIT
**
** This header is generated from the Khronos OpenGL / OpenGL ES XML
** API Registry. The current version of the Registry, generator scripts
** used to make the header, and the header can be found at
**   https://github.com/KhronosGroup/OpenGL-Registry
*/

#include <GLES/glplatform.h>

#ifndef GL_APIENTRYP
#define GL_APIENTRYP GL_APIENTRY*
#endif

/* Generated C header for:
 * API: gles1
 * Profile: common
 * Versions considered: .*
 * Versions emitted: .*
 * Default extensions included: gles1
 * Additional extensions included: _nomatch_^
 * Extensions removed: _nomatch_^
 */

#ifndef GL_VERSION_ES_CM_1_0
#define GL_VERSION_ES_CM_1_0 1
#include <KHR/khrplatform.h>
typedef khronos_int8_t GLbyte;
typedef khronos_float_t GLclampf;
typedef khronos_int16_t GLshort;
typedef khronos_uint16_t GLushort;
typedef void GLvoid;
typedef unsigned int GLenum;
typedef khronos_float_t GLfloat;
typedef khronos_int32_t GLfixed;
typedef unsigned int GLuint;
typedef khronos_ssize_t GLsizeiptr;
typedef khronos_intptr_t GLintptr;
typedef unsigned int GLbitfield;
typedef int GLint;
typedef khronos_uint8_t GLubyte;
typedef unsigned char GLboolean;
typedef int GLsizei;
typedef khronos_int32_t GLclampx;
#define GL_VERSION_ES_CL_1_0              1
#define GL_VERSION_ES_CM_1_1              1
#define GL_VERSION_ES_CL_1_1              1
#define GL_DEPTH_BUFFER_BIT               0x00000100
#define GL_STENCIL_BUFFER_BIT             0x00000400
#define GL_COLOR_BUFFER_BIT               0x00004000
#define GL_FALSE                          0
#define GL_TRUE                           1
#define GL_POINTS                         0x0000
#define GL_LINES                          0x0001
#define GL_LINE_LOOP                      0x0002
#define GL_LINE_STRIP                     0x0003
#define GL_TRIANGLES                      0x0004
#define GL_TRIANGLE_STRIP                 0x0005
#define GL_TRIANGLE_FAN                   0x0006
#define GL_NEVER                          0x0200
#define GL_LESS                           0x0201
#define GL_EQUAL                          0x0202
#define GL_LEQUAL                         0x0203
#define GL_GREATER                        0x0204
#define GL_NOTEQUAL                       0x0205
#define GL_GEQUAL                         0x0206
#define GL_ALWAYS                         0x0207
#define GL_ZERO                           0
#define GL_ONE                            1
#define GL_SRC_COLOR                      0x0300
#define GL_ONE_MINUS_SRC_COLOR            0x0301
#define GL_SRC_ALPHA                      0x0302
#define GL_ONE_MINUS_SRC_ALPHA            0x0303
#define GL_DST_ALPHA                      0x0304
#define GL_ONE_MINUS_DST_ALPHA            0x0305
#define GL_DST_COLOR                      0x0306
#define GL_ONE_MINUS_DST_COLOR            0x0307
#define GL_SRC_ALPHA_SATURATE             0x0308
#define GL_CLIP_PLANE0                    0x3000
#define GL_CLIP_PLANE1                    0x3001
#define GL_CLIP_PLANE2                    0x3002
#define GL_CLIP_PLANE3                    0x3003
#define GL_CLIP_PLANE4                    0x3004
#define GL_CLIP_PLANE5                    0x3005
#define GL_FRONT                          0x0404
#define GL_BACK                           0x0405
#define GL_FRONT_AND_BACK                 0x0408
#define GL_FOG                            0x0B60
#define GL_LIGHTING                       0x0B50
#define GL_TEXTURE_2D                     0x0DE1
#define GL_CULL_FACE                      0x0B44
#define GL_ALPHA_TEST                     0x0BC0
#define GL_BLEND                          0x0BE2
#define GL_COLOR_LOGIC_OP                 0x0BF2
#define GL_DITHER                         0x0BD0
#define GL_STENCIL_TEST                   0x0B90
#define GL_DEPTH_TEST                     0x0B71
#define GL_POINT_SMOOTH                   0x0B10
#define GL_LINE_SMOOTH                    0x0B20
#define GL_SCISSOR_TEST                   0x0C11
#define GL_COLOR_MATERIAL                 0x0B57
#define GL_NORMALIZE                      0x0BA1
#define GL_RESCALE_NORMAL                 0x803A
#define GL_VERTEX_ARRAY                   0x8074
#define GL_NORMAL_ARRAY                   0x8075
#define GL_COLOR_ARRAY                    0x8076
#define GL_TEXTURE_COORD_ARRAY            0x8078
#define GL_MULTISAMPLE                    0x809D
#define GL_SAMPLE_ALPHA_TO_COVERAGE       0x809E
#define GL_SAMPLE_ALPHA_TO_ONE            0x809F
#define GL_SAMPLE_COVERAGE                0x80A0
#define GL_NO_ERROR                       0
#define GL_INVALID_ENUM                   0x0500
#define GL_INVALID_VALUE                  0x0501
#define GL_INVALID_OPERATION              0x0502
#define GL_STACK_OVERFLOW                 0x0503
#define GL_STACK_UNDERFLOW                0x0504
#define GL_OUT_OF_MEMORY                  0x0505
#define GL_EXP                            0x0800
#define GL_EXP2                           0x0801
#define GL_FOG_DENSITY                    0x0B62
#define GL_FOG_START                      0x0B63
#define GL_FOG_END                        0x0B64
#define GL_FOG_MODE                       0x0B65
#define GL_FOG_COLOR                      0x0B66
#define GL_CW                             0x0900
#define GL_CCW                            0x0901
#define GL_CURRENT_COLOR                  0x0B00
#define GL_CURRENT_NORMAL                 0x0B02
#define GL_CURRENT_TEXTURE_COORDS         0x0B03
#define GL_POINT_SIZE                     0x0B11
#define GL_POINT_SIZE_MIN                 0x8126
#define GL_POINT_SIZE_MAX                 0x8127
#define GL_POINT_FADE_THRESHOLD_SIZE      0x8128
#define GL_POINT_DISTANCE_ATTENUATION     0x8129
#define GL_SMOOTH_POINT_SIZE_RANGE        0x0B12
#define GL_LINE_WIDTH                     0x0B21
#define GL_SMOOTH_LINE_WIDTH_RANGE        0x0B22
#define GL_ALIASED_POINT_SIZE_RANGE       0x846D
#define GL_ALIASED_LINE_WIDTH_RANGE       0x846E
#define GL_CULL_FACE_MODE                 0x0B45
#define GL_FRONT_FACE                     0x0B46
#define GL_SHADE_MODEL                    0x0B54
#define GL_DEPTH_RANGE                    0x0B70
#define GL_DEPTH_WRITEMASK                0x0B72
#define GL_DEPTH_CLEAR_VALUE              0x0B73
#define GL_DEPTH_FUNC                     0x0B74
#define GL_STENCIL_CLEAR_VALUE            0x0B91
#define GL_STENCIL_FUNC                   0x0B92
#define GL_STENCIL_VALUE_MASK             0x0B93
#define GL_STENCIL_FAIL                   0x0B94
#define GL_STENCIL_PASS_DEPTH_FAIL        0x0B95
#define GL_STENCIL_PASS_DEPTH_PASS        0x0B96
#define GL_STENCIL_REF                    0x0B97
#define GL_STENCIL_WRITEMASK              0x0B98
#define GL_MATRIX_MODE                    0x0BA0
#define GL_VIEWPORT                       0x0BA2
#define GL_MODELVIEW_STACK_DEPTH          0x0BA3
#define GL_PROJECTION_STACK_DEPTH         0x0BA4
#define GL_TEXTURE_STACK_DEPTH            0x0BA5
#define GL_MODELVIEW_MATRIX               0x0BA6
#define GL_PROJECTION_MATRIX              0x0BA7
#define GL_TEXTURE_MATRIX                 0x0BA8
#define GL_ALPHA_TEST_FUNC                0x0BC1
#define GL_ALPHA_TEST_REF                 0x0BC2
#define GL_BLEND_DST                      0x0BE0
#define GL_BLEND_SRC                      0x0BE1
#define GL_LOGIC_OP_MODE                  0x0BF0
#define GL_SCISSOR_BOX                    0x0C10
#define GL_COLOR_CLEAR_VALUE              0x0C22
#define GL_COLOR_WRITEMASK                0x0C23
#define GL_MAX_LIGHTS                     0x0D31
#define GL_MAX_CLIP_PLANES                0x0D32
#define GL_MAX_TEXTURE_SIZE               0x0D33
#define GL_MAX_MODELVIEW_STACK_DEPTH      0x0D36
#define GL_MAX_PROJECTION_STACK_DEPTH     0x0D38
#define GL_MAX_TEXTURE_STACK_DEPTH        0x0D39
#define GL_MAX_VIEWPORT_DIMS              0x0D3A
#define GL_MAX_TEXTURE_UNITS              0x84E2
#define GL_SUBPIXEL_BITS                  0x0D50
#define GL_RED_BITS                       0x0D52
#define GL_GREEN_BITS                     0x0D53
#define GL_BLUE_BITS                      0x0D54
#define GL_ALPHA_BITS                     0x0D55
#define GL_DEPTH_BITS                     0x0D56
#define GL_STENCIL_BITS                   0x0D57
#define GL_POLYGON_OFFSET_UNITS           0x2A00
#define GL_POLYGON_OFFSET_FILL            0x8037
#define GL_POLYGON_OFFSET_FACTOR          0x8038
#define GL_TEXTURE_BINDING_2D             0x8069
#define GL_VERTEX_ARRAY_SIZE              0x807A
#define GL_VERTEX_ARRAY_TYPE              0x807B
#define GL_VERTEX_ARRAY_STRIDE            0x807C
#define GL_NORMAL_ARRAY_TYPE              0x807E
#define GL_NORMAL_ARRAY_STRIDE            0x807F
#define GL_COLOR_ARRAY_SIZE               0x8081
#define GL_COLOR_ARRAY_TYPE               0x8082
#define GL_COLOR_ARRAY_STRIDE             0x8083
#define GL_TEXTURE_COORD_ARRAY_SIZE       0x8088
#define GL_TEXTURE_COORD_ARRAY_TYPE       0x8089
#define GL_TEXTURE_COORD_ARRAY_STRIDE     0x808A
#define GL_VERTEX_ARRAY_POINTER           0x808E
#define GL_NORMAL_ARRAY_POINTER           0x808F
#define GL_COLOR_ARRAY_POINTER            0x8090
#define GL_TEXTURE_COORD_ARRAY_POINTER    0x8092
#define GL_SAMPLE_BUFFERS                 0x80A8
#define GL_SAMPLES                        0x80A9
#define GL_SAMPLE_COVERAGE_VALUE          0x80AA
#define GL_SAMPLE_COVERAGE_INVERT         0x80AB
#define GL_NUM_COMPRESSED_TEXTURE_FORMATS 0x86A2
#define GL_COMPRESSED_TEXTURE_FORMATS     0x86A3
#define GL_DONT_CARE                      0x1100
#define GL_FASTEST                        0x1101
#define GL_NICEST                         0x1102
#define GL_PERSPECTIVE_CORRECTION_HINT    0x0C50
#define GL_POINT_SMOOTH_HINT              0x0C51
#define GL_LINE_SMOOTH_HINT               0x0C52
#define GL_FOG_HINT                       0x0C54
#define GL_GENERATE_MIPMAP_HINT           0x8192
#define GL_LIGHT_MODEL_AMBIENT            0x0B53
#define GL_LIGHT_MODEL_TWO_SIDE           0x0B52
#define GL_AMBIENT                        0x1200
#define GL_DIFFUSE                        0x1201
#define GL_SPECULAR                       0x1202
#define GL_POSITION                       0x1203
#define GL_SPOT_DIRECTION                 0x1204
#define GL_SPOT_EXPONENT                  0x1205
#define GL_SPOT_CUTOFF                    0x1206
#define GL_CONSTANT_ATTENUATION           0x1207
#define GL_LINEAR_ATTENUATION             0x1208
#define GL_QUADRATIC_ATTENUATION          0x1209
#define GL_BYTE                           0x1400
#define GL_UNSIGNED_BYTE                  0x1401
#define GL_SHORT                          0x1402
#define GL_UNSIGNED_SHORT                 0x1403
#define GL_FLOAT                          0x1406
#define GL_FIXED                          0x140C
#define GL_CLEAR                          0x1500
#define GL_AND                            0x1501
#define GL_AND_REVERSE                    0x1502
#define GL_COPY                           0x1503
#define GL_AND_INVERTED                   0x1504
#define GL_NOOP                           0x1505
#define GL_XOR                            0x1506
#define GL_OR                             0x1507
#define GL_NOR                            0x1508
#define GL_EQUIV                          0x1509
#define GL_INVERT                         0x150A
#define GL_OR_REVERSE                     0x150B
#define GL_COPY_INVERTED                  0x150C
#define GL_OR_INVERTED                    0x150D
#define GL_NAND                           0x150E
#define GL_SET                            0x150F
#define GL_EMISSION                       0x1600
#define GL_SHININESS                      0x1601
#define GL_AMBIENT_AND_DIFFUSE            0x1602
#define GL_MODELVIEW                      0x1700
#define GL_PROJECTION                     0x1701
#define GL_TEXTURE                        0x1702
#define GL_ALPHA                          0x1906
#define GL_RGB                            0x1907
#define GL_RGBA                           0x1908
#define GL_LUMINANCE                      0x1909
#define GL_LUMINANCE_ALPHA                0x190A
#define GL_UNPACK_ALIGNMENT               0x0CF5
#define GL_PACK_ALIGNMENT                 0x0D05
#define GL_UNSIGNED_SHORT_4_4_4_4         0x8033
#define GL_UNSIGNED_SHORT_5_5_5_1         0x8034
#define GL_UNSIGNED_SHORT_5_6_5           0x8363
#define GL_FLAT                           0x1D00
#define GL_SMOOTH                         0x1D01
#define GL_KEEP                           0x1E00
#define GL_REPLACE                        0x1E01
#define GL_INCR                           0x1E02
#define GL_DECR                           0x1E03
#define GL_VENDOR                         0x1F00
#define GL_RENDERER                       0x1F01
#define GL_VERSION                        0x1F02
#define GL_EXTENSIONS                     0x1F03
#define GL_MODULATE                       0x2100
#define GL_DECAL                          0x2101
#define GL_ADD                            0x0104
#define GL_TEXTURE_ENV_MODE               0x2200
#define GL_TEXTURE_ENV_COLOR              0x2201
#define GL_TEXTURE_ENV                    0x2300
#define GL_NEAREST                        0x2600
#define GL_LINEAR                         0x2601
#define GL_NEAREST_MIPMAP_NEAREST         0x2700
#define GL_LINEAR_MIPMAP_NEAREST          0x2701
#define GL_NEAREST_MIPMAP_LINEAR          0x2702
#define GL_LINEAR_MIPMAP_LINEAR           0x2703
#define GL_TEXTURE_MAG_FILTER             0x2800
#define GL_TEXTURE_MIN_FILTER             0x2801
#define GL_TEXTURE_WRAP_S                 0x2802
#define GL_TEXTURE_WRAP_T                 0x2803
#define GL_GENERATE_MIPMAP                0x8191
#define GL_TEXTURE0                       0x84C0
#define GL_TEXTURE1                       0x84C1
#define GL_TEXTURE2                       0x84C2
#define GL_TEXTURE3                       0x84C3
#define GL_TEXTURE4                       0x84C4
#define GL_TEXTURE5                       0x84C5
#define GL_TEXTURE6                       0x84C6
#define GL_TEXTURE7                       0x84C7
#define GL_TEXTURE8                       0x84C8
#define GL_TEXTURE9                       0x84C9
#define GL_TEXTURE10                      0x84CA
#define GL_TEXTURE11                      0x84CB
#define GL_TEXTURE12                      0x84CC
#define GL_TEXTURE13                      0x84CD
#define GL_TEXTURE14                      0x84CE
#define GL_TEXTURE15                      0x84CF
#define GL_TEXTURE16                      0x84D0
#define GL_TEXTURE17                      0x84D1
#define GL_TEXTURE18                      0x84D2
#define GL_TEXTURE19                      0x84D3
#define GL_TEXTURE20                      0x84D4
#define GL_TEXTURE21                      0x84D5
#define GL_TEXTURE22                      0x84D6
#define GL_TEXTURE23                      0x84D7
#define GL_TEXTURE24                      0x84D8
#define GL_TEXTURE25                      0x84D9
#define GL_TEXTURE26                      0x84DA
#define GL_TEXTURE27                      0x84DB
#define GL_TEXTURE28                      0x84DC
#define GL_TEXTURE29                      0x84DD
#define GL_TEXTURE30                      0x84DE
#define GL_TEXTURE31                      0x84DF
#define GL_ACTIVE_TEXTURE                 0x84E0
#define GL_CLIENT_ACTIVE_TEXTURE          0x84E1
#define GL_REPEAT                         0x2901
#define GL_CLAMP_TO_EDGE                  0x812F
#define GL_LIGHT0                         0x4000
#define GL_LIGHT1                         0x4001
#define GL_LIGHT2                         0x4002
#define GL_LIGHT3                         0x4003
#define GL_LIGHT4                         0x4004
#define GL_LIGHT5                         0x4005
#define GL_LIGHT6                         0x4006
#define GL_LIGHT7                         0x4007
#define GL_ARRAY_BUFFER                   0x8892
#define GL_ELEMENT_ARRAY_BUFFER           0x8893
#define GL_ARRAY_BUFFER_BINDING           0x8894
#define GL_ELEMENT_ARRAY_BUFFER_BINDING   0x8895
#define GL_VERTEX_ARRAY_BUFFER_BINDING    0x8896
#define GL_NORMAL_ARRAY_BUFFER_BINDING    0x8897
#define GL_COLOR_ARRAY_BUFFER_BINDING     0x8898
#define GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING 0x889A
#define GL_STATIC_DRAW                    0x88E4
#define GL_DYNAMIC_DRAW                   0x88E8
#define GL_BUFFER_SIZE                    0x8764
#define GL_BUFFER_USAGE                   0x8765
#define GL_SUBTRACT                       0x84E7
#define GL_COMBINE                        0x8570
#define GL_COMBINE_RGB                    0x8571
#define GL_COMBINE_ALPHA                  0x8572
#define GL_RGB_SCALE                      0x8573
#define GL_ADD_SIGNED                     0x8574
#define GL_INTERPOLATE                    0x8575
#define GL_CONSTANT                       0x8576
#define GL_PRIMARY_COLOR                  0x8577
#define GL_PREVIOUS                       0x8578
#define GL_OPERAND0_RGB                   0x8590
#define GL_OPERAND1_RGB                   0x8591
#define GL_OPERAND2_RGB                   0x8592
#define GL_OPERAND0_ALPHA                 0x8598
#define GL_OPERAND1_ALPHA                 0x8599
#define GL_OPERAND2_ALPHA                 0x859A
#define GL_ALPHA_SCALE                    0x0D1C
#define GL_SRC0_RGB                       0x8580
#define GL_SRC1_RGB                       0x8581
#define GL_SRC2_RGB                       0x8582
#define GL_SRC0_ALPHA                     0x8588
#define GL_SRC1_ALPHA                     0x8589
#define GL_SRC2_ALPHA                     0x858A
#define GL_DOT3_RGB                       0x86AE
#define GL_DOT3_RGBA                      0x86AF
GL_API void GL_APIENTRY glAlphaFunc (GLenum func, GLfloat ref);
GL_API void GL_APIENTRY glClearColor (GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
GL_API void GL_APIENTRY glClearDepthf (GLfloat d);
GL_API void GL_APIENTRY glClipPlanef (GLenum p, const GLfloat *eqn);
GL_API void GL_APIENTRY glColor4f (GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
GL_API void GL_APIENTRY glDepthRangef (GLfloat n, GLfloat f);
GL_API void GL_APIENTRY glFogf (GLenum pname, GLfloat param);
GL_API void GL_APIENTRY glFogfv (GLenum pname, const GLfloat *params);
GL_API void GL_APIENTRY glFrustumf (GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);
GL_API void GL_APIENTRY glGetClipPlanef (GLenum plane, GLfloat *equation);
GL_API void GL_APIENTRY glGetFloatv (GLenum pname, GLfloat *data);
GL_API void GL_APIENTRY glGetLightfv (GLenum light, GLenum pname, GLfloat *params);
GL_API void GL_APIENTRY glGetMaterialfv (GLenum face, GLenum pname, GLfloat *params);
GL_API void GL_APIENTRY glGetTexEnvfv (GLenum target, GLenum pname, GLfloat *params);
GL_API void GL_APIENTRY glGetTexParameterfv (GLenum target, GLenum pname, GLfloat *params);
GL_API void GL_APIENTRY glLightModelf (GLenum pname, GLfloat param);
GL_API void GL_APIENTRY glLightModelfv (GLenum pname, const GLfloat *params);
GL_API void GL_APIENTRY glLightf (GLenum light, GLenum pname, GLfloat param);
GL_API void GL_APIENTRY glLightfv (GLenum light, GLenum pname, const GLfloat *params);
GL_API void GL_APIENTRY glLineWidth (GLfloat width);
GL_API void GL_APIENTRY glLoadMatrixf (const GLfloat *m);
GL_API void GL_APIENTRY glMaterialf (GLenum face, GLenum pname, GLfloat param);
GL_API void GL_APIENTRY glMaterialfv (GLenum face, GLenum pname, const GLfloat *params);
GL_API void GL_APIENTRY glMultMatrixf (const GLfloat *m);
GL_API void GL_APIENTRY glMultiTexCoord4f (GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
GL_API void GL_APIENTRY glNormal3f (GLfloat nx, GLfloat ny, GLfloat nz);
GL_API void GL_APIENTRY glOrthof (GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);
GL_API void GL_APIENTRY glPointParameterf (GLenum pname, GLfloat param);
GL_API void GL_APIENTRY glPointParameterfv (GLenum pname, const GLfloat *params);
GL_API void GL_APIENTRY glPointSize (GLfloat size);
GL_API void GL_APIENTRY glPolygonOffset (GLfloat factor, GLfloat units);
GL_API void GL_APIENTRY glRotatef (GLfloat angle, GLfloat x, GLfloat y, GLfloat z);
GL_API void GL_APIENTRY glScalef (GLfloat x, GLfloat y, GLfloat z);
GL_API void GL_APIENTRY glTexEnvf (GLenum target, GLenum pname, GLfloat param);
GL_API void GL_APIENTRY glTexEnvfv (GLenum target, GLenum pname, const GLfloat *params);
GL_API void GL_APIENTRY glTexParameterf (GLenum target, GLenum pname, GLfloat param);
GL_API void GL_APIENTRY glTexParameterfv (GLenum target, GLenum pname, const GLfloat *params);
GL_API void GL_APIENTRY glTranslatef (GLfloat x, GLfloat y, GLfloat z);
GL_API void GL_APIENTRY glActiveTexture (GLenum texture);
GL_API void GL_APIENTRY glAlphaFuncx (GLenum func, GLfixed ref);
GL_API void GL_APIENTRY glBindBuffer (GLenum target, GLuint buffer);
GL_API void GL_APIENTRY glBindTexture (GLenum target, GLuint texture);
GL_API void GL_APIENTRY glBlendFunc (GLenum sfactor, GLenum dfactor);
GL_API void GL_APIENTRY glBufferData (GLenum target, GLsizeiptr size, const void *data, GLenum usage);
GL_API void GL_APIENTRY glBufferSubData (GLenum target, GLintptr offset, GLsizeiptr size, const void *data);
GL_API void GL_APIENTRY glClear (GLbitfield mask);
GL_API void GL_APIENTRY glClearColorx (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
GL_API void GL_APIENTRY glClearDepthx (GLfixed depth);
GL_API void GL_APIENTRY glClearStencil (GLint s);
GL_API void GL_APIENTRY glClientActiveTexture (GLenum texture);
GL_API void GL_APIENTRY glClipPlanex (GLenum plane, const GLfixed *equation);
GL_API void GL_APIENTRY glColor4ub (GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha);
GL_API void GL_APIENTRY glColor4x (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
GL_API void GL_APIENTRY glColorMask (GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);
GL_API void GL_APIENTRY glColorPointer (GLint size, GLenum type, GLsizei stride, const void *pointer);
GL_API void GL_APIENTRY glCompressedTexImage2D (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, const void *data);
GL_API void GL_APIENTRY glCompressedTexSubImage2D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const void *data);
GL_API void GL_APIENTRY glCopyTexImage2D (GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
GL_API void GL_APIENTRY glCopyTexSubImage2D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
GL_API void GL_APIENTRY glCullFace (GLenum mode);
GL_API void GL_APIENTRY glDeleteBuffers (GLsizei n, const GLuint *buffers);
GL_API void GL_APIENTRY glDeleteTextures (GLsizei n, const GLuint *textures);
GL_API void GL_APIENTRY glDepthFunc (GLenum func);
GL_API void GL_APIENTRY glDepthMask (GLboolean flag);
GL_API void GL_APIENTRY glDepthRangex (GLfixed n, GLfixed f);
GL_API void GL_APIENTRY glDisable (GLenum cap);
GL_API void GL_APIENTRY glDisableClientState (GLenum array);
GL_API void GL_APIENTRY glDrawArrays (GLenum mode, GLint first, GLsizei count);
GL_API void GL_APIENTRY glDrawElements (GLenum mode, GLsizei count, GLenum type, const void *indices);
GL_API void GL_APIENTRY glEnable (GLenum cap);
GL_API void GL_APIENTRY glEnableClientState (GLenum array);
GL_API void GL_APIENTRY glFinish (void);
GL_API void GL_APIENTRY glFlush (void);
GL_API void GL_APIENTRY glFogx (GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glFogxv (GLenum pname, const GLfixed *param);
GL_API void GL_APIENTRY glFrontFace (GLenum mode);
GL_API void GL_APIENTRY glFrustumx (GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);
GL_API void GL_APIENTRY glGetBooleanv (GLenum pname, GLboolean *data);
GL_API void GL_APIENTRY glGetBufferParameteriv (GLenum target, GLenum pname, GLint *params);
GL_API void GL_APIENTRY glGetClipPlanex (GLenum plane, GLfixed *equation);
GL_API void GL_APIENTRY glGenBuffers (GLsizei n, GLuint *buffers);
GL_API void GL_APIENTRY glGenTextures (GLsizei n, GLuint *textures);
GL_API GLenum GL_APIENTRY glGetError (void);
GL_API void GL_APIENTRY glGetFixedv (GLenum pname, GLfixed *params);
GL_API void GL_APIENTRY glGetIntegerv (GLenum pname, GLint *data);
GL_API void GL_APIENTRY glGetLightxv (GLenum light, GLenum pname, GLfixed *params);
GL_API void GL_APIENTRY glGetMaterialxv (GLenum face, GLenum pname, GLfixed *params);
GL_API void GL_APIENTRY glGetPointerv (GLenum pname, void **params);
GL_API const GLubyte *GL_APIENTRY glGetString (GLenum name);
GL_API void GL_APIENTRY glGetTexEnviv (GLenum target, GLenum pname, GLint *params);
GL_API void GL_APIENTRY glGetTexEnvxv (GLenum target, GLenum pname, GLfixed *params);
GL_API void GL_APIENTRY glGetTexParameteriv (GLenum target, GLenum pname, GLint *params);
GL_API void GL_APIENTRY glGetTexParameterxv (GLenum target, GLenum pname, GLfixed *params);
GL_API void GL_APIENTRY glHint (GLenum target, GLenum mode);
GL_API GLboolean GL_APIENTRY glIsBuffer (GLuint buffer);
GL_API GLboolean GL_APIENTRY glIsEnabled (GLenum cap);
GL_API GLboolean GL_APIENTRY glIsTexture (GLuint texture);
GL_API void GL_APIENTRY glLightModelx (GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glLightModelxv (GLenum pname, const GLfixed *param);
GL_API void GL_APIENTRY glLightx (GLenum light, GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glLightxv (GLenum light, GLenum pname, const GLfixed *params);
GL_API void GL_APIENTRY glLineWidthx (GLfixed width);
GL_API void GL_APIENTRY glLoadIdentity (void);
GL_API void GL_APIENTRY glLoadMatrixx (const GLfixed *m);
GL_API void GL_APIENTRY glLogicOp (GLenum opcode);
GL_API void GL_APIENTRY glMaterialx (GLenum face, GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glMaterialxv (GLenum face, GLenum pname, const GLfixed *param);
GL_API void GL_APIENTRY glMatrixMode (GLenum mode);
GL_API void GL_APIENTRY glMultMatrixx (const GLfixed *m);
GL_API void GL_APIENTRY glMultiTexCoord4x (GLenum texture, GLfixed s, GLfixed t, GLfixed r, GLfixed q);
GL_API void GL_APIENTRY glNormal3x (GLfixed nx, GLfixed ny, GLfixed nz);
GL_API void GL_APIENTRY glNormalPointer (GLenum type, GLsizei stride, const void *pointer);
GL_API void GL_APIENTRY glOrthox (GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);
GL_API void GL_APIENTRY glPixelStorei (GLenum pname, GLint param);
GL_API void GL_APIENTRY glPointParameterx (GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glPointParameterxv (GLenum pname, const GLfixed *params);
GL_API void GL_APIENTRY glPointSizex (GLfixed size);
GL_API void GL_APIENTRY glPolygonOffsetx (GLfixed factor, GLfixed units);
GL_API void GL_APIENTRY glPopMatrix (void);
GL_API void GL_APIENTRY glPushMatrix (void);
GL_API void GL_APIENTRY glReadPixels (GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void *pixels);
GL_API void GL_APIENTRY glRotatex (GLfixed angle, GLfixed x, GLfixed y, GLfixed z);
GL_API void GL_APIENTRY glSampleCoverage (GLfloat value, GLboolean invert);
GL_API void GL_APIENTRY glSampleCoveragex (GLclampx value, GLboolean invert);
GL_API void GL_APIENTRY glScalex (GLfixed x, GLfixed y, GLfixed z);
GL_API void GL_APIENTRY glScissor (GLint x, GLint y, GLsizei width, GLsizei height);
GL_API void GL_APIENTRY glShadeModel (GLenum mode);
GL_API void GL_APIENTRY glStencilFunc (GLenum func, GLint ref, GLuint mask);
GL_API void GL_APIENTRY glStencilMask (GLuint mask);
GL_API void GL_APIENTRY glStencilOp (GLenum fail, GLenum zfail, GLenum zpass);
GL_API void GL_APIENTRY glTexCoordPointer (GLint size, GLenum type, GLsizei stride, const void *pointer);
GL_API void GL_APIENTRY glTexEnvi (GLenum target, GLenum pname, GLint param);
GL_API void GL_APIENTRY glTexEnvx (GLenum target, GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glTexEnviv (GLenum target, GLenum pname, const GLint *params);
GL_API void GL_APIENTRY glTexEnvxv (GLenum target, GLenum pname, const GLfixed *params);
GL_API void GL_APIENTRY glTexImage2D (GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, const void *pixels);
GL_API void GL_APIENTRY glTexParameteri (GLenum target, GLenum pname, GLint param);
GL_API void GL_APIENTRY glTexParameterx (GLenum target, GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glTexParameteriv (GLenum target, GLenum pname, const GLint *params);
GL_API void GL_APIENTRY glTexParameterxv (GLenum target, GLenum pname, const GLfixed *params);
GL_API void GL_APIENTRY glTexSubImage2D (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const void *pixels);
GL_API void GL_APIENTRY glTranslatex (GLfixed x, GLfixed y, GLfixed z);
GL_API void GL_APIENTRY glVertexPointer (GLint size, GLenum type, GLsizei stride, const void *pointer);
GL_API void GL_APIENTRY glViewport (GLint x, GLint y, GLsizei width, GLsizei height);
#endif /* GL_VERSION_ES_CM_1_0 */

#ifndef GL_KHR_debug
#define GL_KHR_debug 1
#endif /* GL_KHR_debug */

#ifndef GL_OES_EGL_image
#define GL_OES_EGL_image 1
typedef void *GLeglImageOES;
GL_API void GL_APIENTRY glEGLImageTargetTexture2DOES (GLenum target, GLeglImageOES image);
GL_API void GL_APIENTRY glEGLImageTargetRenderbufferStorageOES (GLenum target, GLeglImageOES image);
#endif /* GL_OES_EGL_image */

#ifndef GL_OES_EGL_image_external
#define GL_OES_EGL_image_external 1
#define GL_TEXTURE_EXTERNAL_OES           0x8D65
#define GL_TEXTURE_BINDING_EXTERNAL_OES   0x8D67
#define GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES 0x8D68
#endif /* GL_OES_EGL_image_external */

#ifndef GL_OES_blend_equation_separate
#define GL_OES_blend_equation_separate 1
#define GL_BLEND_EQUATION_RGB_OES         0x8009
#define GL_BLEND_EQUATION_ALPHA_OES       0x883D
GL_API void GL_APIENTRY glBlendEquationSeparateOES (GLenum modeRGB, GLenum modeAlpha);
#endif /* GL_OES_blend_equation_separate */

#ifndef GL_OES_blend_func_separate
#define GL_OES_blend_func_separate 1
#define GL_BLEND_DST_RGB_OES              0x80C8
#define GL_BLEND_SRC_RGB_OES              0x80C9
#define GL_BLEND_DST_ALPHA_OES            0x80CA
#define GL_BLEND_SRC_ALPHA_OES            0x80CB
GL_API void GL_APIENTRY glBlendFuncSeparateOES (GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);
#endif /* GL_OES_blend_func_separate */

#ifndef GL_OES_blend_subtract
#define GL_OES_blend_subtract 1
#define GL_BLEND_EQUATION_OES             0x8009
#define GL_FUNC_ADD_OES                   0x8006
#define GL_FUNC_SUBTRACT_OES              0x800A
#define GL_FUNC_REVERSE_SUBTRACT_OES      0x800B
GL_API void GL_APIENTRY glBlendEquationOES (GLenum mode);
#endif /* GL_OES_blend_subtract */

#ifndef GL_OES_byte_coordinates
#define GL_OES_byte_coordinates 1
#endif /* GL_OES_byte_coordinates */

#ifndef GL_OES_compressed_ETC1_RGB8_sub_texture
#define GL_OES_compressed_ETC1_RGB8_sub_texture 1
#endif /* GL_OES_compressed_ETC1_RGB8_sub_texture */

#ifndef GL_OES_compressed_ETC1_RGB8_texture
#define GL_OES_compressed_ETC1_RGB8_texture 1
#define GL_ETC1_RGB8_OES                  0x8D64
#endif /* GL_OES_compressed_ETC1_RGB8_texture */

#ifndef GL_OES_compressed_paletted_texture
#define GL_OES_compressed_paletted_texture 1
#define GL_PALETTE4_RGB8_OES              0x8B90
#define GL_PALETTE4_RGBA8_OES             0x8B91
#define GL_PALETTE4_R5_G6_B5_OES          0x8B92
#define GL_PALETTE4_RGBA4_OES             0x8B93
#define GL_PALETTE4_RGB5_A1_OES           0x8B94
#define GL_PALETTE8_RGB8_OES              0x8B95
#define GL_PALETTE8_RGBA8_OES             0x8B96
#define GL_PALETTE8_R5_G6_B5_OES          0x8B97
#define GL_PALETTE8_RGBA4_OES             0x8B98
#define GL_PALETTE8_RGB5_A1_OES           0x8B99
#endif /* GL_OES_compressed_paletted_texture */

#ifndef GL_OES_depth24
#define GL_OES_depth24 1
#define GL_DEPTH_COMPONENT24_OES          0x81A6
#endif /* GL_OES_depth24 */

#ifndef GL_OES_depth32
#define GL_OES_depth32 1
#define GL_DEPTH_COMPONENT32_OES          0x81A7
#endif /* GL_OES_depth32 */

#ifndef GL_OES_draw_texture
#define GL_OES_draw_texture 1
#define GL_TEXTURE_CROP_RECT_OES          0x8B9D
GL_API void GL_APIENTRY glDrawTexsOES (GLshort x, GLshort y, GLshort z, GLshort width, GLshort height);
GL_API void GL_APIENTRY glDrawTexiOES (GLint x, GLint y, GLint z, GLint width, GLint height);
GL_API void GL_APIENTRY glDrawTexxOES (GLfixed x, GLfixed y, GLfixed z, GLfixed width, GLfixed height);
GL_API void GL_APIENTRY glDrawTexsvOES (const GLshort *coords);
GL_API void GL_APIENTRY glDrawTexivOES (const GLint *coords);
GL_API void GL_APIENTRY glDrawTexxvOES (const GLfixed *coords);
GL_API void GL_APIENTRY glDrawTexfOES (GLfloat x, GLfloat y, GLfloat z, GLfloat width, GLfloat height);
GL_API void GL_APIENTRY glDrawTexfvOES (const GLfloat *coords);
#endif /* GL_OES_draw_texture */

#ifndef GL_OES_element_index_uint
#define GL_OES_element_index_uint 1
#define GL_UNSIGNED_INT                   0x1405
#endif /* GL_OES_element_index_uint */

#ifndef GL_OES_extended_matrix_palette
#define GL_OES_extended_matrix_palette 1
#endif /* GL_OES_extended_matrix_palette */

#ifndef GL_OES_fbo_render_mipmap
#define GL_OES_fbo_render_mipmap 1
#endif /* GL_OES_fbo_render_mipmap */

#ifndef GL_OES_fixed_point
#define GL_OES_fixed_point 1
#define GL_FIXED_OES                      0x140C
GL_API void GL_APIENTRY glAlphaFuncxOES (GLenum func, GLfixed ref);
GL_API void GL_APIENTRY glClearColorxOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
GL_API void GL_APIENTRY glClearDepthxOES (GLfixed depth);
GL_API void GL_APIENTRY glClipPlanexOES (GLenum plane, const GLfixed *equation);
GL_API void GL_APIENTRY glColor4xOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
GL_API void GL_APIENTRY glDepthRangexOES (GLfixed n, GLfixed f);
GL_API void GL_APIENTRY glFogxOES (GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glFogxvOES (GLenum pname, const GLfixed *param);
GL_API void GL_APIENTRY glFrustumxOES (GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);
GL_API void GL_APIENTRY glGetClipPlanexOES (GLenum plane, GLfixed *equation);
GL_API void GL_APIENTRY glGetFixedvOES (GLenum pname, GLfixed *params);
GL_API void GL_APIENTRY glGetTexEnvxvOES (GLenum target, GLenum pname, GLfixed *params);
GL_API void GL_APIENTRY glGetTexParameterxvOES (GLenum target, GLenum pname, GLfixed *params);
GL_API void GL_APIENTRY glLightModelxOES (GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glLightModelxvOES (GLenum pname, const GLfixed *param);
GL_API void GL_APIENTRY glLightxOES (GLenum light, GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glLightxvOES (GLenum light, GLenum pname, const GLfixed *params);
GL_API void GL_APIENTRY glLineWidthxOES (GLfixed width);
GL_API void GL_APIENTRY glLoadMatrixxOES (const GLfixed *m);
GL_API void GL_APIENTRY glMaterialxOES (GLenum face, GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glMaterialxvOES (GLenum face, GLenum pname, const GLfixed *param);
GL_API void GL_APIENTRY glMultMatrixxOES (const GLfixed *m);
GL_API void GL_APIENTRY glMultiTexCoord4xOES (GLenum texture, GLfixed s, GLfixed t, GLfixed r, GLfixed q);
GL_API void GL_APIENTRY glNormal3xOES (GLfixed nx, GLfixed ny, GLfixed nz);
GL_API void GL_APIENTRY glOrthoxOES (GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);
GL_API void GL_APIENTRY glPointParameterxvOES (GLenum pname, const GLfixed *params);
GL_API void GL_APIENTRY glPointSizexOES (GLfixed size);
GL_API void GL_APIENTRY glPolygonOffsetxOES (GLfixed factor, GLfixed units);
GL_API void GL_APIENTRY glRotatexOES (GLfixed angle, GLfixed x, GLfixed y, GLfixed z);
GL_API void GL_APIENTRY glScalexOES (GLfixed x, GLfixed y, GLfixed z);
GL_API void GL_APIENTRY glTexEnvxOES (GLenum target, GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glTexEnvxvOES (GLenum target, GLenum pname, const GLfixed *params);
GL_API void GL_APIENTRY glTexParameterxOES (GLenum target, GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glTexParameterxvOES (GLenum target, GLenum pname, const GLfixed *params);
GL_API void GL_APIENTRY glTranslatexOES (GLfixed x, GLfixed y, GLfixed z);
GL_API void GL_APIENTRY glGetLightxvOES (GLenum light, GLenum pname, GLfixed *params);
GL_API void GL_APIENTRY glGetMaterialxvOES (GLenum face, GLenum pname, GLfixed *params);
GL_API void GL_APIENTRY glPointParameterxOES (GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glSampleCoveragexOES (GLclampx value, GLboolean invert);
GL_API void GL_APIENTRY glGetTexGenxvOES (GLenum coord, GLenum pname, GLfixed *params);
GL_API void GL_APIENTRY glTexGenxOES (GLenum coord, GLenum pname, GLfixed param);
GL_API void GL_APIENTRY glTexGenxvOES (GLenum coord, GLenum pname, const GLfixed *params);
#endif /* GL_OES_fixed_point */

#ifndef GL_OES_framebuffer_object
#define GL_OES_framebuffer_object 1
#define GL_NONE_OES                       0
#define GL_FRAMEBUFFER_OES                0x8D40
#define GL_RENDERBUFFER_OES               0x8D41
#define GL_RGBA4_OES                      0x8056
#define GL_RGB5_A1_OES                    0x8057
#define GL_RGB565_OES                     0x8D62
#define GL_DEPTH_COMPONENT16_OES          0x81A5
#define GL_RENDERBUFFER_WIDTH_OES         0x8D42
#define GL_RENDERBUFFER_HEIGHT_OES        0x8D43
#define GL_RENDERBUFFER_INTERNAL_FORMAT_OES 0x8D44
#define GL_RENDERBUFFER_RED_SIZE_OES      0x8D50
#define GL_RENDERBUFFER_GREEN_SIZE_OES    0x8D51
#define GL_RENDERBUFFER_BLUE_SIZE_OES     0x8D52
#define GL_RENDERBUFFER_ALPHA_SIZE_OES    0x8D53
#define GL_RENDERBUFFER_DEPTH_SIZE_OES    0x8D54
#define GL_RENDERBUFFER_STENCIL_SIZE_OES  0x8D55
#define GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES 0x8CD0
#define GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES 0x8CD1
#define GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES 0x8CD2
#define GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES 0x8CD3
#define GL_COLOR_ATTACHMENT0_OES          0x8CE0
#define GL_DEPTH_ATTACHMENT_OES           0x8D00
#define GL_STENCIL_ATTACHMENT_OES         0x8D20
#define GL_FRAMEBUFFER_COMPLETE_OES       0x8CD5
#define GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES 0x8CD6
#define GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES 0x8CD7
#define GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES 0x8CD9
#define GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES 0x8CDA
#define GL_FRAMEBUFFER_UNSUPPORTED_OES    0x8CDD
#define GL_FRAMEBUFFER_BINDING_OES        0x8CA6
#define GL_RENDERBUFFER_BINDING_OES       0x8CA7
#define GL_MAX_RENDERBUFFER_SIZE_OES      0x84E8
#define GL_INVALID_FRAMEBUFFER_OPERATION_OES 0x0506
GL_API GLboolean GL_APIENTRY glIsRenderbufferOES (GLuint renderbuffer);
GL_API void GL_APIENTRY glBindRenderbufferOES (GLenum target, GLuint renderbuffer);
GL_API void GL_APIENTRY glDeleteRenderbuffersOES (GLsizei n, const GLuint *renderbuffers);
GL_API void GL_APIENTRY glGenRenderbuffersOES (GLsizei n, GLuint *renderbuffers);
GL_API void GL_APIENTRY glRenderbufferStorageOES (GLenum target, GLenum internalformat, GLsizei width, GLsizei height);
GL_API void GL_APIENTRY glGetRenderbufferParameterivOES (GLenum target, GLenum pname, GLint *params);
GL_API GLboolean GL_APIENTRY glIsFramebufferOES (GLuint framebuffer);
GL_API void GL_APIENTRY glBindFramebufferOES (GLenum target, GLuint framebuffer);
GL_API void GL_APIENTRY glDeleteFramebuffersOES (GLsizei n, const GLuint *framebuffers);
GL_API void GL_APIENTRY glGenFramebuffersOES (GLsizei n, GLuint *framebuffers);
GL_API GLenum GL_APIENTRY glCheckFramebufferStatusOES (GLenum target);
GL_API void GL_APIENTRY glFramebufferRenderbufferOES (GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
GL_API void GL_APIENTRY glFramebufferTexture2DOES (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
GL_API void GL_APIENTRY glGetFramebufferAttachmentParameterivOES (GLenum target, GLenum attachment, GLenum pname, GLint *params);
GL_API void GL_APIENTRY glGenerateMipmapOES (GLenum target);
#endif /* GL_OES_framebuffer_object */

#ifndef GL_OES_mapbuffer
#define GL_OES_mapbuffer 1
#define GL_WRITE_ONLY_OES                 0x88B9
#define GL_BUFFER_ACCESS_OES              0x88BB
#define GL_BUFFER_MAPPED_OES              0x88BC
#define GL_BUFFER_MAP_POINTER_OES         0x88BD
GL_API void *GL_APIENTRY glMapBufferOES (GLenum target, GLenum access);
GL_API GLboolean GL_APIENTRY glUnmapBufferOES (GLenum target);
GL_API void GL_APIENTRY glGetBufferPointervOES (GLenum target, GLenum pname, void **params);
#endif /* GL_OES_mapbuffer */

#ifndef GL_OES_matrix_get
#define GL_OES_matrix_get 1
#define GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES 0x898D
#define GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES 0x898E
#define GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES 0x898F
#endif /* GL_OES_matrix_get */

#ifndef GL_OES_matrix_palette
#define GL_OES_matrix_palette 1
#define GL_MAX_VERTEX_UNITS_OES           0x86A4
#define GL_MAX_PALETTE_MATRICES_OES       0x8842
#define GL_MATRIX_PALETTE_OES             0x8840
#define GL_MATRIX_INDEX_ARRAY_OES         0x8844
#define GL_WEIGHT_ARRAY_OES               0x86AD
#define GL_CURRENT_PALETTE_MATRIX_OES     0x8843
#define GL_MATRIX_INDEX_ARRAY_SIZE_OES    0x8846
#define GL_MATRIX_INDEX_ARRAY_TYPE_OES    0x8847
#define GL_MATRIX_INDEX_ARRAY_STRIDE_OES  0x8848
#define GL_MATRIX_INDEX_ARRAY_POINTER_OES 0x8849
#define GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES 0x8B9E
#define GL_WEIGHT_ARRAY_SIZE_OES          0x86AB
#define GL_WEIGHT_ARRAY_TYPE_OES          0x86A9
#define GL_WEIGHT_ARRAY_STRIDE_OES        0x86AA
#define GL_WEIGHT_ARRAY_POINTER_OES       0x86AC
#define GL_WEIGHT_ARRAY_BUFFER_BINDING_OES 0x889E
GL_API void GL_APIENTRY glCurrentPaletteMatrixOES (GLuint matrixpaletteindex);
GL_API void GL_APIENTRY glLoadPaletteFromModelViewMatrixOES (void);
GL_API void GL_APIENTRY glMatrixIndexPointerOES (GLint size, GLenum type, GLsizei stride, const void *pointer);
GL_API void GL_APIENTRY glWeightPointerOES (GLint size, GLenum type, GLsizei stride, const void *pointer);
#endif /* GL_OES_matrix_palette */

#ifndef GL_OES_packed_depth_stencil
#define GL_OES_packed_depth_stencil 1
#define GL_DEPTH_STENCIL_OES              0x84F9
#define GL_UNSIGNED_INT_24_8_OES          0x84FA
#define GL_DEPTH24_STENCIL8_OES           0x88F0
#endif /* GL_OES_packed_depth_stencil */

#ifndef GL_OES_point_size_array
#define GL_OES_point_size_array 1
#define GL_POINT_SIZE_ARRAY_OES           0x8B9C
#define GL_POINT_SIZE_ARRAY_TYPE_OES      0x898A
#define GL_POINT_SIZE_ARRAY_STRIDE_OES    0x898B
#define GL_POINT_SIZE_ARRAY_POINTER_OES   0x898C
#define GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES 0x8B9F
GL_API void GL_APIENTRY glPointSizePointerOES (GLenum type, GLsizei stride, const void *pointer);
#endif /* GL_OES_point_size_array */

#ifndef GL_OES_point_sprite
#define GL_OES_point_sprite 1
#define GL_POINT_SPRITE_OES               0x8861
#define GL_COORD_REPLACE_OES              0x8862
#endif /* GL_OES_point_sprite */

#ifndef GL_OES_query_matrix
#define GL_OES_query_matrix 1
GL_API GLbitfield GL_APIENTRY glQueryMatrixxOES (GLfixed *mantissa, GLint *exponent);
#endif /* GL_OES_query_matrix */

#ifndef GL_OES_read_format
#define GL_OES_read_format 1
#define GL_IMPLEMENTATION_COLOR_READ_TYPE_OES 0x8B9A
#define GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES 0x8B9B
#endif /* GL_OES_read_format */

#ifndef GL_OES_required_internalformat
#define GL_OES_required_internalformat 1
#define GL_ALPHA8_OES                     0x803C
#define GL_LUMINANCE4_ALPHA4_OES          0x8043
#define GL_LUMINANCE8_ALPHA8_OES          0x8045
#define GL_LUMINANCE8_OES                 0x8040
#define GL_RGB8_OES                       0x8051
#define GL_RGBA8_OES                      0x8058
#define GL_RGB10_EXT                      0x8052
#define GL_RGB10_A2_EXT                   0x8059
#endif /* GL_OES_required_internalformat */

#ifndef GL_OES_rgb8_rgba8
#define GL_OES_rgb8_rgba8 1
#endif /* GL_OES_rgb8_rgba8 */

#ifndef GL_OES_single_precision
#define GL_OES_single_precision 1
GL_API void GL_APIENTRY glClearDepthfOES (GLclampf depth);
GL_API void GL_APIENTRY glClipPlanefOES (GLenum plane, const GLfloat *equation);
GL_API void GL_APIENTRY glDepthRangefOES (GLclampf n, GLclampf f);
GL_API void GL_APIENTRY glFrustumfOES (GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);
GL_API void GL_APIENTRY glGetClipPlanefOES (GLenum plane, GLfloat *equation);
GL_API void GL_APIENTRY glOrthofOES (GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);
#endif /* GL_OES_single_precision */

#ifndef GL_OES_stencil1
#define GL_OES_stencil1 1
#define GL_STENCIL_INDEX1_OES             0x8D46
#endif /* GL_OES_stencil1 */

#ifndef GL_OES_stencil4
#define GL_OES_stencil4 1
#define GL_STENCIL_INDEX4_OES             0x8D47
#endif /* GL_OES_stencil4 */

#ifndef GL_OES_stencil8
#define GL_OES_stencil8 1
#define GL_STENCIL_INDEX8_OES             0x8D48
#endif /* GL_OES_stencil8 */

#ifndef GL_OES_stencil_wrap
#define GL_OES_stencil_wrap 1
#define GL_INCR_WRAP_OES                  0x8507
#define GL_DECR_WRAP_OES                  0x8508
#endif /* GL_OES_stencil_wrap */

#ifndef GL_OES_surfaceless_context
#define GL_OES_surfaceless_context 1
#define GL_FRAMEBUFFER_UNDEFINED_OES      0x8219
#endif /* GL_OES_surfaceless_context */

#ifndef GL_OES_texture_cube_map
#define GL_OES_texture_cube_map 1
#define GL_NORMAL_MAP_OES                 0x8511
#define GL_REFLECTION_MAP_OES             0x8512
#define GL_TEXTURE_CUBE_MAP_OES           0x8513
#define GL_TEXTURE_BINDING_CUBE_MAP_OES   0x8514
#define GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES 0x8515
#define GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES 0x8516
#define GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES 0x8517
#define GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES 0x8518
#define GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES 0x8519
#define GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES 0x851A
#define GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES  0x851C
#define GL_TEXTURE_GEN_MODE_OES           0x2500
#define GL_TEXTURE_GEN_STR_OES            0x8D60
GL_API void GL_APIENTRY glTexGenfOES (GLenum coord, GLenum pname, GLfloat param);
GL_API void GL_APIENTRY glTexGenfvOES (GLenum coord, GLenum pname, const GLfloat *params);
GL_API void GL_APIENTRY glTexGeniOES (GLenum coord, GLenum pname, GLint param);
GL_API void GL_APIENTRY glTexGenivOES (GLenum coord, GLenum pname, const GLint *params);
GL_API void GL_APIENTRY glGetTexGenfvOES (GLenum coord, GLenum pname, GLfloat *params);
GL_API void GL_APIENTRY glGetTexGenivOES (GLenum coord, GLenum pname, GLint *params);
#endif /* GL_OES_texture_cube_map */

#ifndef GL_OES_texture_env_crossbar
#define GL_OES_texture_env_crossbar 1
#endif /* GL_OES_texture_env_crossbar */

#ifndef GL_OES_texture_mirrored_repeat
#define GL_OES_texture_mirrored_repeat 1
#define GL_MIRRORED_REPEAT_OES            0x8370
#endif /* GL_OES_texture_mirrored_repeat */

#ifndef GL_OES_texture_npot
#define GL_OES_texture_npot 1
#endif /* GL_OES_texture_npot */

#ifndef GL_OES_vertex_array_object
#define GL_OES_vertex_array_object 1
#define GL_VERTEX_ARRAY_BINDING_OES       0x85B5
GL_API void GL_APIENTRY glBindVertexArrayOES (GLuint array);
GL_API void GL_APIENTRY glDeleteVertexArraysOES (GLsizei n, const GLuint *arrays);
GL_API void GL_APIENTRY glGenVertexArraysOES (GLsizei n, GLuint *arrays);
GL_API GLboolean GL_APIENTRY glIsVertexArrayOES (GLuint array);
#endif /* GL_OES_vertex_array_object */

#ifndef GL_AMD_compressed_3DC_texture
#define GL_AMD_compressed_3DC_texture 1
#define GL_3DC_X_AMD                      0x87F9
#define GL_3DC_XY_AMD                     0x87FA
#endif /* GL_AMD_compressed_3DC_texture */

#ifndef GL_AMD_compressed_ATC_texture
#define GL_AMD_compressed_ATC_texture 1
#define GL_ATC_RGB_AMD                    0x8C92
#define GL_ATC_RGBA_EXPLICIT_ALPHA_AMD    0x8C93
#define GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD 0x87EE
#endif /* GL_AMD_compressed_ATC_texture */

#ifndef GL_APPLE_copy_texture_levels
#define GL_APPLE_copy_texture_levels 1
GL_API void GL_APIENTRY glCopyTextureLevelsAPPLE (GLuint destinationTexture, GLuint sourceTexture, GLint sourceBaseLevel, GLsizei sourceLevelCount);
#endif /* GL_APPLE_copy_texture_levels */

#ifndef GL_APPLE_framebuffer_multisample
#define GL_APPLE_framebuffer_multisample 1
#define GL_RENDERBUFFER_SAMPLES_APPLE     0x8CAB
#define GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE 0x8D56
#define GL_MAX_SAMPLES_APPLE              0x8D57
#define GL_READ_FRAMEBUFFER_APPLE         0x8CA8
#define GL_DRAW_FRAMEBUFFER_APPLE         0x8CA9
#define GL_DRAW_FRAMEBUFFER_BINDING_APPLE 0x8CA6
#define GL_READ_FRAMEBUFFER_BINDING_APPLE 0x8CAA
GL_API void GL_APIENTRY glRenderbufferStorageMultisampleAPPLE (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
GL_API void GL_APIENTRY glResolveMultisampleFramebufferAPPLE (void);
#endif /* GL_APPLE_framebuffer_multisample */

#ifndef GL_APPLE_sync
#define GL_APPLE_sync 1
typedef struct __GLsync *GLsync;
typedef khronos_uint64_t GLuint64;
typedef khronos_int64_t GLint64;
#define GL_SYNC_OBJECT_APPLE              0x8A53
#define GL_MAX_SERVER_WAIT_TIMEOUT_APPLE  0x9111
#define GL_OBJECT_TYPE_APPLE              0x9112
#define GL_SYNC_CONDITION_APPLE           0x9113
#define GL_SYNC_STATUS_APPLE              0x9114
#define GL_SYNC_FLAGS_APPLE               0x9115
#define GL_SYNC_FENCE_APPLE               0x9116
#define GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE 0x9117
#define GL_UNSIGNALED_APPLE               0x9118
#define GL_SIGNALED_APPLE                 0x9119
#define GL_ALREADY_SIGNALED_APPLE         0x911A
#define GL_TIMEOUT_EXPIRED_APPLE          0x911B
#define GL_CONDITION_SATISFIED_APPLE      0x911C
#define GL_WAIT_FAILED_APPLE              0x911D
#define GL_SYNC_FLUSH_COMMANDS_BIT_APPLE  0x00000001
#define GL_TIMEOUT_IGNORED_APPLE          0xFFFFFFFFFFFFFFFFull
GL_API GLsync GL_APIENTRY glFenceSyncAPPLE (GLenum condition, GLbitfield flags);
GL_API GLboolean GL_APIENTRY glIsSyncAPPLE (GLsync sync);
GL_API void GL_APIENTRY glDeleteSyncAPPLE (GLsync sync);
GL_API GLenum GL_APIENTRY glClientWaitSyncAPPLE (GLsync sync, GLbitfield flags, GLuint64 timeout);
GL_API void GL_APIENTRY glWaitSyncAPPLE (GLsync sync, GLbitfield flags, GLuint64 timeout);
GL_API void GL_APIENTRY glGetInteger64vAPPLE (GLenum pname, GLint64 *params);
GL_API void GL_APIENTRY glGetSyncivAPPLE (GLsync sync, GLenum pname, GLsizei count, GLsizei *length, GLint *values);
#endif /* GL_APPLE_sync */

#ifndef GL_APPLE_texture_2D_limited_npot
#define GL_APPLE_texture_2D_limited_npot 1
#endif /* GL_APPLE_texture_2D_limited_npot */

#ifndef GL_APPLE_texture_format_BGRA8888
#define GL_APPLE_texture_format_BGRA8888 1
#define GL_BGRA_EXT                       0x80E1
#define GL_BGRA8_EXT                      0x93A1
#endif /* GL_APPLE_texture_format_BGRA8888 */

#ifndef GL_APPLE_texture_max_level
#define GL_APPLE_texture_max_level 1
#define GL_TEXTURE_MAX_LEVEL_APPLE        0x813D
#endif /* GL_APPLE_texture_max_level */

#ifndef GL_ARM_rgba8
#define GL_ARM_rgba8 1
#endif /* GL_ARM_rgba8 */

#ifndef GL_EXT_blend_minmax
#define GL_EXT_blend_minmax 1
#define GL_MIN_EXT                        0x8007
#define GL_MAX_EXT                        0x8008
#endif /* GL_EXT_blend_minmax */

#ifndef GL_EXT_debug_marker
#define GL_EXT_debug_marker 1
typedef char GLchar;
GL_API void GL_APIENTRY glInsertEventMarkerEXT (GLsizei length, const GLchar *marker);
GL_API void GL_APIENTRY glPushGroupMarkerEXT (GLsizei length, const GLchar *marker);
GL_API void GL_APIENTRY glPopGroupMarkerEXT (void);
#endif /* GL_EXT_debug_marker */

#ifndef GL_EXT_discard_framebuffer
#define GL_EXT_discard_framebuffer 1
#define GL_COLOR_EXT                      0x1800
#define GL_DEPTH_EXT                      0x1801
#define GL_STENCIL_EXT                    0x1802
GL_API void GL_APIENTRY glDiscardFramebufferEXT (GLenum target, GLsizei numAttachments, const GLenum *attachments);
#endif /* GL_EXT_discard_framebuffer */

#ifndef GL_EXT_map_buffer_range
#define GL_EXT_map_buffer_range 1
#define GL_MAP_READ_BIT_EXT               0x0001
#define GL_MAP_WRITE_BIT_EXT              0x0002
#define GL_MAP_INVALIDATE_RANGE_BIT_EXT   0x0004
#define GL_MAP_INVALIDATE_BUFFER_BIT_EXT  0x0008
#define GL_MAP_FLUSH_EXPLICIT_BIT_EXT     0x0010
#define GL_MAP_UNSYNCHRONIZED_BIT_EXT     0x0020
GL_API void *GL_APIENTRY glMapBufferRangeEXT (GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access);
GL_API void GL_APIENTRY glFlushMappedBufferRangeEXT (GLenum target, GLintptr offset, GLsizeiptr length);
#endif /* GL_EXT_map_buffer_range */

#ifndef GL_EXT_multi_draw_arrays
#define GL_EXT_multi_draw_arrays 1
GL_API void GL_APIENTRY glMultiDrawArraysEXT (GLenum mode, const GLint *first, const GLsizei *count, GLsizei primcount);
GL_API void GL_APIENTRY glMultiDrawElementsEXT (GLenum mode, const GLsizei *count, GLenum type, const void *const*indices, GLsizei primcount);
#endif /* GL_EXT_multi_draw_arrays */

#ifndef GL_EXT_multisampled_render_to_texture
#define GL_EXT_multisampled_render_to_texture 1
#define GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT 0x8D6C
#define GL_RENDERBUFFER_SAMPLES_EXT       0x8CAB
#define GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT 0x8D56
#define GL_MAX_SAMPLES_EXT                0x8D57
GL_API void GL_APIENTRY glRenderbufferStorageMultisampleEXT (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
GL_API void GL_APIENTRY glFramebufferTexture2DMultisampleEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLsizei samples);
#endif /* GL_EXT_multisampled_render_to_texture */

#ifndef GL_EXT_read_format_bgra
#define GL_EXT_read_format_bgra 1
#define GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT 0x8365
#define GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT 0x8366
#endif /* GL_EXT_read_format_bgra */

#ifndef GL_EXT_robustness
#define GL_EXT_robustness 1
#define GL_GUILTY_CONTEXT_RESET_EXT       0x8253
#define GL_INNOCENT_CONTEXT_RESET_EXT     0x8254
#define GL_UNKNOWN_CONTEXT_RESET_EXT      0x8255
#define GL_CONTEXT_ROBUST_ACCESS_EXT      0x90F3
#define GL_RESET_NOTIFICATION_STRATEGY_EXT 0x8256
#define GL_LOSE_CONTEXT_ON_RESET_EXT      0x8252
#define GL_NO_RESET_NOTIFICATION_EXT      0x8261
GL_API GLenum GL_APIENTRY glGetGraphicsResetStatusEXT (void);
GL_API void GL_APIENTRY glReadnPixelsEXT (GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void *data);
GL_API void GL_APIENTRY glGetnUniformfvEXT (GLuint program, GLint location, GLsizei bufSize, GLfloat *params);
GL_API void GL_APIENTRY glGetnUniformivEXT (GLuint program, GLint location, GLsizei bufSize, GLint *params);
#endif /* GL_EXT_robustness */

#ifndef GL_EXT_sRGB
#define GL_EXT_sRGB 1
#define GL_SRGB_EXT                       0x8C40
#define GL_SRGB_ALPHA_EXT                 0x8C42
#define GL_SRGB8_ALPHA8_EXT               0x8C43
#define GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT 0x8210
#endif /* GL_EXT_sRGB */

#ifndef GL_EXT_texture_compression_dxt1
#define GL_EXT_texture_compression_dxt1 1
#define GL_COMPRESSED_RGB_S3TC_DXT1_EXT   0x83F0
#define GL_COMPRESSED_RGBA_S3TC_DXT1_EXT  0x83F1
#endif /* GL_EXT_texture_compression_dxt1 */

#ifndef GL_EXT_texture_filter_anisotropic
#define GL_EXT_texture_filter_anisotropic 1
#define GL_TEXTURE_MAX_ANISOTROPY_EXT     0x84FE
#define GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT 0x84FF
#endif /* GL_EXT_texture_filter_anisotropic */

#ifndef GL_EXT_texture_format_BGRA8888
#define GL_EXT_texture_format_BGRA8888 1
#endif /* GL_EXT_texture_format_BGRA8888 */

#ifndef GL_EXT_texture_lod_bias
#define GL_EXT_texture_lod_bias 1
#define GL_MAX_TEXTURE_LOD_BIAS_EXT       0x84FD
#define GL_TEXTURE_FILTER_CONTROL_EXT     0x8500
#define GL_TEXTURE_LOD_BIAS_EXT           0x8501
#endif /* GL_EXT_texture_lod_bias */

#ifndef GL_EXT_texture_storage
#define GL_EXT_texture_storage 1
#define GL_TEXTURE_IMMUTABLE_FORMAT_EXT   0x912F
#define GL_ALPHA8_EXT                     0x803C
#define GL_LUMINANCE8_EXT                 0x8040
#define GL_LUMINANCE8_ALPHA8_EXT          0x8045
#define GL_RGBA32F_EXT                    0x8814
#define GL_RGB32F_EXT                     0x8815
#define GL_ALPHA32F_EXT                   0x8816
#define GL_LUMINANCE32F_EXT               0x8818
#define GL_LUMINANCE_ALPHA32F_EXT         0x8819
#define GL_RGBA16F_EXT                    0x881A
#define GL_RGB16F_EXT                     0x881B
#define GL_ALPHA16F_EXT                   0x881C
#define GL_LUMINANCE16F_EXT               0x881E
#define GL_LUMINANCE_ALPHA16F_EXT         0x881F
#define GL_R8_EXT                         0x8229
#define GL_RG8_EXT                        0x822B
#define GL_R32F_EXT                       0x822E
#define GL_RG32F_EXT                      0x8230
#define GL_R16F_EXT                       0x822D
#define GL_RG16F_EXT                      0x822F
GL_API void GL_APIENTRY glTexStorage1DEXT (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);
GL_API void GL_APIENTRY glTexStorage2DEXT (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
GL_API void GL_APIENTRY glTexStorage3DEXT (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
GL_API void GL_APIENTRY glTextureStorage1DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);
GL_API void GL_APIENTRY glTextureStorage2DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
GL_API void GL_APIENTRY glTextureStorage3DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
#endif /* GL_EXT_texture_storage */

#ifndef GL_IMG_multisampled_render_to_texture
#define GL_IMG_multisampled_render_to_texture 1
#define GL_RENDERBUFFER_SAMPLES_IMG       0x9133
#define GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG 0x9134
#define GL_MAX_SAMPLES_IMG                0x9135
#define GL_TEXTURE_SAMPLES_IMG            0x9136
GL_API void GL_APIENTRY glRenderbufferStorageMultisampleIMG (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
GL_API void GL_APIENTRY glFramebufferTexture2DMultisampleIMG (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLsizei samples);
#endif /* GL_IMG_multisampled_render_to_texture */

#ifndef GL_IMG_read_format
#define GL_IMG_read_format 1
#define GL_BGRA_IMG                       0x80E1
#define GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG 0x8365
#endif /* GL_IMG_read_format */

#ifndef GL_IMG_texture_compression_pvrtc
#define GL_IMG_texture_compression_pvrtc 1
#define GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG 0x8C00
#define GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG 0x8C01
#define GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG 0x8C02
#define GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG 0x8C03
#endif /* GL_IMG_texture_compression_pvrtc */

#ifndef GL_IMG_texture_env_enhanced_fixed_function
#define GL_IMG_texture_env_enhanced_fixed_function 1
#define GL_MODULATE_COLOR_IMG             0x8C04
#define GL_RECIP_ADD_SIGNED_ALPHA_IMG     0x8C05
#define GL_TEXTURE_ALPHA_MODULATE_IMG     0x8C06
#define GL_FACTOR_ALPHA_MODULATE_IMG      0x8C07
#define GL_FRAGMENT_ALPHA_MODULATE_IMG    0x8C08
#define GL_ADD_BLEND_IMG                  0x8C09
#define GL_DOT3_RGBA_IMG                  0x86AF
#endif /* GL_IMG_texture_env_enhanced_fixed_function */

#ifndef GL_IMG_user_clip_plane
#define GL_IMG_user_clip_plane 1
#define GL_CLIP_PLANE0_IMG                0x3000
#define GL_CLIP_PLANE1_IMG                0x3001
#define GL_CLIP_PLANE2_IMG                0x3002
#define GL_CLIP_PLANE3_IMG                0x3003
#define GL_CLIP_PLANE4_IMG                0x3004
#define GL_CLIP_PLANE5_IMG                0x3005
#define GL_MAX_CLIP_PLANES_IMG            0x0D32
GL_API void GL_APIENTRY glClipPlanefIMG (GLenum p, const GLfloat *eqn);
GL_API void GL_APIENTRY glClipPlanexIMG (GLenum p, const GLfixed *eqn);
#endif /* GL_IMG_user_clip_plane */

#ifndef GL_NV_fence
#define GL_NV_fence 1
#define GL_ALL_COMPLETED_NV               0x84F2
#define GL_FENCE_STATUS_NV                0x84F3
#define GL_FENCE_CONDITION_NV             0x84F4
GL_API void GL_APIENTRY glDeleteFencesNV (GLsizei n, const GLuint *fences);
GL_API void GL_APIENTRY glGenFencesNV (GLsizei n, GLuint *fences);
GL_API GLboolean GL_APIENTRY glIsFenceNV (GLuint fence);
GL_API GLboolean GL_APIENTRY glTestFenceNV (GLuint fence);
GL_API void GL_APIENTRY glGetFenceivNV (GLuint fence, GLenum pname, GLint *params);
GL_API void GL_APIENTRY glFinishFenceNV (GLuint fence);
GL_API void GL_APIENTRY glSetFenceNV (GLuint fence, GLenum condition);
#endif /* GL_NV_fence */

#ifndef GL_QCOM_driver_control
#define GL_QCOM_driver_control 1
GL_API void GL_APIENTRY glGetDriverControlsQCOM (GLint *num, GLsizei size, GLuint *driverControls);
GL_API void GL_APIENTRY glGetDriverControlStringQCOM (GLuint driverControl, GLsizei bufSize, GLsizei *length, GLchar *driverControlString);
GL_API void GL_APIENTRY glEnableDriverControlQCOM (GLuint driverControl);
GL_API void GL_APIENTRY glDisableDriverControlQCOM (GLuint driverControl);
#endif /* GL_QCOM_driver_control */

#ifndef GL_QCOM_extended_get
#define GL_QCOM_extended_get 1
#define GL_TEXTURE_WIDTH_QCOM             0x8BD2
#define GL_TEXTURE_HEIGHT_QCOM            0x8BD3
#define GL_TEXTURE_DEPTH_QCOM             0x8BD4
#define GL_TEXTURE_INTERNAL_FORMAT_QCOM   0x8BD5
#define GL_TEXTURE_FORMAT_QCOM            0x8BD6
#define GL_TEXTURE_TYPE_QCOM              0x8BD7
#define GL_TEXTURE_IMAGE_VALID_QCOM       0x8BD8
#define GL_TEXTURE_NUM_LEVELS_QCOM        0x8BD9
#define GL_TEXTURE_TARGET_QCOM            0x8BDA
#define GL_TEXTURE_OBJECT_VALID_QCOM      0x8BDB
#define GL_STATE_RESTORE                  0x8BDC
GL_API void GL_APIENTRY glExtGetTexturesQCOM (GLuint *textures, GLint maxTextures, GLint *numTextures);
GL_API void GL_APIENTRY glExtGetBuffersQCOM (GLuint *buffers, GLint maxBuffers, GLint *numBuffers);
GL_API void GL_APIENTRY glExtGetRenderbuffersQCOM (GLuint *renderbuffers, GLint maxRenderbuffers, GLint *numRenderbuffers);
GL_API void GL_APIENTRY glExtGetFramebuffersQCOM (GLuint *framebuffers, GLint maxFramebuffers, GLint *numFramebuffers);
GL_API void GL_APIENTRY glExtGetTexLevelParameterivQCOM (GLuint texture, GLenum face, GLint level, GLenum pname, GLint *params);
GL_API void GL_APIENTRY glExtTexObjectStateOverrideiQCOM (GLenum target, GLenum pname, GLint param);
GL_API void GL_APIENTRY glExtGetTexSubImageQCOM (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void *texels);
GL_API void GL_APIENTRY glExtGetBufferPointervQCOM (GLenum target, void **params);
#endif /* GL_QCOM_extended_get */

#ifndef GL_QCOM_extended_get2
#define GL_QCOM_extended_get2 1
GL_API void GL_APIENTRY glExtGetShadersQCOM (GLuint *shaders, GLint maxShaders, GLint *numShaders);
GL_API void GL_APIENTRY glExtGetProgramsQCOM (GLuint *programs, GLint maxPrograms, GLint *numPrograms);
GL_API GLboolean GL_APIENTRY glExtIsProgramBinaryQCOM (GLuint program);
GL_API void GL_APIENTRY glExtGetProgramBinarySourceQCOM (GLuint program, GLenum shadertype, GLchar *source, GLint *length);
#endif /* GL_QCOM_extended_get2 */

#ifndef GL_QCOM_perfmon_global_mode
#define GL_QCOM_perfmon_global_mode 1
#define GL_PERFMON_GLOBAL_MODE_QCOM       0x8FA0
#endif /* GL_QCOM_perfmon_global_mode */

#ifndef GL_QCOM_tiled_rendering
#define GL_QCOM_tiled_rendering 1
#define GL_COLOR_BUFFER_BIT0_QCOM         0x00000001
#define GL_COLOR_BUFFER_BIT1_QCOM         0x00000002
#define GL_COLOR_BUFFER_BIT2_QCOM         0x00000004
#define GL_COLOR_BUFFER_BIT3_QCOM         0x00000008
#define GL_COLOR_BUFFER_BIT4_QCOM         0x00000010
#define GL_COLOR_BUFFER_BIT5_QCOM         0x00000020
#define GL_COLOR_BUFFER_BIT6_QCOM         0x00000040
#define GL_COLOR_BUFFER_BIT7_QCOM         0x00000080
#define GL_DEPTH_BUFFER_BIT0_QCOM         0x00000100
#define GL_DEPTH_BUFFER_BIT1_QCOM         0x00000200
#define GL_DEPTH_BUFFER_BIT2_QCOM         0x00000400
#define GL_DEPTH_BUFFER_BIT3_QCOM         0x00000800
#define GL_DEPTH_BUFFER_BIT4_QCOM         0x00001000
#define GL_DEPTH_BUFFER_BIT5_QCOM         0x00002000
#define GL_DEPTH_BUFFER_BIT6_QCOM         0x00004000
#define GL_DEPTH_BUFFER_BIT7_QCOM         0x00008000
#define GL_STENCIL_BUFFER_BIT0_QCOM       0x00010000
#define GL_STENCIL_BUFFER_BIT1_QCOM       0x00020000
#define GL_STENCIL_BUFFER_BIT2_QCOM       0x00040000
#define GL_STENCIL_BUFFER_BIT3_QCOM       0x00080000
#define GL_STENCIL_BUFFER_BIT4_QCOM       0x00100000
#define GL_STENCIL_BUFFER_BIT5_QCOM       0x00200000
#define GL_STENCIL_BUFFER_BIT6_QCOM       0x00400000
#define GL_STENCIL_BUFFER_BIT7_QCOM       0x00800000
#define GL_MULTISAMPLE_BUFFER_BIT0_QCOM   0x01000000
#define GL_MULTISAMPLE_BUFFER_BIT1_QCOM   0x02000000
#define GL_MULTISAMPLE_BUFFER_BIT2_QCOM   0x04000000
#define GL_MULTISAMPLE_BUFFER_BIT3_QCOM   0x08000000
#define GL_MULTISAMPLE_BUFFER_BIT4_QCOM   0x10000000
#define GL_MULTISAMPLE_BUFFER_BIT5_QCOM   0x20000000
#define GL_MULTISAMPLE_BUFFER_BIT6_QCOM   0x40000000
#define GL_MULTISAMPLE_BUFFER_BIT7_QCOM   0x80000000
GL_API void GL_APIENTRY glStartTilingQCOM (GLuint x, GLuint y, GLuint width, GLuint height, GLbitfield preserveMask);
GL_API void GL_APIENTRY glEndTilingQCOM (GLbitfield preserveMask);
#endif /* GL_QCOM_tiled_rendering */

#ifndef GL_QCOM_writeonly_rendering
#define GL_QCOM_writeonly_rendering 1
#define GL_WRITEONLY_RENDERING_QCOM       0x8823
#endif /* GL_QCOM_writeonly_rendering */

#ifdef __cplusplus
}
#endif

#endif
