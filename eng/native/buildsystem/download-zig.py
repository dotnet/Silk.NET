#!/usr/bin/env python3

import json
import urllib.request
import os.path
import os
import shutil
import sys
import platform
import tarfile

zig_path = os.path.join(os.path.dirname(__file__), "zig")
if os.path.exists(zig_path):
    shutil.rmtree(zig_path)
os.mkdir(zig_path)
tarfile.open(
    fileobj=urllib.request.urlopen(
        json.load(urllib.request.urlopen("https://ziglang.org/download/index.json"))[
            "master"
        ][
            {
                "linux": (
                    "x86_64-linux" if platform.processor() != "arm" else "aarch64-linux"
                ),
                "linux2": (
                    "x86_64-linux" if platform.processor() != "arm" else "aarch64-linux"
                ),
                "darwin": (
                    "x86_64-macos" if platform.processor() != "arm" else "aarch64-macos"
                ),
                "win32": (
                    "x86_64-windows"
                    if platform.processor() != "arm"
                    else "aarch64-windows"
                ),
            }[sys.platform]
        ][
            "tarball"
        ]
    ),
    mode="r|xz",
).extractall(zig_path)
for x in os.scandir(next(f.path for f in os.scandir(zig_path) if f.is_dir())):
    shutil.move(x, os.path.join(zig_path, os.path.basename(x)))
