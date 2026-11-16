FROM debian:latest

# Shared dependencies
RUN apt-get update && apt-get install -y curl libicu-dev git cmake make ninja-build python3 unzip build-essential pkg-config ninja-build

# .NET
ENV DOTNET_ROOT="/root/.dotnet"
ENV PATH="${DOTNET_ROOT}:${DOTNET_ROOT}/tools:${PATH}"
RUN curl -fsSL https://dot.net/v1/dotnet-install.sh | bash

# PowerShell
# TODO: PowerShell is pinned to `--version "7.6.*"` because of https://github.com/PowerShell/PowerShell/issues/28392
RUN dotnet tool install --global PowerShell --version "7.6.*"

# Git
RUN git config --global --add safe.directory "*"

WORKDIR /data
CMD ["pwsh"]
