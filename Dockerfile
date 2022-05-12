# base runtime image (Debian 11 w/ .NET6 runtime)
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

# install necessary packages
RUN apt update \
    && apt install -y libgdiplus libxkbcommon-x11-0 libc6 libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libxrender1 libfontconfig1 libxshmfence1

COPY ./Example/publish ./

ENTRYPOINT ["dotnet", "Example.dll"]
