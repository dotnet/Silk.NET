#ifndef ALLEGRO_AINTERN_ANDROID_H
#define ALLEGRO_AINTERN_ANDROID_H

#include <allegro5/allegro.h>
#include <allegro5/internal/aintern_system.h>
#include <allegro5/internal/aintern_display.h>
#include <allegro5/allegro_opengl.h>

#include <jni.h>

typedef struct ALLEGRO_SYSTEM_ANDROID {
   ALLEGRO_SYSTEM system;
} ALLEGRO_SYSTEM_ANDROID;

typedef struct ALLEGRO_DISPLAY_ANDROID {
   ALLEGRO_DISPLAY display;
   jobject surface_object;

   ALLEGRO_COND *cond;
   ALLEGRO_MUTEX *mutex;

   bool created;
   bool recreate;
   bool first_run;
   bool resize_acknowledge;
   bool resize_acknowledge2;
   bool resumed;
   bool failed;
   bool is_destroy_display;
} ALLEGRO_DISPLAY_ANDROID;

ALLEGRO_SYSTEM_INTERFACE *_al_system_android_interface(void);
const ALLEGRO_FILE_INTERFACE *_al_get_apk_file_vtable(void);

ALLEGRO_DISPLAY_INTERFACE *_al_get_android_display_driver(void);
ALLEGRO_KEYBOARD_DRIVER *_al_get_android_keyboard_driver(void);
ALLEGRO_MOUSE_DRIVER *_al_get_android_mouse_driver(void);
ALLEGRO_TOUCH_INPUT_DRIVER *_al_get_android_touch_input_driver(void);

int _al_android_get_display_orientation(void);

#define _jni_checkException(env)                                              \
   __jni_checkException(env, __FILE__, __FUNCTION__, __LINE__)

void __jni_checkException(JNIEnv *env, const char *file, const char *fname, int line);

