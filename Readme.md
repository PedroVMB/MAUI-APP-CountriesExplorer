
# CountriesExplorer

Aplicativo mobile desenvolvido em **.NET MAUI** que permite explorar informações sobre países do mundo utilizando a [REST Countries API](https://restcountries.com/).  

O app apresenta uma lista de países com bandeira, nome e capital, e uma tela de detalhes mostrando informações mais completas, como capital, região e moedas.

---

## Funcionalidades

- Tela principal exibindo todos os países com:
  - Bandeira
  - Nome
  - Capital
- Tela de detalhes com:
  - Bandeira maior
  - Nome comum e oficial
  - Capital
  - Região
  - Moedas
- Navegação usando **Shell Pages** e passagem de parâmetros via **QueryProperty**.
- Tratamento de valores nulos (capital ou moedas ausentes) para evitar crashes.

---

## Estrutura do Projeto
```bash
CountriesExplorer/
├── CountriesExplorer.App # Projeto MAUI (UI)
├── CountriesExplorer.Core # Modelos e interfaces
├── CountriesExplorer.Services # Serviços de acesso à API
└── CountriesExplorer.sln
```


- **App**: Contém Views, ViewModels, AppShell e configuração de DI.  
- **Core**: Contém modelos (`Country`, `Name`, `Flags`, `Currency`) e interfaces (`ICountryServices`).  
- **Services**: Implementa `CountryServices` para consumir a API pública.

---

## Tecnologias e Padrões

- [.NET MAUI](https://learn.microsoft.com/dotnet/maui/overview) (UI multiplataforma)
- **MVVM** (Model-View-ViewModel)
- **Dependency Injection** com `Microsoft.Extensions.DependencyInjection`
- **Shell Navigation** para telas e passagem de parâmetros
- `HttpClient` para consumo da API REST
- `CollectionView` para listagem de países

---

## Requisitos

- .NET 8 SDK  
- Visual Studio 2022 ou Rider com suporte a MAUI  
- Android/iOS simuladores ou dispositivos reais
- Conexão com a internet

---

## Como Executar

1. Clone o repositório:

```bash
git clone https://github.com/PedroVMB/CountriesExplorer.git
cd CountriesExplorer
````

Abra a solução CountriesExplorer.sln no Visual Studio ou Rider.

Restaure os pacotes NuGet:

```bash

dotnet restore
```
Escolha a plataforma alvo (Android ou iOS) e compile:

```bash
Android: Ctrl + F5 ou via toolbar
iOS: Cmd + R no Mac com simulador selecionado
````

Observações:

No Android, certifique-se de ter a permissão de Internet no AndroidManifest.xml:

```xml

<uses-permission android:name="android.permission.INTERNET" />
```
No iOS, o Shell Navigation exige que a página de detalhes tenha construtor sem parâmetros e utilize [QueryProperty] para receber dados.

Para evitar crashes em países sem capital ou sem moedas, utilizei propriedades calculadas no CountryDetailViewModel.

Estrutura de DI (Dependency Injection)
No MauiProgram.cs:

```csharp

builder.Services.AddSingleton<HttpClient>();
builder.Services.AddSingleton<ICountryServices, CountryServices>();
builder.Services.AddTransient<CountriesViewModel>();
builder.Services.AddTransient<CountriesPage>();
builder.Services.AddTransient<CountryDetailPage>();
builder.Services.AddTransient<CountryDetailViewModel>();
```

Contato / Suporte

Para dúvidas ou sugestões, abra uma issue no GitHub ou entre em contato pelo email: pedromb.dev@gmail.com.