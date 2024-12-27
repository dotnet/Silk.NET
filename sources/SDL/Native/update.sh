#!/usr/bin/env -S bash -eu
if [ ! -e ../../../eng/submodules/sdl/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/sdl
fi
verout="$(dirname "$(readlink -f "${BASH_SOURCE[0]}")")/version.txt"
(
    cd ../../../eng/submodules/sdl
    git fetch --tags
    IFS=' ' read -a latest <<< "$(git for-each-ref --sort=-committerdate --count=1 --contains=HEAD "refs/tags/release-3*")"
    if [[ "${latest:-}" == "" && "$(git describe --tags --exact-match)" == "preview-"* ]]; then
        IFS=' ' read -a latest <<< "$(git for-each-ref --sort=-committerdate --count=1 --contains=HEAD "refs/tags/preview-3*")"
    fi
    if [[ "${latest:-}" != "" ]]; then
        git checkout "${latest[0]}"
        ver="$(git describe --tags --exact-match)"
        if [[ "$ver" == "preview-"* ]]; then
          echo "${ver:8}-preview" > "$verout"
        else
          echo "${ver:8}" > "$verout"
        fi
    fi
)
git add ../../../eng/submodules/sdl version.txt
