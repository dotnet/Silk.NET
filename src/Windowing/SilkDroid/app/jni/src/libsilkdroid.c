#include "libsilkdroid.h"

#include <errno.h>
#include <math.h>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>

#include <android/log.h>

// #define SDL_MAIN_HANDLED
#include <SDL_main.h>
#include <SDL.h>

void sdSetMain(SdMainFunc main) {
    CurrentMain = main;
}

// int SDL_main(int argc, char* argv[]) {
int main(int argc, char* argv[]) {
    if (CurrentMain == NULL) {
        return -1;
    }

    CurrentMain();
    return 0;
}
