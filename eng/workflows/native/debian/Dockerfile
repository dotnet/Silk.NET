# Docker is used to ensure that builds work the same locally as in Github Actions
# Debian is used instead of Ubuntu since it's easier to install multiarch packages with Debian
FROM debian:latest

WORKDIR /data/setup

# Shared dependencies
RUN apt-get update && apt-get install -y curl libicu-dev git cmake make ninja-build python3 unzip build-essential pkg-config ninja-build

# Git
RUN git config --global --add safe.directory "*"

# .NET
ENV DOTNET_ROOT="/root/.dotnet"
ENV PATH="${DOTNET_ROOT}:${DOTNET_ROOT}/tools:${PATH}"
RUN curl -fsSL https://dot.net/v1/dotnet-install.sh | bash

# PowerShell
# TODO: PowerShell is pinned to `--version "7.6.*"` because of https://github.com/PowerShell/PowerShell/issues/28392
RUN dotnet tool install --global PowerShell --version "7.6.*"

# Android
ENV ANDROID_HOME="/data/setup/android-sdk"
COPY dependencies/android.ps1 android.ps1
RUN ./android.ps1

# Zig
ENV PATH="$PATH:/data/setup/zig"
COPY dependencies/download-zig.py download-zig.py
RUN ./download-zig.py

WORKDIR /data
CMD ["pwsh"]
