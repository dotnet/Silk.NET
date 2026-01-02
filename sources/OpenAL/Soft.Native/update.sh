#!/usr/bin/env -S bash -eu
if [ ! -e ../../../eng/submodules/openal-soft/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/openal-soft
fi
verout="$(dirname "$(readlink -f "${BASH_SOURCE[0]}")")/version.txt"
(
    cd ../../../eng/submodules/openal-soft
    git fetch --tags
    IFS=' ' read -a latest <<< "$(git for-each-ref --sort=-committerdate --count=1 --contains=HEAD "refs/tags/[0-9]*")"
    if [[ "${latest:-}" == "" && "$(cat "${verout}")" == *"-"* ]]; then
        git fetch origin master
        IFS=' ' read -a latest <<< "FETCH_HEAD"
    fi
    if [[ "${latest:-}" != "" ]]; then
        git checkout "${latest[0]}"
        git describe --tags --match "[0-9]*" | sed -r "s/-[0-9]+\-/-/" > "${verout}"
    fi
)
git add ../../../eng/submodules/openal-soft version.txt
