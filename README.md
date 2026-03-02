INSURANCE POLICY API
Geração de Apólice de Seguro Automotivo
Arquitetura Profissional – Padrão Fintech

VISÃO GERAL

A Insurance Policy API é um serviço REST desenvolvido em ASP.NET Core 8 responsável pela geração de números de apólice para seguro automotivo.

O sistema foi projetado seguindo boas práticas de arquitetura utilizadas em ambientes financeiros de alta confiabilidade, priorizando:

Escalabilidade

Stateless Design

Clareza de domínio

Separação de responsabilidades

Facilidade de evolução para ambiente enterprise

Produto suportado:
Seguro Automóvel
Código do Produto: 215

REGRA DE NEGÓCIO

A API gera um número de apólice no seguinte formato:

[CODIGO_PRODUTO]-[ANO]-[IDENTIFICADOR_UNICO]

Exemplo:

215-2026-A8F3C9D2

Campos:

215 -> Código fixo do produto (Seguro Automóvel)
2026 -> Ano corrente (UTC)
A8F3C9D2 -> Identificador único baseado em GUID reduzido

Características:

Identificador único

Seguro para alta concorrência

Stateless

Fácil auditoria

Pronto para evolução para numeração sequencial transacional

ARQUITETURA

O projeto segue uma estrutura simples, porém alinhada com princípios de engenharia profissional:

Camadas:

Controller (Camada HTTP)

Service (Regra de Negócio)

Model (Contrato de resposta)

Infraestrutura (Docker)

Princípios aplicados:

Single Responsibility

Separation of Concerns

API First

Stateless Service

12-Factor App (parcialmente aplicado)

Fluxo da requisição:

Cliente -> HTTP -> Controller -> Service -> Resposta JSON

TECNOLOGIAS UTILIZADAS

.NET 8

ASP.NET Core Web API

C#

Swagger / OpenAPI

Docker

Kestrel

ENDPOINT DISPONÍVEL

GET /api/apolices/gerar

Exemplo de requisição:

GET http://localhost:5000/api/apolices/gerar

Exemplo de resposta:

{
"numeroApolice": "215-2026-A8F3C9D2",
"codigoProduto": 215
}

EXECUÇÃO LOCAL

Restaurar dependências:
dotnet restore

Executar aplicação:
dotnet run

Acessar:
https://localhost:5001/swagger

EXECUÇÃO COM DOCKER

Build da imagem:

docker build -t insurance-policy-api .

Executar container:

docker run -p 5000:8080 insurance-policy-api

A API ficará disponível em:

http://localhost:5000

Swagger:
http://localhost:5000/swagger

PRONTIDÃO PARA EVOLUÇÃO

Este projeto foi estruturado para permitir evolução natural para cenários financeiros mais complexos.

Possíveis evoluções:

Nível Intermediário:

Persistência em SQL Server ou PostgreSQL

Numeração sequencial controlada

Health Checks

Logging estruturado (Serilog)

Testes unitários com xUnit

Nível Enterprise:

Clean Architecture

Domain Driven Design (DDD)

Event Driven Architecture

Outbox Pattern

RabbitMQ ou Kafka

Idempotency Key

JWT Authentication

OpenTelemetry

Prometheus e Grafana

Kubernetes (HPA)

CONTEXTO FINANCEIRO

Em um cenário real de fintech ou seguradora digital, este serviço pode atuar como:

Core Service de emissão de apólices

Serviço integrado a Core Banking

Microserviço integrado a sistema antifraude

Serviço integrado a sistema de cobrança

Serviço exposto via API Gateway

OBJETIVO DO PROJETO

Este projeto foi desenvolvido como demonstração de:

Arquitetura REST profissional

Organização de código backend

Preparação para ambientes financeiros

Containerização com Docker

Boas práticas de engenharia

Autor:
Thiago Schultz

Projeto desenvolvido para portfólio técnico e demonstração de arquitetura backend aplicada a contexto financeiro.
