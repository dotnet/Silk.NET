#!/usr/bin/env -S bash -eu
. workflow-common.sh
delim=""
UNIQUE_TARGETS="["
WORKFLOW_FILTERS=""

# Get the paths for the workflow filter action. 
echo "workflow_filters<<EOF" >> $GITHUB_OUTPUT
for item in $NATIVE_LIBRARY_UNIQUE_SHORTHANDS; do
  # Add this to the unique_targets output array
  UNIQUE_TARGETS="$UNIQUE_TARGETS$delim\"$item\""
  delim=", "

  # Add the submodule paths and a glob for the native folder to the workflow filters
  workflow_filter="$item: ["
  i=0
  filter_delim=""
  for target in ${NATIVE_LIBRARY_SHORTHANDS_ARRAY[@]}; do
    if [[ "$target" == "$item" ]]; then
      workflow_filter="$workflow_filter$filter_delim\"${NATIVE_LIBRARY_PATHS_ARRAY[$i]}/*\", \"${NATIVE_LIBRARY_SUBMODULE_PATHS_ARRAY[$i]}\""
      filter_delim=", "
    fi
    i=$(expr $i + 1)
  done
  echo "$workflow_filter]" >> $GITHUB_OUTPUT
done
echo EOF >> $GITHUB_OUTPUT
echo "unique_targets=$UNIQUE_TARGETS]" >> $GITHUB_OUTPUT

# Get a list of targets referenced by the user - we won't build anything we're not asked to build, but at the same time
# we want to yell at them (in stage 2) if they've built something they've gone and modified.
TARGETS_REFERENCED="["
ref_delim=""
while read line
do
  for item in $NATIVE_LIBRARY_UNIQUE_SHORTHANDS; do
    if [[ ${line,,} =~ ^/build-native.*[[:space:]]${item,,}([[:space:]].*)?$ ]]; then
      TARGETS_REFERENCED="$TARGETS_REFERENCED$ref_delim\"$item\""
      ref_delim=", "
      continue
    fi
  done
done <<< "$PR_COMMENT"
echo "targets_referenced=$TARGETS_REFERENCED]" >> $GITHUB_OUTPUT
