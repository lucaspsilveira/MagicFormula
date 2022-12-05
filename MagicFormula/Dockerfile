FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MagicFormula/MagicFormula.csproj", "MagicFormula/"]
RUN dotnet restore "MagicFormula/MagicFormula.csproj"
COPY . .
WORKDIR "/src/MagicFormula"
RUN dotnet build "MagicFormula.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MagicFormula.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MagicFormula.dll"]
