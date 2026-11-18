# Added to address the Year 2038 problem
# https://en.wikipedia.org/wiki/Year_2038_problem
# https://lists.gnu.org/archive/html/bug-gnulib/2021-07/msg00002.html
set(ZIG_TARGET "arm-linux-gnueabihf.2.34")
set(DEBIAN_TARGET "arm-linux-gnueabihf")
include(${CMAKE_CURRENT_LIST_DIR}/zig-toolchain.cmake)
