#!/usr/bin/env -S bash -eu
. workflow-common.sh

# Now we determine the jobs we actually want to run
IFS=' ' read -a NATIVE_LIBRARY_APPLICABLE_SHORTHANDS_ARRAY <<< "$NATIVE_LIBRARY_APPLICABLE_SHORTHANDS"
IFS=' ' read -a NATIVE_LIBRARY_USER_REFERENCED_SHORTHANDS_ARRAY <<< "$NATIVE_LIBRARY_USER_REFERENCED_SHORTHANDS"

COMMENT="Some of the native library builds modified in this PR were not referenced in the PR description. Please ensure that the PR description contains \`/build-native $NATIVE_LIBRARY_APPLICABLE_SHORTHANDS\`. These libraries won't be rebuilt without this being specified. If you believe this is in error, then please write a comment explaining why and ignore this suggestion. This comment will be automatically updated if rectified."
if [[ ${PR_EXISTING_NOTICE_ID:-0} == 0 ]]; then
    PR_EXISTING_NOTICE_ID=""
fi

ANGRY_COMMENT=false
if [ "${#NATIVE_LIBRARY_APPLICABLE_SHORTHANDS_ARRAY[@]}" -gt "${#NATIVE_LIBRARY_USER_REFERENCED_SHORTHANDS_ARRAY[@]}" ]; then
   ANGRY_COMMENT=true
else
   COMMENT="All native library builds modified in this PR shall attempt to be built by CI."
fi

echo "matrix_strategy<<EOF" >> $GITHUB_OUTPUT
echo "[" >> $GITHUB_OUTPUT
json_open="{"
for item in $NATIVE_LIBRARY_USER_REFERENCED_SHORTHANDS; do
  i=0
  for target in ${NATIVE_LIBRARY_SHORTHANDS_ARRAY[@]}; do
    if [[ "$target" == "$item" ]]; then
      shopt -s nullglob
      for runtime_script in "../../../${NATIVE_LIBRARY_PATHS_ARRAY[$i]}"/build-*.*; do
        runtime="$(basename "$runtime_script")"
        runtime="${runtime:6}" # trim build- prefix
        runtime="${runtime%.*}" # remove extension
        echo "$json_open" >> $GITHUB_OUTPUT
        json_open=",{"
        echo "  \"target\": \"$target\"," >> $GITHUB_OUTPUT
        echo "  \"runtime\": \"$runtime\"," >> $GITHUB_OUTPUT
        # :9 trim ../../../ prefix
        echo "  \"exec\": \"$(basename "$runtime_script")\"," >> $GITHUB_OUTPUT
        echo "  \"dir\": \"$(dirname "${runtime_script:9}")\"" >> $GITHUB_OUTPUT
        echo "}" >> $GITHUB_OUTPUT
      done
    fi
    i=$(expr $i + 1)
  done
done
echo "]" >> $GITHUB_OUTPUT
echo EOF >> $GITHUB_OUTPUT
if [[ $PR_EXISTING_NOTICE_ID != 0 && $PR_EXISTING_NOTICE_ID != "" || $ANGRY_COMMENT == true ]]; then
    echo "comment_to_write=$COMMENT" >> $GITHUB_OUTPUT
fi