#define _jni_call(env, rett, method, args...)                                 \
   ({                                                                         \
      rett ret = (*env)->method(env, ##args);                                 \
      _jni_checkException(env);                                               \
      ret;                                                                    \
    })

#define _jni_callv(env, method, args...)                                      \
   ({                                                                         \
      (*env)->method(env, ##args);                                            \
      _jni_checkException(env);                                               \
   })

#define _jni_callBooleanMethodV(env, obj, name, sig, args...)                 \
   ({                                                                         \
      jclass class_id = _jni_call(env, jclass, GetObjectClass, obj);          \
      jmethodID method_id = _jni_call(env, jmethodID, GetMethodID, class_id,  \
         name, sig);                                                          \
      bool ret = false;                                                       \
      if (method_id == NULL) {                                                \
         ALLEGRO_DEBUG("couldn't find method %s", name);                      \
      }                                                                       \
      else {                                                                  \
         ret = _jni_call(env, bool, CallBooleanMethod, obj, method_id,        \
            ##args);                                                          \
      }                                                                       \
      _jni_callv(env, DeleteLocalRef, class_id);                              \
      ret;                                                                    \
   })

jobject _jni_callObjectMethod(JNIEnv *env, jobject object,
         const char *name, const char *sig);
jobject _jni_callObjectMethodV(JNIEnv *env, jobject object,
         const char *name, const char *sig, ...);
ALLEGRO_USTR *_jni_getString(JNIEnv *env, jobject object);
ALLEGRO_USTR *_jni_callStringMethod(JNIEnv *env, jobject obj,
         const char *name, const char *sig);
jobject _jni_callStaticObjectMethodV(JNIEnv *env, jclass class_id,
         const char *name, const char *sig, ...);
jint _jni_callStaticIntMethodV(JNIEnv *env, jclass cls,
         const char *name, const char *sig, ...);

#define _jni_callIntMethodV(env, obj, name, sig, args...)                     \
   ({                                                                         \
      jclass class_id = _jni_call(env, jclass, GetObjectClass, obj);          \
      jmethodID method_id = _jni_call(env, jmethodID, GetMethodID, class_id,  \
         name, sig);                                                          \
      int ret = -1;                                                           \
      if (method_id == NULL) {                                                \
         ALLEGRO_DEBUG("couldn't find method %s", #name);                     \
      }                                                                       \
      else {                                                                  \
         ret = _jni_call(env, int, CallIntMethod, obj, method_id, ##args);    \
      }                                                                       \
      _jni_callv(env, DeleteLocalRef, class_id);                              \
      ret;                                                                    \
   })

#define _jni_callIntMethod(env, obj, name)                                    \
   _jni_callIntMethodV(env, obj, name, "()I")

#define _jni_callLongMethodV(env, obj, name, sig, args...)                    \
   ({                                                                         \
      jclass class_id = _jni_call(env, jclass, GetObjectClass, obj);          \
      jmethodID method_id = _jni_call(env, jmethodID, GetMethodID, class_id,  \
         name, sig);                                                          \
      long ret = -1;                                                          \
      if (method_id == NULL) {                                                \
         ALLEGRO_DEBUG("couldn't find method %s", name);                      \
      }                                                                       \
      else {                                                                  \
         ret = _jni_call(env, long, CallLongMethod, obj, method_id, ##args);  \
      }                                                                       \
      _jni_callv(env, DeleteLocalRef, class_id);                              \
      ret;                                                                    \
   })

#define _jni_callLongMethod(env, obj, name)                                   \
      _jni_callLongMethodV(env, obj, name, "()J");

#define _jni_callVoidMethodV(env, obj, name, sig, args...)                    \
   ({                                                                         \
      jclass class_id = _jni_call(env, jclass, GetObjectClass, obj);          \
      jmethodID method_id = _jni_call(env, jmethodID, GetMethodID, class_id,  \
         name, sig);                                                          \
      if (method_id == NULL) {                                                \
         ALLEGRO_ERROR("couldn't find method %s", name);                      \
      } else {                                                                \
         _jni_callv(env, CallVoidMethod, obj, method_id, ##args);             \
      }                                                                       \
      _jni_callv(env, DeleteLocalRef, class_id);                              \
   })

#define _jni_callVoidMethod(env, obj, name)                                   \
   _jni_callVoidMethodV(env, obj, name, "()V");

AL_VAR(struct ALLEGRO_JOYSTICK_DRIVER, _al_android_joystick_driver);

void _al_android_create_surface(JNIEnv *env, bool post);
void _al_android_destroy_surface(JNIEnv *env, jobject obj, bool post);

ALLEGRO_BITMAP *_al_android_load_image_f(ALLEGRO_FILE *fh, int flags);
ALLEGRO_BITMAP *_al_android_load_image(const char *filename, int flags);

jobject _al_android_activity_object(void);
jclass _al_android_input_stream_class(void);
jclass _al_android_apk_stream_class(void);
jclass _al_android_image_loader_class(void);
jclass _al_android_clipboard_class(void);
jclass _al_android_apk_fs_class(void);

void _al_android_generate_mouse_event(unsigned int type, int x, int y,
   unsigned int button, ALLEGRO_DISPLAY *d);
void _al_android_mouse_get_state(ALLEGRO_MOUSE_STATE *ret_state);

void _al_android_generate_accelerometer_event(float x, float y, float z);
void _al_android_generate_joystick_axis_event(int index, int stick, int axis, float value);
void _al_android_generate_joystick_button_event(int index, int button, bool down);

GLint _al_android_get_curr_fbo(void);
void _al_android_set_curr_fbo(GLint fbo);
bool _al_android_is_os_2_1(void);
void _al_android_thread_created(void);
void _al_android_thread_ended(void);

void _al_android_set_jnienv(JNIEnv *jnienv);
JNIEnv *_al_android_get_jnienv(void);
bool _al_android_is_paused(void);

void _al_android_add_clipboard_functions(ALLEGRO_DISPLAY_INTERFACE *vt);

#define ALLEGRO_ANDROID_PACKAGE_NAME         org_liballeg_android
#define ALLEGRO_ANDROID_PACKAGE_NAME_SLASH   "org/liballeg/android"

#define JNI_FUNC_PASTER(ret, cls, name, params, x) \
	JNIEXPORT ret JNICALL Java_ ## x ## _ ## cls ## _ ## name params
#define JNI_FUNC_EVALUATOR(ret, cls, name, params, x) \
	JNI_FUNC_PASTER(ret, cls, name, params, x)
#define JNI_FUNC(ret, cls, name, params) \
	JNI_FUNC_EVALUATOR(ret, cls, name, params, ALLEGRO_ANDROID_PACKAGE_NAME)

/* Functions called from Java code. */
extern JNI_FUNC(bool, AllegroActivity, nativeOnCreate, (JNIEnv *env, jobject obj));
extern JNI_FUNC(void, AllegroActivity, nativeOnDestroy, (JNIEnv *env, jobject obj));
extern JNI_FUNC(void, AllegroActivity, nativeOnOrientationChange, (JNIEnv *env,
         jobject obj, int orientation, bool init));
extern JNI_FUNC(void, AllegroActivity, nativeOnPause, (JNIEnv *env, jobject obj));
extern JNI_FUNC(void, AllegroActivity, nativeOnResume, (JNIEnv *env, jobject obj));
extern JNI_FUNC(void, AllegroSurface, nativeOnCreate, (JNIEnv *env, jobject obj));
extern JNI_FUNC(bool, AllegroSurface, nativeOnDestroy, (JNIEnv *env, jobject obj));
extern JNI_FUNC(void, AllegroSurface, nativeOnChange, (JNIEnv *env, jobject obj,
         jint format, jint width, jint height));
extern JNI_FUNC(int, AllegroInputStream, nativeRead, (JNIEnv *env, jobject obj,
         jlong handle, jbyteArray array, int offset, int length));
extern JNI_FUNC(void, AllegroInputStream, nativeClose, (JNIEnv *env, jobject obj,
         jlong handle));
extern JNI_FUNC(void, KeyListener, nativeOnKeyDown, (JNIEnv *env, jobject obj,
         jint scancode, jint unichar));
extern JNI_FUNC(void, KeyListener, nativeOnKeyUp, (JNIEnv *env, jobject obj,
         jint scancode));
extern JNI_FUNC(void, KeyListener, nativeOnKeyChar, (JNIEnv *env, jobject obj,
         jint scancode, jint unichar));
extern JNI_FUNC(void, TouchListener, nativeOnTouch, (JNIEnv *env, jobject obj,
         jint id, jint action, jfloat x, jfloat y, jboolean primary));
extern JNI_FUNC(void, Sensors, nativeOnAccel, (JNIEnv *env, jobject obj, jint id,
         jfloat x, jfloat y, jfloat z));

extern JNI_FUNC(void, AllegroSurface, nativeOnJoystickAxis, (JNIEnv *env, jobject obj,
         jint index, jint stick, jint axis, jfloat value));
extern JNI_FUNC(void, AllegroSurface, nativeOnJoystickButton, (JNIEnv *env, jobject obj,
         jint index, jint button, jboolean down));
extern JNI_FUNC(void, KeyListener, nativeOnJoystickButton, (JNIEnv *env, jobject obj,
         jint index, jint button, jboolean down));
extern JNI_FUNC(void, AllegroActivity, nativeSendJoystickConfigurationEvent,
         (JNIEnv *env, jobject obj));

#endif /* ALLEGRO_AINTERN_ANDROID_H */

/* vim: set sts=3 sw=3 et: */
