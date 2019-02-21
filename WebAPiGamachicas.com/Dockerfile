FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["WebAPiGamachicas.com/WebAPiGamachicas.com.csproj", "WebAPiGamachicas.com/"]
RUN dotnet restore "WebAPiGamachicas.com/WebAPiGamachicas.com.csproj"
COPY . .
WORKDIR "/src/WebAPiGamachicas.com"
RUN dotnet build "WebAPiGamachicas.com.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WebAPiGamachicas.com.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebAPiGamachicas.com.dll"]