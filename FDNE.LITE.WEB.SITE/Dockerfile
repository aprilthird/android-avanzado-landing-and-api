FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["FDNE.LITE.WEB.SITE/FDNE.LITE.WEB.SITE.csproj", "FDNE.LITE.WEB.SITE/"]
RUN dotnet restore "FDNE.LITE.WEB.SITE/FDNE.LITE.WEB.SITE.csproj"
COPY . .
WORKDIR "/src/FDNE.LITE.WEB.SITE"
RUN dotnet build "FDNE.LITE.WEB.SITE.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "FDNE.LITE.WEB.SITE.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FDNE.LITE.WEB.SITE.dll"]