#ifndef LIB_SILK_DROID_H
#define LIB_SILK_DROID_H

#include <android/log.h>

#define  LOG_TAG    "libsilkdroid"
#define  LOGI(...)  __android_log_print(ANDROID_LOG_INFO,LOG_TAG,__VA_ARGS__)
#define  LOGW(...)  __android_log_print(ANDROID_LOG_WARN,LOG_TAG,__VA_ARGS__)
#define  LOGE(...)  __android_log_print(ANDROID_LOG_ERROR,LOG_TAG,__VA_ARGS__)

// We're passing a function pointer to "return" to C# land here
typedef void (*SdMainFunc)();
SdMainFunc CurrentMain;

void sdSetMain(SdMainFunc main);

#endif
