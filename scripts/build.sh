#!/bin/bash

SOURCE="${BASH_SOURCE[0]}"
while [ -h "$SOURCE" ]; do # resolve $SOURCE until the file is no longer a symlink
  ScriptRoot="$( cd -P "$( dirname "$SOURCE" )" && pwd )"
  SOURCE="$(readlink "$SOURCE")"
  [[ $SOURCE != /* ]] && SOURCE="$ScriptRoot/$SOURCE" # if $SOURCE was a relative symlink, we need to resolve it relative to the path where the symlink file was located
done
ScriptRoot="$( cd -P "$( dirname "$SOURCE" )" && pwd )"

architecture=''
build=false
ci=false
configuration='Debug'
help=false
pack=false
restore=false
solution=''
test=false
verbosity='minimal'
properties=''

while [[ $# -gt 0 ]]; do
  lower="$(echo "$1" | awk '{print tolower($0)}')"
  case $lower in
    --architecture)
      architecture=$2
      shift 2
      ;;
    --build)
      build=true
      shift 1
      ;;
    --ci)
      ci=true
      shift 1
      ;;
    --configuration)
      configuration=$2
      shift 2
      ;;
    --help)
      help=true
      shift 1
      ;;
    --pack)
      pack=true
      shift 1
      ;;
    --restore)
      restore=true
      shift 1
      ;;
    --solution)
      solution=$2
      shift 2
      ;;
    --test)
      test=true
      shift 1
      ;;
    --verbosity)
      verbosity=$2
      shift 2
      ;;
    *)
      properties="$properties $1"
      shift 1
      ;;
  esac
done

function Build {
  logFile="$LogDir/$configuration/build.binlog"

  if [[ -z "$properties" ]]; then
    dotnet build -c "$configuration" --no-restore -v "$verbosity" /bl:"$logFile" /err "$solution"
  else
    dotnet build -c "$configuration" --no-restore -v "$verbosity" /bl:"$logFile" /err "${properties[@]}" "$solution"
  fi

  LASTEXITCODE=$?

  if [ "$LASTEXITCODE" != 0 ]; then
    echo "'Build' failed for '$solution'"
    return "$LASTEXITCODE"
  fi
}

function CreateDirectory {
  if [ ! -d "$1" ]
  then
    mkdir -p "$1"
  fi
}

function Help {
  echo "Common settings:"
  echo "  --configuration <value>   Build configuration (Debug, Release)"
  echo "  --verbosity <value>       Msbuild verbosity (q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic])"
  echo "  --help                    Print help and exit"
  echo ""
  echo "Actions:"
  echo "  --restore                 Restore dependencies"
  echo "  --build                   Build solution"
  echo "  --test                    Run all tests in the solution"
  echo "  --pack                    Package build artifacts"
  echo ""
  echo "Advanced settings:"
  echo "  --solution <value>        Path to solution to build"
  echo "  --ci                      Set when running on CI server"
  echo "  --architecture <value>    Test Architecture (<auto>, amd64, x64, x86, arm64, arm)"
  echo ""
  echo "Command line arguments not listed above are passed through to MSBuild."
}

function Pack {
  logFile="$LogDir/$configuration/pack.binlog"

  if [[ -z "$properties" ]]; then
    dotnet pack -c "$configuration" --no-build --no-restore -v "$verbosity" /bl:"$logFile" /err "$solution"
  else
    dotnet pack -c "$configuration" --no-build --no-restore -v "$verbosity" /bl:"$logFile" /err "${properties[@]}" "$solution"
  fi

  LASTEXITCODE=$?

  if [ "$LASTEXITCODE" != 0 ]; then
    echo "'Build' failed for '$solution'"
    return "$LASTEXITCODE"
  fi
}

function Restore {
  logFile="$LogDir/$configuration/restore.binlog"

  if [[ -z "$properties" ]]; then
    dotnet restore -v "$verbosity" /bl:"$logFile" /err "$solution"
  else
    dotnet restore -v "$verbosity" /bl:"$logFile" /err "${properties[@]}" "$solution"
  fi

  LASTEXITCODE=$?

  if [ "$LASTEXITCODE" != 0 ]; then
    echo "'Restore' failed for '$solution'"
    return "$LASTEXITCODE"
  fi
}

function Test {
  logFile="$LogDir/$configuration/test.binlog"

  if [[ -z "$properties" ]]; then
    dotnet test -c "$configuration" --no-build --no-restore -v "$verbosity" /bl:"$logFile" /err "$solution"
  else
    dotnet test -c "$configuration" --no-build --no-restore -v "$verbosity" /bl:"$logFile" /err "${properties[@]}" "$solution"
  fi

  LASTEXITCODE=$?

  if [ "$LASTEXITCODE" != 0 ]; then
    echo "'Test' failed for '$solution'"
    return "$LASTEXITCODE"
  fi
}

if $help; then
  Help
  exit 0
fi

if $ci; then
  build=true
  pack=true
  restore=true
  test=true

  if [[ -z "$architecture" ]]; then
    architecture="<auto>"
  fi
fi

RepoRoot="$ScriptRoot/.."

if [[ -z "$solution" ]]; then
  solution="$RepoRoot/$NewRepo.sln"
fi

ArtifactsDir="$RepoRoot/artifacts"
CreateDirectory "$ArtifactsDir"

LogDir="$ArtifactsDir/log"
CreateDirectory "$LogDir"

if [[ ! -z "$architecture" ]]; then
  DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1

  DotNetInstallScript="$ArtifactsDir/dotnet-install.ps1"
  wget -O "$DotNetInstallScript" "https://dot.net/v1/dotnet-install.sh"

  DotNetInstallDirectory="$ArtifactsDir/dotnet"
  CreateDirectory "$DotNetInstallDirectory"

  . "$DotNetInstallScript" --channel release/3.0.1xx --version latest --install-dir "$DotNetInstallDirectory" --architecture "$architecture"
  . "$DotNetInstallScript" --channel 2.1 --version latest --install-dir "$DotNetInstallDirectory" --architecture "$architecture" --runtime dotnet

  PATH="$DotNetInstallDirectory:$PATH:"
fi

if $restore; then
  Restore

  if [ "$LASTEXITCODE" != 0 ]; then
    return "$LASTEXITCODE"
  fi
fi

if $build; then
  Build

  if [ "$LASTEXITCODE" != 0 ]; then
    return "$LASTEXITCODE"
  fi
fi

if $test; then
  Test

  if [ "$LASTEXITCODE" != 0 ]; then
    return "$LASTEXITCODE"
  fi
fi

if $pack; then
  Pack

  if [ "$LASTEXITCODE" != 0 ]; then
    return "$LASTEXITCODE"
  fi
fi
