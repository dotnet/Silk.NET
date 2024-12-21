#!/usr/bin/env -S bash -eu

export NATIVE_LIBRARY_SHORTHANDS="Sdl Aaaa Sdl B"
export NATIVE_LIBRARY_PATHS="sources/SDL/Native sources/Aaaa/Native sources/SDL-Other/Native sources/B/Native"
export NATIVE_LIBRARY_SUBMODULE_PATHS="eng/submodules/sdl eng/submodules/aaaa eng/submodules/sdl-other eng/submodules/b"
export GITHUB_OUTPUT="test.txt"
export PR_COMMENT=$'Hello\n/build-native sdl aaaa\nworld'

rm -f test.txt
./workflow-stage1.sh

EXPECTED="workflow_filters<<EOF
Aaaa: [\"sources/Aaaa/Native/*\", \"eng/submodules/aaa\"]
B: [\"sources/B/Native/*\", \"eng/submodules/b\"]
Sdl: [\"sources/SDL/Native/*\", \"eng/submodules/sdl\", \"sources/SDL-Other/Native/*\", \"eng/submodules/sdl-other\"]
EOF
targets_referenced=Aaaa Sdl"

if [[ "$(cat test.txt)" == "$EXPECTED" ]]; then
    echo stage1 pass
else
    echo stage1 fail
    cat test.txt
fi

export NATIVE_LIBRARY_APPLICABLE_SHORTHANDS="Sdl Aaaa"
export NATIVE_LIBRARY_USER_REFERENCED_SHORTHANDS="Sdl"

rm -f test.txt
./workflow-stage2.sh

EXPECTED="matrix_strategy<<EOF
[
{
  \"target\": \"Sdl\",
  \"runtime\": \"osx\",
  \"exec\": \"build-osx.sh\",
  \"dir\": \"sources/SDL/Native\"
}
]
EOF
comment_to_write=Some of the native library builds modified in this PR were not referenced in the PR description. Please ensure that the PR description contains \`/build-native Sdl Aaaa\`. These libraries won't be rebuilt without this being specified. If you believe this is in error, then please write a comment explaining why and ignore this suggestion. This comment will be automatically updated if rectified."
if [[ "$(cat test.txt)" == "$EXPECTED" ]]; then
    echo stage2 with angry comment pass
else
    echo stage2 with angry comment fail
    cat test.txt
fi

export NATIVE_LIBRARY_APPLICABLE_SHORTHANDS="Sdl Aaaa"
export NATIVE_LIBRARY_USER_REFERENCED_SHORTHANDS="Sdl Aaaa"

rm -f test.txt
./workflow-stage2.sh

EXPECTED="matrix_strategy<<EOF
[
{
  \"target\": \"Sdl\",
  \"runtime\": \"osx\",
  \"exec\": \"build-osx.sh\",
  \"dir\": \"sources/SDL/Native\"
}
]
EOF"
if [[ "$(cat test.txt)" == "$EXPECTED" ]]; then
    echo stage2 with no angry comment pass
else
    echo stage2 with no angry comment fail
    cat test.txt
fi

export NATIVE_LIBRARY_APPLICABLE_SHORTHANDS="Sdl Aaaa"
export NATIVE_LIBRARY_USER_REFERENCED_SHORTHANDS="Sdl Aaaa B"

rm -f test.txt
./workflow-stage2.sh

EXPECTED="matrix_strategy<<EOF
[
{
  \"target\": \"Sdl\",
  \"runtime\": \"osx\",
  \"exec\": \"build-osx.sh\",
  \"dir\": \"sources/SDL/Native\"
}
]
EOF"
if [[ "$(cat test.txt)" == "$EXPECTED" ]]; then
    echo stage2 with no angry comment when we have extra targets pass
else
    echo stage2 with no angry comment when we have extra targets fail
    cat test.txt
fi

export NATIVE_LIBRARY_APPLICABLE_SHORTHANDS="Sdl Aaaa"
export NATIVE_LIBRARY_USER_REFERENCED_SHORTHANDS="Sdl Aaaa B"
export PR_EXISTING_NOTICE_ID=123

rm -f test.txt
./workflow-stage2.sh

EXPECTED="matrix_strategy<<EOF
[
{
  \"target\": \"Sdl\",
  \"runtime\": \"osx\",
  \"exec\": \"build-osx.sh\",
  \"dir\": \"sources/SDL/Native\"
}
]
EOF
comment_to_write=All native library builds modified in this PR shall attempt to be built by CI."
if [[ "$(cat test.txt)" == "$EXPECTED" ]]; then
    echo stage2 with updating angry comment to not be angry pass
else
    echo stage2 with updating angry comment to not be angry fail
    cat test.txt
fi
