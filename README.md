# Console Chat com SignalR

Este é um projeto de exemplo que demonstra a comunicação em tempo real entre dois consoles através do SignalR usando uma API .NET separada.

## Funcionalidades

- Dois consoles podem se conectar à API do SignalR e trocar mensagens em tempo real.
- As mensagens enviadas por um console são exibidas no outro console.

## Pré-requisitos

- .NET Core SDK
- Node.js

## Executando a aplicação

### API SignalR

1. Navegue até o diretório `ApiSignalR`, restaure as dependencias e execute o projeto:

dotnet restore
dotnet run

2. Realize as mesmas etapas para o `ConsoleA` e `ConsoleB`.

## Como funciona

1. Os consoles clientes A e B se conectam à API do SignalR através de um endpoint.
2. Quando um console cliente envia uma mensagem, a mensagem é enviada para a API do SignalR e, em seguida, distribuída para todos os outros consoles clientes conectados.
3. As mensagens recebidas são exibidas nos consoles clientes.
